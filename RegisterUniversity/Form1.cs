using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterUniversity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calBtn_Click(object sender, EventArgs e)
        {
            int Total = 0;
            if (Trum1.Checked||Trum2.Checked)
            {
                Total += 4100;
            }
            else if (Trum3.Checked)
            {
                Total += 2800;
            }
            if (BIT121.Checked) Total += 1100;
            if (BIT121.Checked) Total += 1100;
            if (BIT121.Checked) Total += 1100;
            if (BIT211.Checked) Total += 1100;
            if (BIT199.Checked) Total += 1100;
            if (BIT118.Checked) Total += 1100;
            if (SOC118.Checked) Total += 1100;
            if (SOC122.Checked) Total += 1100;
            if (HUM120.Checked) Total += 1100;

            ResultBox.Text = Total.ToString();

        }

        private void BIT121_CheckedChanged(object sender, EventArgs e)
        {
            if (BIT121.Checked)
            {
               listBox.Items.Insert(listBox.Items.Count, BIT121.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(BIT121.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
            
        }

        private void BIT122_CheckedChanged(object sender, EventArgs e)
        {
            if (BIT122.Checked)
            {
                listBox.Items.Insert(listBox.Items.Count, BIT122.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(BIT122.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
        }

        private void BIT211_CheckedChanged(object sender, EventArgs e)
        {
            if (BIT211.Checked)
            {
                listBox.Items.Insert(listBox.Items.Count, BIT211.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(BIT211.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
        }

        private void BIT199_CheckedChanged(object sender, EventArgs e)
        {
            if (BIT199.Checked)
            {
                listBox.Items.Insert(listBox.Items.Count, BIT199.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(BIT199.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
        }

        private void SOC118_CheckedChanged(object sender, EventArgs e)
        {
            if (SOC118.Checked)
            {
                listBox.Items.Insert(listBox.Items.Count, SOC118.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(SOC118.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
        }

        private void SOC122_CheckedChanged(object sender, EventArgs e)
        {
            if (SOC122.Checked)
            {
                listBox.Items.Insert(listBox.Items.Count, SOC122.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(SOC122.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
        }

        private void BIT118_CheckedChanged(object sender, EventArgs e)
        {
            if (BIT118.Checked)
            {
                listBox.Items.Insert(listBox.Items.Count, BIT118.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(BIT118.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
        }

        private void HUM120_CheckedChanged(object sender, EventArgs e)
        {
            if (HUM120.Checked)
            {
                listBox.Items.Insert(listBox.Items.Count, HUM120.Text);
            }
            else
            {
                for (int n = listBox.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox.Items[n].ToString().Contains(HUM120.Text.ToString()))
                    {
                        listBox.Items.RemoveAt(n);
                    }
                }
            }
        }
    }
}
