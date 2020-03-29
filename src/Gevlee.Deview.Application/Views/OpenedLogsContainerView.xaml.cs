﻿using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Gevlee.Deview.Application.ViewModels;
using ReactiveUI;

namespace Gevlee.Deview.Application.Views
{
    public class OpenedLogsContainerView : ReactiveUserControl<OpenedLogsContainerViewModel>
    {
        public OpenedLogsContainerView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.WhenActivated(disposables => { });
            AvaloniaXamlLoader.Load(this);
        }
    }
}
