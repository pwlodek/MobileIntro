using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MobileApp.Model;
using Newtonsoft.Json;

namespace MobileApp.Services
{
    public class BackendService : IBackendService
    {
        public BackendService()
        {
        }

        public void AddAsync(string name)
        {
			Item item = new Item()
			{
				Name = name,
				Completed = false,
				DueDate = DateTime.Now,
				UserName = "Piotrek"
			};

			String json = JsonConvert.SerializeObject(item);
			HttpClient client = new HttpClient();

			HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

			client.PostAsync("https://pwlodek.azurewebsites.net/api/items", content);
        }

        public async Task<IList<Item>> GetAllAsync()
        {
			var client = new HttpClient();
			var list = await client.GetStringAsync("https://pwlodek.azurewebsites.net/api/items");
			var items = JsonConvert.DeserializeObject<IList<Item>>(list);

            return items;
        }
    }
}
