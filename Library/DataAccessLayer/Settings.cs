// <copyright file="Settings.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace DataAccessLayer
{
    public sealed class Settings
    {
        private string databaseServerName;

        private string databaseName;

        public void AddDatabaseServer(string serverName)
        {
            this.databaseServerName = serverName;
        }

        public void AddDatabase(string databaseName)
        {
            this.databaseName = databaseName;
        }

        public string GetDatabaseServer()
        {
            return this.databaseServerName;
        }

        public void AddDatabaseName(string databaseName)
        {
            this.databaseName = databaseName;
        }

        public string GetDatabaseName()
        {
            return this.databaseName;
        }
    }
}