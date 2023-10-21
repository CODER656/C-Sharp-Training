using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeFormApp
{
    public partial class EmployeeFormApp : Form
    {
        private readonly object txtID;

        public EmployeeFormApp()
        {
            InitializeComponent();
            //create new form and show
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo()
            {
                Surname = txtSurname.Text,
                otherNames = txtFirstName.Text,
                dateOfEmployment = DOE.Text,
                department = cmbDepart.Text,
                role = cmbRole.Text
            }; 



           int res = employeeInfo.employeeCreate(employeeInfo);

            if (res > 0) 
            {
                MessageBox.Show("Employee Saved Successfully");
            }
            else
            {
                MessageBox.Show("Employee not saved");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EmployeeInfo employeeInfo = new EmployeeInfo()
            {
                //id = int.Parse(txtID.Text.ToString()),
                Surname = txtSurname.Text,
                otherNames = txtFirstName.Text, 
                dateOfEmployment = DOE.Text, 
                department = cmbDepart.Text, 
                role = cmbRole.Text
            };

            int res = employeeInfo.employeeUpdate(employeeInfo);

            if (res > 0)
            {
                  MessageBox.Show("Employee Updated Successfully");
            }
            else
            {
                MessageBox.Show("Employee not Updated");
            }
        }

        /*private void Delete_Click(object sender, EventArgs e)
        {
            int idToDelete;
            if (int.TryParse(txtIDToDelete.Text, out idToDelete))
            {
                EmployeeInfo employeeInfo = new EmployeeInfo();
                int result = employeeInfo.employeeDelete(idToDelete);

                if (result > 0)
                {
                    MessageBox.Show("Employee Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Employee not Deleted");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID input");
            }

        }*/
    }
}
