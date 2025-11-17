using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Drink: MenuItem
    {
        public int VolumeInMl { get; private set; }
        public bool IsAlcoholic { get; private set; }

        public Drink(string name, decimal price, int volumeInMl, bool isAlcoholic)
            : base(name, price)
        {
            VolumeInMl = volumeInMl;
            IsAlcoholic = isAlcoholic;
        }

        public override void Display()
        {
            string alcoholInfo = IsAlcoholic ? "Алкогольний" : "Безалкогольний";
            Console.WriteLine($"- {Name} ({alcoholInfo}, {VolumeInMl} мл) - {Price} грн");
        }
    }
}
