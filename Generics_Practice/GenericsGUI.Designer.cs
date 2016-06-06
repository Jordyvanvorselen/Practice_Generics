namespace Generics_Practice
{
    partial class GenericsGUI
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnTestStrings = new System.Windows.Forms.Button();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTestDecimals = new System.Windows.Forms.Button();
            this.nudDecimal1 = new System.Windows.Forms.NumericUpDown();
            this.nudDecimal2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(95, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 25);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Equality Checker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Result:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(170, 224);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btnTestStrings
            // 
            this.btnTestStrings.Location = new System.Drawing.Point(39, 93);
            this.btnTestStrings.Name = "btnTestStrings";
            this.btnTestStrings.Size = new System.Drawing.Size(66, 43);
            this.btnTestStrings.TabIndex = 4;
            this.btnTestStrings.Text = "Test equality";
            this.btnTestStrings.UseVisualStyleBackColor = true;
            this.btnTestStrings.Click += new System.EventHandler(this.btnTestEquality_Click);
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(20, 67);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(100, 20);
            this.txtString2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(20, 41);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(100, 20);
            this.txtString1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtString1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtString2);
            this.groupBox1.Controls.Add(this.btnTestStrings);
            this.groupBox1.Location = new System.Drawing.Point(21, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 148);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compare Strings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudDecimal2);
            this.groupBox2.Controls.Add(this.nudDecimal1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnTestDecimals);
            this.groupBox2.Location = new System.Drawing.Point(202, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(142, 148);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compare Decimals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // btnTestDecimals
            // 
            this.btnTestDecimals.Location = new System.Drawing.Point(39, 93);
            this.btnTestDecimals.Name = "btnTestDecimals";
            this.btnTestDecimals.Size = new System.Drawing.Size(66, 43);
            this.btnTestDecimals.TabIndex = 4;
            this.btnTestDecimals.Text = "Test equality";
            this.btnTestDecimals.UseVisualStyleBackColor = true;
            this.btnTestDecimals.Click += new System.EventHandler(this.btnTestInts_Click);
            // 
            // nudDecimal1
            // 
            this.nudDecimal1.Location = new System.Drawing.Point(20, 41);
            this.nudDecimal1.Name = "nudDecimal1";
            this.nudDecimal1.Size = new System.Drawing.Size(103, 20);
            this.nudDecimal1.TabIndex = 7;
            // 
            // nudDecimal2
            // 
            this.nudDecimal2.Location = new System.Drawing.Point(20, 68);
            this.nudDecimal2.Name = "nudDecimal2";
            this.nudDecimal2.Size = new System.Drawing.Size(103, 20);
            this.nudDecimal2.TabIndex = 8;
            // 
            // GenericsGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 276);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Name = "GenericsGUI";
            this.Text = "Equality Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnTestStrings;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTestDecimals;
        private System.Windows.Forms.NumericUpDown nudDecimal2;
        private System.Windows.Forms.NumericUpDown nudDecimal1;
    }
}

