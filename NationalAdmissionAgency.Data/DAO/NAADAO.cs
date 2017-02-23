using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalAdmissionAgency.Data;
using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.DAO;
using NationalAdmissionAgency.Models;

namespace NationalAdmissionAgency.Data.DAO
{
    public class NAADAO : INAADAO
    {
        private NAAEntities _context;
        public NAADAO()
        {
            _context = new NAAEntities();
        }
        public IList<NAA_Profile> GetApplicants()
        {
            var _applicants = from ApplicantName
                in _context.NAA_Profile
                       select new NAA_Profile
                       {
                           Id = ApplicantName.Id,
                           ApplicantName = ApplicantName.ApplicantName,
                           ApplicantAddress = ApplicantName.ApplicantAddress,
                           Phone = ApplicantName.Phone,
                           Email = ApplicantName.Email,
                           UserId = ApplicantName.UserId
                       };
            return _applicants.ToList();
        }
    }
}
