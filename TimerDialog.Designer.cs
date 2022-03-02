﻿
namespace TimeJournal
{
    partial class TimerDialog
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProjectNumber = new System.Windows.Forms.ComboBox();
            this.cboProjectName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddJournalEntry = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(471, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 13;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStartStop.ForeColor = System.Drawing.Color.Red;
            this.btnStartStop.Location = new System.Drawing.Point(123, 78);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(357, 132);
            this.btnStartStop.TabIndex = 3;
            this.btnStartStop.Text = "btnStartStop";
            this.btnStartStop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(349, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(349, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(43, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Elapsed Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(349, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(43, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time until next journal entry:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(349, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(43, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 28);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // cboProjectNumber
            // 
            this.cboProjectNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboProjectNumber.FormattingEnabled = true;
            this.cboProjectNumber.Location = new System.Drawing.Point(23, 20);
            this.cboProjectNumber.Name = "cboProjectNumber";
            this.cboProjectNumber.Size = new System.Drawing.Size(163, 36);
            this.cboProjectNumber.TabIndex = 11;
            // 
            // cboProjectName
            // 
            this.cboProjectName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboProjectName.FormattingEnabled = true;
            this.cboProjectName.Location = new System.Drawing.Point(201, 20);
            this.cboProjectName.Name = "cboProjectName";
            this.cboProjectName.Size = new System.Drawing.Size(419, 36);
            this.cboProjectName.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(43, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 28);
            this.label9.TabIndex = 14;
            this.label9.Text = "Start Time:";
            // 
            // btnAddJournalEntry
            // 
            this.btnAddJournalEntry.Location = new System.Drawing.Point(471, 457);
            this.btnAddJournalEntry.Name = "btnAddJournalEntry";
            this.btnAddJournalEntry.Size = new System.Drawing.Size(149, 42);
            this.btnAddJournalEntry.TabIndex = 15;
            this.btnAddJournalEntry.Text = "Add Journal Entry...";
            this.btnAddJournalEntry.UseVisualStyleBackColor = true;
            // 
            // TimerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 598);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddJournalEntry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboProjectName);
            this.Controls.Add(this.cboProjectNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TimerDialog";
            this.Text = "Work Timer";
            this.Load += new System.EventHandler(this.TimerDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProjectNumber;
        private System.Windows.Forms.ComboBox cboProjectName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddJournalEntry;
    }
}

