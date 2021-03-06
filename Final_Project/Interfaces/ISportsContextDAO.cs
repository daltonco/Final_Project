using Final_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Controllers;

namespace Final_Project.Data
{
    public interface ISportsContextDAO
    {
        List<Teams> GetAllTeams();
        Teams GetTeamById(int id);
        int? RemoveTeamById(int id);
        int? UpdateTeam(Teams team);
        int? Add(Teams team);
    }
}
