using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_DopPLNSK_Resume
{
    class MdSeekerResume
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The field 'Surname' must be filled.")]
        [RegularExpression(@"^([a-zA-Z]{1,}|[a-zA-Z]{'?-?[a-zA-Z]{2,10}\s?([a-zA-Z]{1,10})?)", ErrorMessage = "Enter the last name in English, in the format Smith or D'Larghe or Doe-Smith or Luther King")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "The field 'Name' must be filled.")]
        [RegularExpression(@"^([a-zA-Z]{2,})", ErrorMessage = "The name must be at least 2 letters")]
        public string Name { get; set; }

        [RegularExpression(@"^([a-zA-Z]{2,})", ErrorMessage = "The name must be at least 2 letters")]
        public string MiddleName { get; set; }

        [Range(18, 65)]
        public string Age { get; set; }

        [RegularExpression(@"^(\+380\d{7})", ErrorMessage = "The name must be at least 2 letters")]
        public string Phone { get; set; }
        public string Address { get; set; }

        [RegularExpression(@"^.+@.+\..+$")]
        public string EMail { get; set; }
        public bool Ukrainian { get; set; }
        public bool Russian { get; set; }
        public bool English { get; set; }
        public bool Chineese { get; set; }
        public bool Spanish { get; set; }
        public bool CSharp { get; set; }
        public bool CPlus { get; set; }
        public bool Java { get; set; }
        public bool Ruby { get; set; }
        public bool PHP { get; set; }
        public bool Python { get; set; }
        public bool JavaScript { get; set; }
        public bool Oracle { get; set; }
        public bool MSSQLServer { get; set; }
        public bool MySQL { get; set; }
        public bool Firebird { get; set; }
        public bool MicrosoftAccess { get; set; }
        public bool SQLite { get; set; }
        public bool ERP { get; set; }
        public bool SAP { get; set; }
        public bool BI { get; set; }

        public MdSeekerResume()
        {
            Surname = "Enter Surname";
            Name = "Enter Name";
            MiddleName = "Enter middle name";
            Age = "Enter age";
            Phone = "Enter phone number +380...";
            Address = "Enter address";
            EMail = "Enter EMail";
        }

    }
}
