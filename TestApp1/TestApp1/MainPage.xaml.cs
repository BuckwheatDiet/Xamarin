using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lst.ItemsSource = new List<ListItem>() {
                new ListItem() {
                    Name = "Umair", Num = "0456445450945", imgsource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAHObeyC86vtAAcRT2EBxqnsVc4qzz96505owEuXzKpNnLFDWKGw",
                    },
                new ListItem() {
                    Name = "Cat", Num = "034456445905", imgsource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAHObeyC86vtAAcRT2EBxqnsVc4qzz96505owEuXzKpNnLFDWKGw",
                    },
                new ListItem() {
                    Name = "Nature", Num = "56445905", imgsource = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAHObeyC86vtAAcRT2EBxqnsVc4qzz96505owEuXzKpNnLFDWKGw",
                    },
            };
        }
    }
}
