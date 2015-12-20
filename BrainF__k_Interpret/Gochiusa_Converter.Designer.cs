namespace BrainF__k_Interpret
{
    partial class Gochiusa_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gochiusa_Converter));
            this.tb_fucklng = new System.Windows.Forms.TextBox();
            this.tb_converted = new System.Windows.Forms.TextBox();
            this.btn_fucktogochi = new System.Windows.Forms.Button();
            this.btn_gochitofuck = new System.Windows.Forms.Button();
            this.btn_exec_onmain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_fucklng
            // 
            this.tb_fucklng.Location = new System.Drawing.Point(12, 26);
            this.tb_fucklng.Multiline = true;
            this.tb_fucklng.Name = "tb_fucklng";
            this.tb_fucklng.Size = new System.Drawing.Size(354, 79);
            this.tb_fucklng.TabIndex = 0;
            // 
            // tb_converted
            // 
            this.tb_converted.Location = new System.Drawing.Point(12, 154);
            this.tb_converted.Multiline = true;
            this.tb_converted.Name = "tb_converted";
            this.tb_converted.Size = new System.Drawing.Size(354, 82);
            this.tb_converted.TabIndex = 1;
            // 
            // btn_fucktogochi
            // 
            this.btn_fucktogochi.Location = new System.Drawing.Point(67, 111);
            this.btn_fucktogochi.Name = "btn_fucktogochi";
            this.btn_fucktogochi.Size = new System.Drawing.Size(75, 23);
            this.btn_fucktogochi.TabIndex = 2;
            this.btn_fucktogochi.Text = "↓";
            this.btn_fucktogochi.UseVisualStyleBackColor = true;
            this.btn_fucktogochi.Click += new System.EventHandler(this.btn_fucktogochi_Click);
            // 
            // btn_gochitofuck
            // 
            this.btn_gochitofuck.Location = new System.Drawing.Point(231, 111);
            this.btn_gochitofuck.Name = "btn_gochitofuck";
            this.btn_gochitofuck.Size = new System.Drawing.Size(75, 23);
            this.btn_gochitofuck.TabIndex = 3;
            this.btn_gochitofuck.Text = "↑";
            this.btn_gochitofuck.UseVisualStyleBackColor = true;
            this.btn_gochitofuck.Click += new System.EventHandler(this.btn_gochitofuck_Click);
            // 
            // btn_exec_onmain
            // 
            this.btn_exec_onmain.Location = new System.Drawing.Point(147, 242);
            this.btn_exec_onmain.Name = "btn_exec_onmain";
            this.btn_exec_onmain.Size = new System.Drawing.Size(75, 23);
            this.btn_exec_onmain.TabIndex = 4;
            this.btn_exec_onmain.Text = "実行";
            this.btn_exec_onmain.UseVisualStyleBackColor = true;
            this.btn_exec_onmain.Click += new System.EventHandler(this.btn_exec_onmain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brainf*ck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "ごちうさ";
            // 
            // Gochiusa_Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 277);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exec_onmain);
            this.Controls.Add(this.btn_gochitofuck);
            this.Controls.Add(this.btn_fucktogochi);
            this.Controls.Add(this.tb_converted);
            this.Controls.Add(this.tb_fucklng);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gochiusa_Converter";
            this.Text = "ごちうさ変換器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fucklng;
        private System.Windows.Forms.TextBox tb_converted;
        private System.Windows.Forms.Button btn_fucktogochi;
        private System.Windows.Forms.Button btn_gochitofuck;
        private System.Windows.Forms.Button btn_exec_onmain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}