namespace Heranca_Multipla_Problema_Do_Diamante.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
