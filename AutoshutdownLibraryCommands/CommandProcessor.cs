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
            // Shtoni më shumë komanda sipas nevojave tuaja

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
                    // Kryeni veprimet për komandën "Sleep"
                    break;

                case EComands.SendMessage:
                    // Kryeni veprimet për komandën "SendMessage"
                    break;

                case EComands.SetScreen:
                    // Kryeni veprimet për komandën "SetScreen"
                    break;

                case EComands.ShutDown:
                    // Kryeni veprimet për komandën "ShutDown"
                    break;

                case EComands.SetTimer:
                    // Kryeni veprimet për komandën "SetTimer"
                    break;

                case EComands.CaptureSc:
                    // Kryeni veprimet për komandën "CaptureScreenshot"
                    result = CaptureMyScreen();
                    break;

                case EComands.SendFile:
                    // Kryeni veprimet për komandën "SendFile"
                    break;

                case EComands.RunCommand:
                    // Kryeni veprimet për komandën "RunCommand"
                    break;

                    // Shtoni më shumë raste për komanda të tjera
            }
            return result;
        }

        public byte[] CaptureMyScreen()
        {
            try
            {
                // Krijo një objekt Bitmap për të mbajtur screenshot-in
                Bitmap captureBitmap = new Bitmap(1024, 768, PixelFormat.Format32bppArgb);

                // Krijo një Rectangle objekt që do të përfshijë ekranin aktual
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

                // Krijo një Graphics objekt nga screenshot-i
                using (Graphics captureGraphics = Graphics.FromImage(captureBitmap))
                {
                    // Kopjo ekranin në objektin Bitmap
                    captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                }

                // Përdor MemoryStream për të konvertuar screenshot-in në byte[]
                byte[] screenshotBytes = null;
                using (MemoryStream ms = new MemoryStream())
                {
                    // Ruaj screenshot-in në MemoryStream në formatin e dëshiruar (JPEG në këtë rast)
                    captureBitmap.Save(ms, ImageFormat.Jpeg);

                    // Merr vargun e bajtëve nga MemoryStream
                    screenshotBytes = ms.ToArray();

                    // Dërgo vargun e bajtëve tek klienti
                }
                return screenshotBytes;
                // Mesazh suksesi (nëse kodi arrin këtu)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gabim gjatë shprehjes së screenshot-it: {ex.Message}");
            }
            return null; 
        }

    }
}
