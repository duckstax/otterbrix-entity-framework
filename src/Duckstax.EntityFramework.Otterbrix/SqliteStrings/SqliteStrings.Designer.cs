// <auto-generated />

using System;
using System.Reflection;
using System.Resources;
using System.Threading;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;

#nullable enable

namespace Microsoft.EntityFrameworkCore.Otterbrix.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class SqliteStrings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Otterbrix.Properties.SqliteStrings", typeof(SqliteStrings).Assembly);

        /// <summary>
        ///     SQLite cannot apply aggregate operator '{aggregateOperator}' on expressions of type '{type}'. Convert the values to a supported type, or use LINQ to Objects to aggregate the results on the client side.
        /// </summary>
        public static string AggregateOperationNotSupported(object? aggregateOperator, object? type)
            => string.Format(
                GetString("AggregateOperationNotSupported", nameof(aggregateOperator), nameof(type)),
                aggregateOperator, type);

        /// <summary>
        ///     Translating this query requires the SQL APPLY operation, which is not supported on SQLite.
        /// </summary>
        public static string ApplyNotSupported
            => GetString("ApplyNotSupported");

        /// <summary>
        ///     Translating this operation requires the 'DEFAULT', which is not supported on SQLite.
        /// </summary>
        public static string DefaultNotSupported
            => GetString("DefaultNotSupported");

        /// <summary>
        ///     '{entityType1}.{property1}' and '{entityType2}.{property2}' are both mapped to column '{columnName}' in '{table}', but are configured with different SRIDs.
        /// </summary>
        public static string DuplicateColumnNameSridMismatch(object? entityType1, object? property1, object? entityType2, object? property2, object? columnName, object? table)
            => string.Format(
                GetString("DuplicateColumnNameSridMismatch", nameof(entityType1), nameof(property1), nameof(entityType2), nameof(property2), nameof(columnName), nameof(table)),
                entityType1, property1, entityType2, property2, columnName, table);

        /// <summary>
        ///     SQLite does not support this migration operation ('{operation}'). See http://go.microsoft.com/fwlink/?LinkId=723262 for more information and examples.
        /// </summary>
        public static string InvalidMigrationOperation(object? operation)
            => string.Format(
                GetString("InvalidMigrationOperation", nameof(operation)),
                operation);

        /// <summary>
        ///     Generating idempotent scripts for migrations is not currently supported for SQLite. See http://go.microsoft.com/fwlink/?LinkId=723262 for more information and examples.
        /// </summary>
        public static string MigrationScriptGenerationNotSupported
            => GetString("MigrationScriptGenerationNotSupported");

        /// <summary>
        ///     SQLite does not support expressions of type '{type}' in ORDER BY clauses. Convert the values to a supported type, or use LINQ to Objects to order the results on the client side.
        /// </summary>
        public static string OrderByNotSupported(object? type)
            => string.Format(
                GetString("OrderByNotSupported", nameof(type)),
                type);

        /// <summary>
        ///     SQLite does not support sequences. See http://go.microsoft.com/fwlink/?LinkId=723262 for more information and examples.
        /// </summary>
        public static string SequencesNotSupported
            => GetString("SequencesNotSupported");

        /// <summary>
        ///     SQLite does not support stored procedures, but one has been configured on entity type '{entityType}'. See http://go.microsoft.com/fwlink/?LinkId=723262 for more information and examples.
        /// </summary>
        public static string StoredProceduresNotSupported(object? entityType)
            => string.Format(
                GetString("StoredProceduresNotSupported", nameof(entityType)),
                entityType);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name)!;
            for (var i = 0; i < formatterNames.Length; i++)
            {
                value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
            }

            return value;
        }
    }
}

namespace Microsoft.EntityFrameworkCore.Otterbrix.Internal
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public static class SqliteResources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.EntityFrameworkCore.Otterbrix.Properties.SqliteStrings", typeof(SqliteResources).Assembly);

        /// <summary>
        ///     The entity type '{entityType}' has composite key '{key}' which is configured to use generated values. SQLite does not support generated values on composite keys.
        /// </summary>
        public static EventDefinition<string?, string?> LogCompositeKeyWithValueGeneration(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogCompositeKeyWithValueGeneration;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogCompositeKeyWithValueGeneration,
                    logger,
                    static logger => new EventDefinition<string?, string?>(
                        logger.Options,
                        SqliteEventId.CompositeKeyWithValueGeneration,
                        LogLevel.Warning,
                        "SqliteEventId.CompositeKeyWithValueGeneration",
                        level => LoggerMessage.Define<string?, string?>(
                            level,
                            SqliteEventId.CompositeKeyWithValueGeneration,
                            _resourceManager.GetString("LogCompositeKeyWithValueGeneration")!)));
            }

            return (EventDefinition<string?, string?>)definition;
        }

        /// <summary>
        ///     Skipping foreign key with identity '{id}' on table '{tableName}' since principal table '{principalTableName}' was not found in the model. This usually happens when the principal table was not included in the selection set.
        /// </summary>
        public static EventDefinition<string?, string?, string?> LogForeignKeyScaffoldErrorPrincipalTableNotFound(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogForeignKeyScaffoldErrorPrincipalTableNotFound;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogForeignKeyScaffoldErrorPrincipalTableNotFound,
                    logger,
                    static logger => new EventDefinition<string?, string?, string?>(
                        logger.Options,
                        SqliteEventId.ForeignKeyReferencesMissingTableWarning,
                        LogLevel.Warning,
                        "SqliteEventId.ForeignKeyReferencesMissingTableWarning",
                        level => LoggerMessage.Define<string?, string?, string?>(
                            level,
                            SqliteEventId.ForeignKeyReferencesMissingTableWarning,
                            _resourceManager.GetString("LogForeignKeyScaffoldErrorPrincipalTableNotFound")!)));
            }

            return (EventDefinition<string?, string?, string?>)definition;
        }

        /// <summary>
        ///     Found column on table '{tableName}' with name: '{columnName}', data type: {dataType}, not nullable: {notNullable}, default value: {defaultValue}.
        /// </summary>
        public static EventDefinition<string?, string?, string?, bool, string?> LogFoundColumn(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundColumn;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundColumn,
                    logger,
                    static logger => new EventDefinition<string?, string?, string?, bool, string?>(
                        logger.Options,
                        SqliteEventId.ColumnFound,
                        LogLevel.Debug,
                        "SqliteEventId.ColumnFound",
                        level => LoggerMessage.Define<string?, string?, string?, bool, string?>(
                            level,
                            SqliteEventId.ColumnFound,
                            _resourceManager.GetString("LogFoundColumn")!)));
            }

            return (EventDefinition<string?, string?, string?, bool, string?>)definition;
        }

        /// <summary>
        ///     Found foreign key on table '{tableName}', id: {id}, principal table: {principalTableName}, delete action: {deleteAction}.
        /// </summary>
        public static EventDefinition<string?, long, string?, string?> LogFoundForeignKey(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundForeignKey;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundForeignKey,
                    logger,
                    static logger => new EventDefinition<string?, long, string?, string?>(
                        logger.Options,
                        SqliteEventId.ForeignKeyFound,
                        LogLevel.Debug,
                        "SqliteEventId.ForeignKeyFound",
                        level => LoggerMessage.Define<string?, long, string?, string?>(
                            level,
                            SqliteEventId.ForeignKeyFound,
                            _resourceManager.GetString("LogFoundForeignKey")!)));
            }

            return (EventDefinition<string?, long, string?, string?>)definition;
        }

        /// <summary>
        ///     Found index on table '{tableName}' with name '{indexName}', is unique: {isUnique}.
        /// </summary>
        public static EventDefinition<string?, string?, bool?> LogFoundIndex(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundIndex;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundIndex,
                    logger,
                    static logger => new EventDefinition<string?, string?, bool?>(
                        logger.Options,
                        SqliteEventId.IndexFound,
                        LogLevel.Debug,
                        "SqliteEventId.IndexFound",
                        level => LoggerMessage.Define<string?, string?, bool?>(
                            level,
                            SqliteEventId.IndexFound,
                            _resourceManager.GetString("LogFoundIndex")!)));
            }

            return (EventDefinition<string?, string?, bool?>)definition;
        }

        /// <summary>
        ///     Found primary key on table '{tableName}' with name {primaryKeyName}.
        /// </summary>
        public static EventDefinition<string?, string?> LogFoundPrimaryKey(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundPrimaryKey;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundPrimaryKey,
                    logger,
                    static logger => new EventDefinition<string?, string?>(
                        logger.Options,
                        SqliteEventId.PrimaryKeyFound,
                        LogLevel.Debug,
                        "SqliteEventId.PrimaryKeyFound",
                        level => LoggerMessage.Define<string?, string?>(
                            level,
                            SqliteEventId.PrimaryKeyFound,
                            _resourceManager.GetString("LogFoundPrimaryKey")!)));
            }

            return (EventDefinition<string?, string?>)definition;
        }

        /// <summary>
        ///     Found table with name: '{name}'.
        /// </summary>
        public static EventDefinition<string?> LogFoundTable(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundTable;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundTable,
                    logger,
                    static logger => new EventDefinition<string?>(
                        logger.Options,
                        SqliteEventId.TableFound,
                        LogLevel.Debug,
                        "SqliteEventId.TableFound",
                        level => LoggerMessage.Define<string?>(
                            level,
                            SqliteEventId.TableFound,
                            _resourceManager.GetString("LogFoundTable")!)));
            }

            return (EventDefinition<string?>)definition;
        }

        /// <summary>
        ///     Found unique constraint on table '{tableName}' with name: {uniqueConstraintName}.
        /// </summary>
        public static EventDefinition<string?, string?> LogFoundUniqueConstraint(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundUniqueConstraint;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogFoundUniqueConstraint,
                    logger,
                    static logger => new EventDefinition<string?, string?>(
                        logger.Options,
                        SqliteEventId.UniqueConstraintFound,
                        LogLevel.Debug,
                        "SqliteEventId.UniqueConstraintFound",
                        level => LoggerMessage.Define<string?, string?>(
                            level,
                            SqliteEventId.UniqueConstraintFound,
                            _resourceManager.GetString("LogFoundUniqueConstraint")!)));
            }

            return (EventDefinition<string?, string?>)definition;
        }

        /// <summary>
        ///     Unable to find a table in the database matching the selected table '{table}'.
        /// </summary>
        public static EventDefinition<string?> LogMissingTable(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogMissingTable;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogMissingTable,
                    logger,
                    static logger => new EventDefinition<string?>(
                        logger.Options,
                        SqliteEventId.MissingTableWarning,
                        LogLevel.Warning,
                        "SqliteEventId.MissingTableWarning",
                        level => LoggerMessage.Define<string?>(
                            level,
                            SqliteEventId.MissingTableWarning,
                            _resourceManager.GetString("LogMissingTable")!)));
            }

            return (EventDefinition<string?>)definition;
        }

        /// <summary>
        ///     Skipping foreign key with identity '{id}' on table '{tableName}', since the principal column '{principalColumnName}' on the foreign key's principal table, '{principalTableName}', was not found in the model.
        /// </summary>
        public static EventDefinition<string?, string?, string?, string?> LogPrincipalColumnNotFound(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogPrincipalColumnNotFound;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogPrincipalColumnNotFound,
                    logger,
                    static logger => new EventDefinition<string?, string?, string?, string?>(
                        logger.Options,
                        SqliteEventId.ForeignKeyPrincipalColumnMissingWarning,
                        LogLevel.Warning,
                        "SqliteEventId.ForeignKeyPrincipalColumnMissingWarning",
                        level => LoggerMessage.Define<string?, string?, string?, string?>(
                            level,
                            SqliteEventId.ForeignKeyPrincipalColumnMissingWarning,
                            _resourceManager.GetString("LogPrincipalColumnNotFound")!)));
            }

            return (EventDefinition<string?, string?, string?, string?>)definition;
        }

        /// <summary>
        ///     The entity type '{entityType}' is configured to use schema '{schema}', but SQLite does not support schemas. This configuration will be ignored by the SQLite provider.
        /// </summary>
        public static EventDefinition<string, string> LogSchemaConfigured(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSchemaConfigured;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSchemaConfigured,
                    logger,
                    static logger => new EventDefinition<string, string>(
                        logger.Options,
                        SqliteEventId.SchemaConfiguredWarning,
                        LogLevel.Warning,
                        "SqliteEventId.SchemaConfiguredWarning",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            SqliteEventId.SchemaConfiguredWarning,
                            _resourceManager.GetString("LogSchemaConfigured")!)));
            }

            return (EventDefinition<string, string>)definition;
        }

        /// <summary>
        ///     The model was configured with the database sequence '{sequence}'. SQLite does not support sequences.
        /// </summary>
        public static EventDefinition<string> LogSequenceConfigured(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSequenceConfigured;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogSequenceConfigured,
                    logger,
                    static logger => new EventDefinition<string>(
                        logger.Options,
                        SqliteEventId.SequenceConfiguredWarning,
                        LogLevel.Warning,
                        "SqliteEventId.SequenceConfiguredWarning",
                        level => LoggerMessage.Define<string>(
                            level,
                            SqliteEventId.SequenceConfiguredWarning,
                            _resourceManager.GetString("LogSequenceConfigured")!)));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     An operation of type '{operationType}' will be attempted while a rebuild of table '{tableName}' is pending. The database may not be in an expected state. Review the SQL generated by this migration to help diagnose any failures. Consider moving these operations to a subsequent migration.
        /// </summary>
        public static EventDefinition<string, string> LogTableRebuildPendingWarning(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogTableRebuildPendingWarning;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogTableRebuildPendingWarning,
                    logger,
                    static logger => new EventDefinition<string, string>(
                        logger.Options,
                        SqliteEventId.TableRebuildPendingWarning,
                        LogLevel.Warning,
                        "SqliteEventId.TableRebuildPendingWarning",
                        level => LoggerMessage.Define<string, string>(
                            level,
                            SqliteEventId.TableRebuildPendingWarning,
                            _resourceManager.GetString("LogTableRebuildPendingWarning")!)));
            }

            return (EventDefinition<string, string>)definition;
        }

        /// <summary>
        ///     A connection of an unexpected type ({type}) is being used. The SQL functions prefixed with 'ef_' could not be created automatically. Manually define them if you encounter errors while querying.
        /// </summary>
        public static EventDefinition<string> LogUnexpectedConnectionType(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUnexpectedConnectionType;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUnexpectedConnectionType,
                    logger,
                    static logger => new EventDefinition<string>(
                        logger.Options,
                        SqliteEventId.UnexpectedConnectionTypeWarning,
                        LogLevel.Warning,
                        "SqliteEventId.UnexpectedConnectionTypeWarning",
                        level => LoggerMessage.Define<string>(
                            level,
                            SqliteEventId.UnexpectedConnectionTypeWarning,
                            _resourceManager.GetString("LogUnexpectedConnectionType")!)));
            }

            return (EventDefinition<string>)definition;
        }

        /// <summary>
        ///     SQLite doesn't support schemas. The specified schema selection arguments will be ignored.
        /// </summary>
        public static EventDefinition LogUsingSchemaSelectionsWarning(IDiagnosticsLogger logger)
        {
            var definition = ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUsingSchemaSelectionsWarning;
            if (definition == null)
            {
                definition = NonCapturingLazyInitializer.EnsureInitialized(
                    ref ((Diagnostics.Internal.SqliteLoggingDefinitions)logger.Definitions).LogUsingSchemaSelectionsWarning,
                    logger,
                    static logger => new EventDefinition(
                        logger.Options,
                        SqliteEventId.SchemasNotSupportedWarning,
                        LogLevel.Warning,
                        "SqliteEventId.SchemasNotSupportedWarning",
                        level => LoggerMessage.Define(
                            level,
                            SqliteEventId.SchemasNotSupportedWarning,
                            _resourceManager.GetString("LogUsingSchemaSelectionsWarning")!)));
            }

            return (EventDefinition)definition;
        }
    }
}