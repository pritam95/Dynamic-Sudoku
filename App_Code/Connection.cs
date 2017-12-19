using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


public class DbAccess
{
    public static int Inser(string s)
    {
        string con_str = ConfigurationManager.ConnectionStrings["dbcs"].ToString();
        SqlConnection con = new SqlConnection(con_str);
        con.Open();
        SqlCommand cmd = new SqlCommand(s,con);
        cmd.ExecuteNonQuery();
        con.Close();
        return 1;


    }
    public static DataSet Fetch1(string q)
    {
        string con_str = ConfigurationManager.ConnectionStrings["dbcs"].ToString();
        SqlConnection con = new SqlConnection(con_str);
        SqlDataAdapter d = new SqlDataAdapter(q, con);
        DataSet ds = new DataSet();
        d.Fill(ds);
        return ds;
    }
}