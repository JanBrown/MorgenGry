using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorgenGry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets { get; set; } = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet GetAmulet(string itemId)
        {
            foreach (var a in amulets)
            {
                if (a.ItemId == itemId)
                    return a;
            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0.0;

            foreach (var a in amulets)
            {
                totalValue += Utility.GetValueOfAmulet(a);
            }

            return totalValue;
        }
    }
}
