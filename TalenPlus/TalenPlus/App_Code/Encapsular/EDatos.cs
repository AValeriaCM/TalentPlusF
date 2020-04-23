using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


[Serializable]
[Table("usuarios", Schema = "usuario")]
public class EDatos
{
    private int id;
    private String nombre;
    private String apellido;
    private String correo;
    private String username;
    private String password;


    [Key]
    [Column("id_user")]
    public int Id { get => id; set => id = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("apellido")]
    public string Apellido { get => apellido; set => apellido = value; }
    [Column("correo")]
    public string Correo { get => correo; set => correo = value; }
    [Column("username")]
    public string Username { get => username; set => username = value; }
    [Column("pass")]
    public string Password { get => password; set => password = value; }
    
}