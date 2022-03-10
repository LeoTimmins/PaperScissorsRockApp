using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperScissorsRockApp
{
    public partial class ViewPort : Form
    {
        public ViewPort()
        {
            InitializeComponent();
            this.TaskBarBG.Width = this.Width;
            this.TaskBarBG.Height = 30;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.TaskBarBG.Height = 30;
            this.TaskBarBG.Width = this.Width;
        }
    }
}
