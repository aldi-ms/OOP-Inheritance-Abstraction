using System;
using System.Text.RegularExpressions;

namespace _02.HumanStudentWorker
{
    public class Student : Human
    {
        private static Regex facNumRegex = new Regex(@"^[A-z0-9]{5,10}$");

        private string
            firstName,
            lastName,
            facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
        }

        #region Properties
        public override string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "firstName",
                        "First name cannot be null or empty string!");
                }

                this.firstName = value;
            }
        }

        public override string LastName
        {
            get { return this.lastName; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "lastName",
                        "Last name cannot be null or empty string!");
                }

                this.lastName = value;
            }
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }

            set 
            {
                if (facNumRegex.IsMatch(value))
                {
                    this.facultyNumber = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Student faculty number should be [5-10] alphanumeric characters",
                        "facultyNumber");
                }
            }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0} {1}, facNum: {2}",
                this.FirstName, this.LastName, this.FacultyNumber);
        }
    }
}
