using System; //Vi bruker mye console så derfor bruker vi «using System;»
using Uke2_øvelser; //Klassen fra filen "Person.cs
/* Øvselse 4: Vi lager en konstruktør for å lage en objekt av vår klasse */

// få verdier fra brukeren
int idVerdi = int.Parse(Console.ReadLine()); //siden alt i console metoden er string, må vi bruke int.parse for å oversette datatypen
string navnVerdi = Console.ReadLine();

//datatype (Person) variabel navn (p)= nytt objekt (new) konstruktør Person()
Person p = new Person(); // "new" er nøkkelord som lar oss lage en nt nytt objekt
//p.SetId(123);
//p.SetNavn("Espen");
//p.Visinformasjon();

//Skriver eller "printer" ut verdier som vi fikk fra brukeren
p.SetId(idVerdi);
p.SetNavn(navnVerdi);
p.VisInformasjon();

//Ved bruk av get og set metoden 
string pNavn = p.GetNavn(); //Henter navnet fra objektet p
Console.WriteLine(pNavn);  // skriver ut en variabel, brukes når man trenger navnet flere ganger.
Console.WriteLine(p.GetNavn()); //Henter navnet fra objektet p og skriver den ut. Brukser når man trenger den en gang.
