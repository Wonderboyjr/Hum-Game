using System;

 namespace Hum
 {
   public class Program
   {
     public static void Main(string[] args)
     {
      
       Console.Title = ("Hum");
       Console.BackgroundColor = ConsoleColor.Black;
       WriteW("Press Enter To Continue...");
       Console.ReadLine();
       
       darkness();
       
     }
     public static void WriteR(string textToWrite)
     {
       Console.ForegroundColor = ConsoleColor.Red;
       Console.Write(textToWrite);
     }
     public static void WriteW(string textToWrite)
     {
       Console.ForegroundColor = ConsoleColor.White;
       Console.Write(textToWrite);
     }
       
      public static void darkness()
      {
       string lighton;
       Console.Clear();
       WriteR("You blink and suddenly you are in your bathroom.\nThe lights are off and the shadow of your reflection\ncan be seen faintly in the mirror.\n");
       WriteW("1. Look around.\n2. Turn on the light.\n");
       lighton = Console.ReadLine().ToLower();
      
       switch(lighton)
       {
         case "1":
         case "look":
         case "look around":
           {
             Console.Clear();
             WriteR("You are in darkness.\nA faint glow from the street lamps etches across the ceiling.\n\nThe wind whistles outside.\n\n");
             WriteW("Press Enter...");
             Console.ReadLine();
             darkness();
             break;
       }
         case "2":
         case "light":
         case "turn on light":
           {
             Console.Clear();
             MirrorLeave();
             break;
           }
          default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           darkness();
           break;
          }
         }
         }
       public static void MirrorLeave()
       {
             string mirror;
             WriteR("You feel for the light switch with your hand.\nFlipping it on, you squint your eyes\nand look at your face in the mirror.\n\nYou look tired.\n\n");
             WriteW("1. Lean in closer to the mirror.\n2. Leave the bathroom.");
             mirror = Console.ReadLine().ToLower();
             
             switch(mirror)
             {
               case "1":
               case "lean":
               case "lean in":
                 {
                   Console.Clear();
                   WriteR("As you lean into the mirror,\nyou notice your vision getting blurry\nand a faint but irritating humming noise.");
                   Console.ReadLine();
                   MirrorLeave();
                   break; 
                 }
                case "2":
                case "leave":
                case "leave the bathroom":
                  {
                    Console.Clear();
                    Third();
                    break;
                  }
                  default:
                     {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           MirrorLeave();
           break;
                   }
                  }
       }
       public static void Third()
       {
         string third;
         WriteR("You back away from your reflection and rub your eyes.\nAs you your hand reaches the bathroom door,\na shrill ringing in your ears grows louder.\nWhen you open the door, the ringing stops.\n\n");
         WriteR("Complete silence.\n\n");
         WriteW("1. Check the front door.\n2. Move towards the living room.");
         third = Console.ReadLine().ToLower();
         
         switch(third)
         {
           case "1":
           case "front door":
           case "check":
             {
            
               frontDoor();
               break;
             }
           case "2":
           case "move":
             {
            
               Moan();
               break;
             }
             default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           Third();
           break;
          }
         }
       }
       public static void frontDoor()
       {
         string frontdoor;
         Console.Clear();
         WriteR("The house is dark but you find your way to the front door.\n\n");
         WriteW("1. Check the locks.\n2. Look through the peephole.");
      
         frontdoor = Console.ReadLine().ToLower();
         
         switch(frontdoor)
         {
           case "1":
           case "check":
             {
               Console.Clear();
               WriteR("Your hand turns the lock open and then close again.\nHowever, you realize it doesn't make any sound.");
               Console.ReadLine();
               frontDoorTwo();
               break;
               }
            case "2":
            case "look":
              {
                Console.Clear();
                WriteR("You look through the peephole out to your street.\nIt is lightly snowing and the flakes dance quietly around the street lamps.\n");
                Console.ReadLine();
                frontDoorTwo();
                break;
                }
                default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           frontDoor();
           break;
          }
             }
          }
        
        public static void frontDoorTwo()
        {
         string frontdoortwo;
         Console.Clear();
         WriteR("The house is dark but you find your way to the front door.\n\n");
         WriteW("1. Check the locks.\n2. Look through the peephole.\n3. Turn back toward the living room.\n");
         
         frontdoortwo = Console.ReadLine().ToLower();
         
           switch(frontdoortwo)
         {
           case "1":
           case "check":
             {
                Console.Clear();
                WriteR("Your hand turns the lock and it doesn't make a sound.\nYou realize it is open.\nYou were sure you had just locked it.");
                Console.ReadLine();
                frontDoorTwo();
                break;
              }
            case "2":
            case "look":
            case "peephole":
               {
                  WriteR("You look through the peephole out to your street.\nIt is lightly snowing and the flakes dance quietly around the street lamps.\nUnder one of the street lamps, you can faintly see a figure crouching.");
                  Console.ReadLine();
                  frontDoorTwo();
                  break;
                }
             case "3":
             case "living room":
             case "turn back":
               {
                 Moan();
                 break;
               }
               default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           frontDoorTwo();
           break;
          }
              }
          }
          
        public static void Moan()
        {
          string moan;
          Console.Clear();
          WriteR("Suddenly, you hear a low gutteral moan come from the living room.\n\nYour stomach drops and you freeze.\n\n");
          WriteW("1.Check the front door.\n2. Call out to the noise.\n3. Slowly approach the living room.\n");
          moan = Console.ReadLine().ToLower();
         
          
          switch (moan)
          {
            case "1":
            case "check":
            case "front door":
              {
                frontDoorTwo();
                break;
              }
            case "2":
            case "call":
            case "call out":
              {
                Console.Clear();
                WriteR("You are about to call out when you realize\nyou are alone.\nYou have no pets and you're not sure how a dying animal could have gotten in.\n");
                Console.ReadLine();
                Moan();
                break;
               }
             case "3":
             case "approach":
             case "living room":
               {
                Approach();
                break;
               }
               default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           Moan();
           break;
          }
            }
        }
         public static void Approach()
         {
           string approach;
           Console.Clear();
           WriteR("As you approach the living room,\nyou begin to notice how silent it is.\nYou cannot hear your own heavy breathing\nor your foot steps on the hard floor.\n\nThe living room is only lit by the street lamps\nand is filled with your usual furniture.\nAside from that, the room is empty and nothing seems out of place.\n\n");
           WriteW("1. Turn on the overhead light.\n2. Listen closely.");
           approach = Console.ReadLine().ToLower();
           
           switch (approach)
           {
           case "1":
             {
               otherHouse();
               break;
               }
            case "2":
              {
                Console.Clear();
                tappingOne();
               break;
               }
               default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           Approach();
           break;
          }
             }
           }
          public static void otherHouse()
          {
            string otherH;
            Console.Clear();
            WriteR("You reach for the overhead light\nand as you pull the string, a humming noise\nin the back of your head begins to grow.\n\nAs soon as you turn on the light, the humming stops.\n\nThe room is now completely empty.\nThe walls and floors are bare.\nAll of your furniture is gone.\nHowever, directly in the middle of the room is a stool.\n\n");
            WriteW("1. Sit on the stool.\n2. Turn off the overhead light.\n");
            otherH = Console.ReadLine().ToLower();
            
            switch (otherH)
            {
              case "1":
                {
                 stoolSit();
                 break;
                 }
              case "2":
                {
                  Console.Clear();
                  WriteR("As soon as you turn the light back off,\nall of your furniture reappears.\n\n");
                  tappingOne();
                  break;
                 }
                 default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           otherHouse();
           break;
          }
             }
           }
                
          public static void tappingOne()
          {
            string tapper;
            Console.Clear();
            WriteR("You listen for anything in the silence.\nA humming noise in the back of your head\nand begins to grow louder, then stops.\n\nVery faintly, you hear a small tapping,\nlike knuckles being rolled on a desk,\ncoming from the window to your right.\n\n");
            WriteW("1. Look out the window.\n2. Make sure the window is locked.\n");
            tapper = Console.ReadLine().ToLower();
            
            switch (tapper)
            {
              case  "1":
                {Console.Clear();
                 WriteR("You try your best to see out of the window.\nBut all you can make out is the outline of your bushes\nand the lightly falling snow.\n");
                 Console.ReadLine();
                 tappingOne();
                 break;
                 }
               case "2":
                 {Windows();
                  break;
                  }
                  default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           tappingOne();
           break;
          }
               }
              }
             public static void Windows()
             {
               Console.Clear();
               WriteR("Reluctantly, you move up to the window.\nThe tapping continues until you are inches away from the glass.\n\nAnd then it stops.\n\nYou wish you could hear anything, anything other than the deafening silence. \n\nThat's when you notice your reflection.\n\n");
               Console.ReadLine();
               Console.Clear();
               WriteR("It's different.\nYour eyes are wide with horror and two hands cover your ears.\n\nBut not your own.\n\nYour eyes move upwards to see the reflection\nof a figure standing behind you.\n");
               Console.ReadLine();
               Console.Clear();
               WriteR("It is about two feet taller than you and its face has no features,\nexcept for an impossibly large mouth that curves upwards into a smile\nthat stretches to either side of its head.\nIts long, pale arms remain firmly cupped over your ears\as it begins to hum melodically.\n\nThe tune is indecipherable as the buzz of noise overwhelms\nand fills every part of you.\nYour body shakes from the vibration and you collapse to ground. \nYour mouth tightens as you try to make sense of the billowing song.\n\n");
               Console.ReadLine();
               Console.Clear();
               WriteR("Slowly, your mouth begins to widen.\nYour close your eyes close and you focus on the wave of sound,\ntossing and turning.");
               Console.ReadLine();
               Console.Clear();
               WriteR("A tear runs down your shivering face.\nWith your lips pressed together, you begin to\n");
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("hum.");
               
               Console.ReadLine();
              
               darkness();
               }
             
             
             public static void stoolSit()
             {
             string hum;
             Console.Clear();
             WriteR("You feel a strong urge to sit on the stool.\nAs you do, you can see yourself in the grey reflection\nof the television screen.\n\n");
             WriteW("1. Turn on the TV.\n2. Get up from the stool.");
             hum = Console.ReadLine().ToLower();
             
             switch (hum)
             {
               case "1":
               {
                 humFinal();
                 break;
                 }
               case "2":
                 
                 {
                   humFinal();
                   break;
                   }
                   default:
           {
           Console.Clear();
           WriteW("Invalid Entry.\nPress Enter...");
           Console.ReadLine();
           stoolSit();
           break;
          }
                 }
               }
             
             public static void humFinal()
             {
              
               Console.Clear();
               WriteR("Before you can move, the TV turns on.\nThe screen turns to static.\nBut instead of the usual grating sound of electric noise,\nyou hear tapping on the screen,\nlike knuckles being rolled on a desk.");
                Console.ReadLine();
               Console.Clear();
               WriteR("As you lean in to the TV, the humming noise in your head\nincreases to a deafening pitch\nand makes you wince in pain.\nThen it stops again.\nThe screen in front of you goes blank.");
               Console.ReadLine();
               Console.Clear();
               WriteR("You wish you could hear anything else, anything other than the deafening silence. \n\nThat's when you notice your reflection.\n\n");
               Console.ReadLine();
               Console.Clear();
               WriteR("It's different.\nYour eyes are wide with horror and two hands cover your ears.\n\nBut not your own.\n\nYour eyes move upwards to see the outlinen\nof a figure standing behind you.\n");
               Console.ReadLine();
               Console.Clear();
               WriteR("It is about two feet taller than you and its face has no features,\nexcept for an impossibly large mouth that curves upwards into a smile\nthat stretches to either side of its head.\nIts long, pale arms remain firmly cupped over your ears\as it begins to hum melodically.\n\nThe tune is indecipherable as the buzz of noise overwhelms\nand fills every part of you.\nYour body shakes from the vibration and you collapse to the ground. \nYour mouth tightens as you try to make sense of the billowing song.\n\n");
               Console.ReadLine();
               Console.Clear();
               WriteR("Slowly, your mouth begins to widen.\nYour eyes close and you focus on the wave of sound,\ntossing and turning.\n");
                Console.ReadLine();
               Console.Clear();
               WriteR("A tear runs down your shivering face.\nWith your lips pressed together, you begin to ");
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("hum.");
               Console.ReadLine();
               darkness();
             }
       }
 }
 
 
     

    
    