using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace GestionCommercialeDll
{   [Serializable()]
    public class Fichier
    {
        //Méthode pour écrire la collection clientsHS sur le disque.

         static public void WriteToFile()
        {
            // Conversion du HashSet en list

            List<Client> clientList = Client.clientsHS.ToList();


            XmlSerializer xmlSerializer = new XmlSerializer(typeof (List<Client>));
            using (StreamWriter SW = new StreamWriter("..\\..\\clients.xml"))
            {
                xmlSerializer.Serialize(SW, clientList);

                SW.Close();
            }

        }

          public static List<Client> ReadFromFile()
        {
            List<Client> clientList ;
            XmlSerializer xmlSerializer=new XmlSerializer(typeof(List<Client>));
            using (StreamReader SR = new StreamReader("..\\..\\clients.xml"))
            {
               clientList = ( List<Client>)xmlSerializer.Deserialize(SR) ;
                SR.Close();
            }
            
            return clientList;
        }


        static public void WriteActivite()
        {
           
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));
            using (StreamWriter SW = new StreamWriter("..\\..\\activites.xml"))
            {
                xmlSerializer.Serialize(SW, Activite.Metiers);

                SW.Close();
            }

        }

        public static List<string> ReadActivite()
        {
            List<string> activites;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));
            using (StreamReader SR = new StreamReader("..\\..\\activites.xml"))
            {
                activites = (List<string>)xmlSerializer.Deserialize(SR);
                SR.Close();
            }

            return activites;
        }
    }
}
