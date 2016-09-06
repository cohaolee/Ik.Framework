﻿// Copyright 2004-2011 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.f
// See the License for the specific language governing permissions and
// limitations under the License.

#if !SILVERLIGHT // Until support for other platforms is verified
namespace IkCastle.Components.DictionaryAdapter.Xml
{
	using System;

	[Flags]
	public enum CursorFlags
	{
		None       = 0,
		Elements   = 1,
		Attributes = 2,
		Multiple   = 4,
		Mutable    = 8,
		AllNodes   = Elements | Attributes
	}

	public static class CursorFlagsExtensions
	{
		public static CursorFlags MutableIf(this CursorFlags flags, bool mutable)
		{
			return mutable ? (flags | CursorFlags.Mutable) : flags;
		}

		public static bool IncludesElements(this CursorFlags flags)
		{
			return 0 != (flags & CursorFlags.Elements);
		}

		public static bool IncludesAttributes(this CursorFlags flags)
		{
			return 0 != (flags & CursorFlags.Attributes);
		}

		public static bool AllowsMultipleItems(this CursorFlags flags)
		{
			return 0 != (flags & CursorFlags.Multiple);
		}

		public static bool SupportsMutation(this CursorFlags flags)
		{
			return 0 != (flags & CursorFlags.Mutable);
		}
	}
}
#endif

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
