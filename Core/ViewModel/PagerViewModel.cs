﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModel
{
    public class PagerViewModel<T>
    {
        public List<T>? Students { get; set; }
        public Pager? Pager { get; set; }
    }
}
