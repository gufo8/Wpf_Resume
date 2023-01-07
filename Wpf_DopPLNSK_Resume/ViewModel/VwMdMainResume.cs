using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Wpf_DopPLNSK_Resume.Model;

namespace Wpf_DopPLNSK_Resume
{
    class VwMdMainResume : VwMdBaseResume
    {
        private bool m_pressEdit = false;
        private bool m_pressAdd = false;
        private int m_pressCombo = 0;

        private MdSeekerResume m_modelSeeker;
        public List<MdSeekerResume> SeekersMd { get; set; }
       public ObservableCollection<string> SeekersFullName { get; set; }

        public VwMdMainResume()
        {            
            m_modelSeeker = new MdSeekerResume();
            SeekersMd = new List<MdSeekerResume>();
            SeekersFullName = new ObservableCollection<string>();
            Load();
            IsBtnViewEnable();
        }        

        private void Load()
        {
            try
            {
                using (DBContextRsm m_db = new DBContextRsm())
                {
                    var qvr = m_db.SeekerSet;
                    if (qvr != null)
                    {
                        SeekersMd = m_db.SeekerSet.ToList();
                        SeekersFullName.Clear();
                        foreach (MdSeekerResume item in SeekersMd)
                        {
                            SeekersFullName.Add(item.Surname + " " + item.Name);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool DeleteMessage { get; set; }

        private bool m_btnViewEnable;
        public bool IsViewRsmBtnEnable
        {
            get => m_btnViewEnable;
            set
            {
                m_btnViewEnable = value;
                OnPropertyChanged(nameof(IsViewRsmBtnEnable));
            }
        }

        private int m_comboSlctInd;
        public int ComboSelectedIndex
        {
            get => m_comboSlctInd;
            set
            {
                m_comboSlctInd = value;
                m_pressCombo = -1;
                OnPropertyChanged(nameof(ComboSelectedIndex));
            }
        }

        #region

        private Brush m_color;
        public Brush ColorBgrndTxt
        {
            get => m_color;
            set
            {
                m_color = value;
                OnPropertyChanged(nameof(ColorBgrndTxt));
            }
        }
        public string SurnameVM
        {
            get => m_modelSeeker.Surname;
            set
            {
                m_modelSeeker.Surname = value;
                OnPropertyChanged(nameof(SurnameVM));
            }
        }
        public string NameVM
        {
            get => m_modelSeeker.Name;
            set
            {
                m_modelSeeker.Name = value;
                OnPropertyChanged(nameof(NameVM));
            }
        }
        public string MiddleNameVM
        {
            get => m_modelSeeker.MiddleName;
            set
            {
                m_modelSeeker.MiddleName = value;
                OnPropertyChanged(nameof(MiddleNameVM));
            }
        }
        public string AgeVM
        {
            get => m_modelSeeker.Age;
            set
            {
                m_modelSeeker.Age = value;
                OnPropertyChanged(nameof(AgeVM));
            }
        }
        public string PhoneVM
        {
            get => m_modelSeeker.Phone;
            set
            {
                m_modelSeeker.Phone = value;
                OnPropertyChanged(nameof(PhoneVM));
            }
        }
        public string AddressVM
        {
            get => m_modelSeeker.Address;
            set
            {
                m_modelSeeker.Address = value;
                OnPropertyChanged(nameof(AddressVM));
            }
        }
        public string EMailVM
        {
            get => m_modelSeeker.EMail;
            set
            {
                m_modelSeeker.EMail = value;
                OnPropertyChanged(nameof(EMailVM));
            }
        }
        public bool UkrainianVM
        {
            get => m_modelSeeker.Ukrainian;
            set
            {
                m_modelSeeker.Ukrainian = value;
                OnPropertyChanged(nameof(UkrainianVM));
            }
        }
        public bool RussianVM
        {
            get => m_modelSeeker.Russian;
            set
            {
                m_modelSeeker.Russian = value;
                OnPropertyChanged(nameof(RussianVM));
            }
        }
        public bool EnglishVM
        {
            get => m_modelSeeker.English;
            set
            {
                m_modelSeeker.English = value;
                OnPropertyChanged(nameof(EnglishVM));
            }
        }
        public bool ChineeseVM
        {
            get => m_modelSeeker.Chineese;
            set
            {
                m_modelSeeker.Chineese = value;
                OnPropertyChanged(nameof(ChineeseVM));
            }
        }
        public bool SpanishVM
        {
            get => m_modelSeeker.Spanish;
            set
            {
                m_modelSeeker.Spanish = value;
                OnPropertyChanged(nameof(SpanishVM));
            }
        }
        public bool CSharpVM
        {
            get => m_modelSeeker.CSharp;
            set
            {
                m_modelSeeker.CSharp = value;
                OnPropertyChanged(nameof(CSharpVM));
            }
        }
        public bool CPlusVM
        {
            get => m_modelSeeker.CPlus;
            set
            {
                m_modelSeeker.CPlus = value;
                OnPropertyChanged(nameof(CPlusVM));
            }
        }
        public bool JavaVM
        {
            get => m_modelSeeker.Java;
            set
            {
                m_modelSeeker.Java = value;
                OnPropertyChanged(nameof(JavaVM));
            }
        }
        public bool RubyVM
        {
            get => m_modelSeeker.Ruby;
            set
            {
                m_modelSeeker.Ruby = value;
                OnPropertyChanged(nameof(RubyVM));
            }
        }
        public bool PHPVM
        {
            get => m_modelSeeker.PHP;
            set
            {
                m_modelSeeker.PHP = value;
                OnPropertyChanged(nameof(PHPVM));
            }
        }
        public bool PythonVM
        {
            get => m_modelSeeker.Python;
            set
            {
                m_modelSeeker.Python = value;
                OnPropertyChanged(nameof(PythonVM));
            }
        }
        public bool JavaScriptVM
        {
            get => m_modelSeeker.JavaScript;
            set
            {
                m_modelSeeker.JavaScript = value;
                OnPropertyChanged(nameof(JavaScriptVM));
            }
        }
        public bool OracleVM
        {
            get => m_modelSeeker.Oracle;
            set
            {
                m_modelSeeker.Oracle = value;
                OnPropertyChanged(nameof(OracleVM));
            }
        }
        public bool MSSQLServerVM
        {
            get => m_modelSeeker.MSSQLServer;
            set
            {
                m_modelSeeker.MSSQLServer = value;
                OnPropertyChanged(nameof(MSSQLServerVM));
            }
        }
        public bool MySQLVM
        {
            get => m_modelSeeker.MySQL;
            set
            {
                m_modelSeeker.MySQL = value;
                OnPropertyChanged(nameof(MySQLVM));
            }
        }
        public bool FirebirdVM
        {
            get => m_modelSeeker.Firebird;
            set
            {
                m_modelSeeker.Firebird = value;
                OnPropertyChanged(nameof(FirebirdVM));
            }
        }
        public bool MicrosoftAccessVM
        {
            get => m_modelSeeker.MicrosoftAccess;
            set
            {
                m_modelSeeker.MicrosoftAccess = value;
                OnPropertyChanged(nameof(MicrosoftAccessVM));
            }
        }
        public bool SQLiteVM
        {
            get => m_modelSeeker.SQLite;
            set
            {
                m_modelSeeker.SQLite = value;
                OnPropertyChanged(nameof(SQLiteVM));
            }
        }
        public bool ERPVM
        {
            get => m_modelSeeker.ERP;
            set
            {
                m_modelSeeker.ERP = value;
                OnPropertyChanged(nameof(ERPVM));
            }
        }
        public bool SAPVM
        {
            get => m_modelSeeker.SAP;
            set
            {
                m_modelSeeker.SAP = value;
                OnPropertyChanged(nameof(SAPVM));
            }
        }
        public bool BIVM
        {
            get => m_modelSeeker.BI;
            set
            {
                m_modelSeeker.BI = value;
                OnPropertyChanged(nameof(BIVM));
            }
        }
        #endregion        

        private DlgCmdResume addBtnClick;
        public ICommand AddBtnClick
        {
            get
            {
                if (addBtnClick == null)
                {
                    addBtnClick = new DlgCmdResume(param => AddResume(), param => CanAddResume());
                }
                return addBtnClick;
            }
        }

        private void AddResume()
        {
            ClearAllProp();
            m_pressAdd = true;
            ColorBgrndTxt = new SolidColorBrush(Colors.Black);
        }

        private bool CanAddResume()
        {
            return true;
        }


        private DlgCmdResume m_applyBtnClick;
        public ICommand ApplyBtnClick
        {
            get
            {
                if (m_applyBtnClick == null)
                {
                    m_applyBtnClick = new DlgCmdResume(param => Apply(), param => CanApply());
                }
                return m_applyBtnClick;
            }
        }

        private void Apply()
        {
            try
            {
                using (DBContextRsm m_db = new DBContextRsm())
                {
                    MdSeekerResume mdl = new();
                    RewriteAllPropToModel(mdl);

                    List<ValidationResult> results = new();
                    ValidationContext context = new(mdl);
                    if (!Validator.TryValidateObject(mdl, context, results, true))
                    {
                        foreach (ValidationResult error in results)
                        {
                            MessageBox.Show(error.ErrorMessage);
                        }
                        SurnameVM = null;
                        NameVM = null;
                        MiddleNameVM = null;
                        AgeVM = null;
                        PhoneVM = null;
                        AddressVM = null;
                        EMailVM = null;
                        return;
                    }

                    if (m_pressAdd)
                    {
                        var qvr = m_db.SeekerSet.Add(mdl);
                        m_db.SaveChanges();
                        Load();
                        ComboSelectedIndex = SeekersFullName.Count - 1;
                        IsBtnViewEnable();
                    }
                    if (m_pressEdit)
                    {
                        MdSeekerResume qvr = m_db.SeekerSet.Find(SeekersMd[ComboSelectedIndex].Id);
                        RewriteAllPropToModel(qvr);
                        m_db.SaveChanges();
                        int indx = m_comboSlctInd;
                        SeekersMd[m_comboSlctInd] = qvr;
                        SeekersFullName[m_comboSlctInd] = qvr.Surname + " " + qvr.Name;
                        ComboSelectedIndex = indx;
                    }
                    ClearAllProp();
                    ColorBgrndTxt = new SolidColorBrush(Colors.LightGray);
                    SurnameVM = "Enter Surname";
                    NameVM = "Enter Name";
                    MiddleNameVM = "Enter middle name";
                    AgeVM = "Enter age";
                    PhoneVM = "Enter phone number +380...";
                    AddressVM = "Enter address";
                    EMailVM = "Enter EMail";
                    m_pressAdd = false;
                    m_pressEdit = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CanApply()
        {
            if ((m_pressAdd || m_pressEdit ) && (SurnameVM != null || NameVM != null))
            {
                return true;
            }
            else return false;
        }


        private DlgCmdResume editBtnClick;
        public ICommand EditBtnClick
        {
            get
            {
                if (editBtnClick == null)
                {
                    editBtnClick = new DlgCmdResume(param => EditResume(), param => CanEditResume());
                }
                return editBtnClick;
            }
        }

        private void EditResume()
        {
            ColorBgrndTxt = new SolidColorBrush(Colors.Black);
            WritePropFromModel();
            m_pressEdit = true;
        }

        private bool CanEditResume()
        {
            if (m_pressCombo == -1 || SeekersFullName.Count != 0)
            {
                return true;
            }
            else return false;
        }


        private DlgCmdResume deleteBtnClick;
        public ICommand DeleteBtnClick
        {
            get
            {
                if (deleteBtnClick == null)
                {
                    deleteBtnClick = new DlgCmdResume(param => DeleteResume(), param => CanDeleteResume());
                }
                return deleteBtnClick;
            }
        }

        private void DeleteResume()
        {
            try
            {
                using (DBContextRsm m_db = new DBContextRsm())
                {
                    if (DeleteMessage)
                    {
                        if (SeekersMd[ComboSelectedIndex] != null)
                        {
                            var qvr = m_db.SeekerSet.Remove(SeekersMd[ComboSelectedIndex]);
                            m_db.SaveChanges();
                        }
                        SeekersMd.Remove(SeekersMd[m_comboSlctInd]);
                        SeekersFullName.Remove(SeekersFullName[m_comboSlctInd]);
                        ClearAllProp();
                        if (SeekersFullName.Count != 0)
                        {
                            ComboSelectedIndex = SeekersFullName.IndexOf(SeekersFullName[0]);
                        }
                        IsBtnViewEnable();
                        m_pressCombo = 0;
                        ColorBgrndTxt = new SolidColorBrush(Colors.LightGray);
                        SurnameVM = "Enter Surname";
                        NameVM = "Enter Name";
                        MiddleNameVM = "Enter middle name";
                        AgeVM = "Enter age";
                        PhoneVM = "Enter Phone number +380...";
                        AddressVM = "Enter address";
                        EMailVM = "Enter EMail";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool CanDeleteResume()
        {
            if (m_pressCombo == -1 || SeekersFullName.Count != 0)
            {
                return true;
            }
            else return false;
        }

        private void ClearAllProp()
        {
            SurnameVM = null;
            NameVM = null;
            MiddleNameVM = null;
            AgeVM = null;
            PhoneVM = null;
            AddressVM = null;
            EMailVM = null;
            UkrainianVM = false;
            RussianVM = false;
            EnglishVM = false;
            ChineeseVM = false;
            SpanishVM = false;
            CSharpVM = false;
            CPlusVM = false;
            JavaVM = false;
            RubyVM = false;
            PHPVM = false;
            PythonVM = false;
            JavaScriptVM = false;
            OracleVM = false;
            MSSQLServerVM = false;
            MySQLVM = false;
            FirebirdVM = false;
            MicrosoftAccessVM = false;
            SQLiteVM = false;
            ERPVM = false;
            SAPVM = false;
            BIVM = false;
        }

        private void RewriteAllPropToModel(MdSeekerResume mdl)
        {
            mdl.Surname = SurnameVM;
            mdl.Name = NameVM;
            mdl.MiddleName = MiddleNameVM;
            mdl.Age = AgeVM;
            mdl.Phone = PhoneVM;
            mdl.Address = AddressVM;
            mdl.EMail = EMailVM;
            mdl.Ukrainian = UkrainianVM;
            mdl.Russian = RussianVM;
            mdl.English = EnglishVM;
            mdl.Chineese = ChineeseVM;
            mdl.Spanish = SpanishVM;
            mdl.CSharp = CSharpVM;
            mdl.CPlus = CPlusVM;
            mdl.Java = JavaVM;
            mdl.Ruby = RubyVM;
            mdl.PHP = PHPVM;
            mdl.Python = PythonVM;
            mdl.JavaScript = JavaScriptVM;
            mdl.Oracle = OracleVM;
            mdl.MSSQLServer = MSSQLServerVM;
            mdl.MySQL = MySQLVM;
            mdl.Firebird = FirebirdVM;
            mdl.MicrosoftAccess = MicrosoftAccessVM;
            mdl.SQLite = SQLiteVM;
            mdl.ERP = ERPVM;
            mdl.SAP = SAPVM;
            mdl.BI = BIVM;
        }

        private void WritePropFromModel()
        {
            SurnameVM = SeekersMd[m_comboSlctInd].Surname;
            NameVM = SeekersMd[m_comboSlctInd].Name;
            MiddleNameVM = SeekersMd[m_comboSlctInd].MiddleName;
            AgeVM = SeekersMd[m_comboSlctInd].Age;
            PhoneVM = SeekersMd[m_comboSlctInd].Phone;
            AddressVM = SeekersMd[m_comboSlctInd].Address;
            EMailVM = SeekersMd[m_comboSlctInd].EMail;
            UkrainianVM = SeekersMd[m_comboSlctInd].Ukrainian;
            RussianVM = SeekersMd[m_comboSlctInd].Russian;
            EnglishVM = SeekersMd[m_comboSlctInd].English;
            ChineeseVM = SeekersMd[m_comboSlctInd].Chineese;
            SpanishVM = SeekersMd[m_comboSlctInd].Spanish;
            CSharpVM = SeekersMd[m_comboSlctInd].CSharp;
            CPlusVM = SeekersMd[m_comboSlctInd].CPlus;
            JavaVM = SeekersMd[m_comboSlctInd].Java;
            RubyVM = SeekersMd[m_comboSlctInd].Ruby;
            PHPVM = SeekersMd[m_comboSlctInd].PHP;
            PythonVM = SeekersMd[m_comboSlctInd].Python;
            JavaScriptVM = SeekersMd[m_comboSlctInd].JavaScript;
            OracleVM = SeekersMd[m_comboSlctInd].Oracle;
            MSSQLServerVM = SeekersMd[m_comboSlctInd].MSSQLServer;
            MySQLVM = SeekersMd[m_comboSlctInd].MySQL;
            FirebirdVM = SeekersMd[m_comboSlctInd].Firebird;
            MicrosoftAccessVM = SeekersMd[m_comboSlctInd].MicrosoftAccess;
            SQLiteVM = SeekersMd[m_comboSlctInd].SQLite;
            ERPVM = SeekersMd[m_comboSlctInd].ERP;
            SAPVM = SeekersMd[m_comboSlctInd].SAP;
            BIVM = SeekersMd[m_comboSlctInd].BI;
        }

        private void IsBtnViewEnable()
        {
            if (SeekersFullName.Count != 0)
            {
                IsViewRsmBtnEnable = true;
            }
            else
            {
                IsViewRsmBtnEnable = false;
            }
        }

    }
}
