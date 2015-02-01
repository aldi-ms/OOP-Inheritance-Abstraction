using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Discipline
    {
        private string name;
        private int lecturesCount;
        private List<Student> students;

        #region Constructors
        public Discipline(string name, int lecturesCount, List<Student> students)
        {
            this.Name = name;
            this.LecturesCount = lecturesCount;
            this.Students = students;
        }

        public Discipline(string name, int lecturesCount, List<Student> students, string details)
            : this(name, lecturesCount, students)
        {
            this.Details = details;
        }
        #endregion

        #region Properties

        public string Details { get; set; }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "name",
                        "Discipline name cannot be null or empty string!");
                }

                this.name = value;
            }
        }

        public int LecturesCount
        {
            get { return this.lecturesCount; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Lectures count should be integer > 0!",
                        "lecturesCount");
                }

                this.lecturesCount = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        #endregion
    }
}
