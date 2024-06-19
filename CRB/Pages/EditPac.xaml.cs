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
    /// Логика взаимодействия для EditPac.xaml
    /// </summary>
    public partial class EditPac : Page
    {
        public EditPac()
        {
            InitializeComponent();
            DataContext = Right.patt ?? new Patient();
            PolisTxt.Text = Right.patt.policy_number.ToString();
            genderCmb.ItemsSource = new string[]
            {
                "мужской",
                "женский"
            };
        }

        private void AddPacBtn_Click(object sender, RoutedEventArgs e)
        {
            var errorsBuild = new StringBuilder();
            if (string.IsNullOrEmpty(Right.patt.Surname)) errorsBuild.AppendLine("Не введена фамилия");
            if (string.IsNullOrEmpty(Right.patt.First_name)) errorsBuild.AppendLine("Не введено имя");
            if (string.IsNullOrEmpty(Right.patt.Patronymic)) errorsBuild.AppendLine("Не введено отчетсво");
            if (string.IsNullOrEmpty(Right.patt.gender)) errorsBuild.AppendLine("Не введен пол");
            if (string.IsNullOrEmpty(Right.patt.phone_number)) errorsBuild.AppendLine("Не введен номер телефона");
            if (string.IsNullOrEmpty(Right.patt.email)) errorsBuild.AppendLine("Не введена почта");
            if (string.IsNullOrEmpty(Right.patt.actual_address)) errorsBuild.AppendLine("Не введен адрес нахождения");
            if (string.IsNullOrEmpty(Right.patt.registered_address)) errorsBuild.AppendLine("Не введен адрес прописки");
            if (Right.patt.date_of_birth < new DateTime(1900, 1, 1)) errorsBuild.AppendLine("Не правильно введена дата");
            if (string.IsNullOrEmpty(Right.patt.SNILS) || Right.patt.SNILS.Count() < 11) errorsBuild.AppendLine("Не правильно введен снилс");
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

        private void genderCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void genderCmb_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
