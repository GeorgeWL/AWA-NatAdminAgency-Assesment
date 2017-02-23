using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalAdmissionAgency.Data;
using NationalAdmissionAgency.Data.IDAO;
using NationalAdmissionAgency.Data.DAO;
using NationalAdmissionAgency.Service;
using NationalAdmissionAgency.Service.IService;
using NationalAdmissionAgency.Service.Service;
using NationalAdmissionAgency.Models;

namespace NationalAdmissionAgency.Service.IService
{
    public interface INAAService
    {
        IList<NAA_Profile> GetApplicants();
    }
}
