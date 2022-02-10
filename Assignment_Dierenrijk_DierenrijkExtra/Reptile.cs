namespace Assignment_Dierenrijk_DierenrijkExtra
{
    internal class Reptile:Animal
    {
        public uint AantalSchubben { get; set; }

        public Reptile(uint aantalSchubben,string naam):base(naam)
        {
            AantalSchubben = aantalSchubben;
        }

        public override void ToonInfo()
        {
            base.ToonInfo();
        }
    }
}


