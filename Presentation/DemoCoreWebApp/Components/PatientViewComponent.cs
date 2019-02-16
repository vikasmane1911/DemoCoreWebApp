using DemoCoreWebApp.Web.Factories;
using Microsoft.AspNetCore.Mvc;

namespace DemoCoreWebApp.Web.Components
{
    public class PatientViewComponent : ViewComponent
    {
        #region Fields

        private readonly IPatientModelFactory _patientModelFactory;

        #endregion

        #region Ctor

        public PatientViewComponent(IPatientModelFactory patientModelFactory)
        {
            this._patientModelFactory = patientModelFactory;
        }

        #endregion

        #region Methods

        public IViewComponentResult Invoke()
        {
            var model = _patientModelFactory.PreparePatientModel();
            return View(model);
        }

        #endregion
    }
}
