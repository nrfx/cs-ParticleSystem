using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RadarPoint : IImpactPoint
    {
        public int Radius = 80;
        public int RadiusMin = 20, RadiusMax = 400;

        private readonly List<Particle> insideThisFrame = new List<Particle>();

        public int CountTotal;
        public int SmallMaxRadius = 4, MediumMaxRadius = 8;
        public override void BeforeUpdate()
        {
            CountTotal = 0;
        }

        public override void ImpactParticle(Particle particle)
        {
            // радар на саму частицу не действует физически --
            // только проверяем попадание в круг
            float dx = X - particle.X;
            float dy = Y - particle.Y;
            float r2 = dx * dx + dy * dy;

            if (r2 <= Radius * Radius)
            {
                insideThisFrame.Add(particle);
                CountTotal++;
            }
        }

        public override void Render(Graphics g)
        {

            foreach (var p in insideThisFrame)
            {
                float k = Math.Min(1f, p.Life / 100f);
                int alpha = (int)(k * 255);
                if (alpha < 0) alpha = 0;
                if (alpha > 255) alpha = 255;

                using (var brush = new SolidBrush(Color.FromArgb(alpha, Color.LimeGreen)))
                {
                    g.FillEllipse(brush, p.X - p.Radius, p.Y - p.Radius, p.Radius * 2, p.Radius * 2);
                }
            }

            // окружность радара
            using (var pen = new Pen(Color.LimeGreen, 2))
            {
                g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }

            // полупрозрачная заливка чтобы зона была заметнее
            using (var fill = new SolidBrush(Color.FromArgb(40, Color.LimeGreen)))
            {
                g.FillEllipse(fill, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }

            var text = $"{CountTotal}";

            using (var font = new Font("Arial", 11, FontStyle.Bold))
            using (var brush = new SolidBrush(Color.Black))
            {
                var size = g.MeasureString(text, font);
                g.DrawString(text, font, brush, X - size.Width / 2, Y - size.Height / 2);
            }
            insideThisFrame.Clear();
            CountTotal = 0;
        }
    }
}