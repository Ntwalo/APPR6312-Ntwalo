﻿using Ntwalo_APPR6312.Data;
using Ntwalo_APPR6312.Interfaces;
using Ntwalo_APPR6312.Models;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Ntwalo_APPR6312.Repository
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly ApplicationDbContext? _context;

        public ApplicationUserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(ApplicationUser applicationUser)
        {
            _context.Add(applicationUser);
            return Save();
        }

        public bool Delete(ApplicationUser applicationUser)
        {
            _context.Remove(applicationUser);
            return Save();
        }

        public async Task<IEnumerable<ApplicationUser>> GetAll()
        {
            return await _context.ApplicationUsers.ToListAsync();
        }

        public async Task<ApplicationUser> GetByIdAsync(int id)
        {
            return await _context.ApplicationUsers.FirstOrDefaultAsync(i => i.UserId == id);
        }

        public async Task<IEnumerable<ApplicationUser>> GetUserByUserName(string userName)
        {
            return (IEnumerable<ApplicationUser>)await _context.ApplicationUsers.FirstOrDefaultAsync(i => i.UserName == userName);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(ApplicationUser applicationUser)
        {
            _context.Update(applicationUser);
            return Save();
        }
    }
}
