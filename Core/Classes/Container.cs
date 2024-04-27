using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElroubyLessCore.Core.Classes
{
    public class Container : List<FileWithNumber>
    {
        ClassListBox ParentOf;
        public Container(ClassListBox ParentOf) : base()
        {
            this.ParentOf = ParentOf;
        }
        public new void Add(FileWithNumber File)
        {
            ParentOf.Items.Add(File.Name);

            base.Add(File);

            Main.MainForm.SaveProject_Click(null, null);
        }
        public new void Remove(FileWithNumber File)
        {
            ParentOf.Items.Remove(File.Name);

            base.Remove(File);

            Main.MainForm.SaveProject_Click(null, null);
        }
        public new void Clear()
        {
            ParentOf.Items.Clear();

            base.Clear();
        }
    }
}
