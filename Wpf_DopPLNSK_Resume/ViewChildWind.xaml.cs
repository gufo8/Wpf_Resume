using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Wpf_DopPLNSK_Resume
{
    /// <summary>
    /// Interaction logic for ViewChildWind.xaml
    /// </summary>
    public partial class ViewChildWind : Window
    {
        Table table1;
        TableRow currentRow;
        int ind = 2;
        public ViewChildWind(string surname, string name, string middleName = null, string age = null,
            string phone = null, string address = null, string eMail = null, bool flagLang = false, bool ukrainian = false,
            bool russian = false, bool english = false, bool chineese = false, bool spanish = false, bool flagInfTech = false,
            bool flagPrgLang = false, bool cSharp = false, bool cPlus = false, bool java = false, bool ruby = false,
            bool php = false, bool python = false, bool javaScript = false, bool flagDB = false, bool oracle = false,
            bool msSQLServer = false, bool mySQL = false, bool firebird = false, bool microsoftAccess = false,
            bool sqLite = false, bool flagAutoSys = false, bool erp = false, bool sap = false, bool bi = false)
        {
            InitializeComponent();

            SurnameVw = surname;
            NameVw = name;
            MiddleNameVw = middleName;
            AgeVw = age;
            PhoneVw = phone;
            AddressVw = address;
            EMailVw = eMail;

            FlagLang = flagLang;
            Ukrainian = ukrainian;
            Russian = russian;
            English = english;
            Chineese = chineese;
            Spanish = spanish;

            FlagInfTech = flagInfTech;
            FlagPrgLang = flagPrgLang;
            CSharpVw = cSharp;
            CPlusVw = cPlus;
            JavaVw = java;
            RubyVw = ruby;
            PHPVw = php;
            PythonVw = python;
            JavaScriptVw = javaScript;

            FlagDB = flagDB;
            OracleVw = oracle;
            MSSQLServerVw = msSQLServer;
            MySQLVw = mySQL;
            FirebirdVw = firebird;
            MicrosoftAccessVw = microsoftAccess;
            SQLiteVw = sqLite;

            FlagAutoSys = flagAutoSys;
            ERPVw = erp;
            SAPVw = sap;
            BIVw = bi;

            table1 = new Table();
            table1.BorderThickness = new Thickness(3);
            table1.BorderBrush = Brushes.Black;
            table1.CellSpacing = 10;
            flowDoc.Blocks.Add(table1);

            int numberOfColumns = 2;
            for (int x = 0; x < numberOfColumns; x++)
            {
                table1.Columns.Add(new TableColumn());                
            }
            table1.Columns[0].Width = new GridLength(150);

            table1.Columns[1].Width = new GridLength(150);
            table1.RowGroups.Add(new TableRowGroup());

            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[0];
            CreateFlowTable();
        }

        #region

        public string SurnameVw { get; set; }
        public string NameVw { get; set; }
        public string MiddleNameVw { get; set; }
        public string AgeVw { get; set; }
        public string PhoneVw { get; set; }
        public string AddressVw { get; set; }
        public string EMailVw { get; set; }

        public bool FlagLang { get; set; }
        public bool Ukrainian { get; set; }
        public bool Russian { get; set; }
        public bool English { get; set; }
        public bool Chineese { get; set; }
        public bool Spanish { get; set; }

        public bool FlagInfTech { get; set; }
        public bool FlagPrgLang { get; set; }
        public bool CSharpVw { get; set; }
        public bool CPlusVw { get; set; }
        public bool JavaVw { get; set; }
        public bool RubyVw { get; set; }
        public bool PHPVw { get; set; }
        public bool PythonVw { get; set; }
        public bool JavaScriptVw { get; set; }

        public bool FlagDB { get; set; }
        public bool OracleVw { get; set; }
        public bool MSSQLServerVw { get; set; }
        public bool MySQLVw { get; set; }
        public bool FirebirdVw { get; set; }
        public bool MicrosoftAccessVw { get; set; }
        public bool SQLiteVw { get; set; }

        public bool FlagAutoSys { get; set; }
        public bool ERPVw { get; set; }
        public bool SAPVw { get; set; }
        public bool BIVw { get; set; }
        #endregion

        private void CreateFlowTable()
        {
            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[0];
            currentRow.FontSize = 12;
            currentRow.FontWeight = FontWeights.Normal;

            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Surname:"))));
            currentRow.Cells[0].Background = Brushes.Yellow;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(SurnameVw))));
            currentRow.Cells[1].Background = Brushes.GreenYellow;

            table1.RowGroups[0].Rows.Add(new TableRow());
            currentRow = table1.RowGroups[0].Rows[1];
            currentRow.FontSize = 12;
            currentRow.FontWeight = FontWeights.Normal;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Name:"))));
            currentRow.Cells[0].Background = Brushes.Yellow;
            currentRow.Cells.Add(new TableCell(new Paragraph(new Run(NameVw))));
            currentRow.Cells[1].Background = Brushes.GreenYellow;
            CheckStr(MiddleNameVw, "Middle name:");
            CheckStr(AgeVw, "Age:");
            CheckStr(PhoneVw, "Phone:");
            CheckStr(AddressVw, "Address:");
            CheckStr(EMailVw, "EMail:");
            if (FlagLang)
            {
                table1.RowGroups[0].Rows.Add(new TableRow());
                currentRow = table1.RowGroups[0].Rows[ind];
                currentRow.FontSize = 12;
                currentRow.FontWeight = FontWeights.Bold;
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Knowledge of foreign languages:"))));
                currentRow.Cells[0].ColumnSpan = 2;
                currentRow.Cells[0].Background = Brushes.Yellow;
                ind++;

                CheckBoolStr(Ukrainian, "Ukrainian");
                CheckBoolStr(Russian, "Russian");
                CheckBoolStr(English, "English");
                CheckBoolStr(Chineese, "Chineese");
                CheckBoolStr(Spanish, "Spanish");
            }
            if (FlagInfTech)
            {
                table1.RowGroups[0].Rows.Add(new TableRow());
                currentRow = table1.RowGroups[0].Rows[ind];
                currentRow.FontSize = 12;
                currentRow.FontWeight = FontWeights.Bold;
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Knowledge of information technology"))));
                currentRow.Cells[0].ColumnSpan = 2;
                currentRow.Cells[0].Background = Brushes.Yellow;
                ind++;
                if (FlagPrgLang)
                {
                    table1.RowGroups[0].Rows.Add(new TableRow());
                    currentRow = table1.RowGroups[0].Rows[ind];
                    currentRow.FontSize = 12;
                    currentRow.FontWeight = FontWeights.Bold;
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Programming language:"))));
                    currentRow.Cells[0].ColumnSpan = 2;
                    currentRow.Cells[0].Background = Brushes.Yellow;
                    ind++;

                    CheckBoolStr(CSharpVw, "C#/.Net");
                    CheckBoolStr(CPlusVw, "C++");
                    CheckBoolStr(JavaVw, "Java");
                    CheckBoolStr(RubyVw, "Ruby");
                    CheckBoolStr(PHPVw, "PHP");
                    CheckBoolStr(PythonVw, "Python");
                    CheckBoolStr(JavaScriptVw, "JavaScript");
                }
                if (FlagDB)
                {
                    table1.RowGroups[0].Rows.Add(new TableRow());
                    currentRow = table1.RowGroups[0].Rows[ind];
                    currentRow.FontSize = 12;
                    currentRow.FontWeight = FontWeights.Bold;
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Database:"))));
                    currentRow.Cells[0].ColumnSpan = 2;
                    currentRow.Cells[0].Background = Brushes.Yellow;

                    ind++;

                    CheckBoolStr(OracleVw, "Oracle");
                    CheckBoolStr(MSSQLServerVw, "MS SQL Server");
                    CheckBoolStr(MySQLVw, "MySQL");
                    CheckBoolStr(FirebirdVw, "Firebird");
                    CheckBoolStr(MicrosoftAccessVw, "Microsoft Access");
                    CheckBoolStr(SQLiteVw, "SQLite");
                }
                if (FlagAutoSys)
                {
                    table1.RowGroups[0].Rows.Add(new TableRow());
                    currentRow = table1.RowGroups[0].Rows[ind];
                    currentRow.FontSize = 12;
                    currentRow.FontWeight = FontWeights.Bold;
                    currentRow.Cells.Add(new TableCell(new Paragraph(new Run("Automation system:"))));
                    currentRow.Cells[0].ColumnSpan = 2;
                    currentRow.Cells[0].Background = Brushes.Yellow;
                    ind++;

                    CheckBoolStr(ERPVw, "ERP");
                    CheckBoolStr(SAPVw, "SAP");
                    CheckBoolStr(BIVw, "BI");
                }
            }
        }

        private void CheckStr(string str1, string str2)
        {
            if (str1 != null)
            {
                table1.RowGroups[0].Rows.Add(new TableRow());
                currentRow = table1.RowGroups[0].Rows[ind];
                currentRow.FontSize = 12;
                currentRow.FontWeight = FontWeights.Normal;
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(str2))));

                Run r1 = new(str1);
                Paragraph p1 = new();
                p1.TextAlignment = TextAlignment.Left;
                p1.Inlines.Add(r1);
                currentRow.Cells.Add(new TableCell(p1));
                currentRow.Cells[0].Background = Brushes.Yellow;
                currentRow.Cells[1].Background = Brushes.GreenYellow;
                ind++;
            }
        }
        private void CheckBoolStr(bool param, string str)
        {
            if (param)
            {
                table1.RowGroups[0].Rows.Add(new TableRow());
                currentRow = table1.RowGroups[0].Rows[ind];
                currentRow.FontSize = 12;
                currentRow.FontWeight = FontWeights.Normal;
                currentRow.Cells.Add(new TableCell(new Paragraph(new Run(str))));
                currentRow.Cells[0].ColumnSpan = 2;
                currentRow.Cells[0].Background = Brushes.GreenYellow;
                ind++;
            }
        }

    }
}
