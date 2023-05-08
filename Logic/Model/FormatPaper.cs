﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Model
{
    public class FormatPaper
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public FormatPaper() { }
        
        public FormatPaper(int width, int height)
        {
            Width = width;
            Height = height;    
        }

        public static FormatPaper A4 => new FormatPaper(10, 20);
        
    }
}
