using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportManagment.Models;
using Microsoft.Extensions.Caching;
using Microsoft.Extensions.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web;
using SportManagement.Models;
using Newtonsoft.Json;


namespace SportManagement.Controllers
{
    public class DetailsTestController : Controller
    {
        private readonly IConfiguration Configration;

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        string result = string.Empty;





        public DetailsTestController(IConfiguration config)
        {
            this.Configration = config;
        }

        [HttpGet]
        public ActionResult Index(int id)
        {

            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Select_User", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return View(ds);
        }

        [HttpPost]
        public string InsertTestDetail(string Ranking, int Distance,int NewTest_Id)
        {

            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Inseart_TestDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ranking", Ranking);
            cmd.Parameters.AddWithValue("@Distance", Distance);
            cmd.Parameters.AddWithValue("@NewTest_Id", NewTest_Id);
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Success";
            return JsonConvert.SerializeObject(result);

        }

        public string GetTestDetail(int id)
        {
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Select_TestDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewTest_Id", id);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return JsonConvert.SerializeObject(ds);
         
        }

        [HttpGet]
        public string edittest(int id)
        {
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Edit_User", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@User_Id", id);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return JsonConvert.SerializeObject(ds);
        }


        [HttpPost]
        public string deletetest(int id)
        {
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Delete_Test", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return JsonConvert.SerializeObject(ds);
        }

        [HttpPost]
        public string DeleteAthelet(int id)
        {
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_DeleteAthelet_Test", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", id);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return JsonConvert.SerializeObject(ds);
        }

        [HttpPost]
        public string UpdateTestDetail(string Ranking, int Distance, int NewTest_Id,int id)
        {

            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Update_TestDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ranking", Ranking);
            cmd.Parameters.AddWithValue("@Distance", Distance);
            cmd.Parameters.AddWithValue("@NewTest_Id", NewTest_Id);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Success";
            return JsonConvert.SerializeObject(result);

        }
    }
}