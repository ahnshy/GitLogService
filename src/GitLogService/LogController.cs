﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GitLogService
{
    public class LogController : ApiController
    {
        public IEnumerable<string> Get()
        {
            GitLogManager manager = new GitLogManager();
            Dictionary<string, int> logList = new Dictionary<string, int>();
            manager.GetLog(ref logList);

            return logList.Select(item => $"{item.Key}:{item.Value}");
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values 
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }

        // GET api/values 
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
    }
}
