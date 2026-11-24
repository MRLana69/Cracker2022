using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Kiloo;

public class ResetValuesOnDisable : MonoBehaviour
{
	private SpaceType _positionSpaceType;

	private SpaceType _rotationSpaceType;

	private IValueResetter<Transform>[] _valueResetters;

	private void Start()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_009e: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(CompressionExtensions);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.CompressionExtensions>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(CompressionExtensions);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Kiloo.CompressionExtensions>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string msg = string.ConcatArray((string[])(object)CompressionExtensions.DEBUG_TAG, (int)this);
		SDebug.LogFormat(msg, null);
	}

	private void InitValueResetters()
	{
		OnDisable();
		CreateValueResetters();
	}

	private void CreateValueResetters()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj = _valueResetters + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _valueResetters + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}

	private void OnDisable()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = _positionSpaceType;
		throw new ArrayTypeMismatchException();
	}

	private void ResetValues()
	{
		this._002Ector();
	}

	public ResetValuesOnDisable()
	{
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_007e: Expected Obj, but got I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		object obj = _valueResetters + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = _valueResetters + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			GameObject gameObject = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
	}
}
