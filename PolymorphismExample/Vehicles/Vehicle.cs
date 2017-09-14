namespace PolymorphismExample.Vehicles
{
    public abstract class Vehicle
    {
        public abstract int Seats { get; }
        public virtual string IntroduceYourself()
        {
            return $"I'm a vehicle!";
        }
    }
}
