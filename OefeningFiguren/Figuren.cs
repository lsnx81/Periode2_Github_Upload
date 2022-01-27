using System.Runtime.CompilerServices;

namespace OefeningFiguren
{
    internal abstract class Figuren
    {
        private int breedte;
        public int Breedte { get => breedte; set => SetProperty(ref breedte, value); }
        public abstract double ToonOppervlakte();
        protected void SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
        {
           
           
                if (Convert.ToInt32(newValue) < 1)
                {
                    throw new ArgumentException("Minimumwaarde moet 1 zijn", propertyName);
                }
                field = newValue;

           
           
           
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: Oppervlakte = {ToonOppervlakte()}";
        }
    }



}
