using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
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
using System.Windows.Shapes;

namespace BlackListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
            var args = Environment.GetCommandLineArgs();
            foreach (var arg in args)
            {
                if (arg.EndsWith("/ru"))
                {
                   
                    button1.Content = "Прикончить эту тварь!!!11";
                    i = 1;
                    
                }
                else if (arg.EndsWith("/ua"))
                {

                    button1.Content = "Прикінчити цю тварюку!!!11";
                    i = 2;

                }
                else if (arg.EndsWith("/eng"))
                {
                    button1.Content = "Punish this bastard!!!11";
                    
                    i = 3;


                }
                if(arg.EndsWith("/black"))
                {
                    Background = Brushes.Black;
                }
                else if(arg.EndsWith("/red"))
                {
                    Background = Brushes.Red;
                }
            }
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int kol = 0;
            try
            {
                foreach (Process chromeProcess in Process.GetProcessesByName(Killeds.Text))
                {
                    chromeProcess.Kill();
                    
                    kol++;
                    if(i==2)
                    {
                        KillInf.Text = "Падлюку " + Killeds.Text + " було покарано " + kol + " разів.";
                    }
                    if(i==1)
                    {
                        KillInf.Text = "Падлюку " + Killeds.Text + " было покарано " + kol + " раз.";
                    }
                    if(i==3)
                    {
                        KillInf.Text = "Bastard " + Killeds.Text + " was punished " + kol + " times.";
                    }
                    
                }
                         
            }
            catch (Exception b) { MessageBox.Show(b.Message); };

        }
    }

    
}
