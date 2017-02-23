using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalAdmissionAgency.Data;
using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.DAO;
using NationalAdmissionAgency.Service.IService;
using NationalAdmissionAgency.Service;
using NationalAdmissionAgency.Service.Service;
using NationalAdmissionAgency.Models;

namespace NationalAdmissionAgency.Service.Service
{
    public class NAAService : INAADAO
    {
        private INAADAO _naaDAO;
        public NAAService() { _naaDAO = new NAADAO(); }

        public IList<NAA_Profile> INAADAO.GetApplicants()
        {
            return _naaDAO.GetApplicants();
        }
    }
}
