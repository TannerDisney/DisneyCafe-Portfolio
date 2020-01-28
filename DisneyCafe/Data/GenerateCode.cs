using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DisneyCafe.Data
{
    public class GenerateCode
    {
        public static string GenerateOrderNumber(int length)
        {
            Random random = new Random();
            string alphanumeric = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                                    "abcdefghijklmnopqrstuvwxyz" +
                                    "1234567890";

            return new string(alphanumeric.Select(c => alphanumeric[random.Next(alphanumeric.Length)]).Take(length).ToArray());

        }
    }
}
