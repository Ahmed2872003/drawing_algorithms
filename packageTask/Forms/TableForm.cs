using System.Collections.Generic;
using System.Windows.Forms;

namespace packageTask.Forms
{
    abstract public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        public void InitializeTable(List<string> columns)
        {

            foreach (string columnName in columns)
            {
                DGV.Columns.Add(columnName + "Column", columnName);
            }

        }


        abstract public void fillTable(object res);
    }
}
