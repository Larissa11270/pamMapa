using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Azure.Core;
using MapaPam.Models;

namespace MapaPam.Services
{
    public class UsuarioService
    {
        private Request _request;
        private string _apiUrlBase = "";

        public UsuarioService()
        {
            _request = new Request();
        }

        private string _token;
        public UsuarioService(string token)
        {
            _request = new Request();
            _token = token;
           
        }

        public async Task<int> PutAtualizarLocalizacaoAsync(Usuarios u)
        {
            string urlComplementar = "/AtualizarLocalizacao";
            var result = await _request.PutAsync(_apiUrlBase + urlComplementar, u, _token);
            return result;
        }

        public async Task<ObservableCollection<Usuarios>> GetUsuariosAsync()
        {
            string urlComplementar = string.Format("{0}", "/ GetAll");
            ObservableCollection<Models.Usuarios> listaUsuarios = await 
                _request.GetAsync<ObservableCollection<Models.Usuarios>>(_apiUrlBase + urlComplementar, _token);
            return listaUsuarios;
        }
    }
}
