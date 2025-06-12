Console.WriteLine("----------Nullable Types start----------");
/*
1-Null içi boş anlamına gelir
2-HasValue Türkçesi = Değeri var değer varsa ture(doğru) eğer değer yok ise false(yanlış) sonucunu veririr
3-GetValueOrDefault  Türkçesi = Değer Al Veya Varsayılan uygula değer varsa o değeri yansıtır eğer değer yok ise 0 sonucunu veririr
*/
int? uyarı1 = null;
int? uyarı2 = 10;
Console.WriteLine(uyarı1.HasValue);
Console.WriteLine(uyarı2.GetValueOrDefault());

