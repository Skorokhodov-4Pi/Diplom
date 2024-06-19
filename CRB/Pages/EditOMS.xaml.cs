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
using TestStack.White.UIItems;

namespace CRB.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditOMS.xaml
    /// </summary>
    public partial class EditOMS : Page
    {
        OMS_policy polis;
        public EditOMS()
        {
            InitializeComponent();
            DataContext = ConnectDB.GetCont().OMS_policy.OrderByDescending(x => x.end_date).Where(x => x.end_date >= DateTime.Now).FirstOrDefault(x => x.id_patient == Right.patt.id_patient);
        }

        private void EditOMSBtn_Click(object sender, RoutedEventArgs e)
        {
            var errorsBuild = new StringBuilder();
            if (string.IsNullOrEmpty(RegionTxt.Text)) errorsBuild.AppendLine("Не введен регион");
            if (string.IsNullOrEmpty(CompanyTxt.Text)) errorsBuild.AppendLine("Не введена страховая компания");
            if (string.IsNullOrEmpty(NumTxt.Text) || NumTxt.Text.Count() < 16) errorsBuild.AppendLine("Не введен номер полиса/Не правильно введен полис");
            if (string.IsNullOrEmpty(StartDP.Text.ToString())) errorsBuild.AppendLine("Не введена дата начала страхования");
            if (string.IsNullOrEmpty(EndDP.Text.ToString())) errorsBuild.AppendLine("Не введена дата конца страхования");
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
