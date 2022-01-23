
namespace AkademineSistema.Frontend.Controlers.AdminControls
{
    partial class GroupButtonControl
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
            this.removeButton = new System.Windows.Forms.Button();
            this.groupTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addGroupButton = new System.Windows.Forms.Button();
            this.groupCheckBoxList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupės";
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(675, 485);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(103, 31);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Pašalinti";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // groupTextBox
            // 
            this.groupTextBox.Location = new System.Drawing.Point(626, 117);
            this.groupTextBox.Name = "groupTextBox";
            this.groupTextBox.Size = new System.Drawing.Size(207, 22);
            this.groupTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupės pavadinimas:";
            // 
            // addGroupButton
            // 
            this.addGroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupButton.Location = new System.Drawing.Point(675, 145);
            this.addGroupButton.Name = "addGroupButton";
            this.addGroupButton.Size = new System.Drawing.Size(102, 26);
            this.addGroupButton.TabIndex = 6;
            this.addGroupButton.Text = "Pridėti";
            this.addGroupButton.UseVisualStyleBackColor = true;
            this.addGroupButton.Click += new System.EventHandler(this.addGroupButton_Click);
            // 
            // groupCheckBoxList
            // 
            this.groupCheckBoxList.FormattingEnabled = true;
            this.groupCheckBoxList.Location = new System.Drawing.Point(625, 188);
            this.groupCheckBoxList.Name = "groupCheckBoxList";
            this.groupCheckBoxList.Size = new System.Drawing.Size(207, 276);
            this.groupCheckBoxList.TabIndex = 7;
            this.groupCheckBoxList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // GroupButtonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupCheckBoxList);
            this.Controls.Add(this.addGroupButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupTextBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label1);
            this.Name = "GroupButtonControl";
            this.Size = new System.Drawing.Size(1552, 739);
            this.Load += new System.EventHandler(this.GroupButtonControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox groupTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addGroupButton;
        private System.Windows.Forms.CheckedListBox groupCheckBoxList;
    }
}
