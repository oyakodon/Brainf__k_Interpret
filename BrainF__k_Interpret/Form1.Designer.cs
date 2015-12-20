namespace BrainF__k_Interpret
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.source = new System.Windows.Forms.TextBox();
            this.btn_exec = new System.Windows.Forms.Button();
            this.btn_step = new System.Windows.Forms.Button();
            this.lab_memory = new System.Windows.Forms.Label();
            this.lab_result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_current = new System.Windows.Forms.Label();
            this.btn_escape = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_bf = new System.Windows.Forms.ToolStripMenuItem();
            this.Manu_GochiusaMode = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Convert = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_CharConv = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Howtouse = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Versions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // source
            // 
            this.source.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.source.Location = new System.Drawing.Point(12, 44);
            this.source.Multiline = true;
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(384, 58);
            this.source.TabIndex = 0;
            this.source.KeyDown += new System.Windows.Forms.KeyEventHandler(this.source_KeyDown);
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(321, 108);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(75, 23);
            this.btn_exec.TabIndex = 1;
            this.btn_exec.Text = "実行";
            this.btn_exec.UseVisualStyleBackColor = true;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // btn_step
            // 
            this.btn_step.Location = new System.Drawing.Point(236, 108);
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(75, 23);
            this.btn_step.TabIndex = 2;
            this.btn_step.Text = "ステップ実行";
            this.btn_step.UseVisualStyleBackColor = true;
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // lab_memory
            // 
            this.lab_memory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_memory.Location = new System.Drawing.Point(11, 149);
            this.lab_memory.Name = "lab_memory";
            this.lab_memory.Size = new System.Drawing.Size(385, 75);
            this.lab_memory.TabIndex = 3;
            // 
            // lab_result
            // 
            this.lab_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_result.Location = new System.Drawing.Point(10, 244);
            this.lab_result.Name = "lab_result";
            this.lab_result.Size = new System.Drawing.Size(386, 77);
            this.lab_result.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "結果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "メモリ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "ソース";
            // 
            // lab_current
            // 
            this.lab_current.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_current.Location = new System.Drawing.Point(10, 44);
            this.lab_current.Name = "lab_current";
            this.lab_current.Size = new System.Drawing.Size(386, 61);
            this.lab_current.TabIndex = 9;
            this.lab_current.Visible = false;
            // 
            // btn_escape
            // 
            this.btn_escape.Location = new System.Drawing.Point(13, 108);
            this.btn_escape.Name = "btn_escape";
            this.btn_escape.Size = new System.Drawing.Size(67, 23);
            this.btn_escape.TabIndex = 11;
            this.btn_escape.Text = "クリア";
            this.btn_escape.UseVisualStyleBackColor = true;
            this.btn_escape.Click += new System.EventHandler(this.btn_escape_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.ツールToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_bf,
            this.Manu_GochiusaMode,
            this.Menu_Quit});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // Menu_bf
            // 
            this.Menu_bf.Name = "Menu_bf";
            this.Menu_bf.Size = new System.Drawing.Size(154, 22);
            this.Menu_bf.Text = "開く(&O)";
            this.Menu_bf.Click += new System.EventHandler(this.Menu_bf_Click);
            // 
            // Manu_GochiusaMode
            // 
            this.Manu_GochiusaMode.CheckOnClick = true;
            this.Manu_GochiusaMode.Name = "Manu_GochiusaMode";
            this.Manu_GochiusaMode.Size = new System.Drawing.Size(154, 22);
            this.Manu_GochiusaMode.Text = "ごちうさモード(&G)";
            this.Manu_GochiusaMode.CheckedChanged += new System.EventHandler(this.Manu_GochiusaMode_CheckedChanged);
            // 
            // Menu_Quit
            // 
            this.Menu_Quit.Name = "Menu_Quit";
            this.Menu_Quit.Size = new System.Drawing.Size(154, 22);
            this.Menu_Quit.Text = "終了(&Q)";
            this.Menu_Quit.Click += new System.EventHandler(this.Menu_Quit_Click);
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Convert,
            this.Menu_CharConv});
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ツールToolStripMenuItem.Text = "ツール(&T)";
            // 
            // Menu_Convert
            // 
            this.Menu_Convert.Name = "Menu_Convert";
            this.Menu_Convert.Size = new System.Drawing.Size(166, 22);
            this.Menu_Convert.Text = "ごちうさ変換(&U)";
            this.Menu_Convert.Click += new System.EventHandler(this.Menu_Convert_Click);
            // 
            // Menu_CharConv
            // 
            this.Menu_CharConv.Name = "Menu_CharConv";
            this.Menu_CharConv.Size = new System.Drawing.Size(166, 22);
            this.Menu_CharConv.Text = "文字コード変換(&C)";
            this.Menu_CharConv.Click += new System.EventHandler(this.Menu_CharConv_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Howtouse,
            this.Menu_Versions});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // Menu_Howtouse
            // 
            this.Menu_Howtouse.Name = "Menu_Howtouse";
            this.Menu_Howtouse.Size = new System.Drawing.Size(161, 22);
            this.Menu_Howtouse.Text = "使い方(&H)";
            this.Menu_Howtouse.Click += new System.EventHandler(this.Menu_Howtouse_Click);
            // 
            // Menu_Versions
            // 
            this.Menu_Versions.Name = "Menu_Versions";
            this.Menu_Versions.Size = new System.Drawing.Size(161, 22);
            this.Menu_Versions.Text = "バージョン情報(&V)";
            this.Menu_Versions.Click += new System.EventHandler(this.Menu_Versions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 332);
            this.Controls.Add(this.btn_escape);
            this.Controls.Add(this.lab_current);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_result);
            this.Controls.Add(this.lab_memory);
            this.Controls.Add(this.btn_step);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.source);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Brainf*ck";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.Button btn_step;
        private System.Windows.Forms.Label lab_memory;
        private System.Windows.Forms.Label lab_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_current;
        private System.Windows.Forms.Button btn_escape;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Quit;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Convert;
        public System.Windows.Forms.TextBox source;
        public System.Windows.Forms.ToolStripMenuItem Manu_GochiusaMode;
        private System.Windows.Forms.ToolStripMenuItem Menu_CharConv;
        private System.Windows.Forms.ToolStripMenuItem Menu_bf;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Howtouse;
        private System.Windows.Forms.ToolStripMenuItem Menu_Versions;
    }
}

