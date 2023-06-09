using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_interface
{
    class FunyFuny : IClown
    {
        private string funnyThingsIHave = "";
        public string FunnyThingsIHave { get { return funnyThingsIHave; } }

        public FunyFuny(string _funnyThings)
        {
            funnyThingsIHave = _funnyThings;

        }

        public void Honk()
        {
            Console.WriteLine($"Cześć dzieciaki! Mam: {FunnyThingsIHave}.");
        }

    }
}