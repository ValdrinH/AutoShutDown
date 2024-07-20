using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static AutoshutdownLibraryCommands.CommandProcessor;

namespace AutoshutdownLibraryCommands
{
    public class CommandProcessor
    {
        public List<Commands> Commands = new List<Commands>();
        public CommandProcessor()
        {
            Commands.Add(new Commands() { _CommandName = "Sleep" });
            Commands.Add(new Commands() { _CommandName = "SendMessage" });
            Commands.Add(new Commands() { _CommandName = "SetScreen" });
            Commands.Add(new Commands() { _CommandName = "ShutDown" });
            Commands.Add(new Commands() { _CommandName = "SetTimer" });
            Commands.Add(new Commands() { _CommandName = "CaptureScreenshot" });
            Commands.Add(new Commands() { _CommandName = "SendFile" });
            Commands.Add(new Commands() { _CommandName = "RunCommand" });
   

        }

        public enum EComands
        {
            Sleep,SendMessage,SetScreen,ShutDown,SetTimer,CaptureSc,SendFile,RunCommand
        }

        public object ProcessWork(EComands eComands,object  value = null)
        {
            object result = null;
            switch (eComands)
            {
                case EComands.Sleep:
         
                    break;

                case EComands.SendMessage:
            
                    break;

                case EComands.SetScreen:
            
                    break;

                case EComands.ShutDown:
             
                    break;

                case EComands.SetTimer:
            
                    break;

                case EComands.CaptureSc:
           
                    result = CaptureMyScreen();
                    break;

                case EComands.SendFile:
          
                    break;

                case EComands.RunCommand:
            
                    break;

            }
            return result;
        }

        public byte[] CaptureMyScreen()
        {
            try
            {
          
                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);

           
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;


                using (Graphics captureGraphics = Graphics.FromImage(captureBitmap))
                {

                    captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                }

       
                byte[] screenshotBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    // Ruaj screenshot-in në MemoryStream në formatin  (JPEG në këtë rast)
                    captureBitmap.Save(ms, ImageFormat.Jpeg);

                    // Merr vargun e bajtëve nga MemoryStream
                    screenshotBytes = ms.ToArray();


                }
                return screenshotBytes;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë shprehjes së screenshot-it: {ex.Message}");
            }
            return null; 
        }

    }
}
