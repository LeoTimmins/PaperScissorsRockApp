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
            this.TaskBarBG.Height = 50;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.TaskBarBG.Height = 50;
            this.TaskBarBG.Width = this.Width;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            int WinStat = 0;
            if (this.WindowState != FormWindowState.Minimized)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    WinStat = 1;
                }
                else
                {
                    WinStat = 2;
                }
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (WinStat == 1)
                {
                    this.WindowState = FormWindowState.Normal;
                }else if (WinStat == 2)
                {
                    this.WindowState= FormWindowState.Maximized;
                }
            }
        }
    }
}
