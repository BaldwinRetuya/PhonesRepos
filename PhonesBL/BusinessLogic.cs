using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhonesModel;

namespace PhonesBL
{
    public class BusinessLogic
    {
        List<CPBrands> brands = new List<CPBrands>();
        public void AddCPBrands(CPBrands brand)
        {
            brands.Add(brand);
        }
    }
}
