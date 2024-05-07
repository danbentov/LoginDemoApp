using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoApp.Models
{
    public class Grade
    {
        public string Subject { get; set; }

        public int Score { get; set; }
        public DateTime Date { get; set; }

        public string Email { get; set; }
        public virtual User EmailNavigation { get; set; }
    }
}

