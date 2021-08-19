using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.Models.DAO
{
    public class PersonaRepository
    {
        public List<ClsPersona> ObtenerPersona()
        {
            return new List<ClsPersona>()
            {
                new ClsPersona()
                {
                    Id= 1,
                    Nombre="Katerine"
                },
                 new ClsPersona()
                 {
                     Id=2,
                     Nombre="Idalia"
                 },

                  new ClsPersona()
                 {
                     Id=3,
                     Nombre="Andrea"
                 }
            };
        }
    }
}