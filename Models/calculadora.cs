namespace GeoApp.Models
{
    public static class Calculadora
    {
        public static double AreaRectangulo(double baseR, double altura) => baseR * altura;
        public static double AreaCirculo(double radio) => Math.PI * Math.Pow(radio, 2);
        public static double AreaTriangulo(double baseT, double altura) => (baseT * altura) / 2;
    }
}
