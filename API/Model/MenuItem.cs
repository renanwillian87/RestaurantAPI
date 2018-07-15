using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class MenuItem
    {
        public Menu Menu { get; set; }
        //[ForeignKey("MenuId"), Column(Order = 1)]
        public Guid MenuId { get; set; }

        public Item Item { get; set; }
        //[ForeignKey("ItemId"), Column(Order = 2)]
        public Guid ItemId { get; set; }
    }
}