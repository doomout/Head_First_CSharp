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

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock  textBlock = sender as TextBlock;

            //매칭 실패 상태일 때
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;  //클릭한 동물 가리기
                lastTextBlockClicked = textBlock; //클릭한 동물 임시 저장
                findingMatch = true;  //매칭  성공  상태로 변환
            }
            else if (textBlock.Text == lastTextBlockClicked.Text) //짝을 맞춘 경우
            {
                textBlock.Visibility = Visibility.Hidden; //클릭한  동물 가리기
                findingMatch = false; //매칭 실패 상태로 변환
            }
            else //짝을 틀린 경우
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;  //클릭한 동물  보이도록 설정
                findingMatch = false; //매칭 실패 상태로 변환
            }
        }
    }
}
