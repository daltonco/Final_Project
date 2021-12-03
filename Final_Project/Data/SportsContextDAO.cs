
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class SportsContextDAO : ISportsContextDAO
    {
        private SportsTeamsContext _context;
        public SportsContextDAO(SportsTeamsContext context)
        {
            _context = context;
        }

        public List<Teams> GetAllTeams()
        {
            return _context.BestTeams.ToList();
        }

        public Teams GetTeamById(int id)
        {
            return _context.BestTeams.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
    }
}
