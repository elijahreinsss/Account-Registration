namespace Account_Registration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            studentno = new Label();
            studentno_txtbox = new TextBox();
            firstname = new Label();
            Lastname = new Label();
            address = new Label();
            age = new Label();
            program = new Label();
            middlename = new Label();
            lastname_txtbox = new TextBox();
            firstname_txtbox = new TextBox();
            middlename_txtbox = new TextBox();
            age_txtbox = new TextBox();
            address_txtbox = new TextBox();
            contactno_txtbox = new TextBox();
            contactno = new Label();
            program_txtbox = new TextBox();
            next_btn = new Button();
            SuspendLayout();
            // 
            // studentno
            // 
            studentno.AutoSize = true;
            studentno.ForeColor = SystemColors.ButtonFace;
            studentno.Location = new Point(113, 42);
            studentno.Name = "studentno";
            studentno.Size = new Size(68, 15);
            studentno.TabIndex = 0;
            studentno.Text = "Student no:";
            // 
            // studentno_txtbox
            // 
            studentno_txtbox.Location = new Point(113, 73);
            studentno_txtbox.Name = "studentno_txtbox";
            studentno_txtbox.Size = new Size(156, 23);
            studentno_txtbox.TabIndex = 1;
            // 
            // firstname
            // 
            firstname.AutoSize = true;
            firstname.ForeColor = SystemColors.ButtonFace;
            firstname.Location = new Point(284, 116);
            firstname.Name = "firstname";
            firstname.Size = new Size(67, 15);
            firstname.TabIndex = 2;
            firstname.Text = "First Name:";
            // 
            // Lastname
            // 
            Lastname.AutoSize = true;
            Lastname.ForeColor = SystemColors.ButtonFace;
            Lastname.Location = new Point(115, 116);
            Lastname.Name = "Lastname";
            Lastname.Size = new Size(66, 15);
            Lastname.TabIndex = 3;
            Lastname.Text = "Last Name:";
            // 
            // address
            // 
            address.AutoSize = true;
            address.ForeColor = SystemColors.ButtonFace;
            address.Location = new Point(115, 301);
            address.Name = "address";
            address.Size = new Size(52, 15);
            address.TabIndex = 4;
            address.Text = "Address:";
            // 
            // age
            // 
            age.AutoSize = true;
            age.ForeColor = SystemColors.ButtonFace;
            age.Location = new Point(115, 214);
            age.Name = "age";
            age.Size = new Size(31, 15);
            age.TabIndex = 5;
            age.Text = "Age:";
            // 
            // program
            // 
            program.AutoSize = true;
            program.ForeColor = SystemColors.ButtonFace;
            program.Location = new Point(308, 42);
            program.Name = "program";
            program.Size = new Size(56, 15);
            program.TabIndex = 6;
            program.Text = "Program:";
            // 
            // middlename
            // 
            middlename.AutoSize = true;
            middlename.ForeColor = SystemColors.ButtonFace;
            middlename.Location = new Point(457, 116);
            middlename.Name = "middlename";
            middlename.Size = new Size(82, 15);
            middlename.TabIndex = 7;
            middlename.Text = "Middle Name:";
            // 
            // lastname_txtbox
            // 
            lastname_txtbox.Location = new Point(113, 148);
            lastname_txtbox.Name = "lastname_txtbox";
            lastname_txtbox.Size = new Size(156, 23);
            lastname_txtbox.TabIndex = 8;
            // 
            // firstname_txtbox
            // 
            firstname_txtbox.Location = new Point(284, 148);
            firstname_txtbox.Name = "firstname_txtbox";
            firstname_txtbox.Size = new Size(156, 23);
            firstname_txtbox.TabIndex = 9;
            // 
            // middlename_txtbox
            // 
            middlename_txtbox.Location = new Point(446, 148);
            middlename_txtbox.Name = "middlename_txtbox";
            middlename_txtbox.Size = new Size(156, 23);
            middlename_txtbox.TabIndex = 10;
            // 
            // age_txtbox
            // 
            age_txtbox.Location = new Point(113, 252);
            age_txtbox.Name = "age_txtbox";
            age_txtbox.Size = new Size(156, 23);
            age_txtbox.TabIndex = 11;
            // 
            // address_txtbox
            // 
            address_txtbox.Location = new Point(113, 334);
            address_txtbox.Name = "address_txtbox";
            address_txtbox.Size = new Size(489, 23);
            address_txtbox.TabIndex = 12;
            // 
            // contactno_txtbox
            // 
            contactno_txtbox.Location = new Point(286, 252);
            contactno_txtbox.Name = "contactno_txtbox";
            contactno_txtbox.Size = new Size(156, 23);
            contactno_txtbox.TabIndex = 14;
            // 
            // contactno
            // 
            contactno.AutoSize = true;
            contactno.ForeColor = SystemColors.ButtonFace;
            contactno.Location = new Point(286, 214);
            contactno.Name = "contactno";
            contactno.Size = new Size(71, 15);
            contactno.TabIndex = 13;
            contactno.Text = "Contact No:";
            // 
            // program_txtbox
            // 
            program_txtbox.Location = new Point(286, 73);
            program_txtbox.Name = "program_txtbox";
            program_txtbox.Size = new Size(316, 23);
            program_txtbox.TabIndex = 15;
            // 
            // next_btn
            // 
            next_btn.Location = new Point(308, 390);
            next_btn.Name = "next_btn";
            next_btn.Size = new Size(75, 23);
            next_btn.TabIndex = 16;
            next_btn.Text = "Next";
            next_btn.UseVisualStyleBackColor = true;
            next_btn.Click += next_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(next_btn);
            Controls.Add(program_txtbox);
            Controls.Add(contactno_txtbox);
            Controls.Add(contactno);
            Controls.Add(address_txtbox);
            Controls.Add(age_txtbox);
            Controls.Add(middlename_txtbox);
            Controls.Add(firstname_txtbox);
            Controls.Add(lastname_txtbox);
            Controls.Add(middlename);
            Controls.Add(program);
            Controls.Add(age);
            Controls.Add(address);
            Controls.Add(Lastname);
            Controls.Add(firstname);
            Controls.Add(studentno_txtbox);
            Controls.Add(studentno);
            Name = "Form1";
            Text = "FrmRegistration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label studentno;
        private TextBox studentno_txtbox;
        private Label firstname;
        private Label Lastname;
        private Label address;
        private Label age;
        private Label program;
        private Label middlename;
        private TextBox lastname_txtbox;
        private TextBox firstname_txtbox;
        private TextBox middlename_txtbox;
        private TextBox age_txtbox;
        private TextBox address_txtbox;
        private TextBox contactno_txtbox;
        private Label contactno;
        private TextBox program_txtbox;
        private Button next_btn;
    }
}
