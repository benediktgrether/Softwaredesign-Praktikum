// using System;
// using System.Collections.Generic;

// namespace L07_DesignPatterns
// { 
//     interface IGameChar
//     {
//         void  Threaten();
//     }

//     class MonsterTwo : IGameChar
//     {
//         public void  Threaten()
//         {
//             Console.WriteLine("Grrrrrrrr");
//         }
//     }

//     class HeroTwo : IGameChar
//     {
//         public void  Threaten()
//         {
//             Console.WriteLine("You should not passed");
//         }
//     }

//     // Decorator
//     class WithAColdCharTwo : IGameChar
//     {
//         private IGameChar _original;

//         public WithAColdCharTwo(IGameChar original)
//         {
//             _original = original; 
//         }
//         public void  Threaten()
//         {
//             _original. Threaten();
//             Console.Write(" Hust!");
//         }
//     }

//     class HoarseCharTwo : IGameChar
//     {
//         private IGameChar _original;

//         public HoarseCharTwo(IGameChar original)
//         {
//             _original = original; 
//         }
//         public void  Threaten()
//         {
//             Console.Write("Räusper...");
//             _original. Threaten();
//         }
//     }
// }  