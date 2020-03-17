using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

	
namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["video"] = BaseHelper.EjecutarConsulta("Select * from video", CommandType.Text);

            return View();
        }


        public ActionResult Create()
        {

            return View();

        }

        [HttpPost]

        public ActionResult Create(int idVideo, string titulo, int Repro, string Url)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idVideo", idVideo));

            parametros.Add(new SqlParameter("@titulo", titulo));

            parametros.Add(new SqlParameter("@Repro", Repro));

            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.EjecutarSentencia("sp_Video1_insertar", CommandType.StoredProcedure, parametros);

            return View();

        }
     
        public ActionResult Update()
        {

            return View();

        }

        [HttpPost]

        public ActionResult Update(int idVideo, string titulo, int Repro, string Url)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idVideo", idVideo));

            parametros.Add(new SqlParameter("@titulo", titulo));

            parametros.Add(new SqlParameter("@Repro", Repro));

            parametros.Add(new SqlParameter("@Url", Url));

            BaseHelper.EjecutarSentencia("sp_Video1_actualizar", CommandType.StoredProcedure, parametros);

            return View();

        }

        public ActionResult Delete()
        {

            return View();

        }

        [HttpPost]

        public ActionResult Delete(int idVideo)
        {

            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.EjecutarSentencia("sp_Video1_borrar", CommandType.StoredProcedure, parametros);

            return View();

        }

    }

}




