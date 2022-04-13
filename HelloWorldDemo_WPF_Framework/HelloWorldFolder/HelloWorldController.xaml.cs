using System;
using System.Windows.Controls;
namespace HelloWorldDemo_WPF_Framework.HelloWorldFolder {
  /// <summary>
  /// HelloWorldController.xaml 的互動邏輯
  /// </summary>
  public partial class HelloWorldController : UserControl {
    public HelloWorldController() {
      InitializeComponent();
    }
    private void Print(object sender, EventArgs e) {
      PrintLabel.Content = "Hello World!";
    }
  }
}
