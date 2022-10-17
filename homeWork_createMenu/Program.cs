using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_createMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandCreateAccount = "1";
            const string CommandSingInAccount = "2";
            const string CommandSettings = "3";
            const string CommandEsc = "!";

            const string CommandChangeName = "1";
            const string CommandChangePassword = "2";

            const string CommandSetCollorText = "1";
            const string CommandSetCollorBeckgroud = "2";

            const string CommandSetCollorTextRed = "1";
            const string CommandSetCollorTextBlue = "2";
            const string CommandSetCollorTextWhite = "3";
            const string CommandSetCollorTextBlack = "4";

            const string CommandSetCollorBeckgroudRed = "1";
            const string CommandSetCollorBeckgroudBlou = "2";
            const string CommandSetCollorBeckgroudWhite = "3";
            const string CommandSetCollorBeckgroudBlack = "4";

            const string CommandGoToMainMenu = "<";

            string userInput;
            bool isExit = false;
            bool isLogIn = false;
            string passwordUser = null;
            string nameUser = null;

            while (isExit == false) 
            {
                Console.WriteLine("Добро пожаловать в главное меню програмы! Введите - ");
                Console.WriteLine($"{CommandCreateAccount} - чтобы создать новый аккаунт");
                Console.WriteLine($"{CommandSingInAccount} - чтобы войти в аккаунт");
                Console.WriteLine($"{CommandSettings} - чтобы настроить консоль");
                Console.WriteLine($"{CommandEsc} - чтобы выйти");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput) 
                {
                    case CommandCreateAccount:
                        Console.Write("Придумайте свое имя: ");
                        nameUser = Console.ReadLine();
                        Console.Write("Придумайте свой пароль: ");
                        passwordUser = Console.ReadLine();
                        Console.WriteLine("Вы успешно создали аккаунт.\nНажмите enter , для того чтобы вернуться в меню");
                        Console.ReadKey();                
                        isLogIn = true;
                        Console.Clear();
                        break;

                    case CommandSingInAccount:
                        if (isLogIn = false) 
                        {
                            Console.WriteLine("Вы не создали аккаунт.\nНажмите enter для продолжения");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Введите свое имя: ");
                            userInput = Console.ReadLine();

                            while (userInput != nameUser) 
                            {
                                    Console.Write("Имя пользователя введено неверно. Попробуйте еще раз: ");
                                    userInput = Console.ReadLine();
                            }

                            Console.WriteLine("Введите свой пароль: ");
                            userInput = Console.ReadLine();

                            while (userInput != passwordUser)
                            {
                                Console.Write("Пароль введен неверно.\nПопробуй еще раз: ");
                                userInput = Console.ReadLine();
                            }

                            Console.WriteLine("Вы вошли в аккаунт");
                            Console.WriteLine("Вы можите изменить данные аккаунта для этого нажмите :");
                            Console.WriteLine($"{CommandChangeName} - чтобы изменить имя аккаунта");
                            Console.WriteLine($"{CommandChangePassword} - чтобы изменить пароль");
                            Console.WriteLine($"{CommandGoToMainMenu} - чтобы выйти в главное меню");
                            userInput = Console.ReadLine();
                            Console.Clear();

                            switch (userInput) 
                            {
                                case CommandChangeName:
                                    Console.WriteLine("Введите новое имя: ");
                                    nameUser = Console.ReadLine();
                                    Console.WriteLine("Вы успешно изменили имя.\nНажмите enter, чтобы выйти в меню");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case CommandChangePassword:
                                    Console.WriteLine("Введите новый пароль: ");
                                    passwordUser = Console.ReadLine();
                                    Console.WriteLine("Вы успешно изменили пароль.\nНажмите enter, чтобы выйти в меню");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case CommandGoToMainMenu:
                                    break;
                                default:
                                    Console.WriteLine("Команда введина неверно. Нажмите entet, чтобы выйти в главное мнею");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }      

                        }

                        Console.Clear();
                        break;

                    case CommandSettings:
                        Console.WriteLine($"Нажмите:" +
                            $"\n{CommandSetCollorText} - чтобы, изменить цвет текста " +
                            $"\n{CommandSetCollorBeckgroud} - чтобы, изменить цвет заднего фона ");
                        userInput= Console.ReadLine();
                        Console.Clear();

                        switch (userInput) 
                        {
                            case CommandSetCollorText:
                                Console.WriteLine("На какой цвет вы хотите изменить");
                                Console.WriteLine($"{CommandSetCollorTextRed} - красный"); ;
                                Console.WriteLine($"{CommandSetCollorTextBlue} - синий");
                                Console.WriteLine($"{CommandSetCollorTextWhite} - белый");
                                Console.WriteLine($"{CommandSetCollorTextBlack} - черный");
                                userInput = Console.ReadLine();

                                switch (userInput) 
                                {
                                    case CommandSetCollorTextRed:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        break;

                                    case CommandSetCollorTextBlue:
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        break;

                                    case CommandSetCollorTextWhite:
                                        Console.ForegroundColor = ConsoleColor.White;
                                        break;

                                    case CommandSetCollorTextBlack:
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        break;
                                    default:
                                        Console.WriteLine("Комманда введина неверно.\nНажмите enter ,чтобы перейти в меню");
                                        Console.ReadKey();
                                        break;
                                }

                                Console.Clear();
                                break;

                            case CommandSetCollorBeckgroud:
                                Console.WriteLine("На какой цвет вы хотите изменить");
                                Console.WriteLine($"{CommandSetCollorBeckgroudRed} - красный"); ;
                                Console.WriteLine($"{CommandSetCollorBeckgroudBlou} - синий");
                                Console.WriteLine($"{CommandSetCollorBeckgroudWhite} - белый");
                                Console.WriteLine($"{CommandSetCollorBeckgroudBlack} - черный");
                                userInput = Console.ReadLine();

                                switch (userInput)
                                {
                                    case CommandSetCollorTextRed:
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        break;

                                    case CommandSetCollorTextBlue:
                                        Console.BackgroundColor = ConsoleColor.Blue;
                                        break;

                                    case CommandSetCollorTextWhite:
                                        Console.BackgroundColor = ConsoleColor.White;
                                        break;

                                    case CommandSetCollorTextBlack:
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        break;
                                    default:
                                        Console.WriteLine("Комманда введина неверно.\nНажмите enter ,чтобы перейти в меню");
                                        Console.ReadKey();
                                        break;
                                }

                                Console.Clear();
                                break;

                            default :
                                Console.WriteLine("Комманда введина неверно.\nНажмите enter ,чтобы перейти в меню");
                                Console.ReadKey();
                                break;
                        }

                        Console.Clear();
                        break;

                    case CommandEsc:
                        isExit = true;
                        break;

                    default:
                        Console.WriteLine("Команда введена неверно");
                        break;
                }

            }

        }
    }
}
