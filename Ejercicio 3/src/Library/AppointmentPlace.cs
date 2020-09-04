using System;

namespace Library
{
    public class AppointmentPlace
    {
        public string Name {get;set;}

        public AppointmentPlace(string name)
        {
            this.Name = name;
        }

        public bool IsValid()
        {
            return !(String.IsNullOrEmpty(this.Name));
        }
    }
}
