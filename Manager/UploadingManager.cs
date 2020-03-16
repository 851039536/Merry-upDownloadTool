using CopyTest.Model;
using System;
using System.Collections.Generic;

namespace CopyTest.Manager
{
    class UploadingManager : DbContext
    {
        public List<uploading> Query()
        {
            try
            {
                List<uploading> data = Db.Queryable<uploading>()
                    .Select(f => new uploading
                    {
                        name = f.name,
                        path = f.path
                    })
                    .ToList();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public List<uploading> GetName(string name)
        {
            List<uploading> data = Db.Queryable<uploading>()
                .Where(w=>w.name== name)
                .Select(f => new uploading
                {
                    path= f.path,
                  localitypath= f.localitypath
                }).ToList();
            return data;

        }
    }
}
