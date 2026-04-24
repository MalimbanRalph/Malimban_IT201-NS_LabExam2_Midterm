namespace Malimban_IT201_NS_LabExam2_Midterm
{
    partial class PosForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.changeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cashRenderedTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.totalDiscountedAmountTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalDiscountGivenTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.totalQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelNumpad = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBoxDiscounts = new System.Windows.Forms.GroupBox();
            this.noDiscountRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeDiscRadioButton = new System.Windows.Forms.RadioButton();
            this.discCardRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorCitizenRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBoxCalculated = new System.Windows.Forms.GroupBox();
            this.discountedAmountTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.discountAmountTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxOrderDetails = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            this.groupBoxSummary.SuspendLayout();
            this.panelNumpad.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBoxDiscounts.SuspendLayout();
            this.groupBoxCalculated.SuspendLayout();
            this.groupBoxOrderDetails.SuspendLayout();
            this.SuspendLayout();

            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(1184, 561);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;

            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPayment);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxSummary);
            this.splitContainer1.Panel1.Controls.Add(this.panelNumpad);
            this.splitContainer1.Panel1.Controls.Add(this.panelButtons);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDiscounts);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCalculated);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOrderDetails);

            this.splitContainer1.Panel2.Controls.Add(this.itemsPanel);
            this.splitContainer1.Panel2.Controls.Add(this.label1);

            this.groupBoxPayment.Controls.Add(this.label11);
            this.groupBoxPayment.Controls.Add(this.changeTextBox);
            this.groupBoxPayment.Controls.Add(this.label10);
            this.groupBoxPayment.Controls.Add(this.cashRenderedTextBox);
            this.groupBoxPayment.Location = new System.Drawing.Point(12, 480);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(570, 70);
            this.groupBoxPayment.TabIndex = 6;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Payment";

            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Change";

            this.changeTextBox.Location = new System.Drawing.Point(60, 42);
            this.changeTextBox.Name = "changeTextBox";
            this.changeTextBox.ReadOnly = true;
            this.changeTextBox.Size = new System.Drawing.Size(220, 20);
            this.changeTextBox.TabIndex = 2;

            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cash Rendered";

            this.cashRenderedTextBox.Location = new System.Drawing.Point(100, 16);
            this.cashRenderedTextBox.Name = "cashRenderedTextBox";
            this.cashRenderedTextBox.Size = new System.Drawing.Size(180, 20);
            this.cashRenderedTextBox.TabIndex = 0;

            this.groupBoxSummary.Controls.Add(this.totalDiscountedAmountTextBox);
            this.groupBoxSummary.Controls.Add(this.label9);
            this.groupBoxSummary.Controls.Add(this.totalDiscountGivenTextBox);
            this.groupBoxSummary.Controls.Add(this.label8);
            this.groupBoxSummary.Controls.Add(this.totalQuantityTextBox);
            this.groupBoxSummary.Controls.Add(this.label7);
            this.groupBoxSummary.Location = new System.Drawing.Point(12, 390);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(570, 84);
            this.groupBoxSummary.TabIndex = 5;
            this.groupBoxSummary.TabStop = false;
            this.groupBoxSummary.Text = "Summary";

            this.totalDiscountedAmountTextBox.Location = new System.Drawing.Point(280, 57);
            this.totalDiscountedAmountTextBox.Name = "totalDiscountedAmountTextBox";
            this.totalDiscountedAmountTextBox.ReadOnly = true;
            this.totalDiscountedAmountTextBox.Size = new System.Drawing.Size(150, 20);
            this.totalDiscountedAmountTextBox.TabIndex = 5;

            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Total Discounted";

            this.totalDiscountGivenTextBox.Location = new System.Drawing.Point(280, 37);
            this.totalDiscountGivenTextBox.Name = "totalDiscountGivenTextBox";
            this.totalDiscountGivenTextBox.ReadOnly = true;
            this.totalDiscountGivenTextBox.Size = new System.Drawing.Size(150, 20);
            this.totalDiscountGivenTextBox.TabIndex = 3;

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Discount %";

            this.totalQuantityTextBox.Location = new System.Drawing.Point(90, 17);
            this.totalQuantityTextBox.Name = "totalQuantityTextBox";
            this.totalQuantityTextBox.ReadOnly = true;
            this.totalQuantityTextBox.Size = new System.Drawing.Size(80, 20);
            this.totalQuantityTextBox.TabIndex = 1;

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Quantity";

            this.panelNumpad.Controls.Add(this.buttonEnter);
            this.panelNumpad.Controls.Add(this.buttonC);
            this.panelNumpad.Controls.Add(this.buttonDot);
            this.panelNumpad.Controls.Add(this.button0);
            this.panelNumpad.Controls.Add(this.button9);
            this.panelNumpad.Controls.Add(this.button8);
            this.panelNumpad.Controls.Add(this.button7);
            this.panelNumpad.Controls.Add(this.button6);
            this.panelNumpad.Controls.Add(this.button5);
            this.panelNumpad.Controls.Add(this.button4);
            this.panelNumpad.Controls.Add(this.button3);
            this.panelNumpad.Controls.Add(this.button2);
            this.panelNumpad.Controls.Add(this.button1);
            this.panelNumpad.Location = new System.Drawing.Point(370, 180);
            this.panelNumpad.Name = "panelNumpad";
            this.panelNumpad.Size = new System.Drawing.Size(212, 204);
            this.panelNumpad.TabIndex = 4;

            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnter.Location = new System.Drawing.Point(158, 177);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(51, 24);
            this.buttonEnter.TabIndex = 12;
            this.buttonEnter.Text = "ENTER";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.enterButton_Click);

            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(105, 177);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(51, 24);
            this.buttonC.TabIndex = 11;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;

            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(105, 151);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(51, 24);
            this.buttonDot.TabIndex = 10;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;

            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(52, 151);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(51, 24);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;

            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(158, 125);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 24);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;

            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(105, 125);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 24);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;

            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(52, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 24);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;

            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(158, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 24);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;

            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(105, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;

            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(52, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;

            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(158, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;

            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(105, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;

            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;

            this.panelButtons.Controls.Add(this.exitButton);
            this.panelButtons.Controls.Add(this.cancelButton);
            this.panelButtons.Controls.Add(this.newButton);
            this.panelButtons.Controls.Add(this.calculateButton);
            this.panelButtons.Location = new System.Drawing.Point(12, 180);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(352, 204);
            this.panelButtons.TabIndex = 3;

            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(178, 132);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(155, 54);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            this.cancelButton.BackColor = System.Drawing.Color.Orange;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(178, 68);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(155, 54);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "CANCEL";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

            this.newButton.BackColor = System.Drawing.Color.Lime;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(178, 5);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(155, 54);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "NEW";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);

            this.calculateButton.BackColor = System.Drawing.Color.Blue;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(10, 5);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(155, 191);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "CALCULATE";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            this.groupBoxDiscounts.Controls.Add(this.noDiscountRadioButton);
            this.groupBoxDiscounts.Controls.Add(this.employeeDiscRadioButton);
            this.groupBoxDiscounts.Controls.Add(this.discCardRadioButton);
            this.groupBoxDiscounts.Controls.Add(this.seniorCitizenRadioButton);
            this.groupBoxDiscounts.Location = new System.Drawing.Point(12, 88);
            this.groupBoxDiscounts.Name = "groupBoxDiscounts";
            this.groupBoxDiscounts.Size = new System.Drawing.Size(352, 88);
            this.groupBoxDiscounts.TabIndex = 2;
            this.groupBoxDiscounts.TabStop = false;
            this.groupBoxDiscounts.Text = "Discount Options";

            this.noDiscountRadioButton.AutoSize = true;
            this.noDiscountRadioButton.Checked = true;
            this.noDiscountRadioButton.Location = new System.Drawing.Point(262, 47);
            this.noDiscountRadioButton.Name = "noDiscountRadioButton";
            this.noDiscountRadioButton.Size = new System.Drawing.Size(80, 17);
            this.noDiscountRadioButton.TabIndex = 3;
            this.noDiscountRadioButton.TabStop = true;
            this.noDiscountRadioButton.Text = "No Discount";
            this.noDiscountRadioButton.UseVisualStyleBackColor = true;

            this.employeeDiscRadioButton.AutoSize = true;
            this.employeeDiscRadioButton.Location = new System.Drawing.Point(262, 20);
            this.employeeDiscRadioButton.Name = "employeeDiscRadioButton";
            this.employeeDiscRadioButton.Size = new System.Drawing.Size(88, 17);
            this.employeeDiscRadioButton.TabIndex = 2;
            this.employeeDiscRadioButton.Text = "Employee Disc";
            this.employeeDiscRadioButton.UseVisualStyleBackColor = true;

            this.discCardRadioButton.AutoSize = true;
            this.discCardRadioButton.Location = new System.Drawing.Point(94, 47);
            this.discCardRadioButton.Name = "discCardRadioButton";
            this.discCardRadioButton.Size = new System.Drawing.Size(109, 17);
            this.discCardRadioButton.TabIndex = 1;
            this.discCardRadioButton.Text = "With Disc. Card";
            this.discCardRadioButton.UseVisualStyleBackColor = true;

            this.seniorCitizenRadioButton.AutoSize = true;
            this.seniorCitizenRadioButton.Location = new System.Drawing.Point(10, 47);
            this.seniorCitizenRadioButton.Name = "seniorCitizenRadioButton";
            this.seniorCitizenRadioButton.Size = new System.Drawing.Size(91, 17);
            this.seniorCitizenRadioButton.TabIndex = 0;
            this.seniorCitizenRadioButton.Text = "Senior Citizen";
            this.seniorCitizenRadioButton.UseVisualStyleBackColor = true;

            this.groupBoxCalculated.Controls.Add(this.discountedAmountTextBox);
            this.groupBoxCalculated.Controls.Add(this.label6);
            this.groupBoxCalculated.Controls.Add(this.discountAmountTextBox);
            this.groupBoxCalculated.Controls.Add(this.label5);
            this.groupBoxCalculated.Location = new System.Drawing.Point(370, 88);
            this.groupBoxCalculated.Name = "groupBoxCalculated";
            this.groupBoxCalculated.Size = new System.Drawing.Size(212, 88);
            this.groupBoxCalculated.TabIndex = 1;
            this.groupBoxCalculated.TabStop = false;
            this.groupBoxCalculated.Text = "Calculated Fields";

            this.discountedAmountTextBox.Location = new System.Drawing.Point(120, 42);
            this.discountedAmountTextBox.Name = "discountedAmountTextBox";
            this.discountedAmountTextBox.ReadOnly = true;
            this.discountedAmountTextBox.Size = new System.Drawing.Size(82, 20);
            this.discountedAmountTextBox.TabIndex = 3;

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Discounted Amount";

            this.discountAmountTextBox.Location = new System.Drawing.Point(120, 20);
            this.discountAmountTextBox.Name = "discountAmountTextBox";
            this.discountAmountTextBox.ReadOnly = true;
            this.discountAmountTextBox.Size = new System.Drawing.Size(82, 20);
            this.discountAmountTextBox.TabIndex = 1;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Discount Amount";

            this.groupBoxOrderDetails.Controls.Add(this.priceTextBox);
            this.groupBoxOrderDetails.Controls.Add(this.label4);
            this.groupBoxOrderDetails.Controls.Add(this.quantityTextBox);
            this.groupBoxOrderDetails.Controls.Add(this.label3);
            this.groupBoxOrderDetails.Controls.Add(this.itemNameTextBox);
            this.groupBoxOrderDetails.Controls.Add(this.label2);
            this.groupBoxOrderDetails.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrderDetails.Name = "groupBoxOrderDetails";
            this.groupBoxOrderDetails.Size = new System.Drawing.Size(570, 70);
            this.groupBoxOrderDetails.TabIndex = 0;
            this.groupBoxOrderDetails.TabStop = false;
            this.groupBoxOrderDetails.Text = "Order Details";

            this.priceTextBox.Location = new System.Drawing.Point(447, 36);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(107, 20);
            this.priceTextBox.TabIndex = 5;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";

            this.quantityTextBox.Location = new System.Drawing.Point(231, 36);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(107, 20);
            this.quantityTextBox.TabIndex = 3;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";

            this.itemNameTextBox.Location = new System.Drawing.Point(87, 36);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.ReadOnly = true;
            this.itemNameTextBox.Size = new System.Drawing.Size(93, 20);
            this.itemNameTextBox.TabIndex = 1;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name of Item";

            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU ITEMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsPanel.Location = new System.Drawing.Point(0, 30);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.Size = new System.Drawing.Size(580, 531);
            this.itemsPanel.TabIndex = 1;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PosForm";
            this.Text = "4Jee POS - Point of Sale System";
            this.Load += new System.EventHandler(this.PosForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            this.groupBoxSummary.ResumeLayout(false);
            this.groupBoxSummary.PerformLayout();
            this.panelNumpad.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.groupBoxDiscounts.ResumeLayout(false);
            this.groupBoxDiscounts.PerformLayout();
            this.groupBoxCalculated.ResumeLayout(false);
            this.groupBoxCalculated.PerformLayout();
            this.groupBoxOrderDetails.ResumeLayout(false);
            this.groupBoxOrderDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox changeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox cashRenderedTextBox;
        private System.Windows.Forms.GroupBox groupBoxSummary;
        private System.Windows.Forms.TextBox totalDiscountedAmountTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalDiscountGivenTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalQuantityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelNumpad;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox groupBoxDiscounts;
        private System.Windows.Forms.RadioButton noDiscountRadioButton;
        private System.Windows.Forms.RadioButton employeeDiscRadioButton;
        private System.Windows.Forms.RadioButton discCardRadioButton;
        private System.Windows.Forms.RadioButton seniorCitizenRadioButton;
        private System.Windows.Forms.GroupBox groupBoxCalculated;
        private System.Windows.Forms.TextBox discountedAmountTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discountAmountTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxOrderDetails;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel itemsPanel;
    }
}
