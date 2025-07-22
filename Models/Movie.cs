using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMovies.Models;

[Table("Movie")] // <--- nombre de la tabla
public class Movie
{
    [Key] // <--- llave primaria
    [Column("Id")] // <--- nombre de la columna, se puede omitir si en la tabla se llama igual que en la variable
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public int? GenreId { get; set; }
    public Genre Genre { get; set; } = new();

    [DataType(DataType.Currency)] // <--- para que se muestre en diferentes formatos
    [Column(TypeName = "decimal(18, 2)")] // <--- en caso de tener que definir el tipo de columna
    public decimal Price { get; set; }
}