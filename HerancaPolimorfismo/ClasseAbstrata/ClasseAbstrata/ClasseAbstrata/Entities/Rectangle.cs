﻿using System;
using System.Collections.Generic;
using System.Text;
using ClasseAbstrata.Enum;

namespace ClasseAbstrata.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color){

            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }


    }
}
