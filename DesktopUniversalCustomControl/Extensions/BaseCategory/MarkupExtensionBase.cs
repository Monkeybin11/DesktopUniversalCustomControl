using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace DesktopUniversalCustomControl.Extensions.BaseCategory
{
    /// <summary>
    /// 为可以由.NET Framework XAML服务及其他XAML读取器和XAML编写器支持的XAML标记扩展实现提供基类。
    /// </summary>
    public class MarkupExtensionBase : MarkupExtension
    {
        public MarkupExtensionBase()
        {

        }

        public override object ProvideValue(IServiceProvider serviceProvider) => this;
    }

    /// <summary>
    /// 为可以由.NET Framework XAML服务及其他XAML读取器和XAML编写器支持的XAML标记扩展实现提供基类。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MarkupExtensionBase<T> : MarkupExtension 
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var obj = serviceProvider.GetService(typeof(T));

            return this;
        }
    }
}
