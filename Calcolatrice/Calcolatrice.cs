namespace Calcolatrice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Calcolatrice : ICalcolatrice
    {
        public decimal Addizione(params decimal[] addendi)
        {
            return ApproccioIterativo(addendi);
            ////return ApproccioRicorsivo(addendi);
            ////return ApproccioFunzionale(addendi);
        }

        private static decimal ApproccioIterativo(
            IEnumerable<decimal> addendi)
        {
            var somma = 0m;
            foreach (var i in addendi)
            {
                somma += i;
            }

            return somma;
        }

        private static decimal ApproccioRicorsivo(
            IEnumerable<decimal> addendi,
            decimal somma = 0)
        {
            var stack = addendi as Stack<decimal> ?? new Stack<decimal>(addendi);

            try
            {
                somma += stack.Pop();
            }
            catch (InvalidOperationException)
            {
                return somma;
            }

            return ApproccioRicorsivo(stack, somma);
        }

        private static decimal ApproccioFunzionale(
            IEnumerable<decimal> addendi)
        {
            return addendi.Sum();
        }
    }
}
