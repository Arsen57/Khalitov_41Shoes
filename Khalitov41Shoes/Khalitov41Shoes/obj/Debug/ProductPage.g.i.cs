﻿#pragma checksum "..\..\ProductPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DAE775009305CA86CA11B4F821BB7D9B2538305E183DF79EE4596D912F3E4527"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Khalitov41Shoes;
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


namespace Khalitov41Shoes {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProdSearch;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CostComboBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DiscntComboBox;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProdAtTheMoment;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ProdAll;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductListView;
        
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
            System.Uri resourceLocater = new System.Uri("/Khalitov41Shoes;component/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductPage.xaml"
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
            this.ProdSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\ProductPage.xaml"
            this.ProdSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ProdSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CostComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 21 "..\..\ProductPage.xaml"
            this.CostComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CostComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DiscntComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 27 "..\..\ProductPage.xaml"
            this.DiscntComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DiscntComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ProdAtTheMoment = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ProdAll = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ProductListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

