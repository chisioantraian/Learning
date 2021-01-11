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
using System.Windows.Threading;

namespace GameOfLife
{
    
    public partial class MainWindow : Window
    {
        private readonly Random random = new Random();
        private readonly DispatcherTimer timer = new DispatcherTimer();
        
        private int cellSize = 25;
        private int rows;
        private int cols;
        
        private int[][] grid;


        public MainWindow()
        {
            InitializeComponent();
            paintSurface.UpdateLayout();

            rows = 20;//(int)(paintSurface.ActualHeight / cellSize);
            cols = 20;//(int)(paintSurface.ActualWidth / cellSize);
            grid = new int[rows][];
            for (int i = 0; i < rows; i++)
                grid[i] = new int[cols];

            GenerateRandomPattern();



            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            paintSurface.Children.Clear();
            DrawGrid();
            FindNextGeneration();
        }

        private void FindNextGeneration()
        {
            int[][] aux = new int[rows][];
            for (int i = 0; i < rows; i++)
                aux[i] = new int[cols];

            //
        }

        private void GenerateRandomPattern()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    grid[i][j] = random.Next() % 2;
                }
            }
        }

        private void DrawGrid()
        {
            Title = $"{rows}, {cols}, {paintSurface.ActualWidth}, {paintSurface.ActualHeight}";

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        DrawCell(row, col);
                    }
                }
            }
        }

        private void DrawCell(int row, int col)
        {
            var cell = new Rectangle
            {
                Width = cellSize,
                Height = cellSize,
                Fill = Brushes.Black
            };
            Canvas.SetLeft(cell, row * cellSize);
            Canvas.SetTop(cell, col * cellSize);
            //cell.SetValue(Canvas.LeftProperty, row * cellSize);
            //cell.SetValue(Canvas.TopProperty, col * cellSize);
            paintSurface.Children.Add(cell);
        }

        private void RandomPattern_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StopTime_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void paintSurface_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
