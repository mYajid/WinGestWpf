using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
   
    
    public class Client
    {

        public static HashSet<Client> clientsHS = new HashSet<Client>();
        public static HashSet<Contact> contactsHS = new HashSet<Contact>();
        private int _idClient;
        private string _raisonSociale;
        private string _adresse1;
        private string _adresse2;
        private int _telephoneClient;
        private int _effectif;
        private decimal _CA;
        private bool _typeSociete;
        private string _ville;
        private int _CP;
       
        /// <summary>
        /// L'id de mon client
        /// </summary>
        public int IdClient
        {
            get
            {
                return _idClient;
            }
            set
            {
                if (!IsIdClientValid(value))
                {
                    throw new Exception(string.Format("La valeur saisie {0} n'est pas valide", value));

                }
                _idClient = value;
            }

        }

        /// <summary>
        /// Numero de telephone client
        /// </summary>

        public int TelephoneClient
        {
            get
            {
                return _telephoneClient;
            }
            set
            {
                if (!IsTelephoneClientValid(value))
                {
                    throw new Exception(string.Format("Le numero saisie {0} n'est pas valide", value));
                }
                _telephoneClient = value;
            }

        }
        /// <summary>
        /// L'effectif de mon client
        /// </summary>
        public int Effectif
        {
            get
            {
                return _effectif;
            }
            set
            {
                _effectif = value;
            }

        }
        /// <summary>
        /// La chiffre d'affaire de mon client 
        /// </summary>
        public decimal CA
        {
            get
            {
                return _CA;
            }
            set
            {
                _CA = value;
            }

        }
        /// <summary>
        /// Type Societe client
        /// </summary>
        public bool TypeSociete
        {
            get
            {
                return _typeSociete;
            }
            set
            {

                _typeSociete = value;

            }

        }
        /// <summary>
        /// Raison Sociale client 
        /// </summary>
        public string RaisonSociale
        {
            get
            {
                return _raisonSociale;
            }
            set
            {
                if (!IsRaisonSocialeValide(value))
                {
                    throw new Exception(string.Format("La Raison Sociale {0} n'est pas valide", value));
                }
                _raisonSociale = value;
            }

        }
        /// <summary>
        /// Adresse client
        /// </summary>
        public string Adresse1
        {
            get
            {
                return _adresse1;
            }
            set
            {
                _adresse1 = value;
            }

        }
        public string Adresse2
        {
            get
            {
                return _adresse2;
            }
            set
            {
                _adresse2 = value;
            }

        }
        /// <summary>
        /// Cod Postal Client
        /// </summary>
        public int CodPostal
        {
            get
            {
                return _CP;
            }
            set
            {
                _CP = value;

            }

        }
        /// <summary>
        /// Ville client 
        /// </summary>
        public string Ville
        {
            get
            {
                return _ville;
            }
            set
            {

                _ville = value;
            }

        }

        public bool IsRaisonSocialeValide(string value)
        {
            if (value == null || value.Length > 32)

            { return false; }

            for (int i = 0; i < value.Length - 1; i++)
            {
               
                if (!char.IsLetter(value[i]) && !char.IsWhiteSpace(value[i]))
                {
                    return false;
                }
            }
            return true;

        }
        public bool IsTelephoneClientValid(int value)
        {

            string valeur = value.ToString();

            if (valeur == null || valeur.Length > 15)

                return false;

            for (int i = 0; i < valeur.Length - 1; i++)
            {
                if (!char.IsDigit(valeur[i]))
                {
                    return false;
                }
            }
            return true;




        }

        public bool IsIdClientValid(int value)
            
        {
            string valeur = value.ToString();

            if (valeur == null || valeur.Length > 4)

                return false;

            for (int i = 0; i < valeur.Length - 1; i++)
            {
                if (!char.IsDigit(valeur[i]))
                {
                    return false;
                }
            }
            return true;


        }



        public HashSet<Contact> ListContact {get; set;}
        public Activite Activite { get; set; }
        

    }
}  
