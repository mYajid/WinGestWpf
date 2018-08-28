using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{


    public enum Metier { Boisson  = 1, laiterie, Administration }
    public  enum Nature { Principale = 1, Secondaire , Ancienne  }

   public class Activite
    {
       
        

        public Metier ActiviteAct
        { get; set; }
      public Nature nature { get; set; }

        public Client client { get; set; }
    }


}
