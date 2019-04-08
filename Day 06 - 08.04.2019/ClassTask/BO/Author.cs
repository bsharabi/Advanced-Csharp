using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    class Author
    {
        private string name;

        public string Name
        {
            get { return name; }
            set {
                if(value.Length>3 && value.Length > 20)
                    name = value; }
        }

        private int age;

        public int Age 
        {
            get { return age; }
            set {
                if(value >18 && value < 120)
                    age = value;
            }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

    }
}
