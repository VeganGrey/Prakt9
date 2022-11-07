using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt9
{
    internal struct Puple
    {
        public string LastName {get;set;}
        public string Street { get;set;}
        public int House { get;set;}
        public int Kvart { get;set;}
        public Puple(string lastname,string street,int house,int kvart)
        {
            LastName = lastname;
            Street = street;
            House = house;
            Kvart = kvart;
        }
    }
}
