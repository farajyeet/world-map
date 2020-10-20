using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LiveCharts.WinForms.GeoMap geoMap = new LiveCharts.WinForms.GeoMap();
            Random random = new Random();
            Dictionary<string, double> values = new Dictionary<string, double>();
            values["CA"] = random.Next(0, 100);
            values["GB"] = random.Next(0, 100);
            values["US"] = random.Next(0, 100);
            values["FR"] = random.Next(0, 100);
            values["BG"] = random.Next(0, 100);
            values["CN"] = random.Next(0, 100);
            values["CY"] = random.Next(0, 100);
            values["HK"] = random.Next(0, 100);
            values["CH"] = random.Next(0, 100);
            values["TH"] = random.Next(0, 100);
            values["KR"] = random.Next(0, 100);
            values["JP"] = random.Next(0, 100);
            values["IT"] = random.Next(0, 100);
            values["IN"] = random.Next(0, 100);
            values["DE"] = random.Next(0, 100);
            values["RU"] = random.Next(0, 100);
            values["PE"] = random.Next(0, 100);
            values["ZA"] = random.Next(0, 100);
            geoMap.HeatMap = values;
            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;

        }
    }
}
