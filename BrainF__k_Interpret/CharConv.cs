using System;
using System.Text;
using System.Windows.Forms;

namespace BrainF__k_Interpret
{
    public partial class CharConv : Form
    {
        public CharConv()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 枠の固定(=ウィンドウサイズの固定)
            this.MaximizeBox = false; //最大化を無効にする
        }

        private void tb_charcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9とバックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar)&&(e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void btn_char_tocode_Click(object sender, EventArgs e)
        {
            var getbytes = Encoding.GetEncoding(932).GetBytes(tb_char.Text);
            var s = BitConverter.ToString(getbytes).Split('-');
            tb_charcode1.Text = getbytes.Length > 0 ? s[0] : "0";
            tb_charcode2.Text = getbytes.Length > 1 ? s[1] : "0";
        }

        private void btn_code_tochar_Click(object sender, EventArgs e)
        {
            try {
                var bytes = new byte[] { Convert.ToByte(tb_charcode1.Text, 16), tb_charcode2.TextLength != 0 ? Convert.ToByte(tb_charcode2.Text, 16) : (byte)0};
                tb_char.Text = Encoding.GetEncoding(932).GetString(bytes);
            }
            catch (Exception err)
            {
                MessageBox.Show("入力された数値にエラーがあります。\n(「FF」より大きな数値は入力できません。)\nエラー詳細：\n" + err.Message, "変換エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void btn_hextoint_Click(object sender, EventArgs e)
        {
            var convTxt = "";
            if (tb_charcode2.Text == "0")
            {
                convTxt = tb_charcode1.Text;
            } else
            {
                convTxt = tb_charcode2.Text + tb_charcode1.Text;
            }
            tb_codehex.Text = int.Parse(convTxt, System.Globalization.NumberStyles.HexNumber).ToString();
        }

        private void btn_inttohexClick(object sender, EventArgs e)
        {
            try
            {
                var charbytes = BitConverter.GetBytes(int.Parse(tb_codehex.Text));
                if (BitConverter.IsLittleEndian)
                    Array.Reverse(charbytes);
                var s = BitConverter.ToString(charbytes).Split('-');
                if (charbytes[0] == 0 && charbytes[1] == 0)
                {
                    tb_charcode2.Text = charbytes[2] != 00 ? s[2] : "0";
                    tb_charcode1.Text = charbytes[3] != 00 ? s[3] : "0";
                }
                else
                {
                    throw new Exception("入力された数値が2バイトの範囲を超えています。(Intentionally Throw)"); // 例外発生。
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("入力された数値にエラーがあります。\n(65,536以上の数値は入力できません。)\nエラー詳細：\n" + err.Message, "変換エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
