using System;
namespace MobileApp.Model
{
    public class Item
    {
        public Item()
        {
        }

		public string Name { get; set; }

		public bool Completed { get; set; }

		public DateTime DueDate { get; set; }

		public string UserName { get; set; }
    }
}
