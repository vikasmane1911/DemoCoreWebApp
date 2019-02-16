using DemoCoreWebApp.Core.Domain;
using DemoCoreWebApp.Core.Interfaces;
using DemoCoreWebApp.Web.Models;

namespace DemoCoreWebApp.Web.Factories
{
    public class PatientModelFactory : IPatientModelFactory
    {
        private IPatientRepository patientRepository;

        public PatientModelFactory(IPatientRepository _patientRepository)
        {
            this.patientRepository = _patientRepository;
        }

        public void AddPatient(Patient patient)
        {
            patientRepository.Create(patient);
        }

        public PatientModel PreparePatientModel()
        {
            throw new System.NotImplementedException();
        }
    }
}
