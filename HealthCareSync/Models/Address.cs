using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareSync.Models
{
    public class Address
    {
        public int Id { get; }

        public string Address_1 { get; }

        public string Zip { get; }

        public string? City { get; }

        public string? State { get; }

        public string? Address_2 { get; }

        public Address(int id, string address)
        {

        }
    }
}
