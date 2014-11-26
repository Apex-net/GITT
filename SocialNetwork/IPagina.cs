namespace SocialNetwork
{
    public interface IPagina
    {
        void AggiungiContenuto(object messaggio);

        void VisualizzaErrore(string messaggio);
    }
}