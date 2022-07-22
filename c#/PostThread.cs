using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Http;
using System.Net;
using System.Collections.Specialized;

namespace Perf_monitor
{
    
    class PostThread
    {
        public void sadasd()
        {
            using (var wb = new WebClient())
            {
                var data = new NameValueCollection();
                data["username"] = "myUser";
                data["password"] = "myPassword";

                var response = wb.UploadValues("http:\\localhost:3000", "POST", data);
                string responseInString = Encoding.UTF8.GetString(response);
            }
        }
    }
}
