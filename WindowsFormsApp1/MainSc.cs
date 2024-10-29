using EmpDataLayer;
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
    public partial class MainSc : Form
    {
        RichTextBox Page = new RichTextBox();
        public void SetupPage(ref RichTextBox Page)
        {
            Page.Text = $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                        $"~~~~~~~~~~~~~~~~~~  Employee Info  ~~~~~~~~~~~~~~~~\n" +
                        $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                        $"ID : {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}\n" +
                        $"Name : {dataGridView1.SelectedRows[0].Cells[1].Value.ToString()}\n" +
                        $"Job : {dataGridView1.SelectedRows[0].Cells[2].Value.ToString()}\n" +
                        $"BirthDate : {dataGridView1.SelectedRows[0].Cells[3].Value.ToString()}\n" +
                        $"Mstatus : {dataGridView1.SelectedRows[0].Cells[4].Value.ToString()}\n" +
                        $"Email : {dataGridView1.SelectedRows[0].Cells[5].Value.ToString()}\n" +
                        $"Phone : {dataGridView1.SelectedRows[0].Cells[6].Value.ToString()}\n" +
                        $"Salary : {dataGridView1.SelectedRows[0].Cells[7].Value.ToString()}\n" +
                        $"Department : {dataGridView1.SelectedRows[0].Cells[8].Value.ToString()}\n" +
                        $"Gender : {dataGridView1.SelectedRows[0].Cells[9].Value.ToString()}\n" +
                        $"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
        }

        public void DataRefresh()
        {
            dataGridView1.DataSource = new DataView(ClsData.SelectAll());
        }

        public void ShowInfo()
        {

            label_show_ID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label_show_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label_show_Job.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            label_show_BirthDate.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            label_show_Mstatus.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            label_show_Email.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            label_show_Phone.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            label_show_Salary.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            label_show_Department.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            label_show_Gender.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

            button2.Enabled = true;
            button3.Enabled = true;
            button5.Enabled = true;
        }
        public MainSc()
        {
            InitializeComponent();
            DataRefresh();
            comboBoxFilter.SelectedIndex = 0;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add Addfrem = new Add();
            Addfrem.ShowDialog();
            DataRefresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBoxFilter.SelectedIndex == 0)
                try
                {
                    dataGridView1.DataSource = ClsData.FilterByID(int.Parse(textBox1.Text));
                }
                catch 
                {
                    MessageBox.Show("دخل رقم");
                }
            else
                dataGridView1.DataSource = ClsData.FilterByName(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add Updatefrem = new Add(int.Parse(label_show_ID.Text), label_show_Name.Text, label_show_Job.Text, DateTime.Parse(label_show_BirthDate.Text), label_show_Mstatus.Text, label_show_Email.Text, label_show_Phone.Text, label_show_Salary.Text, label_show_Department.Text, label_show_Gender.Text);
            Updatefrem.ShowDialog();
            DataRefresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClsData.Delete(int.Parse(label_show_ID.Text));
            DataRefresh();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(Page.Text, new Font("Tahoma", 15), Brushes.Black, 10, 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetupPage(ref Page);
            printPreviewDialog1.ShowDialog();
        }

    }
}
