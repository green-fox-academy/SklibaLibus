using System;

namespace PlayingInstruments
{
    public abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings = 0;

        public abstract string Sound();

        public override void Play()
        {
            Console.WriteLine($"{name}, a {numberOfStrings}" +
                                            $"-stringed instruments that {Sound()}.");
        }
    }
}
