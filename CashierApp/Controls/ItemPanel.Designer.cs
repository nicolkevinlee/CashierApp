namespace CashierApp.Controls
{
    partial class ItemPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemNameLabel = new Label();
            PriceLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemNameLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(ItemNameLabel, 3);
            ItemNameLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ItemNameLabel.Location = new Point(3, 0);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(188, 47);
            ItemNameLabel.TabIndex = 3;
            ItemNameLabel.Text = "Item Name";
            ItemNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            ItemNameLabel.MouseClick += ItemPanel_MouseClick;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(3, 47);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(188, 47);
            PriceLabel.TabIndex = 4;
            PriceLabel.Text = "Price";
            PriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            PriceLabel.MouseClick += ItemPanel_MouseClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(PriceLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(ItemNameLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(194, 94);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.MouseClick += ItemPanel_MouseClick;
            // 
            // ItemPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(tableLayoutPanel1);
            Name = "ItemPanel";
            Size = new Size(200, 100);
            MouseClick += ItemPanel_MouseClick;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label ItemNameLabel;
        private Label PriceLabel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
