using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetonMe.Models
{
    public class Selection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Market Market { get; set; }
        public float Odds { get; set; }
        public Result Result { get; set; }
    }
}
