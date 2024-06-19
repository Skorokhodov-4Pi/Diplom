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
    /// Логика взаимодействия для AddOMSForm.xaml
    /// </summary>
    public partial class AddOMSForm : Page
    {
        static OMS_policy policy;
        public AddOMSForm(OMS_policy oms)
        {
            InitializeComponent();
            DataContext = policy = oms is null ? new OMS_policy() {start_date = new DateTime(1900, 1, 1), end_date = new DateTime(1900, 1, 1) } : oms;
            PacientCmb.ItemsSource = ConnectDB.GetCont().Patient.ToList();
        }

        private void AddOMSBtn_Click(object sender, RoutedEventArgs e)
        {
            var errorsBuild = new StringBuilder();
            if (string.IsNullOrEmpty(policy.region)) errorsBuild.AppendLine("Не введен регион");
            if (string.IsNullOrEmpty(policy.insurance_company)) errorsBuild.AppendLine("Не введена страховая компания");
            if (string.IsNullOrEmpty(policy.policy_number) || policy.policy_number.Count() < 16) errorsBuild.AppendLine("Не введен номер полиса/Не правильно введен полис");
            if (string.IsNullOrEmpty(policy.start_date.ToString())) errorsBuild.AppendLine("Не введена дата начала страхования");
            if (string.IsNullOrEmpty(policy.end_date.ToString())) errorsBuild.AppendLine("Не введена дата конца страхования");
            if (errorsBuild.Length > 0)
            {
                MessageBox.Show(errorsBuild.ToString(), "Ошибка сохранения!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (policy.id_patient == 0)
                ConnectDB.GetCont().OMS_policy.Add(policy);
            try
            {
                ConnectDB.GetCont().SaveChanges();
                MessageBox.Show("Данные сохранены!");
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
