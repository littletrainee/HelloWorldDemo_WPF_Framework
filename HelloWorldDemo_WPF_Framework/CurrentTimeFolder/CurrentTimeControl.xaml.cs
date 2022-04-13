using System;
using System.Windows.Controls;
using System.Windows.Threading;
namespace HelloWorldDemo_WPF_Framework.CurrentTimeFolder {
  /// <summary>
  /// CurrentTimeControl.xaml 的互動邏輯
  /// </summary>
  public partial class CurrentTimeControl : UserControl {
    private DispatcherTimer Timer { get; set; }
    public CurrentTimeControl() {
      InitializeComponent();
      Timer = new DispatcherTimer();
      Timer.Tick += CurrentTime;
      Timer.Start();
    }

    private void CurrentTime(object sender, EventArgs e) {
      Print.Content = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
    }
  }
}
