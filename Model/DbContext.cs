﻿using System;
using System.Linq;
using SqlSugar;

namespace CopyTest.Model
{
    public class DbContext
    {
        //注意：不能写成静态的，不能写成静态的
        public SqlSugarClient Db; //用来处理事务多表查询和复杂的操作

        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig
            {
                 ConnectionString = "server=10.55.22.34;uid=root;pwd=merryte;database=test",
                // ConnectionString = "server=localhost;uid=root;pwd=woshishui;database=test",
                DbType = DbType.MySql,
                InitKeyType = InitKeyType.Attribute, //从特性读取主键和自增列信息
                IsAutoCloseConnection = true //开启自动释放模式和EF原理一样我就不多解释了
            });
            //调式代码 用来打印SQL 
            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine(sql + "\r\n" + Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
                Console.WriteLine();
            };
        }

        public SimpleClient<uploading> uploadingdb => new SimpleClient<uploading>(Db); //用来处理Student表的常用操作
    }
}