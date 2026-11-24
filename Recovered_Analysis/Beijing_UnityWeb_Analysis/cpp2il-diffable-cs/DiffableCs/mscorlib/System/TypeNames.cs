namespace System;

internal class TypeNames
{
	internal abstract class ATypeName : TypeName, IEquatable<TypeName>
	{

		public abstract string DisplayName
		{
			 get { } //Length: 0
		}

		protected ATypeName() { }

		public bool Equals(TypeName other) { }

		public override bool Equals(object other) { }

		public abstract string get_DisplayName() { }

		public override int GetHashCode() { }

	}


}

