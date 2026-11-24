using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Coins;
using SYBO.Subway.Level;
using SYBO.Subway.Pickups;
using SYBO.Subway.Pickups.Pickers;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using SYBO.Subway.Utilities;
using UnityEngine;
using UnityEngine.U2D;

namespace SYBO.Subway.Placeholders;

public class Placeholder : MonoBehaviour
{
	protected Transform _transform;

	private bool _initialized;

	private List<TrackObject> _childTrackObjects;

	private IPlaceholderInitializer[] _initializers;

	public bool HasSpawnedInstances => _initializers != null;

	protected virtual void Initialize()
	{
		_ = 1f;
		((SynchronizedThemeAsset)this)._002Ector();
	}

	protected void InitializeCheck()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected Obj, but got Unknown
		object obj = this + 12;
		GameObject gameObject = base.gameObject;
		obj = gameObject;
		object obj2 = this + 24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AA3B");
		object obj3 = default;
		obj2 = obj3;
		_initialized = true;
	}

	protected virtual void OnValidate()
	{
		if (~(_initialized ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		}
	}

	public void GetSpawnedObjects(List<Selector> selectors)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7266");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
	}

	internal virtual GameObject SpawnInstance(Transform prefab)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 16;
		obj = this;
		object obj2 = gameObject + 20;
		obj2 = prefab;
		return gameObject;
	}

	protected virtual Transform InitializeSpawnedInstance(Transform objectTransform, string newName)
	{
		//IL_0184: Expected VT, but got Obj
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected Obj, but got Unknown
		//IL_00f1: Expected I, but got Obj
		//IL_0107: Expected Obj, but got I
		//IL_0214: Expected I4, but got Obj
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_0028: Expected F4, but got I
		//IL_0132: Expected I, but got Obj
		//IL_005e: Expected I, but got Obj
		//IL_0074: Expected Obj, but got I
		//IL_01e4: Expected I4, but got Obj
		//IL_009f: Expected I, but got Obj
		Coin coin = ((CoinManager)this).SpawnCoin((Vector3)objectTransform, (Transform)(object)newName);
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)_transform).GetComponentsInParent<T>(true);
		object obj = componentsInParent + 12;
		if (obj != null)
		{
			object obj2 = componentsInParent + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SYBO.Subway.Placeholders.Placeholder)+1C]");
			((BackgroundLayer)obj2).Speed = 0f;
			if ((nint)obj > 1)
			{
				nint num = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S1_v24 (Il2CppClass<Utils>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S1_v31 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string longNameList = Utils.GetLongNameList((Component[])(object)_transform);
				string msg = string.ConcatArray((string[])(object)"Moving train placeholder loaded multiple MovingTrain chidren - ", (int)longNameList);
				SDebug.LogFormat(msg, null);
			}
		}
		else
		{
			nint num3 = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S1_v7 (Il2CppClass<Utils>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num4 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S1_v14 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string longNameList2 = Utils.GetLongNameList((Component[])(object)_transform);
			string msg2 = string.ConcatArray((string[])(object)"Utils could not find moving train in children of ", (int)longNameList2);
			SDebug.LogFormat(msg2, null);
		}
		return objectTransform;
	}

	protected void GetTrackObjects_Cached(Transform t)
	{
		//IL_017c: Expected Obj, but got I4
		//IL_002e: Expected Obj, but got I4
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_0081: Expected I, but got Obj
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_00f6: Expected Obj, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_0126: Expected Obj, but got I4
		OnValidate();
		object obj = 0;
		Sprite sprite = default;
		Sprite sprite2 = default;
		while (true)
		{
			GameObject gameObject = base.gameObject;
			int siblingIndex = ((Transform)(object)gameObject).GetSiblingIndex();
			if ((nint)sprite >= siblingIndex)
			{
				break;
			}
			GameObject gameObject2 = base.gameObject;
			bool flag = ((SpriteAtlas)(object)gameObject2).CanBindTo(sprite);
			PlaceholderPrefab component = ((Component)flag).GetComponent<PlaceholderPrefab>();
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v19 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S3_v6 (Il2CppMethodInfo)+C]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S3_v7+60]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S3_v8+38]");
				object obj5 = 0;
				object obj6 = obj5 & 0x1FFF;
				object obj7 = obj6 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S4_v5 (should have been resolved before IL gen)");
				obj = 1;
			}
			sprite = (Sprite)(sprite2 + 1);
		}
		if (obj == null)
		{
			SYBO.Common.Utilities.GameObjectUtil.GetComponentsInChildrenBFS<T>((GameObject)(object)this, true, (List<T>)(object)t, true);
		}
	}

	protected void GetTrackObjects(Transform t, bool addRootTrackObject = true)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_004e: Expected Obj, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_008a: Expected I, but got Obj
		//IL_00a0: Expected Obj, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		//IL_00cb: Expected I, but got Obj
		//IL_0118: Expected Obj, but got I4
		List<Component> themedComponents = ((SynchronizedThemeAsset)(object)_childTrackObjects).ThemedComponents;
		if (themedComponents != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
		if (!addRootTrackObject)
		{
			return;
		}
		_0021_00210[] componentsInParent = (_0021_00210[])(object)((Component)this).GetComponentsInParent<T>(true);
		object obj = componentsInParent + 12;
		object obj2 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
		{
			object obj3 = componentsInParent + 16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			nint num = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v24 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num2 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v35 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (!((UnityEngine.Object)obj5 != this))
			{
				((Placeholder)obj5).GetSpawnedObjects((List<Selector>)1);
			}
			object obj7 = obj2 + 1;
			obj2 = obj7;
		}
	}

	internal virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider)
	{
		//IL_00ed: Expected I, but got Obj
		//IL_0103: Expected Obj, but got I
		//IL_00cc: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0092: Expected Obj, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected Obj, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected Obj, but got Unknown
		PlaceholderPrefab component = prefabProvider.GetComponent<PlaceholderPrefab>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
		{
			List<TrackObject> childTrackObjects = _childTrackObjects;
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S3_v4 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S3_v5+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S3_v6+38]");
			object obj4 = 0;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S4_v5 (should have been resolved before IL gen)");
		}
		else
		{
			((PickupManager)this).SetPickerState((PickerType)prefabProvider, PickerEnabledState.NotEnabled);
		}
	}

	internal void DespawnInstances()
	{
		//IL_00a8: Expected I, but got Obj
		//IL_00be: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I4, but got Obj
		string text = tag;
		PlaceholderLifecycle component = ((GameObject)(object)text).GetComponent<PlaceholderLifecycle>();
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S1_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S1_v15 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (component != null)
		{
			string longName = SYBO.Common.Utilities.GameObjectUtil.GetLongName((GameObject)(object)this);
			string msg = string.ConcatArray((string[])(object)"No lifecycle2 for placeholder ", (int)longName);
			SDebug.LogFormat(msg, (object[])(object)this);
		}
	}

	internal void Activate()
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0022: Expected Obj, but got I4
		//IL_004f: Expected VT, but got I4
		//IL_0074: Expected I, but got Obj
		//IL_008a: Expected Obj, but got I
		//IL_013c: Expected Obj, but got I4
		//IL_0166: Expected Obj, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_00b5: Expected I, but got Obj
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 24);
		object obj = transform2 + 12;
		obj = 0;
		_ = 0;
		OnValidate();
		RuntimePlatform platform = Application.platform;
		int siblingIndex = _transform.GetSiblingIndex();
		Sprite sprite = (Sprite)(siblingIndex - 1);
		Sprite sprite2 = sprite;
		while (true)
		{
			bool flag = ((SpriteAtlas)(object)_transform).CanBindTo(sprite2);
			transform2.localScale = (Vector3)flag;
			obj = transform2;
			_ = ((UnityEngine.Object)transform2).m_CachedPtr;
			nint num = (nint)typeof(PoolManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v31 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(PoolManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v41 (Il2CppClass<SYBO.Components.Utilities.PoolManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			PoolManager.AddPool((PrefabPool)flag);
			transform = (Transform)obj;
			Transform transform3 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			((Transform)flag).parent = transform;
			Sprite sprite3 = (Sprite)(sprite2 - 1);
			sprite2 = sprite3;
		}
	}

	internal void Deactivate()
	{
		//IL_0026: Expected I, but got Obj
		//IL_003c: Expected Obj, but got I
		//IL_0067: Expected I, but got Obj
		int num = 0;
		while (true)
		{
			List<TrackObject> childTrackObjects = _childTrackObjects;
			if (num >= childTrackObjects._size)
			{
				break;
			}
			TrackObject trackObject = _childTrackObjects.get_Item(num);
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v15 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v31 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)trackObject).FindKernel((string)null) == 0)
			{
				_childTrackObjects.RemoveAt(num);
				continue;
			}
			int num4 = num + 1;
			string text = trackObject.tag;
			string text2 = ((GameObject)(object)text).tag;
			if (text2 != null)
			{
				trackObject.Deactivate();
			}
			num = num4;
		}
	}

	public Placeholder()
	{
		int num = 0;
		while (true)
		{
			List<TrackObject> childTrackObjects = _childTrackObjects;
			if (num < childTrackObjects._size)
			{
				TrackObject trackObject = _childTrackObjects.get_Item(num);
				if (~(trackObject._active ? 1u : 0u) == 0)
				{
					trackObject._002Ector();
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}
}
