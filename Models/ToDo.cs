using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFinlanTechnical.Models
{
    public class ToDo
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }

        [Column(TypeName = "int")]
        public Boolean IsComplete { get; set; }
    }
}
