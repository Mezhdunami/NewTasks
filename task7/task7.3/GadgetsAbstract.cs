using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task7
{
    public abstract class GadgetsAbstract
    {
        public abstract string Description { get; }

        public abstract void TurnOn();
        public abstract void TunrnOff();
    }
}

