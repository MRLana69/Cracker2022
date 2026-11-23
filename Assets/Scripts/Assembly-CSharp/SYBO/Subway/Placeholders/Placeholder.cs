using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Common.Utilities;
using SYBO.Components.Utilities;
using SYBO.Subway.Level;
using SYBO.Subway.Placeholders.Lifecycles;
using SYBO.Subway.Placeholders.PrefabProviders;
using SYBO.Subway.Utilities;
using UnityEngine;

namespace SYBO.Subway.Placeholders;

public class Placeholder : MonoBehaviour
{
	protected Transform _transform;

	private bool _initialized;

	private List<TrackObject> _childTrackObjects;

	private IPlaceholderInitializer[] _initializers;

	public bool HasSpawnedInstances
	{
		get
		{
			if (_transform != null)
			{
				int childCount = _transform.childCount;
				return childCount != 0;
			}
			return false;
		}
	}

	protected virtual void Initialize()
	{
		Transform transform = base.transform;
		_transform = transform;
		IPlaceholderInitializer[] components = GetComponents<IPlaceholderInitializer>();
		_initializers = components;
		_initialized = true;
	}

	protected void InitializeCheck()
	{
		//IL_0029: Expected I, but got Obj
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			object obj = this + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v7 @ S1_v3 (Il2CppClass<SYBO.Subway.Placeholders.Placeholder>)+DC] (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnValidate()
	{
		GameObject gameObject = base.gameObject;
		PlaceholderLifecycle component = gameObject.GetComponent<PlaceholderLifecycle>();
		if (component == null)
		{
			string longName = GameObjectUtil.GetLongName(this);
			string text = "No lifecycle2 for placeholder " + longName;
		}
	}

	public void GetSpawnedObjects(List<Selector> selectors)
	{
		//IL_000a: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v19 (Il2CppClass<SYBO.Subway.Placeholders.Placeholder>)+DC] (should have been resolved before IL gen)");
		}
		int num2 = 0;
		while (true)
		{
			Transform transform = base.transform;
			int childCount = transform.childCount;
			if (childCount <= num2)
			{
				break;
			}
			Transform transform2 = base.transform;
			Transform child = transform2.GetChild(num2);
			PlaceholderPrefab component = child.GetComponent<PlaceholderPrefab>();
			if (component != null)
			{
				nint num3 = 0;
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v8 (Il2CppRgctx<System.Collections.Generic.List`1<SYBO.Subway.Level.Selector>>)+3C]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v113 @ S4_v9+4] (should have been resolved before IL gen)");
			}
			int num5 = num2 + 1;
			num2 = num5;
		}
		if (1 == 0)
		{
			GameObjectUtil.GetComponentsInChildrenBFS<T>((Component)this, true, (List<T>)(object)selectors, true);
		}
	}

	internal virtual GameObject SpawnInstance(Transform prefab)
	{
		//IL_00ae: Expected I, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		if (prefab == null)
		{
			return null;
		}
		Transform transform = default;
		if (Application.isPlaying)
		{
			transform = PoolManager.Spawn(prefab);
			if (transform == null)
			{
				string text = name;
				string text2 = "Placeholder on [" + text + "] failed to get object";
				return null;
			}
		}
		string text3 = prefab.name;
		nint num = (nint)this;
		object obj = this + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v82 @ S3_v4 (Il2CppClass<SYBO.Subway.Placeholders.Placeholder>)+F4] (should have been resolved before IL gen)");
		GameObject gameObject = transform.gameObject;
		bool activeSelf = gameObject.activeSelf;
		GameObject gameObject2 = transform.gameObject;
		gameObject2.SetActive(value: true);
		GetTrackObjects_Cached(transform);
		return transform.gameObject;
	}

	protected unsafe virtual Transform InitializeSpawnedInstance(Transform objectTransform, string newName)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected VT, but got Unknown
		//IL_00e8: Expected I, but got Obj
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected VT, but got Unknown
		//IL_0153: Expected I, but got Obj
		//IL_0185: Expected F4, but got I
		//IL_0180: Expected native int or pointer, but got VT
		//IL_01a0: Expected F4, but got I
		//IL_019b: Expected native int or pointer, but got VT
		//IL_01c0: Expected Obj, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected Obj, but got Unknown
		object obj = default;
		Quaternion quaternion = (Quaternion)(obj - 112);
		objectTransform.name = newName;
		Vector3 localScale = objectTransform.localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+50]");
		_ = 0;
		objectTransform.parent = _transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+68]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+60]");
		_ = 0;
		Vector3 localScale2 = (Vector3)(quaternion + 32);
		objectTransform.localScale = localScale2;
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v21 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v22 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+48]");
		_ = 0;
		_ = Vector3.zeroVector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+40]");
		_ = 0;
		Vector3 localPosition = (Vector3)(quaternion + 16);
		objectTransform.localPosition = localPosition;
		nint num3 = (nint)typeof(Quaternion);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v34 (Il2CppClass<UnityEngine.Quaternion>)+5C]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v35 (Il2CppStaticFields<UnityEngine.Quaternion>)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+38]");
		((Quaternion*)(nint)quaternion)->z = 0f;
		_ = Quaternion.identityQuaternion;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Quaternion)+30]");
		((Quaternion*)(nint)quaternion)->x = 0f;
		objectTransform.localRotation = quaternion;
		IPlaceholderInitializer[] initializers = _initializers;
		object obj2 = 0;
		while (initializers.Length > (nint)obj2)
		{
			object obj3 = obj2 << 2;
			object obj4 = (object)initializers + obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @293");
			object obj5 = obj2 + 1;
			obj2 = obj5;
		}
		return objectTransform;
	}

	protected void GetTrackObjects_Cached(Transform t)
	{
		//IL_0044: Expected Obj, but got I
		PlaceholderPrefab component = t.GetComponent<PlaceholderPrefab>();
		if (component != null)
		{
			List<TrackObject> childTrackObjects = _childTrackObjects;
			nint num = 0;
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S4_v3 (Il2CppRgctx<System.Collections.Generic.List`1<TrackObject>>)+3C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S4_v4+4] (should have been resolved before IL gen)");
		}
		else
		{
			GetTrackObjects(t);
		}
	}

	protected void GetTrackObjects(Transform t, bool addRootTrackObject = true)
	{
		if (addRootTrackObject)
		{
			TrackObject component = t.GetComponent<TrackObject>();
			if (component != null)
			{
				_childTrackObjects.Add(component);
			}
		}
		int num = 0;
		while (true)
		{
			int childCount = t.childCount;
			if (childCount > num)
			{
				Transform child = t.GetChild(num);
				TrackObject component2 = child.GetComponent<TrackObject>();
				if (component2 != null)
				{
					_childTrackObjects.Add(component2);
				}
				Placeholder component3 = child.GetComponent<Placeholder>();
				if (component3 == null)
				{
					GetTrackObjects(child, addRootTrackObject: false);
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	internal virtual void SpawnInstances(PlaceholderPrefabProviderBase prefabProvider)
	{
		//IL_000a: Expected I, but got Obj
		//IL_004a: Expected I, but got Obj
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v18 @ S1_v12 (Il2CppClass<SYBO.Subway.Placeholders.Placeholder>)+DC] (should have been resolved before IL gen)");
		}
		if (!HasSpawnedInstances)
		{
			List<Transform> prefabsToSpawn = prefabProvider._prefabsToSpawn;
			int num2 = 0;
			while (num2 < prefabsToSpawn._size)
			{
				Transform transform = prefabsToSpawn.get_Item(num2);
				nint num3 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v76 @ S2_v6 (Il2CppClass<SYBO.Subway.Placeholders.Placeholder>)+EC] (should have been resolved before IL gen)");
				int num4 = num2 + 1;
				num2 = num4;
			}
		}
	}

	internal unsafe void DespawnInstances()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0018: Expected I, but got Obj
		//IL_00b3: Expected F4, but got I
		//IL_00ae: Expected native int or pointer, but got VT
		//IL_00c8: Expected F4, but got I
		//IL_00c3: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_ = 0;
		_ = 0;
		if (~(_initialized ? 1u : 0u) != 0)
		{
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v27 @ S1_v30 (Il2CppClass<SYBO.Subway.Placeholders.Placeholder>)+DC] (should have been resolved before IL gen)");
		}
		if (Application.isPlaying)
		{
			int childCount = _transform.childCount;
			int num2 = childCount - 1;
			int num3 = num2;
			while (num3 > -1)
			{
				Transform child = _transform.GetChild(num3);
				Vector3 localScale = child.localScale;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
				_ = 0;
				PoolManager.Despawn(child);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
				((Vector3*)(nint)vector)->x = 0f;
				child.localScale = vector;
				int num4 = num3 - 1;
				num3 = num4;
			}
		}
		((List<T>)(object)_childTrackObjects).Clear();
	}

	internal void Activate()
	{
		int num = 0;
		while (true)
		{
			List<TrackObject> childTrackObjects = _childTrackObjects;
			if (num >= childTrackObjects._size)
			{
				break;
			}
			TrackObject trackObject = _childTrackObjects.get_Item(num);
			if (trackObject != null)
			{
				int num2 = num + 1;
				GameObject gameObject = trackObject.gameObject;
				bool activeInHierarchy = gameObject.activeInHierarchy;
				bool flag = !activeInHierarchy;
				num = num2;
				if (!flag)
				{
					trackObject.Activate();
					num = num2;
				}
			}
			else
			{
				_childTrackObjects.RemoveAt(num);
			}
		}
	}

	internal void Deactivate()
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
					trackObject.Deactivate();
				}
				int num2 = num + 1;
				num = num2;
				continue;
			}
			break;
		}
	}

	public Placeholder()
	{
		List<TrackObject> list = default;
		list._002Ector();
		_childTrackObjects = list;
		base._002Ector();
	}
}
