using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GestionCommercialeDll;

namespace WpfWinGest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Client> clientList = Fichier.ReadFromFile();

            Client.clientsHS = new HashSet<Client>(clientList);

            Client client1 = new Client();
            client1.IdClient = 1234;
            client1.RaisonSociale = "Exploitation Legoff";
            client1.Adresse1 = "Le Hameau";
            client1.Adresse2 = "Route de Ploubazlanec";
            client1.CodPostal = 22500;
            client1.Ville = "Paimpol";
            client1.TypeSociete = true;
            client1.TelephoneClient = 0299010203;
            client1.Effectif = 12;
            client1.CA = 275000;

            /// instanciation de la classe activité
            Activite activite1 = new Activite();
            activite1.Activit = "Boissons";
            activite1.NatureAct = Natur.Principale;
            client1.Activite = activite1;


            Contact contact1 = new Contact();
            contact1.IdClient = 1234;
            contact1.NomContact = "Legoff";
            contact1.PrenomContact = "Alain";
            contact1.Telephone = 0661564555;
            contact1.Email = "alain@LegoffBretagne.fr";
            contact1.FonctionSetting = Fonction.Dirigeant;

            HashSet<Contact> contacts = new HashSet<Contact>();
            contacts.Add(contact1);

            client1.ListContact = contacts;
            Client.clientsHS.Add(client1);

            // instanciation d'un deuxieme client test--------------------------

            Client client2 = new Client();
            client2.IdClient = 1235;
            client2.RaisonSociale = "Conseil Général";
            client2.Adresse1 = "3 rue de la république";
            client2.Adresse2 = "";
            client2.CodPostal = 35000;
            client2.Ville = "Rennes";
            client2.TypeSociete = false;
            client2.TelephoneClient = 0355555555;
            client2.Effectif = 47;
            client2.CA = 0;

            /// instanciation de la classe activité
            Activite activite2 = new Activite();
            activite2.Activit = "Administration";
            activite2.NatureAct = Natur.Principale;
            client2.Activite = activite2;


            Contact contact2 = new Contact();
            contact2.IdClient = 1235;
            contact2.NomContact = "Doe";
            contact2.PrenomContact = "John";
            contact2.Telephone = 0661563333;
            contact2.Email = "jDoe@CG.fr";
            contact2.FonctionSetting = Fonction.Comptable;

            HashSet<Contact> contacts2 = new HashSet<Contact>();
            contacts2.Add(contact2);

            client2.ListContact = contacts2;
            Client.clientsHS.Add(client2);

            this.dtgListClient.ItemsSource= Client.clientsHS;



            //foreach (Client item in Client.clientsHS)
            //{
            //   // Remplit la DataGridView à partir de la liste HachSet où sont stockées les données des clients.
            //    this.dtgListClient.r.Add(item.RaisonSociale, item.Ville, item.CodPostal, item.TypeSociete, item.Activite.Activit, item.Activite.NatureAct);
            //}
        }
    }
}
