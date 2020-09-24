namespace Model
{
    public class Contact
    {
        
        public string Prenom { get; set; }

        public string Nom { get; set; }


        public string[] Telephone { get; set; }


        public string[] Mail { get; set; }

        public string Rue { get; set; }

        public string NumeroRue { get; set; }

        public string CodePostal { get; set; }

        public string Ville { get; set; }


        public bool IsFavorite { get; set; }


        public string PhotoContact { get; set; }

    }
}
