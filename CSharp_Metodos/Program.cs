abstract class Motocicleta
{
    // Cualquiera puede llamar a este método.
    public void EncenderMotor() { /* Declaraciones del método aquí */ }

    // Solo las clases derivadas pueden llamar a este método.
    protected void AñadirGasolina(int galones) { /* Declaraciones del método aquí */ }

    // Las clases derivadas pueden sobrescribir la implementación de la clase base.
    public virtual int Conducir(int millas, int velocidad)
    {
        /* Declaraciones del método aquí */
        return 1;
    }

    // Las clases derivadas deben implementar este método.
    public abstract double ObtenerVelocidadMáxima();
}
