using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace 安全驾驶指南
{
    public partial class SafeDrivingGuideForm : Form
    {
        public SafeDrivingGuideForm()
        {
            InitializeComponent();
        }

        private string[] values = { "富强", "民主", "文明", "和谐", "自由", "平等", "公正", "法治", "爱国", "敬业", "诚信", "友善"};

        /// <summary>
        /// 加密按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnCode_Click(object sender, EventArgs e)
        {
            string input = richTextBoxDe.Text.Trim();
            string output = valuesEncode(input);
            Clipboard.SetDataObject(output);//顺手复制到剪贴板
            richTextBoxEn.Text = output;
        }

        /// <summary>
        /// 解密按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeCode_Click(object sender, EventArgs e)
        {
            string input = richTextBoxEn.Text.Trim();
            string output = valuesDecode(input);
            Clipboard.SetDataObject(output);//顺手复制到剪贴板
            richTextBoxDe.Text = output;
        }

        /// <summary>
        /// Encode Values
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string valuesEncode(string str)
        {
            return duo2values(hex2duo(str2utf8(str)));
        }

        /// <summary>
        /// Decode Values
        /// </summary>
        /// <param name="encoded"></param>
        /// <returns></returns>
        private string valuesDecode(string encoded)
        {
            string result = "";

            List<int> duo = new List<int>();
            for (int i = 0; i < encoded.Length; i += 2)
            {
                string value = encoded[i].ToString() + encoded[i + 1].ToString();
                for (int j = 0;j<values.Length;j++)
                {
                    if (String.Equals(value, values[j]))
                    {
                        duo.Add(j);
                    }
                }
            }

            List<string> hex = duo2hex(duo);

            result = utf82str(hex);

            return result;
        }

        /// <summary>
        /// 10进制组合转16进制URI编码
        /// </summary>
        /// <param name="duo"></param>
        /// <returns></returns>
        private List<string> duo2hex(List<int> duo)
        {
            List<string> hex = new List<string>();

            int i = 0;
            int l = duo.Count;

            while (i < l)
            {
                if (duo[i] < 10)
                {
                    hex.Add(duo[i].ToString());
                }
                else
                {
                    if (duo[i] == 10)
                    {
                        i++;
                        hex.Add((duo[i] + 10).ToString());
                    }
                    else
                    {
                        i++;
                        hex.Add((duo[i] + 6).ToString());
                    }
                }
                i++;
            }

            //10进制转16进制
            for (int j = 0; j < hex.Count; j++)
            {
                hex[j] = Convert.ToString(int.Parse(hex[j]), 16).ToUpper();
            }
            return hex;
        }

        /// <summary>
        /// 16进制编码加百分号，再转为字符
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        private string utf82str(List<string> hex)
        {
            string result = "";
            for (int i = 0; i < hex.Count; i += 2)
            {
                result += "%";
                result += hex[i];
                result += hex[i + 1];
            }
            return System.Web.HttpUtility.UrlDecode(result);
        }

        /// <summary>
        /// 初始字符串转UTF8
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string str2utf8(string str)
        {
            string input = str;
            string output = "";
            foreach (char c in input)
            {
                Regex regex = new Regex(@"[，。；？~！：‘“”’【】（）]");

                if (c >= 0x4e00 && c <= 0x9fbb)
                    output = output + c;
                else if (regex.IsMatch(c.ToString()))
                    output = output + c;
                else
                    output = output + Convert.ToString(Convert.ToInt32(c.ToString().ElementAt(0)), 16);
            }

            output = System.Web.HttpUtility.UrlEncode(output);
            return output.Replace("%", "").ToUpper();
        }

        /// <summary>
        /// UTF8转哈希，key为12
        /// </summary>
        /// <param name="hexs"></param>
        /// <returns></returns>
        private ArrayList hex2duo(string hexs)
        {
            ArrayList duo = new ArrayList();
            foreach (char c in hexs)
            {
                int n = Int32.Parse(c.ToString(), System.Globalization.NumberStyles.HexNumber);
                if (n < 10)
                {
                    duo.Add(n);
                }
                else
                {
                    if (randBin())
                    {
                        duo.Add(10);
                        duo.Add(n - 10);
                    }
                    else
                    {
                        duo.Add(11);
                        duo.Add(n - 6);
                    }
                }
            }
            return duo;
                
        }

        /// <summary>
        /// 将哈希列表对应values
        /// </summary>
        /// <param name="duo"></param>
        /// <returns></returns>
        private string duo2values(ArrayList duo)
        {
            string result = "";
            foreach (int i in duo)
            {
                result = result + values[i];
            }
            return result;
        }

        /// <summary>
        /// 随机获取是或否
        /// </summary>
        /// <returns></returns>
        private Boolean randBin()
        {
            return (new Random()).NextDouble() > 0.5 ? true : false;
        }

        private void SafeDrivingGuideForm_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
        }

        private void SafeDrivingGuideForm_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Variazioni CopyRight\n感谢算法原作者sym233");
        }
    }
}
