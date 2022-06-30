
//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,
//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

//una serie di istanze per "popolare" il nostro "fake db"
// 2 o 3 utenti -> registrati
// 2 o 3 libri --> tutti disponibili
// Gli utenti si possono registrare specificando i dati ...


// Biblioteca online
// 1. registrati
// 2. login

//login 
// email: ..
// passowrd: ..

// Biblioteca online
// 1. Cerca libri
// 2. Cerca dvd

// Registrazione
// Scrivmi il nome: 
// scrivimi il cognome.. etc
// scrivi la passowrd: 

// Menu libro (titolo)
// 1. visualizza dettagli libro
// 2. richiedi prestito
// 3. restitutisci


// tutti i menu hanno esci o torna indietro


using csharp_biblioteca;

User user1 = new User("Rossi", "Marco", "marcorossi@mail.com", "password", 333888554);
User user2 = new User("Bianco", "Marta", "biancomarta@mail.com", "password", 323857454);


Dvd dvd1 = new Dvd(120, 1522548852, "Matrix", 2000, "4D", true, 3, "qualcuno chenonricordo");
Dvd dvd2 = new Dvd(120, 2392343871, "Boh", 1998, "7D", true, 2, "qualcun'altro chenonricordo");

Book book1 = new Book(345, 0004450008, "La vita è altrove", 2002, "24C", true, 12, "Milan Kundera");
Book book2 = new Book(215, 0000071108, "La grammatica di dio", 2002, "35F", true, 3, "Stefano Benni");

List<Item> items = new List<Item>();
List<User> users = new List<User>();

items.Add(book1);
items.Add(book2);
items.Add(dvd1);
items.Add(dvd2);

users.Add(user1);
users.Add(user2);


Library library = new Library(users, items);


library.PrintSearchResult(library.SearchItem("Matrix"));


