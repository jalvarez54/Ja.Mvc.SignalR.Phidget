using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1128: UserControl
    {
        public int sensorValue;
        public Sensor1128()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            double tmp = val * 1.296;
            textBox1.Text = tmp.ToString("0.##") + "cm";
        }

    }
}
