using DemoCoreWebApp.Core.Domain;
using DemoCoreWebApp.Core.Interfaces;

namespace DemoCoreWebApp.Data.Repositories
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(DemoCoreWebAppContext dbContext)
        : base(dbContext)
        {

        }
    }
}
