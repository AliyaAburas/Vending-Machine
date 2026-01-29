using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VendingMachine_30131623
{
    public partial class Form1 : Form
    {
        public class Product
        {
            public string? ProductName;
            public int Product_no;
            public double Product_price;

        }

        Product CheezIts;
        Product SkittlesS;
        Product DrPepper;
        Product MnMs;

        bool checkout = false;
        public Form1()
        {
            InitializeComponent();



            CheezIts = new Product
            {
                ProductName = "CheezIts",
                Product_no = 101,
                Product_price = 2.00
            };

            SkittlesS = new Product                     // Object creation, sets product number, price and name
            {
                ProductName = "Skittles Sour",
                Product_no = 102,
                Product_price = 2.00
            };

            DrPepper = new Product
            {
                ProductName = "Dr Pepper",
                Product_no = 103,
                Product_price = 1.00
            };

            MnMs = new Product
            {
                ProductName = "M&Ms",
                Product_no = 104,
                Product_price = 2.50
            };

            Money_in.Text = "0.00";

        }

        private void AddProduct(Product product)
        {
            AddProduct(product, product.ProductName);
        }

        private void RemoveProduct(Product product)
        {
            RemoveProduct(product, product.ProductName);
        }
        void AddProduct(Product product, string productName)            // Passes through produce detaills (from object)
        {                                                               // Adds object to order list

            double totalCost = 0;
            double.TryParse(Money_in.Text, out totalCost);
            totalCost += product.Product_price;
            Money_in.Text = totalCost.ToString("0.00");
            productName = product.ProductName;
            ListViewItem item = new ListViewItem(product.ProductName);
            item.SubItems.Add(product.Product_price.ToString("0.00"));
            list_items.Items.Add(item);
            txt_Choice.Text = "";
        }

        void RemoveProduct(Product product, string productName)
        {
            double totalCost = 0;
            double.TryParse(Money_in.Text, out totalCost);

            for (int i = list_items.Items.Count - 1; i >= 0; i--)
            {
                if (list_items.Items[i].Text == productName)
                {
                    list_items.Items.RemoveAt(i);
                    totalCost -= product.Product_price;
                }
            }

            Money_in.Text = totalCost.ToString("0.00");
            txt_Choice.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            one_pence.Tag = "0.01";             // Provides tag for input to money in.
            two_pence.Tag = "0.02";
            five_pence.Tag = "0.05";
            ten_pence.Tag = "0.10";
            twenty_pence.Tag = "0.20";
            fifty_pence.Tag = "0.50";
            one_pound.Tag = "1.00";

            coinslot.AllowDrop = true;          // Allows images to be dropped

            list_items.View = View.Details;
            list_items.Columns.Add("Item", 120);
            list_items.Columns.Add("Price", 60);


        }

        #region dragndrop


        private void one_pence_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag != null)                          // Lets you drag each coin to be dropped at the coinslot, amount is wwritten to the the "screen"
            {
                _ = DoDragDrop(data: pb.Tag.ToString(), DragDropEffects.Copy);
            }
        }

        private void two_pence_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag != null)
            {
                _ = DoDragDrop(data: pb.Tag.ToString(), DragDropEffects.Copy);
            }
        }

        private void five_pence_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag != null)
            {
                _ = DoDragDrop(data: pb.Tag.ToString(), DragDropEffects.Copy);
            }
        }


        private void ten_pence_MouseDown(object sender, MouseEventArgs e)           // The drag and drop to insert money into the machine
        {
            if (sender is PictureBox pb && pb.Tag != null)
            {
                _ = DoDragDrop(data: pb.Tag.ToString(), DragDropEffects.Copy);
            }
        }

        private void twenty_pence_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag != null)
            {
                _ = DoDragDrop(data: pb.Tag.ToString(), DragDropEffects.Copy);
            }
        }

        private void fifty_pence_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag != null)
            {
                _ = DoDragDrop(data: pb.Tag.ToString(), DragDropEffects.Copy);
            }
        }

        private void one_pound_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag != null)
            {
                _ = DoDragDrop(data: pb.Tag.ToString(), DragDropEffects.Copy);
            }
        }

        double totalInserted = 0.0;
        private void coinslot_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
        }

        private void coinslot_DragDrop(object sender, DragEventArgs e)
        {
            string data = (string)e.Data.GetData(DataFormats.Text);

            if (double.TryParse(data, out double coinValue) && checkout == true)
            {
                totalInserted += coinValue;
                double inputValue = Convert.ToDouble(Money_in.Text);           // adds up money from the inserted coins
                inputValue -= totalInserted;
                Money_in.Text = inputValue.ToString();

                if (Convert.ToDouble(Money_in.Text) <= 0)
                {
                    double change;
                    change = System.Math.Abs(Convert.ToDouble(Money_in.Text));

                    MessageBox.Show("Transaction Complete. Change: £" + change.ToString());     // outputs change is money insterted is 
                    checkout = false;                                                           // above required 
                    list_items.Items.Clear();
                    Money_in.Text = "0.00";
                }
            }

            else if (double.TryParse(data, out coinValue) && checkout == false)
            {
                totalInserted += coinValue;
                MessageBox.Show("Confirm order first. Change: £" + totalInserted.ToString());

            }
        }
        #endregion

        #region Number input

        private void btn_one_Click(object sender, EventArgs e)              // sets up keypad to displayy item numbers on screen
        {
            txt_Choice.Text = txt_Choice.Text + "1";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "2";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "3";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "4";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "5";
        }

        private void btn_six_Click(object sender, EventArgs e)              // Each takes input from the button and saves input to choice textbox
        {
            txt_Choice.Text = txt_Choice.Text + "6";
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "7";
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "8";
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "9";
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = txt_Choice.Text + "0";
        }
        #endregion

        double value;
        string snack;

        private void btn_enter_Click(object sender, EventArgs e)
        {

            double totalCost;

            if (int.Parse(txt_Choice.Text) == CheezIts.Product_no && checkout == false)
            {
                AddProduct(CheezIts);
            }

            else if (int.Parse(txt_Choice.Text) == SkittlesS.Product_no && checkout == false)
            {

                AddProduct(SkittlesS);
            }
            else if (int.Parse(txt_Choice.Text) == DrPepper.Product_no && checkout == false)
            {

                AddProduct(DrPepper);
            }

            else if (int.Parse(txt_Choice.Text) == MnMs.Product_no && checkout == false)
            {

                AddProduct(MnMs);
            }
            else
            {                                                   // If statement for the cases that a number is entered that does not
                MessageBox.Show("Invalid Choice");              // have a product linked
                txt_Choice.Text = "";
            }

            if (checkout == true)
            {                                                                   // If checkout has been chosen, user told to insert 
                MessageBox.Show("Insert coins, total: £", Money_in.Text);      // money instead of adding more products

            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_Choice.Text = "";
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            checkout = true;
        }

        private void btn_void_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_Choice.Text) == CheezIts.Product_no && checkout == false)
            {
                RemoveProduct(CheezIts);
            }

            else if (int.Parse(txt_Choice.Text) == SkittlesS.Product_no && checkout == false)
            {                                                                                           // removal of products from order

                RemoveProduct(SkittlesS);
            }
            else if (int.Parse(txt_Choice.Text) == DrPepper.Product_no && checkout == false)
            {

                RemoveProduct(DrPepper);
            }

            else if (int.Parse(txt_Choice.Text) == MnMs.Product_no && checkout == false)
            {

                RemoveProduct(MnMs);
            }
            else
            {                                                   // If statement for the cases that a number is entered that does not
                MessageBox.Show("Invalid Choice");              // have a product linked
                txt_Choice.Text = "";
            }

            if (checkout == true)
            {                                                                   // If checkout has been chosen, user told to insert 
                MessageBox.Show("Insert coins, total: £", Money_in.Text);      // money instead of adding more products

            }
        }

        private void CheezIt_Click(object sender, EventArgs e)
        {

        }

        private void coinslot_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelorder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel Order?", "Cancel Confirmation",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

          if (result == DialogResult.Yes)
            {
                list_items.Items.Clear();
                Money_in.Text = "0.00";
            }
        }
    }
}





    
