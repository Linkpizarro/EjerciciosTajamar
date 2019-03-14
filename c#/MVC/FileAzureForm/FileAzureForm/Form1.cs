using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.File;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileAzureForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            String keys = CloudConfigurationManager.GetSetting("Storage");
            CloudStorageAccount account = CloudStorageAccount.Parse(keys);
            CloudFileClient client = account.CreateCloudFileClient();
            CloudFileShare shared = client.GetShareReference("sharedtajamar");
            CloudFileDirectory root = shared.GetRootDirectoryReference();
            CloudFile file = root.GetFileReference("bbdd.sql");
            String content = file.DownloadTextAsync().Result;
            this.txt.Text = content;
        }
    }
}
