using System;

namespace _02.HumanStudentWorker
{
    public class Worker : Human
    {
        private string
            firstName,
            lastName;
        private double
            weekSalary,
            workHoursPerDay;

        public Worker(
            string firstName, 
            string lastName,
            double weekSalary,
            double workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
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

        public double WeekSalary
        {
            get { return this.weekSalary; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Worker week salary cannot be negative number!",
                        "weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Worker work hours per day cannot be negative number!",
                        "workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }
        #endregion

        public double MoneyPerHour()
        {
            // We assume 5-day work week
            double weekWorkHours = this.WorkHoursPerDay * 5;

            return weekSalary / weekWorkHours;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, pay/hour: {2}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
