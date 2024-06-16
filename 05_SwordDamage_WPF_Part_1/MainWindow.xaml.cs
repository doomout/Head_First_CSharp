using System;
using System.Collections.Generic;
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

namespace _05_SwordDamage_WPF_Part_1
{ 
    public partial class MainWindow : Window
    {
        Random random = new Random();
        SwordDamage sd = new SwordDamage();

        public MainWindow()
        {
            InitializeComponent();
            sd.SetMagic(false);
            sd.SetFlaming(false);
            RollDice();
        }

        private void RollDice()
        {
            sd.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            sd.SetFlaming(Flaming.IsChecked.Value);
            sd.SetMagic(Magic.IsChecked.Value);
            DisplayDamage();
        }
        
        void DisplayDamage()
        {
            damage.Text = "Rolled " + sd.Roll + " for " + sd.Damage + " HP";
        }

        private void Flaming_Checked(object sender, RoutedEventArgs e)
        {
            sd.SetFlaming(true);
            DisplayDamage();
        }

        private void Flaming_Unchecked(object sender, RoutedEventArgs e)
        {
            sd.SetFlaming(false);
            DisplayDamage();
        }

        private void Magic_Checked(object sender, RoutedEventArgs e)
        {
            sd.SetMagic(true);
            DisplayDamage();
        }

        private void Magic_Unchecked(object sender, RoutedEventArgs e)
        {
            sd.SetMagic(false);
            DisplayDamage();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RollDice();
        }
    }
}
