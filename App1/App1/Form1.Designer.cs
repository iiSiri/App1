﻿namespace App1
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxDesc = new System.Windows.Forms.RichTextBox();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxImplementor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Action:";
            // 
            // comboBoxAction
            // 
            this.comboBoxAction.FormattingEnabled = true;
            this.comboBoxAction.Items.AddRange(new object[] {
            "Started",
            "Added",
            "Fixed",
            "Changed",
            "Removed",
            "Known Issue",
            "Installed",
            "Go Live",
            "Bug"});
            this.comboBoxAction.Location = new System.Drawing.Point(133, 37);
            this.comboBoxAction.Name = "comboBoxAction";
            this.comboBoxAction.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAction.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the Description:";
            // 
            // richTextBoxDesc
            // 
            this.richTextBoxDesc.Location = new System.Drawing.Point(133, 123);
            this.richTextBoxDesc.Name = "richTextBoxDesc";
            this.richTextBoxDesc.Size = new System.Drawing.Size(283, 96);
            this.richTextBoxDesc.TabIndex = 3;
            this.richTextBoxDesc.Text = "Enter the Text..";
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(133, 245);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(240, 23);
            this.btn_Show.TabIndex = 4;
            this.btn_Show.Text = "Show Result Now !";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Change done by:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxImplementor
            // 
            this.textBoxImplementor.Location = new System.Drawing.Point(133, 78);
            this.textBoxImplementor.Name = "textBoxImplementor";
            this.textBoxImplementor.Size = new System.Drawing.Size(121, 20);
            this.textBoxImplementor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 321);
            this.Controls.Add(this.textBoxImplementor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.richTextBoxDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAction);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxDesc;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxImplementor;
    }
}

