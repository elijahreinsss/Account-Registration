namespace Account_Registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            StudentInfoClass.lastName = lastname_txtbox.Text;
            StudentInfoClass.firstName = firstname_txtbox.Text;
            StudentInfoClass.middleName = middlename_txtbox.Text;
            StudentInfoClass.program = program_txtbox.Text;
            StudentInfoClass.address = address_txtbox.Text;
            StudentInfoClass.age = long.Parse(age_txtbox.Text);
            StudentInfoClass.contactno = long.Parse(contactno_txtbox.Text);
            StudentInfoClass.studentno = long.Parse(studentno_txtbox.Text);

            FrmConfirm confirm = new FrmConfirm();
            if (confirm.ShowDialog() == DialogResult.OK)

            {
                lastname_txtbox.Clear();
                firstname_txtbox.Clear();
                middlename_txtbox.Clear();
                program_txtbox.Clear();
                address_txtbox.Clear();
                program_txtbox.Clear();
                age_txtbox.Clear();
                contactno_txtbox.Clear();
                studentno_txtbox.Clear();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
    }
}
