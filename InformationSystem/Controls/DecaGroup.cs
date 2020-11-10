using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InformationSystem.Controls
{
    class DecaGroup : Control
    {
        #region Свойства

        #region Label
        public string LabelGroup { get; set; } = "Label group";
        public Font FontLabelGroup { get; set; } = new Font("Arial", 8, FontStyle.Bold);
        public Color ForeColorLabelGroup { get; set; } = Color.Black;
        #endregion
        #region Text
        public string TextGroup
        {
            get => labelText.Text;
            set
            {
                labelText.Text = value;
                Refresh();
            }
        }
        public Font FontTextGroup { get; set; } = new Font("Arial", 8, FontStyle.Regular);
        public Color ForeColorTextGroup { get; set; } = Color.Black;
        #endregion
        public Color BorderColor { get; set; } = FlatColors.Blue;
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

        #region Переменые
        private StringFormat SF = new StringFormat();
        int TopBorderOffset = 0;
        Label labelText = new Label();
        #endregion

        public DecaGroup()
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

            TopBorderOffset = graph.MeasureString(LabelGroup, FontLabelGroup).ToSize().Height / 2;

            Rectangle rect = new Rectangle(BorderElementSize - 1, TopBorderOffset, Width - (int)BorderElementSize, Height - (int)BorderElementSize - TopBorderOffset);
            
            Size LabelGroupRectSize = graph.MeasureString(LabelGroup, FontLabelGroup).ToSize();
            Rectangle rectLabelGroup = new Rectangle(5, 0, LabelGroupRectSize.Width + 3, LabelGroupRectSize.Height);

            // Закругление
            float roundingValue = 0.1F;
            if (RoundingEnable && roundingPercent > 0)
                roundingValue = Height / 100F * roundingPercent;

            GraphicsPath rectPath = Drawer.RoundedRectangle(rect, roundingValue);

            // Контур
            graph.DrawPath(new Pen(BorderColor, BorderElementSize), rectPath);
            graph.DrawRectangle(new Pen(Parent.BackColor), rectLabelGroup);
            graph.FillRectangle(new SolidBrush(Parent.BackColor), rectLabelGroup);

            // Рисование текста заголовка группы
            graph.DrawString(LabelGroup, FontLabelGroup, new SolidBrush(ForeColorLabelGroup), rectLabelGroup, SF);
            // Рисование текста внутри группы
            graph.DrawString(Text, FontTextGroup, new SolidBrush(ForeColorTextGroup), rect, SF);
            
        }
    }
}
