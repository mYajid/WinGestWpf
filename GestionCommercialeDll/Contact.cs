using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace GestionCommercialeDll
{
    public enum Fonction {Dirigeant, Comptable, ResponsableRH, Commercial }

    [Serializable]
    public class Contact

    {
        private int _idClient;
        private string _nomContact;
        private string _prenomContact;
        private int _telephoneContact;
        private string _emailContact;
        private string _imageContact;

        public int IdClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }

        public string NomContact
        {
            get { return _nomContact; }
            set {
                if (!IsNomPrenomValide(value))
                {
                    throw new Exception(string.Format("Le nomn {0} n'est pas valide", value));
                }
                _nomContact = value; }
        }
        public string PrenomContact
        {
            get { return _prenomContact; }
            set {
                if (!IsNomPrenomValide(value))
                {
                    throw new Exception(string.Format("Le prénom {0} n'est pas valide", value));
                }
                _prenomContact = value; }
        }
        public int Telephone
        {
            get { return _telephoneContact; }
            set {
                if (!IsTelephoneValide(value))

                {
                    throw new Exception(string.Format("Le numero saisie {0} n'est pas valide", value));
                }

                _telephoneContact = value; }
        }
        public string Email
        {
            get { return _emailContact; }

            set {
                if (!IsEmailValide(value))

                {
                    throw new Exception(string.Format("L'adresse mail  {0} n'est pas valide", value));
                }
                
                _emailContact = value; }
        }
        public Fonction FonctionSetting
        {get; set;  }


        public bool IsNomPrenomValide(string value)
        {
            if (value == string.Empty || value.Length > 32)
                return false;
            for (int i = 0; i < value.Length - 1; i++)
            {
                if (!char.IsLetter(value[i])&&!char.IsWhiteSpace(value[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsTelephoneValide(int value)
        {

            string number = value.ToString();

            return Regex.Match(number, @"^(^[0-9]{9}$|^06[0-9]{8}$|^00[0-9]{11,13}$)$").Success;

            //if (value == null || value.Length > 15)
            //    return false;
            //for (int i = 0; i < value.Length - 1; i++)
            //{
            //    if (char.IsLetter(value[i]))
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }


        public bool IsEmailValide(string value)
        {
            return Regex.Match(value, @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$").Success;
        }

        public string ImageClient
        {
            get { return _imageContact; }
            set { _imageContact = value; }
        }

        public Client Client { get; set; }
    }
}

