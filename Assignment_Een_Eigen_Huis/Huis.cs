using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Een_Eigen_Huis
{
    internal class Huis
    {
        public List<Kamer>  Kamers { get;} =new();

        public double BerekenPrijs() => Kamers.Sum(k => k.Price);

        public override string ToString()
        {
            var sb=new StringBuilder();
            sb.AppendLine(new string('▬', 83));
            sb.AppendLine($"Huis met {Kamers.Count} kamers");
            sb.AppendLine(new string('▬', 83));
            foreach(var kamer in Kamers)
            {
                sb.AppendLine($"{kamer.GetType().Name,-25}:  {kamer.Name,-15} vierkante meter {kamer.VierkanteMeter.ToString(),-5} Prijs: {kamer.Price.ToString("N0").PadLeft(10,' ')}");
            }
            sb.AppendLine(new string('─', 83));
            sb.AppendLine($"{"Totale Prijs",-25}: {BerekenPrijs().ToString("N0").PadLeft(56,' ')}");
            sb.AppendLine(new string('▬', 83));
            return sb.ToString();
        }

    }
}
