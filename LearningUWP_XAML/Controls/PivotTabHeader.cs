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
    public sealed class PivotTabHeader : Control
    {
        public PivotTabHeader()
        {
            this.DefaultStyleKey = typeof(PivotTabHeader);
        }

        public string TabSymbol
        {
            get { return (string)GetValue(TabSymbolProperty); }
            set { SetValue(TabSymbolProperty, value); }
        }
        
        public static readonly DependencyProperty TabSymbolProperty =
            DependencyProperty.Register("TabSymbol", typeof(string), 
                typeof(PivotTabHeader), new PropertyMetadata("Map"));

        public string TabText
        {
            get { return (string)GetValue(TabTextProperty); }
            set { SetValue(TabTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TabTextProperty =
            DependencyProperty.Register("TabText", typeof(string), 
                typeof(PivotTabHeader), new PropertyMetadata("Tab text"));




    }
}
