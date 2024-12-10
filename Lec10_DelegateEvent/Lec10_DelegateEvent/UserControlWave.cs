using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lec10_DelegateEvent
{
    public partial class UserControlWave : UserControl
    {
        public string WaveName
        {
            get => groupBoxName.Text;
        }
        public Color WaveColor
        {
            get => groupBoxName.ForeColor;
        }
        public double Amplitude
        {
            get => (double)numericUpDownAmplitude.Value;
        }
        public double Frequency
        {
            get => (double)numericUpDownFrequency.Value;
        }

        public delegate void delegateUserControlWave(UserControlWave sender);
        public delegateUserControlWave WaveChanged;

        public UserControlWave(string name, Decimal freq, Decimal amp, Color color)
        {
            InitializeComponent();
            groupBoxName.Text = name;
            groupBoxName.ForeColor = color;
            numericUpDownFrequency.Value = freq;
            numericUpDownAmplitude.Value = amp;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (WaveChanged != null)
            {
                WaveChanged(this);
            }
            //WaveChanged?.Invoke();
        }
    }
}
