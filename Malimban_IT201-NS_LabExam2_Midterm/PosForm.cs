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
    public partial class PosForm : Form
    {
        private List<Panel> itemPanels = new List<Panel>();
        private TextBox currentFocusedTextBox = null;
        private Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>()
        {
            { "Spag Meal 1", 120m },
            { "Spag Meal 2", 140m },
            { "Burger Meal", 95m },
            { "Chicken Meal", 110m },
            { "Rice Bowl", 65m },
            { "Carbonara", 130m },
            { "Fried Chicken", 85m },
            { "Adobo Rice", 100m }
        };

        public PosForm()
        {
            InitializeComponent();
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            PopulateMenuItems();
            AttachNumpadEvents();
            SetupTextBoxFocusEvents();
        }

        private void PopulateMenuItems()
        {
            itemsPanel.Controls.Clear();
            itemPanels.Clear();

            foreach (var item in menuItems)
            {
                Panel itemPanel = new Panel();
                itemPanel.Width = 120;
                itemPanel.Height = 140;
                itemPanel.BackColor = Color.LightGray;
                itemPanel.BorderStyle = BorderStyle.FixedSingle;
                itemPanel.Margin = new Padding(5);
                itemPanel.Tag = item.Key + "|" + item.Value.ToString();
                itemPanel.Click += ItemPanel_Click;

                Label itemLabel = new Label();
                itemLabel.Text = item.Key;
                itemLabel.Dock = DockStyle.Top;
                itemLabel.TextAlign = ContentAlignment.TopCenter;
                itemLabel.Height = 40;
                itemLabel.Font = new Font(itemLabel.Font, FontStyle.Bold);
                itemLabel.Click += ItemPanel_Click;
                itemPanel.Controls.Add(itemLabel);

                PictureBox itemPicture = new PictureBox();
                itemPicture.Dock = DockStyle.Fill;
                itemPicture.BackColor = Color.White;
                itemPicture.Click += ItemPanel_Click;
                itemPanel.Controls.Add(itemPicture);

                itemsPanel.Controls.Add(itemPanel);
                itemPanels.Add(itemPanel);
            }
        }

        private void ItemPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;
            Panel panel = null;

            if (clickedControl is Panel)
            {
                panel = clickedControl as Panel;
            }
            else
            {
                panel = clickedControl?.Parent as Panel;
            }

            if (panel != null && panel.Tag != null)
            {
                string[] itemData = panel.Tag.ToString().Split('|');
                string itemName = itemData[0];
                decimal itemPrice = decimal.Parse(itemData[1]);

                itemNameTextBox.Text = itemName;
                priceTextBox.Text = itemPrice.ToString("F2");
            }
        }

        private void AttachNumpadEvents()
        {
            for (int i = 0; i <= 9; i++)
            {
                string buttonName = "button" + i;
                Button btn = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    btn.Click += NumpadButton_Click;
                }
            }

            Button dotBtn = this.Controls.Find("buttonDot", true).FirstOrDefault() as Button;
            if (dotBtn != null)
                dotBtn.Click += NumpadButton_Click;

            Button clearBtn = this.Controls.Find("buttonC", true).FirstOrDefault() as Button;
            if (clearBtn != null)
                clearBtn.Click += (s, e) => { if (currentFocusedTextBox != null) currentFocusedTextBox.Clear(); };
        }

        private void NumpadButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (currentFocusedTextBox != null && btn != null)
            {
                currentFocusedTextBox.AppendText(btn.Text);
            }
        }

        private void SetupTextBoxFocusEvents()
        {
            itemNameTextBox.Enter += (s, e) => { currentFocusedTextBox = itemNameTextBox; };
            quantityTextBox.Enter += (s, e) => { currentFocusedTextBox = quantityTextBox; };
            priceTextBox.Enter += (s, e) => { currentFocusedTextBox = priceTextBox; };
            cashRenderedTextBox.Enter += (s, e) => { currentFocusedTextBox = cashRenderedTextBox; };
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = string.IsNullOrEmpty(quantityTextBox.Text) ? 0 : int.Parse(quantityTextBox.Text);
                decimal price = string.IsNullOrEmpty(priceTextBox.Text) ? 0 : decimal.Parse(priceTextBox.Text);
                decimal subtotal = quantity * price;

                decimal discountPercentage = 0;
                if (seniorCitizenRadioButton.Checked)
                    discountPercentage = 0.20m;
                else if (discCardRadioButton.Checked)
                    discountPercentage = 0.10m;
                else if (employeeDiscRadioButton.Checked)
                    discountPercentage = 0.15m;

                decimal discountAmount = subtotal * discountPercentage;
                decimal discountedAmount = subtotal - discountAmount;

                discountAmountTextBox.Text = discountAmount.ToString("F2");
                discountedAmountTextBox.Text = discountedAmount.ToString("F2");

                UpdateSummary(quantity, discountAmount, discountedAmount);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input. Please check your entries.");
            }
        }

        private void UpdateSummary(int quantity, decimal totalDiscount, decimal totalDiscounted)
        {
            totalQuantityTextBox.Text = quantity.ToString();
            totalDiscountGivenTextBox.Text = totalDiscount.ToString("F2");
            totalDiscountedAmountTextBox.Text = totalDiscounted.ToString("F2");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal discountedAmount = string.IsNullOrEmpty(discountedAmountTextBox.Text) ? 0 : decimal.Parse(discountedAmountTextBox.Text);
                decimal cashRendered = string.IsNullOrEmpty(cashRenderedTextBox.Text) ? 0 : decimal.Parse(cashRenderedTextBox.Text);

                decimal change = cashRendered - discountedAmount;
                changeTextBox.Text = change >= 0 ? change.ToString("F2") : "Insufficient";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input for cash rendered.");
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            itemNameTextBox.Clear();
            quantityTextBox.Clear();
            priceTextBox.Clear();
            discountAmountTextBox.Clear();
            discountedAmountTextBox.Clear();
            totalQuantityTextBox.Clear();
            totalDiscountGivenTextBox.Clear();
            totalDiscountedAmountTextBox.Clear();
            cashRenderedTextBox.Clear();
            changeTextBox.Clear();
            noDiscountRadioButton.Checked = true;
            currentFocusedTextBox = null;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            newButton_Click(null, null);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
