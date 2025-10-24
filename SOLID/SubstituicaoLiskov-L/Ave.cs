
namespace SubstituicaoLiskov_L
{
    public abstract class Ave // nao vou poder criar um novo objeto a partir de Ave, so estender
    {
        public abstract void Mover(); // quando for chamar ele em outra classe, precisa fazer um override
        // cada ave vai se mover de um jeito, ou seja, e um metodo que precisa ser flexivel e obrigatorio

        public virtual void Dormir() => Console.WriteLine("Dormindo..."); // e um metodo fixo, ou seja, nao e abstrato
        // virtual permite sobrescrever sem ser obrigatorio (o abstract torna obrigatorio)
    }
}