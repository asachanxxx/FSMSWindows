using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class KeyValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class TwoKeyValue
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public string Name { get; set; }
    }
    public class TwoKeyNumer
    {
        public int Id1 { get; set; }
        public int Id2 { get; set; }
        public decimal Value { get; set; }
    }
    public class TwoKeyOnject
    {
        public int Id1 { get; set; }
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
