using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.Models
{
    enum SnakeHeadDirection
    {
        Up = 1,
        Right,
        Down,
        Left
    }

    enum MapContent
    {
        Space = 0,
        SnakeBodyUp,
        SnakeBodyQ1,
        SnakeBodyRight
    }


    class SnakeWorld
    {
        private bool m_borderless;
        private byte[,] m_mapContent;

        private SnakeHeadDirection m_snakeHeadDirection;
        private short m_snakeHeadX, m_snakeHeadY;
        private short m_freshPreyX, m_freshPreyY;
        private short m_eatenPreyX, m_eatenPreyY;


    }
}
