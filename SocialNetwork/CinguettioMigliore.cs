namespace SocialNetwork
{
    public class CinguettioMigliore : FacciaLibro
    {
        private readonly int limite;

        public CinguettioMigliore(IUtente utenteCollegato, int limite = 140)
            : base(utenteCollegato)
        {
            this.limite = limite;
        }

        public new void PubblicaMessaggio(string messaggio)
        {
            if (messaggio.Length > this.limite)
            {
                this.UtenteCollegato.Pagina.VisualizzaErrore(
                    "Il tuo cinguettio deve essere breve.");
                return;
            }

            base.PubblicaMessaggio(messaggio);
        }
    }
}
