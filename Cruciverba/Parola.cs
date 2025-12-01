using SQLite;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Cruciverba
{
    internal class Parola
    {
        [PrimaryKey, AutoIncrement]
        public int Id{ get; set; }
        public String parola { get; set; }

        public int sinonimo0 { get; set; }
        public int sinonimo1 { get; set; }
        public int sinonimo2 { get; set; }
        public int sinonimo3 { get; set; }
        public int sinonimo4 { get; set; }
        public int sinonimo5 { get; set; }
        public int sinonimo6 { get; set; }
        public int sinonimo7 { get; set; }
        public int sinonimo8 { get; set; }
        public int sinonimo9 { get; set; }
        public int contrario0 { get; set; }
        public int contrario1 { get; set; }
        public int contrario2 { get; set; }
        public int contrario3 { get;set; }
        public int contrario4 { get; set; }
        public int contrario5 { get;    set; }
        public int contrario6 { get; set; } 
        public int contrario7 { get; set; }
        public int contrario8 { get; set; }
        public int contrario9 { get; set; }

        public List<int> sinonimi;
        public List<int> contrari;
    }
}
