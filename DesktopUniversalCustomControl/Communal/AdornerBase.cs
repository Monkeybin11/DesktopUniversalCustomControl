using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace DesktopUniversalCustomControl.Communal
{
    /// <summary>
    /// 表示装饰器的基类
    /// </summary>
    public class AdornerBase : Adorner
    {
        public AdornerBase(UIElement adornedElement) : base(adornedElement)
        {
            AddAdornerElement(adornedElement);
        }

        protected virtual void AddAdornerElement(UIElement element)
        {
            var layer = AdornerLayer.GetAdornerLayer(element);
            layer.Add(new AdornerBase(element));
        }
    }
}
