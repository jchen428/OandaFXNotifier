using System.Reflection;
using System.Text;

namespace OandaRest.TradeLibrary.DataTypes.Communications.Requests
{
	public interface ISmartProperty
	{
		bool hasValue { get; set; }
		void setValue(object obj);
	}

	// Functionally very similar to System.Nullable, could possibly just replace this
	public struct SmartProperty<T> : ISmartProperty
	{
		private T _value;
		public bool hasValue { get; set; }
		
		public T value
		{
			get { return _value; }
			set
			{
				_value = value;
				hasValue = true;
			}
		}

		public static implicit operator SmartProperty<T>(T value)
		{
			return new SmartProperty<T>() { value = value };
		}

		public static implicit operator T(SmartProperty<T> value)
		{
			return value._value;
		}

		public void setValue(object obj)
		{
			setValue((T)obj);
		}
		public void setValue(T value)
		{
			this.value = value;
		}

		public override string ToString()
		{
			// This is ugly, but c'est la vie for now
			if (_value is bool)
			{	// bool values need to be lower case to be parsed correctly
				return _value.ToString().ToLower();
			}
			return _value.ToString();
		}
	}

	public abstract class Request
	{
		public abstract string endPoint { get; }

		public string getRequestString()
		{
			var result = new StringBuilder();
			result.Append(endPoint);
			bool firstJoin = true;
			foreach (var declaredField in this.GetType().GetTypeInfo().DeclaredFields)
			{
				var prop = declaredField.GetValue(this);
				var smartProp = prop as ISmartProperty;
				if (smartProp != null && smartProp.hasValue)
				{
					if (firstJoin)
					{
						result.Append("?");
						firstJoin = false;
					}
					else
					{
						result.Append("&");
					}

					result.Append(declaredField.Name + "=" + prop);
				}
			}
			return result.ToString();
		}

		public abstract EServer getServer();
	}
}
