// <copyright file="ClientMap.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DataAccessLayer
{
    using FluentNHibernate.Mapping;
    using SportClub;

    internal class CoachMap : ClassMap<Coach>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoachesMap"/> class.
        /// </summary>
        public CoachMap()
        {
            this.Table("Coaches");
            this.Id(x => x.Id);
            this.Map(x => x.FirstName).Not.Nullable().Length(255);
            this.Map(x => x.LastName).Not.Nullable().Length(255);
            this.Map(x => x.MiddleName).Nullable().Length(255);
            /*this.HasMany(x => x.Clients)
                .Cascade.Delete()
                .Not.Inverse();*/
        }
    }
}