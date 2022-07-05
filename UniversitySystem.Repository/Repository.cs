using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using UniversitySystem.Classes;
namespace UniversitySystem.Repository
{
    public class Repository
    {
        public void Create(string name)
        {
            // sqlConnection
            // query : Insert : client data
            // sqlCommand (query )
        }

        public void Update()
        {
            // sqlConnection
            // query : Update : client data
            // sqlCommand (query )
        }

        //Create Student --> C
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
            //querystring = $"select * from Users where ID = {newUser.CardID} and password = {newUser.Password}";
            //SqlCommand cmd2 = new SqlCommand(querystring, con);

            //SqlDataAdapter adapter = new SqlDataAdapter(cmd2);//for read table from db 
            //DataSet tables = new DataSet(); //can read data from row and column 
            //adapter.Fill(tables);


            //var x = tables.Tables[0].Rows;
            //foreach( DataRow row in x)
            //{
            //    var id = row["ID"];
            //    var name = row["Name"];
            //    var password = row["Password"];
            //    var CollegeID = row["College_ID"];
            //}
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

        public void Dalete()
        {
            // sqlConnection
            // query : Delete : client data
            // sqlCommand (query )
        }

        public void Read()
        {
            // sqlConnection
            // query : Select : client data
            // sqlCommand (query )
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