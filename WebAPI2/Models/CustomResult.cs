using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebAPI2.Models
{
    public class CustomResult : IHttpActionResult
    {
        string _val;
        HttpRequestMessage _req;
        HttpStatusCode _code;
        public CustomResult(string val, HttpRequestMessage req, HttpStatusCode code)
        {
            _val = val;
            _req = req;
            _code = code;
        }
        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = new HttpResponseMessage()
            {
                Content = new StringContent(_val),
                RequestMessage = _req,
                StatusCode = _code
            };
            return Task.FromResult(response);
        }
    }
}