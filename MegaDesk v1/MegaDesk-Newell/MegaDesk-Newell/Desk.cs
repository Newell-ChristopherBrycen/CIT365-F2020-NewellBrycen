using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Newell
{
    class Desk
    {
        // Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        // create and constrain desk width
        private int setwidth;
        public int DeskWidth
        {
            get { return setwidth; }
            set
            {
                if (value >= MINWIDTH && value <= MAXWIDTH)
                {
                    setwidth = value;
                }
                else
                    throw new Exception("Width must be between 24 and 96");

            }
        }
        private int setdepth;
        public int DeskDepth
        {
            get
            {
                return setdepth;
            }
            set
            {
                if (value >= MINDEPTH && value <= MAXDEPTH)
                {
                    setdepth = value;
                }
                else
                    throw new Exception("Depth must be between 12 and 48");
            }

        }

        private int setdrawers;
        public int numberOfDrawers
        {
            get
            {
                return setdrawers;
            }
            set
            {
                if (value >= MINDRAWERS && value <= MAXDRAWERS)
                {
                    setdrawers = value;
                }
                else
                    throw new Exception("Incorrect number of drawers, must be between 0 and 7");
            }
        }
        public enum DeskMaterial
        {
            Pine, Laminate, Veneer, Oak, Rosewood
        }
        public DeskMaterial Material
        {
            get; set;
        }

        public Desk(int width, int depth, int drawers, DeskMaterial material)
        {
            this.DeskWidth = width;
            this.DeskDepth = depth;
            this.numberOfDrawers = drawers;
            this.Material = material;
        }

        public int GetArea()
        {
            return DeskWidth * DeskDepth;
        }
    }
}
