using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Models
{
    public class Customer : Iperson

    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ulong PhoneNumber { get; set; }
        public string Addres { get; set; }


        

        public ObservableCollection<product> SelectedProducts { get; private set; } = new ObservableCollection<product>();
        public ObservableCollection<Customer> customers { get; private set; } = new ObservableCollection<Customer>();


        // افزودن محصول به لیست انتخابی مشتری
        public void AddSelectedProduct(product product)
        {
            if (product != null)
            {
                SelectedProducts.Add(product);
               // Console.WriteLine($"{product.Name} added to the selected products of customer {Id}.");
            }
            else
            {
                Console.WriteLine("Invalid product.");
            }
        }


        // حذف محصول از لیست انتخابی مشتری
        public void RemoveSelectedProduct(product product)
        {
            if (product != null && SelectedProducts.Contains(product))
            {
                SelectedProducts.Remove(product);
               // Console.WriteLine($"{product.Name} removed from the selected products of customer {Id}.");
            }
            else
            {
                Console.WriteLine("Invalid product or not in the selected products list.");
            }
        }


        public string GetBasicInfo()
        {
            string str = FirstName + " " + LastName + "\nPhoneNumber : " + PhoneNumber + "\n Address : " + Addres + "\n Selected Products: ";
            foreach (var product in SelectedProducts)
            {
                str += product.Name + ", ";
            }
            return str;
        }
    }


    //public string GetBasicInfo()
    //    {
           

    //        string str = FirstName + " " + LastName + "\nPhoneNumber : " + PhoneNumber + "\n Address : " + Addres 
    //                      ;

    //        return str;
    //    }



    } 
