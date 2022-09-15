namespace Dictionary
{
    internal class Producto
    {
        int codigoId;
        string nombreProducto;
        float precio;

        public Producto(int codigoId, string nombreProducto, float precio)
        {
            this.codigoId = codigoId;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
        }

    }
}