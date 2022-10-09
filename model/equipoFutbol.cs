using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace apiFutbol.model
{
    [Index(nameof(nombre), IsUnique = true)]
    public class EquipoFutbol
    {
        //DEFINO CAMPOS Y AGREGO SUS VALIDACIONES
        [Key]
        public int id { get; set; }
        [RegularExpression("^[a-zA-Z][a-zA-Z ]{3,25}$",
            ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres")]
        public string? nombre { get; set; }
        [RegularExpression("^[a-zA-Z][a-zA-Z ]{3,25}$",
            ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres")]
        public string? color { get; set; }
    }
}
