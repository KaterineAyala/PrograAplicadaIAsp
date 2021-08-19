using Asp.Models;
using Asp.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Humano()
        {
            var persona = new ClsPersona { Nombre = "Katerine" };
            return View(persona);
        }

        public ActionResult VistalistadoPersona(String nombre)

        {
            PersonaRepository persona = new PersonaRepository();
            ViewBag.EnviandoNombre = nombre;
            return View(persona.ObtenerPersona());
        }
    }
}