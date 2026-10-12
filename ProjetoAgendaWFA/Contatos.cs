using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda_contatos_
{
    internal class Contatos
    {
        private readonly List<Contato> agenda;

        public Contatos()
        {
            agenda = new List<Contato>();
        }


        public List<Contato> listar()
        {
            return new List<Contato>(agenda);
        }


        public bool adicionar(Contato c)
        {
            foreach (Contato contato in agenda)
            {
                if (contato.Equals(c))
                {
                    return false;
                }
            }

            agenda.Add(c);
            return true;
        }

        public Contato pesquisar(Contato c)
        {
            return agenda.Find(contato => contato.Equals(c));
        }


        public bool alterar(string emailOriginal, Contato atualizado)
        {
            int indice = agenda.FindIndex(c =>
                string.Equals(
                    c.Email,
                    emailOriginal,
                    StringComparison.OrdinalIgnoreCase));

            if (indice == -1)
                return false;

            bool emailDuplicado = agenda.Any(c =>
                !string.Equals(
                    c.Email,
                    emailOriginal,
                    StringComparison.OrdinalIgnoreCase) &&
                string.Equals(
                    c.Email,
                    atualizado.Email,
                    StringComparison.OrdinalIgnoreCase));

            if (emailDuplicado)
                return false;

            agenda[indice] = atualizado;
            return true;
        }


        public bool remover(Contato c)
        {
            Contato encontrado = agenda.Find(contato => contato.Equals(c));

            if (encontrado == null)
            {
                return false;
            }

            agenda.Remove(encontrado);
            return true;
        }

    }
}
