namespace PlayingInstruments
{
    public class Violin : StringedInstrument
    {
        public Violin(int value = 4)
        {
            name = "Violin";
            numberOfStrings = value;
        }

        public override string Sound()
        {
            return "screech";
        }
    }
}
