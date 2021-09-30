using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Exercise1.models;

namespace ItemRestClient
{
   public class Worker
    {
        public async Task<IEnumerable<Item>> GetAllItemsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://exercise5.azurewebsites.net/api/items");
                IEnumerable<Item> items = await response.Content.ReadFromJsonAsync<IEnumerable<Item>>();
                return items;
            }
        }

        public async Task<Item> PostItem(Item item)
        {
            using (HttpClient client = new HttpClient())
            {
                JsonContent serializedItem = JsonContent.Create(item);
                HttpResponseMessage response = await client.PostAsync("https://exercise5.azurewebsites.net/api/items", serializedItem);
                return await response.Content.ReadFromJsonAsync<Item>();
            }
        }
    }
}
