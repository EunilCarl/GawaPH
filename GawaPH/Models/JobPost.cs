using System;
using System.ComponentModel.DataAnnotations;

namespace GawaPH.Models
{
    public class JobPost
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public string SkillsRequired { get; set; }

        public DateTime PostedDate { get; set; } = DateTime.Now;

        public int ClientId { get; set; } // Future: foreign key to User
    }
}
