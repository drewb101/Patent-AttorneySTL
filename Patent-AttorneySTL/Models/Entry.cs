using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Patent_AttorneySTL.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string Company { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }
        public string Status { get; set; }
    }
}