using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{   //public enum Metier {Administration, Bovins, Cereales, Boissons, Laiterie, Pêche,Mecanique, }
    public  enum Natur { Principale, Secondaire,Ancienne}
   public class Activite
    {

        public static List<String> Metiers = Fichier.ReadActivite();
       // { "Administration", "Bovins", "Cereales", "Boissons", "Laiterie", "Pêche","Mecanique"};

        

        public String Activit { get; set; }
        public Natur NatureAct { get; set; }

        public Client Client { get; set; }
       
       



    }


}
