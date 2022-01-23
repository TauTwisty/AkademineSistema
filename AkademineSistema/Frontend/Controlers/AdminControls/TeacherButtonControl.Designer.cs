
namespace AkademineSistema.Frontend.Controlers.AdminControls
{
    partial class TeacherButtonControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teachersCheckList = new System.Windows.Forms.CheckedListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teacherNameTextBox = new System.Windows.Forms.TextBox();
            this.teacherSurnameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subjectList = new System.Windows.Forms.CheckedListBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.addSubjectButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.removeSubject = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dėstytojai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registracija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(836, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dėstytojų sąrašas";
            // 
            // teachersCheckList
            // 
            this.teachersCheckList.FormattingEnabled = true;
            this.teachersCheckList.Location = new System.Drawing.Point(840, 183);
            this.teachersCheckList.Name = "teachersCheckList";
            this.teachersCheckList.Size = new System.Drawing.Size(251, 395);
            this.teachersCheckList.TabIndex = 4;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(914, 584);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(111, 30);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Pašalinti";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vardas: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pavardė:";
            // 
            // teacherNameTextBox
            // 
            this.teacherNameTextBox.Location = new System.Drawing.Point(437, 181);
            this.teacherNameTextBox.Name = "teacherNameTextBox";
            this.teacherNameTextBox.Size = new System.Drawing.Size(213, 22);
            this.teacherNameTextBox.TabIndex = 9;
            // 
            // teacherSurnameTextBox
            // 
            this.teacherSurnameTextBox.Location = new System.Drawing.Point(437, 226);
            this.teacherSurnameTextBox.Name = "teacherSurnameTextBox";
            this.teacherSurnameTextBox.Size = new System.Drawing.Size(213, 22);
            this.teacherSurnameTextBox.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(476, 584);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 30);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Pridėti";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subjectList
            // 
            this.subjectList.FormattingEnabled = true;
            this.subjectList.Location = new System.Drawing.Point(437, 329);
            this.subjectList.Name = "subjectList";
            this.subjectList.Size = new System.Drawing.Size(213, 242);
            this.subjectList.TabIndex = 13;
            this.subjectList.SelectedIndexChanged += new System.EventHandler(this.subjectList_SelectedIndexChanged);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(437, 271);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(213, 22);
            this.subjectTextBox.TabIndex = 15;
            // 
            // addSubjectButton
            // 
            this.addSubjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubjectButton.Location = new System.Drawing.Point(656, 271);
            this.addSubjectButton.Name = "addSubjectButton";
            this.addSubjectButton.Size = new System.Drawing.Size(41, 30);
            this.addSubjectButton.TabIndex = 16;
            this.addSubjectButton.Text = "+";
            this.addSubjectButton.UseVisualStyleBackColor = true;
            this.addSubjectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Dėstomas dalykas:";
            // 
            // removeSubject
            // 
            this.removeSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSubject.Location = new System.Drawing.Point(656, 329);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(41, 30);
            this.removeSubject.TabIndex = 18;
            this.removeSubject.Text = "-";
            this.removeSubject.UseVisualStyleBackColor = true;
            this.removeSubject.Click += new System.EventHandler(this.removeSubject_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 685);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "(+) - Prideda naują dėstomą dalyką į sąrašą";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 706);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "(-) - Pašalina dėstomą dalyką iš sąrašo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 655);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Instrukcija";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(434, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Dėstomi dalykai";
            // 
            // TeacherButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.removeSubject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addSubjectButton);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.subjectList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.teacherSurnameTextBox);
            this.Controls.Add(this.teacherNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.teachersCheckList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TeacherButtonControl";
            this.Size = new System.Drawing.Size(1552, 739);
            this.Load += new System.EventHandler(this.TeacherButtonControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox teachersCheckList;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teacherNameTextBox;
        private System.Windows.Forms.TextBox teacherSurnameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox subjectList;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Button addSubjectButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button removeSubject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}
