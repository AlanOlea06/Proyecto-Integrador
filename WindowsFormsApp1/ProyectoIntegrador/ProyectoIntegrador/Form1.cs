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
        public Form1()
        {
            InitializeComponent();
        }

        private void ALANgpt_Click(object sender, EventArgs e)
        {
          
            
                
            int cont = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(cont, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, dateTimePicker1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0) { }
            else
            {
                this.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                this.textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                this.textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                this.textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                this.dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
        }
    }
}
