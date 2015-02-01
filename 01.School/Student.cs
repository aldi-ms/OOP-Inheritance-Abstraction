using System;

namespace _01.School
{
    public class Student : People
    {
        private int uniqueNumber;

        #region Constructors
        public Student(string name, int uniqueNumber)
            : base(name)
        {
            this.UniqueNumber = uniqueNumber;
        }

        public Student(string name, int uniqueNumber, string details)
            : this(name, uniqueNumber)
        {
            this.Details = details;
        }
        #endregion

        public string Details { get; set; }

        public int UniqueNumber
        {
            get { return this.uniqueNumber; }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "Student number should be integer > 0!",
                        "uniqueNumber");
                }

                this.uniqueNumber = value;
            }
        }
    }
}
