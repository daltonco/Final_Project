using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Interfaces
{
    public interface ITsunamiContextDAO
    {
        List<Tsunami> GetAllTsunamis();
        Tsunami GetTsunamiById(int id);
        int? RemoveTsunamiById(int id);
        int? UpdateTsunami(Tsunami tsunami);
        int? Add(Tsunami tsunami);
    }
}
