using System;
using System.Threading;

namespace Consoleapp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Abstrakcja - Wstęp

            // Można powiedzieć, że C# jest abstrakcją języka programowania niskiego
            // poziomu, jakim może być assembler. To głównie dlatego, że abstrakcja
            // oznacza oderwanie od rzeczywistości. C# jest językiem wysokopoziomowym.
            // Języki wysokopoziomowe mają za zadanie ułatwić programistom pisanie i
            // rozumienie kodu, ponieważ ich struktura i składnia została w pewien
            // sposób uproszczona. Abstrakcja oznacza oderwanie od rzeczywistości.
            // Najlepiej zrozumieć to na przykładzie kodu, jaki kiedyś pisali pierwsi
            // programiści. Ich kod składał się jedynie z zer i jedynek. Następnie
            // ktoś wpadł na pomysł aby stworzyć nowy język, w którym będziemy mogli
            // porozumiewać się w prosty sposób z komputerem. Pomysł wynika głównie z tego,
            // żeby programiści nie musieli się uczyć na pamięć, co oznacza dany
            // zestaw kombinacji cyfr zer i jedynek. W ten sposób powstał assembler.
            // Jest to język niskiego poziomu. Kod IL (który jest wynikiem kompilacji C#)
            // składnią przypomina język assembly, ale zawiera wysokopiozomowe koncepty
            // oraz funkcje takie jak klasy, zmienne, metody, wywołania.

            // Gdy piszemy kod w języku C#, nie jest z góry narzucona nam np. potrzeba
            // zwalniania obiektów z pamięci, gdy już nie są używane. Służy do tego
            // mechanizm (inaczej system) Garbage Collector, który automatycznie zwolni
            // nieużywane przez nas stworzone obiekty. Ale oczywiście my także mamy taką
            // możliwość, aby samodzielnie zwalniać obiekty z pamięci. W językach takich,
            // jak C i C++ musimy sami o to zadbać.









            // Abstrakcja - OOP

            // ŹRÓDŁO: http://staff.elka.pw.edu.pl
            // Abstrakcja, w kontekście programowania obiektowego, jest zdolnością
            // do pomijania niektórych, nieistotnych aspektów modelowanego fragmentu
            // rzeczywistości. Abstrahowaniu podlegają zarówno dane jakie przechowują
            // obiekty jak również ich zachowanie.

            // ŹRÓDŁO: https://docs.microsoft.com
            // Abstrakcja to typ opisujący kontrakt, ale nie zapewnia pełnej implementacji
            // kontraktu. Abstrakcje są zwykle implementowane jako abstrakcyjne klasy lub
            // interfejsy i są dostarczane z dobrze zdefiniowanym zestawem dokumentacji
            // referencyjnej opisującym wymaganą semantyka typów implementujących kontrakt.



            // Pojęcia:

            // Klasa abstrakcyjna to taka klasa, dla której nie możemy utworzyć obiektu.

            // Jest bardzo podobna do interfejsu z tą różnicą, że klasy mogą dziedziczyć
            // po wielu interfejsach a tylko po jednej klasie.

            // Klasa może implementować dowolną ilość interfejsów a dziedziczyć może tylko
            // po jednej klasie abstrakcyjnej. Metody w interfejsach nie mogą zawierać
            // atrybutów dostępu a w klasach abstrakcyjnych już tak. Konstruktor może być
            // zawarty w klasie abstrakcyjnej a w intefejsie już nie.
















            Car car = new Car("BMW");
            car.Cost = 8000;
            car.Speed = 80;
            car.Description = "Niezawodny i szybki samochód!";
            
            car.Ride(10001);

            car.Stop();

            //car.ImmediateStop();

            Console.WriteLine("Koniec gry!");

            //Console.WriteLine(car.Cost);
            //Console.WriteLine(car.Description);

        }
    }

    public interface IVehicle
    {
        void Ride(int time);
    }

    public abstract class Vehicle
    {
        public abstract void Ride(int time);
        public abstract void Stop();
    }

    public class Car : Vehicle
    {
        private string _brand;

        public int Cost { get; set; }
        public int Speed { get; set; }
        public string Description { get; set; }

        public Car(string brand)
        {
            _brand = brand;
        }

        public override void Ride(int time)
        {
            Console.WriteLine($"Samochód marki {_brand} w trasie!" +
                "\nPrzejażdzka będzie trwała " + time / 1000 + " sekund.");

            if (Speed > 50)
            {   
                Thread.Sleep(1000); // 1 sekunda
                ImmediateStop(); // zatrzymanie pojazdu
            }
            else
                Thread.Sleep(time);
        }

        public override void Stop() // nadpisujemy tą metodę
        {
            Console.WriteLine("Samochód się zatrzymał!");
        }

        private void ImmediateStop()
        {
            Console.WriteLine("Samochód został natychmiastowo zatrzymany!");
        }
    }
}
