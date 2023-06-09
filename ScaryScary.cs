using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_interface
{
    class ScaryScary : FunyFuny, IScaryClown
    {
        private int scaryThingCount;

        public ScaryScary(string funnyThings, int scaryThingCount):base (funnyThings)
        {
            this.scaryThingCount = scaryThingCount;
        }
        public string ScaryThinkIHave { get { return "pająki -- "+scaryThingCount.ToString (); } }
        public void ScareLittleChildren()
        {
            Console.WriteLine($"Ha mam was zobaczcie moje {ScaryThinkIHave}!");
        }
    }
}
