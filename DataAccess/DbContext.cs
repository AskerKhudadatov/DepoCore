using Entites.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
   public static class DbContext
    {
        public static List<Medicine> Medicines { get; }
        public static List<Categor> Categors { get; }
        static DbContext()
        {
            Medicines = new List<Medicine>();
            Categors = new List<Categor>();
        }
    }
}
