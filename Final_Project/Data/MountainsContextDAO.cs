using Final_Project.Interfaces;
using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Data
{
    public class MountainsContextDAO : IMountainsContextDAO
    {
        private MountainsContext _context;
        public MountainsContextDAO(MountainsContext context)
        {
            _context = context;
        }

        public List<Mountain> GetAllMountains()
        {
            return _context.TallestMountains.ToList();
        }

        public Mountain GetMountainById(int id)
        {
            return _context.TallestMountains.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public Mountain RemoveMountainById(int id)
        {
            var mountain = this.GetMountainById(id);
            if (mountain == null) return null;
            try
            {
                _context.TallestMountains.Remove(mountain);
                _context.SaveChanges();
                return mountain;
            }
            catch(Exception)
            {
                return new Mountain();
            }
        }
    }
}
