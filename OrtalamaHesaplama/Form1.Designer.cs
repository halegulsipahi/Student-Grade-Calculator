namespace AverageCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGradeOne = new System.Windows.Forms.Label();
            this.lblGradeTwo = new System.Windows.Forms.Label();
            this.txtGradeOne = new System.Windows.Forms.TextBox();
            this.txtGradeTwo = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGradeOne
            // 
            this.lblGradeOne.AutoSize = true;
            this.lblGradeOne.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGradeOne.Location = new System.Drawing.Point(4, 29);
            this.lblGradeOne.Name = "lblGradeOne";
            this.lblGradeOne.Size = new System.Drawing.Size(72, 23);
            this.lblGradeOne.TabIndex = 0;
            this.lblGradeOne.Text = "Grade 1:";
            // 
            // lblGradeTwo
            // 
            this.lblGradeTwo.AutoSize = true;
            this.lblGradeTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGradeTwo.Location = new System.Drawing.Point(4, 60);
            this.lblGradeTwo.Name = "lblGradeTwo";
            this.lblGradeTwo.Size = new System.Drawing.Size(74, 23);
            this.lblGradeTwo.TabIndex = 1;
            this.lblGradeTwo.Text = "Grade 2:";
            // 
            // txtGradeOne
            // 
            this.txtGradeOne.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeOne.Location = new System.Drawing.Point(84, 25);
            this.txtGradeOne.MaxLength = 3;
            this.txtGradeOne.Name = "txtGradeOne";
            this.txtGradeOne.Size = new System.Drawing.Size(185, 30);
            this.txtGradeOne.TabIndex = 2;
            this.txtGradeOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGradeOne.TextChanged += new System.EventHandler(this.txtGradeOne_TextChanged);
            this.txtGradeOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeOne_KeyPress);
            // 
            // txtGradeTwo
            // 
            this.txtGradeTwo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGradeTwo.Location = new System.Drawing.Point(84, 56);
            this.txtGradeTwo.MaxLength = 3;
            this.txtGradeTwo.Name = "txtGradeTwo";
            this.txtGradeTwo.Size = new System.Drawing.Size(185, 30);
            this.txtGradeTwo.TabIndex = 3;
            this.txtGradeTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGradeTwo.TextChanged += new System.EventHandler(this.txtGradeTwo_TextChanged);
            this.txtGradeTwo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeTwo_KeyPress);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Location = new System.Drawing.Point(84, 92);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(185, 32);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAverage.ForeColor = System.Drawing.Color.White;
            this.lblAverage.Location = new System.Drawing.Point(120, 131);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Padding = new System.Windows.Forms.Padding(4, 3, 6, 6);
            this.lblAverage.Size = new System.Drawing.Size(10, 32);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.Location = new System.Drawing.Point(122, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 23);
            this.lblStatus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(302, 206);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtGradeTwo);
            this.Controls.Add(this.txtGradeOne);
            this.Controls.Add(this.lblGradeTwo);
            this.Controls.Add(this.lblGradeOne);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGradeOne;
        private System.Windows.Forms.Label lblGradeTwo;
        private System.Windows.Forms.TextBox txtGradeOne;
        private System.Windows.Forms.TextBox txtGradeTwo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblStatus;
    }
}

