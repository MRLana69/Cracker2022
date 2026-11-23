using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using SYBO.Subway.Routes;
using SYBO.Subway.Themes;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class RoofedCulling
{
	[Serializable]
	public class CustomRoofedCulling
	{
		public EnvironmentType EnvironmentType;

		public Vector4 CullingBounds;

		public CustomRoofedCulling()
		{
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector4>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
			_ = 0;
			CullingBounds = Vector4.zeroVector;
		}
	}

	private class CullingBlock
	{
		private Vector4 _value;

		public bool Low;

		public bool Finalized;

		public float CullStartZ
		{
			get
			{
				//IL_0007: Expected F4, but got VT
				return (float)_value;
			}
			set
			{
				//IL_000a: Expected VT, but got F4
				_value = (Vector4)value;
			}
		}

		public float CullStartY
		{
			get
			{
				//IL_000d: Expected F4, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+C]");
				return 0f;
			}
			set
			{
			}
		}

		public float CullEndZ
		{
			get
			{
				//IL_000d: Expected F4, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+10]");
				return 0f;
			}
			set
			{
			}
		}

		public float CullEndY
		{
			get
			{
				//IL_000d: Expected F4, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+14]");
				return 0f;
			}
			set
			{
			}
		}

		public unsafe Vector4 ToVector4()
		{
			//IL_000f: Expected F4, but got VT
			//IL_000a: Expected native int or pointer, but got VT
			//IL_0024: Expected F4, but got I
			//IL_001f: Expected native int or pointer, but got VT
			Vector4 vector = default;
			((Vector4*)(nint)vector)->x = (float)_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L1 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+10]");
			((Vector4*)(nint)vector)->z = 0f;
			return vector;
		}

		public CullingBlock()
		{
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Vector4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v11 @ S0_v6 (Il2CppClass<UnityEngine.Vector4>)+5C]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v7 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
			_ = 0;
			_value = Vector4.zeroVector;
		}
	}

	private LinkedList<CullingBlock> _cullingBlockList;

	private CullingBlock _currentCullingBlock;

	private CullingBlock _nextCullingBlock;

	private CullingBlock _emptyCullingblock;

	private CullingBlock _menuCullingblock;

	private Theme _theme;

	private unsafe CullingBlock CurrentCullingBlock
	{
		get
		{
			return _currentCullingBlock;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0049: Expected F4, but got I
			//IL_0044: Expected native int or pointer, but got VT
			//IL_0068: Expected F4, but got I
			//IL_0063: Expected native int or pointer, but got VT
			object obj = default;
			Vector4 vector = (Vector4)(obj - 32);
			_currentCullingBlock = value;
			CullingBlock currentCullingBlock = _currentCullingBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+18]");
			((Vector4*)(nint)vector)->z = 0f;
			_ = currentCullingBlock._value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+10]");
			((Vector4*)(nint)vector)->x = 0f;
			Shader.SetGlobalVector("_RoofedCullCurrent", vector);
		}
	}

	private unsafe CullingBlock NextCullingBlock
	{
		get
		{
			return _nextCullingBlock;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0049: Expected F4, but got I
			//IL_0044: Expected native int or pointer, but got VT
			//IL_0068: Expected F4, but got I
			//IL_0063: Expected native int or pointer, but got VT
			object obj = default;
			Vector4 vector = (Vector4)(obj - 32);
			_nextCullingBlock = value;
			CullingBlock nextCullingBlock = _nextCullingBlock;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+18]");
			((Vector4*)(nint)vector)->z = 0f;
			_ = nextCullingBlock._value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector4)+10]");
			((Vector4*)(nint)vector)->x = 0f;
			Shader.SetGlobalVector("_RoofedCullNext", vector);
		}
	}

	public void Initialize()
	{
		throw new ArgumentException();
	}

	private void Game_OnGameStarted()
	{
		NextCullingBlock = _emptyCullingblock;
	}

	private void Game_OnGameEnded()
	{
		_cullingBlockList.Clear();
	}

	public void UpdateCulling()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04d2: Expected F8, but got I
		//IL_0266: Expected F8, but got I4
		//IL_0522: Invalid comparison between I and F8
		//IL_0258: Expected F8, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		Character instance = Character.Instance;
		Transform transform = instance.transform;
		Vector3 position = transform.position;
		Game instance2 = Game.Instance;
		Variable<bool> isInGame = instance2.IsInGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S1_v8 (Variable`1<System.Boolean>)+8]");
		CullingBlock nextCullingBlock;
		if ((nint)0 == 0)
		{
			if (_menuCullingblock != _currentCullingBlock)
			{
				CurrentCullingBlock = _menuCullingblock;
				nextCullingBlock = _menuCullingblock;
				goto IL_0494;
			}
		}
		else
		{
			LinkedList<CullingBlock> cullingBlockList = _cullingBlockList;
			if (cullingBlockList.count >= 1)
			{
				LinkedList<CullingBlock> cullingBlockList2 = _cullingBlockList;
				LinkedListNode<CullingBlock> head = cullingBlockList2.head;
				if (head.item != _currentCullingBlock)
				{
					CurrentCullingBlock = head.item;
					LinkedListNode<CullingBlock> linkedListNode;
					if (head.next != null)
					{
						LinkedList<CullingBlock> list = head.list;
						bool flag = head.next == list.head;
						linkedListNode = null;
						if (!flag)
						{
							linkedListNode = head.next;
						}
					}
					else
					{
						linkedListNode = null;
					}
					if (linkedListNode != null)
					{
						LinkedListNode<CullingBlock> linkedListNode2;
						if (head.next != null)
						{
							LinkedList<CullingBlock> list2 = head.list;
							bool flag2 = head.next == list2.head;
							linkedListNode2 = null;
							if (!flag2)
							{
								linkedListNode2 = head.next;
							}
						}
						else
						{
							linkedListNode2 = null;
						}
						nextCullingBlock = linkedListNode2.item;
						goto IL_0494;
					}
				}
			}
			else if (_emptyCullingblock != _currentCullingBlock)
			{
				CurrentCullingBlock = _emptyCullingblock;
				nextCullingBlock = _emptyCullingblock;
				goto IL_0494;
			}
		}
		goto IL_04ad;
		IL_04ad:
		CullingBlock currentCullingBlock = _currentCullingBlock;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		double num = Math.Abs(0.0);
		double num2;
		if (num < 2147483648.0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			num2 = 0.0;
		}
		else
		{
			num2 = -2147483648.0;
		}
		double num3 = num2 - 90.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v20 (SYBO.Subway.Visuals.RoofedCulling+CullingBlock)+10]");
		if (!(0.0 < num3))
		{
			return;
		}
		LinkedList<CullingBlock> cullingBlockList3 = _cullingBlockList;
		if (cullingBlockList3.count >= 1)
		{
			LinkedList<CullingBlock> cullingBlockList4 = _cullingBlockList;
			LinkedListNode<CullingBlock> head2 = cullingBlockList4.head;
			if (head2.item == _currentCullingBlock)
			{
				_cullingBlockList.RemoveFirst();
			}
		}
		LinkedList<CullingBlock> cullingBlockList5 = _cullingBlockList;
		CullingBlock nextCullingBlock2;
		if (cullingBlockList5.count >= 1)
		{
			LinkedList<CullingBlock> cullingBlockList6 = _cullingBlockList;
			LinkedListNode<CullingBlock> head3 = cullingBlockList6.head;
			CurrentCullingBlock = head3.item;
			LinkedListNode<CullingBlock> linkedListNode3;
			if (head3.next != null)
			{
				LinkedList<CullingBlock> list3 = head3.list;
				bool flag3 = head3.next == list3.head;
				linkedListNode3 = null;
				if (!flag3)
				{
					linkedListNode3 = head3.next;
				}
			}
			else
			{
				linkedListNode3 = null;
			}
			if (linkedListNode3 == null)
			{
				return;
			}
			LinkedListNode<CullingBlock> linkedListNode4;
			if (head3.next != null)
			{
				LinkedList<CullingBlock> list4 = head3.list;
				bool flag4 = head3.next == list4.head;
				linkedListNode4 = null;
				if (!flag4)
				{
					linkedListNode4 = head3.next;
				}
			}
			else
			{
				linkedListNode4 = null;
			}
			nextCullingBlock2 = linkedListNode4.item;
		}
		else
		{
			if (_emptyCullingblock == _currentCullingBlock)
			{
				return;
			}
			CurrentCullingBlock = _emptyCullingblock;
			nextCullingBlock2 = _emptyCullingblock;
		}
		NextCullingBlock = nextCullingBlock2;
		return;
		IL_0494:
		NextCullingBlock = nextCullingBlock;
		goto IL_04ad;
	}

	private unsafe void RouteChunk_OnEnvironmentSegmentSpawned(EnvironmentKind environmentKind, int posZ, Route route)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0292: Expected I, but got Obj
		//IL_02ca: Expected I, but got Obj
		//IL_02f5: Expected Obj, but got VT
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Ref, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected Ref, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected Ref, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Ref, but got Unknown
		//IL_01a8: Expected F4, but got I4
		//IL_0150: Expected Obj, but got I
		//IL_016e: Expected VT, but got Obj
		//IL_016e: Expected F4, but got I4
		//IL_010b: Expected Obj, but got I
		object obj = default;
		RoofedCulling roofedCulling = (RoofedCulling)(obj - 48);
		_ = 0;
		nint num = (nint)route;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v20 @ S1_v5 (Il2CppClass<SYBO.Subway.Routes.Route>)+E4] (should have been resolved before IL gen)");
		object obj2 = default;
		if ((nint)obj2 != 1)
		{
			return;
		}
		_ = 0;
		_ = 0;
		nint num2 = (nint)typeof(Vector4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v14 (Il2CppClass<UnityEngine.Vector4>)+5C]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S1_v15 (Il2CppStaticFields<UnityEngine.Vector4>)+8]");
		_ = 0;
		roofedCulling._menuCullingblock = (CullingBlock)Vector4.zeroVector;
		EvaluateEnvironment(environmentKind._type, out *(bool*)(roofedCulling + 23), ref *(bool*)(roofedCulling + 47), ref *(bool*)(roofedCulling + 46), ref *(Vector4*)(roofedCulling + 24));
		LinkedList<CullingBlock> cullingBlockList = _cullingBlockList;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Visuals.RoofedCulling)+17]");
		if ((nint)0 != 0)
		{
			if (cullingBlockList.count >= 1)
			{
				LinkedList<CullingBlock> cullingBlockList2 = _cullingBlockList;
				LinkedListNode<CullingBlock> head = cullingBlockList2.head;
				LinkedListNode<CullingBlock> linkedListNode = ((cullingBlockList2.head == null) ? null : head.prev);
				CullingBlock item = linkedListNode.item;
				if (!item.Finalized)
				{
					if (item == _currentCullingBlock)
					{
						CurrentCullingBlock = item;
					}
					bool low = item.Low;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Visuals.RoofedCulling)+2F]");
					bool flag = (nint)(low ? 1 : 0) != 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Visuals.RoofedCulling)+2E]");
					object obj3 = (nint)0 | (nint)(flag ? 1 : 0);
					if (obj3 == null)
					{
						return;
					}
					item.Finalized = true;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Visuals.RoofedCulling)+2E]");
			if ((nint)0 != 0)
			{
				RoofedCulling roofedCulling2 = roofedCulling;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Visuals.RoofedCulling)+20]");
				roofedCulling2._cullingBlockList = (LinkedList<CullingBlock>)0;
				roofedCulling = (RoofedCulling)(object)roofedCulling._menuCullingblock;
				CullingBlock value = roofedCulling.GenerateCustomCullingBlock(posZ, (Vector4)roofedCulling);
				LinkedListNode<CullingBlock> linkedListNode2 = _cullingBlockList.AddLast(value);
			}
			else
			{
				RoofedCulling roofedCulling3 = roofedCulling;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (SYBO.Subway.Visuals.RoofedCulling)+2F]");
				CullingBlock value2 = roofedCulling3.GenerateCullingBlock(posZ, low: false);
				LinkedListNode<CullingBlock> linkedListNode3 = _cullingBlockList.AddLast(value2);
			}
		}
		else
		{
			if (cullingBlockList.count < 1)
			{
				return;
			}
			LinkedList<CullingBlock> cullingBlockList3 = _cullingBlockList;
			LinkedListNode<CullingBlock> head2 = cullingBlockList3.head;
			LinkedListNode<CullingBlock> linkedListNode4 = ((cullingBlockList3.head == null) ? null : head2.prev);
			CullingBlock item2 = linkedListNode4.item;
			if (!item2.Finalized)
			{
				item2.Finalized = true;
				if (_currentCullingBlock == item2)
				{
					CurrentCullingBlock = item2;
				}
			}
		}
	}

	private unsafe void EvaluateEnvironment(EnvironmentType environmentType, out bool cullEnvironment, ref bool cullLow, ref bool cullCustom, ref Vector4 customCullingBounds)
	{
		//IL_0012: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected Obj, but got Unknown
		//IL_0126: Expected Obj, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0156: Expected Obj, but got I
		//IL_01ef: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		ref bool reference = ref *(bool*)null;
		object obj = 0;
		while (true)
		{
			Theme theme = _theme;
			EnvironmentType[] roofedCullingEnvironmentsHigh = theme._roofedCullingEnvironmentsHigh;
			if (roofedCullingEnvironmentsHigh.Length <= (nint)obj)
			{
				break;
			}
			object obj2 = obj << 2;
			object obj3 = (object)roofedCullingEnvironmentsHigh + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v33+10]");
			if ((nint)environmentType == (nint)0)
			{
				reference = ref *(bool*)1;
				ref bool reference2 = ref *(bool*)null;
				break;
			}
			object obj4 = obj + 1;
			obj = obj4;
		}
		if (cullEnvironment)
		{
			return;
		}
		object obj5 = 0;
		while (true)
		{
			Theme theme2 = _theme;
			EnvironmentType[] roofedCullingEnvironmentsLow = theme2._roofedCullingEnvironmentsLow;
			if (roofedCullingEnvironmentsLow.Length <= (nint)obj5)
			{
				break;
			}
			object obj6 = obj5 << 2;
			object obj7 = (object)roofedCullingEnvironmentsLow + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S1_v27+10]");
			if ((nint)environmentType == (nint)0)
			{
				reference = ref *(bool*)1;
				ref bool reference2 = ref *(bool*)1;
				break;
			}
			object obj8 = obj5 + 1;
			obj5 = obj8;
		}
		if (cullEnvironment)
		{
			return;
		}
		object obj9 = 0;
		while (true)
		{
			Theme theme3 = _theme;
			CustomRoofedCulling[] roofedCullingEnvironmentsCustom = theme3._roofedCullingEnvironmentsCustom;
			if ((nint)obj9 < roofedCullingEnvironmentsCustom.Length)
			{
				object obj10 = obj9 << 2;
				object obj11 = (object)roofedCullingEnvironmentsCustom + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v15+10]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S1_v16+8]");
				if ((nint)environmentType != (nint)0)
				{
					object obj13 = obj9 + 1;
					obj9 = obj13;
					continue;
				}
				reference = ref *(bool*)1;
				ref bool reference3 = ref *(bool*)1;
				Theme theme4 = _theme;
				object obj14 = obj9 << 2;
				object obj15 = (object)theme4._roofedCullingEnvironmentsCustom + obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v34+10]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v35+14]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S0_v35+C]");
				ref Vector4 reference4 = ref *(Vector4*)null;
				break;
			}
			break;
		}
	}

	private CullingBlock GenerateCullingBlock(float posZ, bool low)
	{
		//IL_0029: Expected VT, but got F4
		CullingBlock cullingBlock = default;
		cullingBlock._002Ector();
		cullingBlock._value = (Vector4)posZ;
		_ = -1000f;
		float num = 90f;
		if (!low)
		{
			num = 1000f;
		}
		cullingBlock.Low = low;
		return cullingBlock;
	}

	private CullingBlock GenerateCustomCullingBlock(float posZ, Vector4 customCulling)
	{
		//IL_002f: Expected VT, but got F4
		CullingBlock cullingBlock = default;
		cullingBlock._002Ector();
		float num = posZ + customCulling.x;
		cullingBlock._value = (Vector4)num;
		_ = customCulling.y;
		float num2 = posZ + customCulling.z;
		_ = customCulling.w;
		cullingBlock.Finalized = true;
		return cullingBlock;
	}

	public RoofedCulling()
	{
		//IL_0039: Expected VT, but got F4
		LinkedList<CullingBlock> cullingBlockList = default;
		_cullingBlockList = cullingBlockList;
		CullingBlock cullingBlock = default;
		cullingBlock._002Ector();
		cullingBlock.Finalized = true;
		_emptyCullingblock = cullingBlock;
		CullingBlock cullingBlock2 = default;
		cullingBlock2._002Ector();
		cullingBlock2._value = (Vector4)(-1000f);
		_ = -1000f;
		_ = 1000f;
		_ = 1000f;
		cullingBlock2.Finalized = true;
		_menuCullingblock = cullingBlock2;
	}
}
