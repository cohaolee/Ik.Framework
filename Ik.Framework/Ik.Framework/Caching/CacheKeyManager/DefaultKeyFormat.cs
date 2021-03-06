﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Framework.Caching.CacheKeyManager
{
    public class DefaultKeyFormat : ICacheKeyFormat
    {
        private static ICacheKeyFormat _defaultKeyFormart = null;
        private KeyConfigFormatObjcet _configFormatObjcet = null;

        public DefaultKeyFormat(KeyConfigFormatObjcet configFormatObjcet)
        {
            this._configFormatObjcet = configFormatObjcet;
        }

        public static ICacheKeyFormat Instance
        {
            get
            {
                if (_defaultKeyFormart == null)
                {
                    _defaultKeyFormart = new DefaultKeyFormat(KeyConfigManager.GetFormatObjcetDictFromConfig());
                }
                return _defaultKeyFormart;
            }
        }

        public string FormatKey(string key, params object[] values)
        {
            FormatObjcet formatObjcet = null;
            string formatKey = _configFormatObjcet.FormatObjcets.TryGetValue(key, out formatObjcet) ? formatObjcet.FormatKey(values) : null;
            if (string.IsNullOrEmpty(formatKey))
            {
                throw new InkeyException(InkeyErrorCodes.CommonFailure, "未知缓存key:" + key);
            }
            return formatKey;
        }


        public Type GetKeyDefineType(string key)
        {
            FormatObjcet formatObjcet = null;
            if (_configFormatObjcet.FormatObjcets.TryGetValue(key, out formatObjcet))
            {
                return formatObjcet.GetKeyDefineType();
            }
            return null;
        }
    }
}

#region copyright
/*
*.NET基础开发框架
*Copyright (C) 。。。
*地址：git@github.com:gangzaicd/Ik.Framework.git
*作者：到大叔碗里来（大叔）
*QQ：397754531
*eMail：gangzaicd@163.com
*/
#endregion copyright
