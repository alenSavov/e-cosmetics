using e_cosmetics.Services.Accounts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_cosmetics.Services.Interfaces
{
    public interface IAccountService
    {
        Task<bool> Create(RegisterInputModel model);
    }
}
