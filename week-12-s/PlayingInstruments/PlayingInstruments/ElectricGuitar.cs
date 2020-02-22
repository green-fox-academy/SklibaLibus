namespace PlayingInstruments
{
    public class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar(int value = 6)
        {
            name = "Electric Guitar";
            numberOfStrings = value;
        }

        public override string Sound()
        {
            return "twangs";
        }
    }
}
