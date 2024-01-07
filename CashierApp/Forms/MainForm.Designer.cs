namespace CashierApp.Forms;

partial class MainForm
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
        ItemsLayoutPanel = new FlowLayoutPanel();
        OrdersPanel = new Controls.OrdersPanel();
        button1 = new Button();
        SuspendLayout();
        // 
        // ItemsLayoutPanel
        // 
        ItemsLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ItemsLayoutPanel.AutoScroll = true;
        ItemsLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ItemsLayoutPanel.Location = new Point(12, 12);
        ItemsLayoutPanel.Name = "ItemsLayoutPanel";
        ItemsLayoutPanel.Size = new Size(578, 758);
        ItemsLayoutPanel.TabIndex = 0;
        // 
        // OrdersPanel
        // 
        OrdersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        OrdersPanel.Location = new Point(596, 12);
        OrdersPanel.Name = "OrdersPanel";
        OrdersPanel.Size = new Size(400, 656);
        OrdersPanel.TabIndex = 1;
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        button1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(596, 674);
        button1.Name = "button1";
        button1.Size = new Size(400, 96);
        button1.TabIndex = 2;
        button1.Text = "CHECKOUT";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1008, 782);
        Controls.Add(button1);
        Controls.Add(OrdersPanel);
        Controls.Add(ItemsLayoutPanel);
        Name = "MainForm";
        Text = "Form1";
        Load += MainForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel ItemsLayoutPanel;
    private Controls.OrdersPanel OrdersPanel;
    private Button button1;
}