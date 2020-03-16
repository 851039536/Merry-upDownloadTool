using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyTest.Model
{
    [SugarTable("uploading")]
   public class uploading
    {

        //指定主键和自增列，当然数据库中也要设置主键和自增列才会有效
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int id { get; set; }
        public string name { get; set; }
        public string path { get; set; }

        public string localitypath { get; set; }
    }
}
