//Omri Meller
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_2
{
    internal class Ball
    {
        int screenWidth;
        int screenHeight;
        private static Random random = new Random();
        public int radius { get; set; }
        public Color color { get; set; }
        public int step { get; set; }
        public int locationX { get; set; }
        public int locationY { get; set; }
        public Boolean dirX { get; set; }
        public Boolean dirY { get; set; }
        public Boolean stop { get; set; }
        public Ball(int width, int height)
        {
            screenWidth = width;
            screenHeight = height;
            radius = GenerateRandomNumber(10, 40);
            color = GenerateRandomColor();
            step = GenerateRandomNumber(1, 5);
            locationX = GenerateRandomNumber(radius, screenWidth - radius);
            locationY = GenerateRandomNumber(radius, screenHeight - radius);
            dirX = GenerateRandomBoolean();
            dirY = GenerateRandomBoolean();
            stop = false;
        }

        public void move()
        {
            int hit = hitWall();
            if (hit != 0)
            {
                //Change step size if hit wall
                step = GenerateRandomNumber(1, 5);
                if (hit == 1)
                {
                    dirX = !dirX;
                    dirY = !dirY;
                }
                else if (hit == 2)
                    dirX = !dirX;
                else
                    dirY = !dirY;
            }
            if (dirX)
                locationX += step;
            else
                locationX -= step;
            if (dirY)
                locationY += step;
            else
                locationY -= step;
        }

        public int hitWall()
        {
            bool hitX = false;
            bool hitY = false;

            if (((locationX + radius) >= screenWidth) && (dirX == true) || ((locationX - radius) <= 0) && (dirX == false))
                hitX = true;
            if (((locationY + radius) >= screenHeight) && (dirY == true) || ((locationY - radius) <= 0) && (dirY == false))
                hitY = true;

            if (hitX && hitY)
                return 1; // Corner collision
            if (hitX)
                return 2; // Horizontal wall collision
            if (hitY)
                return 3; // Vertical wall collision

            return 0; // No collision
        }



        public int GenerateRandomNumber(int n, int m)
        {
            return random.Next(n, m);
        }

        public Color GenerateRandomColor()
        {
            byte r = (byte)random.Next(256); // Generate a random value for the red component (0-255)
            byte g = (byte)random.Next(256); // Generate a random value for the green component (0-255)
            byte b = (byte)random.Next(256); // Generate a random value for the blue component (0-255)

            return Color.FromArgb(r, g, b);
        }

        public bool GenerateRandomBoolean()
        {
            return random.Next(2) == 0;
        }
    }
}
