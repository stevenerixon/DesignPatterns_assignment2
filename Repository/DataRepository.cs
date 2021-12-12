using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class DataRepository
    {
        public string GetAllData()
        {
            return "All the data";
        }
        public string GetCustomersByName()
        {
            return "Steve";
        }
        public string GetPetByName()
        {
            return "Vira";
        }
        public void SaveCustomer(string customerName)
        {
            Console.WriteLine($"Saving customer: '{customerName}' to the database");
        }
        public void SavePet(string petName)
        {
            Console.WriteLine($"Saving pet: '{petName}' to the database");
        }
        public void SaveData(string data)
        {
            Console.WriteLine($"Saving all data: {data} to the database");
        }
    }
}
