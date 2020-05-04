using System;
using System.ComponentModel.DataAnnotations;

namespace SDMS.Models
{
    public class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}