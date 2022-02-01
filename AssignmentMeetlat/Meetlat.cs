namespace AssignmentMeetlat
{
    internal class Meetlat
    {
        private readonly double _lengte;

        public Meetlat(double beginLengte)
        {
            _lengte = beginLengte;
        }

        // Only the public Property (propfull) can access its private value -> Security
        public double BeginLengte
        {
            get
            {
                // Check if user is logged in

                // Check if user is authorized

                // Check if value is valid
                return _lengte;
            }
        }

        public double LengteInCm => BeginLengte * 100;

        public double LengteInKm => BeginLengte / 1000;

        public double LengteInVoet => BeginLengte * 3.2808;

    }
}