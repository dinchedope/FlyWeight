﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBoat
{
    public class SailBoat : AbstractBoat
    {
        public SailBoat(Image img)
        {
            this.image = img;
            this.width = img.Width;
            this.height = img.Height;

            this.x = 0;
            this.y = 0;


            this.SetDirection("right");
        }

        private SailBoat()
        {

        }

        public override AbstractBoat GetCopy()
        {
            return new SailBoat { image = this.image, x = this.x, y = this.y, width = this.width, height = this.height, speed = this.speed, direction = this.direction, };
        }
    }
}
