using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using HtmlAgilityPack;

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
            string[] ageGroup = new string[] { "14014", "15015", "16016", "17017", "18018", "19000" };
            int[] gender = new int[] { 1, 2 };

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    string[] distance = new string[URL(url.Replace("agegroup=0", "agegroup=" + ageGroup[j]).Replace("gender=1", "gender=" + gender[i])).Length];
                    distance = URL(url.Replace("agegroup=0", "agegroup=" + ageGroup[j]).Replace("gender=1", "gender=" + gender[i]));
                    for (int k = 0; k < 4; k++)
                    {
                        if (i == 0 && j == 0 && k == 0)
                        {
                            int[] inter = Rekords(distance[k]);
                            Rudolph_Points.Series["Rudolph_Points"].Points.AddXY("16-17", inter[0]);
                            Rudolph_Points.Series["Rudolph_Points"].Points.AddXY("17-18", inter[1]);
                            Rudolph_Points.Series["Rudolph_Points"].Points.AddXY("18-19", inter[2]);
                            Rudolph_Points.Series["Rudolph_Points"].Points.AddXY("19-20", inter[3]);
                        }
                        else if (i == 0 && j == 0 && k == 1)
                        {
                            int[] inter = Rekords(distance[k]);
                            Rudolph_Points2.Series["Rudolph_Points2"].Points.AddXY("16-17", inter[0]);
                            Rudolph_Points2.Series["Rudolph_Points2"].Points.AddXY("17-18", inter[1]);
                            Rudolph_Points2.Series["Rudolph_Points2"].Points.AddXY("18-19", inter[2]);
                            Rudolph_Points2.Series["Rudolph_Points2"].Points.AddXY("19-20", inter[3]);     
                        }
                        else if (i == 0 && j == 0 && k == 2)
                        {
                            int[] inter = Rekords(distance[k]);
                            Rudolph_Points3.Series["Rudolph_Points3"].Points.AddXY("16-17", inter[0]);
                            Rudolph_Points3.Series["Rudolph_Points3"].Points.AddXY("17-18", inter[1]);
                            Rudolph_Points3.Series["Rudolph_Points3"].Points.AddXY("18-19", inter[2]);
                            Rudolph_Points3.Series["Rudolph_Points3"].Points.AddXY("19-20", inter[3]);
                        }
                        else if (i == 0 && j == 0 && k == 3)
                        {
                            int[] inter = Rekords(distance[k]);
                            Rudolph_Points4.Series["Rudolph_Points4"].Points.AddXY("16-17", inter[0]);
                            Rudolph_Points4.Series["Rudolph_Points4"].Points.AddXY("17-18", inter[1]);
                            Rudolph_Points4.Series["Rudolph_Points4"].Points.AddXY("18-19", inter[2]);
                            Rudolph_Points4.Series["Rudolph_Points4"].Points.AddXY("19-20", inter[3]);
                            
                        }
                    }
                }
            }
        }

        public static string[] URL(string url)
        {
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(url).Result;

            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);
            var URLlink = htmlDocument.DocumentNode.SelectNodes("//td[@class='swimstyle']//a[@href]");
            var distance = htmlDocument.DocumentNode.SelectNodes("//td[@class='swimstyle']//a");
            string[] linki = new string[URLlink.Count];
            for (int i = 0; i < URLlink.Count; i++)
            {


                if (distance[i].InnerText == "50m Freestyle Lap" || distance[i].InnerText == "100m Freestyle Lap" || distance[i].InnerText == "200m Freestyle Lap"
                        || distance[i].InnerText == "50m Breaststroke Lap" || distance[i].InnerText == "100m Breaststroke Lap" || distance[i].InnerText == "50m Backstroke Lap" || distance[i].InnerText == "100m Backstroke Lap"
                        || distance[i].InnerText == "50m Butterfly Lap" || distance[i].InnerText == "100m Butterfly Lap" || distance[i].InnerText == "4 x 50m Freestyle" || distance[i].InnerText == "4 x 100m Freestyle"
                        || distance[i].InnerText == "4 x 50m Medley" || distance[i].InnerText == "4 x 100m Medley")
                {
                    //to wgl nie działa, musze to usunąć
                }
                else
                {
                    linki[i] = "https://www.swimrankings.net/index.php" + URLlink[i].GetAttributeValue("href", "").Replace("amp;", "") + "&points=rudolph_2023";
                    //tutaj muszę dodać, szukanie na kolejnych stronach
                }

            }
            return linki;
        }
        public static int[] Rekords(string dystans)
        {
            var httpClient = new HttpClient();
            var html = httpClient.GetStringAsync(dystans).Result;
            var htmlDocument = new HtmlAgilityPack.HtmlDocument();
            htmlDocument.LoadHtml(html);
            var distanceElement = htmlDocument.DocumentNode.SelectSingleNode("//td[@class='titleCenter']");
            var timeElement0 = htmlDocument.DocumentNode.SelectNodes("//tr[@class='rankingList0']//td[@class='time']");
            var timeElement1 = htmlDocument.DocumentNode.SelectNodes("//tr[@class='rankingList1']//td[@class='time']");
            var pointsElement0 = htmlDocument.DocumentNode.SelectNodes("//tr[@class='rankingList0']//td[@class='code']");
            var pointsElement1 = htmlDocument.DocumentNode.SelectNodes("//tr[@class='rankingList1']//td[@class='code']");
            var distance = distanceElement.InnerText.Trim();
            List<double> rudolphPoints = new List<double>();
            int[] counters = new int[4];
            int a = pointsElement0.Count + pointsElement1.Count;

            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    string dziwak = pointsElement0[i / 2].InnerText.Trim();
                    double inter = double.Parse(dziwak);
                    if (inter < 16)
                    {
                        inter = 0;
                        break;
                    }
                    else
                    {
                        rudolphPoints.Add(inter);
                        inter = 0;
                    }
                }
                else if (i == 1)
                {
                    string dziwak = pointsElement1[0].InnerText.Trim();
                    double inter = double.Parse(dziwak);
                    if (inter < 16)
                    {
                        inter = 0;
                        break;
                    }
                    else
                    {
                        rudolphPoints.Add(inter);
                        Console.WriteLine(rudolphPoints[1]);
                        inter = 0;
                    }
                }
                else if (i % 2 == 1)
                {
                    string dziwak = pointsElement1[i / 2].InnerText.Trim();
                    double inter = double.Parse(dziwak);
                    if (inter < 16)
                    {
                        inter = 0;
                        break;
                    }
                    else
                    {
                        rudolphPoints.Add(inter);
                        inter = 0;
                    }
                }
            }
            for (int i = 0; i < rudolphPoints.Count; i++)
            {
                if (rudolphPoints[i] < 16)
                {
                    break;
                }
                else if (rudolphPoints[i] < 17  && rudolphPoints[i] >= 16)
                {
                    counters[0]++;
                }
                else if (rudolphPoints[i] >= 17 && rudolphPoints[i] < 18)
                {
                    counters[1]++;
                }
                else if (rudolphPoints[i] >= 18 && rudolphPoints[i] < 19)
                {
                    counters[2]++;
                }
                else if (rudolphPoints[i] >= 19 && rudolphPoints[i] < 20)
                {
                    counters[3]++;
                }
            }
            return counters;
        }
    }
}
