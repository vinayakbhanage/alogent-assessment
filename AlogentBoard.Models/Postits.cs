using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlogentBoard.Models
{
    public class Postits
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Note { get; set; }

        public DateTime Date { get; set; }
    }
}
