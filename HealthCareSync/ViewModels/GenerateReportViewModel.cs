using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareSync.DAL;

namespace HealthCareSync.ViewModels
{
    public class GenerateReportViewModel
    {
        private AdministratorDatalayer adminDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateReportViewModel"/> class.
        /// </summary>
        public GenerateReportViewModel()
        {
            this.adminDAL = new AdministratorDatalayer();
        }

        /// <summary>
        /// Executes the query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public Tuple<DataTable,string> ExecuteQuery(string query)
        {
            return this.adminDAL.ExecuteQuery(query);
        }

        /// <summary>
        /// Views the report.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public DataTable ViewReport(DateTime from, DateTime to)
        {
            return this.adminDAL.ViewReport(from, to);
        }
    }
}
