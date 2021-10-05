using Microsoft.AspNetCore.Hosting;

using System.IO;
using System.Linq;

namespace DockerVolumeTest
{
    public class Model
    {
        IWebHostEnvironment WebHost;

        public Model(IWebHostEnvironment webHost)
        {
            WebHost = webHost;
        }

        void Get()
        {
            string path = Path.Combine(WebHost.WebRootPath, "svmedia");
            var files = Directory.EnumerateFiles(path);
            if (files.Any())
            {
                try
                {

                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
    }


}
