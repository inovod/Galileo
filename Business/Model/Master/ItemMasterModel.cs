using Business.Model.common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Model.Master
{
    public class ItemMasterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CollectionItemMaserModel : ValidationModel
    {
        public List<ItemMasterModel> CollectionItem { get; set; }
    }
}
