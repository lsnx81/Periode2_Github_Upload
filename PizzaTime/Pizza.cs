namespace PizzaTime
{
    internal class Pizza
    {
        private string toppings;
        private int diameter;
        private double price;

        public Pizza(string toppings, int diameter, double price)
        {
            Toppings = toppings;
            Diameter = diameter;
            Price = price;
        }

        /// <summary>
        /// Topping Hetgeen wat op pizza ligt.
        /// </summary>
        /// <remarks>Moet een geldige waarde hebben. Foute Waarde of NULL is niet aanvaard.</remarks>
        /// <exception cref="ArgumentException"> laat Null or Empty niet toe. </exception>

        public string Toppings
        {
            get => toppings;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(Toppings)}, Moet een geldige waarde hebben. Foute Waarde of NULL is niet aanvaard.");
                }
                toppings = value;
            }
        }

        /// <summary>
        /// Diameter bepaalt de grootte van de pizza.
        /// </summary>
        /// <remarks>Diameter moet tussen 10 en 30 cm zijn..</remarks>
        /// <exception cref="ArgumentException"> Diameter moet tussen 10 en 30 cm zijn.. </exception>
        public int Diameter
        {
            get => diameter;
            set
            {
                if (value < 10 || value > 30)
                {
                    throw new ArgumentException($"Diameter moet tussen 10 en 30 cm zijn. Uw waarden {value} is ongeldig", nameof(Diameter));
                }

                diameter = value;
            }
        }

        /// <summary>
        /// Prijs is de prijs in euro voor de pizza
        /// </summary>
        /// <remarks>Prijs kan niet negatief zijn</remarks>
        /// <exception cref="ArgumentException"> Prijs kan niet negatief zijn </exception>
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"Prijs kan niet negatief zijn", nameof(Price));
                }
                price = value;
            }
        }

        public override string ToString()
        {
            return $"Topping:{Toppings} Diameter:{Diameter} Prijs:{Price}";
        }
    }
}