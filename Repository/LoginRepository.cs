using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbandoLogin.Repository
{
    public class LoginRepository
    {
        public Models.usuario ingresar(Models.usuario usuario)
        {
            try
            {
                Models.nutricloudEntities context = new Models.nutricloudEntities();

                Models.usuario usu = (from u in context.usuario
                                      where u.usuario1 == usuario.usuario1
                                      && u.clave == usuario.clave
                                      select u).FirstOrDefault<Models.usuario>();
                
                return usu;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
