namespace _3D_Vector
{
    partial class Form3DVector
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.labelV1 = new System.Windows.Forms.Label();
            this.labelV2 = new System.Windows.Forms.Label();
            this.labelMsg1 = new System.Windows.Forms.Label();
            this.VecU1 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.RadioButton();
            this.BtnDot = new System.Windows.Forms.RadioButton();
            this.BtnSub = new System.Windows.Forms.RadioButton();
            this.BtnCross = new System.Windows.Forms.RadioButton();
            this.VecU2 = new System.Windows.Forms.TextBox();
            this.VecU3 = new System.Windows.Forms.TextBox();
            this.VecV1 = new System.Windows.Forms.TextBox();
            this.VecV2 = new System.Windows.Forms.TextBox();
            this.VecV3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(202)))), ((int)(((byte)(180)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(762, 76);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(320, 19);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "3D VECTOR";
            // 
            // labelV1
            // 
            this.labelV1.AutoSize = true;
            this.labelV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV1.Location = new System.Drawing.Point(170, 138);
            this.labelV1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelV1.Name = "labelV1";
            this.labelV1.Size = new System.Drawing.Size(105, 26);
            this.labelV1.TabIndex = 2;
            this.labelV1.Text = "Vector U";
            // 
            // labelV2
            // 
            this.labelV2.AutoSize = true;
            this.labelV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV2.Location = new System.Drawing.Point(499, 138);
            this.labelV2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelV2.Name = "labelV2";
            this.labelV2.Size = new System.Drawing.Size(104, 26);
            this.labelV2.TabIndex = 3;
            this.labelV2.Text = "Vector V";
            // 
            // labelMsg1
            // 
            this.labelMsg1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMsg1.AutoSize = true;
            this.labelMsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg1.Location = new System.Drawing.Point(142, 98);
            this.labelMsg1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMsg1.Name = "labelMsg1";
            this.labelMsg1.Size = new System.Drawing.Size(553, 17);
            this.labelMsg1.TabIndex = 4;
            this.labelMsg1.Text = "Please Insert The Input According to i, j, k Coordinates Respectively. (Example: " +
    "1, 2, 3)";
            // 
            // VecU1
            // 
            this.VecU1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VecU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VecU1.Location = new System.Drawing.Point(137, 166);
            this.VecU1.Margin = new System.Windows.Forms.Padding(2);
            this.VecU1.Name = "VecU1";
            this.VecU1.Size = new System.Drawing.Size(41, 26);
            this.VecU1.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.Window;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(337, 409);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 22);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "ANSWER";
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(337, 233);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(77, 21);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.TabStop = true;
            this.BtnAdd.Text = "Addition";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.CheckedChanged += new System.EventHandler(this.BtnAdd_CheckedChanged);
            // 
            // BtnDot
            // 
            this.BtnDot.AutoSize = true;
            this.BtnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.Location = new System.Drawing.Point(337, 301);
            this.BtnDot.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(101, 21);
            this.BtnDot.TabIndex = 15;
            this.BtnDot.TabStop = true;
            this.BtnDot.Text = "Dot Product";
            this.BtnDot.UseVisualStyleBackColor = true;
            this.BtnDot.CheckedChanged += new System.EventHandler(this.BtnDot_CheckedChanged);
            // 
            // BtnSub
            // 
            this.BtnSub.AutoSize = true;
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(337, 267);
            this.BtnSub.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(98, 21);
            this.BtnSub.TabIndex = 16;
            this.BtnSub.TabStop = true;
            this.BtnSub.Text = "Subtraction";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.CheckedChanged += new System.EventHandler(this.BtnSub_CheckedChanged);
            // 
            // BtnCross
            // 
            this.BtnCross.AutoSize = true;
            this.BtnCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCross.Location = new System.Drawing.Point(337, 338);
            this.BtnCross.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCross.Name = "BtnCross";
            this.BtnCross.Size = new System.Drawing.Size(115, 21);
            this.BtnCross.TabIndex = 17;
            this.BtnCross.TabStop = true;
            this.BtnCross.Text = "Cross Product";
            this.BtnCross.UseVisualStyleBackColor = true;
            this.BtnCross.CheckedChanged += new System.EventHandler(this.BtnCross_CheckedChanged);
            // 
            // VecU2
            // 
            this.VecU2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VecU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VecU2.Location = new System.Drawing.Point(198, 166);
            this.VecU2.Margin = new System.Windows.Forms.Padding(2);
            this.VecU2.Name = "VecU2";
            this.VecU2.Size = new System.Drawing.Size(41, 26);
            this.VecU2.TabIndex = 19;
            // 
            // VecU3
            // 
            this.VecU3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VecU3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VecU3.Location = new System.Drawing.Point(262, 166);
            this.VecU3.Margin = new System.Windows.Forms.Padding(2);
            this.VecU3.Name = "VecU3";
            this.VecU3.Size = new System.Drawing.Size(41, 26);
            this.VecU3.TabIndex = 20;
            // 
            // VecV1
            // 
            this.VecV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VecV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VecV1.Location = new System.Drawing.Point(463, 166);
            this.VecV1.Margin = new System.Windows.Forms.Padding(2);
            this.VecV1.Name = "VecV1";
            this.VecV1.Size = new System.Drawing.Size(41, 26);
            this.VecV1.TabIndex = 21;
            // 
            // VecV2
            // 
            this.VecV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VecV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VecV2.Location = new System.Drawing.Point(524, 166);
            this.VecV2.Margin = new System.Windows.Forms.Padding(2);
            this.VecV2.Name = "VecV2";
            this.VecV2.Size = new System.Drawing.Size(41, 26);
            this.VecV2.TabIndex = 22;
            // 
            // VecV3
            // 
            this.VecV3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VecV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VecV3.Location = new System.Drawing.Point(585, 166);
            this.VecV3.Margin = new System.Windows.Forms.Padding(2);
            this.VecV3.Name = "VecV3";
            this.VecV3.Size = new System.Drawing.Size(41, 26);
            this.VecV3.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "i";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "j";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "k";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "i";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "j";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "k";
            // 
            // Form3DVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 518);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VecV3);
            this.Controls.Add(this.VecV2);
            this.Controls.Add(this.VecV1);
            this.Controls.Add(this.VecU3);
            this.Controls.Add(this.VecU2);
            this.Controls.Add(this.BtnCross);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.VecU1);
            this.Controls.Add(this.labelMsg1);
            this.Controls.Add(this.labelV2);
            this.Controls.Add(this.labelV1);
            this.Controls.Add(this.panelTitleBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3DVector";
            this.Text = "3D Vector Calculator";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label labelV1;
        private System.Windows.Forms.Label labelV2;
        private System.Windows.Forms.Label labelMsg1;
        private System.Windows.Forms.TextBox VecU1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RadioButton BtnAdd;
        private System.Windows.Forms.RadioButton BtnDot;
        private System.Windows.Forms.RadioButton BtnSub;
        private System.Windows.Forms.RadioButton BtnCross;
        private System.Windows.Forms.TextBox VecU2;
        private System.Windows.Forms.TextBox VecU3;
        private System.Windows.Forms.TextBox VecV1;
        private System.Windows.Forms.TextBox VecV2;
        private System.Windows.Forms.TextBox VecV3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

