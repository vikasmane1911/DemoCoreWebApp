using DemoCoreWebApp.Core.Interfaces;
using System;

namespace DemoCoreWebApp.Core.Domain
{
    public class Login : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
