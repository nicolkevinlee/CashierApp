namespace CashierApp.Forms
{
    partial class CheckoutForm
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
            GrossAmountLabel = new Label();
            GrossAmountText = new Label();
            ChangeLabel = new Label();
            ChangeText = new Label();
            label5 = new Label();
            BackButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SubmitButton = new Button();
            PayAmountTextbox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // GrossAmountLabel
            // 
            GrossAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            GrossAmountLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(GrossAmountLabel, 2);
            GrossAmountLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            GrossAmountLabel.Location = new Point(3, 0);
            GrossAmountLabel.Name = "GrossAmountLabel";
            GrossAmountLabel.Size = new Size(177, 41);
            GrossAmountLabel.TabIndex = 0;
            GrossAmountLabel.Text = "Gross Amount:";
            GrossAmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GrossAmountText
            // 
            GrossAmountText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            GrossAmountText.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(GrossAmountText, 2);
            GrossAmountText.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            GrossAmountText.Location = new Point(398, 0);
            GrossAmountText.Name = "GrossAmountText";
            GrossAmountText.Size = new Size(59, 41);
            GrossAmountText.TabIndex = 1;
            GrossAmountText.Text = "0.00";
            GrossAmountText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ChangeLabel
            // 
            ChangeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ChangeLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(ChangeLabel, 2);
            ChangeLabel.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeLabel.Location = new Point(3, 41);
            ChangeLabel.Name = "ChangeLabel";
            ChangeLabel.Size = new Size(100, 41);
            ChangeLabel.TabIndex = 2;
            ChangeLabel.Text = "Change:";
            ChangeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ChangeText
            // 
            ChangeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ChangeText.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(ChangeText, 2);
            ChangeText.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeText.Location = new Point(398, 41);
            ChangeText.Name = "ChangeText";
            ChangeText.Size = new Size(59, 41);
            ChangeText.TabIndex = 3;
            ChangeText.Text = "0.00";
            ChangeText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label5, 4);
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 82);
            label5.Name = "label5";
            label5.Size = new Size(454, 41);
            label5.TabIndex = 4;
            label5.Text = "Enter Amount:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackButton
            // 
            BackButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(BackButton, 2);
            BackButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.Location = new Point(3, 167);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(224, 37);
            BackButton.TabIndex = 6;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(ChangeLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(BackButton, 0, 4);
            tableLayoutPanel1.Controls.Add(GrossAmountLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(label5, 0, 2);
            tableLayoutPanel1.Controls.Add(GrossAmountText, 2, 0);
            tableLayoutPanel1.Controls.Add(ChangeText, 2, 1);
            tableLayoutPanel1.Controls.Add(SubmitButton, 2, 4);
            tableLayoutPanel1.Controls.Add(PayAmountTextbox, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(460, 207);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // SubmitButton
            // 
            SubmitButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(SubmitButton, 2);
            SubmitButton.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SubmitButton.Location = new Point(233, 167);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(224, 37);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // PayAmountTextbox
            // 
            PayAmountTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(PayAmountTextbox, 4);
            PayAmountTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PayAmountTextbox.Location = new Point(3, 126);
            PayAmountTextbox.Name = "PayAmountTextbox";
            PayAmountTextbox.Size = new Size(454, 33);
            PayAmountTextbox.TabIndex = 8;
            PayAmountTextbox.TextAlign = HorizontalAlignment.Right;
            PayAmountTextbox.TextChanged += PayAmountTextbox_TextChanged;
            PayAmountTextbox.KeyPress += PayAmountTextbox_KeyPress;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 231);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CheckoutForm";
            Load += CheckoutForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label GrossAmountLabel;
        private Label GrossAmountText;
        private Label ChangeLabel;
        private Label ChangeText;
        private Label label5;
        private Button BackButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SubmitButton;
        private TextBox PayAmountTextbox;
    }
}