using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Lock
{
    class Capture
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice finalFrame;

        public Capture()
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            finalFrame = new VideoCaptureDevice();
        }
        public void captureImage()
        {
            try
            {
                finalFrame = new VideoCaptureDevice(captureDevice[0].MonikerString);
                finalFrame.NewFrame += new NewFrameEventHandler(finalFrame_NewFrame);
                finalFrame.Start();
            }
            catch
            {
                //if camera is not present on pc
                Process.Start("shutdown", "/s /t 0");
            }
        }
        void finalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                ImageFormat format = ImageFormat.Png;
                Bitmap Image = (Bitmap)eventArgs.Frame.Clone();
                Image.Save("D:\\Unknown_User\\Unknow_user.png", format);
                eventArgs.Frame.Dispose();
                Environment.Exit(0);
                Process.Start("shutdown", "/s /t 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed saving the snapshot.\n" + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
