using CashierApp.Data;
using CashierApp.Model;
using CashierApp.Wrappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApp.Forms;

public partial class CheckoutForm : Form
{
    private IWriter _writer;
    private StringBuilder _payAmountText;
    private OrderEntry[] _orderEntries;
    private decimal _payAmount;
    private decimal _totalAmount;

    private event CheckoutCompleteDelegate _checkoutComplete;

    public CheckoutForm(IWriter writer, OrderEntry[] orderEntry, CheckoutCompleteDelegate checkoutComplete)
    {
        InitializeComponent();
        _writer = writer;
        _payAmountText = new StringBuilder("0.00");
        _orderEntries = orderEntry;
        _payAmount = 0;
        _totalAmount = orderEntry.Sum(orderEntry => orderEntry.Amount);
        _checkoutComplete = checkoutComplete;
    }

    private void CheckoutForm_Load(object sender, EventArgs e)
    {
        GrossAmountText.Text = $"{_totalAmount:N2}";
        UpdateTexts();
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void PayAmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back)
        {
            e.Handled = true;
        }
        else
        {
            UpdatePayAmount(e.KeyChar);
        }
    }

    private void PayAmountTextbox_TextChanged(object sender, EventArgs e)
    {
        UpdateTexts();
    }

    private void UpdatePayAmount(char keyChar)
    {
        if (_payAmountText[^3] == '.')
        {
            _payAmountText.Remove(_payAmountText.Length - 3, 1);
        }

        if (char.IsNumber(keyChar))
        {
            _payAmountText.Append(keyChar);
        }
        else if ((Keys)keyChar == Keys.Back)
        {
            if (_payAmountText.Length > 0)
            {
                _payAmountText.Remove(_payAmountText.Length - 1, 1);
            }
        }

        while (_payAmountText.Length > 3 && _payAmountText[0] == '0')
        {
            _payAmountText.Remove(0, 1);
        }
        while (_payAmountText.Length < 3)
        {
            _payAmountText.Insert(0, '0');
        }

        _payAmountText.Insert(_payAmountText.Length - 2, '.');
    }

    private void UpdateTexts()
    {
        _payAmount = decimal.Parse(_payAmountText.ToString());
        PayAmountTextbox.Text = $"{_payAmount:N2}";
        PayAmountTextbox.SelectionStart = PayAmountTextbox.Text.Length;
        ChangeText.Text = $"{_payAmount - _totalAmount:N2}";
    }

    private void SubmitButton_Click(object sender, EventArgs e)
    {
        if(IsFullyPaid())
        {
            MessageBox.Show("Total Amount is not fully paid.");
            return;
        }

        DialogResult result = MessageBox.Show("System will generate receipt.\nProceed?", "Question", MessageBoxButtons.YesNo);

        if(result == DialogResult.Yes)
        {
            WriteReceipt();
            MessageBox.Show("Receipt has been saved.");
            _checkoutComplete?.Invoke();
            Close();
        }
        
    }

    private bool IsFullyPaid()
    {
        return _totalAmount > _payAmount;
    }

    private void WriteReceipt()
    {
        var receiptBuilder = new ReceiptBuilder(new DateTimeWrapper());
        _writer.Write(receiptBuilder.Generate(_orderEntries, _payAmount, _payAmount - _totalAmount));
    }
}

public delegate void CheckoutCompleteDelegate();