using Newtonsoft.Json;
using ServicoUnica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace apiConsultaUnica
{
    public class CoreMethods
    {
        public static string GetValuesWithoutParams()
        {
            RequestManager manager = new RequestManager();

            string uri = "https://vendas.unica-facil.com.br/VendaWeb/busca";
            string uri2 = "https://vendas.unica-facil.com.br/VendaWeb/consulta/idaJson/0";
            string content = "origem=PETROPOLIS&destino=CASTELO&dataInicial=24%2F06%2F2019&dataFinal=&submit.x=54&submit.y=16&idioma=pt";

            manager.SendPOSTRequest(1, uri, content, "", "", false);

            return manager.GetResponseContent(manager.SendPOSTRequest(1, uri2, content, "", "", false));
        }

    }
}
