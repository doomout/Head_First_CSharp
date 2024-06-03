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

namespace _01_MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List  <string> aninmalEomji = new List<string>()
            {
                "🐼", "🐼",
                "🦁", "🦁",
                "🐭", "🐭",
                "🐶", "🐶",
                "🐰", "🐰",
                "🐸", "🐸",
                "🐮", "🐮",
                "🦊", "🦊",
                "😎", "😎",
            };
            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                textBlock.Visibility = Visibility.Visible;
                int index  = random.Next(aninmalEomji.Count);
                string nextemoji = aninmalEomji[index];
                textBlock.Text = nextemoji;
                aninmalEomji.RemoveAt(index);
            }
        }
    }
}
