using Castle.Core.Internal;
using CRB.AppData;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CRB.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditStaff.xaml
    /// </summary>
    public partial class EditStaff : Page
    {
        public EditStaff()
        {
            InitializeComponent();
            var role = ConnectDB.GetCont().Positions.ToList();
            RoleCmb.ItemsSource = role;
            DataContext = Right.editUsers ?? new Staff();

        }

        private void RoleCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var errorsBuild = new StringBuilder();
            if (string.IsNullOrEmpty(FmTxt.Text)) errorsBuild.AppendLine("Не введена фамилия");
            if (string.IsNullOrEmpty(NameTxt.Text)) errorsBuild.AppendLine("Не введено имя");
            if (string.IsNullOrEmpty(OtchTxt.Text)) errorsBuild.AppendLine("Не введено отчество");
            if (string.IsNullOrEmpty(LogTxt.Text)) errorsBuild.AppendLine("Не введен логин");
            if (string.IsNullOrEmpty(PassTxt.Text)) errorsBuild.AppendLine("Не введен пароль");
            if (string.IsNullOrEmpty(RoleCmb.Text)) errorsBuild.AppendLine("Не выбрана роль");
            if (errorsBuild.Length > 0)
            {
                MessageBox.Show(errorsBuild.ToString(), "Ошибка сохранения!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                ConnectDB.GetCont().SaveChanges();
                Nav.frame.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка сохранения!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            Nav.frame.GoBack();
        }
    }
}
