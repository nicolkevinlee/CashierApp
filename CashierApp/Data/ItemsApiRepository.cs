using CashierApp.ApiDataAccess;
using CashierApp.DTO;
using CashierApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CashierApp.Data
{
    internal class ItemsApiRepository : IApiRepository
    {
        private IApiDataReader _apiDataReader;
        private static readonly string BASE_URL = "https://localhost:7236/CashierAppApi/";
        private static readonly string ITEMS = "Items";

        public ItemsApiRepository(IApiDataReader apiDataReader)
        {
            _apiDataReader = apiDataReader;
        }

        public async Task<List<Item>> GetItemList()
        {
            string? json = null;
            try
            {
                json = await _apiDataReader.Read(
                    BASE_URL, ITEMS);
            }
            catch (HttpRequestException ex)
            {
                throw new HttpRequestException($"Error calling url {BASE_URL}{ITEMS}. Please check connection", ex);
            }

            var root = JsonSerializer.Deserialize<List<ItemsResult>>(json);

            return ToItems(root);
        }

        private List<Item> ToItems(List<ItemsResult>? root) {

            if (root is null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            return root.Select(item => (Item)item).ToList();
        }
    }
}
