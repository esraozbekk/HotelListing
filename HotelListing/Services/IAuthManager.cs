using HotelListing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace HotelListing.Services
{
    public interface IAuthManager
    {
        Task<bool> ValideteUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
    }
}
