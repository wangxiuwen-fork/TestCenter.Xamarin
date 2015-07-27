using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using TestCenter.Localization;
using TestCenter.Model;
using TestCenter.Services;

namespace TestCenter.ViewModels
{
    public class InstitutesViewModel: ViewModelBase
    {
        readonly InstituteService Service;
        readonly Func<Institute, InstituteViewModel> InstituteViewModelFactory;

        public IEnumerable<InstituteViewModel> Institutes { get; set; }

        public InstitutesViewModel(InstituteService service, Func<Institute, InstituteViewModel> instituteViewModelFactory)
        {
            Title = AppResource.AppName;
            Service = service;
            InstituteViewModelFactory = instituteViewModelFactory;
            Institutes = Service.GetAllPublishers().Select(p => InstituteViewModelFactory(p));
        }
    }
}