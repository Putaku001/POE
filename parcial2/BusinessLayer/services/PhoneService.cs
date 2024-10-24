using CommonLayer.Entities;
using DataAccessLayer.Repositories;
using System.Collections.Generic;

namespace BusinessLayer.services
{
    public class PhoneService
    {
        private readonly PhoneRepository phoneRepository = new PhoneRepository();

        public List<Phone> GetAllPhones()
        {
            return phoneRepository.GetPhones();
        }

        public void AddPhone(Phone phone)
        {
            phoneRepository.AddPhone(phone);
        }

        public void UpdatePhone(Phone phone)
        {
            phoneRepository.EditPhone(phone);
        }

        public void DeletePhone(int phoneID)
        {
            phoneRepository.DeletePhone(phoneID);
        }
    }
}
