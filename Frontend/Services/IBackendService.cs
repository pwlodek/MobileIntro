using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobileApp.Model;

namespace MobileApp.Services
{
    public interface IBackendService
    {
        void AddAsync(string name);

        Task<IList<Item>> GetAllAsync();
    }
}
