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
        
        private int cellSize = 20;
        private int rows;
        private int cols;
        
        private int[][] grid;


        public MainWindow()
        {
            InitializeComponent();
            paintSurface.UpdateLayout();

            rows = 40;//(int)(paintSurface.ActualHeight / cellSize);
            cols = 60;//(int)(paintSurface.ActualWidth / cellSize);
            grid = new int[rows][];
            for (int i = 0; i < rows; i++)
                grid[i] = new int[cols];

            GenerateRandomPattern();

            timer.Interval = TimeSpan.FromMilliseconds(50);
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

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    aux[i][j] = CheckCellStatus(i, j);
                }
            }
            grid = aux;
        }

        private int CheckCellStatus(int row, int col)
        {
            int neigh = NeighbourCount(row, col);
            if (grid[row][col] == 1)
            {
                if (neigh < 2)
                {
                    return 0;
                }
                if (neigh == 2 || neigh == 3)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else if (grid[row][col] == 0 && neigh == 3)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        int NeighbourCount(int r, int c)
        {
            //top left
            if (r == 0 && c == 0)
            {
                return grid[r][c + 1] + grid[r + 1][c + 1] + grid[r + 1][c];
            }
            //top right
            if (r == 0 && c == cols - 1)
            {
                return grid[r + 1][c] + grid[r + 1][c - 1] + grid[r][c - 1];
            }
            //bottom left
            if (r == rows - 1 && c == 0)
            {
                return grid[r - 1][c] + grid[r - 1][c + 1] + grid[r][c + 1];
            }
            //bottom right
            if (r == rows - 1 && c == cols - 1)
            {
                return grid[r][c - 1] + grid[r - 1][c - 1] + grid[r - 1][c];
            }
            //top edge
            if (r == 0)
            {
                return grid[r][c + 1] + grid[r + 1][c + 1] + grid[r + 1][c] + grid[r + 1][c - 1] + grid[r][c - 1];
            }
            //right edge
            if (c == cols - 1)
            {
                return grid[r + 1][c] + grid[r + 1][c - 1] + grid[r][c - 1] + grid[r - 1][c - 1] + grid[r - 1][c];
            }
            //bottom edge
            if (r == rows - 1)
            {
                return grid[r][c - 1] + grid[r - 1][c - 1] + grid[r - 1][c] + grid[r - 1][c + 1] + grid[r][c + 1];
            }
            //left edge
            if (c == 0)
            {
                return grid[r - 1][c] + grid[r - 1][c + 1] + grid[r][c + 1] + grid[r + 1][c + 1] + grid[r + 1][c];
            }
            //inside
            return grid[r - 1][c - 1] + grid[r - 1][c] + grid[r - 1][c + 1] +
                   grid[r][c - 1] + grid[r][c + 1] +
                   grid[r + 1][c - 1] + grid[r + 1][c] + grid[r + 1][c + 1];
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
                Fill = Brushes.Yellow
            };
            Canvas.SetLeft(cell, col * cellSize);
            Canvas.SetTop(cell, row * cellSize);
            paintSurface.Children.Add(cell);
        }

        private void RandomPattern_Click(object sender, RoutedEventArgs e)
        {
            GenerateRandomPattern();
        }

        private void StopTime_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.IsEnabled = false;
                TimeButton.Content = "Start time";
                NextButton.IsEnabled = true;
            }
            else
            {
                timer.IsEnabled = true;
                TimeButton.Content = "Stop time";
                NextButton.IsEnabled = false;
            }
        }
        

        private void paintSurface_MouseDown(object sender, MouseButtonEventArgs e)
        {
            double x = e.GetPosition(paintSurface).X;
            double y = e.GetPosition(paintSurface).Y;
            Title = $"titlu : {x} {y}";

            int row = (int)(y / cellSize);
            int col = (int)(x / cellSize);

            if (row < rows && col < cols)
            {
                grid[row][col] = 1 - grid[row][col];
            }
            DrawGrid();
        }

        private void NextGeneration_Click(object sender, RoutedEventArgs e)
        {
            paintSurface.Children.Clear();
            DrawGrid();
            FindNextGeneration();
        }


    }
}
