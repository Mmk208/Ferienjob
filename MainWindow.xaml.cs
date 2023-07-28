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
using SnakeGame.GameElemnts; 

namespace SnakeGame
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int elementSize = 20;
        private int numberOfColumns;
        private int numberOfRows;
        private Random randomTron;

        DispatcherTimer _gameLoopTimer;
        List<Snake> snakeElem;
        List<Apple> appleElem;
        private Direction currentDirection;
        private int gameWidth;
        private int gameHeight;
        private long elaspedTicks;
        

        public MainWindow()
        {
            InitializeComponent();
            randomTron = new Random(DateTime.Now.Millisecond / DateTime.Now.Second);
            appleElem = new List<Apple>();
            InitializeTimer();
            DrawGameWorld();
            InitializeSnake();
            DrawSnake();
        }
        private void MainGameLoop(object sender, EventArgs e)
        {
            MoveSnake();
            CheckColllision();
            DrawSnake();
            CreateApple();
            DrawApple();

        }

        private void DrawSnake()
        {
            foreach (var snakeUsed in snakeElem)
            {
                if (!GameWorld.Children.Contains(snakeUsed.UIElement))
                
                    GameWorld.Children.Add(snakeUsed.UIElement);
                    Canvas.SetLeft(snakeUsed.UIElement, snakeUsed.x);
                    Canvas.SetTop(snakeUsed.UIElement, snakeUsed.y);
                

            }
        }

        private void InitializeSnake()
        {
            snakeElem = new List<Snake>();
            snakeElem.Add(new Snake(elementSize)
            {
                x = (numberOfRows / 2) * elementSize,
                y = (numberOfColumns / 2) * elementSize,
                IsHead = true
            });
            currentDirection = Direction.Left;
        }

        private void DrawGameWorld()
        {
            gameWidth = (int)Width;
            gameHeight = (int)Height;
         numberOfColumns = gameWidth/ elementSize;
         numberOfRows = gameHeight/ elementSize;

            for (int i = 0; i < numberOfRows; i++)
            {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = 0;
                line.Y1 = i * elementSize;
                line.X2 = gameWidth;
                line.Y2 = i * elementSize;
                GameWorld.Children.Add(line);

            }

            for (int i = 0; i < numberOfColumns; i++)
            {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = i * elementSize;
                line.Y1 = 0;
                line.X2 = i * elementSize;
                line.Y2 = gameHeight;
                GameWorld.Children.Add(line);

            }

        }

        public void InitializeTimer()
        {
            _gameLoopTimer = new DispatcherTimer();
            _gameLoopTimer.Interval = TimeSpan.FromSeconds(0.2);
            _gameLoopTimer.Tick += MainGameLoop;
            _gameLoopTimer.Start();
        }

        

        private void DrawApple()
        {
            foreach (var apple in appleElem)
            {
                if (!GameWorld.Children.Contains(apple.UIElement))

                    GameWorld.Children.Add(apple.UIElement);
                Canvas.SetLeft(apple.UIElement, apple.x);
                Canvas.SetTop(apple.UIElement, apple.y);


            }
        }

        private void CreateApple()
        {
            if (elaspedTicks % 13 == 0)
            {
                appleElem.Add(new Apple(elementSize)
                {
                    x = randomTron.Next(0, numberOfColumns) * elementSize,
                    y = randomTron.Next(0, numberOfRows) * elementSize
                });
            }
        }

        private void CheckColllision()
        {
            CheckCollisionWithWorldBounds();
            CheckCollisionWithSelf();
            CheckColllisionWithWorldItems();

        }

        private void CheckColllisionWithWorldItems()
        {
            Snake head = GetSnakeHead();
            if (head.x > gameWidth - elementSize || 
                head.x < 0 || head.y < 0 ||
                head.y > gameHeight - elementSize)
                    {
                        MessageBox.Show("!!!!GAME OVER!!!!");
                    }
            
        }

        private void CheckCollisionWithSelf()
        {
            Snake head = GetSnakeHead();

            if (head != null)
            {
                {
                    foreach (var snakeUsed in snakeElem)
                    {
                        if (!snakeUsed.IsHead)
                        {
                            if (snakeUsed.x == head.x && snakeUsed.y == head.y)
                            {
                                MessageBox.Show("!!!!GAME OVER!!!!");
                            }
                            break;
                        }
                    }

                }
            }
        }

        private Snake GetSnakeHead()
        {
            Snake head = null;
            foreach (var snakeUsed in snakeElem)
            {
                if (snakeUsed.IsHead)
                {
                    head = snakeUsed;
                    break;
                }
            }
            return head;
        }

        private void CheckCollisionWithWorldBounds()
        {
            
        }

        private void MoveSnake()
        {
            foreach (var snakeUsed in snakeElem)
            {
                switch (currentDirection)
                {
                    case Direction.Right:
                        snakeUsed.x += elementSize;
                        break;
                    case Direction.Left:
                        snakeUsed.x -= elementSize;
                        break;
                    case Direction.Up:
                        snakeUsed.y -= elementSize;
                        break;
                    case Direction.Down:
                        snakeUsed.y += elementSize;
                        break;
                    default:
                        break;
                }
                
            }

        }

        private void KeyWasRealesed(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    currentDirection = Direction.Up;
                    break;
                case Key.A:
                    currentDirection = Direction.Left;
                    break;
                case Key.S:
                    currentDirection = Direction.Down;
                    break;
                case Key.D:
                    currentDirection = Direction.Right;
                    break;
            }

        }
    }
    enum Direction
    {
        Right,
        Left,
        Up,
        Down
    }
}
