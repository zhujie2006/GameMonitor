using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace GamePlayMonitor.Control.CommonControls
{
    /// <summary>
    /// 按照步骤 1a 或 1b 操作，然后执行步骤 2 以在 XAML 文件中使用此自定义控件。
    ///
    /// 步骤 1a) 在当前项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:GamePlayMonitor.Control"
    ///
    ///
    /// 步骤 1b) 在其他项目中存在的 XAML 文件中使用该自定义控件。
    /// 将此 XmlNamespace 特性添加到要使用该特性的标记文件的根 
    /// 元素中:
    ///
    ///     xmlns:MyNamespace="clr-namespace:GamePlayMonitor.Control;assembly=GamePlayMonitor.Control"
    ///
    /// 您还需要添加一个从 XAML 文件所在的项目到此项目的项目引用，
    /// 并重新生成以避免编译错误:
    ///
    ///     在解决方案资源管理器中右击目标项目，然后依次单击
    ///     “添加引用”->“项目”->[浏览查找并选择此项目]
    ///
    ///
    /// 步骤 2)
    /// 继续操作并在 XAML 文件中使用控件。
    ///
    ///     <MyNamespace:ImageButtonControl/>
    ///
    /// </summary>
    public class ImageButtonControl : Button
    {
        static ImageButtonControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButtonControl), new FrameworkPropertyMetadata(typeof(ImageButtonControl)));
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(string), typeof(ImageButtonControl),
            new FrameworkPropertyMetadata(string.Empty, new PropertyChangedCallback(ImageSourcePathChange)));

        [Description("按钮图片路径")]
        [Category("Common Properties")]
        public string ImageSource
        {
            get { return (string) this.GetValue(ImageSourceProperty); }
            set { this.SetValue(ImageSourceProperty, value); }
        }

        /// <summary>
        /// 图片路径改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        public static void ImageSourcePathChange(DependencyObject sender, DependencyPropertyChangedEventArgs arg)
        {
            return;
        }


        public static readonly DependencyProperty TextProperty = 
            DependencyProperty.Register("Text", typeof(string), typeof(ImageButtonControl),
            new FrameworkPropertyMetadata(string.Empty, new PropertyChangedCallback(TextChange)));

        [Description("按钮文字")]
        [Category("Common Properties")]
        public string Text
        {
            get { return (string) this.GetValue(TextProperty); }
            set { this.SetValue(TextProperty, value); }
        }


        /// <summary>
        /// 文字改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        public static void TextChange(DependencyObject sender, DependencyPropertyChangedEventArgs arg)
        {
            return;
        }
    }
}
