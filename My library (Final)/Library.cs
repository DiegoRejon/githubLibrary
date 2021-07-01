using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLiteDb;

namespace My_library__Final_
{
    public class Library
    {
        private SQLiteConn conn;
        public Library()
        {
            conn = new SQLiteConn("library.db", true);
        }
        public List<User> GetUsersById()
        {
            return conn.GetUsersById();
        }
        public void close()
        {
            conn.Close();
        }
    }
}
