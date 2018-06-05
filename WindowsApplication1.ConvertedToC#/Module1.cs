using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsApplication1
{
	static class Module1
	{
		public static string strcon = "Data Source=xone;Initial Catalog=Parking;Integrated Security=True";
		public static SqlConnection conn = new SqlConnection();
		public static SqlCommand cmd = new SqlCommand();
		public static SqlDataAdapter da = new SqlDataAdapter();
		public static DataSet ds = new DataSet();
		public static SqlDataReader reader;
		public const int AmountParking = 500;
		public static int AmountBike = 0;
		public static DataTable table = new DataTable();
		//  Public dr As SqlDataReader
		public static MainComponentForm Mainform = new MainComponentForm();
		public static string UserAuthor;
		public static string Username;
		public static int index = 0;
		public static void connectDatabase()
		{
			try {
				var _with1 = conn;
				if (_with1.State == ConnectionState.Open)
					_with1.Close();
				_with1.ConnectionString = strcon;
				_with1.Open();
			} catch (Exception ex) {
			}
		}

		public static object getMaxID(string tableName, string col)
		{
			connectDatabase();
			SqlDataAdapter da = getSqlDataAdapter("SELECT MAX(" + col + ") FROM " + tableName);
			DataSet ds = new DataSet();
			ClearTables(ds, "maxData" + tableName);
			da.Fill(ds, "maxData" + tableName);
			if (!Information.IsDBNull(ds.Tables["maxData" + tableName].Rows[0][0])) {
				return ds.Tables["maxData" + tableName].Rows[0][0].ToString();
			}
			return 1;
		}

		public static bool IsIDExists(string tableName, string column, string value, string idType, bool isOldExits = false, string newVal = "")
		{
			connectDatabase();
			try {
				SqlDataAdapter da = null;
				if (idType.ToLower().Equals("number") & isOldExits == false) {
					da = getSqlDataAdapter("SELECT " + column + " FROM " + tableName + " Where " + column + " =" + value);
				} else if (isOldExits == false) {
					da = getSqlDataAdapter("SELECT " + column + " FROM " + tableName + " Where " + column + " ='" + value + "'");
				} else if (idType.ToLower().Equals("number") & isOldExits == true) {
					da = getSqlDataAdapter("SELECT " + column + " FROM " + tableName + " Where " + column + " <> " + value + "' AND " + column + " =" + newVal);
				} else if (isOldExits == true) {
					da = getSqlDataAdapter("SELECT " + column + " FROM " + tableName + " Where " + column + " <> '" + value + "' AND " + column + " ='" + newVal + "'");
				} else {
					da = getSqlDataAdapter("SELECT " + column + " FROM " + tableName + " Where " + column + " =" + value);
				}
				DataSet ds = new DataSet();
				ClearTables(ds, "IsIDExists" + tableName);
				da.Fill(ds, "IsIDExists" + tableName);
				if (ds.Tables["IsIDExists" + tableName].Rows.Count > 0) {
					return true;
				}
			} catch (Exception ex) {
			}
            return false;

        }

		public static object getAgree(string tableName, string col, string cmd)
		{
			connectDatabase();

			try {
				SqlDataAdapter da = getSqlDataAdapter("SELECT " + cmd + "(" + col + ") FROM " + tableName);
				DataSet ds = new DataSet();
				ClearTables(ds, "getAgree" + tableName);
				da.Fill(ds, "getAgree" + tableName);
				if (!Information.IsDBNull(ds.Tables["getAgree" + tableName].Rows[0][0])) {
					return ds.Tables["getAgree" + tableName].Rows[0][0];
				}
				

			} catch (Exception ex) {
			}
            return "";

        }
		public static object getSqlDataSpecifix(string table, string col, string condition = "")
		{
			try {
				SqlDataAdapter da = null;
				if (condition.Equals("")) {
					da = getSqlDataAdapter("SELECT " + col + " FROM " + table);
				} else {
					da = getSqlDataAdapter("SELECT " + col + " FROM " + table + " " + condition);
				}
				DataSet ds = new DataSet();
				string tbName = "DataSpecifix" + table;
				ClearTables(ds, tbName);
				da.Fill(ds, tbName);
				if (ds.Tables[tbName].Rows.Count > 0) {
					return ds.Tables[tbName].Rows[0][0];
				}

			} catch (Exception ex) {
			}
            return null;
        }
		public static SqlDataAdapter getSqlDataAdapter(string sql)
		{
			return new SqlDataAdapter(sql, conn);
		}
		public static void ClearTables(DataSet ds, string tb)
		{
			if ((ds.Tables[tb] != null)) {
				ds.Tables[tb].Clear();
			}
		}

		public static void ClearReader(DataSet ds, SqlDataAdapter dap, DataTable dt = null)
		{
			ds.Dispose();
			dap.Dispose();
			if ((dt != null)) {
				dt.Dispose();
			}
			//If Not IsNothing(dr) Then
			//    dr.Close()
			//End If
		}
	}
}
