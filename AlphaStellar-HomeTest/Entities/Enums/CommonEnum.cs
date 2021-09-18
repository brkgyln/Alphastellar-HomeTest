using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public static class CommonEnum
    {
        public enum ResponseDataTypes
        {
            Error = 0,
            Success = 1,
        }

        public static class Colors
        {
            public const string White = "White";
            public const string Blue = "Blue";
            public const string Red = "Red";
            public const string Black = "Black";
        }
    }
}
