using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QUIZMANAGEMENTSYSTEM
{
    // This is the Controller class (Facade) that decouples UI from all logic classes
    public class QController
    {
        
        // Authenticates user using RealLogin class
        public string UserLogin(string username, string password, string user)
        {
            RealLogin rl = new RealLogin();
            return rl.Authenticate(username, password, user);  // Calls authentication logic
        }

        // STUDENT OPERATIONS
        public DataSet ViewSinfo()
        {
            Student s = new Student();
            return s.ViewAllStudentDetails();  // Gets all student records
        }

        public int DeleteS(int rollno)
        {
            Student s = new Student();
            return s.DeleteStudent(rollno);  // Deletes a student by roll number
        }

        public int AddStudent(string name, int rollno, string semester, string department, string email, Int64 contact, string password)
        {
            Student s = new Student();
            return s.InsertStudent(name, rollno, semester, department, email, contact, password);  // Adds a new student
        }

        public DataSet ShowSResult()
        {
            Student s = new Student();
            return s.ViewResult();  // Shows result for the logged-in student (uses Factory Method inside)
        }

        public int Checkifallquizateempted()
        {
            Student s = new Student();
            return s.ifattemtedallquiz();  // Checks if all quizzes have been attempted
        }

        // TEACHER OPERATIONS
        public int AddTeacher(string name, int empno, string email, Int64 contact, string address, string password)
        {
            Teacher t = new Teacher();
            return t.InsertTeacher(name, empno, email, contact, address, password);  // Adds a new teacher
        }

        public DataSet ShowTResult()
        {
            Teacher t = new Teacher();
            return t.ViewResult();  // Shows all student results for a teacher (uses Factory Method inside)
        }

        // COURSE OPERATIONS 
        public List<string> SShowCourses()
        {
            Course c = new Course();
            return c.GetCourses();  // Returns all available courses
        }

        public string AddCourse(string course)
        {
            Course c = new Course();
            return c.InsertCourse(course);  // Adds a new course
        }

        public string RemoveCourse(string course)
        {
            Course c = new Course();
            return c.DeleteCourse(course);  // Deletes an existing course
        }

        

        public DataSet TShowCourses()
        {
            Course c = new Course();
            return c.TShowCourses();  // Shows all courses for teacher
        }

        // QUESTION OPERATIONS 
        public DataSet ShowallQuestions()
        {
            Question q = new Question();
            return q.ShowallQuestions();  // Gets all quiz questions
        }

        public string DeleteQuestion(string course, int qno)
        {
            Question q = new Question();
            return q.DeleteQuestion(course, qno);  // Deletes a question by course and question number
        }

        //  STRATEGY PATTERN QUIZ START, Runtime Strategy Selection
        public void StartSelectedQuiz(string course)
        {
            IQuizStrategy strategy; // Declare a variable to hold strategy

            // Select strategy based on course name (runtime decision)
            switch (course.ToLower())
            {
                case "maths":
                    strategy = new MathQuizStrategy(); // Assign Math strategy
                    break;
                case "computer science":
                    strategy = new CSQuizStrategy(); // Assign CS strategy
                    break;
                default:
                    MessageBox.Show("No strategy available for this course."); // If no matching course
                    return;
            }

            // Create context and set the selected strategy
            QuizContext context = new QuizContext();
            context.SetStrategy(strategy); // Inject strategy
            context.ExecuteStrategy();     // Execute strategy behavior
        }

    }
}
