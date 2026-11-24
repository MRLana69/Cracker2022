using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Level;

[StructLayout((LayoutKind)0, Size = 12)]
public struct EnvironmentBaseKind
{
	public readonly EnvironmentBaseType Type;

	public readonly EnvironmentBaseShadowSequence ShadowSequence;

	public readonly int NumTracks;

	public static readonly EnvironmentBaseKind None;

	public static readonly EnvironmentBaseKind Empty;

	public static readonly EnvironmentBaseKind Tracks0;

	public static readonly EnvironmentBaseKind Tracks1;

	public static readonly EnvironmentBaseKind Tracks1ShadowStart;

	public static readonly EnvironmentBaseKind Tracks1ShadowMid;

	public static readonly EnvironmentBaseKind Tracks1ShadowEnd;

	public static readonly EnvironmentBaseKind Tracks2;

	public static readonly EnvironmentBaseKind Tracks2ShadowStart;

	public static readonly EnvironmentBaseKind Tracks2ShadowMid;

	public static readonly EnvironmentBaseKind Tracks2ShadowEnd;

	public static readonly EnvironmentBaseKind Tracks3;

	public static readonly EnvironmentBaseKind Tracks3ShadowStart;

	public static readonly EnvironmentBaseKind Tracks3ShadowMid;

	public static readonly EnvironmentBaseKind Tracks3ShadowEnd;

	public static readonly EnvironmentBaseKind Tracks3Gates;

	public static readonly EnvironmentBaseKind Tracks3GatesShadow;

	public static readonly EnvironmentBaseKind Tracks3Special;

	private unsafe EnvironmentBaseKind(EnvironmentBaseType envBaseType, EnvironmentBaseShadowSequence shadowSequence, int numTracks)
	{
		//IL_03b8: Expected Obj, but got Ref
		//IL_03d6: Expected Obj, but got I
		//IL_03e4: Expected I4, but got Obj
		//IL_03e4: Expected Obj, but got Ref
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03fb: Expected Obj, but got I
		//IL_0431: Expected Obj, but got I4
		//IL_0431: Expected Obj, but got I
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected Obj, but got Unknown
		//IL_044c: Expected Obj, but got I4
		//IL_047c: Expected I, but got Obj
		//IL_0492: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_04eb: Expected Obj, but got I4
		//IL_00a3: Expected Obj, but got I
		//IL_0541: Expected Obj, but got I
		//IL_00c3: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I
		//IL_020a: Expected Obj, but got I4
		//IL_01ce: Expected Obj, but got I
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected Obj, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected Obj, but got Unknown
		UnityEngine.Object provider = UnityEngine.Object.Instantiate((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBaseType @ L1 (SYBO.Subway.Level.EnvironmentBaseType)+8]");
		object obj = ((IConvertible)0).ToType((Type)(object)" - ", (IFormatProvider)provider);
		UnityEngine.Object.DestroyImmediate((UnityEngine.Object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this), (byte)(int)obj != 0);
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v7 (Il2CppClass<UnityEngine.Object>)+BA]");
		if ((object)((nint)0 & (nint)0x200) != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S1_v81 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+10]");
		if (((ComputeShader)0).FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+10]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBaseType @ L1 (SYBO.Subway.Level.EnvironmentBaseType)+18]");
			_ = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+14]");
		((Transform)0).parentInternal = (Transform)shadowSequence;
		object obj3 = default;
		Transform transform = (Transform)(obj3 + 16);
		transform = (Transform)((int*)numTracks)->m_value;
		Transform transform2 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [numTracks @ L3 (System.Int32)+8]");
		((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
		Vector3 eulerAngles = transform.eulerAngles;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v19 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S1_v75 (Il2CppClass<UnityEngine.Quaternion>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector2 zero = Vector2.zero;
		transform = (Transform)obj3;
		Transform transform3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
		Vector3 localScale = transform.localScale;
		object obj5 = 0;
		Material material = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+18]");
			object obj6 = 0;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v29+C]");
			if ((nint)obj7 >= 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+18]");
			object obj8 = (nint)0 + (nint)16;
			object obj9 = obj5 << 2;
			object obj10 = obj8 + obj9;
			Renderer renderer = (Renderer)obj10;
			Renderer renderer2 = (Renderer)((obj10 == null) ? null : (((object)renderer.GetType() != typeof(ParticleSystemRenderer)) ? null : obj10));
			if ((object)renderer2 != null)
			{
				Material sharedMaterial = ((Renderer)obj10).sharedMaterial;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBaseType @ L1 (SYBO.Subway.Level.EnvironmentBaseType)+1C]");
				string keyword = (string)((nint)0 + (nint)1001);
				sharedMaterial.EnableKeyword(keyword);
			}
			else
			{
				Shader shader = Shader.Find((string)obj10);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				object obj11 = 0;
				Shader shader2 = Shader.Find((string)obj10);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S1_v42 (UnityEngine.Shader)+C]");
				if ((nint)obj11 < 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [envBaseType @ L1 (SYBO.Subway.Level.EnvironmentBaseType)+30]");
					if ((nint)0 != 0)
					{
						throw new ArrayTypeMismatchException();
					}
					Shader shader3 = Shader.Find((string)obj10);
					object obj12 = shader3 + 16;
					object obj13 = obj11 << 2;
					object contents = obj12 + obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					material._002Ector((string)contents);
					throw new ArrayTypeMismatchException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @FA1F");
			}
			object obj14 = obj5 + 1;
			obj5 = obj14;
		}
	}

	public static bool operator ==(EnvironmentBaseKind c1, EnvironmentBaseKind c2)
	{
		return c1 == c2;
	}

	public static bool operator !=(EnvironmentBaseKind c1, EnvironmentBaseKind c2)
	{
		//IL_000d: Expected Obj, but got I4
		object obj = c2.Type;
		_ = c2.NumTracks;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8649");
		bool result = default;
		return result;
	}

	public override int GetHashCode()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Level.EnvironmentBaseKind)+20]");
		return 0;
	}

	public override bool Equals(object other)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [other @ L1 (System.Object)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8649");
		object obj = default;
		return (byte)(obj ^ 1) != 0;
	}

	public bool Equals(EnvironmentBaseKind other)
	{
		//IL_000e: Expected I4, but got Obj
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public unsafe override string ToString()
	{
		//IL_000b: Expected Obj, but got Ref
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9806");
		string result = default;
		return result;
	}

	static EnvironmentBaseKind()
	{
		//IL_001d: Expected I, but got Obj
		//IL_0033: Expected Obj, but got I
		//IL_003c: Expected Obj, but got I4
		//IL_005d: Expected I, but got Obj
		//IL_0073: Expected Obj, but got I
		MovingTrain.autoPilotActivationDistance = 200f;
		nint num = (nint)typeof(MovingTrain);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		HashSet<> hashSet = default;
		((HashSet<T>)(object)hashSet).Clear();
		nint num2 = (nint)typeof(MovingTrain);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v16 (Il2CppClass<SYBO.Subway.Level.MovingTrain>)+5C]");
		object obj2 = (nint)0 + (nint)8;
		obj2 = hashSet;
	}
}
