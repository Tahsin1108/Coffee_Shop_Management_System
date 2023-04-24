using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Dessert Item 1");
            comboBox1.Items.Add("Dessert Item 2");
            comboBox1.Items.Add("Dessert Item 3");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Capucchino")
            {
                textBox1.Text = "100";
            }
            else if (comboBox1.SelectedItem.ToString() == "Cold Coffee")
            {
                {
                    textBox1.Text = "200";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Pastrami")
            {
                {
                    textBox1.Text = "500";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Dessert Item 1")
            {
                {
                    textBox1.Text = "300";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Dessert Item 2")
            {
                {
                    textBox1.Text = "500";
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Dessert Item 3")
            {
                {
                    textBox1.Text = "700";
                }
            }
            else
            {
                textBox1.Text = "0";
            }
            textBox3.Text = "";
            textBox2.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Capucchino");
            comboBox1.Items.Add("Cold Coffee");
            comboBox1.Items.Add("Pastrami");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox3.Text = (Convert.ToInt64(textBox1.Text) * Convert.ToInt64(textBox2.Text)).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //add
            dataGridView1.Rows.Add(comboBox1.Text, textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text);
            //sum
            textBox4.Text = (Convert.ToInt16(textBox4.Text) + Convert.ToInt16(textBox3.Text)).ToString();
            //delete
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //delete
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Selected)
                    {
                        textBox4.Text = (Convert.ToInt16(textBox4.Text) - Convert.ToInt16(dataGridView1.Rows[i].Cells[3].Value)).ToString();
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
