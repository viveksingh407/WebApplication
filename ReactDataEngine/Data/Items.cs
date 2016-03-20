using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactDataEngine.Data
{
    public class Items
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public IList<Items> GetItems()
        {
            var data = new List<Items>() as IList<Items>;

            data.Add(new Items() { ItemId = 1, ItemName = "First", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });
            data.Add(new Items() { ItemId = 1, ItemName = "test2", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });
            data.Add(new Items() { ItemId = 1, ItemName = "tst3", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });
            data.Add(new Items() { ItemId = 1, ItemName = "First", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });
            data.Add(new Items() { ItemId = 1, ItemName = "First", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });
            data.Add(new Items() { ItemId = 1, ItemName = "First", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });
            data.Add(new Items() { ItemId = 1, ItemName = "First", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });
            data.Add(new Items() { ItemId = 1, ItemName = "First", ItemDescription = "Item Name", Details = "Test Details 1111", CreatedOn = DateTime.Now, CreatedBy = "Admin", ModifiedOn = DateTime.Now, ModifiedBy = "Admin" });

            return data;
        }
    }
}
