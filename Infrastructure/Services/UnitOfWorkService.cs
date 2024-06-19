using Core.Interface;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private bool _disposed;

        public IStudentInfo StudentInfo { get; set; }
        public IBlogPost BlogPost {  get; set; }
        public ICategory Category { get; set; }

        public UnitOfWorkService(
            ApplicationDbContext context, 
            IStudentInfo studentinfo, 
            IBlogPost blogPost,
            ICategory category
        )
        {
            _context = context ?? throw new ArgumentException(nameof(context));
            StudentInfo = new StudentInfoService(context);
            BlogPost = new BlogPostService(context);
            Category = category;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}
