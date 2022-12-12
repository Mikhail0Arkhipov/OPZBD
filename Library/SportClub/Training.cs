using System;
using System.Collections.Generic;

namespace SportClub
{
    public class Training
    {
        public Training(string numTrain)
        {
            if (string.IsNullOrEmpty(numTrain))
            {
                throw new ArgumentNullException("name");
            }

            this.NumTrain = numTrain;
        }

        [Obsolete("For ORM")]
        protected Training()
        {

        }

        public virtual Guid Id { get; }

        public virtual string NumTrain { get; }

        public virtual ISet<Clients> clients { get; } = new HashSet<Clients>();

        public override string ToString()
        {
            return $"{this.NumTrain}";
        }
    }
}

