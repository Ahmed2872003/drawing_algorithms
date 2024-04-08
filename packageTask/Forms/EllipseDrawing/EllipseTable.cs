using System.Collections.Generic;

namespace packageTask.Forms.EllipseDrawing
{
    internal class EllipseTable : TableForm
    {
        private List<string> columns = new List<string>() { };

        public EllipseTable()
        {
            InitializeTable(columns);
        }


        public override void fillTable(object res)
        {
            return;
        }
    }
}
