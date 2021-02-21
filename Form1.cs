using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ookii.Dialogs.WinForms;

namespace CSharp_FrameExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //This is the default starting code.
            InitializeComponent();
        }

        #region Drag and drops
        private void VideoPathDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;           //This tests if the user dropped anything.
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);    //Converts the items dropped into a string array.

            foreach (var file in files)
            {
                //This bit of code just checks if the file extendtion is or isn't .mp4
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".mp4", StringComparison.CurrentCultureIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy;
                    VideoPath.Text = file;          //Sets the path to the dropped video in the textbox
                }
            }
        }

        private void OutputFolderPathDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;           //This tests if the user dropped anything.
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);    //Converts the items dropped into a string array.
            foreach (var file in files)
            {
                //Checks if the selected folder exists or not.
                var ext = System.IO.Path.GetExtension(file);
                if (Directory.Exists(file))
                {
                    e.Effect = DragDropEffects.Copy;
                    OutputFolderPath.Text = file;
                }
            }
        }

        private void Drags_DragEnter(object sender, DragEventArgs e)
        {
            //A bit of code straight copied from stackoverflow.
            //This code just makes the drop-fields, accept drops.
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        #endregion

        #region Path selection using dialogs
        private void VideoPathChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();      //Creates an dialog instance

            openFileDialog1.InitialDirectory = "c:\\";                                                                          //Sets the starting directory when the dialog starts
            openFileDialog1.Filter = "Video file (*.mp4)|*.mp4|Other Accord and FFMPEG compatible formats (*.*)|*.*";           //Sets which file extendtions the dialog accepts.
            openFileDialog1.FilterIndex = 0;                                                                                    //I dont even know what this is.
            openFileDialog1.RestoreDirectory = true;                                                                            //TBH this is some code i copied from stackoverflow.

            //Shows the dialog and if the user selected an item then it will set the videopath textbox to the correct path of the selected item.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                VideoPath.Text = openFileDialog1.FileName;
            }
        }

        private void OutputFolderPathChoose_Click(object sender, EventArgs e)
        {
            //Basically the same code as above but i choose to use Ookii.Dialogs.WinForms because this dialog looks much much better than the default folder selector from C# winforms
            VistaFolderBrowserDialog vistaFolderBrowserDialog = new VistaFolderBrowserDialog();

            if (vistaFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                OutputFolderPath.Text = vistaFolderBrowserDialog.SelectedPath;
            }
        }

        #endregion

        private void StartExtraction_Click(object sender, EventArgs e)
        {
            if (Program.GetTotalFrames() > 0 ||             //Checks if the selected video is valid and contains atleast a single frame.
                Directory.Exists(OutputFolderPath.Text))    //Checks if the selected folder exists.
            {
                //Copies the paths to the Program class in Program.cs
                Program.InPath = VideoPath.Text;
                Program.OutPath = OutputFolderPath.Text;

                //Checks if the program should do it in this single process or to launch multiple processes.
                if (NumberOfProcesses.Value > 1)
                {
                    //Starts the method that launches multiple processes
                    Program.StartMultiTread(Convert.ToInt32(NumberOfProcesses.Value));
                }
                else
                {
                    //Starts a new task that extracts the frames.
                    //I made it start another task so the UI didn't freaze when extracting.
                    Task.Run(() => Program.ExtractFramesSingleProcess());
                }
            }
        }

        private void VideoPath_TextChanged(object sender, EventArgs e)
        {
            //This looks at the selected video and checks how many frames it contains
            Program.InPath = VideoPath.Text;
            TotalNumberOfFrames.Text = $"Total frames: About {Program.GetTotalFrames()}";
        }
    }
}
