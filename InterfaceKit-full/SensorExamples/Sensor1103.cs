using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceKit_full.SensorExamples
{
    public partial class Sensor1103 : UserControl
    {
        public int sensorValue;
        public Sensor1103()
        {
            InitializeComponent();
        }

        public void changeDisplay(int val)
        {
            if (val < 100)
                textBox1.Text = "Object Detected";
            else
                textBox1.Text = "Object Not Detected";
        }

    }
}
