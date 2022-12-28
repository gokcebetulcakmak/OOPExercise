using OOPExercise;

internal class Program
{
    // İnsan isimli bir sınıf içinde ad, soyad, boy, kilo, yaş alanlarını tanımlayıp, bir kurucu -constructor- metod içinde bu alanlar için değer atamalarını yapacağız. Son olarak da "Tanis" isimli metodla girilen bilgileri kullanıcıya belli, güzel, açıklayıcı bir şekilde görünteleyen bir programcık yazınız
    //Örnek : Ben Gökçe Betül ÇAKMAK...Boyum 164cm, Kilom 48kg, Yaşım 26'dır.

    
    private static void Main(string[] args)
    {
       HumanProperty humanProperty = new HumanProperty();
       humanProperty.Tanis();
       Console.ReadKey();
    }
}