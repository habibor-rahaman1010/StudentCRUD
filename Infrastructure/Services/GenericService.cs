using Core.Entities;
using Core.Interface;
using Core.ViewModel;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        public GenericService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<PagerViewModel<T>> GetAllByPageSizeAsync(int page = 1)
        {
            var students =  await _context.Set<T>().ToListAsync();
            const int pageSize = 5;
            if (page < 1)
            {
                page = 1;
            }
            int recsCount = students.Count();
            var pager = new Pager(recsCount, page, pageSize);
            int recSkip = (page - 1) * pageSize;
            var data = students.Skip(recSkip).Take(pageSize).ToList();

            var viewModel = new PagerViewModel<T>
            {
                Students = data,
                Pager = pager
            };
            return viewModel;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var findStudent = await _context.Set<T>().FindAsync(id);
            if (findStudent != null)
            {
                return findStudent;
            }
            else
            {
                throw new Exception($"Entity with ID {id} not found.");
            }
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return entity;
        }
        public Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
        public Task DeleteAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            return Task.CompletedTask;  
        }
    }
}
