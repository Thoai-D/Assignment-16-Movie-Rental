using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_16_Movie_Rental
{
    class Movie
    {
        private string Name;
        private int Length;
        private bool Available;

        public Movie(string name, int length)
        {
            Name = name;
            Length = length;
            Available = true;
        }



        public string GetName()
        {
            return Name;
        }

        public int GetLength()
        {
            return Length;
        }

        public bool IsAvailable()
        {
            return Available;
        }

        public void BorrowMovie()
        {
            if(Available == true)
            {
                Available = false;
            }
        }

        public void ReturnMovie()
        {
            if(Available == false)
            {
                Available = true;
            }
        }
    }
}
