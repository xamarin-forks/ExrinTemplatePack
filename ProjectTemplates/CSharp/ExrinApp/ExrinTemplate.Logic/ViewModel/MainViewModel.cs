﻿using Exrin.Abstraction;
using ExrinMobileApp.Framework.Abstraction.Model;
using $safeprojectname$.Base;
using $safeprojectname$.VisualState;

namespace $safeprojectname$.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(IMainModel model, IExrinContainer exrinContainer)
            : base(exrinContainer, new MainVisualState(model))
        {
        }
    }
}
