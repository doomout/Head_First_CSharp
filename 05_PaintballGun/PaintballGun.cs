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
        public const int MAGAZINE_SIZE = 16; 

        private int balls = 0;
        public int BallsLoaded { get; private set; } //자동 구현 속성(prop + 탭 2번) 읽기 전용

        public int GetBallsLoaded() { return BallsLoaded; } //게임에서 남은 페인트볼 개수
        
        public bool IsEmpty() { return BallsLoaded == 0; }

        /** 기존 코드
        public int GetBalls() { return balls; } //장전된 페인트 볼 개수
        public void SetBalls(int numberOfBalls) //페인트볼 개수 지정
        {
            if (numberOfBalls > 0)  //양수만 허용
                balls = numberOfBalls;
            Reload(); //재장전
        }
        */

        //기존 코드를 속성으로 변경
        //속성이란? 사용할 때는 필드처럼 보이지만, 실제로는 메서드 처럼 실행되는 클래스 멤버
        public int Balls //속성 타입이 int고 이름은 Balls
        {
            get { return balls; } //장전된 페인트 볼 개수

            set //페인트볼 개수 지정
            {
                if(value > 0)  //양수만 허용
                    balls = value;  //value 는 setter에 의해 할당되는 값을 저장
                Reload(); //재장전
            }
        }


        public void Reload() 
        {
            if (balls > MAGAZINE_SIZE) //탄창 최고치보다 많다면.
                BallsLoaded = MAGAZINE_SIZE; //최고치로 장전
            else //탄창 최고치 보다 적다면.
                BallsLoaded = balls; //가지고 있는 볼만큼만 장전
        }

        public bool Shoot() //공이 장전되어 있으면 true, 없으면 false
        {
            if (BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }


    }
}
