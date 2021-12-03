using Final_Project.Interfaces;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class TsunamiContextDAO : ITsunamiContextDAO
    {
        TallestTsunamisContext _context;
        public TsunamiContextDAO(TallestTsunamisContext context)
        {
            _context = context;
        }

        public int? Add(Tsunami tsunami)
        {
            var tsunamis = _context.TallestTsunamis.Where(x => x.Element.Equals(tsunami.Element) && x.Type.Equals(tsunami.Type)).FirstOrDefault();

            if (tsunamis != null)
                return null;

            try
            {
                _context.TallestTsunamis.Add(tsunami);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public List<Tsunami> GetAllTsunamis()
        {
            return _context.TallestTsunamis.ToList();
        }

        public Tsunami GetTsunamiById(int id)
        {
            return _context.TallestTsunamis.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveTsunamiById(int id)
        {
            var tsunami = this.GetTsunamiById(id);
            if (tsunami == null) return null;
            try
            {
                _context.TallestTsunamis.Remove((Tsunami)tsunami);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int? UpdateTsunami(Tsunami tsunami)
        {
            var tsunamiToUpdate = this.GetTsunamiById(tsunami.Id);
            if (tsunamiToUpdate == null)
                return null;

            tsunamiToUpdate.Element = tsunami.Element;
            tsunamiToUpdate.Type = tsunami.Type;
            tsunamiToUpdate.HeightInFeet = tsunami.HeightInFeet;
            tsunamiToUpdate.Where = tsunami.Where;
            tsunamiToUpdate.Year = tsunami.Year;

            try
            {
                _context.TallestTsunamis.Update((Tsunami)tsunamiToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }

        }


    }
}
