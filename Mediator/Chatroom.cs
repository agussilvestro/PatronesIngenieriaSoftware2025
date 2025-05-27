using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Chat
{
    public class Chatroom : Chat
    {
        IDictionary<string, Usuario> _participantes;
      
        public Chatroom()
        {
            _participantes = new Dictionary<string, Usuario>(); 
        }

        public override void Enviar(string _mensaje, Usuario _para, Usuario _de)
        {
            Mensaje msg = new Mensaje();
            msg.De = _de;
            msg.Para = _para;
            msg.Texto = _mensaje;

            if (_participantes.ContainsKey(_para.Nombre))
            {
                _participantes[_para.Nombre].Recibir(msg);
                _mensajes.Add(msg);
            }
        }

        public override void Registrar(Usuario _usuario)
        {
            if (!_participantes.ContainsKey(_usuario.Nombre))
            {
                _participantes.Add(_usuario.Nombre, _usuario);
            }
        }
    }
}
