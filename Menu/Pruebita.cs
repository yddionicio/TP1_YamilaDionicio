using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Pruebita : Form
    {
        public Pruebita()
        {
            InitializeComponent();
        }

        private void Pruebita_Load(object sender, EventArgs e)
        {
            // Ruta del archivo de video
           // string videoPath = "ruta_del_video/video.mp4";

            // Establecer la ruta del archivo de video en el control AxWindowsMediaPlayer
            //axWindowsMediaPlayer1.URL = videoPath;

            // Reproducir el video en bucle
            //axWindowsMediaPlayer1.settings.setMode("loop", true);
        }
    }
}
