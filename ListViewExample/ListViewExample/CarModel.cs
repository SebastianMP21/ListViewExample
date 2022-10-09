using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewExample
{
    public class CarModel
    {
        public string Name { get; set; }
        public string Comment { get; set; }

        public bool car_or_motorbike { get; set; }
        public string Image { get; set; }
        public CarModel()
        {
        }
    }

    public class GroupedCarModel : ObservableCollection<CarModel>
    {
        public string LongName { get; set; }
        public string ShortName { get; set; }
    }
}

