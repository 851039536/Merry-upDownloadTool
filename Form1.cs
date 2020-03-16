using CCWin;
using CCWin.SkinControl;
using CopyTest.Manager;
using CopyTest.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CopyTest
{
    public partial class Form1 : CCSkinMain
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void CopyDirs(string srcPath, string aimPath)
        {
            try
            {
                // 检查目标目录是否以目录分割字符结束如果不是则添加
                if (aimPath[aimPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
                {
                    aimPath += System.IO.Path.DirectorySeparatorChar;
                }

                // 判断目标目录是否存在如果不存在则新建
                if (!System.IO.Directory.Exists(aimPath))
                {
                    System.IO.Directory.CreateDirectory(aimPath);
                }

                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles（srcPath）；
                string[] fileList = System.IO.Directory.GetFileSystemEntries(srcPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (System.IO.Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + System.IO.Path.GetFileName(file));

                        DisplaylistboxMsg("上传成功");
                    }
                    // 否则直接Copy文件
                    else
                    {
                        System.IO.File.Copy(file, aimPath + System.IO.Path.GetFileName(file), true);
                        DisplaylistboxMsg("上传成功");
                    }
                }
            }
            catch (Exception e)
            {
                DisplaylistboxMsg("上传失败" + e.Message);
            }
        }

        private void CopyDir(string srcPath, string aimPath)
        {
            // 检查目标目录是否以目录分割字符结束如果不是则添加
            if (aimPath[aimPath.Length - 1] != System.IO.Path.DirectorySeparatorChar)
            {
                aimPath += System.IO.Path.DirectorySeparatorChar;
            }

            // 判断目标目录是否存在如果不存在则新建
            if (!System.IO.Directory.Exists(aimPath))
            {
                System.IO.Directory.CreateDirectory(aimPath);
            }

            // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
            // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
            // string[] fileList = Directory.GetFiles（srcPath）；
            string[] fileList = System.IO.Directory.GetFileSystemEntries(srcPath);
            // 遍历所有的文件和目录
            foreach (string file in fileList)
            {
                // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                if (System.IO.Directory.Exists(file))
                {
                    CopyDir(file, aimPath + System.IO.Path.GetFileName(file));
                    DisplaylistboxMsg("下载成功");
                }
                // 否则直接Copy文件
                else
                {
                    System.IO.File.Copy(file, aimPath + System.IO.Path.GetFileName(file), true);
                    DisplaylistboxMsg("下载成功");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled=false;
             CopyDir(textBox2.Text, textBox4.Text);
             button2.Enabled=true;
        }

       

        private void Button4_Click(object sender, EventArgs e)
        {
            //浏览文件夹
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Trim() != "")
                textBox4.Text = folderBrowserDialog1.SelectedPath.Trim();
        }

        private void DisplaylistboxMsg(String msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<String>(DisplaylistboxMsg), new Object[] { msg });
            }
            else
            {
                if (msg.Contains("\r\n"))
                {
                    skinListBox1.Items.Add(new SkinListBoxItem("\r\n"));
                }
                else
                {
                    skinListBox1.Items.Add(new SkinListBoxItem(String.Format("At {0:hh:mm:ss},{1}", DateTime.Now, msg)));
                }
                if (skinListBox1.Items.Count > 0) skinListBox1.SelectedIndex = skinListBox1.Items.Count - 1;
                Application.DoEvents();
            }
        }

        private UploadingManager uploading = new UploadingManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            List<uploading> data = uploading.Query();
            foreach (var data1 in data)
            {
                comboBox1.Items.Add(data1.name);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<uploading> data = uploading.GetName(comboBox1.Text);
            

            foreach (var data1 in data)
            {
                 textBox2.Text =data1.path;
                 textBox4.Text =data1.localitypath;
            }
        }
        /// <summary>
        /// 登录权限
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
          public  bool ConnectState(string path, string userName, string passWord)
        {
            bool Flag = false;
            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                string dosLine = "net use " + path + " " + passWord + " /user:" + userName;
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
              DisplaylistboxMsg(ex.Message);
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }

        private void 登录_Click(object sender, EventArgs e)
        {
             bool userbool = ConnectState(@"\\10.55.2.3",User.Text,Pwd.Text);
           if (userbool)
           {
                DisplaylistboxMsg("登录成功："+User.Text);
           }
           else
           {
                DisplaylistboxMsg("登录失败");
           }
        }
    }
}
