using SqlSugar;

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
        public string filepath { get; set; }

        /// <summary>
        /// 需要压缩的文件夹
        /// </summary>
        public string foldertozip { get; set; }

        /// <summary>
        /// 压缩后的Zip完整文件名
        /// </summary>
        public string zipedfilename { get; set; }

        public string zipedfilename2 { get; set; }

        public string localitypath { get; set; }
    }
}