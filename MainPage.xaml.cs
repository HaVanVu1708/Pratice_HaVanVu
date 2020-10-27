using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Practice_HaVanVu.Models;
using System.Collections.ObjectModel;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Practice_HaVanVu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Imagess> images;

        private ObservableCollection<Contact> Contacts;
        public MainPage()
        {
            this.InitializeComponent();

            images = new List<Imagess>();

            images.Add(new Imagess { imagePath = "Assets/anh1.jpg" });
            images.Add(new Imagess { imagePath = "Assets/anh2.jpg" });
            images.Add(new Imagess { imagePath = "Assets/anh3.jpg" });
            images.Add(new Imagess { imagePath = "Assets/anh4.jpg" });
            images.Add(new Imagess { imagePath = "Assets/anh5.jpg" });
            images.Add(new Imagess { imagePath = "Assets/anh6.jpg" });


              Contacts = new ObservableCollection<Contact>();
              Contacts.Add(new Contact { Product = "AoTheThao", Description= "Sam Sung" , ImagePath = "Assets/anh1.jpg" });
              Contacts.Add(new Contact { Product = "AoTheThao", Description = "Viet Nam", ImagePath = "Assets/anh2.jpg" });
              Contacts.Add(new Contact { Product = "AoTheThao", Description = "Viet Nam", ImagePath = "Assets/anh2.jpg" });


        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Imagess)ImageComboBox.SelectedValue).imagePath;
            Contacts.Add(new Contact { Product = ProductTextBox.Text, Description = DescriptionTextBox.Text, ImagePath = avatar });

            ProductTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedItem = -1;
            ProductTextBox.Focus(FocusState.Programmatic);
        }
    }
}
