using System;
using System.Windows.Controls;
namespace HelloWorldDemo_WPF_Framework.HelloWorldFolder {
  /// <summary>
  /// HW.xaml 的互動邏輯
  /// </summary>
  public partial class HW : UserControl {
    public HW() =>
      InitializeComponent();
    private void Print(object sender, EventArgs e) =>
    PrintLabel.Content = "Hello World!";
  }
}
