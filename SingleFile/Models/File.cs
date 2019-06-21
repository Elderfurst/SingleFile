using System;
using System.ComponentModel.DataAnnotations;

namespace SingleFile.Models
{
    public class File
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
