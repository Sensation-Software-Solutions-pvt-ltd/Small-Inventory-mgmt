using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class ItemTypedropdown
    {
        public ItemTypedropdown(int typeid, string typename)
        {
            ItemTypeId = typeid;
            ItemTypeName = typename;
        }
        public int ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
    }
}
