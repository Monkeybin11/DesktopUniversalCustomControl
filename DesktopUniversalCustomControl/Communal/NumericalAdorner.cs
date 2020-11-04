using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace DesktopUniversalCustomControl.Communal
{
    public class NumericalAdorner : AdornerBase
    {
        public NumericalAdorner(UIElement numericalElement) : base(numericalElement)
        {
            
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            var brush = new SolidColorBrush(Colors.BlueViolet);
            var pen = new Pen(brush, 1.5);
            Rect rect = new Rect(this.AdornedElement.DesiredSize);
            drawingContext.DrawEllipse(brush, pen, rect.TopRight, 8, 8);

            AddAdornerElement(AdornedElement);
        }

        protected override void AddAdornerElement(UIElement element)
        {
            base.AddAdornerElement(element);
        }
    }
}
