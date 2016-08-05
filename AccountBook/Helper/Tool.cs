using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class Tool
{
    public static void errorMessage(string msg)
    {
        MessageBox.Show(msg, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public static void promptMessage(string msg)
    {
        MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public static DialogResult Affirm(string msg)
    {
        return MessageBox.Show(msg, "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
}
