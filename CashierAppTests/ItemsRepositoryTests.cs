using CashierApp.Data;
using CashierApp.Model;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace CashierAppTests;

[TestFixture]
internal class ItemsRepositoryTests
{

    private Mock<IDataAccessor> _accessorMock;
    private ItemsRepository _cut;

    [SetUp]
    public void SetUp()
    {
        _accessorMock = new Mock<IDataAccessor>();
        _cut = new ItemsRepository(_accessorMock.Object);
    }

    [Test]
    public void GetItemList_ShallReturnItemList()
    {
        var mockStrings = new List<string[]>()
        {
             new string[] { "1", "Test 1", "10"},
             new string[] { "2", "Test 2", "50"},
             new string[] { "3", "Test 3", "100"}
        };

        var expected = new List<Item>()
        {
            new Item(1, "Test 1", 10),
            new Item(2, "Test 2", 50),
            new Item(3, "Test 3", 100)
        };

        _accessorMock.Setup(mock => mock.Read(It.IsAny<string>()))
            .Returns(mockStrings);

        var result = _cut.GetItemList();

        ClassicAssert.That(expected, Is.EqualTo(result));
    }
}
