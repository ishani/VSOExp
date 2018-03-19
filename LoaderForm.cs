using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VSOExp
{
    public partial class LoaderForm : Form
    {
        public LoaderForm()
        {
            InitializeComponent();
        }

        private async void hwLoadPrepro_Click( object sender, EventArgs e )
        {
            if ( hwOpenFilePrepro.ShowDialog() == DialogResult.OK )
            {
                hwProgress.Visible = true;

                ParsedPreprocessorOutput ppOutput = new ParsedPreprocessorOutput();
                await Task.Run( () => ppOutput.ParseFromFile( hwOpenFilePrepro.FileName ) );

                hwProgress.Visible = false;

                PreproForm ppForm = new PreproForm(ppOutput);
                ppForm.Text = hwOpenFilePrepro.FileName;
                ppForm.Show();
            }
        }

        private async void hwLoadLayout_Click( object sender, EventArgs e )
        {
            if ( hwOpenFileLayout.ShowDialog() == DialogResult.OK )
            {
                hwProgress.Visible = true;
                hwProgress.Refresh();

                // load in the background as these files can be enormous and the parse can take a while
                LayoutLoader layoutLoader = new LayoutLoader();
                await Task.Run( () => layoutLoader.ParseFromFile( hwOpenFileLayout.FileName ) );

                hwProgress.Visible = false;

                LayoutLoaderOutput llOutput = layoutLoader.Result;

                LayoutForm loForm = new LayoutForm(llOutput);
                loForm.Text = hwOpenFileLayout.FileName;
                loForm.Show();
            }
        }
    }
}
