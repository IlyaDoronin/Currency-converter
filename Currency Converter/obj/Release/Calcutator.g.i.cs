﻿#pragma checksum "..\..\Calcutator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8025AE48903AF4BACE126C69447FE8F589AA4D70"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Currency_Converter;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Currency_Converter {
    
    
    /// <summary>
    /// Calcutator
    /// </summary>
    public partial class Calcutator : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 63 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BYN_Field;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox USD_Field;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RUB_Field;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EUR_Field;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UAH_Field;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cur_Input;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input;
        
        #line default
        #line hidden
        
        
        #line 180 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Cur_Output;
        
        #line default
        #line hidden
        
        
        #line 208 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Output;
        
        #line default
        #line hidden
        
        
        #line 222 "..\..\Calcutator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Date;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Currency Converter;component/calcutator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Calcutator.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\Calcutator.xaml"
            ((Currency_Converter.Calcutator)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BYN_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\Calcutator.xaml"
            this.BYN_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.BYN_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 67 "..\..\Calcutator.xaml"
            this.BYN_Field.GotFocus += new System.Windows.RoutedEventHandler(this.BYN_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 67 "..\..\Calcutator.xaml"
            this.BYN_Field.LostFocus += new System.Windows.RoutedEventHandler(this.BYN_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.USD_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 80 "..\..\Calcutator.xaml"
            this.USD_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.USD_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 81 "..\..\Calcutator.xaml"
            this.USD_Field.GotFocus += new System.Windows.RoutedEventHandler(this.USD_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 81 "..\..\Calcutator.xaml"
            this.USD_Field.LostFocus += new System.Windows.RoutedEventHandler(this.USD_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RUB_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 94 "..\..\Calcutator.xaml"
            this.RUB_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.RUB_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 95 "..\..\Calcutator.xaml"
            this.RUB_Field.GotFocus += new System.Windows.RoutedEventHandler(this.RUB_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 95 "..\..\Calcutator.xaml"
            this.RUB_Field.LostFocus += new System.Windows.RoutedEventHandler(this.RUB_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EUR_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 108 "..\..\Calcutator.xaml"
            this.EUR_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.EUR_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 109 "..\..\Calcutator.xaml"
            this.EUR_Field.GotFocus += new System.Windows.RoutedEventHandler(this.EUR_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 109 "..\..\Calcutator.xaml"
            this.EUR_Field.LostFocus += new System.Windows.RoutedEventHandler(this.EUR_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.UAH_Field = ((System.Windows.Controls.TextBox)(target));
            
            #line 122 "..\..\Calcutator.xaml"
            this.UAH_Field.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.UAH_Field_TextChanged);
            
            #line default
            #line hidden
            
            #line 123 "..\..\Calcutator.xaml"
            this.UAH_Field.GotFocus += new System.Windows.RoutedEventHandler(this.UAH_Field_GotFocus);
            
            #line default
            #line hidden
            
            #line 123 "..\..\Calcutator.xaml"
            this.UAH_Field.LostFocus += new System.Windows.RoutedEventHandler(this.UAH_Field_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Cur_Input = ((System.Windows.Controls.ComboBox)(target));
            
            #line 146 "..\..\Calcutator.xaml"
            this.Cur_Input.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.Cur_Input_TextChanged));
            
            #line default
            #line hidden
            return;
            case 8:
            this.Input = ((System.Windows.Controls.TextBox)(target));
            
            #line 171 "..\..\Calcutator.xaml"
            this.Input.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Input_TextChanged);
            
            #line default
            #line hidden
            
            #line 172 "..\..\Calcutator.xaml"
            this.Input.GotFocus += new System.Windows.RoutedEventHandler(this.Input_GotFocus);
            
            #line default
            #line hidden
            
            #line 172 "..\..\Calcutator.xaml"
            this.Input.LostFocus += new System.Windows.RoutedEventHandler(this.Input_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Cur_Output = ((System.Windows.Controls.ComboBox)(target));
            
            #line 186 "..\..\Calcutator.xaml"
            this.Cur_Output.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.Cur_Output_TextChanged));
            
            #line default
            #line hidden
            return;
            case 10:
            this.Output = ((System.Windows.Controls.TextBox)(target));
            
            #line 211 "..\..\Calcutator.xaml"
            this.Output.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Output_TextChanged);
            
            #line default
            #line hidden
            
            #line 212 "..\..\Calcutator.xaml"
            this.Output.GotFocus += new System.Windows.RoutedEventHandler(this.Output_GotFocus);
            
            #line default
            #line hidden
            
            #line 212 "..\..\Calcutator.xaml"
            this.Output.LostFocus += new System.Windows.RoutedEventHandler(this.Output_LostFocus);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Date = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

