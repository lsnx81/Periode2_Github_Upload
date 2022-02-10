namespace Assignment_Dierenrijk_DierenrijkExtra
{

    internal abstract class Animal
    {
        virtual public void ToonInfo()
        {
            Console.WriteLine($"Eigenschappen van {this.GetType().Name} met namen {Naam} zijn:");
            foreach (var prop in this.GetType().GetProperties())
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(this)}");

            }
        }


        public string Naam { get; set; }

        public Animal(string naam)
        {
            Naam = naam;
        }
    }
}


