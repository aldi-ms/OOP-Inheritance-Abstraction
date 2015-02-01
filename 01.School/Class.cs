using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Class
    {
        private string uniqueID;
        private List<Teacher> teachers;
        private List<Student> students;

        public Class(string uniqueID, List<Teacher> teachers, List<Student> students)
        {
            this.UniqueID = uniqueID;
            this.Teachers = teachers;
            this.Students = students;
        }
        
        public Class(string uniqueID, List<Teacher> teachers, List<Student> students, string details)
            : this(uniqueID, teachers, students)
        {
            this.Details = details;
        }

        #region Properties
        public string Details { get; set; }

        public string UniqueID
        {
            get { return this.uniqueID; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "uniqueID",
                        "Class unique text ID cannot be null or empty string!");
                }

                this.uniqueID = value;
            }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "teachers",
                        "Class teachers cannot be null!");
                }

                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get { return this.students; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "students",
                        "Class students cannot be null!");
                }

                this.students = value;
            }
        }
        #endregion
    }
}
