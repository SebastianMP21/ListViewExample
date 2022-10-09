using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }

        public ListViewSource()
        {

            InitializeComponent();
            //ObservableCollection allows items to be added after ItemSource
            //is set and the UI will react to changes
            EmployeeView.ItemsSource = employees;
            employees.Add(new Employee { Displayname = "Rob Finnerty" });
            employees.Add(new Employee { Displayname = "Bill Wrestler" });
            employees.Add(new Employee { Displayname = "Dr. Geri-Beth Hooper" });
            employees.Add(new Employee { Displayname = "Dr. Keith Joyce-Purdy" });
            employees.Add(new Employee { Displayname = "Sheri Spruce"  });
            employees.Add(new Employee { Displayname = "Burt Indybrick" });
           
        }
    }
}