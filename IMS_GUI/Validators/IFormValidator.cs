using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using IMS_DataAccess;
using User_Repo;

namespace IMS_GUI
{
    public interface IFormValidator
    {
        bool IsTextBoxEmpty(Control control);
        void ClearFormControls(List<Control> controls);
        void CheckSpace_KeyPress(Guna.UI2.WinForms.Guna2TextBox control, KeyPressEventArgs e, string fieldName);
        void CheckNumeric_KeyPress(Control control, KeyPressEventArgs e, String fieldName);
        string ValidateAndTransformPhoneNumber(Control control);
        string FormatPhoneNumberForDisplay(string phoneNumber);
        void ResetColor_TextChanged(Guna.UI2.WinForms.Guna2TextBox control);
        void SetupNavigation(Form form, List<Guna.UI2.WinForms.Guna2TextBox> controls);
      
    }
}
