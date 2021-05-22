using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOGIN
{
    class Program
    {
    public static void firstscreen()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("\t\t\tINSTRUCTIONS.");
        Console.WriteLine();
        Console.WriteLine("\t1.PRESS TAB AFTER ENTERING PASSWORD OR CONFIRM PASSWORD.");
        Console.WriteLine();
        Console.WriteLine("\t2.PRESS BACKSPACE IN PASSWORD OR CONFIRM PASSWORD");
        Console.WriteLine("\t  FEILD FOR CANCELLATION OF ACTION AND COMING BACK TO MAIN MENU.");
        Console.WriteLine();
        Console.WriteLine("ENTER YOUR CHOICE FROM FOLLOWING.");
        Console.WriteLine("1.SIGN UP.");
        Console.WriteLine("2.SIGN IN.");
        Console.WriteLine("3.NUMBER OF USERS AT THE MOMENT.");
        Console.WriteLine("4.ALL USER & PASSWORD INFORMATION.");
        Console.WriteLine("5.MAGIC");
        Console.WriteLine("6.EXIT.");

        
    }

    public static bool SARVESARVA()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("\t\tADMINISTRATOR LOGIN.");
        Console.WriteLine();
        Console.Write("\tADMIN NAME\t");
        string ADMIN = Console.ReadLine();
        if (ADMIN.Equals("MUKESH"))
        {
            Console.Write("\tPASSWORD  \t");
            ADMIN = Console.ReadLine();
            if (ADMIN.Equals("BHANSALI"))
                return true;
        }
        return false;
    }

    static void Main(string[] args)
        {
           int option, MAX = 10, TOTALEQUAL = 0,TOTAL = 0;
           login alone = new login();
           login[] RUNTIME = new login[MAX + 1];
           RUNTIME[0] = new login("0","0\t");
                    
           do
           {
               firstscreen();
               string TEMP =Console.ReadLine();
               if (TEMP.Length == 0)
               { option = 0; }
               else
               {
                   int i;
                   for (i = 0; i < TEMP.Length; i++)
                   {
                       if (TEMP[i] < 48 || TEMP[i] > 57)
                       {
                           Console.WriteLine("YOUR INPUT IS NOT IN PROPER FORMAT.");
                           Console.ReadLine();
                           break;
                       }
                   }
                   option = 0;
                   if (i == TEMP.Length) { option = Convert.ToInt32(TEMP); }
               }
               int equal = -11;
               if (option == 1)
               {
                   if (TOTAL < MAX)
                   {
                       TOTAL++;
                       RUNTIME[TOTAL] = new login();
                       equal = TOTAL;
                       TOTALEQUAL = TOTAL;
                   }
                   else
                   {
                       int i;
                       for (i = 0; i <= TOTAL; i++ )
                       {
                           if (RUNTIME[i].problem())
                           {
                               equal = i;
                               TOTALEQUAL = TOTAL + 1;
                               break;
                           }
                       }
                       if (equal == -11)
                       {
                           Console.WriteLine("\tCAN NOT CREATE MORE USER. MEMORY RECHES TO MAXIMUM LIMIT");
                           Console.ReadLine();
                           continue;
                       }
                   }
               }

               switch (option)
               {
                   case 0:
                       break;
                   case 1:

                       string USERNAME = login.constant();
                       for (int j = 0; j < TOTALEQUAL; j++)
                       {
                               if (RUNTIME[j].usernamecheck(USERNAME))
                               {
                                   Console.WriteLine("USERNAME ALREADY EXIST.");
                                   Console.ReadLine();
                                   j = -1;
                                   USERNAME = login.constant();
                               }
                       }  
                             
                       RUNTIME[equal].SETUSERNAME(USERNAME);
                       if (RUNTIME[equal].REGISTRATION())
                       {
                           Console.WriteLine();
                           Console.WriteLine("REGISTRATION SUCCESFULLY COMPLETED.");
                           Console.ReadLine();
                       }
                       else
                       {
                           TOTAL--;
                           Console.WriteLine();
                           Console.WriteLine("\tACTION CANCELLED.");
                           Console.ReadLine();
                       }
                       Console.Clear();
                       break;

                     case 2:
                       
                    int i = 0,times = 3;
                    while (times > 0)
                    {
                           Console.WriteLine("ENTER USERNAME.");
                           Console.WriteLine();
                           Console.Write("\tUSERNAME\t");
                           string uNAME = Console.ReadLine();

                            for(i = 0; i <= TOTAL; i++)
                            {
                               if(RUNTIME[i].usernamecheck(uNAME))
                                   break;
                            }
                        if(i > TOTAL)
                        {
                            times--;
                            Console.Clear();
                            Console.WriteLine("USERNAME DOES NOT EXIST. ");
                            Console.WriteLine();
                            Console.WriteLine("YOUR REMAINING ATTEMPT IS " + times);
                            Console.WriteLine();
                            continue;
                        }
                        break;
                        
                    }
                    if (times > 0)
                    {
                        if(RUNTIME[i].passwordcheck())
                            RUNTIME[i].LOGINSCREEN();
                    }
                    break;
                                     
                   case 3:
                       Console.WriteLine();
                       Console.WriteLine("\t" + TOTAL + " USER(S) ARE REGISTERED TILL THIS MOMENT. ");
                       Console.ReadLine();
                       break;

                   case 4:
                       if (SARVESARVA())
                       {
                           if (TOTAL == 0)
                           {
                               Console.WriteLine("\n\t\tNOBODY HAS REGISTERED.");
                               Console.ReadLine();
                               continue;
                           }
                           Console.WriteLine();
                           Console.WriteLine("\t\tUSERNAME\tPASSWORD");
                           for (int I = 1; I <= TOTAL; I++)
                           {
                               Console.WriteLine("\t     " + I + ".| " + RUNTIME[I].GETINFO());
                           }

                       }
                       else
                       {
                           Console.WriteLine();
                           Console.WriteLine("\t YOU ARE NOT THE RIGHT ONE.");
                           Console.WriteLine("\t I AM GOING.");
                       }
                       Console.ReadLine();
                       break;
                   case 5:
                       Console.Clear();
                       Console.WriteLine();
                       Console.WriteLine("ENTER A NUMBER.");
                       float MID = float.Parse(Console.ReadLine());
                       float  number = MID / 3;
                       Console.WriteLine();
                       float[,] arrmatrix = new float[3,3]
                       {{number + 3, number - 4, number + 1},{number - 2,
                       number,number + 2},{number - 1,number + 4, number - 3}};

                       for (int L = 0; L < 3; L++)
                       {
                           Console.WriteLine();
                           Console.WriteLine();
                           Console.Write("\t");
                           for (int j = 0; j < 3; j++)
                           {
                               Console.Write(arrmatrix[L,j] +"\t");
                           }
                       }
                       Console.WriteLine();
                       Console.WriteLine("------------------------------");
                       Console.WriteLine("\t AS YOU CAN SEE.");
                       for (int H = 0; H < 3; H++)
                       {
                           Console.WriteLine();
                           if(H != 0)
                           Console.WriteLine();
                           Console.Write("\t");
                           for (int j = 0; j < 3; j++)
                           {
                               if (j == 2)
                               { Console.WriteLine(arrmatrix[H, j] + "\t =\t" + MID); }
                               else
                               {
                                   Console.Write(arrmatrix[H, j] + "   +   ");
                               }
                           }
                       }
                       Console.WriteLine("------------------------------");
                       Console.Write("        " + MID);
                       Console.Write("\t " + MID);
                       Console.WriteLine("\t  " + MID);
                       Console.WriteLine("------------------------------");
                       Console.WriteLine("THE TOTAL IS ALSO SAME FOR DIAGONOLS.");
                       Console.WriteLine("------------------------------");
                       Console.ReadLine();
                       break;
                   case 6:
                       break;
                   default:
                       Console.WriteLine("YOU HAVE SELECTED A WRONG OPTION. TRY AGAIN.");
                       Console.ReadLine();
                       break;
               }
           } while (option !=6);

            char farzi = Console.ReadKey().KeyChar;
            Console.WriteLine("\b");
        }
    }



    class login
    {
        private
        
        string username,password;
        
        public login(string uname , string pword)
        {
            username = uname;
            password = pword;
        }

        public login()
        {
            username = "MUKESH";
            password = "BHANSALI";
        }

        public void SETUSERNAME(string UNAME)
        {
            username = UNAME;
        }

        public static string constant()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tREGISTRATION FORM.");
            Console.WriteLine();
            Console.Write("\tUSERNAME\t  ");
            string utemp = Console.ReadLine();
            return utemp;
        }

        public bool problem()
         {
               if (username == null)
                   return true;
               return false;
         }

        public string GETINFO()
        {
            return (username + "\t\t" + password);
        }

        
        public bool REGISTRATION()
        {
            char[] PASS = new char[23];
            char[] PWORD = new char[23];
            while (true)
            {
                Console.Write("\tPASSWORD\t  ");
                for (int i = 0; ; i++)
                {
                    PASS[i] = Console.ReadKey().KeyChar;
                    if (PASS[i] == '\b') return false;
                    if (PASS[i] == '\t')
                    { break; }
                    if (i == 21)
                    { Console.Write("\b*"); break; }
                    Console.Write("\b*");

                }
                Console.WriteLine();
                Console.Write("\tCONFIRM PASSWORD  ");
                for (int i = 0; ; i++)
                {
                    PWORD[i] = Console.ReadKey().KeyChar;
                    if (PWORD[i] == '\b') return false;
                    if (PWORD[i] == '\t' )
                    { break; }
                    if (i == 21)
                    { Console.WriteLine("\b*"); break; }
                    Console.Write("\b*");

                }
               
                int I;
                for (I = 0; PWORD[I] != '\t'; I++)
                {
                    if (PWORD[I] != PASS[I])
                    { break; }
                    if (I == 21)
                    { break; }
                }
                if(PWORD[I] == '\t' && PASS[I] == '\t'|| I > 20)
                { break; }
                Console.WriteLine();
                Console.WriteLine("PASSWORD NOT CONFIRMED.....");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
            }
            password = new String(PASS);
            return true;
         }

        public bool usernamecheck(string user)
        {
            if (user == username)
                return true;
            return false;
        }

        public int LOGINSCREEN()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\tWELCOME " + username);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("YOU HAVE FOLLOWING THINGS TO DO.");
                Console.WriteLine("1.SHAYRI");
                Console.WriteLine("2.MATHAMETIC TIPS.");
                Console.WriteLine("3.QUICK LOG OFF.");
                Console.WriteLine("4.SLOW LOG OFF.");
                Console.WriteLine("5.DELETE ACCOUNT.");

                string TEMP = Console.ReadLine();
                if (TEMP.Length == 0)
                { choice = 0; }
                else
                {
                   int i;
                   for (i = 0; i < TEMP.Length; i++)
                   {
                       if (TEMP[i] < 48 || TEMP[i] > 57)
                       {
                           Console.WriteLine("YOUR INPUT IS NOT IN PROPER FORMAT.");
                           Console.ReadLine();
                           break;
                       }
                   }
                  choice = 0;
                   if (i == TEMP.Length) {choice = Convert.ToInt32(TEMP); }
               }
                
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        shayari();
                        break;
                    case 2:
                        MATHS();
                        break;
                    case 3:
                        break;
                    case 4:
                        SLOW();
                        return 0;
                    case 5:
                        username = null;
                        password = null;
                        return 5;
                    default:
                        Console.WriteLine("BAD CHOICE.");
                        Console.ReadLine();
                        break;
                }

            } while (choice != 3);
            return 0;
        }


        public bool passwordcheck()
        {
            char[] word = new char[23];
            int times = 3;

            while(times > 0)
            {
                 Console.Write("\tPASSWORD\t");
                for (int i = 0; ; i++)
                {
                    word[i] = Console.ReadKey().KeyChar;
                    if (word[i] == '\b')
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t\tACTION CANCELLED.");
                        Console.ReadLine();
                        return false;
                    }
                        
                    if (word[i] == '\t')
                    { break; }
                    if (i == 21)
                    { Console.Write("\b*"); break; }
                    Console.Write("\b*");
                                      
                }

                int j;
                for (j = 0; ; j++)
                {
                    if (j > 21) break;
                    if (word[j] == '\t')
                    {
                        Console.Clear();
                        Console.WriteLine();
                        break;
                    }

                    if (word[j] != password[j])
                    {
                       break; 
                    }
                               
                 }

                if (password[j]== '\t' && word[j] == '\t' || j > 21)
                    return true;
                else
                {
                    times--;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("PASSWORD MISMATCHED.");
                    Console.WriteLine("YOUR REMAINING ATTEMPT IS " + times);
                    Console.WriteLine();
                }
                  
           }
            return false;
                    
        }

        public void shayari()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tHANSTE HUE CHEHRE PE BHI GAM HO SAKTA HAIN,");
            Console.WriteLine("\t\tWAH WAH, WAH WAH");
            Console.WriteLine();
            Console.WriteLine("JARA GAUR FARMAIGA");
            Console.WriteLine("\tHANSTE HUE CHEHRE PE BHI GAM HO SAKTA HAIN,");
            Console.WriteLine("\tANJAAN VASTUON SE DOOR RAHNA, UNME BAM HO SAKTA HAIN.");
            Console.WriteLine("AADAB.......");
            Console.ReadLine();
         }

        public void MATHS()
        {
            Console.Clear();
            Console.WriteLine("\t1.DO YOU KNOW");
            Console.WriteLine("12 * 12 = 10 * 10 + (10 + 12) * (12 - 10) = 144");
            Console.WriteLine("AND IT WILL WORK FOR ALL CASES.");
            Console.WriteLine();
            Console.WriteLine("\t2. DO YOU KNOW 97 * 94 = ");
            Console.WriteLine("94 * 100 - ((100 - 97) * 100) + (100 - 94) * (100 - 97) = 9118");
            Console.ReadLine();


        }

         public void SLOW()
        {
            Console.WriteLine("\t\t\t\t   GOODBYE  " + username);
            Console.WriteLine();
            Console.WriteLine();
             int J;
             for (int i = 1; i < 40; i++)
            {
                for (J = 1; J <= i; J++)
                {
                    Console.Write("_");
                }
                for (J = i + 1; J < 80 - i; J++)
                {
                    Console.Write(" ");
                }
                for (J = 80 - i; J <= 80; J++)
                {
                    Console.Write("_");
                }
                System.Threading.Thread.Sleep(400);
            }
             
        }
          
    }
}
