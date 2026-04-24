namespace Malimban_IT201_NS_LabExam2_Midterm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.posCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePosIncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePosOrderingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplePosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posAdministratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePosIncAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourJeePosOrderingAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userAccountPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegistrationPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posCashierToolStripMenuItem,
            this.posAdministratorToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            this.posCashierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourJeePosIncToolStripMenuItem,
            this.fourJeePosOrderingToolStripMenuItem,
            this.simplePosToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem});
            this.posCashierToolStripMenuItem.Name = "posCashierToolStripMenuItem";
            this.posCashierToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.posCashierToolStripMenuItem.Text = "POS Cashier";

            this.fourJeePosIncToolStripMenuItem.Name = "fourJeePosIncToolStripMenuItem";
            this.fourJeePosIncToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.fourJeePosIncToolStripMenuItem.Text = "4Jee POS Inc.";
            this.fourJeePosIncToolStripMenuItem.Click += new System.EventHandler(this.fourJeePosIncToolStripMenuItem_Click);

            this.fourJeePosOrderingToolStripMenuItem.Name = "fourJeePosOrderingToolStripMenuItem";
            this.fourJeePosOrderingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.fourJeePosOrderingToolStripMenuItem.Text = "4Jee POS Ordering";
            this.fourJeePosOrderingToolStripMenuItem.Click += new System.EventHandler(this.fourJeePosOrderingToolStripMenuItem_Click);

            this.simplePosToolStripMenuItem.Name = "simplePosToolStripMenuItem";
            this.simplePosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.simplePosToolStripMenuItem.Text = "Simple POS";
            this.simplePosToolStripMenuItem.Click += new System.EventHandler(this.simplePosToolStripMenuItem_Click);

            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);

            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);

            this.posAdministratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fourJeePosIncAdminToolStripMenuItem,
            this.fourJeePosOrderingAdminToolStripMenuItem,
            this.toolStripSeparator2,
            this.userAccountPageToolStripMenuItem});
            this.posAdministratorToolStripMenuItem.Name = "posAdministratorToolStripMenuItem";
            this.posAdministratorToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.posAdministratorToolStripMenuItem.Text = "POS Administrator";

            this.fourJeePosIncAdminToolStripMenuItem.Name = "fourJeePosIncAdminToolStripMenuItem";
            this.fourJeePosIncAdminToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.fourJeePosIncAdminToolStripMenuItem.Text = "4Jee POS Inc.";
            this.fourJeePosIncAdminToolStripMenuItem.Click += new System.EventHandler(this.fourJeePosIncAdminToolStripMenuItem_Click);

            this.fourJeePosOrderingAdminToolStripMenuItem.Name = "fourJeePosOrderingAdminToolStripMenuItem";
            this.fourJeePosOrderingAdminToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.fourJeePosOrderingAdminToolStripMenuItem.Text = "4Jee POS Ordering";
            this.fourJeePosOrderingAdminToolStripMenuItem.Click += new System.EventHandler(this.fourJeePosOrderingAdminToolStripMenuItem_Click);

            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);

            this.userAccountPageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountToolStripMenuItem});
            this.userAccountPageToolStripMenuItem.Name = "userAccountPageToolStripMenuItem";
            this.userAccountPageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.userAccountPageToolStripMenuItem.Text = "User Account";

            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.userAccountToolStripMenuItem.Text = "User Account Page";
            this.userAccountToolStripMenuItem.Click += new System.EventHandler(this.userAccountToolStripMenuItem_Click);

            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrollApplicationToolStripMenuItem,
            this.toolStripSeparator3,
            this.employeeInformationToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.payrollToolStripMenuItem.Text = "Payroll";

            this.payrollApplicationToolStripMenuItem.Name = "payrollApplicationToolStripMenuItem";
            this.payrollApplicationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.payrollApplicationToolStripMenuItem.Text = "Payroll Application";
            this.payrollApplicationToolStripMenuItem.Click += new System.EventHandler(this.payrollApplicationToolStripMenuItem_Click);

            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(197, 6);

            this.employeeInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegistrationPageToolStripMenuItem});
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";

            this.employeeRegistrationPageToolStripMenuItem.Name = "employeeRegistrationPageToolStripMenuItem";
            this.employeeRegistrationPageToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.employeeRegistrationPageToolStripMenuItem.Text = "Employee Registration Page";
            this.employeeRegistrationPageToolStripMenuItem.Click += new System.EventHandler(this.employeeRegistrationPageToolStripMenuItem_Click);

            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.cascadeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";

            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);

            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);

            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);

            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";

            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(152, 17);
            this.toolStripStatusLabel1.Text = "User Role: Administrator";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "4Jee POS System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem posCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePosIncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePosOrderingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplePosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posAdministratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePosIncAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourJeePosOrderingAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem userAccountPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegistrationPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}
