using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Interfaces
{
    public interface IMountainsContextDAO
    {
        List<Mountain> GetAllMountains();
        Mountain GetMountainById(int id);
        int? RemoveMountainById(int id);
        int? UpdateMountain(Mountain mountain);
        int? Add(Mountain mountain);
    }
}
