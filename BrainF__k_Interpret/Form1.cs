using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BrainF__k_Interpret
{
    public partial class Form1 : Form
    {
        public int pointer; // ポインタ
        public int[] memory; //メモリ
        public string program; // プログラムソース
        public int pc; // プログラムカウンタ

        public bool isFirst = true; // 初回実行か
        public bool slow_exec = false; // 遅く実行するか
        public bool isExecuting = false; // 実行中であるか
        public bool gochiusa_mode = false; // ごちうさモード
        

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // ウィンドウのサイズを固定
            this.MaximizeBox = false; //最大化を無効にする

            Init();
        }
        
        /// <summary>
        /// メモリの状況や結果を表示する。
        /// </summary>
        /// <returns>True: 正常終了 False: ソースの末尾に来た</returns>
        public void Display()
        {
            // メモリ領域の表示
            var memory_show = "";

            for (var i = 0; i < 3; ++i)
            {
                for (var j = 0; j < 10; ++j)
                {
                    var index = i * 10 + j;
                    if (pointer == index)
                    {
                        memory_show += "[" + memory[index].ToString("000") + "]";
                    } else
                    {
                        memory_show += " " + memory[index].ToString("000") + " ";
                    }
                }
                memory_show += "\n"; //改行
            }
            lab_memory.Text = memory_show;

            // 実行中の場所を表示
            var show_current = "";
            for (var i = 0; i < program.Length; ++i)
            {
                if (i == pc + 1)
                {
                    show_current += "[" + program[i] + "]";
                } else
                {
                    show_current += program[i];
                }
            }
            lab_current.Text = show_current;
        }

        /// <summary>
        /// 変数などを初期化する。
        /// </summary>
        public void Init()
        {
            // 変数の初期化
            program = "";
            pc = 0;
            pointer = 0;
            memory = new int[30];
            // ラベルの初期化
            lab_current.Text = lab_memory.Text = lab_result.Text = "";
            btn_escape.Text = "強制終了";

            if (!isFirst)
            {
                // 各ブールの設定
                isExecuting = lab_current.Visible = true;
                btn_exec.Enabled = btn_step.Enabled = source.Enabled = false;
            } else
            {
                Fin();
                isFirst = false;
            }
        }

        /// <summary>
        /// 実行終了処理。
        /// </summary>
        public void Fin()
        {
            isExecuting = lab_current.Visible = false;
            source.Enabled = btn_exec.Enabled = btn_step.Enabled = true;
            btn_escape.Text = "クリア";
        }

        /// <summary>
        /// BrainF*ckプログラムを実行する。
        /// </summary>
        /// <returns>True: 正常実行 False: 正常終了 または 異常終了</returns>
        public bool Exec()
        {
            if (!isExecuting || pc == program.Length) return false;

            try {
                switch (program[pc])
                {
                    case '+': memory[pointer]++; break;
                    case '-': memory[pointer]--; break;
                    case '>': pointer++; break;
                    case '<': pointer--; break;
                    case '.':
                        var charbytes = BitConverter.GetBytes(memory[pointer]);
                        lab_result.Text += Encoding.GetEncoding(932).GetString(charbytes);
                        break;
                    case '[':
                        if (memory[pointer] == 0)
                        {
                            var pos = 0;
                            for (var i = pc; i < program.Length; ++i)
                            {
                                if (program[i] == ']')
                                {
                                    pos = i;
                                }
                            }
                            pc = pos;
                        }
                        break;
                    case ']':
                        if (memory[pointer] != 0)
                        {
                            var pos = 0;
                            for (var i = 0; i < pc; ++i)
                            {
                                if (program[i] == '[')
                                {
                                    pos = i;
                                }
                            }
                            pc = pos;
                        }
                        break;
                    case ',':
                        getform form = new getform();
                        form.ShowDialog();
                        var getchar = form.getchar;
                        if (getchar != "")
                        {
                            var getbytes = Encoding.GetEncoding(932).GetBytes(getchar);
                            var s = BitConverter.ToString(getbytes).Split('-');
                            memory[pointer] = int.Parse(getbytes.Length > 1 ? s[1] + s[0] : s[0], System.Globalization.NumberStyles.HexNumber);
                        } else
                        {
                            return false;
                        }
                        break;
                    default:
                        break;
                }
            } catch (Exception e)
            {
                MessageBox.Show("構文にエラーがあります。\n行数：" + pc + "文字目\nエラー詳細：\n" + e.Message,"コンパイルエラー",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Init();
                return false;
            }

            Application.DoEvents(); //応答なし回避
            return true;
        }

        public string make_source(string prog)
        {
            var ret = prog;
            if (gochiusa_mode)
            {
                    // + ぴょん         - らん
                    // > 心             < 胸が
                    // [ 詰んだ詰んだ   ] ぽっぴんジャンプ♪
                    // . 言いなさい     , ｾﾛﾘﾀﾍﾞﾃﾙ!
                    var sb = new System.Text.StringBuilder(prog);
                    sb.Replace("ぴょん", "+");
                    sb.Replace("らん", "-");
                    sb.Replace("心", ">");
                    sb.Replace("胸が", "<");
                    sb.Replace("詰んだ詰んだ", "[");
                    sb.Replace("ぽっぴんジャンプ♪", "]");
                    sb.Replace("言いなさい", ".");
                    sb.Replace("ｾﾛﾘﾀﾍﾞﾃﾙ!", ",");
                    ret = sb.ToString();
            }
            return ret;
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            Init();
            
            if  ((ModifierKeys & Keys.Control) == Keys.Control)
            {
                slow_exec = true;
            } else
            {
                slow_exec = false;
            }

            program = make_source(source.Text);
            while (true)
            {
                if (slow_exec)
                {
                    System.Threading.Thread.Sleep(50);
                    this.Update();
                }

                if (!Exec())
                {
                    break;
                }
                Display();
                ++pc;
            }

            Fin();
        }

        private void btn_step_Click(object sender, EventArgs e)
        {
            Init();
            btn_exec.Enabled = btn_step.Enabled = true;

            program = make_source(source.Text);
            if (!Exec())
            {
                Fin();
            }
            Display();

            ++pc;
        }

        private void source_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                source.SelectAll();
        }

        private void btn_escape_Click(object sender, EventArgs e)
        {
            if (isExecuting)
            {
                Fin();
            }
            else
            {
                lab_current.Text = lab_memory.Text = lab_result.Text = program = source.Text = "";
                memory = new int[30];
                pc = pointer = 0;
                gochiusa_mode = source.Enabled = btn_exec.Enabled = btn_step.Enabled = true;
                Manu_GochiusaMode.Checked = false;
            }
        }

        private void Manu_GochiusaMode_CheckedChanged(object sender, EventArgs e)
        {
            if (Manu_GochiusaMode.Checked)
            {
                gochiusa_mode = true; // ごちうさモード突入
                this.Text = "Brainf*ck - GOCHIUSA";
            }
            else
            {
                gochiusa_mode = false; // 通常モード 
                this.Text = "Brainf*ck";
            }
        }

        private void Menu_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Convert_Click(object sender, EventArgs e)
        {
            Gochiusa_Converter convform = new Gochiusa_Converter();
            convform.mainform = this;
            convform.ShowDialog();
        }

        private void Menu_CharConv_Click(object sender, EventArgs e)
        {
            CharConv charconv = new CharConv();
            charconv.ShowDialog();
        }

        private void Menu_bf_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //[ファイルの種類]に表示される選択肢を指定する
            ofd.Filter =
                "Brainfuckソース(*.bf)|*.bf|すべてのファイル(*.*)|*.*";

            //タイトルを設定する
            ofd.Title = "Brainfuckソースファイルを選択してください";

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // ファイルを読み込んで代入
                try
                {
                    using (StreamReader sr = new StreamReader(ofd.OpenFile(), Encoding.GetEncoding("Shift_JIS")))
                    {
                        source.Text = sr.ReadToEnd();
                    }
                }
                catch (Exception err)
                {
                    // 例外処理
                    MessageBox.Show("ソースファイル読み込み時にエラーが発生しました。\nエラー詳細：\n" + err.Message, "読み込みエラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Menu_Versions_Click(object sender, EventArgs e)
        {
            VersionForm vform = new VersionForm();
            vform.ShowDialog();
        }

        private void Menu_Howtouse_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://alltekito.tumblr.com/post/135554713399/brainfckinterprit");
        }
    }
}