using System.IO;

namespace Kiloo.Common.Utility;

public interface IBsonSerializer
{
	void ToBson(object value, BinaryWriter writer);

	T FromBson<T>(BinaryReader reader);
}
