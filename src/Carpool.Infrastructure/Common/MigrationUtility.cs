using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Carpool.Infrastructure.Common
{
    public static class MigrationUtility
    {
        /// <summary>
        /// Read a SQL script that is embedded into a resource.
        /// </summary>
        /// <param name="migrationType">The migration type the SQL file script is attached to.</param>
        /// <param name="sqlFileName">The embedded SQL file name.</param>
        /// <returns>The content of the SQL file.</returns>
        public static void RunSqlScript(this MigrationBuilder migrationBuilder, string script)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = assembly.GetManifestResourceNames().FirstOrDefault(x => x.EndsWith($"{script}.sql"));
            using var stream = assembly.GetManifestResourceStream(resourceName);
            using var reader = new StreamReader(stream);
            var sqlResult = reader.ReadToEnd();
            migrationBuilder.Sql(sqlResult);
        }
    }
}
