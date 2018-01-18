using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Plugin.Connectivity;

namespace SW416
{
    public class SQLiteDataStore : IDataStore<Item>
    {
        IEnumerable<Item> items;

        public SQLiteDataStore()
        {
            items = new List<Item>();
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
        }

        public async Task<Item> GetItemAsync(string id)
        {
        }

        public async Task<bool> AddItemAsync(Item item)
        {
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
        }
    }
}