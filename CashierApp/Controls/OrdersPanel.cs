using CashierApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp.Controls;

public partial class OrdersPanel : UserControl
{
    private BindingSource _bindingSource;
    public OrdersPanel()
    {
        InitializeComponent();
        _bindingSource = new BindingSource();
        InitializeOrdersGridViewData();
    }

    private void InitializeOrdersGridViewData()
    {
        _bindingSource = (BindingSource)OrdersGridView.DataSource;
        OrdersGridView.Columns[2].DefaultCellStyle.Format = "N";
        OrdersGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        RefreshGrossAmount();
    }

    public OrderEntry[] GetOrders()
    {
        OrderEntry[] orderEntries = new OrderEntry[_bindingSource.List.Count];
        _bindingSource.List.CopyTo(orderEntries, 0);
        return orderEntries;
    }

    public bool HasOrders()
    {
        return _bindingSource.List.Count > 0;
    }
    public void AddOrder(Item item, int count)
    {
        _bindingSource.Add(new OrderEntry(item, count));
        RefreshGrossAmount();
    }

    public void ClearOrders()
    {
        _bindingSource.Clear();
    }

    private void OrdersGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        PromptRemoveOrder(e.RowIndex);
    }

    private void PromptRemoveOrder(int index)
    {
        DialogResult result = MessageBox.Show($"Remove {_bindingSource[index]}?", "Warning", MessageBoxButtons.YesNo);

        if(result == DialogResult.Yes)
        {
            _bindingSource.RemoveAt(index);
            RefreshGrossAmount();
        }
    }

    private void RefreshGrossAmount()
    {
        var grossAmount = _bindingSource.List.Cast<OrderEntry>().Sum(orderEntry => orderEntry.Amount);
        GrossAmountText.Text = $"{grossAmount:N2}";
    }
}
