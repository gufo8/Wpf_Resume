using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Wpf_DopPLNSK_Resume.Model;

namespace Wpf_DopPLNSK_Resume
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TxtBxSrnm.Foreground = new SolidColorBrush(Colors.LightGray);
            TxtBxNm.Foreground = new SolidColorBrush(Colors.LightGray);
            TxtBxMdlNm.Foreground = new SolidColorBrush(Colors.LightGray);
            TxtBxAg.Foreground = new SolidColorBrush(Colors.LightGray);
            TxtBxPhn.Foreground = new SolidColorBrush(Colors.LightGray);
            TxtBxAdrs.Foreground = new SolidColorBrush(Colors.LightGray);
            TxtBxEMl.Foreground = new SolidColorBrush(Colors.LightGray);
        }
        
        private void Message(object sender, RoutedEventArgs e)
        {
            VwMdMainResume el = Resources["VMR"] as VwMdMainResume;
            string prs = el?.SeekersFullName[el.ComboSelectedIndex];
            MessageBoxResult msrlt = MessageBox.Show($"Are you sure you want to delete {prs}", "Delete element", MessageBoxButton.YesNo);
            if (msrlt == MessageBoxResult.Yes)
            {
                el.DeleteMessage = true;
            }
            else
            {
                el.DeleteMessage = false;
            }
        }

        private void ViewRsm(object sender, RoutedEventArgs e)
        {
            VwMdMainResume el = Resources["VMR"] as VwMdMainResume;
           
            el.SurnameVM = el.SeekersMd[el.ComboSelectedIndex].Surname;
            el.NameVM = el.SeekersMd[el.ComboSelectedIndex].Name;
            el.MiddleNameVM = el.SeekersMd[el.ComboSelectedIndex]?.MiddleName;
            el.AgeVM = el.SeekersMd[el.ComboSelectedIndex].Age;
            el.PhoneVM = el.SeekersMd[el.ComboSelectedIndex].Phone;
            el.AddressVM = el.SeekersMd[el.ComboSelectedIndex].Address;
            el.EMailVM = el.SeekersMd[el.ComboSelectedIndex].EMail;
            el.UkrainianVM = el.SeekersMd[el.ComboSelectedIndex].Ukrainian;
            el.RussianVM = el.SeekersMd[el.ComboSelectedIndex].Russian;
            el.EnglishVM = el.SeekersMd[el.ComboSelectedIndex].English;
            el.ChineeseVM = el.SeekersMd[el.ComboSelectedIndex].Chineese;
            el.SpanishVM = el.SeekersMd[el.ComboSelectedIndex].Spanish;
            el.CSharpVM = el.SeekersMd[el.ComboSelectedIndex].CSharp;
            el.CPlusVM = el.SeekersMd[el.ComboSelectedIndex].CPlus;
            el.JavaVM = el.SeekersMd[el.ComboSelectedIndex].Java;
            el.RubyVM = el.SeekersMd[el.ComboSelectedIndex].Ruby;
            el.PHPVM = el.SeekersMd[el.ComboSelectedIndex].PHP;
            el.PythonVM = el.SeekersMd[el.ComboSelectedIndex].Python;
            el.JavaScriptVM = el.SeekersMd[el.ComboSelectedIndex].JavaScript;
            el.OracleVM = el.SeekersMd[el.ComboSelectedIndex].Oracle;
            el.MSSQLServerVM = el.SeekersMd[el.ComboSelectedIndex].MSSQLServer;
            el.MySQLVM = el.SeekersMd[el.ComboSelectedIndex].MySQL;
            el.FirebirdVM = el.SeekersMd[el.ComboSelectedIndex].Firebird;
            el.MicrosoftAccessVM = el.SeekersMd[el.ComboSelectedIndex].MicrosoftAccess;
            el.SQLiteVM = el.SeekersMd[el.ComboSelectedIndex].SQLite;
            el.ERPVM = el.SeekersMd[el.ComboSelectedIndex].ERP;
            el.SAPVM = el.SeekersMd[el.ComboSelectedIndex].SAP;
            el.BIVM = el.SeekersMd[el.ComboSelectedIndex].BI;
            bool flagLang = false;
            bool flagInfTech = false;
            bool flagPrgLang = false;
            bool flagDB = false;
            bool flagAutoSys = false;


            if (el.UkrainianVM || el.RussianVM || el.EnglishVM || el.ChineeseVM || el.SpanishVM)
            {
                flagLang = true;
            }
            if (el.CSharpVM || el.CPlusVM || el.JavaVM || el.RubyVM || el.PHPVM ||
                el.PythonVM || el.JavaScriptVM || el.OracleVM || el.MSSQLServerVM ||
                el.MySQLVM || el.FirebirdVM || el.MicrosoftAccessVM || el.SQLiteVM || el.ERPVM || el.SAPVM || el.BIVM)
            {
                flagInfTech = true;
            }
            if (el.CSharpVM || el.CPlusVM || el.JavaVM || el.RubyVM || el.PHPVM || el.PythonVM || el.JavaScriptVM)
            {
                flagPrgLang = true;
            }
            if (el.OracleVM || el.MSSQLServerVM || el.MySQLVM || el.FirebirdVM || el.MicrosoftAccessVM || el.SQLiteVM)
            {
                flagDB = true;
            }
            if (el.ERPVM || el.SAPVM || el.BIVM)
            {
                flagAutoSys = true;
            }
            ViewChildWind vwRsm = new(el.SurnameVM, el.NameVM, el.MiddleNameVM, el.AgeVM, el.PhoneVM,
                el.AddressVM, el.EMailVM, flagLang, el.UkrainianVM, el.RussianVM, el.EnglishVM, el.ChineeseVM,
                el.SpanishVM, flagInfTech, flagPrgLang, el.CSharpVM, el.CPlusVM, el.JavaVM, el.RubyVM, el.PHPVM,
                el.PythonVM, el.JavaScriptVM, flagDB, el.OracleVM, el.MSSQLServerVM, el.MySQLVM, el.FirebirdVM,
                el.MicrosoftAccessVM, el.SQLiteVM, flagAutoSys, el.ERPVM, el.SAPVM, el.BIVM);

            el.ColorBgrndTxt = new SolidColorBrush(Colors.LightGray);
            el.SurnameVM = "Enter Surname";
            el.NameVM = "Enter Name";
            el.MiddleNameVM = "Enter middle name";
            el.AgeVM = "Enter age";
            el.PhoneVM = "Enter phone number +380...";
            el.AddressVM = "Enter address";
            el.EMailVM = "Enter EMail";
            el.UkrainianVM = false;
            el.RussianVM = false;
            el.EnglishVM = false;
            el.ChineeseVM = false;
            el.SpanishVM = false;
            el.CSharpVM = false;
            el.CPlusVM = false;
            el.JavaVM = false;
            el.RubyVM = false;
            el.PHPVM = false;
            el.PythonVM = false;
            el.JavaScriptVM = false;
            el.OracleVM = false;
            el.MSSQLServerVM = false;
            el.MySQLVM = false;
            el.FirebirdVM = false;
            el.MicrosoftAccessVM = false;
            el.SQLiteVM = false;
            el.ERPVM = false;
            el.SAPVM = false;
            el.BIVM = false;

            vwRsm.Show();
        }
    }
}
