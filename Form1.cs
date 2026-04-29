using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        RadarPoint radar;
        BlackHole blackHole;
        Emitter emitter;
        List<Emitter> emitters = new List<Emitter>();
        private int MousePositionX = 0;
        private int MousePositionY = 0;
        const float WindStep = 0.2f;
        bool windEnabled = true;
        /*GravityPoint point1; // добавил поле под первую точку
        GravityPoint point2; // добавил поле под вторую точку*/

        public Form1()
        {
            InitializeComponent();

            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            this.emitter = new Emitter // создаю эмиттер и привязываю его к полю emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter); // все равно добавляю в список emitters, чтобы он рендерился и обновлялся

            /*point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };*/

            // привязываем поля к эмиттеру
            /*emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);*/

            radar = new RadarPoint // последний чтобы маркировка не сбрасывалась другими точками 
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                Radius = 80,
            };
            emitter.impactPoints.Add(radar);
            blackHole = new BlackHole
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2 + 100,
                Power = 200
            };
            emitter.impactPoints.Add(blackHole);

            // колесо мыши - меняем радиус радара
            // PictureBox сам события колеса не получает, поэтому подписываемся на форму
            this.MouseWheel += Form1_MouseWheel;

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // если ветер выключен галочкой ничего не делается
            if (!windEnabled && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right
                              || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down))
            {
                return;
            }

            switch (e.KeyCode)
            {
                case Keys.Left: emitter.WindX -= WindStep; break;
                case Keys.Right: emitter.WindX += WindStep; break;
                case Keys.Up: emitter.WindY -= WindStep; break;
                case Keys.Down: emitter.WindY += WindStep; break;
                case Keys.Space: // пробел -- штиль
                    emitter.WindX = 0;
                    emitter.WindY = 0;
                    break;
            }
        }
        private void cbWind_CheckedChanged(object sender, EventArgs e)
        {
            windEnabled = cbWind.Checked;
            if (!windEnabled)
            {
                emitter.WindX = 0;
                emitter.WindY = 0;
            }
        }

        private void cbBlackHole_CheckedChanged(object sender, EventArgs e)
        {
            blackHole.Enabled = cbBlackHole.Checked;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // каждый тик обновляем систему

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g); // рендерим систему
            }

            picDisplay.Invalidate();
        }
        private void Form1_MouseWheel(object sender, MouseEventArgs e)
        {
            int step;
            if (e.Delta > 0)
            {
                step = 10;
            }
            else
            {
                step = -10;
            }
            radar.Radius = Math.Max(radar.RadiusMin, Math.Min(radar.RadiusMax, radar.Radius + step));
        }
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                emitter.MousePositionX = e.X;
                emitter.MousePositionY = e.Y;

                if (radar != null) // следование за курсором
                {
                    radar.X = e.X;
                    radar.Y = e.Y;
                }
            }

            // а тут передаем положение мыши, в положение гравитона
            /*point2.X = e.X;
            point2.Y = e.Y;*/
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value; // направлению эмиттера присваиваем значение ползунка 
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbSpread_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpread.Value;
        }
    }
}
