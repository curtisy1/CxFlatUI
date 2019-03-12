using CxFlatUI.Controls;
using CxFlatUI.CustomTypes;
using CxFlatUI.Interfaces;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;


namespace CxFlatUI
{
    public class CxFlatGroupBox : GroupBox
    {
        #region 属性

        [RefreshProperties(RefreshProperties.Repaint)]
        public Color ThemeColor { get; set; } = ThemeColors.PrimaryColor;

        [Description("是否显示控件文本")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public bool ShowText { get; set; } = false;

        [Description("移动硬盘驱动器")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public IHeaderStyle HeaderStyle { get; set; } = new HeaderStyle(new CustomDrawLine(new Pen(ThemeColors.OneLevelBorder, 1), 0, 38, 0, 38), new CustomRectangleF(15, 0, 0, 38), new Font("微软雅黑", 12F), new SolidBrush(ThemeColors.MainText), StringAlign.TopCenter);

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.HighQuality;//消除锯齿
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;//高质量显示
            graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;//最高质量显示文本
            graphics.Clear(Parent.BackColor);

            var BG = DrawHelper.CreateRoundRect(1, 1, Width - 2, Height - 2, 3);
            graphics.FillPath(new SolidBrush(BackColor), BG);
            graphics.DrawPath(new Pen(ThemeColors.OneLevelBorder), BG);

            if (ShowText)
            {
                graphics.DrawLine(HeaderStyle.DrawLine.Pen, HeaderStyle.DrawLine.X1, HeaderStyle.DrawLine.Y1, Width, HeaderStyle.DrawLine.Y2);
                graphics.DrawString(Text, HeaderStyle.HeaderFont, HeaderStyle.HeaderColor, new RectangleF(HeaderStyle.HeaderSize.X, HeaderStyle.HeaderSize.Y, Width - 50, HeaderStyle.HeaderSize.Height), HeaderStyle.HeaderAlignment);
            }
        }

        public CxFlatGroupBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12);
        }

        public CxFlatGroupBox(Font font)
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Font = font;
        }
    }
}