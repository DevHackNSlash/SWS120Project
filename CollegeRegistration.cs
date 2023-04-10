using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWS120Project
{
    internal class CollegeRegistration
    {
        static List<course> courses = new List<course>();
        static List<enrolment> enrolments = new List<enrolment>();
        static List<student> students = new List<student>();
        static List<faculty> faculties = new List<faculty>();
        static List<Class1.collegeProgram> programs = new List<Class1.collegeProgram>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add a student");
                Console.WriteLine("2. Add a faculty member");
                Console.WriteLine("3. Add a course");
                Console.WriteLine("4. Add a program");
                Console.WriteLine("5. Enroll a student in a course");
                Console.WriteLine("6. Display student information");
                Console.WriteLine("7. Display course information");
                Console.WriteLine("8. Display all courses taken by a student");
                Console.WriteLine("9. Display all students taking a particular course");
                Console.WriteLine("10. Display all courses taught by a particular faculty");
                Console.WriteLine("11. Display all students in a particular program");
                Console.WriteLine("12. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        addStudent();
                        break;
                    case "2":
                        addFaculty();
                        break;
                    case "3":
                        addCourse();
                        break;
                    case "4":
                        addProgram();
                        break;
                    case "5":
                        createEnrolment();
                        break;
                    case "6":
                        displayStudent();
                        break;
                    case "7":
                        displayCourse();
                        break;
                    case "8":
                        displayCoursesForStudent();
                        break;
                    case "9":
                        displayStudentsInCourse();
                        break;
                    case "10":
                        displayCoursesTaughtByFaculty();
                        break;
                    case "11":
                        displayStudentsInProgram();
                        break;
                    case "12":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        break;
                }
            }
        }

        public static void addStudent()
        {
            Console.WriteLine("Enter student ID:");
            string studentID = Console.ReadLine();

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter program code:");
            string programCode = Console.ReadLine();

            student newStudent = new student(studentID, firstName, lastName, email, phoneNumber, programCode);
            students.Add(newStudent);

            Console.WriteLine("Student added successfully.");
        }

        public static void addFaculty()
        {
            Console.WriteLine("Enter faculty member ID:");
            string facultyID = Console.ReadLine();

            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();

            faculty newFaculty = new faculty(facultyID, firstName, lastName, email, phoneNumber);
            faculties.Add(newFaculty);

            Console.WriteLine("Faculty member added successfully.");
        }

        public static void addCourse()
        {
            Console.WriteLine("Enter course code:");
            string courseCode = Console.ReadLine();

            Console.WriteLine("Enter course name:");

            string courseName = Console.ReadLine();

            Console.WriteLine("Enter Faculty ID");

            int facultyID = Console.ReadLine();

            Console.WriteLine("Enter credit hours");

            int creditHours = Console.ReadLine();

            course newCourse = new course(courseCode,courseName,facultyID,creditHours);

            Console.WriteLine("Course added successfully.");
        }

        public static void addProgram()
        {
            Console.WriteLine("Enter program code:");
            string programCode = Console.ReadLine();

            Console.WriteLine("Enter program name:");
            string programName = Console.ReadLine();

            Console.WriteLine("Enter credentials:");
            string credentials = Console.ReadLine();

            program newProgram = new program(programCode, programName, credentials);
            programs.Add(newProgram);

            Console.WriteLine("Program added successfully.");
        }

        public static void createEnrolment()
        {
            Console.WriteLine("Enter student ID");

        }

            public static void displayStudent()
            {
                Console.WriteLine("Enter student ID:");
                int studentID = int.Parse(Console.ReadLine());

                student foundStudent = null;

                foreach (student s in students)
                {
                    if (s.ID_() == studentID)
                    {
                        foundStudent = s;
                        break;
                    }
                }

                if (foundStudent != null)
                {
                    Console.WriteLine("Student ID: " + foundStudent.ID_());
                    Console.WriteLine("Name: " + foundStudent.firstName_() + " " + foundStudent.lastName_());
                    Console.WriteLine("Email: " + foundStudent.email_());
                    Console.WriteLine("Phone: " + foundStudent.phoneNumber_());
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }

        
