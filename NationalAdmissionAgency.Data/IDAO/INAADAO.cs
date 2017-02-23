using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalAdmissionAgency.Data;
using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.DAO;
using NationalAdmissionAgency.Models;


namespace NationalAdmissionAgency.Data.IDAO
{
    public interface INAADAO
    {
        IList<NAA_Profile> GetApplicants();
    }

}
