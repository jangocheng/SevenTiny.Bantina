﻿/*********************************************************
 * CopyRight: 7TINY CODE BUILDER. 
 * Version: 5.0.0
 * Author: 7tiny
 * Address: Earth
 * Create: 2018-02-15 23:04:25
 * Modify: 2018-02-15 23:04:25
 * E-mail: dong@7tiny.com | sevenTiny@foxmail.com 
 * GitHub: https://github.com/sevenTiny 
 * Personal web site: http://www.7tiny.com 
 * Technical WebSit: http://www.cnblogs.com/7tiny/ 
 * Description: 
 * Thx , Best Regards ~
 *********************************************************/
using SevenTiny.Bantina.Configuration;
using SevenTiny.Bantina.Extensions;
using System.Collections.Generic;

namespace SevenTiny.Bantina.Internationalization.Configs
{
    [ConfigClass(Name = "Internationalization_English")]
    public class Internationalization_English_Config : ConfigBase<Internationalization_English_Config>
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }

        private static Dictionary<int, Internationalization_English_Config> dictionary;

        private static void Initial()
        {
            dictionary = new Dictionary<int, Internationalization_English_Config>();
            foreach (var item in Configs)
            {
                dictionary.AddOrUpdate(item.ID, item);
            }
        }
        public static Internationalization_English_Config Get(int id)
        {
            if (dictionary != null && dictionary.ContainsKey(id))
            {
                return dictionary[id];
            }
            Initial();
            return dictionary.SafeGet(id);
        }
    }
}
