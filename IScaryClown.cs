using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_interface
{
    interface IScaryClown:IClown
    {
        String ScaryThinkIHave { get; }
        void ScareLittleChildren();
    }
}
