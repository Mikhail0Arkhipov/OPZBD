// <copyright file="ClientMap.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace DataAccessLayer
{
    using FluentNHibernate.Mapping;
    using SportClub;

    internal class ClientMap : ClassMap<Clients>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientMap"/> class.
        /// </summary>
        public ClientMap()
        {
            this.Table("Clients");
            this.Id(x => x.Id);
            this.Map(x => x.FirstName).Not.Nullable().Length(255);
            this.Map(x => x.LastName).Not.Nullable().Length(255);
            this.Map(x => x.MiddleName).Nullable().Length(255);
            //this.References(x => x.coaches);
            /*this.HasManyToMany(x => x.coaches)
                .Cascade.Delete()
                .Not.Inverse();*/
        }
    }
}

