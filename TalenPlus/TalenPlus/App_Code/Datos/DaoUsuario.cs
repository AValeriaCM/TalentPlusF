using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Data.Entity;

public class DaoUsuario
{
    public void InsertarUsuario(EDatos usuario)
    {
        using (var db = new Mapeo())
        {
            db.usuario.Add(usuario);
            db.SaveChanges();
        }
    }

    public EDatos verificarCorreo(EDatos verificar)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Correo.Equals(verificar.Correo) || x.Username.Equals(verificar.Username)).FirstOrDefault();
        }
    }

    public EDatos login(EDatos usuario)
    {
        using (var db = new Mapeo())
        {
            //comparo lo que traigo del login con los valores existentes en la base de datos
            return db.usuario.Where(x => x.Username.Contains(usuario.Username) && x.Password.Equals(usuario.Password)).FirstOrDefault();
        }
    }

    public EDatos usuarioSesion(string _usuario)
    {
        using (var db = new Mapeo())
        {
            EDatos usuario = db.usuario.Where(x => x.Username.Contains(_usuario)).FirstOrDefault();
            if (usuario == null)
            {
                return null;
            }
            else
            {
                return usuario;
            }
        }
    }

    public void actualizarDatos(EDatos actualizar)
    {
        using (var db = new Mapeo())
        {
            var ctx = db.usuario.SingleOrDefault(s => s.Id == 1);
            if (ctx != null) {
                ctx.Nombre = actualizar.Nombre;
                ctx.Apellido = actualizar.Apellido;
                ctx.Correo = actualizar.Correo;
                ctx.Username = actualizar.Username;
                ctx.Password = actualizar.Password;

                db.usuario.Attach(ctx);
                var entry = db.Entry(ctx);
                entry.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }

    public Boolean eliminarUsuario(string usuario)
    {
        using (var db = new Mapeo())
        {
            var user = db.usuario.FirstOrDefault(s => s.Username == usuario);
            if (user != null)
            {
                var videos = (from v in db.video where v.Id_usuario == user.Id select v).ToList();

                foreach(var video in videos)
                {
                    db.video.Remove(video);
                    db.SaveChanges();
                }

                db.usuario.Remove(user);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    public void insertarVideo(EVideo video)
    {
        using (var db = new Mapeo())
        {
            db.video.Add(video);
            db.SaveChanges();
        }
    }

}
