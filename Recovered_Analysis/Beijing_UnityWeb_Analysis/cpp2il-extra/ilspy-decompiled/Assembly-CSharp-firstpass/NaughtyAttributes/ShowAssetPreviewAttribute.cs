using Cpp2ILInjected;

namespace NaughtyAttributes;

public class ShowAssetPreviewAttribute : DrawerAttribute
{
	private int width;

	private int height;

	public int Width => width;

	public int Height => width;

	public unsafe ShowAssetPreviewAttribute(int width = 64, int height = 64)
	{
		//IL_000d: Expected Obj, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected Obj, but got Unknown
		//IL_0035: Expected Obj, but got I4
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		object obj = ((int*)width)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [width @ L1 (System.Int32)+8]");
		_ = 0;
		object obj2 = obj + 16;
		obj2 = ((int*)height)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [height @ L2 (System.Int32)+8]");
		_ = 0;
		object obj3 = this + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1176B");
	}
}
