using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NoobCoder;

/// <summary>
/// Страница, описывающая создание стандартных кнопок
/// </summary>
public abstract class NcPage: Page
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