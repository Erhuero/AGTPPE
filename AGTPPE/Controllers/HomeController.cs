using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AGTPPE.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accueil()
        {

            return View();
        }

        public ActionResult Deconnexion()
        {
            return View();
        }
        public new ActionResult User()
        {
            return View();
        }
        public ActionResult Administrateur()
        {
            return View();
        }
        public ActionResult IncidentsAdmin()
        {
            return View();

        }

    }
}
        /*
        public ActionResult IncidentsOuverts(object sender, EventArgs e)
        {
           

       
            string connetionString;
            SqlConnection cnn;

            connetionString = @"Data Source=DESKTOP-G18P8BC\SQLEXPRESS;Initial Catalog=KNInfo;Integrated Security=True";

            cnn = new SqlConnection(connetionString);

            cnn.Open();

           // Response.Write("Connexion établie");
            //cnn.Close();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";

            sql = "Select emplacementMaterielTicket,descriptionIncident, dateCreationTicket from TICKETS WHERE dateCreationTicket IS NOT NULL";

            command = new SqlCommand(sql, cnn);

            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
               
                Output = "<div class='dataReader'>" + Output + dataReader.GetValue(0) + "     " + dataReader.GetValue(1) + "    incident ouvert à   : "+dataReader.GetValue(2)+ "</br>"+"</div>";
            }

            Response.Write(Output);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return View();

        }
    
    }*/
