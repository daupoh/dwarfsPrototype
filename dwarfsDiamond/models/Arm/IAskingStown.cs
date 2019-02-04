using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.Arm
{
    interface IAskingStown
    {
        bool haveStown(string stownsName);
        bool haveInCount(int stownsCount);
        bool haveInTypes(string[] types, int len);
    }
}
