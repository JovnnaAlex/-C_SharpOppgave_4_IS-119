/*Øvelse 4: deklarerer en klasse og kaller den "Person". Deklarer variabler ID, navn, fødselsdato og adresse. 
Skriv en metode som skriver ut informasjon om person. */

//Starter med å lage en navnerom, den sier alt inni disse krøllparentesene tilhører dette navnerommet

namespace Uke2_øvelser                  //Lager en klasse kalt uke2_øvelser
{
    public class Person                 //Klassen "Person får fullt navn: Uke2_øvelser.Person.
    {  
        // deklarerer instansvariabler  //Dette er informasjonen hver person skal ha, kaller er våre deklarerte "instantsvariabler"
        private int id;                 // VI bruker "private" for å protecte informasjon om useren". Hvis jeg ikke skriver private, så blir den public automatisk.
        private string navn;            //Skriver navn med liten bokstavn fordi det er C# Konveksjon, men vi kan bruke stor bokstav hvis det er to ord, eks: personId
        private DateOnly fødselsdato;
        private string adresse; 

        // Konstruktøren
        public Person()
        {
            this.id = 0;
            this.navn = string.Empty;
            this.fødselsdato = new DateOnly();
            this.adresse = string.Empty;

        }

        // deklarerer Set og Get metoder
        public void SetId(int personId)       //Set og Get metoder, vi bruker metoder som skal kommunisere med klassen, MÅ være public da
        {

            id = personId;                              
            
        } 
        public void SetNavn(string personNavn)
        {
            navn = personNavn;
        }  
        public int GetId()
        {
            return id;
        }  
        public string GetNavn()
        {
            return navn;
        } 
        public void VisInformasjon ()
        {
            Console.WriteLine("Person ID: " + id + " Person Name: " + navn);
            //string interpolation
            Console.WriteLine($"Person ID: {id} Person Name: {navn}"); //Setter $ for å gjøre at det er verdier og ikke bare strings
        }                    
    }
}
