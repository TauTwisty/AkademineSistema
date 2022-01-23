
namespace AkademineSistema.Frontend
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabelShow = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.teachersButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(15, 74);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1552, 722);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prisijungėte, kaip: ";
            // 
            // nameLabelShow
            // 
            this.nameLabelShow.AutoSize = true;
            this.nameLabelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabelShow.Location = new System.Drawing.Point(221, 34);
            this.nameLabelShow.Name = "nameLabelShow";
            this.nameLabelShow.Size = new System.Drawing.Size(107, 25);
            this.nameLabelShow.TabIndex = 2;
            this.nameLabelShow.Text = "<Vardas>";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(1479, 8);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(88, 28);
            this.disconnectButton.TabIndex = 3;
            this.disconnectButton.Text = "Atsijungti";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.SystemColors.Control;
            this.studentButton.Location = new System.Drawing.Point(13, 8);
            this.studentButton.Name = "studentButton";
            this.studentButton.Size = new System.Drawing.Size(138, 24);
            this.studentButton.TabIndex = 4;
            this.studentButton.Text = "Studentai";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // teachersButton
            // 
            this.teachersButton.Location = new System.Drawing.Point(157, 8);
            this.teachersButton.Name = "teachersButton";
            this.teachersButton.Size = new System.Drawing.Size(138, 24);
            this.teachersButton.TabIndex = 5;
            this.teachersButton.Text = "Dėstytojai";
            this.teachersButton.UseVisualStyleBackColor = true;
            this.teachersButton.Click += new System.EventHandler(this.teachersButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.Location = new System.Drawing.Point(301, 8);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(138, 24);
            this.groupsButton.TabIndex = 6;
            this.groupsButton.Text = "Grupės";
            this.groupsButton.UseVisualStyleBackColor = true;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 805);
            this.Controls.Add(this.groupsButton);
            this.Controls.Add(this.teachersButton);
            this.Controls.Add(this.studentButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.nameLabelShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Main";
            this.Text = "LoggedIn";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabelShow;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button studentButton;
        private System.Windows.Forms.Button teachersButton;
        private System.Windows.Forms.Button groupsButton;
    }
}