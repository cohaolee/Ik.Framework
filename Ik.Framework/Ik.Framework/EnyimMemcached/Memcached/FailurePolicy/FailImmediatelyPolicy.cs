﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IkCaching.Memcached
{
	/// <summary>
	/// Fails a node immediately when an error occures. This is the default policy.
	/// </summary>
	public sealed class FailImmediatelyPolicy : INodeFailurePolicy
	{
		bool INodeFailurePolicy.ShouldFail()
		{
			return true;
		}
	}

	/// <summary>
	/// Creates instances of <see cref="T:FailImmediatelyPolicy"/>.
	/// </summary>
	public class FailImmediatelyPolicyFactory : INodeFailurePolicyFactory
	{
		private static readonly INodeFailurePolicy PolicyInstance = new FailImmediatelyPolicy();

		INodeFailurePolicy INodeFailurePolicyFactory.Create(IMemcachedNode node)
		{
			return PolicyInstance;
		}
	}
}

#region [ License information          ]
/* ************************************************************
 * 
 *    Copyright (c) 2011 Attila Kiskó, enyim.com
 *    
 *    Licensed under the Apache License, Version 2.0 (the "License");
 *    you may not use this file except in compliance with the License.
 *    You may obtain a copy of the License at
 *    
 *        http://www.apache.org/licenses/LICENSE-2.0
 *    
 *    Unless required by applicable law or agreed to in writing, software
 *    distributed under the License is distributed on an "AS IS" BASIS,
 *    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *    See the License for the specific language governing permissions and
 *    limitations under the License.
 *    
 * ************************************************************/
#endregion
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
