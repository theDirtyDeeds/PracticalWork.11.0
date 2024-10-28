using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace PracticalWork_11._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<Department> _departments;
        public List<Department> Departments
        {
            get => _departments;
            set
            {
                _departments = value;
                OnPropertyChanged(nameof(Departments));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Departments = new List<Department>();
            LoadData(); 
        }

        private void LoadData()
        {
            var department = new Department { Name = "Sales" };
            Departments.Add(department);
        }

        private void AddClient(string lastname, string name, string middlename, string phoneNumber, string passport, Department department)
        {
            var manager = new Manager();
            manager.AddClient(department, lastname, name, middlename, phoneNumber, passport);
            OnPropertyChanged(nameof(Departments)); 
        }

        private void ChangeClientData(Client client, string lastname, string name, string middlename, string phoneNumber, string passport)
        {
            var manager = new Manager();
            manager.ChangeClientData(client, lastname, name, middlename, phoneNumber, passport);
            OnPropertyChanged(nameof(Departments)); 
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void AddClientButton_Click(object sender, RoutedEventArgs e)
        {
            string lastname = LastnameTextBox.Text;
            string name = NameTextBox.Text;
            string middlename = MiddleNameTextBox.Text;
            string phonenumber = PhoneNumberTextBox.Text;
            string passport = PassportTextBox.Text;

            Console.WriteLine($"Добавлен клиент: {lastname} {name} {middlename}, Телефон: {phonenumber}, Паспорт: {passport}");
        
            LastnameTextBox.Clear();
            NameTextBox.Clear();
            MiddleNameTextBox.Clear();
            PhoneNumberTextBox.Clear();
            PassportTextBox.Clear();
        }
    }
}