using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject.Screens._1._Game
{
    public class GameModel
    {
        // 현재 점수
        public int Score { get; set; } = 0;

        // 남은 목숨
        public int Lives { get; set; } = 3;
    }
}
