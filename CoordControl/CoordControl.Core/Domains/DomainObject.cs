using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoordControl.Core.Domains
{
    public abstract class DomainObject
    {
        public long ID { get; protected set; }
    }
}
