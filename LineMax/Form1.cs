using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineMax
{
	public partial class Form1 : Form
	{
		public OpenFileDialog openFileDialog;
		private DataProcessing dataProcessing;

		public Form1()
		{
			InitializeComponent();
			dataProcessing = new DataProcessing();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            string[] args = Environment.GetCommandLineArgs();
            if(args.Length>1 && !string.IsNullOrEmpty(args[1]))
            {
                boxFileSearch.Text = args[1];
                dataProcessing.ReviewPath(args[1]);
                listResult.Text = dataProcessing.GetResult();
            }
        }
		
		private void Review_Click(object sender, EventArgs e)
		{
			openFileDialog = new OpenFileDialog();

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
                dataProcessing = new DataProcessing();
                dataProcessing.ReviewPath(openFileDialog.FileName);
				boxFileSearch.Text = openFileDialog.FileName;
			}
		}

		private void DataProcessing_Click(object sender, EventArgs e)
		{
			listResult.Text = dataProcessing.GetResult();
		}

	}
}
