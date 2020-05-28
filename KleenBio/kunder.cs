using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleenBio
{
    public class kunder
    {
        public kunder() { }

        int id;
        string namn;
        DateTime lastlog;

        public static MySqlCommand getAll()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " Select * from kunder";
            return command;
        }


        public kunder(DataRow dr)
        {
            ID = dr["ID"] == DBNull.Value ? ID = 0 : (int)dr["ID"];
            Namn = dr["Namn"] == DBNull.Value ? Namn = "" : (string)dr["Namn"];
            
        }

        public override string ToString() { return this.namn + "\t(ID: " + this.ID + ")"; }

        public MySqlCommand GetDeleteCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "DELETE from kunder WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", ID);
            return command;
        } 
        
        public MySqlCommand GetUpdateCommand()
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = " UPDATE kunder SET ID = @ID, Namn = @Namn, LastLog = @LastLog WHERE ID = @ID"; command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Namn", Namn);
            return command;
        }

        public int ID { get { return id; } set { id = value; } }
        public string Namn { get { return namn; }set { namn = value; } }
        public DateTime LastLog { get { return lastlog; } set { lastlog = value; } }
    }
}
