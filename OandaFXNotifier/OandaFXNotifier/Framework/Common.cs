using System;
using System.Reflection;

namespace OandaRest.Framework
{
	public class Common
	{
		public static object getDefault(Type t)
		{
			return typeof(Common).GetTypeInfo().GetDeclaredMethod("getDefaultGeneric").MakeGenericMethod(t).Invoke(null, null);
		}

		public static T getDefaultGeneric<T>()
		{
			return default(T);
		}
	}
}
