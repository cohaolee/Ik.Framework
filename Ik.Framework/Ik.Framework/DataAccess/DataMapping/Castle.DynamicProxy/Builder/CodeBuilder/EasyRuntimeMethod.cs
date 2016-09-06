// Copyright 2004-2007 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace IBatisNet.CastleDynamicProxy.Builder.CodeBuilder
{
	using System;
	using System.Reflection;

	using IBatisNet.CastleDynamicProxy.Builder.CodeBuilder.SimpleAST;
	using IBatisNet.CastleDynamicProxy.Builder.CodeBuilder.Utils;

	/// <summary>
	/// Summary description for EasyRuntimeMethod.
	/// </summary>
	
	public class EasyRuntimeMethod : EasyMethod
	{
		public EasyRuntimeMethod(AbstractEasyType maintype, string name, 
			ReturnReferenceExpression returnRef, ArgumentReference[] arguments)
		{
			MethodAttributes atts = MethodAttributes.HideBySig|MethodAttributes.Public|MethodAttributes.Virtual;
			Type[] args = ArgumentsUtil.InitializeAndConvert( arguments );

			_builder = maintype.TypeBuilder.DefineMethod(
				name, atts, returnRef.Type, args);
			_builder.SetImplementationFlags(
				MethodImplAttributes.Runtime|MethodImplAttributes.Managed);
		}

		public override void Generate()
		{
			
		}

		public override void EnsureValidCodeBlock()
		{
			
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
