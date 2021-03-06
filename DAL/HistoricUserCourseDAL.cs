﻿using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HistoricUserCourseDAL : IDisposable
    {
        #region Extend BaseDAL
        private DataEntities _context = new DataEntities();
        private BaseDAL<HistoricUserCourse> historicUserCourseRepository;
        private bool disposed = false;

        public  BaseDAL<HistoricUserCourse> HistoricUserCourseRepository
        {
            get
            {
                return this.historicUserCourseRepository ?? new BaseDAL<HistoricUserCourse>(this._context);
            }
        }

        public void Save()
        {
            this._context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    this._context.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion Extend BaseDAL
    }
}
