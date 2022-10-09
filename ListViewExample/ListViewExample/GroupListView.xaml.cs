using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupListView : ContentPage
    {
        private ObservableCollection<GroupedCarModel> grouped { get; set; }
        public GroupListView()
        {
            InitializeComponent();
            grouped = new ObservableCollection<GroupedCarModel>();
            var CarGroup = new GroupedCarModel() { LongName = "cars", ShortName = "v" };
            var MotobikeGroup = new GroupedCarModel() { LongName = "motorbike", ShortName = "f" };
            CarGroup.Add(new CarModel() { Name = "nissan mk 2010", car_or_motorbike = true, Comment = "muy bonito" });
            MotobikeGroup.Add(new CarModel() { Name = "moto ronco modelo zzz", car_or_motorbike = false, Comment = "se ve ruda" });
            CarGroup.Add(new CarModel() { Name = "nissan rio", car_or_motorbike = true, Comment = "muy buen diseño" });
            CarGroup.Add(new CarModel() { Name = "toyota pícanto", car_or_motorbike = true, Comment = "pequeño pero elegantes" });
            MotobikeGroup.Add(new CarModel() { Name = "moto itallica modelo sss", car_or_motorbike = false, Comment = "simple pero llamativo" });
            MotobikeGroup.Add(new CarModel() { Name = "moto ronco modelo gaa", car_or_motorbike = false, Comment = "una moto muy elegante" });
            MotobikeGroup.Add(new CarModel() { Name = "moto yamaha modelo uwu", car_or_motorbike = false, Comment = "se ve intimidante" });
            grouped.Add(CarGroup); grouped.Add(MotobikeGroup);
            lstView.ItemsSource = grouped;
        }
    }
}