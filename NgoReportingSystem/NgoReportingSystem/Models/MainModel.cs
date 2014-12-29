using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;
using System.Data.Sql;

namespace NgoReportingSystem.Models
{
    public class MainModel
    {
        public static object SelectAll()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConStr"].ToString();
            DataTable dt = SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "tblReports").Tables[0];
            object test = JsonConvert.SerializeObject(dt, Formatting.None);
            return test;
        }

    }
}