using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.StudentInfoClass;

namespace Account_Registration


{

    public partial class FrmConfirm : Form
    {

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;


        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetlastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetfirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetmiddleName);
            DelAddress = new DelegateText(StudentInfoClass.Getaddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.Getage);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.Getcontactno);
            DelStudNo = new DelegateNumber(StudentInfoClass.Getstudentno);


        }



        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            program.Text = DelProgram();
            lastname.Text = DelLastName();
            firstname.Text = DelFirstName();
            middlename.Text = DelMiddleName();
            address.Text = DelAddress();
            age.Text = DelNumAge().ToString();
            contactno.Text = DelNumContactNo().ToString();
            studentno.Text = DelStudNo().ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }

}
