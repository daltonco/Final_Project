using Final_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Controllers;

namespace Final_Project.Data
{
    public class SportsContextDAO : ISportsContextDAO
    {
        private SportsTeamsContext _context;
        public SportsContextDAO(SportsTeamsContext context)
        {
            _context = context;
        }

        public int? Add(Teams team)
        {
            var teams = _context.BestTeamsTwo.Where(x => x.Name.Equals(team.Name)).FirstOrDefault();

            if (teams != null)
                return null;
            try
            {
                _context.BestTeamsTwo.Add(team);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public List<Teams> GetAllTeams()
        {
            return _context.BestTeamsTwo.ToList();
        }

        public Teams GetTeamById(int id)
        {
            return _context.BestTeamsTwo.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveTeamById(int id)
        {
            var team = this.GetTeamById(id);
            if (team == null) return null;
            try
            {
                _context.BestTeamsTwo.Remove(team);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int? UpdateTeam(Teams team)
        {
            var teamToUpdate = this.GetTeamById(team.Id);
            if (teamToUpdate == null)
                return null;

            teamToUpdate.Name = team.Name;
            teamToUpdate.Sport = team.Sport;
            teamToUpdate.Country = team.Country;
            teamToUpdate.League = team.League;
            teamToUpdate.Titles = team.Titles;


            try
            {
                _context.BestTeamsTwo.Update(teamToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }
    }
}
