// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Output for task that validates migration input for SQL to Azure SQL
    /// Managed Instance migrations
    /// </summary>
    public partial class ValidateMigrationInputSqlServerSqlMITaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ValidateMigrationInputSqlServerSqlMITaskOutput class.
        /// </summary>
        public ValidateMigrationInputSqlServerSqlMITaskOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ValidateMigrationInputSqlServerSqlMITaskOutput class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="name">Name of database</param>
        /// <param name="restoreDatabaseNameErrors">Errors associated with the
        /// RestoreDatabaseName</param>
        /// <param name="backupFolderErrors">Errors associated with the
        /// BackupFolder path</param>
        /// <param name="backupShareCredentialsErrors">Errors associated with
        /// backup share user name and password credentials</param>
        /// <param name="backupStorageAccountErrors">Errors associated with the
        /// storage account provided.</param>
        /// <param name="existingBackupErrors">Errors associated with existing
        /// backup files.</param>
        /// <param name="databaseBackupInfo">Information about backup files
        /// when existing backup mode is used.</param>
        public ValidateMigrationInputSqlServerSqlMITaskOutput(string id = default(string), string name = default(string), IList<ReportableException> restoreDatabaseNameErrors = default(IList<ReportableException>), IList<ReportableException> backupFolderErrors = default(IList<ReportableException>), IList<ReportableException> backupShareCredentialsErrors = default(IList<ReportableException>), IList<ReportableException> backupStorageAccountErrors = default(IList<ReportableException>), IList<ReportableException> existingBackupErrors = default(IList<ReportableException>), DatabaseBackupInfo databaseBackupInfo = default(DatabaseBackupInfo))
        {
            Id = id;
            Name = name;
            RestoreDatabaseNameErrors = restoreDatabaseNameErrors;
            BackupFolderErrors = backupFolderErrors;
            BackupShareCredentialsErrors = backupShareCredentialsErrors;
            BackupStorageAccountErrors = backupStorageAccountErrors;
            ExistingBackupErrors = existingBackupErrors;
            DatabaseBackupInfo = databaseBackupInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result identifier
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of database
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets errors associated with the RestoreDatabaseName
        /// </summary>
        [JsonProperty(PropertyName = "restoreDatabaseNameErrors")]
        public IList<ReportableException> RestoreDatabaseNameErrors { get; private set; }

        /// <summary>
        /// Gets errors associated with the BackupFolder path
        /// </summary>
        [JsonProperty(PropertyName = "backupFolderErrors")]
        public IList<ReportableException> BackupFolderErrors { get; private set; }

        /// <summary>
        /// Gets errors associated with backup share user name and password
        /// credentials
        /// </summary>
        [JsonProperty(PropertyName = "backupShareCredentialsErrors")]
        public IList<ReportableException> BackupShareCredentialsErrors { get; private set; }

        /// <summary>
        /// Gets errors associated with the storage account provided.
        /// </summary>
        [JsonProperty(PropertyName = "backupStorageAccountErrors")]
        public IList<ReportableException> BackupStorageAccountErrors { get; private set; }

        /// <summary>
        /// Gets errors associated with existing backup files.
        /// </summary>
        [JsonProperty(PropertyName = "existingBackupErrors")]
        public IList<ReportableException> ExistingBackupErrors { get; private set; }

        /// <summary>
        /// Gets or sets information about backup files when existing backup
        /// mode is used.
        /// </summary>
        [JsonProperty(PropertyName = "databaseBackupInfo")]
        public DatabaseBackupInfo DatabaseBackupInfo { get; set; }

    }
}
