using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace HelloWorldDemo_WPF_Framework.CountToTenFolder {
  /// <summary>
  /// CountToTenControl.xaml 的互動邏輯
  /// </summary>
  public partial class CountToTenControl : UserControl {
    public CountToTenControl() {
      InitializeComponent();
    }
    public int Duration { get; set; }
    /// <summary>
    /// CoutUp Function
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CountUp(object sender, RoutedEventArgs e) {
      // show the first number to PrintLabel.Content
      Duration = 0;
      PrintLabel.Content = Duration.ToString();
      // create sleep Thread with Sleep method
      Thread sleepthread = new Thread(Sleep);
      // wait 1 second
      sleepthread.Start(1);
    }
    /// <summary>
    /// sleep method
    /// </summary>
    /// <param name="i"></param>
    private void Sleep(object i) {
      // make a loop with Thread.Sleep,Duration++ and PrintLabel.Content
      for (int j = 0; j < 10; j++) {
        Thread.Sleep((int)i * 1000);
        Duration++;
        Dispatcher.Invoke(() => {
          PrintLabel.Content = Duration.ToString();
        });
      }
    }
  }
}
