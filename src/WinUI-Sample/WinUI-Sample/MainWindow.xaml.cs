using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI_Sample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 最大化窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void myButton_Click(object sender, RoutedEventArgs e)
        //{
        //    myButton.Content = "Clicked";
        //    //最大化
        //    IntPtr hwnd = (App.Current as App).MainWindowWindowHandle;
        //    PInvoke.User32.ShowWindow(hwnd, PInvoke.User32.WindowShowStyle.SW_MAXIMIZE);
        //}


        /// <summary>
        /// 获取当前进程中加载的模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";

            var description = new System.Text.StringBuilder();
            var process = System.Diagnostics.Process.GetCurrentProcess();
            foreach (System.Diagnostics.ProcessModule module in process.Modules)
            {
                description.AppendLine(module.FileName);
            }

            cdTextBlock.Text = description.ToString();
            await contentDialog.ShowAsync();
        }

    }
}
