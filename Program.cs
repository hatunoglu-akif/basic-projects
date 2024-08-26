//Author:Mehmet Akif Hatunoğlu
//Askere Gitmeli mi ver.1.0
bool yetiskinMi;
string okuluBittimi;
Console.Write("Yaşınızı giriniz: ");
int yas = Convert.ToInt32(Console.ReadLine());
if(yas >= 18){
    yetiskinMi = true;
}
else
{
    yetiskinMi = false;
}
Console.Write("Okulunuzu bitirdiniz mi? (evet: e, hayır: h): ");
okuluBittimi = Console.ReadLine();

if(yetiskinMi == true && okuluBittimi == "e"){
    Console.WriteLine("Askere gitme vaktiniz gelmiştir!");
}
else if(yetiskinMi == true && okuluBittimi == "h"){
    Console.WriteLine("Okulunuz bittiğinde askere geleceksiniz!");
}
else{
    Console.WriteLine("Askere gelme vaktiniz henüz gelmedi.");
}