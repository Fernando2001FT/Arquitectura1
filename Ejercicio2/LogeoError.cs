using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSRP.Ejercicio2
{
    internal class LogeoError
    {
        private readonly Dbcontext _db;

        public LogeoError(Dbcontext db)
        {
            _db = db;
        }
        public void logError (Exception ex)
       {
            _db.LogError("error:",ex.ToString());
            File.WriteAllText("Log.txt", ex.ToString());

        }

        internal void Logear(Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
