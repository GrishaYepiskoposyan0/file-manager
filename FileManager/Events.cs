using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace FileManager
{
    public class Events
    {
        public void FolderBrowser(ref System.Windows.Controls.TextBox tb)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb.Text = fbd.SelectedPath;
            }
            
        }
        public void Move(string file, System.Windows.Controls.TextBox way, ref string newFolderName)
        {
            string extension = Path.GetExtension(file);
            string[] audio = new string[] { ".MP3", ".WMA", ".AAC", ".WAV", ".FLAC", ".ALAC", ".AIFF", ".DSD", ".PCM", };
            string[] video = new string[] { ".MP4", ".MOV", ".WMV", ".FLV", ".AVI", ".MKV", ".AVCHD" };
            string[] photo = new string[] { ".JPEG", ".JPG", ".PNG", ".GIF" };
            string[] installer = new string[] { ".MSI", ".MSM", ".MSP", ".MST", ".IDT", ".EXE", ".CUB", "P.CP",".TORRENT" ,".ISO"};
            string[] archives = new string[] { ".ZIP", ".RAR", ".7Z" };
            string[] doc = new string[] { ".DOC", ".DOCX", ".XLSX", ".XLX", ".PDF", ".XML",".XAML",".TXT"};
            if (Array.IndexOf(audio, extension.ToUpper()) >= 0)
            {
                if (Directory.Exists(way.Text + @"\Audio"))
                {
                }
                else
                {
                    Directory.CreateDirectory(way.Text + @"\Audio");
                }
                newFolderName = "Audio";
            }
            else if (Array.IndexOf(video, extension.ToUpper()) >= 0)
            {
                if (Directory.Exists(way.Text + @"\Video"))
                {
                }
                else
                {
                    Directory.CreateDirectory(way.Text + @"\Video");
                }
                newFolderName = "Video";
            }
            else if (Array.IndexOf(photo, extension.ToUpper()) >= 0)
            {
                if (Directory.Exists(way.Text + @"\Photo"))
                {
                }
                else
                {
                    Directory.CreateDirectory(way.Text + @"\Photo");
                }
                newFolderName = "Photo";
            }
            else if (Array.IndexOf(installer, extension.ToUpper()) >= 0)
            {
                if (Directory.Exists(way.Text + @"\Installers"))
                {
                }
                else
                {
                    Directory.CreateDirectory(way.Text + @"\Installers");
                }
                newFolderName = "Installers";
            }
            else if (Array.IndexOf(archives, extension.ToUpper()) >= 0)
            {
                if (Directory.Exists(way.Text + @"\Archives"))
                {
                }
                else
                {
                    Directory.CreateDirectory(way.Text + @"\Archives");
                }
                newFolderName = "Archives";
            }
            else if (Array.IndexOf(doc, extension.ToUpper()) >= 0)
            {
                if (Directory.Exists(way.Text + @"\Documents"))
                {
                }
                else
                {
                    Directory.CreateDirectory(way.Text + @"\Documents");
                }
                newFolderName = "Documents";
            }
            else
            {
                if (Directory.Exists(way.Text + @"\Other"))
                {
                }
                else
                {
                    Directory.CreateDirectory(way.Text + @"\Other");
                }
                newFolderName = "Other";
            }
        }
        
    }
}
