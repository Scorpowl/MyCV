using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyCV.Models.Entity;

namespace MyCV.Repositories
{
    public class DeneyimRepository: GenericRepository<TblDeneyimlerim>
    {
        MvcCvEntities db = new MvcCvEntities();
        public List<TblDeneyimlerim> List()
        {
            return db.TblDeneyimlerim.ToList();
        }
    }
}