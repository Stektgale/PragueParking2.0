using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PragueParking2._0
{
    public class Vehicle
    {
        private int size;
        private string? registrationNumber;
        public int Size 
        {
            get { return size; }
            set { size = value; } 
        }
        public string? RegistrationNumber 
        {
            get { return registrationNumber; }
            set { registrationNumber = value; } 
        } 

        public Vehicle(int size, string reg)
        {
            Size = size;
            RegistrationNumber = reg;
        }

        public Vehicle() { }
    }
}
