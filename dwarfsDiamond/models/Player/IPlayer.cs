using dwarfsDiamond.models.Arm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.Player
{
    interface IPlayer:IAskingStown
    {
        string Name { get; }
        void grabStownFromDek();
        void checkSetsInArm();
        void askPlayerForStown(IPlayer anotherPlayer, string stownsName);
    }
}
