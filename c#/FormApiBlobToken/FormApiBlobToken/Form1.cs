using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApiBlobToken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_token_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            client.Headers["Content-type"] = "application/json";
            String url = "http://localhost:53664/api/Token";
            byte[] info = client.DownloadData(url);
            MemoryStream ms = new MemoryStream();
            ms = new MemoryStream(info);
            String data = Encoding.UTF8.GetString(ms.ToArray());
            data = data.Replace("\"", "");
            this.text_token.Text = data;
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String archive = dialog.FileName;
                int lastword = archive.LastIndexOf(@"\") + 1;
                String nameblob = archive.Substring(lastword);
                String sas = this.text_token.Text;
                CloudBlobContainer container = new CloudBlobContainer(new Uri(sas));
                CloudBlockBlob blockBlob = container.GetBlockBlobReference(nameblob);
                using (var fileStream = System.IO.File.OpenRead(archive))
                {
                    blockBlob.UploadFromStream(fileStream);
                }

                MessageBox.Show("Blob subido correctamente");
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            listBlob();
        }

        private void listBlob()
        {
            this.list_blob.Items.Clear();
            String sas = this.text_token.Text;
            CloudBlobContainer container = new CloudBlobContainer(new Uri(sas));

            foreach (ICloudBlob blob in container.ListBlobs())
            {
                this.list_blob.Items.Add(blob.Name);
            }
        }

        private void list_blob_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sas = this.text_token.Text;
            CloudBlobContainer container = new CloudBlobContainer(new Uri(sas));
            String nameblob = this.list_blob.SelectedItem.ToString();
            CloudBlockBlob blob = container.GetBlockBlobReference(nameblob);
            MemoryStream msRead = new MemoryStream();
            msRead.Position = 0;
            blob.DownloadToStream(msRead);
            Console.WriteLine(msRead.Length);
            this.img.Image = Image.FromStream(msRead);
        }

        private void dtn_delete_Click(object sender, EventArgs e)
        {
            String sas = this.text_token.Text;
            CloudBlobContainer container = new CloudBlobContainer(new Uri(sas));
            String nameblob = this.list_blob.SelectedItem.ToString();
            CloudBlockBlob blob = container.GetBlockBlobReference(nameblob);
            blob.DeleteIfExists();
            this.img.Image = null;
            listBlob();
        }
    }
}
