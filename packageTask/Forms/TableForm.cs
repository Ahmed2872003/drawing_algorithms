using System.Collections.Generic;
using System.Windows.Forms;

namespace packageTask.Forms
{
    abstract public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();

            Deactivate += BringToFront;

        }

        public void InitializeTable(List<string> columns)
        {

            foreach (string columnName in columns)
            {
                DGV.Columns.Add(columnName + "Column", columnName);
            }

        }


        abstract public void fillTable(object res);

        private void BringToFront(object sender, System.EventArgs e)
        {
            TopMost = true;
        }
    }
}
