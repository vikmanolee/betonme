using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public List<Market> Markets { get; set; }
    }
}
