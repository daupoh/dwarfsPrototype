using dwarfsDiamond.models.Arm;
using dwarfsDiamond.models.Set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models
{
    interface IArm:IAskingStown
    {
        ISet[] checkSets(); //return numbers of finded sets
        void getStownFromDek();
       
    }
}
