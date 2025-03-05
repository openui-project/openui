using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Utility = OpenUI.Core.Utility;

namespace OpenUI {
    public partial class ViewPort {
        private Form form;

        public ViewPort(int width, int height, string title) {
            form = new Form
			{
				ClientSize = new Size(width, height),
				Text = title,
				BackColor = Color.Black
		    };
        }

        public void Run() {
			Utility.TraceLog(0, "Starting application...");
            form.Show();
            Application.Run(form);
			Utility.TraceLog(0, "Application terminated.");
        }
    }
}
