using EnterpriseDirectory.ViewModels.EmployeeStatistics;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace EnterpriseDirectory.Views;

/// <summary>
/// Interaction logic for Statistics.xaml
/// </summary>
public partial class Statistics : Window
{
    public Statistics(
        StatisticsViewModel viewModel,
        ILogger<Statistics> logger)
    {
        logger.LogInformation("Initializing statistics window...");
        InitializeComponent();
        DataContext = viewModel;
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        //base.OnClosing(e);
        e.Cancel = true;
        this.Visibility = Visibility.Collapsed;
    }
}
