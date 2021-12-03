using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Tsunami
    {
        public int Id { get; set; }

        public string Element { get; set; }

        public string Type { get; set; }

        public int HeightInFeet { get; set; }

        public string Where { get; set; }

        public int Year { get; set; }
    }
}
