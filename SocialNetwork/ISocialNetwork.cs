namespace SocialNetwork
{
    public interface ISocialNetwork
    {
        void AggiungiContatto(IUtente contatto);

        void PubblicaMessaggio(string messaggio);
    }
}
