using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLiteDb;

namespace My_library__Final_
{
    public partial class MainForm : Form
    {
        private Library library;
        public MainForm()
        {
            InitializeComponent();
            library = new Library();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            library.close();
            Close( );
        }

        private void OrdenarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderByName form = new OrderByName(library);
            form.ShowDialog(); //Se manda a llamar al diálogo
        }

      
    }
}
