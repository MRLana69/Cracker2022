using System;
using Cpp2ILInjected;
using Kiloo.Common.Backend.PurchaseValidation;
using Kiloo.Common.Utility;
using SYBO.Components.Utilities;
using SYBO.Components.Utilities.Validators;
using UnityEngine;

namespace SYBO.Subway.Level.Environments;

public class DistantObject : MonoBehaviour
{
	private const int BaseRenderQueueOffset = 10;

	private Vector3 _trueSpawnPosition;

	private float _projectionFactor;

	public unsafe void Initialize(Vector3 trueSpawnGamePosition, Vector3 cameraGamePosition, float projectionFactor)
	{
		//IL_000d: Expected Obj, but got F4
		//IL_001f: Expected Obj, but got F4
		//IL_0034: Expected Obj, but got I
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected I4, but got Unknown
		//IL_0054: Expected I4, but got F4
		Uri uri = (Uri)trueSpawnGamePosition.x;
		uri.m_String = (string)trueSpawnGamePosition.z;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [trueSpawnGamePosition @ L1 (UnityEngine.Vector3)+10]");
		uri.m_Syntax = (UriParser)0;
		bool flag = (byte)(uri + 24) != 0;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)cameraGamePosition.x != 0;
		_ = cameraGamePosition.z;
		((PurchaseValidationServer)null)._002Ector(uri, (IJsonSerializer)null, flag, projectionFactor);
	}

	private void OnEnable()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj = this + 36;
		object obj2 = default;
		obj = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj3 = this + 40;
		object obj4 = default;
		obj3 = obj4;
		((Validator<>)(object)this)._002Ector();
	}

	private void OnDisable()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected VT, but got Obj
		//IL_00a6: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SingletonMonoBehaviour);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((DistantEnvironmentController)val).DeregisterDistantObject(this);
	}

	public void UpdateDistantObject(Vector3 camemarGamePosition)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
	}

	public DistantObject()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009c: Expected VT, but got Obj
		//IL_00a6: Expected VT, but got Obj
		//IL_00a6: Expected Obj, but got VT
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SingletonMonoBehaviour);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SingletonMonoBehaviour);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<SYBO.Components.Utilities.SingletonMonoBehaviour>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_00210 val = (_00210)SingletonMonoBehaviour<>.Instantiate();
		((DistantObject)val).UpdateDistantObject((Vector3)this);
	}
}
