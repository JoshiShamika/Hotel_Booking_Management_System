using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group3_entity;

namespace Group3_Exception
{
    public class HMS_Exception:ApplicationException
    {


         public HMS_Exception() : base() { }
         public HMS_Exception(string errormsg) : base(errormsg) { }
    }
}
