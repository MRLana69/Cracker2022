namespace System;

internal class TypeIdentifiers
{
	private class Display : ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName>
	{
		private string displayName; //Field offset: 0x8
		private string internal_name; //Field offset: 0xC

		public override string DisplayName
		{
			 get { } //Length: 71
		}

		public string InternalName
		{
			 get { } //Length: 6
		}

		internal Display(string displayName) { }

		public override string get_DisplayName() { }

		public string get_InternalName() { }

		private string GetInternalName() { }

	}


	internal static TypeIdentifier FromDisplay(string displayName) { }

}

