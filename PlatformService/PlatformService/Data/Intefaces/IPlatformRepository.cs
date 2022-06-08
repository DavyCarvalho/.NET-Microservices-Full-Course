using PlatformService.Models;
using System.Collections.Generic;

namespace PlatformService.Data.Intefaces
{
    public interface IPlatformRepository
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
    }
}
