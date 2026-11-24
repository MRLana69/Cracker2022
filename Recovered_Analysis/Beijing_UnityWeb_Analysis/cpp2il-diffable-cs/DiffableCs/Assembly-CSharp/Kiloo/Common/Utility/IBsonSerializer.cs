namespace Kiloo.Common.Utility;

public interface IBsonSerializer
{

	public T FromBson(BinaryReader reader) { }

	public void ToBson(object value, BinaryWriter writer) { }

}

