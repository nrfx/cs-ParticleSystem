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

        private void DrawWindCompass(Graphics g)
        {
            int cx = picDisplay.Width - 60;   // правый верхний угол
            int cy = 60;
            int radius = 35;

            // фон кружок
            using (var pen = new Pen(Color.Black, 1))
                g.DrawEllipse(pen, cx - radius, cy - radius, radius * 2, radius * 2);

            // длина и направление вектора ветра
            float wx = emitter.WindX;
            float wy = emitter.WindY;
            float magnitude = (float)Math.Sqrt(wx * wx + wy * wy);

            if (magnitude > 0.01f) 
            {
                float maxLen = radius - 6;
                float scaled = Math.Min(1f, magnitude / 5f);
                float dx = wx / magnitude * maxLen * scaled;
                float dy = wy / magnitude * maxLen * scaled;

                // отрисовка
                using (var pen = new Pen(Color.DarkRed, 3))
                {
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    g.DrawLine(pen, cx, cy, cx + dx, cy + dy); // основные координаты + координаты изменеиня направления ветра
                }
            }
            else
            {
                // штиль точка центровая
                using (var dot = new SolidBrush(Color.Gray))
                    g.FillEllipse(dot, cx - 3, cy - 3, 6, 6);
            }
            using (var f = new Font("Arial", 8, FontStyle.Bold))
            using (var br = new SolidBrush(Color.Black))
            {
                var label = magnitude > 0.01f ? $"ветер {magnitude:0.0}" : "штиль";
                var size = g.MeasureString(label, f);
                g.DrawString(label, f, br, cx - size.Width / 2, cy + radius + 2);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState(); // каждый тик обновляем систему

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g); // рендерим систему
                DrawWindCompass(g);
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

        private void btnWindUp_Click(object sender, EventArgs e)
        {
            if (!windEnabled) return;
            emitter.WindY -= WindStep;
        }

        private void btnWindRight_Click(object sender, EventArgs e)
        {
            if (!windEnabled) return;
            emitter.WindX += WindStep;
        }

        private void btnWindDown_Click(object sender, EventArgs e)
        {
            if (!windEnabled) return;
            emitter.WindY += WindStep;
        }

        private void btnWindLeft_Click(object sender, EventArgs e)
        {
            if (!windEnabled) return;
            emitter.WindX -= WindStep;
        }

        private void btnWindReset_Click(object sender, EventArgs e)
        {
            emitter.WindX = 0;
            emitter.WindY = 0;
        }
    }
}
