﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public interface Iproduct
    {
        int Id { get; set; }    
        string Name { get; set; }
        decimal Price { get; set; }
        string GetBasicInfo();
    }
}
