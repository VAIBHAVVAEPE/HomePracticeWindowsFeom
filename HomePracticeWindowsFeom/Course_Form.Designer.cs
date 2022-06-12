namespace HomePracticeWindowsFeom
{
    partial class Course_Form
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.labFees = new System.Windows.Forms.Label();
            this.btnColour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(500, 77);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(500, 134);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(306, 78);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(306, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(306, 199);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(100, 22);
            this.txtFees.TabIndex = 1;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(152, 80);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(76, 16);
            this.labID.TabIndex = 2;
            this.labID.Text = "Course_ID :";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(152, 134);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(94, 16);
            this.labName.TabIndex = 2;
            this.labName.Text = "Course_Name";
            // 
            // labFees
            // 
            this.labFees.AutoSize = true;
            this.labFees.Location = new System.Drawing.Point(152, 205);
            this.labFees.Name = "labFees";
            this.labFees.Size = new System.Drawing.Size(88, 16);
            this.labFees.TabIndex = 2;
            this.labFees.Text = "Course_Fees";
            // 
            // btnColour
            // 
            this.btnColour.Location = new System.Drawing.Point(505, 200);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(69, 37);
            this.btnColour.TabIndex = 3;
            this.btnColour.Text = "Clear";
            this.btnColour.UseVisualStyleBackColor = true;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // Course_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 249);
            this.Controls.Add(this.btnColour);
            this.Controls.Add(this.labFees);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Name = "Course_Form";
            this.Text = "Course_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labFees;
        private System.Windows.Forms.Button btnColour;
    }
}