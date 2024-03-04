using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TPP.Laboratory.Functional.Lab05;

namespace ConsoleApp2
{
    public static class Program
    {
        //Action (takes aprameter returns nothing)
        public static void print(string message)
        {
            Console.WriteLine(message);
        }

        //predicate (returns bool);
        public static bool IsEven(int value)
        {
            return value%2 == 0;
        }

        public static int AddOne(int a)
        {
            return a + 1;
        }

        public static double AddOneD(int a)
        {
            return a + 1;
        }

        public static int InvokeFunction(int a, Func<int, int> b)
        {
            return b(a);
        }

        static void Main(string[] args)
        {
            //delegate
            Func<int, int> myFunc = AddOne;

            //Console.Write(InvokeFunction(10, AddOne));

            var arr = new int[]{ 1, 2, 3, 4, 5 };
            //ExtensionMethods.Show(arr.Map(AddOne).Map(AddOne).Map(AddOne));
            //int x = 0;
            //arr.Map(x => x + 1).Map(x => x.ToString().Map(x => x + "hello").Map(x => x.Length)).Show();

            Person[] people = Factory.CreatePeople();
            Angle[] angles = Factory.CreateAngles();

            Angle dik = new Angle(1.5);
            angles[3] = dik;
            Console.WriteLine(dik.Degrees + " " + dik.Radians);

            Person furkan = new Person("Furkan", "Kurt", "123");
            Person faruk = new Person("Faruk", "Sokucu", "321");
            people[3] = furkan;
            people[4] = faruk;

            //ExtensionMethods.Show(people.Map(x => x.FirstName));

            Predicate<Person> nameStartsWith = x => x.FirstName.StartsWith("F");
            Predicate<Angle> rightAngle = x => x.Degrees < 180 && x.Degrees > 0;
            Console.WriteLine(rightAngle(dik));
            //Console.WriteLine(ExtensionMethods.Find<Person>(people, nameStartsWith));
            //ExtensionMethods.Filter<Person>(people, nameStartsWith).ForEach(Console.WriteLine);
            //Console.WriteLine(ExtensionMethods.Find<Angle>(angles, rightAngle).Degrees);            
            ExtensionMethods.Filter<Angle>(angles, rightAngle).ForEach(Console.WriteLine);
        }
    }
}
