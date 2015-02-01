using System;

namespace _01.School
{
    public class People
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "name",
                        "Student name cannot be null or empty string!");
                }

                this.name = value;
            }
        }
    }
}
