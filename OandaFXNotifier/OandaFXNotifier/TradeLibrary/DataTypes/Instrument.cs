using System;

namespace OandaRest.TradeLibrary.DataTypes
{
	public class IsOptionalAttribute : Attribute
	{
		public override string ToString()
		{
			return "Is Optional";
		}
	}

	public class MaxValueAttribute : Attribute
	{
		public object value { get; set; }
		public MaxValueAttribute(int i)
		{
			value = i;
		}
	}

	public class MinValueAttribute : Attribute
	{
		public object value { get; set; }
		public MinValueAttribute(int i)
		{
			value = i;
		}
	}

	public class Instrument
    {
		public bool hasInstrument;
	    private string _instrument;
        public string instrument 
		{
			get { return _instrument; }
			set 
			{ 
				_instrument = value;
				hasInstrument = true;
			}
		}

		public bool hasDisplayName;
		private string _displayName;
		public string displayName
		{
			get { return _displayName; }
			set
			{
				_displayName = value;
				hasDisplayName = true;
			}
		}

		public bool hasPip;
		private string _pip;
		public string pip
		{
			get { return _pip; }
			set
			{
				_pip = value;
				hasPip = true;
			}
		}

		[IsOptional]
		public bool hasPipLocation;
		private int _pipLocation;
		public int pipLocation
		{
			get { return _pipLocation; }
			set
			{
				_pipLocation = value;
				hasPipLocation = true;
			}
		}

		[IsOptional]
		public bool hasExtraPrecision;
		private int _extraPrecision;
		public int extraPrecision
		{
			get { return _extraPrecision; }
			set
			{
				_extraPrecision = value;
				hasExtraPrecision = true;
			}
		}

		public bool hasMaxTradeUnits;
		private int _maxTradeUnits;
		public int maxTradeUnits
		{
			get { return _maxTradeUnits; }
			set
			{
				_maxTradeUnits = value;
				hasMaxTradeUnits = true;
			}
		}
    }
}
