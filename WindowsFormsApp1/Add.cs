using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpDataLayer;

namespace WindowsFormsApp1
{
    enum Mode
    {
        Add
        ,
        Update
    }
    public partial class Add : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private static Mode mode;
        private bool ValidateForm()
        {
            bool allValid = true;

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;

                    
                    if (textBox.Name == "textBoxSalary" || textBox.Name == "textBoxPhone")
                        continue;

                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        
                        errorProvider.SetError(textBox, $"{textBox.Name.Replace("textBox", "")} is required.");
                        allValid = false;
                    }
                    else
                    {
                        
                        errorProvider.SetError(textBox, "");
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(textBoxSalary.Text) || !float.TryParse(textBoxSalary.Text, out _))
            {
                errorProvider.SetError(textBoxSalary, "Please enter a valid salary (numeric value).");
                allValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxSalary, "");

            }if (string.IsNullOrWhiteSpace(textBoxPhone.Text) || !int.TryParse(textBoxPhone.Text, out _))
            {
                errorProvider.SetError(textBoxPhone, "Please enter a valid Phone (numeric value).");
                allValid = false;
            }
            else
            {
                errorProvider.SetError(textBoxPhone, "");
            }

            if (string.IsNullOrWhiteSpace(comboBoxMStatus.Text))
            {
                errorProvider.SetError(comboBoxMStatus, "Please select a marital status.");
                allValid = false;
            }
            else
            {
                errorProvider.SetError(comboBoxMStatus, "");
            }

            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                errorProvider.SetError(groupBoxGender, "Please select a gender.");
                allValid = false;
            }
            else
            {
                errorProvider.SetError(groupBoxGender, "");
            }

            if (dateTimePickerBirthDate.Value > DateTime.Now)
            {
                errorProvider.SetError(dateTimePickerBirthDate, "Birth date cannot be in the future.");
                allValid = false;
            }
            else
            {
                errorProvider.SetError(dateTimePickerBirthDate, "");
            }

            if (allValid)
            {
                return allValid;
            }
            else
            {
                MessageBox.Show("Please correct the errors in the form.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private string chkGender()
        {
            if (radioButtonMale.Checked)
                return "Male";
            else
                return "Female";
        }

        public Add()
        {
            InitializeComponent();
            mode = Mode.Add;
        }
        public Add(int ID, string Name, string Job, DateTime BirthDate, string Mstatus, string Email, string Phone, string Salary, string Department, string Gender)
        {
            InitializeComponent(); 

            label_ID.Visible = true;
            label_show_ID.Visible = true;

            label_show_ID.Text = ID.ToString();
            textBoxName.Text = Name;
            textBoxJob.Text = Job;
            dateTimePickerBirthDate.Value = BirthDate;
            comboBoxMStatus.Text = Mstatus;
            textBoxEmail.Text = Email;
            textBoxPhone.Text = Phone;
            textBoxSalary.Text = Salary;
            textBoxDepartment.Text = Department;

            if (Gender == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else if (Gender == "Female")
            {
                radioButtonFemale.Checked = true;
            }

            button1.Text = "Update";

            mode = Mode.Update;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Add)
            {
                if (ValidateForm())
                {
                    ClsData.Insert(textBoxName.Text, textBoxJob.Text, dateTimePickerBirthDate.Value, comboBoxMStatus.Text, textBoxEmail.Text, chkGender(), textBoxPhone.Text, float.Parse(textBoxSalary.Text), textBoxDepartment.Text);

                    MessageBox.Show("Done");

                    this.Close();

                }
            }
            else
            {
                if (ValidateForm())
                {
                    ClsData.Update(int.Parse(label_show_ID.Text),textBoxName.Text, textBoxJob.Text, dateTimePickerBirthDate.Value, comboBoxMStatus.Text, textBoxEmail.Text, chkGender(), textBoxPhone.Text, float.Parse(textBoxSalary.Text), textBoxDepartment.Text);

                    MessageBox.Show("Done");

                    this.Close();

                }
            }

        }
    }
}
