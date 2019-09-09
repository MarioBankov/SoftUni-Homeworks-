using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public  class Score
    {
        public int PlayerScore { get;  set; }
        
        public int Level => PlayerScore / 1000 +1;
       
    }
}
