using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{

    public class Client
    {
        /// <summary>
        /// Creation instance liste clients
        /// </summary>
        public static HashSet<Client> clientsHS = new HashSet<Client>();


        private int _idClient;
        private string _raisonSociale;
        private string _adresse1;
        private string _adresse2;
        private int _telephoneClient;
        private int _effectif;
        private decimal _CA;
        private string _typeSociete;
        private string _ville;
        private int _CP;

        /// <summary>
        /// L'id de mon client
        /// </summary>


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
        public string TypeSociete
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
        /// <summary>
        /// Verification du format de la valeur _raisonSociale
        /// Longueur maxi 32 , elle doit permettre des espaces   
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>

        /// <summary>
        /// Vérification du format de la valeur _telephoneClient
        /// Longueur maximum 15 chiffre, ne doit pas contenir des lettres
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// 
        public bool IsTelephoneClientValid(int value)
        {

            string valeur = value.ToString();

            if (valeur == "" || valeur.Length > 15)

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

        /// <summary>
        ///  Vérification du format de la valeur _idClient
        ///  Longueur maxi 4, ne doit pas permettre des lettres
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>



        public HashSet<Contact> ListContact { get; set; }

        public Activite Activite { get; set; }
        public int IdClient
        {
            get { return _idClient; }

            set
            {
                if (!IsIdValid(value))
                {
                    throw new Exception(string.Format("L'id saisi {0} n'est pas valid ", value));      
                }
                 _idClient = value; }
        }

        public string RaisonSociale
        {
            get { return _raisonSociale; }
            set {
                if (!IsRaisonSocValide(value))
                {
                    throw new Exception(string.Format("La Raison Sociale {0} n'est pas valide", value));
                } 
                     _raisonSociale = value; }
        }

        /// Surcharge ( override ) de la fonction héritée Equals 
        ///Elle doit renvoyer la comparaison de deux IdClients
        ///
        public override bool Equals(object obj)
        {
            if (obj == null)
            { return false; }

            if (!(obj is Client))
            { return false; }


            return this.IdClient == ((Client)obj).IdClient;

        }

        public override int GetHashCode()
        {
            return this.IdClient.GetHashCode();
        }

        public bool IsIdValid(int id)
        {
            string valeur =id.ToString();

            for (int i = 0; i < valeur.Length; i++)
            {

                if (!char.IsDigit(valeur[i]) || valeur.Length>4|| valeur== string.Empty)
                {
                    return false;
                }
            }
            return true;

        }

        public bool IsRaisonSocValide(string value)
        {
            if (value.Length < 2 || value.Length > 32 || value == string.Empty)
            {
                return false;
            }
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]) 
                    || !char.IsDigit(value[i]) || !char.IsWhiteSpace(value[i])) 
                {
                    return false;
                }
            }

            return true;
        }



    }

}
