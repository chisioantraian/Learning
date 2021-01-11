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

            rows = 30;//(int)(paintSurface.ActualHeight / cellSize);
            cols = 30;//(int)(paintSurface.ActualWidth / cellSize);
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

        int NeighbourCount(int row, int col)
        {
            //top left
            if (row == 0 && col == 0)
            {
                return grid[row][col + 1] + grid[row + 1][col + 1] + grid[row + 1][col];
            }
            //top right
            if (row == 0 && col == cols - 1)
            {
                return grid[row + 1][col] + grid[row + 1][col - 1] + grid[row][col - 1];
            }
            //bottom left
            if (row == rows - 1 && col == 0)
            {
                return grid[row - 1][col] + grid[row - 1][col + 1] + grid[row][col + 1];
            }
            //bottom right
            if (row == rows - 1 && col == cols - 1)
            {
                return grid[row][col - 1] + grid[row - 1][col - 1] + grid[row - 1][col];
            }
            //top edge
            if (row == 0)
            {
                return grid[row][col + 1] + grid[row + 1][col + 1] + grid[row + 1][col] + grid[row + 1][col - 1] + grid[row][col - 1];
            }
            //right edge
            if (col == cols - 1)
            {
                return grid[row + 1][col] + grid[row + 1][col - 1] + grid[row][col - 1] + grid[row - 1][col - 1] + grid[row - 1][col];
            }
            //bottom edge
            if (row == rows - 1)
            {
                return grid[row][col - 1] + grid[row - 1][col - 1] + grid[row - 1][col] + grid[row - 1][col + 1] + grid[row][col + 1];
            }
            //left edge
            if (col == 0)
            {
                return grid[row - 1][col] + grid[row - 1][col + 1] + grid[row][col + 1] + grid[row + 1][col + 1] + grid[row + 1][col];
            }
            //inside
            return grid[row - 1][col - 1] + grid[row - 1][col] + grid[row - 1][col + 1] +
                   grid[row][col - 1] + grid[row][col + 1] +
                   grid[row + 1][col - 1] + grid[row + 1][col] + grid[row + 1][col + 1];
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
