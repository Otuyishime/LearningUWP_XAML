using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace LearningUWP_XAML.Controls
{
    public sealed class MainMenuButton : Control
    {
        public MainMenuButton()
        {
            this.DefaultStyleKey = typeof(MainMenuButton);
        }
        
        public string ButtonSymbol
        {
            get { return (string)GetValue(ButtonSymbolProperty); }
            set { SetValue(ButtonSymbolProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MenuSymbol. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonSymbolProperty =
            DependencyProperty.Register(nameof(ButtonSymbol), typeof(string), typeof(MainMenuButton), new PropertyMetadata(""));

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonText. This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register(nameof(ButtonText), typeof(string), typeof(MainMenuButton), new PropertyMetadata(""));



    }
}
