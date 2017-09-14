namespace PolymorphismExample.Vehicles
{
    public class Car : Vehicle
    {
        public override int Seats => NUMBER_OF_SEATS;
        private const int NUMBER_OF_SEATS = 5;

        public override string IntroduceYourself()
        {
            return $"{base.IntroduceYourself()} I'm a car!";
        }
    }
}
