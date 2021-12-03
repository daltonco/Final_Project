using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Mountain
    {
        //COLTON DALTON
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int HeightInFeet { get; set; }

        public string Country { get; set; }

        public string Range { get; set; }

        public string Parent { get; set; }
    }
}
