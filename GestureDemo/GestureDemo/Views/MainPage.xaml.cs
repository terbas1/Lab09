using GestureDemo.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GestureDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyMenu();
        }
        void MyMenu()
        {
            Detail = new NavigationPage(new HomePage());
            List<Menu> menu = new List<Menu>
            {
                new Menu{ Page=new TapDemo(), MenuTitle="Tap"},
                new Menu{ Page=new PinchDemo(), MenuTitle="Pinch"},
                new Menu{ Page=new PanDemo(), MenuTitle="Pan"},
                new Menu{ Page=new SwipeDemo(), MenuTitle="Swipe"},
                new Menu{ Page=new SwipeBinding(), MenuTitle="SwipeBinding"},

            };
            ListMenu.ItemsSource = menu;
        }
        
        public class Menu
        {
            public string MenuTitle
            {
                get;
                set;
            }
            public Page Page
            {
                get;
                set;
            }
        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if(menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
            }

        }
    }
}
