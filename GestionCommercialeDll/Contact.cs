using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommercialeDll
{
    public enum Fonction { Dirigeant, Comptable, ResponsableRH, Commercial }
    public class Contact

    {
        private int _idClient;
        private string _nomContact;
        private string _prenomContact;
        private int _telephoneContact;
        private string _emailContact;


        public int IdClient
        {
            get { return _idClient; }
            set { _idClient = value; }
        }

        public string NomContact
        {
            get { return _nomContact; }
            set { _nomContact = value; }
        }
        public string PrenomContact
        {
            get { return _prenomContact; }
            set { _prenomContact = value; }
        }
        public int Telephone
        {
            get { return _telephoneContact; }
            set { _telephoneContact = value; }
        }
        public string Email
        {
            get { return _emailContact; }
            set { _emailContact = value; }
        }
        public Fonction fonction
        {
            get { return fonction; }
            set { fonction = value; }
        }
                

        public bool IsNomPrenomValide(string value)
        {
            if (value == null || value.Length > 32)
                return false;
            for (int i = 0; i < value.Length - 1; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsTelephoneValide(string value)
        {
            if (value == null || value.Length > 15)
                return false;
            for (int i = 0; i < value.Length - 1; i++)
            {
                if (char.IsLetter(value[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public Client Client { get; set; }
    }
}

