﻿using System;
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
            }
            catch( Exception e)
            {
                return false;
            }
            return true;
        }

        public List<Selection> AllSelection()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from Selction ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            List<Selection> Selections = new List<Selection>();
            foreach (DataRow row in AllRows)
            {
                Selection selection = new Selection();
                selection.ID = Convert.ToInt32(row["ID"]);
                selection.Capacity = Convert.ToInt32(row["Capacity"]);
                selection.TeacherID = Convert.ToInt32(row["Teacher_ID"]);
                selection.CollegeID = Convert.ToInt32(row["College_ID"]);
                selection.StudentID = 0;
                selection.dateTime = Convert.ToDateTime(row["CalssTime"]);
                selection.RoomID = Convert.ToInt32(row["Room_ID"]);
                selection.LessonID = Convert.ToInt32(row["Lesson_ID"]);
                Selections.Add(selection);
            }
            return Selections;
        }

        public bool MainSelection(int ID, int selectionID, int studentID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querySelection = "insert into SelectionList " +
                $"Values({ID},{selectionID},{studentID})";


            string queryValidation = "select * from SelectionList ";
            SqlCommand cmdValidation = new SqlCommand(queryValidation, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmdValidation);
            DataSet tables = new DataSet();
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            foreach( DataRow Row in AllRows)
            {
                int ReaderStudentID = Convert.ToInt32(Row["Student_ID"]);
                int ReaderSelectionID = Convert.ToInt32(Row["Selection_ID"]);
                if( ReaderSelectionID == selectionID && ReaderStudentID == studentID)
                {
                    return false;
                }
            }

            SqlCommand cmdSelection = new SqlCommand(querySelection, con);
            try
            {
                int Result = cmdSelection.ExecuteNonQuery();
                if (Result != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RemoveUnivercity(int ID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "delete from Univercity " +
                $"where ID = {ID} ";
            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                int Result = cmd.ExecuteNonQuery();
                if(Result != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                return false;
            }
        }

        public bool RemoveSelection(int ID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "delete from Selction " +
                $"where ID = {ID} ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                int Result = cmd.ExecuteNonQuery();
                if( Result != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                return false;
            }
        }

        public List<Lesson> Alllessons()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from Lessons ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            List<Lesson> Lessons = new List<Lesson>();
            foreach(DataRow row in AllRows)
            {
                Lesson lesson = new Lesson();
                lesson.Name = Convert.ToString(row["Name"]);
                lesson.ID = Convert.ToInt32(row["ID"]);
                lesson.CollegeID = Convert.ToInt32(row["CollegeID"]);

                Lessons.Add(lesson);
            }
            return Lessons;
        }

        public bool RemoveLesson(int ID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "delete from Lessons " +
                $"where ID = {ID}";

            SqlCommand cmd = new SqlCommand(querystring, con);

            try
            {
                int Result = cmd.ExecuteNonQuery();
                if( Result != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                return false;
            }
        }

        public bool CreateSelection(int ID,int Capacity, int collegeID, int lessonID, int roomID, int teacherID, DateTime dateTime)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "insert into Selction " +
                $"Values({ID} , '{dateTime}' , {Capacity} , null , {collegeID} , {roomID} ,{teacherID} ,{lessonID}) ";

            SqlCommand cmd = new SqlCommand(querystring, con);

            try
            {
                int Result = cmd.ExecuteNonQuery();
                if( Result != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                return false;
            }
        }

        public List<Room> AllRooms()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from Room";


            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            List<Room> rooms = new List<Room>();
            foreach(DataRow Row in AllRows)
            {
                Room room = new Room();
                room.ID = Convert.ToInt32(Row["ID"]);
                room.CollageID = Convert.ToInt32(Row["College_ID"]);

                rooms.Add(room);
            }

            return rooms;
        }

        public bool AddLesson(Lesson lesson)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "insert into Lessons " +
                $" Values({lesson.ID} , '{lesson.Name}' , {lesson.CollegeID} )";

            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                int Result = cmd.ExecuteNonQuery();
                if( Result != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch( Exception e)
            {
                return false;
            }
        }

        public List<CollegeAndUnivercity> ReadAllCollegeJoin()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select Univercity.Name as UniName , College.Name , College.ID " +
                " from college " +
                "join Univercity on College.UnivercityID = Univercity.ID";

            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            List<CollegeAndUnivercity> cuList = new List<CollegeAndUnivercity>();
            foreach(DataRow Row in AllRows)
            {
                CollegeAndUnivercity CU = new CollegeAndUnivercity();
                CU.UnivercityName = Convert.ToString(Row["UniName"]);
                CU.CollegeName = Convert.ToString(Row["Name"]);
                CU.CollegeID = Convert.ToInt32(Row["ID"]);
                cuList.Add(CU);
            }

            return cuList;
        }

        public bool RemoveRoom(object ID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "delete from Room " +
                $"where ID = {ID} ";
            SqlCommand cmd = new SqlCommand(querystring, con);

            try
            {
                int Result = cmd.ExecuteNonQuery();

                if( Result != 0)
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            }catch( Exception e)
            {
                return false;
            }
        }

        public List<Teacher> AllTeacher()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from Teacher ";
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;
            List<Teacher> AllTeacher = new List<Teacher>();

            foreach(DataRow Row in AllRows)
            {
                Teacher teacher = new Teacher();
                teacher.Name = Convert.ToString(Row["Name"]);
                teacher.CollegeID = Convert.ToInt32(Row["College_ID"]);
                teacher.ID = Convert.ToInt32(Row["ID"]);
                teacher.Password = Convert.ToString(Row["Password"]);

                AllTeacher.Add(teacher);
            }

            return AllTeacher;
        }

        public bool AddRoom(int ID, int collegeID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "insert into Room " +
                $"Values({ID} , {collegeID})";
            SqlCommand cmd = new SqlCommand(querystring, con);

            try
            {
                int Result = cmd.ExecuteNonQuery();
                if( Result == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }catch(Exception e)
            {
                return false;
            }
        }

        public bool EditTeacher(Teacher editTeacher , int oldID )
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "update Teacher " +
                $"set ID = {editTeacher.ID} , Name = '{editTeacher.Name}' , College_ID = {editTeacher.CollegeID} , Password = '{editTeacher.Password}'  " +
                $"where ID = {oldID}";
            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                int Result = cmd.ExecuteNonQuery();
                if( Result == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool SearchTeacher(Teacher teacher, int ID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from Teacher " +
                $"where ID = {ID}";

            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            foreach(DataRow Row in AllRows)
            {
                teacher.ID = Convert.ToInt32(Row["ID"]);
                teacher.Name = Convert.ToString(Row["Name"]);
                teacher.CollegeID = Convert.ToInt32(Row["College_ID"]);
                teacher.Password = Convert.ToString(Row["Password"]);
                return true;
            }
            return false;
        }

        public string SayUnivercityName(int ID)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from Univercity " +
                $"where ID = {ID} ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            foreach(DataRow Row in AllRows)
            {
                string Name = Convert.ToString(Row["Name"]);
                return Name ;
            }
            return "NO";
        }

        public List<College> ReadAllCollege()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "select * from College  ";
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            List<College> AllCollege = new List<College>();
            foreach(DataRow Row in AllRows)
            {
                College college = new College();
                college.Name = Convert.ToString(Row["Name"]);
                college.Id = Convert.ToInt32(Row["ID"]);
                college.UnivercityID = Convert.ToInt32(Row["UnivercityID"]);
                AllCollege.Add(college);
            }
            return AllCollege;
        }

        public List<Univercity> ReadAllUnivercity()
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string querystring = "select * from Univercity ";
            SqlCommand cmd = new SqlCommand(querystring, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//for read table from db 
            DataSet tables = new DataSet(); //can read data from row and column 
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;

            List<Univercity> UnivercityList = new List<Univercity>();

            foreach ( DataRow Row in AllRows)
            {
                string Name = Convert.ToString(Row["Name"]);
                int ID = Convert.ToInt32(Row["ID"]);

                Univercity univercity = new Univercity(ID , Name);
                UnivercityList.Add(univercity);
            }

            return UnivercityList; 
        }

        public bool DeleteCollege(int CollegeID )
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string querystring = $"delete from College where ID = {CollegeID}";
            SqlCommand cmd = new SqlCommand(querystring, con);
            int Result = cmd.ExecuteNonQuery();
            if( Result != 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddCollege(College college)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string querystring = "insert into College " +
                $"Values({college.Id},'{college.Name}',{college.UnivercityID})";

            SqlCommand cmd = new SqlCommand(querystring, con);
            int Result = cmd.ExecuteNonQuery();

            if( Result != 0 )
            {
                return true ;
            }
            else
            {
                return false ;
            }
        }

        public int FinUnivercityID(string FindUnivercityID)
        {
            //Search Univercity by Name 
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string querystring = "select * " +
                $"from Univercity  " +
                $"where Name = '{FindUnivercityID}' ";

            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet tables = new DataSet();
            adapter.Fill(tables);
            var AllRows = tables.Tables[0].Rows;


            foreach(DataRow Row in AllRows)
            {
                int Value =  Convert.ToInt32(Row["ID"]);
                return Value ;
            }

            return 0 ;
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
                var Result = cmd.ExecuteNonQuery();
                if( Result == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch( Exception e)
            {
                return false;
            }


        }

        public bool AddUnivercity(Univercity univercity)
        {
            string ConString = @"Data Source=DESKTOP-6E77HUQ;Initial Catalog=db-US;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string querystring = "insert into Univercity " +
                $"Values({univercity.Id} , '{univercity.Name}')";

            SqlCommand cmd = new SqlCommand(querystring, con);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }catch( Exception e)
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
            var AllRows = tables.Tables[0].Rows;


            foreach (DataRow Row in AllRows)
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
                var Result = cmd.ExecuteNonQuery();
                if (Result == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch( Exception e)
            {
                return false;
            }
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
            var AllRows = tables.Tables[0].Rows;
            foreach (DataRow row in AllRows)
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