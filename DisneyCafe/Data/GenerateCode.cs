using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Data
{
    public class GenerateCode
    {
        public static string GenerateOrderNumber()
        {
            return Convert.ToString(Guid.NewGuid());
        }
    }
}
