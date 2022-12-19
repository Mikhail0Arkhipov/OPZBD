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

        public virtual Guid Id { get; protected set; }

        public virtual string NumTrain { get; protected set; }

        public virtual ISet<Clients> clients { get; protected set; } = new HashSet<Clients>();

        public override string ToString()
        {
            return $"{this.NumTrain}";
        }
    }
}

