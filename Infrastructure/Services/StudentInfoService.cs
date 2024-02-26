using Core.Entities;
using Core.Interface;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class StudentInfoService : GenericService<StudentTable>, IStudentInfo
    {
        public StudentInfoService(ApplicationDbContext context) : base(context) { }
    }
}
