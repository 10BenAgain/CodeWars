using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata
{
    public class Block
    {
        private readonly int[] myBlock;
        public Block(int[] array) { myBlock = array; }
        public int GetWidth() { return myBlock[0]; }
        public int GetLength() { return myBlock[1]; }
        public int GetHeight() { return myBlock[2]; }
        public int GetVolume() { return myBlock[0] * myBlock[1] * myBlock[2]; }
        public int GetSurfaceArea() { return 2 * (myBlock[1] * myBlock[0] + myBlock[0] * myBlock[2] + myBlock[1] * myBlock[2]); }
        
    }
}
