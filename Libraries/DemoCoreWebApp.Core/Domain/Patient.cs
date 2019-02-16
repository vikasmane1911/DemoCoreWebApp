using DemoCoreWebApp.Core.Interfaces;
using System;

namespace DemoCoreWebApp.Core.Domain
{
    public class Patient : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
