using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ricco.DomainModel
{
    public class Usuario : EntityBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public byte[] SenhaHash { get; set; }
        public byte[] SenhaSalt { get; set; }


        public void GerarHashSalt()
        {
            using (var hmc = new HMACSHA512())
            {
                SenhaSalt = hmc.Key;
                SenhaHash = hmc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Senha));
            };
        }

        public void ValidarSenha()
        {
            using (var hmc = new HMACSHA512(SenhaSalt))
            {
                var computedHash = hmc.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Senha));
                if (!computedHash.SequenceEqual(SenhaHash))
                    throw new ApplicationException("Usuário ou Senha Inválido!");
            };
        }
    }

    public interface IUsuarioRepository : IRepositoryBase<Usuario> { }
}
