using System;

namespace Library
{
    public class Patient
    {
        public string Name {get;set;}
        public string Id {get;set;}
        public string PhoneNumber {get;set;}

        public Patient(string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }

        public bool IsValid()
        {
            return !(String.IsNullOrEmpty(this.Name) && String.IsNullOrEmpty(this.Id) && String.IsNullOrEmpty(this.PhoneNumber));
        }
    }
}
