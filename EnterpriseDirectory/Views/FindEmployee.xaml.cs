using EnterpriseDirectory.ViewModels.FindEmployees;
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
/// Interaction logic for FindEmployee.xaml
/// </summary>
public partial class FindEmployee : Window
{
    public FindEmployee(
        ILogger<FindEmployee> logger,
        FindEmployeesViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
        logger.LogInformation("Successfully initialized find employee view.");
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        //base.OnClosing(e);
        e.Cancel = true;
        this.Visibility = Visibility.Collapsed;
    }
}
