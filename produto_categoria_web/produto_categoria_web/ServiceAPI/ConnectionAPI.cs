using Dominio.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace produto_categoria_web.ServiceAPI
{
    public class ConnectionAPI
    {
        public async Task<MM> GetTokenAsync<MM>(string url, string route, Method methodHttp, object sendObject = null, Dictionary<string, string> headers = null) where MM : new()
        {
            try
            {
                RestClient client;
                RestRequest request;
                IRestResponse response;

                client = new RestClient($"{url}/{route}");
                request = new RestRequest(methodHttp);
                request.RequestFormat = DataFormat.Json;

                if (sendObject != null)
                    request.AddJsonBody(sendObject);

                request.AddHeader("Content-Type", "application/json");

                if (headers != null)
                    foreach (var header in headers)
                    {
                        request.AddHeader(header.Key, header.Value);
                    }

                response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<MM>(response.Content);
                }
                else
                {
                    return new MM();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Result> ExecuteAsync(string url, string route, Method methodHttp, object sendObject = null, Dictionary<string, string> headers = null)
        {
            try
            {
                RestClient client;
                RestRequest request;
                IRestResponse response;

                client = new RestClient($"{url}/{route}");
                request = new RestRequest(methodHttp);
                request.RequestFormat = DataFormat.Json;

                //*****************************

                if (sendObject != null)
                    request.AddJsonBody(sendObject);

                request.AddHeader("Content-Type", "application/json");

                if (headers != null)
                    foreach (var header in headers)
                    {
                        request.AddHeader(header.Key, header.Value);
                    }

                response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Result result = new Result();
                    result.Success = true;
                    result.Json = response.Content;
                    result.Errors = null;
                    result.Message = null;

                    return result;
                }
                else if (response.StatusCode == 0)
                {
                    Result result = new Result();
                    result.Success = false;
                    result.Json = null;
                    result.Errors = null;
                    result.Message = "Falha na conexão com a API. Contate o suporte do site!";

                    return result;
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    Result result = new Result();
                    result.Success = false;
                    result.Json = null;
                    result.Errors = null;
                    result.Message = response.Content.Replace("\"", "");

                    return result;
                }
                else if (response.StatusCode == HttpStatusCode.UnprocessableEntity)
                {
                    Result result = new Result();
                    result.Success = false;
                    result.Json = null;
                    result.Message = null;
                    result.Errors = JsonConvert.DeserializeObject<List<Error>>(response.Content);

                    return result;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    Result result = new Result();
                    result.Success = false;
                    result.Json = null;
                    result.Message = "Url ou caminho de método da API não encontrado!";
                    result.Errors = null;

                    return result;
                }
                else
                {
                    Result result = new Result();
                    result.Success = false;
                    result.Json = null;
                    result.Message = response.Content;
                    result.Errors = null;

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}