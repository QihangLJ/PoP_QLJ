using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject
{
    public static void Main()
    {
        const string AskDate = "Introdueix el dia, mes i any";
        const string MsgFormatError = "El format no és correcte";
        const string MsgCorrectDate = "La data és correcta";
        const string MsgAskForMenu = "Que vols fer? \nA.Saltar \nB.Correr \nC.Ajupir-se \nD.Amagar-se";
        int dia, mes,any;
        char charInput;

        Console.WriteLine(AskDate);
        dia = Convert.ToInt32(Console.ReadLine());
        mes = Convert.ToInt32(Console.ReadLine());
        any = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(Valida(dia, mes, any) ? MsgCorrectDate : MsgFormatError);

        Console.WriteLine(MsgAskForMenu);
        charInput = Convert.ToChar(Console.ReadLine()!);
        Menu(charInput);    
    }

    public static bool CheckDay (int day, int totalDaysMonth)
    {
        return day < totalDaysMonth;
    }

    public static int LeapYeaDays (int year)
    {
        return ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0))) ? 29 : 28;
    }
    public static bool Valida(int day, int month, int year)
    {

        if (day < 1 || day > 31)

            return false;

        if (month < 1 || month > 12)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 0;

        switch (month)
        {

            case 1:

            case 3:

            case 5:

            case 7:

            case 8:

            case 10:

            case 12: totalDaysMonth = 31; break;

            case 4:

            case 6:

            case 9:

            case 11: totalDaysMonth = 30; break;

            case 2: // verifica l'any de traspàs

                totalDaysMonth = LeapYeaDays (year);

                break;
        }
        return CheckDay (day, totalDaysMonth);
    }

    public static void Menu(char option)
    {
        const string MsgJump = "SALTO";
        const string MsgRun = "CORRO";
        const string MsgAjup = "M´AJUPO";
        const string MsgHide = "M´AMAGO";

        switch (option)
        {
            case 'a':
            case 'A':
                Console.WriteLine(MsgJump);
                break;
            case 'b':
            case 'B':
                Console.WriteLine(MsgRun);
                break;
            case 'c':
            case 'C':
                Console.WriteLine(MsgAjup);
                break;
            case 'd':
            case 'D':
                Console.WriteLine(MsgHide);
                break;
        }
    }
}