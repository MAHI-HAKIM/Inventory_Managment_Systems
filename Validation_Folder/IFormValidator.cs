using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public interface IFormValidator
    {
        bool IsTextBoxEmpty(Control control, string controlName);
        Role? ValidateRoleSelection(bool isSuperAdminChecked, bool isAdminChecked, bool isEmployeeChecked);
        string ValidateRole(RadioButton adminRadio, RadioButton employeeRadio);
        void ClearFormControls(List<Control> controls);
        void UncheckRadioButtons(List<Control> container);
        void CheckSpace_KeyPress(Guna.UI2.WinForms.Guna2TextBox control, KeyPressEventArgs e, string fieldName);
        void CheckNumeric_KeyPress(Control control, KeyPressEventArgs e, String fieldName);
        string ValidateAndTransformPhoneNumber(Control control);
        void ResetColor_TextChanged(Guna.UI2.WinForms.Guna2TextBox control);
        void SetupNavigation(Form form, List<Guna.UI2.WinForms.Guna2TextBox> controls);
    }
}
