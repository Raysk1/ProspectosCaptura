using CapturaDeProspectos.Models;
using ProspectosCaptura;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace CapturaDeProspectos.Controllers
{
    internal class ProspectoController
    {
        public static List<Prospecto> All()
        {
            var conn = DataBaseContext.GetContext();
            return conn.Prospectos.ToList();
        }

        public static Prospecto GetById(int id)
        {
            var conn = DataBaseContext.GetContext();
            return conn.Prospectos.FirstOrDefault(p => p.Id == id);
        }

        public static void Insert(Prospecto prospecto)
        {
            var conn = DataBaseContext.GetContext(); ;
            conn.Prospectos.Add(prospecto);
            conn.SaveChanges();
        }

        public static void Update(Prospecto prospecto)
        {
            var conn = DataBaseContext.GetContext();
            conn.Prospectos.AddOrUpdate(prospecto);
            conn.SaveChanges();
        }
    }
}
