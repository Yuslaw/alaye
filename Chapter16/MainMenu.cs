using System;
namespace Chapter16
{
    public class MainMenu
    {
         public static void MyMenu()
        {
            bool big = true;
            while (big)
            {
                Console.WriteLine($"\npress 1 for Question 1\nPress 2 for Question 2\npress 3 for Question 3\npress 4 for Question 4\npress 5 for Question 5\npress 6 for Question 6\npress 7 for Question 7\npress 8 for Question 8\npress 9 for Question 9\npress 10 for Question 10\npress 11 for Question 11\npress 12 for Question 12\npress 13 for Question 13\npress 14 for Question 14\npress 15 for Question 15\npress 16 for Question 16\npress 17 for Question 17\npress 18 for question 18\npress 0 to exit");
                var option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                     question1.AnsOne();
                }
                else if (option == 2)
                {
                    question2.AnsTwo();
                }
                else if (option == 3)
                {
                    question3.AnsThree();
                }
                 else if (option == 4)
                {
                    question4.Ansfour();
                }
                 else if (option == 5)
                {
                    question5.Ansfive();
                }
                else if(option==6)
                {
                    question6.AnsSix();

                }
                else if(option==7)
                {
                    question7.AnsSeven();
                }
                else if (option == 8)
                {
                    
                }
                else if (option == 9)
                {
                    question9.AnsNine();
                }
                 else if (option == 10)
                {
                }
                 else if (option == 11)
                {
                }
                else if(option==12)
                {

                }
                else if(option==13)
                {
                }
                else if(option==0)
                {
                    MainMenu.MyMenu();
                }
        }   }  
    }
}