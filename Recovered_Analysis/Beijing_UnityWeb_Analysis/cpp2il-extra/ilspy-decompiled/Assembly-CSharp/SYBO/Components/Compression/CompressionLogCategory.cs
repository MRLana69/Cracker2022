using System.Security.Cryptography;
using Cpp2ILInjected;
using SYBO.Components.ComponentsManager;
using SYBO.Components.Crypt;
using SYBO.Components.Logging;

namespace SYBO.Components.Compression;

public class CompressionLogCategory : LogCategory
{
	public CompressionLogCategory(int categoryId)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		AesManaged aesManaged = default;
		aesManaged.GenerateIV();
		object obj = this + 8;
		obj = aesManaged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
	}

	public override string[] GetCallstackPrefixes()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ComponentsManagerSettings componentsManagerSettings = default;
		componentsManagerSettings._002Ector();
		((SimpleAES)(object)componentsManagerSettings)._002Ector((byte[])(object)this);
		return (string[])(object)componentsManagerSettings;
	}
}
