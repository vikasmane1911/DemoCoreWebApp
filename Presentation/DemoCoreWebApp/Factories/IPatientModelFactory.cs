using DemoCoreWebApp.Core.Domain;
using DemoCoreWebApp.Web.Models;

namespace DemoCoreWebApp.Web.Factories
{
    public interface IPatientModelFactory
    {
        PatientModel PreparePatientModel();
        void AddPatient(Patient patient);
    }
}
