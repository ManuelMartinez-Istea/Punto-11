namespace Punto_11
{
    public class Auto
    {
       public Auto(string marca, string modelo, int anno) { 
        this.Marca = marca;
        this.Modelo = modelo; 
        this.Anno = anno;
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anno { get; set; }
    }
}
