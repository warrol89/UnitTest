using System;

namespace sampleapi.service
{
    public class Service
    {
        public string TestMethod(int id)
        {
            if(id ==1)
            return "success";

            return "fail";
        }
    }
}
