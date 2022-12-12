// <copyright file="ClientMap.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DataAccessLayer
{
    using FluentNHibernate.Mapping;
    using SportClub;

    internal class TrainingMap : ClassMap<Training>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingsMap"/> class.
        /// </summary>
        public TrainingMap()
        {
            this.Table("Trainings");
            this.Id(x => x.Id);
            this.Map(x => x.NumTrain).Not.Nullable().Length(255);
            /*this.HasMany(x => x.clients)
                .Cascade.Delete()
                .Not.Inverse();*/
        }
    }
}
