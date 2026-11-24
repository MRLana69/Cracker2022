using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Info;
using SYBO.Subway.Characters;
using SYBO.Subway.Level;
using UnityEngine;

namespace SYBO.Subway.Pickups.Pickers;

public class PickerCollection
{
	private Action<PickerRemoveRequestEventArgs> m_OnPickerRemoveRequest;

	private List<IPicker> _iPickerList;

	private PickupManager _pickupManager;

	public event Action<PickerRemoveRequestEventArgs> OnPickerRemoveRequest
	{
		add
		{
			//IL_0021: Expected Obj, but got I
			//IL_0066: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerCollection)+50]");
			if ((nint)0 != 3)
			{
				_ = 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerCollection)+60]");
				((Collider)0).isTrigger = false;
				((CharacterPickupParticles)(object)value).PickedUpDefaultPowerUp();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerCollection)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerCollection)+18]");
					((Action<PickupSpawnPoint>)0)((PickupSpawnPoint)(object)this);
				}
				((PickupSpawnPoint)this).DeactivateChild();
			}
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_OnPickerRemoveRequest;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 8;
				if (obj3 == obj)
				{
					obj3 = obj4;
				}
				if (obj3 != obj)
				{
					obj = (Delegate)obj3;
					continue;
				}
				break;
			}
		}
	}

	public PickerCollection(PickupManager pickupManager)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_OnPickerRemoveRequest;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)(object)pickupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 8;
			if (obj3 == obj)
			{
				obj3 = obj4;
			}
			if (obj3 != obj)
			{
				obj = (Delegate)obj3;
				continue;
			}
			break;
		}
	}

	public void Add(IPicker iPicker)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected Obj, but got Unknown
		object obj = this + 16;
		obj = iPicker;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		object obj2 = this + 12;
		object obj3 = default;
		obj2 = obj3;
	}

	public bool HasPickerOfType<T>()
	{
		//IL_0058: Expected Obj, but got I4
		//IL_0067: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0080: Expected Obj, but got I4
		//IL_00a9: Expected Obj, but got I
		//IL_00b7: Expected Obj, but got I4
		//IL_00c0: Expected Obj, but got I4
		//IL_008e: Expected Obj, but got I4
		//IL_00fb: Expected Obj, but got I
		//IL_0113: Expected Obj, but got I
		//IL_0123: Expected Obj, but got I
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected Obj, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected Obj, but got Unknown
		//IL_01aa: Expected Obj, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected Obj, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected Obj, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got I
		//IL_0241: Expected Obj, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected Obj, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected Obj, but got Unknown
		//IL_0282: Expected Obj, but got I4
		//IL_0294: Expected Obj, but got I4
		//IL_018d: Expected Obj, but got I4
		//IL_0209: Expected Obj, but got I4
		PickupManager pickupManager = _pickupManager;
		object obj;
		if (this.m_OnPickerRemoveRequest != null)
		{
			if ((nint)this.m_OnPickerRemoveRequest == 1)
			{
				this.m_OnPickerRemoveRequest = (Action<PickerRemoveRequestEventArgs>)(-1);
				obj = 6;
			}
			else
			{
				obj = 8;
			}
		}
		else
		{
			this.m_OnPickerRemoveRequest = (Action<PickerRemoveRequestEventArgs>)(-1);
			_ = 0;
			obj = 7;
		}
		object obj2 = obj;
		nint num = default;
		object obj10 = default;
		bool result = default;
		object obj15 = default;
		object obj22 = default;
		while (true)
		{
			if ((nint)obj2 == 6)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerCollection)+14]");
				object obj3 = (nint)0 + (nint)1;
				obj2 = 7;
				object obj4 = 1;
			}
			else if ((nint)obj2 == 7)
			{
				object obj5 = num + 12;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S2_v5+60]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S2_v6+8]");
				object obj4 = 0;
				object obj8 = obj4 & 0x3FFF;
				object obj9 = obj8 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v40 @ S3_v6 (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerCollection)+14]");
				if (0 >= (nint)obj10)
				{
					result = false;
					obj2 = 8;
					continue;
				}
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S2_v9+60]");
				object obj12 = 0;
				obj4 = obj12;
				object obj13 = obj4 & 0x1FFF;
				object obj14 = obj13 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41 @ S3_v10 (should have been resolved before IL gen)");
				if (obj15 == null)
				{
					obj2 = 6;
					continue;
				}
				object obj16 = this + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Pickups.Pickers.PickerCollection)+14]");
				obj4 = 0;
				object obj17 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S3_v12+60]");
				object obj18 = 0;
				object obj19 = obj18;
				object obj20 = obj19 & 0x1FFF;
				object obj21 = obj20 + 22691;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S4_v9 (should have been resolved before IL gen)");
				obj16 = obj22;
				this.m_OnPickerRemoveRequest = (Action<PickerRemoveRequestEventArgs>)1;
				result = true;
				obj2 = 8;
			}
			else if ((nint)obj2 == 8)
			{
				break;
			}
		}
		return result;
	}

	public IPicker GetItemAtIndex(int i)
	{
		//IL_0346: Expected I, but got Obj
		//IL_035c: Expected Obj, but got I
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected Obj, but got Unknown
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_039e: Expected VT, but got Obj
		//IL_039e: Expected Obj, but got I4
		//IL_00f8: Expected I, but got Obj
		//IL_010e: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected Obj, but got Unknown
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_0139: Expected I, but got Obj
		//IL_042a: Expected VT, but got Obj
		//IL_042a: Expected Obj, but got I4
		//IL_021e: Expected I, but got Obj
		//IL_0234: Expected Obj, but got I
		//IL_01d1: Expected I, but got Obj
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Expected Obj, but got Unknown
		//IL_046d: Expected I, but got Obj
		//IL_0483: Expected Obj, but got I
		//IL_04bd: Expected Obj, but got I
		//IL_04db: Expected I, but got Obj
		//IL_04f1: Expected Obj, but got I
		//IL_025f: Expected I, but got Obj
		//IL_0562: Expected Obj, but got I4
		//IL_02ac: Expected I, but got Obj
		//IL_02f9: Expected I, but got Obj
		nint num = (nint)typeof(PickupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<SYBO.Subway.Pickups.PickupManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(PickupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v64 (Il2CppClass<SYBO.Subway.Pickups.PickupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj3 = default;
		object obj2 = obj3 + 12;
		if (!(PickupManager.SpawnDistanceMinToCharacter > 0f))
		{
			return null;
		}
		nint num3 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v59 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted = AgeRestriction.isRestricted;
		GameObject gameObject = ((Component)this).gameObject;
		Vector3 gamePosition = ((GamePositionRoot)isRestricted).GetGamePosition((Vector3)gameObject);
		nint num5 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S1_v12 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num6 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ S1_v39 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance = CharacterRendering.Instance;
		object obj6 = instance + 236;
		obj3 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S2_v7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14+8]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		if (num7 < 0)
		{
			return null;
		}
		nint num8 = (nint)typeof(GamePositionRoot);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v30 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(GamePositionRoot);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v54 (Il2CppClass<SYBO.Subway.Level.GamePositionRoot>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isRestricted2 = AgeRestriction.isRestricted;
		GameObject gameObject2 = ((Component)this).gameObject;
		Vector3 gamePosition2 = ((GamePositionRoot)isRestricted2).GetGamePosition((Vector3)gameObject2);
		nint num10 = (nint)typeof(Character);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v24 (Il2CppClass<SYBO.Subway.Characters.Character>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num11 = (nint)typeof(Character);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v35 (Il2CppClass<SYBO.Subway.Characters.Character>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		CharacterRendering instance2 = CharacterRendering.Instance;
		object obj9 = instance2 + 236;
		obj3 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S2_v16+8]");
		_ = 0;
		nint num12 = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S2_v21 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num13 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S2_v25 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v14+8]");
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		object obj11 = num14 - 0;
		float num15 = (float)obj11 * 0.125f;
		nint num16 = (nint)typeof(PickupManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ S0_v40 (Il2CppClass<SYBO.Subway.Pickups.PickupManager>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num17 = (nint)typeof(PickupManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v48 (Il2CppClass<SYBO.Subway.Pickups.PickupManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = !(PickupManager.SpawnDistanceMinToCharacter > num15);
		return (IPicker)flag;
	}

	public void Remove(IPicker iPicker)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		if (!_iPickerList.Contains(iPicker))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj2 = default;
			object obj = obj2 + 16;
			obj = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
	}

	public void UpdatePickers()
	{
		_ = 2048;
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private void IPicker_OnRemoveRequest(PickerRemoveRequestEventArgs pickerRemoveRequestEvent)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10E8D");
		object obj = default;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			_ = 0;
			object obj3 = default;
			object obj2 = obj3 + 16;
			obj2 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @750C");
		}
	}
}
