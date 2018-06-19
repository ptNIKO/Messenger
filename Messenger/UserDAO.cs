using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Messenger
{
    class UserDAO
    {
        public void AddUser(User user)
        {
            string conStr = @"Data Source=BOS;Initial Catalog=Messenger;Integrated Security=True";
            SqlConnection coon = new SqlConnection(conStr);
            try
            {
                coon.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            SqlCommand cmd = new SqlCommand("Insert into Users (FirstName, Email, Password) Values (@firstname,@email,@password)", coon);
            cmd.Parameters.Add("@firstname", SqlDbType.NVarChar).Value = user.FirstName;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = user.Email;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = user.Password;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            coon.Close();

        }
        
       public User GetUser (String email,String password)
        {
            User res;
            string connStr = @"Data Source=BOS;Initial Catalog=Messenger;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (SqlException se)
            {
                throw se;
            }

            SqlCommand cmd = new SqlCommand("Select * From Users Where Email = @email And Password = @password", conn);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = password;

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows && dr.Read())
            {
                String nickname = dr.GetString(1);
                email = dr.GetString(2);
                password = dr.GetString(3);
                res = new User(nickname,email, password);
            }
            else
            {
                conn.Close();          
                throw new ArgumentException("User not found");
            }

            conn.Close();
            return res;
        }

    }
}
