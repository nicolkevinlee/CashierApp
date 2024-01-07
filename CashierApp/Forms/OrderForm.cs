using CashierApp.Model;

namespace CashierApp.Forms;

public partial class OrderForm : Form
{

    private int _itemCount;
    private Item _item;


    private event ItemAddDelegate _onItemAdd;

    public OrderForm(Item item, ItemAddDelegate itemAddDelegate)
    {
        InitializeComponent();
        _itemCount = 1;
        _item = item;
        _onItemAdd = itemAddDelegate;
    }

    private void UpdateLabels()
    {
        ItemNameLabel.Text = _item.Name;
        UpdateItemCountLabel();
    }

    private void UpdateItemCountLabel()
    {
        ItemCountLabel.Text = _itemCount.ToString();
        PriceLabel.Text = $"{_item.Price * _itemCount:N2}";
    }
    private void OrderForm_Load(object sender, EventArgs e)
    {
        UpdateLabels();
    }

    private void MinusButton_Click(object sender, EventArgs e)
    {
        if (_itemCount > 1)
        {
            _itemCount--;
            UpdateItemCountLabel();
        }
    }

    private void PlusButton_Click(object sender, EventArgs e)
    {
        _itemCount++;
        UpdateItemCountLabel();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void OrderButton_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show("Add to orders?", "Question", MessageBoxButtons.YesNo);
        if (result == DialogResult.Yes) 
        {
            _onItemAdd?.Invoke(_item, _itemCount);
            Close();
        }
        
    }

}

public delegate void ItemAddDelegate(Item orderItem, int count);
