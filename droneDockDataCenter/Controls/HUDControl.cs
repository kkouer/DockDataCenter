using System;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace droneDockDataCenter.Controls
{
    public class HUDControl : Control
    {
        private float pitchAngle;
        private float rollAngle;
        private float yawAngle;
        private int airspeed;
        private int altitude;

        public HUDControl()
        {
            // 启用双缓冲
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);


            // 设置控件大小为正方形，确保宽度和高度相等
            this.Width = 200;
            this.Height = 200;

            // 创建圆形的 GraphicsPath
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(ClientRectangle);

            // 将圆形 GraphicsPath 设置为控件的 Region
            this.Region = new Region(path);

            // 初始化飞行器姿态、空速和高度
            pitchAngle = 0;
            airspeed = 0;
            altitude = 0;
            rollAngle = 0;
            yawAngle = 0;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // 当控件大小改变时，更新圆形的 Region
            UpdateCircularRegion();
        }

        private void UpdateCircularRegion()
        {
            // 创建圆形的 GraphicsPath
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(ClientRectangle);

            // 将圆形 GraphicsPath 设置为控件的 Region
            this.Region = new Region(path);
        }


        public float PitchAngle
        {
            get { return pitchAngle; }
            set { pitchAngle = value; Invalidate(); }
        }

        public float RollAngle { get { return rollAngle; } set { rollAngle = value; Invalidate(); } }
        public float YawAngle { get { return yawAngle; } set { yawAngle = value; Invalidate(); } }

        public int Airspeed
        {
            get { return airspeed; }
            set { airspeed = value; Invalidate(); }
        }

        public int Altitude
        {
            get { return altitude; }
            set { altitude = value; Invalidate(); }
        }

        // 圆形控件的绘制方法
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;  // 启用抗锯齿
            //g.TextRenderingHint = TextRenderingHint.AntiAlias;  // 启用文本抗锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;  // 设置插值模式
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;  // 设置像素偏移模式





            DrawSkyGround(g);
            // 绘制飞行器姿态刻度、数值、空速和高度
            DrawPitch(g);
            DrawYawIndicator(g);
            DrawAirspeedAltitude(g);

            // 绘制外围的白色背景圆
            DrawOuterWhiteCircle(g);
        }

        private void DrawOuterWhiteCircle(Graphics g)
        {
            using (Pen whitePen = new Pen(Color.Black, 5))
            {
                g.DrawEllipse(whitePen, ClientRectangle);
            }
        }

        private void DrawYawIndicator(Graphics g)
        {
            float centerX = ClientSize.Width / 2f;
            float centerY = ClientSize.Height / 2f;
            float circleRadius = Math.Min(ClientSize.Width, ClientSize.Height) / 2f - 10; // 半径减去一些空间用于显示刻度

            float indicatorLength = 0; // 调整刻度指示器的长度
            float arrowSize = 5; // 箭头大小
            float arrowDistance = 5; // 调整箭头离边缘的距离

            // 将角度映射到 0 到 360 范围内
            float normalizedYaw = (YawAngle % 360 + 360) % 360;

            // 将角度转换为弧度
            float angleInRadians = (normalizedYaw - 90) * (float)Math.PI / 180.0f; // 将0度对应到中间竖直向上

            // 计算刻度指示器的起点和终点
            float endX = centerX + (circleRadius - indicatorLength) * (float)Math.Cos(angleInRadians); // 调整为15是指示线段的长度
            float endY = centerY + (circleRadius - indicatorLength) * (float)Math.Sin(angleInRadians); // 调整为15是指示线段的长度

            // 计算箭头的两个点
            float arrow1X = endX + (arrowSize + arrowDistance) * (float)Math.Cos(angleInRadians + 135 * Math.PI / 180); // 135度表示箭头的一个方向
            float arrow1Y = endY + (arrowSize + arrowDistance) * (float)Math.Sin(angleInRadians + 135 * Math.PI / 180);
            float arrow2X = endX + (arrowSize + arrowDistance) * (float)Math.Cos(angleInRadians - 135 * Math.PI / 180); // -135度表示箭头的另一个方向
            float arrow2Y = endY + (arrowSize + arrowDistance) * (float)Math.Sin(angleInRadians - 135 * Math.PI / 180);

            // 创建箭头路径
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddLine(endX, endY, arrow1X, arrow1Y);
                path.AddLine(endX, endY, arrow2X, arrow2Y);

                // 绘制箭头，这里用红色表示
                using (Pen pen = new Pen(Color.Red, 2))
                {
                    g.DrawPath(pen, path);
                }
            }

            int numTicks = 12; // 调整刻度数量
            int tickLength = 2;
            // 绘制刻度
            using (Pen tickPen = new Pen(Color.Black, 2))
            {
                for (int i = 0; i < numTicks; i++)
                {
                    float tickAngle = i * 360f / numTicks;
                    float tickX1 = centerX + circleRadius * (float)Math.Cos((tickAngle - 90) * Math.PI / 180);
                    float tickY1 = centerY + circleRadius * (float)Math.Sin((tickAngle - 90) * Math.PI / 180);
                    float tickX2 = centerX + (circleRadius - tickLength) * (float)Math.Cos((tickAngle - 90) * Math.PI / 180); // 调整为5是刻度的长度
                    float tickY2 = centerY + (circleRadius - tickLength) * (float)Math.Sin((tickAngle - 90) * Math.PI / 180); // 调整为5是刻度的长度
                    g.DrawLine(tickPen, tickX1, tickY1, tickX2, tickY2);
                }
            }
        }


        private void DrawSkyGround(Graphics g)
        {
            float centerX = ClientSize.Width / 2f;
            float centerY = ClientSize.Height / 2f;

            // 计算控件的对角线长度
            float diagonalLength = (float)Math.Sqrt(ClientSize.Width * ClientSize.Width + ClientSize.Height * ClientSize.Height);

            // 计算绘制天地线时的旋转角度，取相反数
            float rotationRoll = -rollAngle % 360;
            float rotationPitch = pitchAngle % 360;

            // 以控件中心为中心点旋转绘图坐标系
            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(rotationRoll);
            //g.RotateTransform(rotationPitch, MatrixOrder.Append); // 注意顺序

            g.TranslateTransform(-centerX, -centerY);

            // 计算垂直位移，根据 pitchAngle 移动
            float pitchOffset = centerY * pitchAngle / 60.0f;

            // 使用线性渐变笔刷绘制天地线
            LinearGradientBrush skyBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, (int)(centerY * 3 + pitchOffset)), Color.FromArgb(39, 212, 229), Color.LightBlue);
            LinearGradientBrush groundBrush = new LinearGradientBrush(new Point(0, 0), new Point(0, (int)(centerY * 3 + pitchOffset)), Color.FromArgb(207, 156, 93), Color.Yellow);


            // 绘制天
            g.FillRectangle(skyBrush, -ClientSize.Width * 2, -ClientSize.Height + pitchOffset, ClientSize.Width * 4, centerY * 3);

            // 绘制地
            g.FillRectangle(groundBrush, -ClientSize.Width, centerY + pitchOffset, ClientSize.Width * 4, centerY * 3);



            // 还原绘图坐标系
            g.ResetTransform();
        }
        private void DrawPitch(Graphics g)
        {
            float centerX = ClientSize.Width / 2f;
            float centerY = ClientSize.Height / 2f;
            float length = Math.Min(ClientSize.Width, ClientSize.Height) / 2f - 10;

            // 绘制飞行器姿态数值
            using (Font font = new Font("微软雅黑", 10))
            {
                // 绘制 Pitch 数值
                string pitchText = $"Pitch: {pitchAngle:F2}°";
                SizeF pitchTextSize = g.MeasureString(pitchText, font);
                PointF pitchTextLocation = new PointF(centerX - pitchTextSize.Width / 2, (float)(centerY - pitchTextSize.Height * 1.5));

                // 绘制黑色阴影
                pitchTextLocation = new PointF(pitchTextLocation.X + 1, pitchTextLocation.Y + 1);
                g.DrawString(pitchText, font, Brushes.Black, pitchTextLocation);

                pitchTextLocation = new PointF(pitchTextLocation.X - 1, pitchTextLocation.Y - 1);

                // 绘制 Pitch 数值
                g.DrawString(pitchText, font, Brushes.White, pitchTextLocation);

                // 绘制 Roll 数值
                string rollText = $"Roll: {rollAngle:F2}°";
                SizeF rollTextSize = g.MeasureString(rollText, font);
                PointF rollTextLocation = new PointF(centerX - rollTextSize.Width / 2, (float)(centerY + rollTextSize.Height * 1.5));  // 调整位置

                // 绘制黑色阴影
                rollTextLocation = new PointF(rollTextLocation.X + 1, rollTextLocation.Y + 1);
                g.DrawString(rollText, font, Brushes.Black, rollTextLocation);

                rollTextLocation = new PointF(rollTextLocation.X - 1, rollTextLocation.Y - 1);

                // 绘制 Roll 数值
                g.DrawString(rollText, font, Brushes.White, rollTextLocation);
            }
        }

        private void DrawAirspeedAltitude(Graphics g)
        {
            // 获取空速和高度数值文本
            string airspeedText = $"AS: {airspeed} m/s";
            string altitudeText = $"Alt: {altitude} m";

            // 使用相同的字体
            using (Font font = new Font("微软雅黑", 10))
            {
                // 计算空速和高度文本的大小
                SizeF airspeedSize = g.MeasureString(airspeedText, font);
                SizeF altitudeSize = g.MeasureString(altitudeText, font);

                // 计算控件中间位置
                float centerX = ClientSize.Width / 2f;
                float centerY = ClientSize.Height / 2f;

                // 计算空速和高度文本的位置，使其居中显示
                PointF airspeedLocation = new PointF(centerX - airspeedSize.Width / 2, centerY - airspeedSize.Height / 2);
                PointF altitudeLocation = new PointF(centerX - altitudeSize.Width / 2, centerY + altitudeSize.Height / 2);

                // 绘制黑色阴影
                airspeedLocation = new PointF(airspeedLocation.X + 1, airspeedLocation.Y + 1);
                altitudeLocation = new PointF(altitudeLocation.X + 1, altitudeLocation.Y + 1);
                g.DrawString(airspeedText, font, Brushes.Black, airspeedLocation);
                g.DrawString(altitudeText, font, Brushes.Black, altitudeLocation);
                // 绘制空速和高度数值
                airspeedLocation = new PointF(airspeedLocation.X - 1, airspeedLocation.Y - 1);
                altitudeLocation = new PointF(altitudeLocation.X - 1, altitudeLocation.Y - 1);
                g.DrawString(airspeedText, font, Brushes.White, airspeedLocation);
                g.DrawString(altitudeText, font, Brushes.White, altitudeLocation);
            }
        }
    }
}