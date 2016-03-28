using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Demo
{
    public partial class Slider : UserControl
    {

        public string ServoName
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }

        public int Value
        {
            get
            {
                if (track.InvokeRequired)
                {

                    return (int)Invoke((Func<int>)delegate { return Value; });
                }
                else
                {
                    return track.Value;
                }
            }
            set
            {
                track.Value = value;
            }
        }

        public Slider()
        {
            InitializeComponent();
        }
    }
}
