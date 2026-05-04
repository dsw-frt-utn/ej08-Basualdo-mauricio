using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    {
        
            public string CompararCopias(int originalValue, Product product)
            {
                // 1. Copiar valor (tipo valor)
                int copiaValor = originalValue;

                // 2. Incrementar solo la copia
                copiaValor++;

                // 3. Copiar referencia (tipo referencia)
                Product copiaProducto = product;

                // 4. Modificar la descripción
                copiaProducto.SetDescription("Producto Modificado");

                // 5. Retornar resultado
                return $"{originalValue}-{copiaValor}-{product.GetDescription()}";
            }
        
    }
}
