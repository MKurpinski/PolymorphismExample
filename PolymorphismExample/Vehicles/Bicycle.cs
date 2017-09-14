namespace PolymorphismExample.Vehicles
{
    public class Bicycle: Vehicle
    {
        public override int Seats => NUMBER_OF_SEATS;
        private const int NUMBER_OF_SEATS = 1;

        public override string IntroduceYourself()
        {
            return $"{base.IntroduceYourself()} I'm a bicycle!";
        }
    }
}
