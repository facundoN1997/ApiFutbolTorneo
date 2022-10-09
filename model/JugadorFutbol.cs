using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace apiFutbol.model
{
    [Index(nameof(dni), IsUnique = true)]
    public class jugadorFutbol
    {

        [Key]
        public int id { get; set; }
        [RegularExpression("^[1-9]{1}[0-9]{7}$",
            ErrorMessage = "Ingresar DNI sin puntos")]
        public int dni { get; set; }
        [RegularExpression("^[a-zA-Z]{1,25}$",
           ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres sin espacios")]
        public string? nombre { get; set; }
        [RegularExpression("^[a-zA-Z]{1,25}$",
           ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres sin espacios")]
        public string? apellido { get; set; }
        [RegularExpression("^[a-zA-Z ]{1,25}$",
           ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres")]
        public string? equipoJugando { get; set; }

    }
}
