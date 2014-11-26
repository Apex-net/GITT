namespace SocialNetwork
{
    public class Cinguettio : FacciaLibro
    {
        public Cinguettio(IUtente utenteCollegato)
            : base(utenteCollegato)
        {
        }

        public new void PubblicaMessaggio(string messaggio)
        {
            if (messaggio.Length > 140)
            {
                return;
            }

            base.PubblicaMessaggio(messaggio);
        }
    }
}
