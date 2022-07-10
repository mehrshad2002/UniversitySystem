using UniversitySystem.Classes;
namespace UniversitySystem.Services
{
    using Repository;
    using System;
    using System.Collections.Generic;

    public class ServiceClass
    {
        Repository repository = new Repository();

        public bool Login(int username, string password , User user)
        {
            return repository.Login(username, password , user);
        }

        public bool AdminAddStudent( User NewUser )
        {
            return repository.AddStudent(NewUser);
        }

        public List<User> ShowAllData()
        {
            return repository.ShowAllData();
        }

        public List<Lesson> AllLessons()
        {
            return repository.Alllessons();
        }

        public List<SelectionForStudentList> SelectionList( int StudentID)
        {
            return repository.SelectionList(StudentID);
        }

        public List<Selection> AllSelection()
        {
            return repository.AllSelection();
        }

        public List<Room> AllRoom()
        {
            return repository.AllRooms();
        }

        public List<College> ReadAllCollege()
        {
            return repository.ReadAllCollege();
        }

        public bool RemoveSelectionStudent(int iD)
        {
            return repository.RemoveSelectionStudent(iD);
        }

        public bool MainSelection(int ID, int selectionID, int studentID)
        {
            return repository.MainSelection(ID, selectionID, studentID);
        }

        public bool RemoveSelection(int ID)
        {
            return repository.RemoveSelection(ID);
        }

        public bool RemoveUnivercity(int ID)
        {
            return repository.RemoveUnivercity(ID);
        }

        public bool RemoveLesson(int ID)
        {
            return repository.RemoveLesson(ID);
        }

        public string SayLessonName(int lessonID)
        {
            return repository.SayLessonName(lessonID);
        }

        public List<Teacher> AllTeacher()
        {
            return repository.AllTeacher();
        }

        public bool RemoveRoom(int ID)
        {
            return repository.RemoveRoom(ID);
        }

        public List<CollegeAndUnivercity> ReadAllCollegeJoin()
        {
            return repository.ReadAllCollegeJoin();
        }

        public bool AddLesson(Lesson lesson)
        {
            return repository.AddLesson(lesson);
        }

        public string SayUnivercityName(int ID)
        {
            return repository.SayUnivercityName( ID );
        }

        public bool DeleteUser(int ID, string Name)
        {
            return repository.DeleteUser(ID , Name );
        }

        public bool CreateSelection(int ID,int Capacity , int collegeID, int lessonID, int roomID, int teacherID, DateTime dateTime , string Name)
        {
            return repository.CreateSelection(ID,Capacity, collegeID, lessonID, roomID, teacherID, dateTime ,Name);
        }

        public bool AddRoom(int ID , int CollegeID )
        {
            return repository.AddRoom(ID, CollegeID);
        }

        public int SearchCollegeID(int userCollegeID)
        {
            return 0;
        }

        public List<Univercity> ReadAllUnivercity()
        {
            return repository.ReadAllUnivercity();
        }

        public bool SearchUser(string name, int ID , User user)
        {
            return repository.SearchUser(name, ID , user );
        }

        public int FindUnivercityID(string findUnivercityID )
        {
            return repository.FinUnivercityID(findUnivercityID);
        }

        public bool SearchTeacher(Teacher teacher, int ID)
        {
            return repository.SearchTeacher(teacher, ID);
        }

        public bool AddCollege(College college)
        {
            return repository.AddCollege(college);
        }

        public bool DeleteCollege(int CollegeID)
        {
            return repository.DeleteCollege(CollegeID);
        }

        public bool EditTeacher(Teacher editTeacher ,  int oldID)
        {
            return repository.EditTeacher(editTeacher , oldID);
        }

        public bool AddUnivercity(Univercity univercity)
        {
            return repository.AddUnivercity(univercity);
        }

        public bool RemoveTeacher(string name, int ID )
        {
            return repository.RemoveTeacher(name, ID);
        }

        public bool AddTeacher(User user)
        {
            return repository.AddTeacher(user);
        }

        public bool EditUser( User editUser , User user )
        {
            return repository.EditUser(editUser ,  user );
        }
    }
}