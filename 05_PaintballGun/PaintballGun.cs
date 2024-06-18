using System;
using System.Collections.Generic;
using System.Text;

namespace _05_PaintballGun
{
    /// <summary>
    /// 페인트 총 게임을 위한 클래스
    /// </summary>
    internal class PaintballGun
    {
        public const int MAGAZINE_SIZE = 16; //

        private int balls = 0;
        private int ballsLoaded = 0;

        public int GetBallsLoaded() { return ballsLoaded; } //게임에서 남은 페인트볼 개수
        
        public bool IsEmpty() { return ballsLoaded == 0; }
        public int GetBalls() { return balls; } //장전된 페인트 볼 개수
        public void SetBalls(int numberOfBalls) //페인트볼 개수 지정
        {
            if (numberOfBalls > 0)  //양수만 허용
                balls = numberOfBalls;
            Reload(); //재장전
        }

        public void Reload() 
        {
            if (balls > MAGAZINE_SIZE) //탄창 최고치보다 많다면.
                ballsLoaded = MAGAZINE_SIZE; //최고치로 장전
            else //탄창 최고치 보다 적다면.
                ballsLoaded = balls; //가지고 있는 볼만큼만 장전
        }

        public bool Shoot() //공이 장전되어 있으면 true, 없으면 false
        {
            if (ballsLoaded == 0) return false; 
            ballsLoaded--;
            balls--;
            return true;
        }
    }
}
