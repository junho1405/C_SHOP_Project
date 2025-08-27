﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal abstract class Terrain
    {
        protected int width;
        protected int height;

        public int Width {  get { return width; } }
        public int Height { get { return height; } }
        public Terrain(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract void Activate();

        public abstract void Description();
        
    }
    

}
