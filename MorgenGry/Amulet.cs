﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public enum Level { low, medium, high };

    public class Amulet : Merchandise
    {
        //public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string itemId, Level quality, string design)// : base(itemId)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;
        }
        public Amulet(string itemId, Level quality) : this(itemId, quality, null) { }
        public Amulet(string itemId) : this(itemId, Level.medium, null) { }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
