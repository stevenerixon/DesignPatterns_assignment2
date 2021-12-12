using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Repository;
using System;

namespace Design_Patterns_Assignment
{
    internal class RepositoryRun
    {
        DataRepository dataRepository = new DataRepository();
        public void Run()
        {
            var saveData = dataRepository.GetAllData();
            dataRepository.SaveData(saveData);

            var customer = dataRepository.GetCustomersByName();
            dataRepository.SaveCustomer(customer);

            var pet = dataRepository.GetPetByName();
            dataRepository.SavePet(pet);
        }
    }
}