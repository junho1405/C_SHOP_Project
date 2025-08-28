using System;
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

        public abstract void Activate();//이거 넣었으면 다른곳에 전부 상속시켜줘야 에러가 안남

        public abstract void Description();
        
    }
    

}
