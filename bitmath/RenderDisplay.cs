using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitmath
{
    public partial class RenderDisplay : Form
    {
        public Bitmap BmpToDisplay { get; set; }
        public RenderDisplay(Bitmap b)
        {
            InitializeComponent();
            BmpToDisplay = b;
            ReloadImage();
        }
        public void ReloadImage() => Viewport.Image = BmpToDisplay;
        private void RenderDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
