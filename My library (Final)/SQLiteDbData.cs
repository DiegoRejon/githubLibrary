using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SQLiteDb
{
    public class User
    {
        public int Id { get; }
        public string First_name { get; }
        public string Last_name { get; }

        public User(int id, string first_name, string last_name)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
        }
    }
    public partial class SQLiteConn
    {
        public List<User> GetUsersById()
        {
            List<User> users = new List<User>();
            string sql= "SELECT * FROM users"
                        + " ORDER BY first_name";
            using (SQLiteRecordSet rs = ExecuteQuery(sql)) //Se ejecuta el query y guarda la tabla
            {
                while (rs.NextRecord()) //Mientras las llamadas a Next Record sean verdaderos
                {
                    users.Add(new User(rs.GetInt32("id"),
                                       rs.GetString("first_name"),
                                       rs.GetString("last_name")));
                    //levels.Add(rs.GetString("description")); //Se extran los datos de la base de datos
                }
            }
            return users;
        }
    }
}
