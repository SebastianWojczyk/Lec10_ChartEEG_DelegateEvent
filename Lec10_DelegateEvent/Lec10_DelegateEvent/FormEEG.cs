using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lec10_DelegateEvent
{
    public partial class FormEEG : Form
    {
        public FormEEG()
        {
            InitializeComponent();


            UserControlWave alfa = new UserControlWave("Alfa", 10, 70, Color.Red);
            UserControlWave beta = new UserControlWave("Beta", 19, 20, Color.Green);
            UserControlWave gamma = new UserControlWave("Gamma", 70, 10, Color.Blue);

            alfa.WaveChanged += UserControlWave_WaveChanged;
            beta.WaveChanged += UserControlWave_WaveChanged;
            gamma.WaveChanged += UserControlWave_WaveChanged;

            drawWave(alfa);
            drawWave(beta);
            drawWave(gamma);

            flowLayoutPanelUserControlWaves.Controls.Add(alfa);
            flowLayoutPanelUserControlWaves.Controls.Add(beta);
            flowLayoutPanelUserControlWaves.Controls.Add(gamma);
        }

        void drawWave(UserControlWave wave)
        {
            Series s;
            if (chartEEG.Series.Count(x => x.Name == wave.WaveName) == 1)
            {
                s = chartEEG.Series.Single(x => x.Name == wave.WaveName);
                s.Points.Clear();
            }
            else
            {
                s = new Series(wave.WaveName);
                s.Color = wave.WaveColor;
                s.ChartType = SeriesChartType.Line;
                chartEEG.Series.Add(s);
            }

            for (double x = 0; x < 2*Math.PI; x += 0.01)
            {
                double y = Math.Sin(x * wave.Frequency) * wave.Amplitude;
                s.Points.AddXY(x, y);
            }

            drawSumWave();
        }

        private void drawSumWave()
        {
            Series sum;
            if (chartEEG.Series.Count(x => x.Name == "EEG") == 1)
            {
                sum = chartEEG.Series.Single(x => x.Name == "EEG");
                sum.Points.Clear();
            }
            else
            {
                sum = new Series("EEG");
                sum.ChartType = SeriesChartType.Line;
                sum.BorderWidth = 3;
                sum.Color = Color.Black;
                chartEEG.Series.Add(sum);
            }

            foreach (Series w in chartEEG.Series.Where(x => x.Name != "EEG"))
            {
                foreach (DataPoint p in w.Points)
                {
                    if (sum.Points.Count(a => a.XValue == p.XValue) == 1)
                    {
                        sum.Points.Single(a => a.XValue == p.XValue).YValues[0] += p.YValues[0];
                    }
                    else
                    {
                        sum.Points.AddXY(p.XValue, p.YValues[0]);
                    }
                }
            }
        }

        private void UserControlWave_WaveChanged(UserControlWave wave)
        {
            drawWave(wave);
        }
    }
}
