#pragma checksum "..\..\Calculadora.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6AEF8AEC9B79471674444639F5AAF00129E76FFC1A27B8D485A7C485952EB45D"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using Projeto1;
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


namespace Projeto1 {
    
    
    /// <summary>
    /// Calculadora
    /// </summary>
    public partial class Calculadora : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\Calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_num1;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_num2;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btMultiplicar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDivisao;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSubtração;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\Calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_resultado;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\Calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_limpar;
        
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
            System.Uri resourceLocater = new System.Uri("/Projeto1;component/calculadora.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Calculadora.xaml"
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
            this.txt_num1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\Calculadora.xaml"
            this.txt_num1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txt_num1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txt_num2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btMultiplicar = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Calculadora.xaml"
            this.btMultiplicar.Click += new System.Windows.RoutedEventHandler(this.btMultiplicar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btDivisao = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Calculadora.xaml"
            this.btDivisao.Click += new System.Windows.RoutedEventHandler(this.btDivisao_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 32 "..\..\Calculadora.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btSubtração = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\Calculadora.xaml"
            this.btSubtração.Click += new System.Windows.RoutedEventHandler(this.btSubtração_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txt_resultado = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.bt_limpar = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\Calculadora.xaml"
            this.bt_limpar.Click += new System.Windows.RoutedEventHandler(this.bt_limpar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

