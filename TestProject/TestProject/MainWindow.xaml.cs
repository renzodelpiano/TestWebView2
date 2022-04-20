using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace TestProject {
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            InitializeWB();
        }

        private async Task InitializeWB() {
            await wb.EnsureCoreWebView2Async();
            wb.CoreWebView2.Navigate("file://" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "editor_summernote.html").Replace(@"\", @"/"));
        }
    }
}
