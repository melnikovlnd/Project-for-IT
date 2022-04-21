using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private TabPage page;
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                page = new TabPage(Convert.ToString(i));
                tabControl1.TabPages.Add(page);
            }

            {
                chart1.Series.Add(Convert.ToString(i));
                chart1.Series[i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                string s;
                if (i <= 0)
                {
                    return;
                }
                {
                    s = tabControl1.SelectedTab.Text;
                    chart1.Series.RemoveAt(Convert.ToInt32(tabControl1.SelectedTab.Text));
                    for(int i = Convert.ToInt32(s); i < chart1.Series.Count; ++i)
                    {
                        chart1.Series[i].Name = Convert.ToString(i);
                    }

                }
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                i--;
                int a = tabControl1.TabPages.Count - 1;
                int b = a;
                while (b >= 0)
                {
                    if (tabControl1.TabPages[b].Text != Convert.ToString(a))
                    {
                        tabControl1.TabPages[b].Text = Convert.ToString(a);
                    }
                    a--;
                    b--;
                }
            }
        }

        private void buildbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
