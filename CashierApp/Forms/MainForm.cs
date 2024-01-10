using CashierApp.Controls;
using CashierApp.Data;
using CashierApp.Model;

namespace CashierApp.Forms;

public partial class MainForm : Form
{
    private IApiRepository _itemsRepository;
    private List<Item> _items;

    public MainForm(IApiRepository itemsRepository)
    {
        InitializeComponent();
        _itemsRepository = itemsRepository;
    }

    private async void MainForm_Load(object sender, EventArgs e)
    {
        _items = await _itemsRepository.GetItemList();

        foreach (var item in _items)
        {
            ItemsLayoutPanel.Controls.Add(new ItemPanel(item, OnOrderSelect));
        }

    }

    private void OnOrderSelect(Item item)
    {
        var orderForm = new OrderForm(item, OnOrderAdded);
        orderForm.ShowDialog();
    }

    private void OnOrderAdded(Item item, int count)
    {
       OrdersPanel.AddOrder(item, count);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (OrdersPanel.HasOrders()) 
        { 
            var checkoutForm = new CheckoutForm(
                    new ReceiptTextWriter(),
                    OrdersPanel.GetOrders(),
                    OnCheckoutComplete);
            checkoutForm.ShowDialog();
        }
        else
        {
            MessageBox.Show(this, "There are no orders.");
        }
    }

    private void OnCheckoutComplete()
    {
        OrdersPanel.ClearOrders();
    }
}