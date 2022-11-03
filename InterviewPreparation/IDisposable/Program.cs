using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;

namespace InterviewPreparation.IDisposable
{
    #region IDisposable

    // Dispose is a method of IDisposeable Interface.
    // Inside this method developer has to write the code to  clean or destroy the objects which are no more required.
    // Finalize is called by Garbage collector automatically and cannot be called by user code.
    // There is no performance cost associated with Dispose method, as the developers know when the objects will be created and where to cleqan up them.
    // There is performance cost associated withe the finalize method.For example, GC is running in every 10 mins but there is no objects for cleaning
    // in the application then it jsut wasting the memory whcih it using for running.

    /*
     
    static class Program
    {
        static void Main(string[] args)
        {
            using var serviceProxy = new ServiceProxy(null);
            serviceProxy.Get();
            serviceProxy.Post("");
            Console.ReadLine();
        }
    }
    public class ServiceProxy : System.IDisposable
    {
        private readonly HttpClient httpClient;
        private bool disposed;

        public ServiceProxy(IHttpClientFactory httpClientFactory)
        {
            httpClient = httpClientFactory.CreateClient();
        }
        ~ServiceProxy()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed objects
                httpClient.Dispose();
            }
            // Dispose unmanaged objects
            disposed = true;
        }
        public void Get()
        {
            var response = httpClient.GetAsync("");
        }
        public void Post(string request)
        {
            var response = httpClient.PostAsync("", new StringContent(request));
        }
    }
    
    */

    #endregion
}
