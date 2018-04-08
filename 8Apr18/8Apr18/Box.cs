using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Apr18
{
    class Box
    {
        public double Width;
        public double Length;
        public double Height;
        private string _result;

        public Box(double Width, double Length, double Height)
        {
            this.Width = Width;
            this.Length = Length;
            this.Height = Height;
        }

        public string Result
        {
            get
            {
                this.Volume();
                return this._result;
                
            }
        }

        private void Volume()
        {
            this._result = "Qutunun hecmi: "+(this.Width * this.Length * this.Height);
        }        

    }
}
