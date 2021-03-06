using MyStaging.xUnitTest.Model;
using System;
using Microsoft.Extensions.Logging;
using MyStaging.Helpers;
using Npgsql;

namespace MyStaging.xUnitTest
{
	public class _startup
	{
		public static void Init(ILogger logger, string connectionString)
		{
			PgSqlHelper.InitConnection(logger, connectionString);
		}
	}
	public partial class NpgsqlNameTranslator : INpgsqlNameTranslator
	{
		private string clrName;
		public string TranslateMemberName(string clrName)
		{
			this.clrName = clrName;
			return this.clrName;
		}
		private string clrTypeName;
		public string TranslateTypeName(string clrName)
		{
			this.clrTypeName = clrName;
			return this.clrTypeName;
		}
	}
}
