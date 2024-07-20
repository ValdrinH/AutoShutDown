using AutoShutdownWinForm.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShutdownWinForm.Classes
{
    public class FormInterpretorClass
    {
        public static Form1 form_;
        public static List<DeviceControl> devices_ = new List<DeviceControl>();

        public static void AddTextToMessage(string Message)
        {
            form_.Invoke((MethodInvoker)delegate
            {
                form_.box.Text += Message + "\n";
            });
        }
        public static void ClearMessage(string Message)
        {
            form_.box.Text = "";
        }
        public static void AddElementToBodyPanel(UserControl userControl)
        {
            form_.Invoke((MethodInvoker)delegate {
                form_.BodyElements.Controls.Add(userControl);
                }
            );
        }
        public static void RemoveElementToBodyPanel(UserControl userControl)
        {
            form_.Invoke((MethodInvoker)delegate {
                form_.BodyElements.Controls.Remove(userControl);
            }
            );
        }
        public static void ClearElementToBodyPanel()
        {
            form_.Invoke((MethodInvoker)delegate {
                    form_.BodyElements.Controls.Clear();
                    devices_.Clear();
                 }
            );
        }

        public static DialogResult dialogResult(UserControl userControl)
        {
            UseForm useForm = new UseForm(userControl);
            return useForm.ShowDialog();
        }
    }
}
