namespace BrainF__k_Interpret
{
    partial class CharConv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharConv));
            this.tb_char = new System.Windows.Forms.TextBox();
            this.tb_charcode1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_char_tocode = new System.Windows.Forms.Button();
            this.btn_code_tochar = new System.Windows.Forms.Button();
            this.tb_charcode2 = new System.Windows.Forms.TextBox();
            this.tb_codehex = new System.Windows.Forms.TextBox();
            this.btn_inttobyte = new System.Windows.Forms.Button();
            this.btn_bytetoint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_char
            // 
            this.tb_char.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb_char.Location = new System.Drawing.Point(12, 37);
            this.tb_char.MaxLength = 1;
            this.tb_char.Name = "tb_char";
            this.tb_char.Size = new System.Drawing.Size(54, 39);
            this.tb_char.TabIndex = 1;
            this.tb_char.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_charcode1
            // 
            this.tb_charcode1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_charcode1.Location = new System.Drawing.Point(177, 37);
            this.tb_charcode1.Name = "tb_charcode1";
            this.tb_charcode1.Size = new System.Drawing.Size(85, 19);
            this.tb_charcode1.TabIndex = 2;
            this.tb_charcode1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_charcode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文字(一文字)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "文字コード\r\n(16進数)";
            // 
            // btn_char_tocode
            // 
            this.btn_char_tocode.Location = new System.Drawing.Point(85, 34);
            this.btn_char_tocode.Name = "btn_char_tocode";
            this.btn_char_tocode.Size = new System.Drawing.Size(75, 23);
            this.btn_char_tocode.TabIndex = 6;
            this.btn_char_tocode.Text = "→";
            this.btn_char_tocode.UseVisualStyleBackColor = true;
            this.btn_char_tocode.Click += new System.EventHandler(this.btn_char_tocode_Click);
            // 
            // btn_code_tochar
            // 
            this.btn_code_tochar.Location = new System.Drawing.Point(85, 63);
            this.btn_code_tochar.Name = "btn_code_tochar";
            this.btn_code_tochar.Size = new System.Drawing.Size(75, 23);
            this.btn_code_tochar.TabIndex = 7;
            this.btn_code_tochar.Text = "←";
            this.btn_code_tochar.UseVisualStyleBackColor = true;
            this.btn_code_tochar.Click += new System.EventHandler(this.btn_code_tochar_Click);
            // 
            // tb_charcode2
            // 
            this.tb_charcode2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_charcode2.Location = new System.Drawing.Point(177, 57);
            this.tb_charcode2.Name = "tb_charcode2";
            this.tb_charcode2.Size = new System.Drawing.Size(85, 19);
            this.tb_charcode2.TabIndex = 8;
            // 
            // tb_codehex
            // 
            this.tb_codehex.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tb_codehex.Location = new System.Drawing.Point(378, 51);
            this.tb_codehex.Name = "tb_codehex";
            this.tb_codehex.Size = new System.Drawing.Size(85, 19);
            this.tb_codehex.TabIndex = 9;
            // 
            // btn_inttobyte
            // 
            this.btn_inttobyte.Location = new System.Drawing.Point(288, 63);
            this.btn_inttobyte.Name = "btn_inttobyte";
            this.btn_inttobyte.Size = new System.Drawing.Size(75, 23);
            this.btn_inttobyte.TabIndex = 11;
            this.btn_inttobyte.Text = "←";
            this.btn_inttobyte.UseVisualStyleBackColor = true;
            this.btn_inttobyte.Click += new System.EventHandler(this.btn_inttohexClick);
            // 
            // btn_bytetoint
            // 
            this.btn_bytetoint.Location = new System.Drawing.Point(288, 34);
            this.btn_bytetoint.Name = "btn_bytetoint";
            this.btn_bytetoint.Size = new System.Drawing.Size(75, 23);
            this.btn_bytetoint.TabIndex = 10;
            this.btn_bytetoint.Text = "→";
            this.btn_bytetoint.UseVisualStyleBackColor = true;
            this.btn_bytetoint.Click += new System.EventHandler(this.btn_hextoint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "文字コード\r\n(10進数)";
            // 
            // CharConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 92);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_inttobyte);
            this.Controls.Add(this.btn_bytetoint);
            this.Controls.Add(this.tb_codehex);
            this.Controls.Add(this.tb_charcode2);
            this.Controls.Add(this.btn_code_tochar);
            this.Controls.Add(this.btn_char_tocode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_charcode1);
            this.Controls.Add(this.tb_char);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharConv";
            this.Text = "文字コードへ変換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_char;
        private System.Windows.Forms.TextBox tb_charcode1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_char_tocode;
        private System.Windows.Forms.Button btn_code_tochar;
        private System.Windows.Forms.TextBox tb_charcode2;
        private System.Windows.Forms.TextBox tb_codehex;
        private System.Windows.Forms.Button btn_inttobyte;
        private System.Windows.Forms.Button btn_bytetoint;
        private System.Windows.Forms.Label label1;
    }
}