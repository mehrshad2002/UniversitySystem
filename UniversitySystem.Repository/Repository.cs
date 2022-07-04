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
            string querystring = "select * from Users";



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

                if( pass == password && ID == UserID)
                {
                    var name = Convert.ToString(Row["Name"]);
                    var CollegeID = Convert.ToInt32(Row["College_ID"]);
                    string stringID = (Convert.ToString(ID)).Substring(0,3);
                    user.Name = name;
                    user.CardID = ID;
                    user.Password = password;
                    user.CollegeID = CollegeID;
                    user.FlagPass = true;
                    user.Poss = Convert.ToInt32(stringID);
                    return true;
                    
                }
            }
            return false;
        }

    }
}