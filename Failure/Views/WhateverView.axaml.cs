using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Failure.Views;

public partial class WhateverView : UserControl
{
    public WhateverView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}