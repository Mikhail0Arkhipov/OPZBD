using System;
using System.Collections.Generic;

namespace SportClub
{
    public class Clients
    {
        public Clients(string lastName, string firstName, string middleName, ISet<Coach> coaches)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentNullException(nameof(firstName));
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentNullException(nameof(lastName));
            }

            if ((middleName?.Trim())?.Length == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(middleName));
            }
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.coaches = coaches;
            this.trainings = trainings;
        }

        [Obsolete("For ORM")]
        protected Clients()
        {

        }

        public virtual Guid Id { get; }
        /// <summary>
        /// Имя.
        /// </summary>
        public virtual string FirstName { get; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public virtual string LastName { get; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public virtual string MiddleName { get; }

        /// <summary>
        /// Тренировки.
        /// </summary>
        public virtual ISet<Coach> coaches { get; } = new HashSet<Coach>();
        public virtual ISet<Training> trainings { get; } = new HashSet<Training>();

        public virtual bool AddTraining(Training trainings)
        {
            return trainings is null
                ? throw new ArgumentNullException(nameof(trainings))
                : this.trainings.Add(trainings);
        }

        public Clients(string lastName, string firstName, string middleName, params Coach[] coaches)
            : this(lastName, firstName, middleName, new HashSet<Coach>(coaches))
        {
        }

        public override string ToString()
        {
            return $"{this.LastName},{this.FirstName},{this.MiddleName},{string.Join(", ", this.coaches)}";
        }

    }
}
