using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class ContactMethodes
    {
        Contact conctacts;

        private Contact selectionnerContact;
        public Contact SelectedContact
        {
            get
            {
                return selectionnerContact;
            }
            set
            {
                selectionnerContact = value;
            }
        }

        private bool isModifierContactActive;
        public bool IsModifierContactActive
        {
            get
            {
                return isModifierContactActive;
            }
            set
            {
                isModifierContactActive = value;
            }
        }

        public bool isModeAffichageActive
        {
            get
            {
                return !isModifierContactActive;
            }
        }

       
        public ContactMethodes()
        {
           


        }

        private void supprimerContact()
        {
            Contact.Remove(SelectedContact);
            Save();
        }

        private bool PeutSuprimmer()
        {
            return SelectedContact == null ? false : true;
        }

        private void Add()
        {
            var newContact = new Contact
            {
                Prenom = "Kamel",
                Nom = "Elk",
                Telephone = new string[2],
                Mail = new string[2],
                Rue = "",
                NumeroRue = "",
                CodePostal = "",
                Ville = "",

            };
           
            Contact.Add(newContact);
            SelectedContact = newContact;
        }

        private void telechargerImage()
        {
            
        }

        private void Update()
        {
          
        }

        private void Save()
        {
            
        }

        private bool IsEdit()
        {
            return IsModifierContactActive;
        }

        private bool CanEdit()
        {
            if (SelectedContact == null)
                return false;

            return !IsModifierContactActive;
        }

        private void Edit()
        {
            IsModifierContactActive = true;
        }

        public void LoadContacts(IEnumerable<Contact> contacts)
        {
         

        }

        private string nomUtilisateur = "kamel";
        private const string motDePasse = "kamel";
        private bool CheckPassWordEtUserName()
        {
            bool motDePasseValide = false;

            if (nomUtilisateur ==   )
            {



            }
            return ;

        }





}
}
