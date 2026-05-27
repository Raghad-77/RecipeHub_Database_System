using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomProgressBar : ProgressBar
{
    public CustomProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = this.ClientRectangle;
        Graphics g = e.Graphics;

        ProgressBarRenderer.DrawHorizontalBar(g, rect);
        rect.Inflate(-3, -3);

        if (this.Value > 0)
        {
            int segmentWidth = rect.Width / this.Maximum; // Calculate the width of each segment

            for (int i = 0; i < this.Value; i++)
            {
                // Get the color for the current segment
                Color segmentColor = GetColorBasedOnSegment(i + 1);
                Rectangle segmentRect = new Rectangle(rect.X + (i * segmentWidth), rect.Y, segmentWidth, rect.Height);

                using (Brush brush = new SolidBrush(segmentColor))
                {
                    g.FillRectangle(brush, segmentRect);
                }
            }
        }
    }

    // Function to return color based on the segment number
    private Color GetColorBasedOnSegment(int segment)
    {
        switch (segment)
        {
            case 1:
                return ColorTranslator.FromHtml("#50C878");
            case 2:
                return Color.GreenYellow;
            case 3:
                return Color.Yellow;
            case 4:
                return Color.Orange;
            case 5:
                return Color.Red;
            default:
                return Color.Gray;
        }
    }
}
