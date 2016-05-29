using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace clinic_db
{
    public partial class ChartControl : UserControl
    {
        private int _month;
        private int _year;
        private Chart _chart;
        private List<string> types;
        private List<KeyValuePair<string,int>> _data;
        private string[] months = {"january","february","march","april","may","june","july",
                                        "august", "september","october","november", "december"};
        
        
        
        public ChartControl()
        {
            InitializeComponent();
            _data = new List<KeyValuePair<string, int>>();
            _month = DateTime.Now.Month;
            _year = DateTime.Now.Year;
            string chartTitle = string.Format("Disease type distribution chart for {0} {1}",
                    months[_month - 1], _year);
            _chart = new Chart();
            _chart.Size = new System.Drawing.Size(700, 550);
            _chart.ChartAreas.Add(new ChartArea("clinic"));
            _chart.Series.Add(new Series("Disease"));
            _chart.Series[0].LegendText = "#VALX\n#VAL";
            _chart.Titles.Add(chartTitle);
            _chart.Titles[0].Font = new Font("Times new roman", 18);
            _chart.Legends.Add(new Legend("legend"));
            _chart.Legends[0].Alignment = StringAlignment.Near;
            _chart.Legends[0].Title = "Number of registered\ndiseases";
            _chart.Legends[0].TitleFont = new System.Drawing.Font("Times new roman", 14);
            _chart.Legends[0].Font = new System.Drawing.Font("Consolas", 13);
            _chart.Series[0].ChartArea = "clinic";

            FillDisributionChart();
            _chart.Show();
            this.Controls.Add(_chart);
        }
        public ChartControl(int startYear, int endYear)
        {
            InitializeComponent();
            types = DbConnector.GetInstance().GetDiseaseTypes().OrderBy(x => x.Name)
                .Select(x => x.Name).ToList();
            _data = new List<KeyValuePair<string, int>>();
            string chartTitle = string.Format("Dynamic of diseases count from year {0} to {1}",
                startYear.ToString(), endYear.ToString());
            _chart = new Chart();
            _chart.Size = new System.Drawing.Size(700, 550);
            _chart.ChartAreas.Add(new ChartArea("clinic"));
            _chart.Titles.Add(chartTitle);
            _chart.Titles[0].Font = new Font("Times new roman", 18);
            _chart.Legends.Add(new Legend("legend"));
            _chart.Legends[0].Alignment = StringAlignment.Near;
            _chart.Legends[0].Title = "Disease type";
            _chart.Legends[0].TitleFont = new System.Drawing.Font("Times new roman", 14);
            _chart.Legends[0].Font = new System.Drawing.Font("Consolas", 13);
            foreach (string type in types)
            {
                _chart.Series.Add(new Series(type));
                _chart.Series[type].ChartType = SeriesChartType.Column;
                _chart.Series[type].ChartArea = "clinic";
                _chart.Series[type].LegendText = "#SERIESNAME";
                _chart.Series[type].Label = "#VAL";
            }
            FillChangeChart(startYear, endYear);
            _chart.Show();
            this.Controls.Add(_chart);
        }
        private void FillDisributionChart()
        {
            _data = DbConnector.GetInstance().GetDiseaseDisribution();

            Series s = _chart.Series[0];
            s.ChartType = SeriesChartType.Pie;
            s.Font = new System.Drawing.Font("Consolas", 10);
            s.Label = "#VALX\n#PERCENT";
            _data.ForEach(x => s.Points.AddXY(x.Key, x.Value));
        }
        private void FillChangeChart(int start, int end)
        {
            DbConnector db = DbConnector.GetInstance();
            SeriesCollection s = _chart.Series;

            for (int i = start; i <= end; i++)
            {
                _data = db.GetDiseaseDisribution(i);
                for (int j = 0; j < _data.Count; j++)
                    s[_data[j].Key].Points.AddXY(i, _data[j].Value);
            }
        }

    }
}
