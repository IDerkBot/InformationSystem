using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InformationSystem.Controls
{
    class DecaButton : Control
    {
        #region Свойства

        public bool Fill { get; set; } = false;
        public int BorderElementSize { get; set; } = 1;

        private bool roundingEnable = false;
        [Description("On/Off rounding")]
        public bool RoundingEnable
        {
            get => roundingEnable;
            set
            {
                roundingEnable = value;
                Refresh();
            }
        }

        private int roundingPercent = 100;
        [DisplayName("Rounding")]
        [Description("Rounding percent")]
        [DefaultValue(100)]
        public int Rounding
        {
            get => roundingPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    roundingPercent = value;
                    Refresh();
                }
            }
        }

        #endregion

        #region Переменные

        private StringFormat SF = new StringFormat();
        private bool MouseEntered = false;
        private bool MousePressed = false;

        #endregion


        public DecaButton()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);
            DoubleBuffered = true;

            Size = new Size(100, 30);

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graph = e.Graphics;
            graph.SmoothingMode = SmoothingMode.HighQuality;

            graph.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(BorderElementSize - 1, BorderElementSize - 1, Width - (int)BorderElementSize, Height - (int)BorderElementSize);

            // Закругление
            float roundingValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
                roundingValue = Height / 100F * roundingPercent;

            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);

            // Контур
            graph.DrawPath(new Pen(BackColor, BorderElementSize), rectPath);

            // Заливка
            if (Fill)
                graph.FillPath(new SolidBrush(BackColor), rectPath);

            graph.SetClip(rectPath);

            // Наведение мыши
            if (MouseEntered)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(60, Color.White)), rect);
                if (Fill)
                    graph.FillRectangle(new SolidBrush(Color.FromArgb(60, Color.White)), rect);
            }

            // Нажатие мыши
            if (MousePressed)
            {
                graph.DrawRectangle(new Pen(Color.FromArgb(30, Color.Black)), rect);
                if (Fill)
                    graph.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), rect);
            }

            // Рисование текста
            graph.DrawString(Text, Font, new SolidBrush(ForeColor), rect, SF);
        }

        #region MouseEvent

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseEntered = true;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseEntered = false;
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePressed = true;
            Invalidate();
            Focus();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MousePressed = false;
            Invalidate();
        }

        #endregion

    }
}
