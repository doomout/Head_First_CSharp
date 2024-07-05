﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Shoes
{
    internal class Shoe
    {
        public Style Style { get; private set; }
        public string Color {  get; private set; }
        public Shoe(Style style, string color)
        {
            Style = style;
            Color = color;
        }
        public string Description
        {
            get { return $"A {Color} {Style}"; }
        }
    }
}
