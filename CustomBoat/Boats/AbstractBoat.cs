using Microsoft.SqlServer.Server;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;

namespace CustomBoat
{
    public abstract class AbstractBoat
    {
        public int x { protected set; get; }
        public int y { protected set; get; }
        public int width { protected set; get; }
        public int height { protected set; get; }
        public int direction { protected set; get; }
        public int speed { protected set; get; }
        public Image image { protected set; get; }

        private Hashtable chooseDirection;

        public AbstractBoat()
        {
            chooseDirection = new Hashtable();
            chooseDirection.Add("left", -1);
            chooseDirection.Add("right", +1);
        }

        public bool SetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
            return true;
        }

        public bool SetCords(int x, int y)
        {
            this.x = x;
            this.y = y;
            return true;
        }

        public bool SetDirection(string where)
        {
            direction = (int)chooseDirection[where];
            return true;
        }

        public bool SetSpeed(int speed)
        {
            this.speed = speed;
            return true;
        }

        public abstract AbstractBoat GetCopy();
    }
}
