using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_Access.models
{
    public interface Iperson
    {
        int Id { get; set; }
        string FirstName {  get; set; }
        string LastName { get; set; }
        UInt64 PhoneNumber {  get; set; }
        string Address {  get; set; }
        string GetBasicInfo();

    }
}
