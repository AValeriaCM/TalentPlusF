using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


[Serializable]
[Table("video", Schema = "usuario")]
public class EVideo
{
    private int id;
    private string nombre;
    private string url;
    private int id_usuario;

    [Key]
    [Column("id_video")]
    public int Id { get => id; set => id = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("url")]
    public string Url { get => url; set => url = value; }
    [Column("id_usuario")]
    public int Id_usuario { get => id_usuario; set => id_usuario = value; }
}