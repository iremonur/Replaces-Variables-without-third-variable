namespace ReplaceVariables
{
    partial class Form1
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
            this.lblVariableFirst = new System.Windows.Forms.Label();
            this.lblVariableScnd = new System.Windows.Forms.Label();
            this.txtFirstVariable = new System.Windows.Forms.TextBox();
            this.txtSecondVariable = new System.Windows.Forms.TextBox();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.lblScndValue = new System.Windows.Forms.Label();
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVariableFirst
            // 
            this.lblVariableFirst.AutoSize = true;
            this.lblVariableFirst.Location = new System.Drawing.Point(13, 35);
            this.lblVariableFirst.Name = "lblVariableFirst";
            this.lblVariableFirst.Size = new System.Drawing.Size(153, 13);
            this.lblVariableFirst.TabIndex = 0;
            this.lblVariableFirst.Text = "Give a number as frst variable :";
            // 
            // lblVariableScnd
            // 
            this.lblVariableScnd.AutoSize = true;
            this.lblVariableScnd.Location = new System.Drawing.Point(13, 58);
            this.lblVariableScnd.Name = "lblVariableScnd";
            this.lblVariableScnd.Size = new System.Drawing.Size(174, 13);
            this.lblVariableScnd.TabIndex = 1;
            this.lblVariableScnd.Text = "Give a number as second variable :";
            // 
            // txtFirstVariable
            // 
            this.txtFirstVariable.Location = new System.Drawing.Point(211, 32);
            this.txtFirstVariable.Name = "txtFirstVariable";
            this.txtFirstVariable.Size = new System.Drawing.Size(100, 20);
            this.txtFirstVariable.TabIndex = 2;
            // 
            // txtSecondVariable
            // 
            this.txtSecondVariable.Location = new System.Drawing.Point(211, 58);
            this.txtSecondVariable.Name = "txtSecondVariable";
            this.txtSecondVariable.Size = new System.Drawing.Size(100, 20);
            this.txtSecondVariable.TabIndex = 3;
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Location = new System.Drawing.Point(13, 102);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(150, 13);
            this.lblFirstValue.TabIndex = 4;
            this.lblFirstValue.Text = "The value of the first variable :";
            // 
            // lblScndValue
            // 
            this.lblScndValue.AutoSize = true;
            this.lblScndValue.Location = new System.Drawing.Point(13, 122);
            this.lblScndValue.Name = "lblScndValue";
            this.lblScndValue.Size = new System.Drawing.Size(169, 13);
            this.lblScndValue.TabIndex = 5;
            this.lblScndValue.Text = "The value of the second variable :";
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(211, 94);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(100, 20);
            this.txtFirstValue.TabIndex = 6;
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(211, 119);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(100, 20);
            this.txtSecondValue.TabIndex = 7;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(381, 54);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Show result!";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 168);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtSecondValue);
            this.Controls.Add(this.txtFirstValue);
            this.Controls.Add(this.lblScndValue);
            this.Controls.Add(this.lblFirstValue);
            this.Controls.Add(this.txtSecondVariable);
            this.Controls.Add(this.txtFirstVariable);
            this.Controls.Add(this.lblVariableScnd);
            this.Controls.Add(this.lblVariableFirst);
            this.Name = "Form1";
            this.Text = "Replace Variables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariableFirst;
        private System.Windows.Forms.Label lblVariableScnd;
        private System.Windows.Forms.TextBox txtFirstVariable;
        private System.Windows.Forms.TextBox txtSecondVariable;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Label lblScndValue;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.Button btnResult;
    }
}

