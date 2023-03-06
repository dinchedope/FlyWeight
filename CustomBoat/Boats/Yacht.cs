using System;
using System.Drawing;

namespace CustomBoat
{
    public class Yacht : AbstractBoat
    {
        public Yacht(Image img)
        {
            this.image = img;
            this.width = img.Width;
            this.height = img.Height;

            this.x = 0;
            this.y = 0;


            this.SetDirection("right");
        }

        private Yacht()
        {

        }

        public override AbstractBoat GetCopy()
        {
            return new Yacht { image = this.image, x = this.x, y = this.y, width = this.width, height = this.height, speed = this.speed, direction = this.direction, };
        }
    }
}
