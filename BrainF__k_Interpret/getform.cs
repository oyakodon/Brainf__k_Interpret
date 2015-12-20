using System;
using System.Windows.Forms;

namespace BrainF__k_Interpret
{
    public partial class getform: Form
    {
        public string getchar;
        public bool isInputed = false;

        public getform()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 枠線の固定(=ウィンドウサイズの固定)
            this.MaximizeBox = false; //最大化を無効にする
        }

        private void input_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isInputed)
                //入力されていなかったら閉じない
                e.Cancel = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            isInputed = true;
            getchar = tb_input.Text;
            this.Close();
        }
    }
}
