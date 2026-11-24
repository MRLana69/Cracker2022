using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UI.Screens;
using UnityEngine;

public class UIKeyNavigation : MonoBehaviour
{
	public enum Constraint
	{
		None,
		Vertical,
		Horizontal,
		Explicit
	}

	public static BetterList<UIKeyNavigation> list;

	public Constraint constraint;

	public GameObject onUp;

	public GameObject onDown;

	public GameObject onLeft;

	public GameObject onRight;

	public GameObject onClick;

	public GameObject onTab;

	public bool startsSelected;

	[NonSerialized]
	private bool mStarted;

	public static int mLastFrame;

	public static UIKeyNavigation current
	{
		get
		{
			//IL_036c: Expected I, but got Obj
			//IL_0382: Expected Obj, but got I
			//IL_04a3: Expected Obj, but got I4
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_03ae: Expected Obj, but got I4
			//IL_005b: Expected Obj, but got I4
			//IL_010a: Expected I, but got Obj
			//IL_0120: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_03da: Expected Obj, but got I4
			//IL_00f7: Expected Obj, but got I4
			//IL_01a6: Expected I, but got Obj
			//IL_01bc: Expected Obj, but got I
			//IL_014b: Expected I, but got Obj
			//IL_0406: Expected Obj, but got I4
			//IL_0193: Expected Obj, but got I4
			//IL_0242: Expected I, but got Obj
			//IL_0258: Expected Obj, but got I
			//IL_01e7: Expected I, but got Obj
			//IL_0432: Expected Obj, but got I4
			//IL_022f: Expected Obj, but got I4
			//IL_0359: Expected Obj, but got I4
			//IL_0283: Expected I, but got Obj
			//IL_02d0: Expected I, but got Obj
			//IL_02e6: Expected Obj, but got I
			//IL_0469: Expected Obj, but got I4
			//IL_0481: Expected Obj, but got I4
			//IL_0311: Expected I, but got Obj
			nint num = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UICamera>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v94 (Il2CppClass<UICamera>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UIKeyNavigation result;
			if (UICamera.GetKey.EndInvoke((IAsyncResult)308))
			{
				result = (UIKeyNavigation)3;
			}
			else
			{
				nint num3 = (nint)typeof(UICamera);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<UICamera>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v87 (Il2CppClass<UICamera>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (UICamera.GetKey.EndInvoke((IAsyncResult)307))
				{
					result = (UIKeyNavigation)3;
				}
				else
				{
					nint num5 = (nint)typeof(UICamera);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v25 (Il2CppClass<UICamera>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v80 (Il2CppClass<UICamera>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (UICamera.GetKey.EndInvoke((IAsyncResult)304))
					{
						result = (UIKeyNavigation)1;
					}
					else
					{
						nint num7 = (nint)typeof(UICamera);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S0_v34 (Il2CppClass<UICamera>)+BA]");
						object obj4 = (nint)0 & (nint)0x200;
						if (obj4 != null)
						{
							nint num8 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v73 (Il2CppClass<UICamera>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (UICamera.GetKey.EndInvoke((IAsyncResult)303))
						{
							result = (UIKeyNavigation)1;
						}
						else
						{
							nint num9 = (nint)typeof(UICamera);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S0_v43 (Il2CppClass<UICamera>)+BA]");
							object obj5 = (nint)0 & (nint)0x200;
							if (obj5 != null)
							{
								nint num10 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v66 (Il2CppClass<UICamera>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							if (!UICamera.GetKey.EndInvoke((IAsyncResult)306))
							{
								nint num11 = (nint)typeof(UICamera);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v55 (Il2CppClass<UICamera>)+BA]");
								object obj6 = (nint)0 & (nint)0x200;
								if (obj6 != null)
								{
									nint num12 = (nint)typeof(UICamera);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ S0_v60 (Il2CppClass<UICamera>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								bool flag = UICamera.GetKey.EndInvoke((IAsyncResult)305);
								bool flag2 = !flag;
								result = (UIKeyNavigation)4;
								if (flag2)
								{
									goto IL_048f;
								}
							}
							result = (UIKeyNavigation)2;
						}
					}
				}
			}
			goto IL_048f;
			IL_048f:
			return result;
		}
	}

	public bool isColliderEnabled
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00a4: Expected I4, but got Obj
			//IL_00a4: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(UIKeyBinding);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppClass<UIKeyBinding>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(UIKeyBinding);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v7 (Il2CppClass<UIKeyBinding>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return ((UIScrollView)constraint).RestrictWithinBounds((byte)(int)onUp != 0);
		}
	}

	protected virtual void OnEnable()
	{
		CancelInvoke();
	}

	private void Start()
	{
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_00b4: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0062: Expected I4, but got Obj
		nint num = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((BetterList<>)(object)list).RemoveAt((int)this);
		if (~(mStarted ? 1u : 0u) == 0)
		{
			((RectTransform)(object)this).SetSizeWithCurrentAnchors((RectTransform.Axis)"Start", 0.001f);
		}
	}

	protected virtual void OnDisable()
	{
		//IL_0040: Expected I, but got Obj
		//IL_0056: Expected Obj, but got I
		//IL_0081: Expected I, but got Obj
		mStarted = true;
		if (~(startsSelected ? 1u : 0u) != 0 || !IsActive((GameObject)(object)this))
		{
			return;
		}
		string touch = tag;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S1_v7 (Il2CppClass<UICamera>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v12 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.Raycast((UICamera.MouseOrTouch)(object)touch);
	}

	private static bool IsActive(GameObject go)
	{
		//IL_005c: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_009d: Expected I, but got Obj
		//IL_014a: Expected I, but got Obj
		if (((Behaviour)(object)go).isActiveAndEnabled)
		{
			string text = ((Component)(object)go).tag;
			string text2 = ((GameObject)(object)text).tag;
			if (text2 != null)
			{
				Collider component = ((Component)(object)go).GetComponent<Collider>();
				nint num = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v42 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					return component.isTrigger;
				}
				Collider2D component2 = ((Component)(object)go).GetComponent<Collider2D>();
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v26 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
				{
					return component2.isActiveAndEnabled;
				}
				return false;
			}
			return false;
		}
		return false;
	}

	public GameObject GetLeft()
	{
		//IL_0209: Expected I, but got Obj
		//IL_021f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0091: Expected I, but got Obj
		//IL_00a7: Expected Obj, but got I
		//IL_0143: Expected I, but got Obj
		//IL_0159: Expected Obj, but got I
		//IL_00d2: Expected I, but got Obj
		//IL_0126: Expected Obj, but got I4
		//IL_0184: Expected I, but got Obj
		//IL_01d8: Expected Obj, but got I4
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v50 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (UnityEngine.Object.IsNativeObjectAlive((UnityEngine.Object)this))
		{
			string text = ((GameObject)(object)this).tag;
			if (text != null)
			{
				Collider component = ((GameObject)(object)this).GetComponent<Collider>();
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v46 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
				{
					bool isTrigger = component.isTrigger;
					return (GameObject)isTrigger;
				}
				Collider2D component2 = ((GameObject)(object)this).GetComponent<Collider2D>();
				nint num5 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v30 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num6 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S0_v40 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (((ComputeShader)(object)component2).FindKernel((string)null) != 0)
				{
					bool flag = component2.isActiveAndEnabled;
					return (GameObject)flag;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	public GameObject GetRight()
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v22 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UILabel uILabel = (UILabel)(obj2 + 12);
		GameObject left = ((UIKeyNavigation)(object)onLeft).GetLeft();
		if ((object)left != null)
		{
			return onLeft;
		}
		if (constraint == Constraint.Vertical)
		{
			return null;
		}
		if (constraint == Constraint.Explicit)
		{
			return null;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 right = Vector3.right;
		uILabel = (UILabel)obj2;
		UILabel uILabel2 = uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)uILabel2).m_CachedPtr = (IntPtr)0;
		return (GameObject)(object)((CelebrationPopup)this).AnimateAlpha(uILabel, 1f, 2f);
	}

	public GameObject GetUp()
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v22 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UILabel uILabel = (UILabel)(obj2 + 12);
		GameObject left = ((UIKeyNavigation)(object)onRight).GetLeft();
		if ((object)left != null)
		{
			return onRight;
		}
		if (constraint == Constraint.Vertical)
		{
			return null;
		}
		if (constraint == Constraint.Explicit)
		{
			return null;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Quaternion identity = Quaternion.identity;
		uILabel = (UILabel)obj2;
		UILabel uILabel2 = uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)uILabel2).m_CachedPtr = (IntPtr)0;
		return (GameObject)(object)((CelebrationPopup)this).AnimateAlpha(uILabel, 1f, 2f);
	}

	public GameObject GetDown()
	{
		//IL_0165: Expected I, but got Obj
		//IL_017b: Expected Obj, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_00d7: Expected I, but got Obj
		//IL_00ed: Expected Obj, but got I
		//IL_0118: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S1_v22 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = default;
		UILabel uILabel = (UILabel)(obj2 + 12);
		GameObject left = ((UIKeyNavigation)(object)onUp).GetLeft();
		if ((object)left != null)
		{
			return onUp;
		}
		if (constraint == Constraint.Horizontal)
		{
			return null;
		}
		if (constraint == Constraint.Explicit)
		{
			return null;
		}
		nint num3 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v19 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S0_v28 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 down = Vector3.down;
		uILabel = (UILabel)obj2;
		UILabel uILabel2 = uILabel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)uILabel2).m_CachedPtr = (IntPtr)0;
		return (GameObject)(object)((CelebrationPopup)this).AnimateAlpha(uILabel, 2f, 1f);
	}

	public GameObject Get(Vector3 myDir, float x = 1f, float y = 1f)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0033: Expected Obj, but got VT
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		((UnityEngine.Object)gameObject).m_CachedPtr = (IntPtr)0;
		object obj = gameObject + 16;
		obj = myDir;
		return gameObject;
	}

	protected static Vector3 GetCenter(GameObject go)
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected Obj, but got Unknown
		//IL_008d: Expected I, but got Obj
		//IL_00a3: Expected Obj, but got I
		//IL_00d2: Expected I4, but got Obj
		//IL_00dd: Expected VT, but got Obj
		//IL_0013: Expected VT, but got Obj
		Component component = default;
		string text = component.tag;
		object obj = go & 1;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S1_v9 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			Vector3 vector = (Vector3)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v15 (UnityEngine.Vector3)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool released = default;
		((UICamera)(object)text).ProcessTouch((byte)(int)"OnPress" != 0, released);
		return (Vector3)typeof(UICamera);
	}

	public unsafe virtual void OnNavigate(KeyCode key)
	{
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected Obj, but got Unknown
		//IL_03e0: Expected Obj, but got I4
		//IL_03ef: Expected Obj, but got I4
		//IL_03fc: Expected Obj, but got I4
		//IL_040e: Expected I, but got Obj
		//IL_0424: Expected Obj, but got I
		//IL_044a: Expected Obj, but got I4
		//IL_045c: Expected I, but got Obj
		//IL_0472: Expected Obj, but got I
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Expected Obj, but got Unknown
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected VT, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected Obj, but got Unknown
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected Obj, but got Unknown
		//IL_04d1: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_024a: Expected I, but got Obj
		//IL_0260: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_00b9: Expected VT, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected Obj, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected Obj, but got Unknown
		//IL_0349: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_028b: Expected I, but got Obj
		//IL_00de: Expected I, but got Obj
		//IL_00f4: Expected Obj, but got I
		//IL_0673: Expected F4, but got Obj
		//IL_066e: Expected native int or pointer, but got VT
		//IL_0688: Expected F4, but got I
		//IL_0683: Expected native int or pointer, but got VT
		//IL_06b2: Expected VT, but got Obj
		//IL_06e1: Expected VT, but got Obj
		//IL_02d3: Expected Obj, but got I4
		//IL_02e1: Expected VT, but got I4
		//IL_038a: Expected I, but got Obj
		//IL_0526: Expected Obj, but got I4
		//IL_0554: Expected VT, but got Obj
		//IL_0554: Expected Obj, but got I4
		//IL_0565: Expected Obj, but got F4
		//IL_011f: Expected I, but got Obj
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected Obj, but got Unknown
		//IL_01bc: Expected I, but got Obj
		//IL_01d2: Expected Obj, but got I
		//IL_05a1: Expected F4, but got Obj
		//IL_059c: Expected native int or pointer, but got VT
		//IL_05b6: Expected F4, but got I
		//IL_05b1: Expected native int or pointer, but got VT
		//IL_05e0: Expected VT, but got Obj
		//IL_060f: Expected VT, but got Obj
		//IL_0620: Expected Obj, but got F4
		//IL_01fd: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 36;
		obj = 0;
		_ = 0;
		UIWidget component = ((GameObject)key).GetComponent<UIWidget>();
		bool activeSelf = ((GameObject)key).activeSelf;
		nint num = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<UICamera>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S1_v106 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int direction = UICamera.GetDirection((string)activeSelf);
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v17 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v115 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Transform transform = (Transform)(obj2 + 60);
		Vector3 vector = (Vector3)(obj2 + 48);
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 12;
		if (((ComputeShader)direction).FindKernel(null) != 0)
		{
			int layer = ((GameObject)key).layer;
			transform.position = (Vector3)layer;
			obj = transform;
			_ = ((UnityEngine.Object)transform).m_CachedPtr;
			nint num5 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v71 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num6 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v111 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)(object)component).FindKernel((string)null) != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				object obj9 = default;
				object obj8 = obj9 + 16;
				obj5 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v78+8]");
				_ = 0;
				object obj10 = obj9 + 40;
				obj6 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S1_v83+8]");
				_ = 0;
				nint num7 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v93 (Il2CppClass<UnityEngine.Vector3>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num8 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v107 (Il2CppClass<UnityEngine.Vector3>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((Vector3*)(nint)vector)->x = (float)obj5;
				Vector3 vector2 = vector;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v26+8]");
				((Vector3*)(nint)vector2)->z = 0f;
				transform = (Transform)obj6;
				Transform transform2 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v28+8]");
				((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)0;
				Vector3 vector3 = vector - (Vector3)transform;
				transform = (Transform)obj2;
				Transform transform3 = transform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
				Vector3 vector4 = (Vector3)transform / 0.5f;
				obj = vector.x;
				_ = vector.z;
			}
			bool flag = UICamera.IsPartOfUI((GameObject)direction);
			transform = (Transform)obj;
			Transform transform4 = transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 vector5 = ((Camera)flag).WorldToViewportPoint((Vector3)transform);
			obj = vector.x;
			_ = vector.z;
			_ = 0f;
			UIKeyNavigation uIKeyNavigation = (UIKeyNavigation)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
			((UnityEngine.Object)this).m_CachedPtr = (IntPtr)0;
			return;
		}
		nint num9 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v34 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj12 = (nint)0 & (nint)0x200;
		if (obj12 != null)
		{
			nint num10 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ S0_v63 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)component).FindKernel((string)null) == 0)
		{
			int layer2 = ((GameObject)key).layer;
			((Transform)(object)this).position = (Vector3)layer2;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj14 = default;
		object obj13 = obj14 + 16;
		obj5 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S1_v26+8]");
		_ = 0;
		object obj15 = obj14 + 40;
		obj6 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v31+8]");
		_ = 0;
		nint num11 = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v46 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj16 = (nint)0 & (nint)0x200;
		if (obj16 != null)
		{
			nint num12 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ S0_v58 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((Vector3*)(nint)vector)->x = (float)obj5;
		Vector3 vector6 = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ S0_v26+8]");
		((Vector3*)(nint)vector6)->z = 0f;
		transform = (Transform)obj6;
		Transform transform5 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v28+8]");
		((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
		Vector3 vector7 = vector - (Vector3)transform;
		transform = (Transform)obj2;
		Transform transform6 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
		Vector3 vector8 = (Vector3)transform / 0.5f;
	}

	public virtual void OnKey(KeyCode key)
	{
		//IL_030a: Expected I, but got Obj
		//IL_0320: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_010d: Expected Obj, but got I
		//IL_0389: Expected Obj, but got I4
		//IL_0138: Expected I, but got Obj
		//IL_03b4: Expected I, but got Obj
		//IL_03ca: Expected Obj, but got I
		//IL_01f4: Expected Obj, but got I4
		//IL_022f: Expected I, but got Obj
		//IL_027c: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I
		//IL_02bd: Expected I, but got Obj
		nint num = (nint)typeof(UIPopupList);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIPopupList>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIPopupList);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v77 (Il2CppClass<UIPopupList>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, string[]> dictionary = Localization.dictionary;
		if (dictionary != null)
		{
			return;
		}
		nint num3 = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v71 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int renderedFrameCount = Time.renderedFrameCount;
		if (mLastFrame == renderedFrameCount)
		{
			return;
		}
		int renderedFrameCount2 = Time.renderedFrameCount;
		nint num5 = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v26 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v65 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		mLastFrame = renderedFrameCount2;
		object obj4 = key - 273;
		GameObject gameObject;
		if (key != KeyCode.UpArrow)
		{
			if ((nint)obj4 != 1)
			{
				if ((nint)obj4 == 2)
				{
					gameObject = GetUp();
				}
				else
				{
					gameObject = (((nint)obj4 != 3) ? null : GetRight());
				}
			}
			else
			{
				bool dualState = ((UIPlayAnimation)this).dualState;
				gameObject = (GameObject)dualState;
			}
		}
		else
		{
			gameObject = GetDown();
		}
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S0_v36 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v52 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)gameObject).FindKernel((string)null) == 0)
		{
			return;
		}
		nint num9 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ S0_v43 (Il2CppClass<UICamera>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num10 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v48 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.controllerNavigationObject = gameObject;
	}

	protected virtual void OnClick()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(UIKeyNavigation);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UIKeyNavigation>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UIKeyNavigation);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<UIKeyNavigation>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num3 = ((BetterList<>.CompareFunc)(object)list).EndInvoke((IAsyncResult)this);
	}

	public UIKeyNavigation()
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(NGUITools);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<NGUITools>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(NGUITools);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v19 (Il2CppClass<NGUITools>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		byte[] array = NGUITools.Load((string)(object)onClick);
		if (array == null)
		{
			return;
		}
		nint num3 = (nint)typeof(UICamera);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<UICamera>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UICamera);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S1_v15 (Il2CppClass<UICamera>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		UICamera.controllerNavigationObject = onClick;
	}

	static UIKeyNavigation()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		List<UIKeyBinding> mList = default;
		UIKeyBinding.mList = mList;
	}
}
