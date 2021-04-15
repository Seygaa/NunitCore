# NunitCore
## Zadanie 1
Proszę napisać klasę łącząca dwa łańcuchy znaków. Jeżeli co najmniej jednym z łańcuchów
znaków jest null funkcja ma również zwracać null. Następnie za pomocą biblioteki NUnit i
mechanizmu asercji proszę napisać testy, które sprawdzą jej zachowanie dla kilku typowych
wartości oraz warunków brzegowych. “Wartość brzegowa ISTQB”

## Zadanie 2
Proszę napisać drugą wersję klasy łączącej dwa łańcuchy znaków. Jeżeli, któryś z argumentów
jest nullem, chcielibyśmy, że metoda rzuciła wyjątkiem – proszę to sprawdzić przy pomocy
asercji.

## Zadanie 3
* Interfejs obiektu który sprawdza czy dane słowa są anagramami. * Anagram
jest słowem lub frazą, która powstała <br />
* przez zmianę kolejności liter w oryginalnym słowie lub frazie. <br />
* Zobacz kilka przykładów na http://www.wordsmith.org/anagram/hof.html : <br />
### public interface IAnagramChecker <br />
### { <br />
&nbsp;&nbsp;&nbsp; Sprawdza czy jedno slowo jest anagramem drugiego. <br />
&nbsp;&nbsp;&nbsp; * Wszystkie niealfanumeryczne znaki są ignorowane. <br />
&nbsp;&nbsp;&nbsp; * Wielkość liter nie ma znaczenia. <br />
&nbsp;&nbsp;&nbsp; * word1 - dowolny niepusty string różny od null. <br />
&nbsp;&nbsp;&nbsp; * word2 - dowolny niepusty string różny od null. <br />
&nbsp;&nbsp;&nbsp; * Zwraca true wtedy i tylko wtedy gdy word1 jest anagramem word2. <br />
### &nbsp;&nbsp;&nbsp; bool IsAnagram(string word1, string word2); <br />
### } <br />

A. Proszę napisać jak najlepszy zestaw testów jednostkowych dla powyższego. <br />
B. Proszę zaimplementować klasę AnagramChecker. <br />
C. Jeżeli podczas implementacji przyjdą Państwu do głowy nowe przypadki testowe, to
proszę je dopisać to zestawu testowego(proszę jakoś oznaczyć takie przypadki). <br />
D. Proszę usunąć błędy i stworzyć dla nich nowe przypadki testowe(proszę je oznaczyć w
jakiś specjalny sposób). <br />

## Zadanie 4
„Formularz zawiera pole "PESEL", system udziela zniżki osobom poniżej 18 i powyżej 65
lat." <br />
Proszę w zadaniu korzystać z interface’u: <br />
public interface IDiscountFromPeselComputer <br />
{ <br />
bool HasDiscount(String pesel) <br />
} <br />
oraz z klasy wyjątku: <br />
public class InvalidPeselException : Exception <br />
{ <br />
} <br />
A. Proszę napisać za pomocą TDD testy jednostkowe dla interfejsu
IDiscountFromPeselComputer <br />
B. Proszę sprawdzić jaki odsetek Państwa testów nie przechodzi dla przykładowej
implementacji umieszczonej na Pegazie. <br />
C. Proszę wykorzystując stworzone przez Państwa testy jednostkowe napisać jak najlepszą
implementację metody “HasDiscount”. 
