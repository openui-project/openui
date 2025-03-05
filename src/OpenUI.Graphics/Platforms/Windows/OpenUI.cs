using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
			form.Show();
            Application.Run(form);
        }
    }
}
