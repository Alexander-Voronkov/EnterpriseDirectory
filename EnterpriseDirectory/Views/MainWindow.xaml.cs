using EnterpriseDirectory.ViewModels.ShowEmployees;
using Microsoft.Extensions.Logging;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnterpriseDirectory;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow(
        ShowEmployeesViewModel viewModel,
        ILogger<MainWindow> logger)
    {
        InitializeComponent();
        DataContext = viewModel;
        logger.LogInformation("Main window has just been successfully initialized...");
    }
}