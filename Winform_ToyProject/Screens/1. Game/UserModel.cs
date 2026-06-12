using System;
using System.Collections.Generic;
using System.Text;

namespace Winform_ToyProject.Screens._1._Game
{
    public class UserModel
    {
        // 플레이어 이름
        public string Name { get; set; }
        // 현재 점수
        public int Score { get; set; } = 0;
        // 남은 목숨
        public int Lives { get; set; } = 3;

        public UserModel(string name)
        {
            Name = name;
        }
    }
}
