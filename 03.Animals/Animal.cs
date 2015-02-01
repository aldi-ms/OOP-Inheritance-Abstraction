using System;

namespace _03.Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        #region Properties
        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(
                        "name",
                        "Name can not be null or empty string!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative number!");
                }

                this.age = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0}, age: {1}, {2}", this.Name, this.Age, this.Gender);
        }

        public abstract void ProduceSound();
    }
}
