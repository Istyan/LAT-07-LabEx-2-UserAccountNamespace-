namespace UserAccountNamespace
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelChange = new Label();
            label8 = new Label();
            label7 = new Label();
            labelTotal = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            textPayment = new TextBox();
            textQuantity = new TextBox();
            textPrice = new TextBox();
            textDiscount = new TextBox();
            textItem = new TextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelChange
            // 
            labelChange.AutoSize = true;
            labelChange.Font = new Font("Segoe UI", 10F);
            labelChange.Location = new Point(194, 258);
            labelChange.Name = "labelChange";
            labelChange.Size = new Size(0, 23);
            labelChange.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(105, 258);
            label8.Name = "label8";
            label8.Size = new Size(73, 23);
            label8.TabIndex = 30;
            label8.Text = "Change:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(26, 216);
            label7.Name = "label7";
            label7.Size = new Size(152, 23);
            label7.TabIndex = 29;
            label7.Text = "Payment Received:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 10F);
            labelTotal.Location = new Point(194, 168);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(0, 23);
            labelTotal.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(61, 168);
            label5.Name = "label5";
            label5.Size = new Size(117, 23);
            label5.TabIndex = 27;
            label5.Text = "Total Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(266, 84);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 26;
            label4.Text = "Quantity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(13, 87);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 25;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(266, 28);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 24;
            label2.Text = "Discount(%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 23;
            label1.Text = "Item:";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(328, 215);
            button2.Name = "button2";
            button2.Size = new Size(73, 29);
            button2.TabIndex = 22;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(151, 117);
            button1.Name = "button1";
            button1.Size = new Size(98, 30);
            button1.TabIndex = 21;
            button1.Text = "Compute";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textPayment
            // 
            textPayment.Location = new Point(184, 215);
            textPayment.Name = "textPayment";
            textPayment.Size = new Size(138, 27);
            textPayment.TabIndex = 20;
            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(348, 83);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(69, 27);
            textQuantity.TabIndex = 19;
            // 
            // textPrice
            // 
            textPrice.Location = new Point(71, 84);
            textPrice.Name = "textPrice";
            textPrice.Size = new Size(189, 27);
            textPrice.TabIndex = 18;
            // 
            // textDiscount
            // 
            textDiscount.Location = new Point(266, 51);
            textDiscount.Name = "textDiscount";
            textDiscount.Size = new Size(151, 27);
            textDiscount.TabIndex = 17;
            // 
            // textItem
            // 
            textItem.Location = new Point(12, 51);
            textItem.Name = "textItem";
            textItem.Size = new Size(248, 27);
            textItem.TabIndex = 16;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(431, 28);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 287);
            Controls.Add(labelChange);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(labelTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textPayment);
            Controls.Add(textQuantity);
            Controls.Add(textPrice);
            Controls.Add(textDiscount);
            Controls.Add(textItem);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted Item";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textItem;
        private TextBox textDiscount;
        private TextBox textPrice;
        private TextBox textQuantity;
        private TextBox textPayment;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelTotal;
        private Label label7;
        private Label label8;
        private Label labelChange;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
    }
}