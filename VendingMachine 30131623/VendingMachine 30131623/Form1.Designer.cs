namespace VendingMachine_30131623
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            CheezIt = new PictureBox();
            SourSkittles = new PictureBox();
            DRPepper = new PictureBox();
            MandMs = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btn_void = new Button();
            btn_checkout = new Button();
            btn_enter = new Button();
            btn_cancel = new Button();
            btn_zero = new Button();
            btn_seven = new Button();
            btn_eight = new Button();
            btn_nine = new Button();
            btn_four = new Button();
            btn_five = new Button();
            btn_six = new Button();
            btn_three = new Button();
            btn_two = new Button();
            btn_one = new Button();
            panel2 = new Panel();
            Money_in = new TextBox();
            txt_Choice = new TextBox();
            list_items = new ListView();
            Item = new ColumnHeader();
            Price = new ColumnHeader();
            coinslot = new PictureBox();
            one_pence = new PictureBox();
            two_pence = new PictureBox();
            five_pence = new PictureBox();
            ten_pence = new PictureBox();
            twenty_pence = new PictureBox();
            fifty_pence = new PictureBox();
            one_pound = new PictureBox();
            btn_cancelorder = new Button();
            ((System.ComponentModel.ISupportInitialize)CheezIt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SourSkittles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DRPepper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MandMs).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coinslot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)one_pence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)two_pence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)five_pence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ten_pence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)twenty_pence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fifty_pence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)one_pound).BeginInit();
            SuspendLayout();
            // 
            // CheezIt
            // 
            CheezIt.Image = (Image)resources.GetObject("CheezIt.Image");
            CheezIt.Location = new Point(38, 12);
            CheezIt.Name = "CheezIt";
            CheezIt.Size = new Size(218, 214);
            CheezIt.SizeMode = PictureBoxSizeMode.CenterImage;
            CheezIt.TabIndex = 0;
            CheezIt.TabStop = false;
            CheezIt.Click += CheezIt_Click;
            // 
            // SourSkittles
            // 
            SourSkittles.Image = (Image)resources.GetObject("SourSkittles.Image");
            SourSkittles.Location = new Point(276, 12);
            SourSkittles.Name = "SourSkittles";
            SourSkittles.Size = new Size(203, 214);
            SourSkittles.SizeMode = PictureBoxSizeMode.CenterImage;
            SourSkittles.TabIndex = 1;
            SourSkittles.TabStop = false;
            // 
            // DRPepper
            // 
            DRPepper.Image = (Image)resources.GetObject("DRPepper.Image");
            DRPepper.Location = new Point(503, 12);
            DRPepper.Name = "DRPepper";
            DRPepper.Size = new Size(194, 214);
            DRPepper.SizeMode = PictureBoxSizeMode.CenterImage;
            DRPepper.TabIndex = 2;
            DRPepper.TabStop = false;
            // 
            // MandMs
            // 
            MandMs.Image = (Image)resources.GetObject("MandMs.Image");
            MandMs.Location = new Point(703, 12);
            MandMs.Name = "MandMs";
            MandMs.Size = new Size(203, 212);
            MandMs.SizeMode = PictureBoxSizeMode.CenterImage;
            MandMs.TabIndex = 3;
            MandMs.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 239);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 4;
            label1.Text = "101 - £2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 239);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 5;
            label2.Text = "102 - £2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(574, 239);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 6;
            label3.Text = "103- £1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(782, 239);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 7;
            label4.Text = "104 - £2.50";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_cancelorder);
            panel1.Controls.Add(btn_void);
            panel1.Controls.Add(btn_checkout);
            panel1.Controls.Add(btn_enter);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(btn_zero);
            panel1.Controls.Add(btn_seven);
            panel1.Controls.Add(btn_eight);
            panel1.Controls.Add(btn_nine);
            panel1.Controls.Add(btn_four);
            panel1.Controls.Add(btn_five);
            panel1.Controls.Add(btn_six);
            panel1.Controls.Add(btn_three);
            panel1.Controls.Add(btn_two);
            panel1.Controls.Add(btn_one);
            panel1.Location = new Point(984, 220);
            panel1.Name = "panel1";
            panel1.Size = new Size(154, 298);
            panel1.TabIndex = 8;
            // 
            // btn_void
            // 
            btn_void.Location = new Point(54, 192);
            btn_void.Name = "btn_void";
            btn_void.Size = new Size(96, 42);
            btn_void.TabIndex = 13;
            btn_void.Text = "Del Item";
            btn_void.UseVisualStyleBackColor = true;
            btn_void.Click += btn_void_Click;
            // 
            // btn_checkout
            // 
            btn_checkout.Image = (Image)resources.GetObject("btn_checkout.Image");
            btn_checkout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_checkout.Location = new Point(3, 192);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(45, 42);
            btn_checkout.TabIndex = 12;
            btn_checkout.Text = "\U0001f6d2";
            btn_checkout.UseVisualStyleBackColor = true;
            btn_checkout.Click += btn_checkout_Click;
            // 
            // btn_enter
            // 
            btn_enter.BackColor = Color.Green;
            btn_enter.Location = new Point(0, 144);
            btn_enter.Name = "btn_enter";
            btn_enter.Size = new Size(45, 42);
            btn_enter.TabIndex = 11;
            btn_enter.Text = "✔";
            btn_enter.UseVisualStyleBackColor = false;
            btn_enter.Click += btn_enter_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.FromArgb(192, 0, 0);
            btn_cancel.Location = new Point(105, 144);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(45, 42);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "X";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_zero
            // 
            btn_zero.Location = new Point(54, 144);
            btn_zero.Name = "btn_zero";
            btn_zero.Size = new Size(45, 42);
            btn_zero.TabIndex = 9;
            btn_zero.Text = "0";
            btn_zero.UseVisualStyleBackColor = true;
            btn_zero.Click += btn_zero_Click;
            // 
            // btn_seven
            // 
            btn_seven.Location = new Point(3, 96);
            btn_seven.Name = "btn_seven";
            btn_seven.Size = new Size(45, 42);
            btn_seven.TabIndex = 8;
            btn_seven.Text = "7";
            btn_seven.UseVisualStyleBackColor = true;
            btn_seven.Click += btn_seven_Click;
            // 
            // btn_eight
            // 
            btn_eight.Location = new Point(54, 96);
            btn_eight.Name = "btn_eight";
            btn_eight.Size = new Size(45, 42);
            btn_eight.TabIndex = 7;
            btn_eight.Text = "8";
            btn_eight.UseVisualStyleBackColor = true;
            btn_eight.Click += btn_eight_Click;
            // 
            // btn_nine
            // 
            btn_nine.Location = new Point(105, 96);
            btn_nine.Name = "btn_nine";
            btn_nine.Size = new Size(45, 42);
            btn_nine.TabIndex = 6;
            btn_nine.Text = "9";
            btn_nine.UseVisualStyleBackColor = true;
            btn_nine.Click += btn_nine_Click;
            // 
            // btn_four
            // 
            btn_four.Location = new Point(3, 48);
            btn_four.Name = "btn_four";
            btn_four.Size = new Size(45, 42);
            btn_four.TabIndex = 5;
            btn_four.Text = "4";
            btn_four.UseVisualStyleBackColor = true;
            btn_four.Click += btn_four_Click;
            // 
            // btn_five
            // 
            btn_five.Location = new Point(54, 48);
            btn_five.Name = "btn_five";
            btn_five.Size = new Size(45, 42);
            btn_five.TabIndex = 4;
            btn_five.Text = "5";
            btn_five.UseVisualStyleBackColor = true;
            btn_five.Click += btn_five_Click;
            // 
            // btn_six
            // 
            btn_six.Location = new Point(105, 48);
            btn_six.Name = "btn_six";
            btn_six.Size = new Size(45, 42);
            btn_six.TabIndex = 3;
            btn_six.Text = "6";
            btn_six.UseVisualStyleBackColor = true;
            btn_six.Click += btn_six_Click;
            // 
            // btn_three
            // 
            btn_three.Location = new Point(105, 0);
            btn_three.Name = "btn_three";
            btn_three.Size = new Size(45, 42);
            btn_three.TabIndex = 2;
            btn_three.Text = "3";
            btn_three.UseVisualStyleBackColor = true;
            btn_three.Click += btn_three_Click;
            // 
            // btn_two
            // 
            btn_two.Location = new Point(54, 0);
            btn_two.Name = "btn_two";
            btn_two.Size = new Size(45, 42);
            btn_two.TabIndex = 1;
            btn_two.Text = "2";
            btn_two.UseVisualStyleBackColor = true;
            btn_two.Click += btn_two_Click;
            // 
            // btn_one
            // 
            btn_one.Location = new Point(3, 0);
            btn_one.Name = "btn_one";
            btn_one.Size = new Size(45, 42);
            btn_one.TabIndex = 0;
            btn_one.Text = "1";
            btn_one.UseVisualStyleBackColor = true;
            btn_one.Click += btn_one_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Money_in);
            panel2.Controls.Add(txt_Choice);
            panel2.Controls.Add(list_items);
            panel2.Location = new Point(941, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 219);
            panel2.TabIndex = 10;
            // 
            // Money_in
            // 
            Money_in.Location = new Point(21, 8);
            Money_in.Name = "Money_in";
            Money_in.Size = new Size(197, 27);
            Money_in.TabIndex = 12;
            // 
            // txt_Choice
            // 
            txt_Choice.Location = new Point(23, 41);
            txt_Choice.Name = "txt_Choice";
            txt_Choice.Size = new Size(195, 27);
            txt_Choice.TabIndex = 11;
            // 
            // list_items
            // 
            list_items.Location = new Point(3, 74);
            list_items.Name = "list_items";
            list_items.Size = new Size(237, 142);
            list_items.TabIndex = 10;
            list_items.UseCompatibleStateImageBehavior = false;
            // 
            // coinslot
            // 
            coinslot.Image = (Image)resources.GetObject("coinslot.Image");
            coinslot.Location = new Point(964, 513);
            coinslot.Name = "coinslot";
            coinslot.Size = new Size(195, 297);
            coinslot.SizeMode = PictureBoxSizeMode.CenterImage;
            coinslot.TabIndex = 11;
            coinslot.TabStop = false;
            coinslot.Click += coinslot_Click;
            coinslot.DragDrop += coinslot_DragDrop;
            coinslot.DragEnter += coinslot_DragEnter;
            // 
            // one_pence
            // 
            one_pence.Image = (Image)resources.GetObject("one_pence.Image");
            one_pence.Location = new Point(1222, 29);
            one_pence.Name = "one_pence";
            one_pence.Size = new Size(119, 89);
            one_pence.SizeMode = PictureBoxSizeMode.Zoom;
            one_pence.TabIndex = 12;
            one_pence.TabStop = false;
            one_pence.MouseDown += one_pence_MouseDown;
            // 
            // two_pence
            // 
            two_pence.Image = (Image)resources.GetObject("two_pence.Image");
            two_pence.Location = new Point(1364, 29);
            two_pence.Name = "two_pence";
            two_pence.Size = new Size(99, 89);
            two_pence.SizeMode = PictureBoxSizeMode.Zoom;
            two_pence.TabIndex = 13;
            two_pence.TabStop = false;
            two_pence.MouseDown += two_pence_MouseDown;
            // 
            // five_pence
            // 
            five_pence.Image = (Image)resources.GetObject("five_pence.Image");
            five_pence.Location = new Point(1225, 151);
            five_pence.Name = "five_pence";
            five_pence.Size = new Size(125, 94);
            five_pence.SizeMode = PictureBoxSizeMode.Zoom;
            five_pence.TabIndex = 14;
            five_pence.TabStop = false;
            five_pence.MouseDown += five_pence_MouseDown;
            // 
            // ten_pence
            // 
            ten_pence.Image = (Image)resources.GetObject("ten_pence.Image");
            ten_pence.Location = new Point(1364, 148);
            ten_pence.Name = "ten_pence";
            ten_pence.Size = new Size(99, 97);
            ten_pence.SizeMode = PictureBoxSizeMode.Zoom;
            ten_pence.TabIndex = 15;
            ten_pence.TabStop = false;
            ten_pence.MouseDown += ten_pence_MouseDown;
            // 
            // twenty_pence
            // 
            twenty_pence.Image = (Image)resources.GetObject("twenty_pence.Image");
            twenty_pence.Location = new Point(1222, 268);
            twenty_pence.Name = "twenty_pence";
            twenty_pence.Size = new Size(122, 105);
            twenty_pence.SizeMode = PictureBoxSizeMode.Zoom;
            twenty_pence.TabIndex = 16;
            twenty_pence.TabStop = false;
            twenty_pence.MouseDown += twenty_pence_MouseDown;
            // 
            // fifty_pence
            // 
            fifty_pence.Image = (Image)resources.GetObject("fifty_pence.Image");
            fifty_pence.Location = new Point(1361, 270);
            fifty_pence.Name = "fifty_pence";
            fifty_pence.Size = new Size(99, 103);
            fifty_pence.SizeMode = PictureBoxSizeMode.Zoom;
            fifty_pence.TabIndex = 17;
            fifty_pence.TabStop = false;
            fifty_pence.MouseDown += fifty_pence_MouseDown;
            // 
            // one_pound
            // 
            one_pound.Image = Properties.Resources._1pound;
            one_pound.Location = new Point(1222, 388);
            one_pound.Name = "one_pound";
            one_pound.Size = new Size(110, 103);
            one_pound.SizeMode = PictureBoxSizeMode.Zoom;
            one_pound.TabIndex = 18;
            one_pound.TabStop = false;
            one_pound.MouseDown += one_pound_MouseDown;
            // 
            // btn_cancelorder
            // 
            btn_cancelorder.Location = new Point(3, 240);
            btn_cancelorder.Name = "btn_cancelorder";
            btn_cancelorder.Size = new Size(147, 50);
            btn_cancelorder.TabIndex = 14;
            btn_cancelorder.Text = "Cancel";
            btn_cancelorder.UseVisualStyleBackColor = true;
            btn_cancelorder.Click += btn_cancelorder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1475, 801);
            Controls.Add(one_pound);
            Controls.Add(fifty_pence);
            Controls.Add(twenty_pence);
            Controls.Add(ten_pence);
            Controls.Add(five_pence);
            Controls.Add(two_pence);
            Controls.Add(one_pence);
            Controls.Add(coinslot);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MandMs);
            Controls.Add(DRPepper);
            Controls.Add(SourSkittles);
            Controls.Add(CheezIt);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CheezIt).EndInit();
            ((System.ComponentModel.ISupportInitialize)SourSkittles).EndInit();
            ((System.ComponentModel.ISupportInitialize)DRPepper).EndInit();
            ((System.ComponentModel.ISupportInitialize)MandMs).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)coinslot).EndInit();
            ((System.ComponentModel.ISupportInitialize)one_pence).EndInit();
            ((System.ComponentModel.ISupportInitialize)two_pence).EndInit();
            ((System.ComponentModel.ISupportInitialize)five_pence).EndInit();
            ((System.ComponentModel.ISupportInitialize)ten_pence).EndInit();
            ((System.ComponentModel.ISupportInitialize)twenty_pence).EndInit();
            ((System.ComponentModel.ISupportInitialize)fifty_pence).EndInit();
            ((System.ComponentModel.ISupportInitialize)one_pound).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox CheezIt;
        private PictureBox SourSkittles;
        private PictureBox DRPepper;
        private PictureBox MandMs;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button btn_two;
        private Button btn_one;
        private Button btn_enter;
        private Button btn_cancel;
        private Button btn_zero;
        private Button btn_seven;
        private Button btn_eight;
        private Button btn_nine;
        private Button btn_four;
        private Button btn_five;
        private Button btn_six;
        private Button btn_three;
        private Button btn_checkout;
        private Panel panel2;
        private ListView list_items;
        private PictureBox coinslot;
        private PictureBox one_pence;
        private PictureBox two_pence;
        private PictureBox five_pence;
        private PictureBox ten_pence;
        private PictureBox twenty_pence;
        private PictureBox fifty_pence;
        private PictureBox one_pound;
        private TextBox txt_Choice;
        private TextBox Money_in;
        private ColumnHeader Item;
        private ColumnHeader Price;
        private Button btn_void;
        private Button btn_cancelorder;
    }
}
