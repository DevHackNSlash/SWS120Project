using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWS120Project
{
    internal class Class1
    {
        class Person
        {
            string ID;
            string firstName;
            string lastName;
            string email;
            string phoneNumber;

            //properties
            public string ID_
            {
                get { return ID; }
                set { ID = value; }
            }
            public string firstName_
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string lastName_
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string email_
            {
                get { return email; }
                set { email = value; }
            }
            public string phoneNumber_
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }
        }

        public class student : Person
        {
            private string programCode;

            public string programCode_
            {
                get { return programCode; }
                set { programCode = value; }
            }

            public showStudentInfo()
            {
                Console.WriteLine();
            }
        }

        public class faculty : Person
        {
        }

        public class course
        {
            public string courseCode;
            public string courseName;
            public int facultyID;
            public int creditHours;

            public string courseCode_
            {
                get { return courseCode; }
                set { courseCode = value; }
            }

            public string courseName_
            {
                get { return courseName; }
                set { courseName = value; }
            }

            public int creditHours_
            {
                get { return creditHours; }
                set { creditHours = value; }
            }

            public int facultyID_
            {
                get { return facultyID; }
                set { facultyID = value; }
            }

            public void showCollegeCourseInfo()
            {
                Console.WriteLine("{0} {1} {2} {3}", this.courseCode_, this.courseName_, this.creditHours_, this.facultyID_);
            }
        }

        public class enrolment
        {
            public int id;
            public string courseCode;
            public int sectionNum;

            public int id_
            {
                get { return id; }
                set { id = value; }
            }
            public string courseCode_
            {
                get { return courseCode; }
                set { courseCode = value; }
            }

            public int sectionNum_
            {
                get { return sectionNum; }
                set { sectionNum = value; }
            }

            public class collegeProgram
            {
                public string programCode;
                public string programName;
                public string credentials;

                public string programCode_
                {
                    get { return programCode; }
                    set { programCode = value; }
                }
                public string programName_
                {
                    get { return programName; }
                    set { programName = value; }
                }
                public string credentials_
                {
                    get { return credentials; }
                    set { credentials = value; }
                }

                public void showCollegeProgramInfo()
                {
                    Console.WriteLine("{0} {1} {2}", this.credentials_, this.programName_, this.programCode_);
                }
            }
        }

      
    }
}