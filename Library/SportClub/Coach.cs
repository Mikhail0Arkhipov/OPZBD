using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClub
{
    public class Coach : IEquatable<Coach>
    {
        public Coach(string lastName, string firstName, string? middleName)
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
        }

        [Obsolete("For ORM")]
        protected Coach()
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
        public virtual ISet<Clients> Clients { get; } = new HashSet<Clients>();

        public virtual bool Equals(Coach other)
        {
            return Equals(other);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return false;
            }

            if (object.ReferenceEquals(obj, this))
            {
                return true;
            }
            return (obj is Clients other)
                && string.Equals(this.FirstName, other.FirstName, StringComparison.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{this.LastName},{this.FirstName},{this.MiddleName}";
        }
    }
}

