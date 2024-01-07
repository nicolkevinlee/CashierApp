namespace CashierApp.Forms
{
    partial class OrderForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ItemNameLabel = new Label();
            PriceLabel = new Label();
            MinusButton = new Button();
            PlusButton = new Button();
            BackButton = new Button();
            OrderButton = new Button();
            ItemCountLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(ItemNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(PriceLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(MinusButton, 0, 2);
            tableLayoutPanel1.Controls.Add(PlusButton, 3, 2);
            tableLayoutPanel1.Controls.Add(BackButton, 0, 3);
            tableLayoutPanel1.Controls.Add(OrderButton, 2, 3);
            tableLayoutPanel1.Controls.Add(ItemCountLabel, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(210, 237);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemNameLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(ItemNameLabel, 4);
            ItemNameLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemNameLabel.Location = new Point(3, 0);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(204, 59);
            ItemNameLabel.TabIndex = 0;
            ItemNameLabel.Text = "Item Name";
            ItemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriceLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(PriceLabel, 4);
            PriceLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(3, 59);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(204, 59);
            PriceLabel.TabIndex = 1;
            PriceLabel.Text = "Price";
            PriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MinusButton
            // 
            MinusButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MinusButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            MinusButton.Location = new Point(3, 121);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(57, 53);
            MinusButton.TabIndex = 2;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += MinusButton_Click;
            // 
            // PlusButton
            // 
            PlusButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PlusButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PlusButton.Location = new Point(150, 121);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(57, 53);
            PlusButton.TabIndex = 3;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += PlusButton_Click;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(BackButton, 2);
            BackButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.Location = new Point(3, 180);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(99, 54);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // OrderButton
            // 
            OrderButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(OrderButton, 2);
            OrderButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OrderButton.Location = new Point(108, 180);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(99, 54);
            OrderButton.TabIndex = 5;
            OrderButton.Text = "Order";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // ItemCountLabel
            // 
            ItemCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemCountLabel.AutoSize = true;
            ItemCountLabel.BackColor = SystemColors.ControlLightLight;
            tableLayoutPanel1.SetColumnSpan(ItemCountLabel, 2);
            ItemCountLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemCountLabel.Location = new Point(66, 118);
            ItemCountLabel.Name = "ItemCountLabel";
            ItemCountLabel.Size = new Size(78, 59);
            ItemCountLabel.TabIndex = 6;
            ItemCountLabel.Text = "1";
            ItemCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 261);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Form";
            Load += OrderForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label ItemNameLabel;
        private Label PriceLabel;
        private Button MinusButton;
        private Button PlusButton;
        private Button BackButton;
        private Button OrderButton;
        private Label ItemCountLabel;
    }
}