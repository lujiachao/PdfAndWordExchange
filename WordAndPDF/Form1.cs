using Microsoft.Office.Interop.Word;
using Spire.Pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace WordAndPDF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOpenWord_Click(object sender, EventArgs e)
        {
            try
            {
                //定义一个文件打开控件 
                OpenFileDialog ofd = new OpenFileDialog();
                //设置打开对话框的初始目录，默认目录为exe运行文件所在的路径 
                ofd.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                //设置打开对话框的标题 
                ofd.Title = "请选择要打开的文件";
                //设置打开对话框可以多选 
                ofd.Multiselect = true;
                //设置对话框打开的文件类型 
                ofd.Filter = "Word&图片&PDF|*.doc;*.docx";
                //设置文件对话框当前选定的筛选器的索引 
                ofd.FilterIndex = 2;
                //设置对话框是否记忆之前打开的目录 
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //获取用户选择的文件完整路径        
                    string filePath = ofd.FileName;
                    string fileName = ofd.SafeFileName;
                    textWordPath.Text = filePath;
                    txtFileName.Text = fileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("转换失败!");
            }
        }

        private void btnWordToPDF_Click(object sender, EventArgs e)
        {
            WordToPDF(textWordPath.Text);
            MessageBox.Show("转换成功!"); 
        }

        public void WordToPDF(string sourcePath)
        {
            try
            {
                bool result = false;
                Microsoft.Office.Interop.Word.Application application = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document document = null;
                try
                {
                    application.Visible = false;
                    document = application.Documents.Open(sourcePath);
                    string lastChar = sourcePath.Substring(sourcePath.Length-1,1);
                    string PDFPath = string.Empty;
                    if (lastChar == "x")
                    {
                        PDFPath = sourcePath.Replace(".docx", ".pdf");//pdf存放位置
                    }
                    else
                    {
                        PDFPath = sourcePath.Replace(".doc", ".pdf");//pdf存放位置
                    }
                    if (!File.Exists(@PDFPath))//存在PDF，不需要继续转换
                    {
                        document.ExportAsFixedFormat(PDFPath, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                    }
                    result = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    result = false;
                }
                finally
                {
                    document.Close();
                }                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("转换成功");
            }
        }

        public void PdfToWord(string sourcePath)
        {
            try
            {
                PdfDocument doc = new PdfDocument();

                doc.LoadFromFile(sourcePath);
                if (radioDoc.Checked == false && radioDocx.Checked == true)
                {
                    doc.SaveToFile(sourcePath.Replace(".pdf", ".docx"), FileFormat.DOCX);

                    System.Diagnostics.Process.Start(sourcePath.Replace(".pdf", ".docx"));
                }
                if (radioDoc.Checked == true && radioDocx.Checked == false)
                {
                    doc.SaveToFile(sourcePath.Replace(".pdf", ".doc"), FileFormat.DOC);

                    System.Diagnostics.Process.Start(sourcePath.Replace(".pdf", ".doc"));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("转换失败");
            }
        }

        private void BtnOpenPdf_Click(object sender, EventArgs e)
        {
            try
            {
                //定义一个文件打开控件 
                OpenFileDialog ofd = new OpenFileDialog();
                //设置打开对话框的初始目录，默认目录为exe运行文件所在的路径 
                ofd.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                //设置打开对话框的标题 
                ofd.Title = "请选择要打开的文件";
                //设置打开对话框可以多选 
                ofd.Multiselect = true;
                //设置对话框打开的文件类型 
                ofd.Filter = "Word&图片&PDF|*.pdf";
                //设置文件对话框当前选定的筛选器的索引 
                ofd.FilterIndex = 2;
                //设置对话框是否记忆之前打开的目录 
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //获取用户选择的文件完整路径        
                    string filePath = ofd.FileName;
                    string fileName = ofd.SafeFileName;
                    txtPdfPath.Text = filePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("转换失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfToWord(txtPdfPath.Text);
            MessageBox.Show("PDF转换Word成功");
        }

        private void radioDoc_Click(object sender, EventArgs e)
        {
            if (radioDoc.Checked == true)
            {
                radioDocx.Checked = false;
            }
            else
            {
                radioDocx.Checked = true;
            }

        }

        private void radioDocx_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDocx.Checked == true)
            {
                radioDoc.Checked = false;
            }
            else
            {
                radioDoc.Checked = true;
            }
        }
    }
}
