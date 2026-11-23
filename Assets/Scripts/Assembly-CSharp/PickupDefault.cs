using System;
using Cpp2ILInjected;
using SYBO.Subway;
using SYBO.Subway.Pickups;
using UnityEngine;

public class PickupDefault : MonoBehaviour
{
	public delegate void ActivateDelegate();

	public MeshRenderer meshRenderer;

	public Glow glow;

	public MeshRenderer[] rings;

	public bool ShouldSpawnParticles;

	private Collider parentCollider;

	public ActivateDelegate ActivatePickup;

	private bool IsActive__BackingField;

	public bool IsVisible
	{
		get
		{
			if (meshRenderer != null)
			{
				return meshRenderer.enabled;
			}
			return false;
		}
	}

	public bool IsActive
	{
		get
		{
			return IsActive__BackingField;
		}
		private set
		{
			IsActive__BackingField = value;
		}
	}

	private unsafe void Awake()
	{
		TrackObject component = GetComponent<TrackObject>();
		bool flag = (object)component == null;
		bool flag2 = !flag;
		TrackObject trackObject = component;
		if (!flag2)
		{
			GameObject gameObject = base.gameObject;
			TrackObject trackObject2 = gameObject.AddComponent<TrackObject>();
			trackObject = trackObject2;
		}
		Action action = default;
		action._002Ector(this, (nint)__ldftn(PickupDefault.OnActivate));
		trackObject.OnActivate += action;
		Action action2 = default;
		action2._002Ector(this, (nint)__ldftn(PickupDefault.OnDeactivate));
		trackObject.OnDeactivate += action2;
		Transform current = transform;
		Collider collider = FindParentCollider(current);
		parentCollider = collider;
		if (parentCollider == null)
		{
			bool isInstantiated = Game.IsInstantiated;
		}
		SetVisible(isVisible: false);
	}

	public static PickupType ConvertSubclassInstanceToPickupType(PickupDefault pickupDefault)
	{
		string text = pickupDefault.name;
		bool flag = text.Contains("jetpackPickup");
		PickupType result = PickupType.JetPack;
		if (!flag)
		{
			bool flag2 = text.Contains("jumpBooster");
			result = PickupType.SuperSneakers;
			if (!flag2)
			{
				bool flag3 = text.Contains("doubleScoreMultiplier");
				result = PickupType.MultiplierScore2x;
				if (!flag3)
				{
					bool flag4 = text.Contains("magnetBooster");
					result = PickupType.CoinMagnet;
					if (!flag4)
					{
						string text2 = "Unexpected value here: " + text + ". Fix immediately";
						result = PickupType.JetPack;
					}
				}
			}
		}
		return result;
	}

	private Collider FindParentCollider(Transform current)
	{
		Transform parent = default;
		Collider result;
		Transform transform = default;
		while (true)
		{
			Collider component = parent.GetComponent<Collider>();
			if (component != null)
			{
				Collider component2 = parent.GetComponent<Collider>();
				result = component2;
				break;
			}
			Transform parent2 = parent.parent;
			bool flag = parent2 != null;
			bool flag2 = !flag;
			result = null;
			if (flag2)
			{
				break;
			}
			parent = transform.parent;
		}
		return result;
	}

	private void SetVisible(bool isVisible)
	{
		//IL_008d: Expected Obj, but got I4
		//IL_00c4: Expected Obj, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected Obj, but got Unknown
		if (meshRenderer != null)
		{
			meshRenderer.enabled = isVisible;
		}
		if (glow != null)
		{
			glow.SetVisible(isVisible);
		}
		MeshRenderer[] array = rings;
		if (rings != null)
		{
			object obj = 0;
			while ((nint)obj < array.Length)
			{
				object obj2 = obj << 2;
				object obj3 = (object)rings + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v29+10]");
				((Renderer)0).enabled = isVisible;
				object obj4 = obj + 1;
				obj = obj4;
			}
		}
		IsActive__BackingField = isVisible;
	}

	private void OnActivate()
	{
		parentCollider.enabled = true;
		ActivateDelegate activatePickup = ActivatePickup;
		if (ActivatePickup != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v6.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		SetVisible(isVisible: true);
	}

	private void OnDeactivate()
	{
		SetVisible(isVisible: false);
	}

	private void OnValidate()
	{
		//IL_007c: Expected Obj, but got I4
		//IL_0031: Expected Obj, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		MeshFilter[] componentsInChildren = GetComponentsInChildren<MeshFilter>(includeInactive: true);
		object obj = 0;
		while (componentsInChildren.Length > (nint)obj)
		{
			object obj2 = obj << 2;
			object obj3 = (object)componentsInChildren + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v13+10]");
			Mesh sharedMesh = ((MeshFilter)0).sharedMesh;
			bool flag = sharedMesh == null;
			object obj4 = obj + 1;
			obj = obj4;
		}
	}

	public void Activate()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		ActivateDelegate activatePickup = ActivatePickup;
		if (ActivatePickup != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v17.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		if (parentCollider != null)
		{
			parentCollider.enabled = true;
		}
		SetVisible(isVisible: true);
	}

	public void Deactivate()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		SetVisible(isVisible: false);
	}
}
