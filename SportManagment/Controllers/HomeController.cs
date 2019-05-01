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

namespace SportManagment.Controllers
{

  
    public class HomeController : Controller
    {

        private readonly IConfiguration Configration;

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string result = string.Empty;





        public HomeController(IConfiguration config)
        {
            this.Configration = config;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Select_TestType", con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return View(ds);
        }


        [HttpPost]
        public string InsertTest(string Test_Name, DateTime date)
        {
           
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Inseart_NewTest", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NewTest_Type", Test_Name);
            cmd.Parameters.AddWithValue("@NewTest_Date", date);
            cmd.ExecuteNonQuery();
            con.Close();
            result = "Success";
           return JsonConvert.SerializeObject(result);
           
        }

        public string getTest()
        {
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Select_Test", con);
            cmd.CommandType = CommandType.StoredProcedure;
          //  cmd.Parameters.AddWithValue("@NewTest_Id",id);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            return JsonConvert.SerializeObject(ds);
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public string Login(string UserName, string Password)
        {
            string connectionstring = Configration.GetConnectionString("DefaultConnectionStrings");
            con = new SqlConnection(connectionstring);
            con.Open();
            cmd = new SqlCommand("sp_Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            //var v = ds.Tables[0].Rows[0]["Users_RoleID"];
            return JsonConvert.SerializeObject(ds);
        }
        public ActionResult Logout()
        {
           
            return RedirectToAction("Login");
           
        }
    }
}
