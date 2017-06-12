using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Convert_ExtensionToTXT
{
    public partial class Form1 : Form
    {
        private static bool ConvertAll = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            ConvertAll = true;
            string ss = @textBox_Path.Text;

            DirectoryInfo d = new DirectoryInfo(ss);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                string s = f.FullName.ToString();
                //File.Move(f.FullName, f.FullName.ToString().Replace("*", s+=".txt"));
                try
                {
                    File.Move(f.FullName, Path.ChangeExtension(f.FullName, ".txt"));
                }
                catch(Exception exception) { Console.WriteLine(exception); ConvertAll = false; }
            }

            if (!ConvertAll)
            {
                label_ConvertAll.Text = "One of more have failed, manually Scan";
            }
            else
                label_ConvertAll.Text = "All have converted successfully";

        }

        private void ClearField(object sender, MouseEventArgs e)
        {
            textBox_Path.Text = "";
        }
    }
}
