using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public interface Iperson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName {  get; set; }
        UInt64 PhoneNumber {  get; set; }
        string Addres {  get; set; }
        string GetBasicInfo();
    }
}
