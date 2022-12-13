using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Noob_Coder;

/// <summary>
/// Окно, описывающие создание стандартных кнопок
/// </summary>
public abstract class NcWindow : Window
{
    /// <summary>
    /// Минимальный размер кнопки, он же отступ границы кнопки от края экрана
    /// </summary>
    internal const int BtnMinWidth = 300;

    /// <summary>
    /// Создать кнопку в основное меню
    /// </summary>
    /// <param name="text">Текст, с которым создаётся кнопка</param>
    /// <returns></returns>
    internal Button GetMenuButton(string text)
    {
        return new Button
        {
            MaxWidth = 1080,
            VerticalAlignment = VerticalAlignment.Top,
            Width = this.Width - BtnMinWidth,
            Height = 40,
            HorizontalContentAlignment = HorizontalAlignment.Center,
            VerticalContentAlignment = VerticalAlignment.Top,
            Content = text,
            FontSize=24,
            Background = Brushes.Indigo,
            Foreground = Brushes.White,
            FontFamily = new FontFamily("Corbel Light")
        };
    }

    /// <summary>
    /// Создать Action, который будет менять размеры кнопок в указаном StackPanel
    /// </summary>
    /// <param name="stack"></param>
    internal void CreateSizeChangedAction(StackPanel stack)
    {
        SizeChanged += (sender, args) =>
        {
            var newWidth = this.Width - BtnMinWidth;
            if (this.Width <= BtnMinWidth * 2)
            {
                foreach (UIElement element in stack.Children)
                    if (element is Button button)
                        button.Width = this.Width;
            }
            else
                foreach (UIElement element in stack.Children)
                    if (element is Button button)
                        button.Width = newWidth;
        };

    }
}