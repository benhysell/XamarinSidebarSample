﻿using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Support.XamarinSidebarSample.Core.ViewModels;

namespace MvvmCross.iOS.Support.XamarinSidebarSample.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {

        private readonly IMvxNavigationService _navigationService;

        public AppStart(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        /// <summary>
        /// Start is called on startup of the app
        /// Hint contains information in case the app is started with extra parameters
        /// </summary>
        public void Start(object hint = null)
        {
            //_navigationService.Navigate<CenterPanelViewModel>();
            _navigationService.Navigate<CenterPanelViewModel>().GetAwaiter().GetResult();
           // ShowViewModel<CenterPanelViewModel>();
        }
    }
}