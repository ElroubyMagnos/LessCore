using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElroubyLessCore.Tables
{
    public class Project
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string ProjName { get; set; }
        public string ProjPath { get; set; }
    }
}
