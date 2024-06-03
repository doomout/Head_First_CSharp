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
    using System.Windows.Threading;
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tenthOfSecondsElapsed;
        int matchsFound;
        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            timer.Tick += Timer_Tick;
            SetUpGame();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthOfSecondsElapsed++;
            TimeTextBlock.Text = (tenthOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchsFound ==  8)
            {
                timer.Stop();
                TimeTextBlock.Text = TimeTextBlock.Text + " -  Play again?";
            }
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
                if (textBlock.Name != "TimeTextBlock") 
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = random.Next(aninmalEomji.Count);
                    string nextemoji = aninmalEomji[index];
                    textBlock.Text = nextemoji;
                    aninmalEomji.RemoveAt(index);
                }
                timer.Start();
                tenthOfSecondsElapsed = 0;
                matchsFound = 0;
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
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchsFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
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

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchsFound == 8)
            {
                SetUpGame();
            }
        }
    }
}
