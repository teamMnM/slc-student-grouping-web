﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace SlcClient.Services
{
    interface ISlcService<T>
    {       
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(string id);

        Task<HttpResponseMessage> Create(T obj);

        Task<HttpStatusCode> Update(T obj);

        Task<HttpStatusCode> DeleteById(string id);
    }
}
