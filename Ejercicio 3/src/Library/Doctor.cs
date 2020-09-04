using System;

namespace Library
{
    public class Doctor
    {
        public string Name {get;set;}

        public Doctor(string name)
        {
            this.Name = name;
        }

        public bool IsValid()
        {
            return !(String.IsNullOrEmpty(this.Name));
        }
    }
}
