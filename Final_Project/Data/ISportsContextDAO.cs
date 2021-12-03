using Final_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public interface ISportsContextDAO
    {
        List<Teams> GetAllTeams();
        Teams GetTeamById(int id);
    }
}
