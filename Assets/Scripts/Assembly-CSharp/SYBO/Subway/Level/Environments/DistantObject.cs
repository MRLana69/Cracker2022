using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

namespace SYBO.Subway.Level.Environments;

public class DistantObject : MonoBehaviour
{
	private const int BaseRenderQueueOffset = 10;

	private Vector3 _trueSpawnPosition;

	private float _projectionFactor;

	public unsafe void Initialize(Vector3 trueSpawnPosition, float projectionFactor)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_001d: Expected VT, but got F4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected VT, but got Unknown
		//IL_00d7: Expected I, but got Obj
		//IL_0145: Expected F4, but got I
		//IL_0140: Expected native int or pointer, but got VT
		//IL_0164: Expected F4, but got I
		//IL_015f: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 80);
		_trueSpawnPosition = (Vector3)trueSpawnPosition.x;
		_ = trueSpawnPosition.z;
		float projectionFactor2 = 1f / projectionFactor;
		_projectionFactor = projectionFactor2;
		Camera main = Camera.main;
		Transform transform = main.transform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
		_ = 0;
		Vector3 camPos = vector + 16;
		UpdateDistantObject(camPos);
		Transform transform2 = base.transform;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		float num3 = (float)Vector3.oneVector * _projectionFactor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+10]");
		float num4 = 0f * _projectionFactor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v21 (Il2CppStaticFields<UnityEngine.Vector3>)+14]");
		float num5 = 0f * _projectionFactor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
		((Vector3*)(nint)vector)->x = 0f;
		transform2.localScale = vector;
	}

	private void OnEnable()
	{
		//IL_000f: Expected VT, but got Obj
		//IL_0019: Expected Obj, but got VT
		_00210 val = (_00210)Singleton<>.Instance;
		((DistantEnvironmentController)val).RegisterDistantObject(this);
	}

	private void OnDisable()
	{
		//IL_000f: Expected VT, but got Obj
		//IL_0019: Expected Obj, but got VT
		_00210 val = (_00210)Singleton<>.Instance;
		((DistantEnvironmentController)val).DeregisterDistantObject(this);
	}

	public unsafe void UpdateDistantObject(Vector3 camPos)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_010f: Expected F4, but got I
		//IL_010a: Expected native int or pointer, but got VT
		//IL_0136: Expected F4, but got I
		//IL_0131: Expected native int or pointer, but got VT
		//IL_0085: Expected F4, but got I
		//IL_008f: Expected F4, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		float num = (float)_trueSpawnPosition - camPos.x;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.DistantObject)+14]");
		float num2 = 0f - camPos.z;
		if (!(_projectionFactor > 0f))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.DistantObject)+14]");
			float num3 = 0f;
			float num4 = (float)_trueSpawnPosition;
		}
		else
		{
			float num5 = num * _projectionFactor;
			float num6 = camPos.x + num5;
			float num7 = num2 * _projectionFactor;
			float num3 = camPos.z + num7;
			float num4 = num6;
		}
		Transform transform = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.Environments.DistantObject)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.position = vector;
	}

	public DistantObject()
	{
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		_trueSpawnPosition = Vector3.zeroVector;
		base._002Ector();
	}
}
