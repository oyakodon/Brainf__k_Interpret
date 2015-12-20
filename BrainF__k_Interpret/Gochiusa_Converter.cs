using System;
using System.Text;
using System.Windows.Forms;

namespace BrainF__k_Interpret
{
    public partial class Gochiusa_Converter : Form
    {
        public Form1 mainform;

        public Gochiusa_Converter()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 枠の固定(=ウィンドウサイズの固定)
            this.MaximizeBox = false; //最大化を無効にする
        }

        private void btn_fucktogochi_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder(tb_fucklng.Text);
            sb.Replace("+", "ぴょん");
            sb.Replace("-", "らん");
            sb.Replace(">", "心");
            sb.Replace("<", "胸が");
            sb.Replace("[", "詰んだ詰んだ");
            sb.Replace("]", "ぽっぴんジャンプ♪");
            sb.Replace(".", "言いなさい");
            sb.Replace(",", "ｾﾛﾘﾀﾍﾞﾃﾙ!");
            tb_converted.Text = sb.ToString();
        }

        private void btn_gochitofuck_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder(tb_converted.Text);
            sb.Replace("ぴょん", "+");
            sb.Replace("らん", "-");
            sb.Replace("心", ">");
            sb.Replace("胸が", "<");
            sb.Replace("詰んだ詰んだ", "[");
            sb.Replace("ぽっぴんジャンプ♪", "]");
            sb.Replace("言いなさい", ".");
            sb.Replace("ｾﾛﾘﾀﾍﾞﾃﾙ!", ",");
            tb_fucklng.Text = sb.ToString();
        }

        private void btn_exec_onmain_Click(object sender, EventArgs e)
        {
            mainform.source.Text = tb_converted.Text;
            mainform.Manu_GochiusaMode.Checked = true;
            this.Close();
        }
    }
}
