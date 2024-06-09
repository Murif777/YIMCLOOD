using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace ENTITY
{
    public class DataGridViewGifCell : DataGridViewImageCell
    {
        private Image _gifImage;
        private FrameDimension _dimension;
        private int _frameCount;
        private int _currentFrame;
        private Timer _timer;
        public DataGridViewGifCell()
        {
            _currentFrame = 0;
            _timer = new Timer();
            _timer.Interval = 100; // Intervalo predeterminado de 100 ms
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }
        public Image GifImage
        {
            get => _gifImage;
            set
            {
                _gifImage = value;
                if (_gifImage != null)
                {
                    _dimension = new FrameDimension(_gifImage.FrameDimensionsList[0]);
                    _frameCount = _gifImage.GetFrameCount(_dimension);
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_gifImage != null)
            {
                _currentFrame = (_currentFrame + 1) % _frameCount;
                _gifImage.SelectActiveFrame(_dimension, _currentFrame);
                DataGridView?.InvalidateCell(this);
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            if (_gifImage != null)
            {
                graphics.DrawImage(_gifImage, cellBounds);
            }
        }

    }

}
