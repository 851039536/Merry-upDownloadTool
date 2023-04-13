using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using CCWin.SkinControl;
using CopyTest.Manager;
using CopyTest.Model;
using ICSharpCode.SharpZipLib.Zip;

namespace CopyTest
{
    public partial class Form1 : Skin_Mac
    {
        private UploadingManager uploading = new UploadingManager();
        private string _zipedfilename2;

        public Form1()
        {
            InitializeComponent();
        }

        private  void CopyDir(string srcPath, string aimPath)
        {
            try
            {
                 button2.Text = @"下载中，请稍等";
                 button2.Enabled = false;
                // 检查目标目录是否以目录分割字符结束如果不是则添加
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    aimPath += Path.DirectorySeparatorChar;
                }

                // 判断目标目录是否存在如果不存在则新建
                if (!Directory.Exists(aimPath))
                {
                    Directory.CreateDirectory(aimPath);
                }

                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                // string[] fileList = Directory.GetFiles（srcPath）；
                string[] fileList = Directory.GetFileSystemEntries(srcPath);
                // 遍历所有的文件和目录
                foreach (string file in fileList)
                {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + Path.GetFileName(file));
                        DisplaylistboxMsg("下载成功");
                    }
                    // 否则直接Copy文件
                    else
                    {
                        File.Copy(file, aimPath + Path.GetFileName(file), true);
                        DisplaylistboxMsg("下载成功");
                    }
                }

            
            }
            catch (Exception e)
            {
               
                MessageBox.Show(e.Message);
            }
            finally{ 
                 button2.Enabled = true;
                 button2.Text = @"下载";
                }
        }

        private  void Button2_Click(object sender, EventArgs e)
        {

            Task copy = new Task(()=>CopyDir(textBox2.Text, textBox4.Text));
             copy.Start();
            
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            //浏览文件夹
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath.Trim() != "")
                textBox4.Text = folderBrowserDialog1.SelectedPath.Trim();
        }

        private void DisplaylistboxMsg(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(DisplaylistboxMsg), msg);
            }
            else
            {
                if (msg.Contains("\r\n"))
                {
                    skinListBox1.Items.Add(new SkinListBoxItem("\r\n"));
                }
                else
                {
                    skinListBox1.Items.Add(new SkinListBoxItem(string.Format("At {0:hh:mm:ss},{1}", DateTime.Now, msg)));
                }

                if (skinListBox1.Items.Count > 0) skinListBox1.SelectedIndex = skinListBox1.Items.Count - 1;
                Application.DoEvents();
            }
        }

      
        /// <param name="hwnd">指定父窗口句柄</param>
        /// <param name="lpszOp">指定要进行的操作</param>
        /// <param name="lpszFile">指定要打开的文件名</param>
        /// <param name="lpszParams">指定命令行参数</param>
        /// <param name="lpszDir">用于指定默认目录</param>
        /// <param name="fsShowCmd">参数是一个可执行程序</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]
        public static extern int ShellExecute(IntPtr hwnd, StringBuilder lpszOp, StringBuilder lpszFile, StringBuilder lpszParams, StringBuilder lpszDir, int fsShowCmd);

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
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
                textBox2.Text = data1.path;
                textBox4.Text = data1.localitypath;
                _zipedfilename2 = data1.zipedfilename2;
            }
        }

        /// <summary>
        /// 登录权限
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        private bool ConnectState(string path, string userName, string passWord)
        {
            bool flag = false;
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
                    flag = true;
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

            return flag;
        }

        private void 登录_Click(object sender, EventArgs e)
        {
            bool userbool = ConnectState(@"\\10.55.2.3", User.Text, Pwd.Text);
            if (userbool)
            {
                DisplaylistboxMsg("登录成功：" + User.Text);
            }
            else
            {
                DisplaylistboxMsg("登录失败");
            }
        }

        //===================================================解压用的是库函数
        /// <summary>  
        /// 功能：解压zip格式的文件。  
        /// </summary>  
        /// <param name="zipFilePath">压缩文件路径</param>  
        /// <param name="unZipDir">解压文件存放路径,为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹</param>  
        /// <returns>解压是否成功</returns>  
        public void UnZip(string zipFilePath, string unZipDir)
        {
            try
            {
                if (zipFilePath == string.Empty)
                {
                    throw new Exception("压缩文件不能为空！");
                }

                if (!File.Exists(zipFilePath))
                {
                    throw new FileNotFoundException("压缩文件不存在！");
                }

                //解压文件夹为空时默认与压缩文件同一级目录下，跟压缩文件同名的文件夹  
                if (unZipDir == string.Empty)
                    unZipDir = zipFilePath.Replace(Path.GetFileName(zipFilePath), Path.GetFileNameWithoutExtension(zipFilePath));
                if (!unZipDir.EndsWith("/"))
                    unZipDir += "/";
                if (!Directory.Exists(unZipDir))
                    Directory.CreateDirectory(unZipDir);

                using (var s = new ZipInputStream(File.OpenRead(zipFilePath)))
                {
                    ZipEntry theEntry;
                    while ((theEntry = s.GetNextEntry()) != null)
                    {
                        string directoryName = Path.GetDirectoryName(theEntry.Name);
                        string fileName = Path.GetFileName(theEntry.Name);
                        if (!string.IsNullOrEmpty(directoryName))
                        {
                            Directory.CreateDirectory(unZipDir + directoryName);
                        }

                        if (directoryName != null && !directoryName.EndsWith("/"))
                        {
                        }

                        if (fileName != string.Empty)
                        {
                            using (FileStream streamWriter = File.Create(unZipDir + theEntry.Name))
                            {
                                int size;
                                byte[] data = new byte[2048];
                                while (true)
                                {
                                    size = s.Read(data, 0, data.Length);
                                    if (size > 0)
                                    {
                                        streamWriter.Write(data, 0, size);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                DisplaylistboxMsg("解压完成！！");
            }
            catch (Exception e)
            {
                DisplaylistboxMsg("解压失败！！");
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task zip = new Task(()=> UnZip(_zipedfilename2, ""));
            zip.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(textBox2.Text), new StringBuilder(""), new StringBuilder(textBox2.Text), 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(textBox4.Text), new StringBuilder(""), new StringBuilder(textBox4.Text), 1);
        }
    }
}