using CashierApp.DataAccessor;
using CashierApp.DTO;
using CashierApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApp.Data
{
    internal class ItemsDBRepository : IRepository
    {
        private IDatabaseAccessor _databaseAccessor;

        public ItemsDBRepository(IDatabaseAccessor databaseAccessor) 
        {
            _databaseAccessor = databaseAccessor;
        }

        public Task<List<Item>> GetItemList()
        {
            var results = _databaseAccessor.Read();

            return Task.FromResult(ToItems(results));
        }

        private List<Item> ToItems(List<ItemsResult> root)
        {

            if (root is null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            return root.Select(item => (Item)item).ToList();
        }
    }
}
