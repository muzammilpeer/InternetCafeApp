﻿

#pragma checksum "C:\Users\MuzammilPeer\documents\visual studio 2012\Projects\InternetCafeApp\InternetCafeApp\View\SqliteSample.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B8BF71F305A69EE4F57425C787F08EB0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternetCafeApp.View
{
    partial class SqliteSample : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 18 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).KeyDown += this.LayoutRoot_KeyDown;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 19 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.listtable;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 20 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ListView_SelectionChanged_1;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 21 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.deleteall;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 22 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.createtable;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 23 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.insert;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 29 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.drop;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 30 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.txt1_TextChanged;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 31 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.txt2_TextChanged;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 32 "..\..\..\View\SqliteSample.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.deleteselected;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


