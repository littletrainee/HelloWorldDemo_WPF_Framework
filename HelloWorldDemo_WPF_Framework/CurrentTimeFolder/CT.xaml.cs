using System;
using System.Windows.Controls;
using System.Windows.Threading;

namespace HelloWorldDemo_WPF_Framework.CurrentTimeFolder {
  /// <summary>
  /// CT.xaml 的互動邏輯
  /// </summary>
  public partial class CT : UserControl {
    DispatcherTimer Timer { get; set; }
    public CT() {
      InitializeComponent();
      Timer = new DispatcherTimer();
      Timer.Tick += CurrentTime;
      Timer.Start();
    }

    private void CurrentTime(object sender, EventArgs e) =>
      Print.Content = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
  }
}
