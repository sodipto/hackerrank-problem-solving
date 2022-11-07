using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //DiagonalDifference
            //int[,] arr = { { 11, 2, 4 }, { 4, 5, 6 }, { 10, 8, -12 } };
            //int result = DiagonalDifference.diagonalDifference(arr);

            //Plus Minus
            // PlusMinus p = new PlusMinus(arr);

            //Staircase
            // Staircase s = new Staircase(40);

            //Mini - Max Sum
            //MiniMaxSum m = new MiniMaxSum(arr);

            //BirthdayCakeCandles
            //BirthdayCakeCandles b = new BirthdayCakeCandles(arr);

            // GradingStudents
            //GradingStudents g = new GradingStudents(arr);

            //Kangaroo
            //Kangaroo k = new Kangaroo(0,3,4,2);

            // DivisibleSumPairs
            // DivisibleSumPairs d = new DivisibleSumPairs(3, arr);

            //CatAndMouse
            //CatAndMouse c = new CatAndMouse(1,3,2);


            //ElectronicsShop
            // int[] keyboards = { 40,50,60 };
            //int[] drives =    { 5, 8, 12 };
            //ElectronicsShop e = new ElectronicsShop(keyboards, drives, 72);

            //TheHurdleRace
            //TheHurdleRace t = new TheHurdleRace(7, arr);

            //BeautifulDaysattheMovies
            //BeautifulDaysattheMovies b = new BeautifulDaysattheMovies(20, 23, 9);


            //AngryProfessor
            //AngryProfessor a = new AngryProfessor(3, arr);

            //LibraryFine
            //LibraryFine l = new LibraryFine(9, 8, 2016, 6, 6, 2017);

            //BonAppetit
            // BonAppetit bn = new BonAppetit(arr, 1, 7);

            // ViralAdvertising
            //ViralAdvertising v = new ViralAdvertising(3);

            //SavethePrisoner
            //SavethePrisoner s = new SavethePrisoner(7,19,2);

            //Time Conversion
            //TimeConversion t = new TimeConversion("07:05:45AM");

            //StrangeCounter
            // StrangeCounter s = new StrangeCounter(10);

            //CamelCase
            // CamelCase c = new CamelCase("SaveChangesInTheEditor");

            //StrongPassword
            //StrongPassword st = new StrongPassword("E!%Z@");

            //Intro_toTutorial_Challenges
            //int[] arr = { 1, 4, 5, 7, 9, 12 };

            // Intro_toTutorial_Challenges i = new Intro_toTutorial_Challenges(arr,3);

            //Find Digits
            //FindDigits f = new FindDigits(132);

            //MinimumAbsoluteDifferenceInAnArray m = new MinimumAbsoluteDifferenceInAnArray();

            //DayoftheProgrammer d = new DayoftheProgrammer();
            //BirthdayChocolate b = new BirthdayChocolate();
            //BreakingtheRecords b = new BreakingtheRecords();
            //DesignerPDFViewer d = new DesignerPDFViewer();
            //SockMerchant s = new SockMerchant();
            //MaxMIn s = new MaxMIn();
            //Pairs p = new Pairs();
            //int[] arr = { 1, 4, 4, 4, 5, 3, };
            int[] arr = { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, };

            MigratoryBirds m= new MigratoryBirds(arr.ToList());
            // Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
