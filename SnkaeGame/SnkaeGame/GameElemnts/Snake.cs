﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SnakeGame.GameElemnts
{
    class Snake:GameIntity
    {
        public Snake(int size)
        {
            Rectangle rect = new Rectangle();
            rect.Width = size;
            rect.Height = size;
            rect.Fill = Brushes.Green;
            UIElement = rect;

        }

        public bool IsHead { get; set; }
    }
}
