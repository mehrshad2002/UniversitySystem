using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using UniversitySystem.Classes;
namespace UniversitySystem.Repository
{
    public class Repository
    {
        public bool AddStudent(User newUser)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);

            con.Open();
            string querystring = "insert into Users" +
                $" Values({newUser.CardID} , '{newUser.Name}' , {newUser.Password} , {newUser.CollegeID})";

            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                cmd.ExecuteNonQuery();

            }catch( Exception e)
            {
                return false;
            }
            return true;
        }

        public bool RemoveTeacher(string name, int ID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string querystring = "delete from Teacher " +
                $"where ID = {ID} and Name = '{name}' ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddTeacher(User user)
        {

            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "Insert into Teacher " +
                $" Values({user.CardID} , '{user.Name}' , '{user.Password}' , {user.CollegeID})";

            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                cmd.ExecuteNonQuery();
                return true; 
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool EditUser(User editUser , User user)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string querystring = "update Users " +
                $"set ID = {editUser.CardID} , Name = '{editUser.Name}' , College_ID = {editUser.CollegeID} , Password = '{editUser.Password}'" +
                $" where ID = {user.CardID}";

            SqlCommand cmd = new SqlCommand(querystring, con);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool SearchUser(string name, int ID , User user)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string querystring = $"select * from Users " +
                $"where ID = {ID} and Name = '{name}' ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet tables = new DataSet();
            adapter.Fill(tables);
            var x = tables.Tables[0].Rows;


            foreach (DataRow Row in x)
            {
                try
                {
                    user.CardID = Convert.ToInt32(Row["ID"]);
                    user.Name = Convert.ToString(Row["Name"]);
                    user.CollegeID = Convert.ToInt32(Row["College_ID"]);
                    user.Password = Convert.ToString(Row["Password"]);
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }

            return true;

        }

        public bool DeleteUser(int ID, string Name)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "delete from Users " +
                $"where Name = '{Name}' and ID = {ID} ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                cmd.ExecuteNonQuery();
                
            }catch( Exception e)
            {
                return false;
            }

            return true;
        }

        public List<User> ShowAllData()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from Users";
            SqlCommand cmd = new SqlCommand(querystring, con);


            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);

            List<User> list = new List<User>(); 
            var x = tables.Tables[0].Rows;
            foreach (DataRow row in x)
            {
                User user = new User();

                string name = (string)row["Name"];
                string password = Convert.ToString(row["Password"]);
                var id = Convert.ToInt32(row["ID"]);
                var CollegeID = Convert.ToInt32(row["College_ID"]);

                user.CardID = id;
                user.CollegeID = CollegeID;
                user.Name = name;
                user.Password = password;

                list.Add(user);
               
            }
            return list;
        }

        public bool Login(int UserID, string password , User user)
        {
            // ADO.Net 
            // Select * from LoginTable where username = username and password = password 
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);

            con.Open();
            string querystring = $"select * from Users where ID = {UserID} and password = {password}";



            SqlCommand cmd = new SqlCommand(querystring, con);
            //SqlCommand cmd = new SqlCommand(querystring, con); // and path ?
            //SqlDataReader reader = cmd.ExecuteReader(); // execute the cmd


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);

            var x = tables.Tables[0].Rows;
            foreach( DataRow Row in x )
            {
                var pass = Convert.ToString(Row["Password"]);
                var ID = Convert.ToInt32(Row["ID"]);
                var name = Convert.ToString(Row["Name"]);
                var CollegeID = Convert.ToInt32(Row["College_ID"]);
                string stringID = (Convert.ToString(ID)).Substring(0, 3);//  should be change 
                user.Name = name;
                user.CardID = ID;
                user.Password = password;
                user.CollegeID = CollegeID;
                user.FlagPass = true;
                user.Poss = Convert.ToInt32(stringID);//  should be change 
                return true;
            }
            return false;
        }

    }
}