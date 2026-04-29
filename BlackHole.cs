using System;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class BlackHole : IImpactPoint
    {
        public int Power = 200;       // сила притяжения
        public int EventHorizon = 16; //радиус при котором частицы обнуляются
        public bool Enabled = true;

        // для красивого пульсирующего ореола

        public override void ImpactParticle(Particle particle)
        {
            if (!Enabled) return;
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = gX * gX + gY * gY;

            // если частица внутри горизонта событий убиваем
            if (r2 < EventHorizon * EventHorizon)
            {
                particle.Life = 0;
                return;
            }

            // иначе притягиваем с ограничением 
            float r2safe = Math.Max(100, r2);
            particle.SpeedX += gX * Power / r2safe;
            particle.SpeedY += gY * Power / r2safe;
        }

        public override void Render(Graphics g)
        {
            if (!Enabled) return;

            // внешний "ореол" -- слабый и пульсирующий
            int haloRadius = (int)(EventHorizon * 3);
            using (var halo = new SolidBrush(Color.FromArgb(40, Color.MediumPurple)))
            {
                g.FillEllipse(halo, X - haloRadius, Y - haloRadius, haloRadius * 2, haloRadius * 2);
            }

            // сама "дыра" -- чёрный круг по горизонту событий
            using (var brush = new SolidBrush(Color.Black))
            {
                g.FillEllipse(brush, X - EventHorizon, Y - EventHorizon, EventHorizon * 2, EventHorizon * 2);
            }

            // тонкая белая обводка чтобы было видно на белом фоне
            using (var pen = new Pen(Color.White, 1))
            {
                g.DrawEllipse(pen, X - EventHorizon, Y - EventHorizon, EventHorizon * 2, EventHorizon * 2);
            }
        }
    }
}
