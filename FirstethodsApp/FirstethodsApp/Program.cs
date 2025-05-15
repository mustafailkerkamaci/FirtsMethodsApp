

//1 Geriye Deger Dondurmeyen Metot
//Ekrana sevdiginiz bir sarki sozunu yazdirsin.
static void SongLyrics()
{
    Console.WriteLine("Ben buyum, nokta koyduk bitti");
}
SongLyrics();

//2 Geriye tamsayi donduren bir metot
//Rastgele bir sayi uretim bu sayinin 2'ye bolumunden kalani geriye dondersin
static int RandomNumber()
{
    Random random = new Random(); //rastgele bir sayi uretmek icin random sinifini kullaniyoruz.
   int randomNumber = random.Next(1, 100); // randomnumber adinda degisken tanimlayip random degiskeninin 1 ile 100 arasinda bir sayi uretmesini istiyoruz.
    int remainder = randomNumber % 2; // reamainer (kalan) adinda degisken tanimlayip randomNumber'in 2'ye bolumunden kalanini aliyoruz.
    return remainder; // remainer degiskenini donduruyoruz.

}
int output = RandomNumber(); // output adinda bir degisken tanimlayip RandomNumber() metotunu cagiriyoruz.
Console.WriteLine($"Uretilen rastgele sayinin 2'ye bolumunden kalan : {output}"); // ekrana yazdiriyoruz.

//3 Parametre Alan Ve geriye Deger Donduren Metot.
// Parametre olrak aldigi iki sayinin carpimini geriye dodursun.

static int Multiply(int number1, int number2)
{
    return number1 * number2; // number1 ve number2'yi carpip geriye donduruyoruz.
}
int num1, num2;
Console.WriteLine("Ilk sayiyi giriniz");
num1 = Convert.ToInt32(Console.ReadLine()); // kullanicidan birinci sayiyi girmesini istiyoruz.
Console.WriteLine("ikinci sayiyi giriniz");
num2 = Convert.ToInt32(Console.ReadLine()); // kullanicidan ikinci sayiyi girmesini istiyoruz.
int result = Multiply(num1, num2); // result adinda bir degisken tanimlayip Multiply() metotunu cagiriyoruz.
Console.WriteLine($" iki sayinin carpimi  : {result}"); // ekrana yazdiriyoruz.

//4 Parametre alan ve geriye deger dondurmeyen metot.
// Parametre olarak isim ve soyisim degerlerini alip "Hoş Geldiniz {isim} {soyisim}" seklinde ekrana bassin 

static void Welcome(string firstName, string lastName) // geriye deger dondurmedigimizx icin void kullanabiliyoruz.
{
    Console.WriteLine("isminizi giriniz");
    firstName = Console.ReadLine(); // kullanicidan isim girmesini istiyoruz.
    Console.WriteLine("soyisminizi giriniz");
    lastName = Console.ReadLine(); // kullanicidan soyisim girmesini istiyoruz.
    Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}"); // isim ve soyismi ekrana yazdiriyoruz.
}
Welcome(" ", " "); // Welcome() metotunu cagiriyoruz. bu degerleri sonradan alacagimiz icin bosluk birakiyoruz.