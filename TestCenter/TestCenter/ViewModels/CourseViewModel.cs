using System;
using System.Linq;
using System.Windows.Input;
using TestCenter.Model;
using TestCenter.Services;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class CourseViewModel : ViewModelBase
    {
        readonly CoursesService Service;
        readonly TestsService TestsService;
        readonly Navigator AppNavigator;
        readonly Func<Test, TestsListItemViewModel> TestViewModelFactory;

        public int Id { get; set; }
        public int InstituteId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }

        public ICommand ShowCourseDetailCommand { get; set; }

        public CourseViewModel(Course course, Navigator navigator, CoursesService service, TestsService testsService, Func<Test, TestsListItemViewModel> testViewModelFactory)
        {
            Service = service;
            TestsService = testsService;
            AppNavigator = navigator;
            TestViewModelFactory = testViewModelFactory;

            InitializeViewModelFromModel(course);
        }

        void InitializeViewModelFromModel(Course course)
        {
            Id = course.Id;
            InstituteId = course.InstituteId;
            Name = course.Name;
            Detail = course.Detail;

            ShowCourseDetailCommand = new Command(ShowCourseDetails);
        }

        void ShowCourseDetails()
        {
            AppNavigator.PushAsync<CourseDetailsViewModel>(viewModel =>
            {
                viewModel.Id = Id;
                viewModel.InstituteId = InstituteId;
                viewModel.Name = Name;
                viewModel.Detail = Detail;
                viewModel.Tests = TestsService.GetByCourse(Id).Select(t => TestViewModelFactory(t));
            });
        }
    }
}