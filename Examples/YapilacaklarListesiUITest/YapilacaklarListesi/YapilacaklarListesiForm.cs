using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapilacaklarListesi
{
    public partial class YapilacaklarListesiForm : Form
    {
        public YapilacaklarListesiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                textBox1.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Insert(listBox1.SelectedIndex, textBox1.Text);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                textBox1.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }
    }
}
