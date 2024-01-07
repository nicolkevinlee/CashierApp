namespace CashierApp.Controls
{
    partial class OrdersPanel
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            GrossAmountLabel = new Label();
            GrossAmountText = new Label();
            label1 = new Label();
            OrdersGridView = new DataGridView();
            itemBindingSource = new BindingSource(components);
            orderEntryBindingSource = new BindingSource(components);
            countDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderEntryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(GrossAmountLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(GrossAmountText, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 450);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(351, 50);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // GrossAmountLabel
            // 
            GrossAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrossAmountLabel.AutoSize = true;
            GrossAmountLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GrossAmountLabel.Location = new Point(3, 0);
            GrossAmountLabel.Name = "GrossAmountLabel";
            GrossAmountLabel.Size = new Size(169, 50);
            GrossAmountLabel.TabIndex = 0;
            GrossAmountLabel.Text = "Gross Amount:";
            GrossAmountLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GrossAmountText
            // 
            GrossAmountText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrossAmountText.AutoSize = true;
            GrossAmountText.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            GrossAmountText.Location = new Point(178, 0);
            GrossAmountText.Name = "GrossAmountText";
            GrossAmountText.Size = new Size(170, 50);
            GrossAmountText.TabIndex = 1;
            GrossAmountText.Text = "0.00";
            GrossAmountText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 0;
            label1.Text = "ORDERS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrdersGridView
            // 
            OrdersGridView.AllowUserToAddRows = false;
            OrdersGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersGridView.AutoGenerateColumns = false;
            OrdersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersGridView.Columns.AddRange(new DataGridViewColumn[] { countDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            OrdersGridView.DataSource = orderEntryBindingSource;
            OrdersGridView.Location = new Point(0, 35);
            OrdersGridView.MultiSelect = false;
            OrdersGridView.Name = "OrdersGridView";
            OrdersGridView.ReadOnly = true;
            OrdersGridView.RowHeadersVisible = false;
            OrdersGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            OrdersGridView.RowTemplate.Height = 25;
            OrdersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersGridView.Size = new Size(351, 409);
            OrdersGridView.TabIndex = 1;
            OrdersGridView.CellMouseDoubleClick += OrdersGridView_CellMouseDoubleClick;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Model.Item);
            // 
            // orderEntryBindingSource
            // 
            orderEntryBindingSource.DataSource = typeof(Model.OrderEntry);
            // 
            // countDataGridViewTextBoxColumn
            // 
            countDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            countDataGridViewTextBoxColumn.HeaderText = "QTY";
            countDataGridViewTextBoxColumn.MinimumWidth = 50;
            countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            countDataGridViewTextBoxColumn.ReadOnly = true;
            countDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            countDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "DESCRIPTION";
            nameDataGridViewTextBoxColumn.MinimumWidth = 272;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 272;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "AMOUNT";
            amountDataGridViewTextBoxColumn.MinimumWidth = 75;
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Width = 75;
            // 
            // OrdersPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersGridView);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersPanel";
            Size = new Size(351, 500);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderEntryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView OrdersGridView;
        private Label GrossAmountLabel;
        private Label GrossAmountText;
        private BindingSource itemBindingSource;
        private BindingSource orderEntryBindingSource;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}
