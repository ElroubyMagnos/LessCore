using ElroubyLessCore.Core.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElroubyLessCore.Core
{
    public partial class ClassListBox : ListBox
    {
        public Container Content { get; set; }
        public ClassListBox()
        {
            InitializeComponent();

            Content = new Container(this);
        }
    }
}
