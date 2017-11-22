using System;

namespace Xamarin.Forms.StyleSheets
{
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true, Inherited = true)]
	public sealed class StylePropertyAttribute : Attribute
	{
		public string CssPropertyName { get; }
		public string BindablePropertyName { get; }
		public Type TargetType { get; }
		public BindableProperty BindableProperty { get; set; }


		public StylePropertyAttribute(string cssPropertyName, Type targetType, string bindablePropertyName)
		{
			CssPropertyName = cssPropertyName;
			BindablePropertyName = bindablePropertyName;
			TargetType = targetType;
		}
	}
}