using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarfsDiamond.models.Entities
{
    class ACEntity:IEntity
    {
        protected string m_sName=null;
        protected string m_sID = null;

        public string Name { get { return m_sName; } }
        public string ID { get { return m_sID; } }
    }
}
