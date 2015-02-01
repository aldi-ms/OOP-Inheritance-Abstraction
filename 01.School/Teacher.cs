using System;
using System.Collections.Generic;

namespace _01.School
{
    public class Teacher : People
    {
        private List<Discipline> disciplines;

        #region Constructors
        public Teacher(string name, List<Discipline> disciplines)
            : base(name)
        {
            this.Disciplines = disciplines;
        }

        public Teacher(string name, List<Discipline> disciplines, string details)
            : this(name, disciplines)
        {
            this.Details = details;
        }
        #endregion

        public string Details { get; set; }

        public List<Discipline> Disciplines
        {
            get { return this.disciplines; }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "disciplines",
                        "Teacher cannot have null as disciplines!");
                }

                this.disciplines = value;
            }
        }
    }
}
