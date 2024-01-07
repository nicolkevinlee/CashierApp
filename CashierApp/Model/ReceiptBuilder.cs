using CashierApp.Extensions;
using CashierApp.Resource;
using CashierApp.Wrappers;
using System;
using System.Text;
using System.Xml.Linq;

namespace CashierApp.Model;

public class ReceiptBuilder
{
    private IDateTime _dateTime;
    private StringBuilder _output;
    private int _descriptionColumnWidth;

    private const int _receiptWidth = 40;
    private const int _qtyColumnWidth = 4;
    private const int _amountColumntWidth = 9;

    public ReceiptBuilder(IDateTime dateTime) 
    {
        _dateTime = dateTime;
        _output = new StringBuilder();
        _descriptionColumnWidth = _receiptWidth - _qtyColumnWidth - _amountColumntWidth - 1;
    }

    public string Generate(OrderEntry[] orderEntries, decimal paidAmount, decimal changeAmount)
    {
        _output.Clear();
        GenerateHeaderText();
        GenerateOrdersText(orderEntries);
        GenerateSummaryText(orderEntries, paidAmount, changeAmount);       

        return _output.ToString();
    }

    private void GenerateHeaderText()
    {
        _output.AppendLine( ReceiptData.CompanyName.GenerateCenteredString(_receiptWidth));
        var wrappedAddress = ReceiptData.Address.WrapString((int)(_receiptWidth * 0.6));

        //Add Header
        foreach (string text in wrappedAddress)
        {
            _output.AppendLine(text.GenerateCenteredString(_receiptWidth));
        }

        _output.AppendLine($"TIN: {ReceiptData.TinValue}".GenerateCenteredString(_receiptWidth));
        _output.AppendLine($"MIN: {ReceiptData.MinValue}".GenerateCenteredString(_receiptWidth));
        _output.AppendLine($"SERIAL NO: {ReceiptData.SerialNumberValue}".GenerateCenteredString(_receiptWidth));
        _output.AppendLine();

        _output.AppendLine($"Date: {_dateTime.Now().ToString("MM/dd/yyyy")}");
        _output.AppendLine($"Time: {_dateTime.Now().ToString("hh:mm tt")}");
    }

    private void GenerateOrdersText(OrderEntry[] orderEntries)
    {
        _output.AppendLine(new String('-', _receiptWidth));
        var paddedName = "DESCRIPTION";
        paddedName = paddedName.PadRight(_descriptionColumnWidth);
        _output.AppendLine($"{"QTY", -_qtyColumnWidth}{paddedName} {"AMOUNT",_amountColumntWidth}");
        foreach (var entry in orderEntries)
        {
            GenerateOrderRow(entry);
        }
        _output.AppendLine(new String('=', _receiptWidth));
    }

    private void GenerateSummaryText(OrderEntry[] orderEntries, decimal paidAmount, decimal changeAmount)
    {
        var grossAmount = orderEntries.Sum(entry => entry.Amount);
        var grossAmountText = $"Gross Amount: {grossAmount,15:N2}";
        _output.AppendLine($"{grossAmountText,_receiptWidth}");

        var amountPaidText = $"Amount Paid: {paidAmount,15:N2}";
        _output.AppendLine($"{amountPaidText,_receiptWidth}");

        var changeText = $"Change: {changeAmount,15:N2}";
        _output.AppendLine($"{changeText,_receiptWidth}");
    }


    public void GenerateOrderRow(OrderEntry orderEntry)
    {
        var paddedName = (_descriptionColumnWidth <= orderEntry.Name.Length) ? 
                            orderEntry.Name.Substring(0, _descriptionColumnWidth) : 
                            orderEntry.Name.PadRight(_descriptionColumnWidth);
        _output.AppendLine($"{orderEntry.Count,-_qtyColumnWidth}{paddedName} {orderEntry.Amount,_amountColumntWidth:N2}");
    }
}
