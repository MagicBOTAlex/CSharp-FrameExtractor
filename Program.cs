using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using Accord.Video.FFMPEG;
using System.Diagnostics;

namespace CSharp_FrameExtractor
{
    static class Program
    {
        public static string InPath, OutPath;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Default code that im not touching.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// This launches how many processes the user selected.
        /// </summary>
        /// <param name="Processes">How many process to start at once</param>
        public static void StartMultiTread(int Processes)
        {
            //Gets how many frames in the video and saves it to memory for faster access.
            int TotalFrames = GetTotalFrames();
            Console.WriteLine($"Total frames: {TotalFrames}\n");

            //some old code but still good to have a failsafe.
            if (Processes > TotalFrames)
            {
                Console.WriteLine($"Too many processes. Setting processes equal to total video frames.\n");
                Processes = TotalFrames;
            }

            //As the name says. Frames per process.
            int FramesPerProcess = TotalFrames / Processes;

            //Sets the ranges that each process will render with a little wiggle room
            FrameRange[] frameRangePerProcess = new FrameRange[Processes];
            int FramesStartedRendering = 0;
            for (int i = 0; i < frameRangePerProcess.Length; i++)
            {
                //Special condition for the last process frame range
                if (i == frameRangePerProcess.Length - 1)
                {
                    //Sets the last process with all the last frames.
                    frameRangePerProcess[i].StartFrame = FramesStartedRendering - 10;
                    frameRangePerProcess[i].EndFrame = TotalFrames;
                }
                else if (i == 0)
                {
                    frameRangePerProcess[i].StartFrame = FramesStartedRendering;
                    FramesStartedRendering += FramesPerProcess;
                    frameRangePerProcess[i].EndFrame = FramesStartedRendering + 10;
                }
                else
                {
                    frameRangePerProcess[i].StartFrame = FramesStartedRendering - 10;
                    FramesStartedRendering += FramesPerProcess;
                    frameRangePerProcess[i].EndFrame = FramesStartedRendering + 10;
                }
            }

            //The actual process launcher.
            for (int i = 0; i < frameRangePerProcess.Length; i++)
            {
                Console.WriteLine($"Process {i}: \nStart frame: {frameRangePerProcess[i].StartFrame} \nEnd frame: {frameRangePerProcess[i].EndFrame}\n");

                //I had to create new int values for some unknown reason. It just didn't work without making new integers.
                int SF = frameRangePerProcess[i].StartFrame;
                int EF = frameRangePerProcess[i].EndFrame;
                Task.Run(() => TheActualStart(SF, EF, i));  //Running a new task so the rest doesn't wait until the whole code was executed.
            }
        }

        /// <summary>
        /// The actual multi-process launcher
        /// </summary>
        /// <param name="StartFrame">First rendering frame</param>
        /// <param name="EndFrame">Last rendering frame</param>
        /// <param name="i">Which process it is (For better organization)</param>
        private static void TheActualStart(int StartFrame, int EndFrame, int i)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"ImageExtractionProcess.exe");       //Creates a process info called "startInfo"

            startInfo.Arguments = $"{InPath.Replace(' ', '⇥')} {OutPath.Replace(' ', '⇥')} {StartFrame} {EndFrame} {i}"; //Sets the arguments for when the process launches and replaces spaces with a random unicode so spaces in paths are allowed.

            Console.WriteLine($"Sending args: {InPath.Replace(' ', '⇥')} {OutPath.Replace(' ', '⇥')} {StartFrame} {EndFrame} {i}");
            Process.Start(startInfo);       //Starts the .exe process with those arguments.
        }

        /// <summary>
        /// Use this if you want to extract using the same process as the form.
        /// </summary>
        public static void ExtractFramesSingleProcess()
        {
            using (var vFReader = new VideoFileReader())//I think this creates a new empty video stream
            {
                vFReader.Open(InPath); //This selects the video as the video stream

                for (int i = 1; i < vFReader.FrameCount - 2; i++)
                {
                    try
                    {
                        Bitmap bmpBaseOriginal = vFReader.ReadVideoFrame(i);            //Reads the i frame and saves the frame to bmpBaseOriginal
                        bmpBaseOriginal.Save(OutPath + $@"\{i}.png", ImageFormat.Png);  //Saves the frame at the output folder
                        bmpBaseOriginal.Dispose();                                      //Disposes the image to save memory space
                    }
                    catch (ArgumentNullException e) //Made this so it crashes less
                    {
                        Console.WriteLine(e);
                    }
                    catch
                    {
                        Console.WriteLine($"Frame \"{i}\" failed to save. Trying again...");

                        try
                        {
                            Bitmap SecondTry = vFReader.ReadVideoFrame(i);              //Reads the i frame and saves the frame to SecondTry
                            SecondTry.Save(OutPath + $@"\{i}.png", ImageFormat.Png);    //Saves the frame at the output folder
                            SecondTry.Dispose();                                        //Disposes the image to save memory space
                            Console.WriteLine("Second attempt success.\n");
                        }
                        catch
                        {
                            Console.WriteLine($"Second save attempt of frame \"{i}\" failed to save.\n");
                        }
                    }
                }
                vFReader.Close();   //Closes the video stream object.
            }
        }

        /// <summary>
        /// Just a basic way to check how many frames the video contains
        /// </summary>
        /// <returns>If successful then it will return the total frames of the video. If not successful then it will return 0</returns>
        public static int GetTotalFrames()
        {
            try
            {
                using (var vFReader = new VideoFileReader())
                {
                    vFReader.Open(InPath);
                    return Convert.ToInt32(vFReader.FrameCount);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        /// <summary>
        /// Just here is make things a little nicer to look at.
        /// </summary>
        public struct FrameRange
        {
            public int StartFrame;
            public int EndFrame;
        }
    }
}
