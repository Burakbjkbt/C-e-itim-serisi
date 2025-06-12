Console.WriteLine("----------Strings metotlar Start----------");
string yazı1 = "bu dosya da string ve date konularını görücesiniz";
var yazı2 = "BU  DOSYADA BURAK ADIN DAKİ KİŞİ HAKKINDA BİLGİLER VAR";
var yazı3 = "bu dosyada burak adın  daki kişi hakkında bilgiler var";
var yazı4 = "  bu dosyada burak adın  daki kişi hakkında bilgiler var  ";
var yazı5 = "bu dosyada burak adın  daki kişi hakkında bilgiler var";
var yazı6 = "bu dosyada burak adın  daki kişi hakkında bilgiler var";
var yazı7 = "bu dosyada burak adın  daki kişi hakkında bilgiler var";
int yazı1_sonuc = yazı1.Length;//Kaç harf yani kaç karakter varsa ounun sayısını verir
var yazı2_sonuc = yazı2.ToLower();//Büyük kelimeleri küçük harfe çevirir
var yazı3_sonuc = yazı3.ToUpper();//küçük kelimeleri büyük harfe çevirir
var yazı4_sonuc = yazı4.Trim();//Metin içersindeki ilk ve son daki boşlukları alır
var yazı6_sonuc = yazı5.StartsWith("b");//String yada diğer veri tipleri başlangıçta harf sayı true (doğru) eğer false(yanlış) olur 
var yazı7_sonuc = yazı5.Substring(5);//belirlediğimiz index sayısından başlar
Console.WriteLine(yazı1_sonuc);
Console.WriteLine(yazı2_sonuc);
Console.WriteLine(yazı3_sonuc);
Console.WriteLine(yazı4_sonuc);
Console.WriteLine(yazı6_sonuc);
Console.WriteLine(yazı7_sonuc);