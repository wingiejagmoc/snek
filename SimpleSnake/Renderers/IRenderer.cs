using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.Renderers
{
    interface IRenderer
    {
        void Render(Graphics g);
    }
}
