﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface ICategory : IGenericService<CategoryTable>
    {
        Task<List<BlogPostTable>> GetPostsByCategoryId(Guid categoryId);
    }
}
