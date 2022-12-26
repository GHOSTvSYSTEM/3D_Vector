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
            this.Ui = new System.Windows.Forms.TextBox();
            this.labelMsg2 = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.Uj = new System.Windows.Forms.TextBox();
            this.Uk = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.RadioButton();
            this.BtnDot = new System.Windows.Forms.RadioButton();
            this.BtnSub = new System.Windows.Forms.RadioButton();
            this.BtnCross = new System.Windows.Forms.RadioButton();
            this.labelUi = new System.Windows.Forms.Label();
            this.labelUj = new System.Windows.Forms.Label();
            this.labelUk = new System.Windows.Forms.Label();
            this.labelVk = new System.Windows.Forms.Label();
            this.labelVj = new System.Windows.Forms.Label();
            this.labelVi = new System.Windows.Forms.Label();
            this.Vk = new System.Windows.Forms.TextBox();
            this.Vj = new System.Windows.Forms.TextBox();
            this.Vi = new System.Windows.Forms.TextBox();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(202)))), ((int)(((byte)(180)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1016, 94);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(426, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "3D VECTOR";
            // 
            // labelV1
            // 
            this.labelV1.AutoSize = true;
            this.labelV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV1.Location = new System.Drawing.Point(226, 170);
            this.labelV1.Name = "labelV1";
            this.labelV1.Size = new System.Drawing.Size(131, 32);
            this.labelV1.TabIndex = 2;
            this.labelV1.Text = "Vector U";
            // 
            // labelV2
            // 
            this.labelV2.AutoSize = true;
            this.labelV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelV2.Location = new System.Drawing.Point(665, 170);
            this.labelV2.Name = "labelV2";
            this.labelV2.Size = new System.Drawing.Size(130, 32);
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
            this.labelMsg1.Location = new System.Drawing.Point(190, 121);
            this.labelMsg1.Name = "labelMsg1";
            this.labelMsg1.Size = new System.Drawing.Size(654, 20);
            this.labelMsg1.TabIndex = 4;
            this.labelMsg1.Text = "Please Insert The Input According to i, j, k Coordinates Respectively. (Example: " +
    "1, 2, 3)";
            // 
            // Ui
            // 
            this.Ui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ui.Location = new System.Drawing.Point(137, 205);
            this.Ui.Name = "Ui";
            this.Ui.Size = new System.Drawing.Size(78, 30);
            this.Ui.TabIndex = 5;
            this.Ui.TextChanged += new System.EventHandler(this.Ui_TextChanged);
            // 
            // labelMsg2
            // 
            this.labelMsg2.AutoSize = true;
            this.labelMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg2.Location = new System.Drawing.Point(147, 268);
            this.labelMsg2.Name = "labelMsg2";
            this.labelMsg2.Size = new System.Drawing.Size(82, 20);
            this.labelMsg2.TabIndex = 7;
            this.labelMsg2.Text = "Message:";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.BackColor = System.Drawing.SystemColors.Window;
            this.labelAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnswer.Location = new System.Drawing.Point(449, 503);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(102, 27);
            this.labelAnswer.TabIndex = 8;
            this.labelAnswer.Text = "ANSWER";
            // 
            // Uj
            // 
            this.Uj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uj.Location = new System.Drawing.Point(247, 205);
            this.Uj.Name = "Uj";
            this.Uj.Size = new System.Drawing.Size(78, 30);
            this.Uj.TabIndex = 9;
            // 
            // Uk
            // 
            this.Uk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Uk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uk.Location = new System.Drawing.Point(357, 205);
            this.Uk.Name = "Uk";
            this.Uk.Size = new System.Drawing.Size(78, 30);
            this.Uk.TabIndex = 10;
            // 
            // BtnAdd
            // 
            this.BtnAdd.AutoSize = true;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(449, 287);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 24);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.TabStop = true;
            this.BtnAdd.Text = "Addition";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnDot
            // 
            this.BtnDot.AutoSize = true;
            this.BtnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDot.Location = new System.Drawing.Point(449, 371);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(120, 24);
            this.BtnDot.TabIndex = 15;
            this.BtnDot.TabStop = true;
            this.BtnDot.Text = "Dot Product";
            this.BtnDot.UseVisualStyleBackColor = true;
            // 
            // BtnSub
            // 
            this.BtnSub.AutoSize = true;
            this.BtnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSub.Location = new System.Drawing.Point(449, 332);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(115, 24);
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
            this.BtnCross.Location = new System.Drawing.Point(449, 416);
            this.BtnCross.Name = "BtnCross";
            this.BtnCross.Size = new System.Drawing.Size(138, 24);
            this.BtnCross.TabIndex = 17;
            this.BtnCross.TabStop = true;
            this.BtnCross.Text = "Cross Product";
            this.BtnCross.UseVisualStyleBackColor = true;
            // 
            // labelUi
            // 
            this.labelUi.AutoSize = true;
            this.labelUi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUi.Location = new System.Drawing.Point(223, 208);
            this.labelUi.Name = "labelUi";
            this.labelUi.Size = new System.Drawing.Size(16, 25);
            this.labelUi.TabIndex = 18;
            this.labelUi.Text = "i";
            // 
            // labelUj
            // 
            this.labelUj.AutoSize = true;
            this.labelUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUj.Location = new System.Drawing.Point(333, 206);
            this.labelUj.Name = "labelUj";
            this.labelUj.Size = new System.Drawing.Size(16, 25);
            this.labelUj.TabIndex = 19;
            this.labelUj.Text = "j";
            // 
            // labelUk
            // 
            this.labelUk.AutoSize = true;
            this.labelUk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUk.Location = new System.Drawing.Point(443, 207);
            this.labelUk.Name = "labelUk";
            this.labelUk.Size = new System.Drawing.Size(22, 25);
            this.labelUk.TabIndex = 20;
            this.labelUk.Text = "k";
            // 
            // labelVk
            // 
            this.labelVk.AutoSize = true;
            this.labelVk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVk.Location = new System.Drawing.Point(882, 207);
            this.labelVk.Name = "labelVk";
            this.labelVk.Size = new System.Drawing.Size(22, 25);
            this.labelVk.TabIndex = 26;
            this.labelVk.Text = "k";
            // 
            // labelVj
            // 
            this.labelVj.AutoSize = true;
            this.labelVj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVj.Location = new System.Drawing.Point(772, 206);
            this.labelVj.Name = "labelVj";
            this.labelVj.Size = new System.Drawing.Size(16, 25);
            this.labelVj.TabIndex = 25;
            this.labelVj.Text = "j";
            // 
            // labelVi
            // 
            this.labelVi.AutoSize = true;
            this.labelVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVi.Location = new System.Drawing.Point(662, 208);
            this.labelVi.Name = "labelVi";
            this.labelVi.Size = new System.Drawing.Size(16, 25);
            this.labelVi.TabIndex = 24;
            this.labelVi.Text = "i";
            // 
            // Vk
            // 
            this.Vk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vk.Location = new System.Drawing.Point(796, 205);
            this.Vk.Name = "Vk";
            this.Vk.Size = new System.Drawing.Size(78, 30);
            this.Vk.TabIndex = 23;
            // 
            // Vj
            // 
            this.Vj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vj.Location = new System.Drawing.Point(686, 205);
            this.Vj.Name = "Vj";
            this.Vj.Size = new System.Drawing.Size(78, 30);
            this.Vj.TabIndex = 22;
            // 
            // Vi
            // 
            this.Vi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Vi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vi.Location = new System.Drawing.Point(576, 205);
            this.Vi.Name = "Vi";
            this.Vi.Size = new System.Drawing.Size(78, 30);
            this.Vi.TabIndex = 21;
            // 
            // Form3DVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 638);
            this.Controls.Add(this.labelVk);
            this.Controls.Add(this.labelVj);
            this.Controls.Add(this.labelVi);
            this.Controls.Add(this.Vk);
            this.Controls.Add(this.Vj);
            this.Controls.Add(this.Vi);
            this.Controls.Add(this.labelUk);
            this.Controls.Add(this.labelUj);
            this.Controls.Add(this.labelUi);
            this.Controls.Add(this.BtnCross);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Uk);
            this.Controls.Add(this.Uj);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelMsg2);
            this.Controls.Add(this.Ui);
            this.Controls.Add(this.labelMsg1);
            this.Controls.Add(this.labelV2);
            this.Controls.Add(this.labelV1);
            this.Controls.Add(this.panelTitleBar);
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
        private System.Windows.Forms.TextBox Ui;
        private System.Windows.Forms.Label labelMsg2;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.TextBox Uj;
        private System.Windows.Forms.TextBox Uk;
        private System.Windows.Forms.RadioButton BtnAdd;
        private System.Windows.Forms.RadioButton BtnDot;
        private System.Windows.Forms.RadioButton BtnSub;
        private System.Windows.Forms.RadioButton BtnCross;
        private System.Windows.Forms.Label labelUi;
        private System.Windows.Forms.Label labelUj;
        private System.Windows.Forms.Label labelUk;
        private System.Windows.Forms.Label labelVk;
        private System.Windows.Forms.Label labelVj;
        private System.Windows.Forms.Label labelVi;
        private System.Windows.Forms.TextBox Vk;
        private System.Windows.Forms.TextBox Vj;
        private System.Windows.Forms.TextBox Vi;
    }
}

