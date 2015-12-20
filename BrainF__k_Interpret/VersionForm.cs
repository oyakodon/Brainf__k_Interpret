using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainF__k_Interpret
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle; // 枠の固定(=ウィンドウサイズの固定)
            this.MaximizeBox = false; //最大化を無効にする

            Assembly asm = Assembly.GetExecutingAssembly();
            lab_version.Text = asm.GetName().Version.ToString();
            var asmcpy =(AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute));
            lab_copyright.Text = asmcpy.Copyright;
        }
    }
}
