using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace GestionCommercialeDll
{

    [Serializable()]
    public class Client
    {

        public static HashSet<Client> clientsHS = new HashSet<Client>();

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


        public Client()
        {

        }

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
        /// Cod postal client
        /// </summary>
        public int CodPostal
        {
            get
            {
                return _CP;
            }
            set
            {
                if (!CPValid(value))
                {
                    throw new Exception(string.Format("Le Code Postal {0} n'est pas valide", value));
                }
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
        /// <summary>
        /// Vérification du format de la valeur Raison Sociale
        /// La longueur maxi 32 ne doit pas contenir de chiffre, elle accepte aussi des espaces vides
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsRaisonSocialeValide(string value)
        {
            if (value == string.Empty || value.Length > 32)

            { return false; }

            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]) && !char.IsWhiteSpace(value[i]) && !char.IsDigit(value[i]))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Verification du format de la valeur telephone
        /// Longueur maxi 15, ne doit pas contenir de lettres  
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsTelephoneClientValid(int value)
        {
            string number = value.ToString();

            return Regex.Match(number, @"^(^[0-9]{9}$|^06[0-9]{8}$|^00[0-9]{11,13}$)$").Success;


        }
        /// <summary>
        /// Verification de la propriete id client, longueur maxi 4,
        /// ne doit pas contenir de lettres
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsIdClientValid(int value)

        {
            string valeur = value.ToString();

            if (valeur == null || valeur.Length > 4)

                return false;

            for (int i = 0; i < valeur.Length; i++)
            {
                if (!char.IsDigit(valeur[i]))
                {
                    return false;
                }
            }
            return true;

        }

        public bool CPValid(int value)

        {
            string valeur = value.ToString();

            if (valeur == null || valeur.Length != 5)
            {
                return false;
            }
            return true;

        }



        /// <summary>
        /// Surcharge (override) de la fonction héritée Equals
        /// Elle doit renvoyer la comparaison de deux clients
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            { return false; }

            if (!(obj is Client))
            { return false; }

            return this.IdClient == ((Client)obj).IdClient;
        }

        /// <summary>
        /// Surcharge(override) de la fonction héritée Equals
        /// Elle doit renvoyer le HashCode de la proprieté Id client 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.IdClient.GetHashCode();
        }


        public HashSet<Contact> ListContact { get; set; }

        public Activite Activite { get; set; }


    }
}
