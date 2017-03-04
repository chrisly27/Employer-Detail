using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Assignment
{
    public partial class DisplayRec : Form
    {
        public DisplayRec()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Hide();
            Menu newform = new Menu();
            newform.ShowDialog();
        }

        List<IpayableStaff> employeeList = new List<IpayableStaff>();

        private const string filename = "employee.dat";

        private void DisplayEmp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            lstEmployees.Items.Clear();

            FileStream inFile;
            BinaryFormatter bformatter = new BinaryFormatter();

            if (File.Exists(filename))
            {
                inFile = new FileStream(filename, FileMode.Open, FileAccess.Read);

                while (inFile.Position < inFile.Length)
                {
                    IpayableStaff load = (IpayableStaff)bformatter.Deserialize(inFile);
                    employeeList.Add(load);
                    lstEmployees.Items.Add(load);
                }
                inFile.Close();
            }
        }

        private void SaveData()
        {
            FileStream outFile;
            BinaryFormatter bformatter = new BinaryFormatter();

            if (lstEmployees.Items.Count > 0)
            {
                outFile = new FileStream(filename, FileMode.Create, FileAccess.Write);

                foreach (IpayableStaff save in employeeList)
                {
                    bformatter.Serialize(outFile, save);
                }

                outFile.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<IpayableStaff> employeeSearch = new List<IpayableStaff>();
            string searchName = txtSearch.Text;

            foreach (IpayableStaff s in employeeList)
            {
                if (string.Compare(searchName, s.Surname) == 0)
                {
                    employeeSearch.Add(s);
                }
            }

            if (employeeSearch.Count != 0)
            {
                display(employeeSearch);
                txtSearch.Text = "";
            }

            else if (searchName == "")
            {
                MessageBox.Show("Yomessage.u must enter Surname in search box", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No name was found that matches " + searchName + " in data file.\nCheck your input you might be missing characters...", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearch.Text = "";
            }
        }

        private void display(List<IpayableStaff> displ)
        {
            lstEmployees.Items.Clear();

            for (int i = 0; i < displ.Count; i++)
            {
                IpayableStaff dis = (IpayableStaff)displ[i];

                lstEmployees.Items.Add(dis);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstEmployees.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Select an Employee from the list.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                employeeList.Remove(employeeList[index]);

                display(employeeList);
                SaveData();
            }
        }

        private void btnShowAllRecord_Click(object sender, EventArgs e)
        {
            lstEmployees.Items.Clear();
            display(employeeList);
        }

        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IndexName = lstEmployees.SelectedIndex;

            if (IndexName > -1)
            {
                IpayableStaff employeeDetails = employeeList[IndexName];
                lblStatement.Text = employeeDetails.ShowDetails();
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            AddNewRec newform = new AddNewRec();

            if (newform.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    IpayableStaff newEmployee = newform.GetEmployee();
                    employeeList.Add(newEmployee);
                    lstEmployees.Items.Clear();

                    foreach (IpayableStaff empo in employeeList)
                    {
                        lstEmployees.Items.Add(empo.ToString());
                    }
                    SaveData();
                }
                catch (exception_blank_field c)
                {
                    MessageBox.Show(c.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (exception_select_dept t)
                {
                    MessageBox.Show(t.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException d)
                {
                    MessageBox.Show(d.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
