using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empinfo;
namespace EmpInformation
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp=new Employee();
            emp.EmpAddress = textEmpAddress.Text;
            emp.EmployeeName = textEmpName.Text;
            emp.EmpId =textEmpId.Text ;
        
            emp.EmpPhone =textPhone.Text;
            try
            {

                emp.EmpTweetId = textTweetId.Text;
            }
            catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
