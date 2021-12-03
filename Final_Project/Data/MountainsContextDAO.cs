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

        public int? Add(Mountain mountain)
        {
            var mountainToBeAdded = _context.TallestMountains.Where(x => x.Name.Equals(mountain.Name)).FirstOrDefault();
            if(mountainToBeAdded != null)
            {
                return null;
            }
            try
            {
                _context.TallestMountains.Add(mountain);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public List<Mountain> GetAllMountains()
        {
            return _context.TallestMountains.ToList();
        }

        public Mountain GetMountainById(int id)
        {
            return _context.TallestMountains.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public int? RemoveMountainById(int id)
        {
            var mountain = this.GetMountainById(id);
            if (mountain == null) return null;
            try
            {
                _context.TallestMountains.Remove(mountain);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

        public int? UpdateMountain(Mountain mountain)
        {
            var mountainToUpdate = this.GetMountainById(mountain.Id);
            if(mountainToUpdate == null)
            {
                return null;
            }
            mountainToUpdate.Name = mountain.Name;
            mountainToUpdate.Parent = mountain.Parent;
            mountainToUpdate.Range = mountain.Range;
            mountainToUpdate.Country = mountain.Country;
            mountainToUpdate.HeightInFeet = mountain.HeightInFeet;
            try
            {
                _context.TallestMountains.Update(mountainToUpdate);
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
