﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ik.Framework.Events
{
    public class DistributedEventConsumer
    {
        public DistributedEventConsumer(HandleType handleType, object consumer)
        {
            this.Consumer = consumer;
            this.HandleType = handleType;
        }

        public HandleType HandleType { private set; get; }

        public object Consumer { get; private set; }

		public IConsumer<T> GetConsumer<T>()
		{
			return (IConsumer<T>)this.Consumer;
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
