namespace PolymorphismExample.Vehicles
{
    public class Motorcycle: Vehicle
    {
        public override int Seats => NUMBER_OF_SEATS;
        private const int NUMBER_OF_SEATS = 1;

        public new string IntroduceYourself()
        {
            return $"{base.IntroduceYourself()} I'm a motorcycle!";
        }
    }
}
