using DemoCoreWebApp.Core.Interfaces;
using System;

namespace DemoCoreWebApp.Core.Domain
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentCategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
