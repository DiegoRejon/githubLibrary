using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_library__Final_
{
    public partial class OrderByName : Form
    {
        private Library library; //Guarda referencia
        public OrderByName(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void OrderByName_Load(object sender, EventArgs e)
        {
            dgvOrderByName.DataSource = library.GetUsersById();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
