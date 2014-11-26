namespace SocialNetwork
{
    public class FacciaLibro : ISocialNetwork
    {
        public FacciaLibro(IUtente utente)
        {
            this.UtenteCollegato = utente;
        }

        public IUtente UtenteCollegato { get; set; }

        public void AggiungiContatto(IUtente contatto)
        {
            this.UtenteCollegato.Contatti.Add(contatto);
        }

        public void PubblicaMessaggio(string messaggio)
        {
            this.UtenteCollegato.Pagina.AggiungiContenuto(messaggio);
        }
    }
}
