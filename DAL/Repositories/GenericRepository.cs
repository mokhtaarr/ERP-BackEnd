using DAL.Context;
using Microsoft.EntityFrameworkCore;
using RepositoryPatternWithUOW.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using DAL.Models;
using System.Linq.Expressions;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ERPContext _db;
        public GenericRepository(ERPContext db)
        {
            _db = db;
        }

        public async Task<T> Find(Expression<Func<T, bool>> criteria)
        {
            return  await _db.Set<T>().SingleOrDefaultAsync(criteria);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _db.Set<T>()
                .Where(c => !EF.Property<DateTime?>(c, "DeletedAt").HasValue)
                .OrderByDescending(c => EF.Property<DateTime>(c, "CreatedAt")).AsNoTracking()
                .ToListAsync();
        } 

       
    }
}
