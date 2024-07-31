using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Ders_Keywords_.Classes
{
    internal class Database
    {
        public const double tax = 0.04;

        public readonly string connectionKeyword;

        public Database(string connectionKey)
        {
            connectionKeyword = connectionKey;
        }
    }
}
