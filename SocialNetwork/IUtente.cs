namespace SocialNetwork
{
    using System.Collections.Generic;

    public interface IUtente
    {
        IList<IUtente> Contatti { get; }

        IPagina Pagina { get; }
    }
}