using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Tic_Tac_Toe
{
    public partial class MainWindow : Window
    {
        int winsx = 0;
        int winso = 0;
        int a = 0;
        int c = 0;
        int d = 0;
        int l = 0;
        int f = 0;
        int g = 0;
        int h = 0;
        int i = 0;
        int j = 0;
        int k = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_click1(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_1.Visibility = Visibility.Hidden;
                c++;
            }
            else
            {
                _1.Visibility = Visibility.Hidden;
                c--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (c == 1 && d == 1 && l == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && d == -1 && l == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (c == 1 && f == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && f == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (c == 1 && g == 1 && k == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && g == -1 && k == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }

        }

        private void btn_click2(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_2.Visibility = Visibility.Hidden;
                d++;
            }
            else
            {
                _2.Visibility = Visibility.Hidden;
                d--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (c == 1 && d == 1 && l == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && d == -1 && l == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (d == 1 && g == 1 && j == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (d == -1 && g == -1 && j == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
        }

        private void btn_click3(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_3.Visibility = Visibility.Hidden;
                l++;
            }
            else
            {
                _3.Visibility = Visibility.Hidden;
                l--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (c == 1 && d == 1 && l == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && d == -1 && l == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (l == 1 && g == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (l == -1 && g == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (l == 1 && h == 1 && k == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (l == -1 && h == -1 && k == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
        }

        private void btn_click4(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_4.Visibility = Visibility.Hidden;
                f++;
            }
            else
            {
                _4.Visibility = Visibility.Hidden;
                f--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (c == 1 && f == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && f == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (f == 1 && g == 1 && h == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (f == -1 && g == -1 && h == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
        }

        private void btn_click5(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_5.Visibility = Visibility.Hidden;
                g++;
            }
            else
            {
                _5.Visibility = Visibility.Hidden;
                g--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (c == 1 && g == 1 && k == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && g == -1 && k == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (d == 1 && g == 1 && j == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (d == -1 && g == -1 && j == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (l == 1 && g == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (l == -1 && g == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (f == 1 && g == 1 && h == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (f == -1 && g == -1 && h == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }

        }

        private void btn_click6(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_6.Visibility = Visibility.Hidden;
                h++;
            }
            else
            {
                _6.Visibility = Visibility.Hidden;
                h--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (f == 1 && g == 1 && h == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (f == -1 && g == -1 && h == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (l == 1 && h == 1 && k == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (l == -1 && h == -1 && k == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
        }

        private void btn_click7(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_7.Visibility = Visibility.Hidden;
                i++;
            }
            else
            {
                _7.Visibility = Visibility.Hidden;
                i--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (c == 1 && f == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && f == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (l == 1 && g == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (l == -1 && g == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (j == 1 && k == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (j == -1 && k == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
        }

        private void btn_click8(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_8.Visibility = Visibility.Hidden;
                j++;
            }
            else
            {
                _8.Visibility = Visibility.Hidden;
                j--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (j == 1 && k == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (j == -1 && k == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (d == 1 && g == 1 && j == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (d == -1 && g == -1 && j == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
        }

        private void btn_click9(object sender, RoutedEventArgs e)
        {
            a++;
            Button b = (Button)sender;
            b.Visibility = Visibility.Hidden;
            if (a % 2 != 0)
            {
                o_9.Visibility = Visibility.Hidden;
                k++;
            }
            else
            {
                _9.Visibility = Visibility.Hidden;
                k--;
            }
            if (c != 0 && d != 0 && l != 0 && f != 0 && g != 0 && h != 0 && i != 0 && j != 0 && k != 0)
            {
                draw.Visibility = Visibility.Visible;
                Restart();
            }
            if (j == 1 && k == 1 && i == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (j == -1 && k == -1 && i == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (l == 1 && h == 1 && k == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (l == -1 && h == -1 && k == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
            if (c == 1 && g == 1 && k == 1)
            {
                o_win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winsx++;
                x.Text = "X= " + winsx;
                Restart();
            }
            if (c == -1 && g == -1 && k == -1)
            {
                _win.Visibility = Visibility.Visible;
                draw.Visibility = Visibility.Hidden;
                winso++;
                o.Text = "O= " + winso;
                Restart();
            }
        }
        private async void Restart()
        {
            await Task.Delay(1000);
            draw.Visibility = Visibility.Hidden;
            _win.Visibility = Visibility.Hidden;
            o_win.Visibility = Visibility.Hidden;
            _9.Visibility = Visibility.Visible;
            o_9.Visibility = Visibility.Visible;
            _8.Visibility = Visibility.Visible;
            o_8.Visibility = Visibility.Visible;
            _7.Visibility = Visibility.Visible;
            o_7.Visibility = Visibility.Visible;
            _6.Visibility = Visibility.Visible;
            o_6.Visibility = Visibility.Visible;
            _5.Visibility = Visibility.Visible;
            o_5.Visibility = Visibility.Visible;
            _4.Visibility = Visibility.Visible;
            o_4.Visibility = Visibility.Visible;
            _3.Visibility = Visibility.Visible;
            o_3.Visibility = Visibility.Visible;
            _2.Visibility = Visibility.Visible;
            o_2.Visibility = Visibility.Visible;
            _1.Visibility = Visibility.Visible;
            o_1.Visibility = Visibility.Visible;

            a = 0;
            c = 0;
            d = 0;
            l = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            j = 0;
            k = 0;

            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;
            b5.Visibility = Visibility.Visible;
            b6.Visibility = Visibility.Visible;
            b7.Visibility = Visibility.Visible;
            b8.Visibility = Visibility.Visible;
            b9.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            draw.Visibility = Visibility.Hidden;
            _win.Visibility = Visibility.Hidden;
            o_win.Visibility = Visibility.Hidden;
            _9.Visibility = Visibility.Visible;
            o_9.Visibility = Visibility.Visible;
            _8.Visibility = Visibility.Visible;
            o_8.Visibility = Visibility.Visible;
            _7.Visibility = Visibility.Visible;
            o_7.Visibility = Visibility.Visible;
            _6.Visibility = Visibility.Visible;
            o_6.Visibility = Visibility.Visible;
            _5.Visibility = Visibility.Visible;
            o_5.Visibility = Visibility.Visible;
            _4.Visibility = Visibility.Visible;
            o_4.Visibility = Visibility.Visible;
            _3.Visibility = Visibility.Visible;
            o_3.Visibility = Visibility.Visible;
            _2.Visibility = Visibility.Visible;
            o_2.Visibility = Visibility.Visible;
            _1.Visibility = Visibility.Visible;
            o_1.Visibility = Visibility.Visible;

            a = 0;
            c = 0;
            d = 0;
            l = 0;
            f = 0;
            g = 0;
            h = 0;
            i = 0;
            j = 0;
            k = 0;

            b1.Visibility = Visibility.Visible;
            b2.Visibility = Visibility.Visible;
            b3.Visibility = Visibility.Visible;
            b4.Visibility = Visibility.Visible;
            b5.Visibility = Visibility.Visible;
            b6.Visibility = Visibility.Visible;
            b7.Visibility = Visibility.Visible;
            b8.Visibility = Visibility.Visible;
            b9.Visibility = Visibility.Visible;

            winsx = 0;
            winso = 0;
            x.Text = "X= " + winsx;
            o.Text = "O= " + winso;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            draw.Visibility = Visibility.Visible;
            Restart();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _win.Visibility = Visibility.Visible;
            winso++;
            o.Text = "O= " + winso;
            Restart();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            o_win.Visibility = Visibility.Visible;
            winsx++;
            x.Text = "X= " + winsx;
            Restart();
        }
    }
}