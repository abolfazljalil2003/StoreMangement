using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Access.models
{
    public interface Iproduct
    {
        int  Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        string GetBasicInfo();
    }
}
