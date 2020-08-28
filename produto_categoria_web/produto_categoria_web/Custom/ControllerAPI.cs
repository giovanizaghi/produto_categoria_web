using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using produto_categoria_web.ServiceAPI;
using System;

namespace produt_categoria_web.Custom
{
    public class ControllerAPI : Controller
    {
        protected ConnectionAPI API;

        public ControllerAPI(ConnectionAPI api)
        {
            API = api;
        }

        public void SetSession(SessionKeys key, object value)
        {
            HttpContext.Session.SetString(key.ToString(), JsonConvert.SerializeObject(value));
        }

        public M GetSession<M>(SessionKeys key)
        {
            string value = HttpContext.Session.GetString(key.ToString());
            if (value == null)
                return default(M);
            else
                return JsonConvert.DeserializeObject<M>(value);
        }

        public void DeleteAllSessionData()
        {
            HttpContext.Session.Clear();
        }
    }

    public enum SessionKeys
    {
        IdProposta,
        IdCliente,
        ConsigCliente,
        CPF
    }
}
