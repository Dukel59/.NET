using System;
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
using System.Windows.Threading;

namespace KeyboardTrainer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool shiftDown = false;
        BrushConverter bc = new BrushConverter();
        int time;
        DispatcherTimer timer;
        int totalChar;
        int speed;
        int fails;
        public MainWindow()
        {
            InitializeComponent();
            braceL.Content = "{";
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(2);
        }

        private void KeyEvents(object sender, KeyEventArgs e)
        {
             if (e.Key == Key.OemTilde)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(tilda, null);
                    }
                    else
                        Button_Click(tilda, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(tild, null);
                    }
                    else
                        Button_Click(tild, null);
                }
            }
            else if (e.Key == Key.D1)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(bang, null);
                    }
                    else
                        Button_Click(bang, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(one, null);
                    }
                    else
                        Button_Click(one, null);
                }
            }
            else if (e.Key == Key.D2)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(dog, null);
                    }
                    else
                        Button_Click(dog, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(two, null);
                    }
                    else
                        Button_Click(two, null);
                }
            }
            else if (e.Key == Key.D3)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(sharp, null);
                    }
                    else
                        Button_Click(sharp, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(three, null);
                    }
                    else
                        Button_Click(three, null);
                }
            }
            else if (e.Key == Key.D4)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(dollar, null);
                    }
                    else
                        Button_Click(dollar, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(four, null);
                    }
                    else
                        Button_Click(four, null);
                }
            }
            else if (e.Key == Key.D5)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(percent, null);
                    }
                    else
                        Button_Click(percent, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(five, null);
                    }
                    else
                        Button_Click(five, null);
                }
            }
            else if (e.Key == Key.D6)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(caret, null);
                    }
                    else
                        Button_Click(caret, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(six, null);
                    }
                    else
                        Button_Click(six, null);
                }
            }
            else if (e.Key == Key.D7)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(ampersand, null);
                    }
                    else
                        Button_Click(ampersand, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(seven, null);
                    }
                    else
                        Button_Click(seven, null);
                }
            }
            else if (e.Key == Key.D8)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(star, null);
                    }
                    else
                        Button_Click(star, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(eight, null);
                    }
                    else
                        Button_Click(eight, null);
                }
            }
            else if (e.Key == Key.D9)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(parenthesisL, null);
                    }
                    else
                        Button_Click(parenthesisL, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(nine, null);
                    }
                    else
                        Button_Click(nine, null);
                }
            }
            else if (e.Key == Key.D0)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(parenthesisR, null);
                    }
                    else
                        Button_Click(parenthesisR, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(ten, null);
                    }
                    else
                        Button_Click(ten, null);
                }
            }
            else if (e.Key == Key.OemMinus)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(underscore, null);
                    }
                    else
                        Button_Click(underscore, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(minus, null);
                    }
                    else
                        Button_Click(minus, null);
                }
            }
            else if (e.Key == Key.OemPlus)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(plus, null);
                    }
                    else
                        Button_Click(plus, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(equally, null);
                    }
                    else
                        Button_Click(equally, null);
                }
            }
            else if (e.Key == Key.Q)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(Q, null);
                    }
                    else
                        Button_Click(Q, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(q, null);
                    }
                    else
                        Button_Click(q, null);
                }
            }
            else if (e.Key == Key.W)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(W, null);
                    }
                    else
                        Button_Click(W, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(w, null);
                    }
                    else
                        Button_Click(w, null);
                }
            }
            else if (e.Key == Key.E)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(ButE, null);
                    }
                    else
                        Button_Click(ButE, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(butE, null);
                    }
                    else
                        Button_Click(butE, null);
                }
            }
            else if (e.Key == Key.R)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(R, null);
                    }
                    else
                        Button_Click(R, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(r, null);
                    }
                    else
                        Button_Click(r, null);
                }
            }
            else if (e.Key == Key.T)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(T, null);
                    }
                    else
                        Button_Click(T, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(t, null);
                    }
                    else
                        Button_Click(t, null);
                }
            }
            else if (e.Key == Key.Y)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(Y, null);
                    }
                    else
                        Button_Click(Y, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(y, null);
                    }
                    else
                        Button_Click(y, null);
                }
            }
            else if (e.Key == Key.U)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(U, null);
                    }
                    else
                        Button_Click(U, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(u, null);
                    }
                    else
                        Button_Click(u, null);
                }
            }
            else if (e.Key == Key.I)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(I, null);
                    }
                    else
                        Button_Click(I, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(i, null);
                    }
                    else
                        Button_Click(i, null);
                }
            }
            else if (e.Key == Key.O)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(O, null);
                    }
                    else
                        Button_Click(O, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(o, null);
                    }
                    else
                        Button_Click(o, null);
                }
            }
            else if (e.Key == Key.P)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(P, null);
                    }
                    else
                        Button_Click(P, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(p, null);
                    }
                    else
                        Button_Click(p, null);
                }
            }
            else if (e.Key == Key.OemOpenBrackets)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(braceL, null);
                    }
                    else
                        Button_Click(braceL, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(squareL, null);
                    }
                    else
                        Button_Click(squareL, null);
                }
            }
            else if (e.Key == Key.Oem6)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(braceR, null);
                    }
                    else
                        Button_Click(braceR, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(squareR, null);
                    }
                    else
                        Button_Click(squareR, null);
                }
            }
            else if (e.Key == Key.Oem5)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(pipe, null);
                    }
                    else
                        Button_Click(pipe, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(backslash, null);
                    }
                    else
                        Button_Click(backslash, null);
                }
            }
            else if (e.Key == Key.A)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(A, null);
                    }
                    else
                        Button_Click(A, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(a, null);
                    }
                    else
                        Button_Click(a, null);
                }
            }
            else if (e.Key == Key.S)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(S, null);
                    }
                    else
                        Button_Click(S, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(s, null);
                    }
                    else
                        Button_Click(s, null);
                }
            }
            else if (e.Key == Key.D)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(D, null);
                    }
                    else
                        Button_Click(D, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(d, null);
                    }
                    else
                        Button_Click(d, null);
                }
            }
            else if (e.Key == Key.F)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(F, null);
                    }
                    else
                        Button_Click(F, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(f, null);
                    }
                    else
                        Button_Click(f, null);
                }
            }
            else if (e.Key == Key.G)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(G, null);
                    }
                    else
                        Button_Click(G, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(g, null);
                    }
                    else
                        Button_Click(g, null);
                }
            }
            else if (e.Key == Key.H)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(H, null);
                    }
                    else
                        Button_Click(H, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(h, null);
                    }
                    else
                        Button_Click(h, null);
                }
            }
            else if (e.Key == Key.J)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(J, null);
                    }
                    else
                        Button_Click(J, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(j, null);
                    }
                    else
                        Button_Click(j, null);
                }
            }
            else if (e.Key == Key.K)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(K, null);
                    }
                    else
                        Button_Click(K, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(k, null);
                    }
                    else
                        Button_Click(k, null);
                }
            }
            else if (e.Key == Key.L)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(L, null);
                    }
                    else
                        Button_Click(L, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(l, null);
                    }
                    else
                        Button_Click(l, null);
                }
            }
            else if (e.Key == Key.Oem1)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(colon, null);
                    }
                    else
                        Button_Click(colon, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(semicolon, null);
                    }
                    else
                        Button_Click(semicolon, null);
                }
            }
            else if (e.Key == Key.OemQuotes)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(quote, null);
                    }
                    else
                        Button_Click(quote, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(apostrophe, null);
                    }
                    else
                        Button_Click(apostrophe, null);
                }
            }
            else if (e.Key == Key.Z)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(Z, null);
                    }
                    else
                        Button_Click(Z, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(z, null);
                    }
                    else
                        Button_Click(z, null);
                }
            }
            else if (e.Key == Key.X)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(X, null);
                    }
                    else
                        Button_Click(X, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(x, null);
                    }
                    else
                        Button_Click(x, null);
                }
            }
            else if (e.Key == Key.C)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(C, null);
                    }
                    else
                        Button_Click(C, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(c, null);
                    }
                    else
                        Button_Click(c, null);
                }
            }
            else if (e.Key == Key.V)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(V, null);
                    }
                    else
                        Button_Click(V, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(v, null);
                    }
                    else
                        Button_Click(v, null);
                }
            }
            else if (e.Key == Key.B)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(B, null);
                    }
                    else
                        Button_Click(B, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(b, null);
                    }
                    else
                        Button_Click(b, null);
                }
            }
            else if (e.Key == Key.N)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(N, null);
                    }
                    else
                        Button_Click(N, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(n, null);
                    }
                    else
                        Button_Click(n, null);
                }
            }
            else if (e.Key == Key.M)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(M, null);
                    }
                    else
                        Button_Click(M, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(m, null);
                    }
                    else
                        Button_Click(m, null);
                }
            }
            else if (e.Key == Key.OemComma)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(angleL, null);
                    }
                    else
                        Button_Click(angleL, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(comma, null);
                    }
                    else
                        Button_Click(comma, null);
                }
            }
            else if (e.Key == Key.OemPeriod)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(angleR, null);
                    }
                    else
                        Button_Click(angleR, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(dot, null);
                    }
                    else
                        Button_Click(dot, null);
                }
            }
            else if (e.Key == Key.OemQuestion)
            {
                if (shiftDown)
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(quest, null);
                    }
                    else
                        Button_Click(quest, null);
                }
                else
                {
                    if (e.IsDown)
                    {
                        Button_KeyDown(forvardSlash, null);
                    }
                    else
                        Button_Click(forvardSlash, null);
                }
            }
            else if (e.Key == Key.Space)
            {
                if (e.IsDown)
                {
                    Button_KeyDown(space, null);
                }
                else
                    space_Click(space, null);
            }
            else if (e.Key == Key.Back)
            {
                if (e.IsDown)
                {
                    Button_KeyDown(backspace, null);
                }
                else
                    backspace_Click(backspace, null);
            }
            else if (e.Key == Key.Tab)
            {
                if (e.IsDown)
                {
                    Button_KeyDown(tab, null);
                }
                else
                    tab_Click(tab, null);
            }
            else if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                if (e.IsDown)
                {
                    if (e.Key == Key.LeftShift)
                    {
                        Button_KeyDown(shiftL, null);
                    }
                    else
                    {
                        Button_KeyDown(shiftR, null);
                    }
                }
                else
                {
                    if (e.Key == Key.LeftShift)
                    {
                        shiftL_Click(shiftL, null);
                    }
                    else
                    {
                       shiftL_Click(shiftR, null);
                    }
                }
            }
             else if (e.Key == Key.CapsLock)
            {
                ButtonPressBackGroung(capsLock);
                if(e.IsUp)
                {
                    if(shiftDown)
                    {
                        shiftDown = false;
                        ButtonBackGround(CapsLock);
                        ButtonBackGround(capsLock);
                    }
                    else
                    {
                        shiftDown = true;
                        ButtonPressBackGroung(CapsLock);
                    }
                    ActivateShift(shiftDown);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            if (Start.IsEnabled == false)
            {
                if (second.Text.Length == 0)
                {
                    if (first.Text[0].ToString() == but.Content.ToString())
                    {
                        second.Text += but.Content;
                        totalChar++;
                        ButtonBackGround(but);
                    }
                    else
                    {
                        fails++;
                        fail.Content = fails;
                        ButtonBackGround(but);
                    }
                }
                else
                {
                    second.Text += but.Content;
                    totalChar++;
                    ButtonBackGround(but);
                }
            }
            else
            {
                second.Text += but.Content;
                ButtonBackGround(but);
            }
        }

        private void ButtonBackGround(Button but)
        {
            if (but.Name == "q" || but.Name == "a" || but.Name == "z" || but.Name == "tild" || but.Name == "one" ||
                but.Name == "two" || but.Name == "nine" || but.Name == "i" || but.Name == "k" || but.Name == "comma" ||
                but.Name == "Q" || but.Name == "A" || but.Name == "Z" || but.Name == "tilda" || but.Name == "bang" ||
                but.Name == "dog" || but.Name == "parenthesisL" || but.Name == "I" || but.Name == "K" || but.Name == "angleL")
            {
                but.Background = (Brush)bc.ConvertFrom("#FFFF2424");
            }
            else if (but.Name == "three" || but.Name == "w" || but.Name == "s" || but.Name == "x" || but.Name == "ten" ||
                but.Name == "o" || but.Name == "l" || but.Name == "dot" || but.Name == "sharp" || but.Name == "W" ||
                but.Name == "S" || but.Name == "X" || but.Name == "parenthesisR" || but.Name == "O" || but.Name == "L" ||
                but.Name == "angleR")
            {
                but.Background = (Brush)bc.ConvertFrom("#FFF5FF00");
            }
            else if (but.Name == "four" || but.Name == "butE" || but.Name == "d" || but.Name == "c" || but.Name == "minus" ||
                but.Name == "equally" || but.Name == "p" || but.Name == "forvardSlash" || but.Name == "squareL" ||
                but.Name == "squareR" || but.Name == "semicolon" || but.Name == "apostrophe" || but.Name == "backSlash" ||
                but.Name == "dollar" || but.Name == "ButE" || but.Name == "D" || but.Name == "C" || but.Name == "underscore" ||
                but.Name == "plus" || but.Name == "P" || but.Name == "quest" || but.Name == "braceL" || but.Name == "braceR" ||
                but.Name == "colon" || but.Name == "quote" || but.Name == "pipe")
            {
                but.Background = (Brush)bc.ConvertFrom("#FF18FF00");
            }
            else if (but.Name == "five" || but.Name == "six" || but.Name == "r" || but.Name == "t" || but.Name == "f" ||
                but.Name == "g" || but.Name == "v" || but.Name == "b" || but.Name == "percent" || but.Name == "caret" ||
                but.Name == "R" || but.Name == "T" || but.Name == "F" || but.Name == "G" || but.Name == "V" || but.Name == "B")
            {
                but.Background = (Brush)bc.ConvertFrom("#FF0096FF");
            }
            else if (but.Name == "seven" || but.Name == "eight" || but.Name == "y" || but.Name == "u" || but.Name == "h" ||
               but.Name == "j" || but.Name == "n" || but.Name == "m" || but.Name == "ampersand" || but.Name == "star" ||
               but.Name == "Y" || but.Name == "U" || but.Name == "H" || but.Name == "J" || but.Name == "N" || but.Name == "M")
            {
                but.Background = (Brush)bc.ConvertFrom("#FFFF00C0");
            }
            else
            {
                but.Background = (Brush)bc.ConvertFrom("#FFD9D9D9");
            }
        }

        private void Button_KeyDown(object sender, KeyEventArgs e)
        {
            var butts = sender as Button;
            ButtonPressBackGroung(butts);
            if (butts.Name == "shiftL" || butts.Name == "shiftR")
            {
                if (butts.Name == "shiftL")
                {
                    ButtonPressBackGroung(ShiftL);
                    ButtonBackGround(ShiftR);
                }
                else
                {
                    ButtonPressBackGroung(ShiftR);
                    ButtonBackGround(ShiftL);
                }
                shiftDown = true;
                ActivateShift(shiftDown); 
            }
        }

        private void ButtonPressBackGroung(Button but)
        {
            if (but.Name == "q" || but.Name == "a" || but.Name == "z" || but.Name == "tild" || but.Name == "one" ||
                but.Name == "two" || but.Name == "nine" || but.Name == "i" || but.Name == "k" || but.Name == "comma" ||
                but.Name == "Q" || but.Name == "A" || but.Name == "Z" || but.Name == "tilda" || but.Name == "bang" ||
                but.Name == "dog" || but.Name == "parenthesisL" || but.Name == "I" || but.Name == "K" || but.Name == "angleL")
            {
                but.Background = (Brush)bc.ConvertFrom("#FFBA2020");
            }
            else if (but.Name == "three" || but.Name == "w" || but.Name == "s" || but.Name == "x" || but.Name == "ten" ||
                but.Name == "o" || but.Name == "l" || but.Name == "dot" || but.Name == "sharp" || but.Name == "W" ||
                but.Name == "S" || but.Name == "X" || but.Name == "parenthesisR" || but.Name == "O" || but.Name == "L" ||
                but.Name == "angleR")
            {
                but.Background = (Brush)bc.ConvertFrom("#FFAAB100");
            }
            else if (but.Name == "four" || but.Name == "butE" || but.Name == "d" || but.Name == "c" || but.Name == "minus" ||
                but.Name == "equally" || but.Name == "p" || but.Name == "forvardSlash" || but.Name == "squareL" ||
                but.Name == "squareR" || but.Name == "semicolon" || but.Name == "apostrophe" || but.Name == "backSlash" ||
                but.Name == "dollar" || but.Name == "ButE" || but.Name == "D" || but.Name == "C" || but.Name == "underscore" ||
                but.Name == "plus" || but.Name == "P" || but.Name == "quest" || but.Name == "braceL" || but.Name == "braceR" ||
                but.Name == "colon" || but.Name == "quote" || but.Name == "pipe")
            {
                but.Background = (Brush)bc.ConvertFrom("#FF10A800");
            }
            else if (but.Name == "five" || but.Name == "six" || but.Name == "r" || but.Name == "t" || but.Name == "f" ||
                but.Name == "g" || but.Name == "v" || but.Name == "b" || but.Name == "percent" || but.Name == "caret" ||
                but.Name == "R" || but.Name == "T" || but.Name == "F" || but.Name == "G" || but.Name == "V" || but.Name == "B")
            {
                but.Background = (Brush)bc.ConvertFrom("#FF0166AD");
            }
            else if (but.Name == "seven" || but.Name == "eight" || but.Name == "y" || but.Name == "u" || but.Name == "h" ||
               but.Name == "j" || but.Name == "n" || but.Name == "m" || but.Name == "ampersand" || but.Name == "star" ||
               but.Name == "Y" || but.Name == "U" || but.Name == "H" || but.Name == "J" || but.Name == "N" || but.Name == "M")
            {
                but.Background = (Brush)bc.ConvertFrom("#FFA3007B");
            }
            else if(but.Name == "space")
            {
                but.Background = (Brush)bc.ConvertFrom("#FFB36D00");
            }
            else
            {
                but.Background = (Brush)bc.ConvertFrom("#FF979797");
            }
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            var but = sender as Button;
            ButtonBackGround(but);
            if (second.Text.Length > 0)
                second.Text = second.Text.Remove(second.Text.Length - 1);
            else
                return;
        }

        private void tab_Click(object sender, RoutedEventArgs e)
        {
            var but = sender as Button;
            but.Background = (Brush)bc.ConvertFrom("#FFD9D9D9");
            second.Text += "\t";
        }

        private void space_Click(object sender, RoutedEventArgs e)
        {
            var but = sender as Button;
            but.Background = (Brush)bc.ConvertFrom("#FFFF9B00");
            second.Text += " ";
            totalChar++;
        }

        private void shiftL_Click(object sender, RoutedEventArgs e)
        {
            var but = sender as Button;
            ButtonBackGround(but);
            shiftDown = false;
            ActivateShift(shiftDown);
        }

        private void ActivateShift(bool shift)
        {
            if(shift)
            {
                _wrap0.Visibility = Visibility.Visible;
                _wrap1.Visibility = Visibility.Visible;
                _wrap2.Visibility = Visibility.Visible;
                _wrap3.Visibility = Visibility.Visible;
                wrap0.Visibility = Visibility.Hidden;
                wrap1.Visibility = Visibility.Hidden;
                wrap2.Visibility = Visibility.Hidden;
                wrap3.Visibility = Visibility.Hidden;
            }
            else 
            {
                wrap0.Visibility = Visibility.Visible;
                wrap1.Visibility = Visibility.Visible;
                wrap2.Visibility = Visibility.Visible;
                wrap3.Visibility = Visibility.Visible;
                _wrap0.Visibility = Visibility.Hidden;
                _wrap1.Visibility = Visibility.Hidden;
                _wrap2.Visibility = Visibility.Hidden;
                _wrap3.Visibility = Visibility.Hidden;
            }
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slide = sender as Slider;
            difficulty.Content = slide.Value;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            first.Text = string.Empty;
            second.Text = string.Empty;
            speed = 0;
            speeds.Content = speed;
            fails = 0;
            fail.Content = fails;
            Start.IsEnabled = false;
            Stop.IsEnabled = true; 
            int dif = Convert.ToInt32(difficulty.Content);
            RandomText(dif);
        }

        private void RandomText(int diff)
        {
            if (chack.IsChecked == true)
            {
                diff = diff * 2;
            }
            Random rnd = new Random();
            for (int i = 1; i < 50; i++)
            {
                int random = rnd.Next(0, diff+1);
                switch (random)
                {
                    case 0: first.Text = (first.Text) + " "; break;
                    case 1: first.Text = (first.Text) + "a"; break;
                    case 2: first.Text = (first.Text) + "b"; break;
                    case 3: first.Text = (first.Text) + "c"; break;
                    case 4: first.Text = (first.Text) + "d"; break;
                    case 5: first.Text = (first.Text) + "e"; break;
                    case 6: first.Text = (first.Text) + "f"; break;
                    case 7: first.Text = (first.Text) + "g"; break;
                    case 8: first.Text = (first.Text) + "h"; break;
                    case 9: first.Text = (first.Text) + "i"; break;
                    case 10: first.Text = (first.Text) + "j"; break;
                    case 11: first.Text = (first.Text) + "k"; break;
                    case 12: first.Text = (first.Text) + "l"; break;
                    case 13: first.Text = (first.Text) + "m"; break;
                    case 14: first.Text = (first.Text) + "n"; break;
                    case 15: first.Text = (first.Text) + "o"; break;
                    case 16: first.Text = (first.Text) + "p"; break;
                    case 17: first.Text = (first.Text) + "q"; break;
                    case 18: first.Text = (first.Text) + "r"; break;
                    case 19: first.Text = (first.Text) + "s"; break;
                    case 20: first.Text = (first.Text) + "t"; break;
                    case 21: first.Text = (first.Text) + "u"; break;
                    case 22: first.Text = (first.Text) + "v"; break;
                    case 23: first.Text = (first.Text) + "w"; break;
                    case 24: first.Text = (first.Text) + "x"; break;
                    case 25: first.Text = (first.Text) + "y"; break;
                    case 26: first.Text = (first.Text) + "z"; break;

                    case 27: first.Text = (first.Text) + "A"; break;
                    case 28: first.Text = (first.Text) + "B"; break;
                    case 29: first.Text = (first.Text) + "C"; break;
                    case 30: first.Text = (first.Text) + "D"; break;
                    case 31: first.Text = (first.Text) + "E"; break;
                    case 32: first.Text = (first.Text) + "F"; break;
                    case 33: first.Text = (first.Text) + "G"; break;
                    case 34: first.Text = (first.Text) + "H"; break;
                    case 35: first.Text = (first.Text) + "I"; break;
                    case 36: first.Text = (first.Text) + "J"; break;
                    case 37: first.Text = (first.Text) + "K"; break;
                    case 38: first.Text = (first.Text) + "L"; break;
                    case 39: first.Text = (first.Text) + "M"; break;
                    case 40: first.Text = (first.Text) + "N"; break;
                    case 41: first.Text = (first.Text) + "O"; break;
                    case 42: first.Text = (first.Text) + "P"; break;
                    case 43: first.Text = (first.Text) + "Q"; break;
                    case 44: first.Text = (first.Text) + "R"; break;
                    case 45: first.Text = (first.Text) + "S"; break;
                    case 46: first.Text = (first.Text) + "T"; break;
                    case 47: first.Text = (first.Text) + "U"; break;
                    case 48: first.Text = (first.Text) + "V"; break;
                    case 49: first.Text = (first.Text) + "W"; break;
                    case 50: first.Text = (first.Text) + "X"; break;
                    case 51: first.Text = (first.Text) + "Y"; break;
                    case 52: first.Text = (first.Text) + "Z"; break;
                }
            }
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Stop.IsEnabled = false;
            Start.IsEnabled = true;
            timer.Stop();
        }

        private void second_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(Start.IsEnabled==false)
            {
                if (second.Text.Length == first.Text.Length)
                {
                    Stop_Click(Stop, e);
                }
                else
                {
                    if (second.Text.Length > 1)
                    {
                        if (first.Text[second.Text.Length - 1] != second.Text[second.Text.Length - 1])
                        {
                            fails++;
                            fail.Content = fails;
                            second.Text = second.Text.Remove(second.Text.Length - 1);
                        }
                    }
                }
            }
        }

        private void timer_Tick (object sender, EventArgs e)
        {
            time += 2;
            speed = (totalChar*60 / time) ;
            speeds.Content = speed;
        }
    }
}
