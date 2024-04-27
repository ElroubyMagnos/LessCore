using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ElroubyLessCore.Tables
{
    public class FileSave
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Path { get; set; }
        public string Text { get; set; }
        public int ProjID { get; set; }
    }
}
