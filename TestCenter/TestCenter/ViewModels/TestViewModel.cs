﻿using System;
using System.Windows.Input;
using TestCenter.Model;
using TestCenter.Services;
using Xamarin.Forms;

namespace TestCenter.ViewModels
{
    public class TestViewModel : ViewModelBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public ICommand ShowTestDetailsCommand { get; set; }

        readonly Navigator AppNavigator;
        readonly TestsService TestsService;

        public TestViewModel(Test test, Navigator navigator, TestsService service)
        {
            AppNavigator = navigator;
            TestsService = service;

            Id = test.Id;
            Name = test.Name;
            Detail = test.Detail;
            ShowTestDetailsCommand = new Command(ShowTestDetails);
        }

        void ShowTestDetails()
        {
            AppNavigator.PushAsync<TestDetailsViewModel>(viewModel =>
            {
                viewModel.Id = Id;
                viewModel.Name = Name;
                viewModel.Detail = Detail;
                viewModel.Instructions = TestsService.GetById(Id).Instructions;
            });
        }
    }
}
