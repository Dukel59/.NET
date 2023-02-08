using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess
{
    public partial class Form1 : Form
    {
        public Image chess;
        ContextMenu menu;
        int[,] map = new int[8,8]
        {
        { 15,14,13,12,11,13,14,15},
        { 16,16,16,16,16,16,16,16},
        { 0,0,0,0,0,0,0,0},
        { 0,0,0,0,0,0,0,0},
        { 0,0,0,0,0,0,0,0},
        { 0,0,0,0,0,0,0,0},
        { 26,26,26,26,26,26,26,26},
        { 25,24,23,22,21,23,24,25} 
        };
        Button[,] buttons = new Button[8, 8];
        public Form1()
        {
            InitializeComponent();

            chess = new Bitmap("C:\\WF_project\\Chess\\Chess\\chess.png");
            
            Init();
        }

        private void Init()
        {
            CreateMap();
        }


        private void CreateMap()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    buttons[i, j] = new Button();
                    Button button = new Button();
                    button.Location = new Point(j * 50, i * 50);
                    button.Size = new Size(50, 50);

                    if(i%2==0)
                    {
                        if(j%2==0)
                        {
                            button.BackColor = Color.FromArgb(247, 245, 210);
                        }
                        else
                        {
                            button.BackColor = Color.DarkOliveGreen;
                        }
                    }
                    else
                    {
                        if(j%2==0)
                        {
                            button.BackColor = Color.DarkOliveGreen;
                        }
                        else
                        {
                            button.BackColor = Color.FromArgb(247, 245, 210);
                        }
                    }
                    

                    switch (map[i,j]/10)
                    {
                        case 1:
                            Image figure = new Bitmap(50, 50);
                            Graphics g = Graphics.FromImage(figure);
                            g.DrawImage(chess, new Rectangle(0, 0, 50, 50), 0+150*(map[i,j]%10-1), 0, 155, 155, GraphicsUnit.Pixel);
                            button.BackgroundImage = figure;
                            break;
                        case 2:
                            Image figure1 = new Bitmap(50, 50);
                            Graphics g1 = Graphics.FromImage(figure1);
                            g1.DrawImage(chess, new Rectangle(0, 0, 50, 50), 0 + 150 * (map[i, j] % 10-1), 155, 155, 155, GraphicsUnit.Pixel);
                            button.BackgroundImage = figure1;
                            break;
                    }

                    this.Controls.Add(button);
                    buttons[i, j] = button;
                    if(i == 1 || i ==6)
                    {
                        menu = new ContextMenu();
                        menu.MenuItems.Add("Ходит на одну клетку вперед");
                        buttons[i, j].ContextMenu = menu;
                    }
                    else if(i==0 || i ==7)
                    {
                        if(j ==0 || j ==7)
                        {
                            menu = new ContextMenu();
                            menu.MenuItems.Add("Ходит по вертикали и горизонтали");
                            buttons[i, j].ContextMenu = menu;
                        }
                        else if (j==1 || j==6)
                        {
                            menu = new ContextMenu();
                            menu.MenuItems.Add("Ходит буквой \"Г\"");
                            buttons[i, j].ContextMenu = menu;
                        }
                        else if (j ==2 || j == 5)
                        {
                            menu = new ContextMenu();
                            menu.MenuItems.Add("Ходит по диагонали");
                            buttons[i, j].ContextMenu = menu;
                        }
                        else if (j==3)
                        {
                            menu = new ContextMenu();
                            menu.MenuItems.Add("Ходит по вертикали и горизонтали на любое расстояние");
                            buttons[i, j].ContextMenu = menu;
                        }
                        else
                        {
                            menu = new ContextMenu();
                            menu.MenuItems.Add("Ходит по вертикали и горизонтали на одну клетку");
                            buttons[i, j].ContextMenu = menu;
                        }
                    }
                }
            }
        }
    }
}
