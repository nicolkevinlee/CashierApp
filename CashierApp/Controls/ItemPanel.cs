using CashierApp.Model;

namespace CashierApp.Controls;

public partial class ItemPanel : UserControl
{
    private Item _orderItem;

    private event ItemSelectedDelegate _onItemSelected;
    public ItemPanel(Item orderItem, ItemSelectedDelegate onItemSelected)
    {
        InitializeComponent();
        _orderItem = orderItem;
        _onItemSelected = onItemSelected;

        ItemNameLabel.Text = orderItem.Name;
        PriceLabel.Text = $"{orderItem.Price:N2}";
    }

    private void ItemPanel_MouseClick(object sender, MouseEventArgs e)
    {
        _onItemSelected?.Invoke(_orderItem);
    }
}

public delegate void ItemSelectedDelegate(Item orderItem);