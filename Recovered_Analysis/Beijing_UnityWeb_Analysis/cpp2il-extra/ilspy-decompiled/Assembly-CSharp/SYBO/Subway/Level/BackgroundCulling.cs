using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace SYBO.Subway.Level;

[Serializable]
public class BackgroundCulling
{
	[StructLayout((LayoutKind)0, Size = 8)]
	private struct CullingBlock
	{
		public int CullingStartGamePositionZ;

		public int CullingEndGamePositionZ;
	}

	private const string BackgroundCullingAlphaPropertyName = "_BackgroundCullingAlpha";

	private const float FadeOutOffset = 100f;

	public EnvironmentType EnvironmentType;

	public Mesh CullingMesh;

	public float CullingStartOffset;

	private LinkedList<CullingBlock> _cullingBlocks;

	private Transform _transform;

	private MeshRenderer _renderer;

	private static float CullingOffset => 0.6000004f;

	public unsafe void Initialize(Material material, int renderQueue)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_001b: Expected Obj, but got I4
		//IL_0035: Expected Obj, but got I4
		//IL_005f: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 12;
		obj = ((int*)renderQueue)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [renderQueue @ L2 (System.Int32)+8]");
		_ = 0;
		obj2 = ((int*)renderQueue)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [renderQueue @ L2 (System.Int32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [material @ L1 (UnityEngine.Material)+10]");
		object obj3 = num - 0;
		BackgroundCulling backgroundCulling = (BackgroundCulling)obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
		EnvironmentType = EnvironmentType.None;
	}

	public void SetCullingStartZ(int gamePositionZ)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0013: Expected Obj, but got I4
		object obj = this + 84;
		obj = gamePositionZ;
	}

	public unsafe void SetCullingEndZ(int gamePositionZ)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected VT, but got Unknown
		//IL_0051: Expected I4, but got Obj
		//IL_004c: Expected native int or pointer, but got VT
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
		obj = gamePositionZ;
		obj2 = obj;
		CullingBlock cullingBlock = (CullingBlock)(obj2 + 16);
		((CullingBlock*)(nint)cullingBlock)->CullingStartGamePositionZ = (int)obj2;
		LinkedListNode<CullingBlock> linkedListNode = _cullingBlocks.AddLast(cullingBlock);
	}

	public void UpdateCulling(float gamePositionZ)
	{
		//IL_000a: Expected Obj, but got F4
		_transform = (Transform)gamePositionZ;
	}

	public void Reset()
	{
		//IL_0054: Expected I4, but got F4
		//IL_005f: Expected Obj, but got F4
		//IL_006a: Expected Obj, but got F4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected Obj, but got Unknown
		//IL_0092: Expected Obj, but got F4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected Obj, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected Obj, but got Unknown
		EnvironmentType = (EnvironmentType)(-350);
		CullingMesh = (Mesh)750f;
		_cullingBlocks = (LinkedList<CullingBlock>)5f;
		object obj = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj2 = default;
		obj = obj2;
		_renderer = (MeshRenderer)1f;
		_ = 0.5f;
		object obj3 = this + 68;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj4 = default;
		obj3 = obj4;
		Color black = Color.black;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj7 = this + 72;
		obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19+8]");
		_ = 0;
	}

	private static float CalculateCullingAlpha(float gamePositionZ, CullingBlock block)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
		return 0f;
	}

	public BackgroundCulling()
	{
		_cullingBlocks.Clear();
		_renderer.shadowCastingMode = ShadowCastingMode.Off;
	}
}
