using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Pelijuttujentaustat {
    public class Item {
        public Guid ItemId { get; set; }
        public int ItemLevel { get; set; }
        public Itemtype ItemType { get; set; }
        public DateTime CreationDate { get; set; }
    }

    public class NewItem {
        [Range (1, 99)]
        public int ItemLevel { get; set; }
        public Itemtype ItemType { get; set; }
        [DataType (DataType.Date)]
        [ValidateAttribute]
        public DateTime CreationDate { get; set; }

    }
    public enum Itemtype {
        sword,axe,mace
    }

    public class ModifiedItem {
        public int ItemLevel { get; set; }
    }
}