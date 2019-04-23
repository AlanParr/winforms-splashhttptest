using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy.Hosting.Self;

namespace WinForms_SplashHttpTest
{
    public class SplashNancyHost
    {
        private static NancyHost _host;
        public string Url { get; private set; } = @"http://127.0.0.1:1702";

        public SplashNancyHost()
        {
        }

        public void Start()
        {
            var opts = new HostConfiguration
            {
                UrlReservations = { CreateAutomatically = true },
                EnableClientCertificates = true,
                RewriteLocalhost = false
            };

            _host = new NancyHost(opts, new Uri(Url));
            _host.Start();
        }

        public void Stop() => _host.Stop();
    }
}
