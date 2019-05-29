using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class Packages
    {
        public int PackageId { get; set; }
        public int PkgName { get; set; }
        public int PkgStartDate { get; set; }
        public int PkgEndDate { get; set; }
        public int PkgDesc { get; set; }
        public int PkgBasePrice { get; set; }
        public int PkgAgencyCommission { get; set; }

    }
}
