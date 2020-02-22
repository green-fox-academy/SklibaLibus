using System;
using System.Collections.Generic;
using System.Text;

namespace PlayingInstruments
{
    public class BassGuitar : StringedInstrument
    {
        public BassGuitar(int value = 4)
        {
            name = "Bass Guitar";
            numberOfStrings = value;
        }

        public override string Sound()
        {
            return "duum-duum-duum";
        }
    }
}
