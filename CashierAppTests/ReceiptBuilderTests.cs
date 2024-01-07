using CashierApp.Data;
using CashierApp.Model;
using CashierApp.Wrappers;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CashierAppTests;

[TestFixture]
internal class ReceiptBuilderTests
{
    private Mock<IDateTime> _dateTimeMock;
    private ReceiptBuilder _cut;

    [SetUp]
    public void SetUp()
    {
        _dateTimeMock = new Mock<IDateTime>();
        _cut = new ReceiptBuilder(_dateTimeMock.Object);
    }

    [Test]
    public void GetItemList_ShallReturnItemList()
    {
        _dateTimeMock.Setup(mock => mock.Now())
            .Returns(new DateTime(2024, 1, 7, 0, 10, 0));

        OrderEntry[] entries = new OrderEntry[]
        {
            new OrderEntry(new Item(1,"Test 1", 10), 10),
            new OrderEntry(new Item(3,"Test 3", 100), 1),
            new OrderEntry(new Item(2,"Test 2", 50), 3)
        };

        var result = _cut.Generate(entries, 500, 150);

        ClassicAssert.AreEqual(GetItemList_ShallReturnItemList_ExpectedResult(), result);
    }

    private string GetItemList_ShallReturnItemList_ExpectedResult()
    {
        return """
                          Company Name              
                        1111 Any St. Any            
                    District, Any City, Any         
                          Country 1001              
                        TIN: 1234567890             
                        MIN: 9876543210             
                     SERIAL NO: 2468013579          

            Date: 01/07/2024
            Time: 12:10 AM
            ----------------------------------------
            QTY DESCRIPTION                   AMOUNT
            10  Test 1                        100.00
            1   Test 3                        100.00
            3   Test 2                        150.00
            ========================================
                       Gross Amount:          350.00
                        Amount Paid:          500.00
                             Change:          150.00

            """;
    }
}
