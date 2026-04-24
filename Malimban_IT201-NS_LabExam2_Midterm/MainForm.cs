using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malimban_IT201_NS_LabExam2_Midterm
{
    public partial class MainForm : Form
    {
        private string currentUserRole = "Administrator";
        private PosForm posFormInstance = null;
        private UserAccountForm userAccountFormInstance = null;
        private PayrollForm payrollFormInstance = null;
        private EmployeeRegistrationForm employeeRegistrationFormInstance = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplyRoles();
        }

        private void ApplyRoles()
        {
            var allMenuItems = new List<ToolStripItem>();
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                allMenuItems.Add(item);
            }

            posCashierToolStripMenuItem.Visible = false;
            posAdministratorToolStripMenuItem.Visible = false;
            payrollToolStripMenuItem.Visible = false;
            windowToolStripMenuItem.Visible = false;

            switch (currentUserRole)
            {
                case "Administrator":
                    posCashierToolStripMenuItem.Visible = true;
                    posAdministratorToolStripMenuItem.Visible = true;
                    windowToolStripMenuItem.Visible = true;
                    break;
                case "Cashier":
                    posCashierToolStripMenuItem.Visible = true;
                    windowToolStripMenuItem.Visible = true;
                    break;
                case "HR":
                    payrollToolStripMenuItem.Visible = true;
                    windowToolStripMenuItem.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void openPosForm()
        {
            if (posFormInstance == null || posFormInstance.IsDisposed)
            {
                posFormInstance = new PosForm();
                posFormInstance.MdiParent = this;
                posFormInstance.Show();
            }
            else
            {
                posFormInstance.BringToFront();
            }
        }

        private void openUserAccountForm()
        {
            if (userAccountFormInstance == null || userAccountFormInstance.IsDisposed)
            {
                userAccountFormInstance = new UserAccountForm();
                userAccountFormInstance.MdiParent = this;
                userAccountFormInstance.Show();
            }
            else
            {
                userAccountFormInstance.BringToFront();
            }
        }

        private void openPayrollForm()
        {
            if (payrollFormInstance == null || payrollFormInstance.IsDisposed)
            {
                payrollFormInstance = new PayrollForm();
                payrollFormInstance.MdiParent = this;
                payrollFormInstance.Show();
            }
            else
            {
                payrollFormInstance.BringToFront();
            }
        }

        private void openEmployeeRegistrationForm()
        {
            if (employeeRegistrationFormInstance == null || employeeRegistrationFormInstance.IsDisposed)
            {
                employeeRegistrationFormInstance = new EmployeeRegistrationForm();
                employeeRegistrationFormInstance.MdiParent = this;
                employeeRegistrationFormInstance.Show();
            }
            else
            {
                employeeRegistrationFormInstance.BringToFront();
            }
        }

        private void fourJeePosIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPosForm();
        }

        private void fourJeePosOrderingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPosForm();
        }

        private void simplePosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPosForm();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void fourJeePosIncAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPosForm();
        }

        private void fourJeePosOrderingAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPosForm();
        }

        private void userAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openUserAccountForm();
        }

        private void payrollApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openPayrollForm();
        }

        private void employeeRegistrationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openEmployeeRegistrationForm();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }
    }
}
