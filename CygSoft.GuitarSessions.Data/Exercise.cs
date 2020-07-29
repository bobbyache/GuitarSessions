using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CygSoft.GuitarSessions.Data
{
    public class Exercise
    {
        public int Id { get; set; }

        [MaxLength(280)]
        public string Title { get; set; }

        [MaxLength(280)]
        public string Description { get; set; }
    }
}
