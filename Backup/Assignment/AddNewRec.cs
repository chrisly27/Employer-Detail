using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AddNewRec : Form
    {
        public AddNewRec()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DisplayRec newform = new DisplayRec();
            this.Close();
            newform.ShowDialog();
        }

        private void AddEmp_Load(object sender, EventArgs e)
        {
            txtResident.Enabled = false;
            txtCoachName.Enabled = false;
            txtRecentEvents.Enabled = false;
            txtTShirt.Enabled = false;
            txtPosition.Enabled = false;
            txtTeam.Enabled = false;
            txtSalary.Enabled = true;
            txtFines.Enabled = false;
            txtN_DaysOff.Enabled = true;
        }

        private void rdoFootballer_CheckedChanged(object sender, EventArgs e)
        {
            txtResident.Enabled = false;
            txtCoachName.Enabled = false;
            txtRecentEvents.Enabled = false;
            txtTShirt.Enabled = true;
            txtPosition.Enabled = true;
            txtTeam.Enabled = true;
            txtN_DaysOff.Enabled = true;
            txtFines.Enabled = true;
            txtSalary.Enabled = true;
        }

        private void rdoSwimmer_CheckedChanged(object sender, EventArgs e)
        {
            txtResident.Enabled = true;
            txtCoachName.Enabled = true;
            txtRecentEvents.Enabled = true;
            txtTShirt.Enabled = false;
            txtPosition.Enabled = false;
            txtTeam.Enabled = false;
            txtN_DaysOff.Enabled = true;
            txtSalary.Enabled = true;
            txtFines.Enabled = false;
        }

        private void rdoPhysio_CheckedChanged(object sender, EventArgs e)
        {
            txtResident.Enabled = false;
            txtCoachName.Enabled = false;
            txtRecentEvents.Enabled = false;
            txtTShirt.Enabled = false;
            txtPosition.Enabled = false;
            txtTeam.Enabled = false;
            txtNationality.Enabled = false;
            txtDOB.Enabled = false;
            txtFines.Enabled = false;
            txtSalary.Enabled = true;
        }

        public IpayableStaff GetEmployee()
        {
            Athlete athlete = null;
            Physio physio = null;
            Footballers footballer = null;
            Swimmers swimmer = null;

            Boolean isAthlete = true;
            Boolean isPhysio = true;
            Boolean isFootbaler = true;
            Boolean isSwimmer = true;


            if (rdoFootballer.Checked == true)
            {
                if (    txtTitle.Text == "" || txtFirstname.Text == "" || txtSurname.Text == "" || txtNationality.Text == "" || txtNI.Text == "" || txtTaxRate.Text == ""
                        || txtTeam.Text == "" || txtPosition.Text == "" || txtTShirt.Text == "" || txtFines.Text == "" || txtSalary.Text == "" || txtDOB.Text == ""
                    )
                {
                    throw (new exception_blank_field());
                }
                else
                {
                    footballer = new Footballers(
                                                    txtTitle.Text, txtFirstname.Text, txtSurname.Text, txtNationality.Text,
                                                    txtNI.Text, Convert.ToInt32(txtN_DaysOff.Text), Convert.ToInt32(txtDOB.Text),
                                                    Convert.ToDouble(txtTaxRate.Text), Convert.ToDouble(txtSalary.Text), txtTeam.Text,
                                                    txtPosition.Text, Convert.ToInt32(txtTShirt.Text), Convert.ToDouble(txtFines.Text)
                                                 );
                    isAthlete = false;
                    isPhysio = false;
                    isSwimmer = false;
                }
            }
            else if (rdoSwimmer.Checked == true)
            {
                if (    txtTitle.Text == "" || txtFirstname.Text == "" || txtSurname.Text == "" || txtNationality.Text == "" || txtNI.Text == ""
                        || txtN_DaysOff.Text == "" || txtDOB.Text == "" || txtTaxRate.Text == "" || txtSalary.Text == "" ||txtResident.Text == "" 
                        || txtRecentEvents.Text == "" || txtCoachName.Text == ""
                    )
                {
                    throw (new exception_blank_field());
                }
                else
                {
                    swimmer = new Swimmers(
                                                txtTitle.Text, txtFirstname.Text, txtSurname.Text, txtNationality.Text, txtNI.Text,
                                                Convert.ToInt32(txtN_DaysOff.Text), Convert.ToInt32(txtDOB.Text), Convert.ToDouble(txtTaxRate.Text),
                                                Convert.ToDouble(txtSalary.Text), txtResident.Text, txtRecentEvents.Text, txtCoachName.Text
                                          );
                    isAthlete = false;
                    isPhysio = false;
                    isFootbaler = false;
                }
            }
            else if (rdoPhysio.Checked == true)
            {
                if (    txtTitle.Text =="" || txtFirstname.Text == "" || txtSurname.Text == "" || txtNI.Text == "" || 
                        txtN_DaysOff.Text == "" || txtTaxRate.Text == "" || txtSalary.Text == ""
                    )
                {
                    throw (new exception_blank_field());
                }
                else
                {
                    physio = new Physio(
                                        txtTitle.Text, txtFirstname.Text, txtSurname.Text, txtNI.Text, Convert.ToInt32(txtN_DaysOff.Text),
                                        Convert.ToDouble(txtTaxRate.Text), Convert.ToDouble(txtSalary.Text)
                                   );
                    isAthlete = false;
                    isSwimmer = false;
                    isFootbaler = false;
                }
            }
            else if (rdoDept.Checked == true)
            {
                throw ( new exception_select_dept());
            }

            //returning value
            if (isFootbaler)
            {
                return footballer;
            }
            else if (isSwimmer)
            {
                return swimmer;
            }
            else if (isPhysio)
            {
                return physio;
            }
            else
            {
                return athlete;
            }
        }
    }
}
