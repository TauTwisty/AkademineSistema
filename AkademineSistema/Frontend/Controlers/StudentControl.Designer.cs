
namespace AkademineSistema.Frontend.Controlers
{
    partial class StudentControl
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
            this.studentGradePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentGradePanel
            // 
            this.studentGradePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.studentGradePanel.Location = new System.Drawing.Point(25, 21);
            this.studentGradePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.studentGradePanel.Name = "studentGradePanel";
            this.studentGradePanel.Size = new System.Drawing.Size(1127, 561);
            this.studentGradePanel.TabIndex = 0;
            this.studentGradePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.stundetGradePanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "x - jeigu nėra jokio pažymio";
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.studentGradePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentControl";
            this.Size = new System.Drawing.Size(1164, 600);
            this.Load += new System.EventHandler(this.StudentControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel studentGradePanel;
        private System.Windows.Forms.Label label2;
    }
}
