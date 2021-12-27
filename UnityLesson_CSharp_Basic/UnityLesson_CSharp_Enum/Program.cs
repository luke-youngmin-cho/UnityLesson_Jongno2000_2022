﻿using System;
// enum (enumerated type) 열거형.
// enum 은 겹치지 않는것이 전제.
enum e_PlayerState
{
    IDLE, // ...0000000
    ATTACK, // ...0000001
    JUMP, // ...0000010
    WALK, // ...0000011
    RUN, // ...0000100
    DASH, // ...0000101
    HOME // ...0000110
}
[Flags]
enum e_PlayerStateFlags
{
    IDLE = 0, // ...00000000
    ATTACK = 1 << 0,// ...00000001
    JUMP = 1 << 1, // ...00000010
    WALK = 1 << 2, // ...00000100
    RUN = 1 << 3, // ...00001000
    DASH = 1 << 4,// ...00010000
    HOME = 1 << 5,// ...00100000
    ATTACK_JUMP = ATTACK| JUMP // // ...00000011
}
namespace UnityLesson_CSharp_Enum
{
    class Program
    {
        // 캐릭터 생성시 보여줄 모션 
        static public bool doAttack = true;
        static public bool doJump;
        static public bool doWalk;
        static public bool doRun;
        static public bool doDash;
        static public bool doHome;

        static public e_PlayerState createMotion = e_PlayerState.JUMP;
        static void Main(string[] args)
        {
            e_PlayerStateFlags state = e_PlayerStateFlags.IDLE;

            if (state == e_PlayerStateFlags.IDLE)
            {
                // switch - case 분기문 
                //switch (조건변수(참/거짓이 아닌 다양한 타입이 될 수 있음))
                //{
                //    case 조건1:
                //        break;
                //    case 조건2:
                //        break;
                //    case 조건3:
                //        break;
                //    default:
                //        // 어느 경우도 해당되지 않을경우 
                //        break;
                //}

                // string case 예시
                Console.WriteLine("검색할 캐릭터의 이름을 입력하세요");
                string name = Console.ReadLine();
                switch (name)
                {
                    case "철수":
                        Console.WriteLine("내이름은 철수, NPC 입니다");
                        break;
                    case "영희":
                        Console.WriteLine("내이름은 영희, NPC 입니다");
                        break;
                    default:
                        Console.WriteLine($"내이름은 {name}, 플레이어입니다");
                        break;
                }

                // 전사 함수 예시
                Console.WriteLine("전사를 생성합니다. 캐릭터 이름을 입력해 주세요.");
                Warrior warrior1 = new Warrior();
                warrior1.name = Console.ReadLine();

                if (doAttack)
                {
                    warrior1.Attack();
                }
                else if (doJump)
                {
                    warrior1.Jump();
                }
                else if (doWalk)
                {
                    warrior1.Walk();
                }
                else if (doRun)
                {
                    warrior1.Run();
                }
                else if (doDash)
                {
                    warrior1.Dash();
                }
                else if (doHome)
                {
                    warrior1.Home();
                }
                else
                {
                    // do nothing.
                }

                // switch-case 전사 생성시 실행할 모션
                switch (createMotion)
                {
                    case e_PlayerState.IDLE:
                        // do nothing
                        break;
                    case e_PlayerState.ATTACK:
                        warrior1.Attack();
                        break;
                    case e_PlayerState.JUMP:
                        warrior1.Jump();
                        break;
                    case e_PlayerState.WALK:
                        warrior1.Walk();
                        break;
                    case e_PlayerState.RUN:
                        warrior1.Run();
                        break;
                    case e_PlayerState.DASH:
                        warrior1.Dash();
                        break;
                    case e_PlayerState.HOME:
                        warrior1.Home();
                        break;
                    default:
                        break;
                }

                // 동작 명령
                Console.WriteLine("전사에게 명령을 내려주세요");
                string motionInput = Console.ReadLine();
                e_PlayerState motion = (e_PlayerState)Enum.Parse(typeof(e_PlayerState), motionInput);
                switch (motion)
                {
                    case e_PlayerState.IDLE:
                        // do nothing
                        break;
                    case e_PlayerState.ATTACK:
                        warrior1.Attack();
                        break;
                    case e_PlayerState.JUMP:
                        warrior1.Jump();
                        break;
                    case e_PlayerState.WALK:
                        warrior1.Walk();
                        break;
                    case e_PlayerState.RUN:
                        warrior1.Run();
                        break;
                    case e_PlayerState.DASH:
                        warrior1.Dash();
                        break;
                    case e_PlayerState.HOME:
                        warrior1.Home();
                        break;
                    default:
                        break;
                }

            }
        }
    }

    class Warrior
    {
        public string name;

        
        public void Attack()
        {
            Console.WriteLine($"{name} (이)가 공격함");
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프함");
        }
        public void Walk()
        {
            Console.WriteLine($"{name} (이)가 걸음");
        }
        public void Run()
        {
            Console.WriteLine($"{name} (이)가 달림");
        }
        public void Dash()
        {
            Console.WriteLine($"{name} (이)가 돌진함");
        }
        public void Home()
        {
            Console.WriteLine($"{name} (이)가 귀환함");
        }
    }
}
