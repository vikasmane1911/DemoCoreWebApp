using DemoCoreWebApp.Core.Domain;
using DemoCoreWebApp.Web.Factories;
using Microsoft.AspNetCore.Mvc;

namespace DemoCoreWebApp.Web.Controllers
{
    public class PatientController : Controller
    {
        private IPatientModelFactory patientModelFactory;

        public IActionResult Index([FromServices]IPatientModelFactory _patientModelFactory)
        {
            this.patientModelFactory = _patientModelFactory;

            patientModelFactory.AddPatient(new Patient { FirstName = "Vikas" });

            return View();
        }
    }
}