using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://www.swimrankings.net/index.php?page=rankingDetail&clubId=291&gender=1&season=2023&course=LCM&stroke=0&agegroup=0&points=rudolph_2023";
            string[] ageGroup = new string[] { "14014", "15015", "16016", "17017", "18018", "19000", "0" };
            int[] gender = new int[] { 1, 2 };

            List<Series> seriesList = new List<Series> { Rudolph_Points.Series[0], Rudolph_Points2.Series[0], Rudolph_Points3.Series[0], Rudolph_Points4.Series[0] };

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    List<string> distance = ScrapingSystem.URL(url.Replace("agegroup=0", $"agegroup={ageGroup[j]}").Replace("gender=1", $"gender={gender[i]}"));

                    for (int k = 0; k < 4; k++)
                    {
                        List<int> rudolphPoints = Rekords(distance[k]);

                        seriesList[k].Points.AddXY("16-17", rudolphPoints[0]);
                        seriesList[k].Points.AddXY("17-18", rudolphPoints[1]);
                        seriesList[k].Points.AddXY("18-19", rudolphPoints[2]);
                        seriesList[k].Points.AddXY("19-20", rudolphPoints[3]);
                    }
                }
            }
        }
        public static List<int> Rekords(string dystans)
        {
            var htmlDocument = ScrapingSystem.Loader(dystans);
            string distance = htmlDocument.DocumentNode.SelectSingleNode("//td[@class='titleCenter']").InnerText.Trim();
            var pointsElement = htmlDocument.DocumentNode.SelectNodes("//td[@class='code']");
            List<int> rudolphPoints = new List<int> { 0, 0, 0, 0 };
            for (int i = 0; i < pointsElement.Count; i++)
            {
                if (!distance.Contains("Lap") && !distance.Contains("x"))
                {
                    rudolphPoints.Add((Convert.ToDouble(pointsElement[i].InnerText) <= 20 && Convert.ToDouble(pointsElement[i].InnerText) >= 19) ? 
                          rudolphPoints[3]++ : (Convert.ToDouble(pointsElement[i].InnerText) >= 18 && Convert.ToDouble(pointsElement[i].InnerText) < 19) ?
                          rudolphPoints[2]++ : (Convert.ToDouble(pointsElement[i].InnerText) >= 17 && Convert.ToDouble(pointsElement[i].InnerText) < 18) ? 
                          rudolphPoints[1]++ : (Convert.ToDouble(pointsElement[i].InnerText) < 17 && Convert.ToDouble(pointsElement[i].InnerText) >= 16) ? 
                          rudolphPoints[0]++ : rudolphPoints[0] += 0); 
;               }
            }
            return rudolphPoints;
        }
    }
}
