using System;
using Cpp2ILInjected;
using UnityEngine;

public abstract class UIRect : MonoBehaviour
{
	[Serializable]
	public class AnchorPoint
	{
		public Transform target;

		public float relative;

		public int absolute;

		[NonSerialized]
		public UIRect rect;

		[NonSerialized]
		public Camera targetCam;

		public AnchorPoint()
		{
		}

		public AnchorPoint(float relative)
		{
			this.relative = relative;
		}

		public void Set(float relative, float absolute)
		{
			//IL_0035: Expected F8, but got I4
			//IL_0087: Expected I4, but got F8
			this.relative = relative;
			float num = absolute + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
			double num2 = Math.Abs((double)num);
			double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
			this.absolute = (int)num3;
		}

		public void Set(Transform target, float relative, float absolute)
		{
			//IL_003f: Expected F8, but got I4
			//IL_0091: Expected I4, but got F8
			this.target = target;
			this.relative = relative;
			float num = absolute + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
			double num2 = Math.Abs((double)num);
			double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
			this.absolute = (int)num3;
		}

		public void SetToNearest(float abs0, float abs1, float abs2)
		{
			SetToNearest(0f, 0.5f, 1f, abs0, abs1, abs2);
		}

		public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
		{
			float num = Math.Abs(abs2);
			float num2 = Math.Abs(abs0);
			float num3 = Math.Abs(abs1);
			if (num2 < num3 && num > num2)
			{
				Set(rel0, abs0);
			}
			else if (num2 > num3 && num > num3)
			{
				Set(rel1, abs1);
			}
			else
			{
				Set(rel2, abs2);
			}
		}

		public unsafe void SetHorizontal(Transform parent, float localPos)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0025: Expected I, but got Obj
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected Obj, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected Obj, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected Obj, but got Unknown
			//IL_017f: Expected Obj, but got I
			//IL_0127: Expected F4, but got I
			//IL_0122: Expected native int or pointer, but got VT
			//IL_0149: Expected F4, but got I
			//IL_0144: Expected native int or pointer, but got VT
			//IL_016a: Expected Obj, but got I
			//IL_00c5: Expected F8, but got I4
			//IL_019a: Expected F8, but got I4
			//IL_027f: Expected I4, but got F8
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			double num9;
			if ((bool)rect)
			{
				UIRect uIRect = rect;
				nint num = (nint)uIRect;
				object obj2 = uIRect + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v6 (Il2CppClass<UIRect>)+124] (should have been resolved before IL gen)");
				object obj4 = default;
				object obj3 = obj4 + 16;
				object obj5 = obj4 + 40;
				object obj6 = obj5 - obj3;
				float num2 = Math.Min(relative, 1f);
				bool flag = relative < 0f;
				float num3 = 0f;
				if (!flag)
				{
					num3 = num2;
				}
				float num4 = (float)obj6 * num3;
				float num5 = (float)obj3 + num4;
				float num6 = localPos - num5;
				float num7 = num6 + 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				double num8 = Math.Abs((double)num7);
				num9 = ((!(num8 < 2147483648.0)) ? (-2147483648.0) : ((double)num7));
			}
			else
			{
				Vector3 position = target.position;
				object obj7;
				if (parent != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
					((Vector3*)(nint)vector)->x = 0f;
					Vector3 vector2 = parent.InverseTransformPoint(vector);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					obj7 = 0;
				}
				float num10 = localPos - (float)obj7;
				float num11 = num10 + 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				double num12 = Math.Abs((double)num11);
				num9 = ((!(num12 < 2147483648.0)) ? (-2147483648.0) : ((double)num11));
			}
			absolute = (int)num9;
		}

		public unsafe void SetVertical(Transform parent, float localPos)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected VT, but got Unknown
			//IL_0025: Expected I, but got Obj
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected Obj, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected Obj, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected Obj, but got Unknown
			//IL_0076: Expected Obj, but got I
			//IL_019c: Expected Obj, but got I
			//IL_0137: Expected F4, but got I
			//IL_0132: Expected native int or pointer, but got VT
			//IL_0166: Expected F4, but got I
			//IL_0161: Expected native int or pointer, but got VT
			//IL_0187: Expected Obj, but got I
			//IL_00d5: Expected F8, but got I4
			//IL_01b7: Expected F8, but got I4
			//IL_02a4: Expected I4, but got F8
			object obj = default;
			Vector3 vector = (Vector3)(obj - 48);
			double num10;
			if ((bool)rect)
			{
				UIRect uIRect = rect;
				nint num = (nint)uIRect;
				object obj2 = uIRect + 104;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v6 (Il2CppClass<UIRect>)+124] (should have been resolved before IL gen)");
				object obj4 = default;
				object obj3 = obj4 + 52;
				object obj5 = obj4 + 28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S3_v17+4]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v26+4]");
				object obj6 = num2 - 0;
				float num3 = Math.Min(relative, 1f);
				bool flag = relative < 0f;
				float num4 = 0f;
				if (!flag)
				{
					num4 = num3;
				}
				float num5 = (float)obj6 * num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S2_v26+4]");
				float num6 = 0f + num5;
				float num7 = localPos - num6;
				float num8 = num7 + 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				double num9 = Math.Abs((double)num8);
				num10 = ((!(num9 < 2147483648.0)) ? (-2147483648.0) : ((double)num8));
			}
			else
			{
				Vector3 position = target.position;
				object obj7;
				if (parent != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
					((Vector3*)(nint)vector)->z = 0f;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
					((Vector3*)(nint)vector)->x = 0f;
					Vector3 vector2 = parent.InverseTransformPoint(vector);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+24]");
					obj7 = 0;
				}
				float num11 = localPos - (float)obj7;
				float num12 = num11 + 0.5f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
				double num13 = Math.Abs((double)num12);
				num10 = ((!(num13 < 2147483648.0)) ? (-2147483648.0) : ((double)num12));
			}
			absolute = (int)num10;
		}

		public Vector3[] GetSides(Transform relativeTo)
		{
			//IL_0045: Expected I, but got Obj
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected Obj, but got Unknown
			bool flag = target != null;
			bool flag2 = !flag;
			Vector3[] result = null;
			if (!flag2)
			{
				if (rect != null)
				{
					UIRect uIRect = rect;
					nint num = (nint)uIRect;
					object obj = uIRect + 104;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ S2_v7 (Il2CppClass<UIRect>)+124] (should have been resolved before IL gen)");
					Vector3[] result2 = default;
					return result2;
				}
				Camera component = target.GetComponent<Camera>();
				bool flag3 = component != null;
				bool flag4 = !flag3;
				result = null;
				if (!flag4)
				{
					Camera component2 = target.GetComponent<Camera>();
					Vector3[] sides = NGUITools.GetSides(component2, relativeTo);
					result = sides;
				}
			}
			return result;
		}
	}

	public enum AnchorUpdate
	{
		OnEnable,
		OnUpdate,
		OnStart
	}

	public AnchorPoint leftAnchor;

	public AnchorPoint rightAnchor;

	public AnchorPoint bottomAnchor;

	public AnchorPoint topAnchor;

	public AnchorUpdate updateAnchors;

	protected GameObject mGo;

	protected Transform mTrans;

	protected BetterList<UIRect> mChildren;

	protected bool mChanged;

	protected bool mStarted;

	protected bool mParentFound;

	[NonSerialized]
	private bool mUpdateAnchors;

	[NonSerialized]
	private int mUpdateFrame;

	[NonSerialized]
	private bool mAnchorsCached;

	[NonSerialized]
	private UIRoot mRoot;

	[NonSerialized]
	private UIRect mParent;

	[NonSerialized]
	private bool mRootSet;

	[NonSerialized]
	protected Camera mCam;

	[NonSerialized]
	public float finalAlpha;

	protected static Vector3[] mSides;

	public GameObject cachedGameObject
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 32;
			if (mGo == null)
			{
				GameObject gameObject = base.gameObject;
				mGo = gameObject;
			}
			return (GameObject)result;
		}
	}

	public Transform cachedTransform
	{
		get
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected Obj, but got Unknown
			object result = this + 36;
			if (mTrans == null)
			{
				Transform transform = base.transform;
				mTrans = transform;
			}
			return (Transform)result;
		}
	}

	public Camera anchorCamera
	{
		get
		{
			if (~(mAnchorsCached ? 1u : 0u) != 0)
			{
				ResetAnchors();
			}
			return mCam;
		}
	}

	public bool isFullyAnchored
	{
		get
		{
			AnchorPoint anchorPoint = leftAnchor;
			bool flag = anchorPoint.target;
			bool flag2 = !flag;
			bool result = false;
			if (!flag2)
			{
				AnchorPoint anchorPoint2 = rightAnchor;
				bool flag3 = anchorPoint2.target;
				bool flag4 = !flag3;
				result = false;
				if (!flag4)
				{
					AnchorPoint anchorPoint3 = topAnchor;
					bool flag5 = anchorPoint3.target;
					bool flag6 = !flag5;
					result = false;
					if (!flag6)
					{
						AnchorPoint anchorPoint4 = bottomAnchor;
						bool flag7 = anchorPoint4.target;
						result = flag7;
					}
				}
			}
			return result;
		}
	}

	public virtual bool isAnchoredHorizontally
	{
		get
		{
			AnchorPoint anchorPoint = leftAnchor;
			if ((bool)anchorPoint.target)
			{
				return true;
			}
			AnchorPoint anchorPoint2 = rightAnchor;
			return anchorPoint2.target;
		}
	}

	public virtual bool isAnchoredVertically
	{
		get
		{
			AnchorPoint anchorPoint = bottomAnchor;
			if ((bool)anchorPoint.target)
			{
				return true;
			}
			AnchorPoint anchorPoint2 = topAnchor;
			return anchorPoint2.target;
		}
	}

	public virtual bool canBeAnchored => true;

	public UIRect parent
	{
		get
		{
			if (~(mParentFound ? 1u : 0u) != 0)
			{
				mParentFound = true;
				Transform transform = cachedTransform;
				Transform trans = transform.parent;
				UIRect uIRect = NGUITools.FindInParents<UIRect>(trans);
				mParent = uIRect;
			}
			return mParent;
		}
	}

	public UIRoot root
	{
		get
		{
			UIRect uIRect2 = default;
			while (true)
			{
				UIRect uIRect = mParent.parent;
				if (!(uIRect != null))
				{
					break;
				}
				uIRect2 = mParent;
			}
			if (~(uIRect2.mRootSet ? 1u : 0u) != 0)
			{
				uIRect2.mRootSet = true;
				Transform trans = mParent.cachedTransform;
				UIRoot uIRoot = NGUITools.FindInParents<UIRoot>(trans);
				uIRect2.mRoot = uIRoot;
			}
			return uIRect2.mRoot;
		}
	}

	public bool isAnchored
	{
		get
		{
			//IL_00ab: Expected I, but got Obj
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Expected Obj, but got Unknown
			AnchorPoint anchorPoint = leftAnchor;
			bool result = default;
			if (!anchorPoint.target)
			{
				AnchorPoint anchorPoint2 = rightAnchor;
				if (!anchorPoint2.target)
				{
					AnchorPoint anchorPoint3 = topAnchor;
					if (!anchorPoint3.target)
					{
						AnchorPoint anchorPoint4 = bottomAnchor;
						bool flag = anchorPoint4.target;
						bool flag2 = !flag;
						result = false;
						if (flag2)
						{
							goto IL_00ef;
						}
					}
				}
			}
			nint num = (nint)this;
			object obj = this + 48;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v42 @ S1_v6 (Il2CppClass<UIRect>)+EC] (should have been resolved before IL gen)");
			goto IL_00ef;
			IL_00ef:
			return result;
		}
	}

	public abstract float alpha { get; set; }

	public abstract Vector3[] localCorners { get; }

	public abstract Vector3[] worldCorners { get; }

	protected unsafe float cameraRayDistance
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01c1: Expected I, but got Obj
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Expected VT, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Expected VT, but got Unknown
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Expected VT, but got Unknown
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Expected VT, but got Unknown
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ca: Expected VT, but got Unknown
			//IL_02d6: Expected native int or pointer, but got VT
			//IL_02ee: Expected I, but got Obj
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Expected VT, but got Unknown
			//IL_0342: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Expected VT, but got Unknown
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Expected VT, but got Unknown
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected VT, but got Unknown
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Expected VT, but got Unknown
			//IL_03dc: Expected native int or pointer, but got VT
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Expected VT, but got Unknown
			//IL_041f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Expected VT, but got Unknown
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0432: Expected Ref, but got Unknown
			//IL_0443: Expected Ref, but got VT
			//IL_0112: Expected F4, but got I
			object obj2 = default;
			object obj = obj2 - 320;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			_ = 0;
			Camera camera = anchorCamera;
			bool flag = camera != null;
			float result = 0f;
			if (flag)
			{
				if (!mCam.orthographic)
				{
					Transform transform = cachedTransform;
					Transform transform2 = mCam.transform;
					Quaternion rotation = transform.rotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					_ = 0;
					nint num = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v44 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+108]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+100]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v45 (Il2CppStaticFields<UnityEngine.Vector3>)+5C]");
					_ = 0;
					_ = Vector3.backVector;
					Quaternion quaternion = (Quaternion)(obj + 144);
					Vector3 vector = (Vector3)(obj + 128);
					Vector3 vector2 = quaternion * vector;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					_ = 0;
					Vector3 position = transform.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+E0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					_ = 0;
					Plane plane = (Plane)(obj + 304);
					Vector3 inNormal = (Vector3)(obj + 112);
					Vector3 inPoint = (Vector3)(obj + 96);
					*(Plane*)(nint)plane = new Plane(inNormal, inPoint);
					Vector3 position2 = transform2.position;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					_ = 0;
					Quaternion rotation2 = transform2.rotation;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
					_ = 0;
					nint num3 = (nint)typeof(Vector3);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v77 (Il2CppClass<UnityEngine.Vector3>)+5C]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+F0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ S0_v78 (Il2CppStaticFields<UnityEngine.Vector3>)+50]");
					_ = 0;
					_ = Vector3.forwardVector;
					Quaternion quaternion2 = (Quaternion)(obj + 80);
					Vector3 vector3 = (Vector3)(obj - -64);
					Vector3 vector4 = quaternion2 * vector3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B8]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+C0]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+B0]");
					_ = 0;
					Ray ray = (Ray)(obj + 280);
					Vector3 origin = (Vector3)(obj + 48);
					Vector3 direction = (Vector3)(obj + 32);
					*(Ray*)(nint)ray = new Ray(origin, direction);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+128]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+120]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+118]");
					_ = 0;
					Plane plane2 = (Plane)(obj + 304);
					Ray ray2 = (Ray)(obj + 8);
					if (((Plane*)plane2)->Raycast(ray2, out *(float*)(obj + 276)))
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+114]");
						result = 0f;
						goto IL_01ae;
					}
				}
				float nearClipPlane = mCam.nearClipPlane;
				float farClipPlane = mCam.farClipPlane;
				float num5 = farClipPlane - nearClipPlane;
				float num6 = num5 * 0.5f;
				result = nearClipPlane + num6;
			}
			goto IL_01ae;
			IL_01ae:
			return result;
		}
	}

	public abstract float CalculateFinalAlpha(int frameID);

	public virtual void Invalidate(bool includeChildren)
	{
		//IL_002d: Expected Obj, but got I4
		//IL_0062: Expected Obj, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected Obj, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		mChanged = true;
		if (!includeChildren)
		{
			return;
		}
		object obj = 0;
		while (true)
		{
			BetterList<UIRect> betterList = mChildren;
			if ((nint)obj < betterList.size)
			{
				object obj2 = obj << 2;
				object obj3 = (object)betterList.buffer + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v11+10]");
				object obj4 = 0;
				object obj5 = obj4;
				object obj6 = obj4 + 96;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v49 @ S2_v5+11C] (should have been resolved before IL gen)");
				object obj7 = obj + 1;
				obj = obj7;
				continue;
			}
			break;
		}
	}

	public virtual Vector3[] GetSides(Transform relativeTo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0096: Expected Obj, but got I4
		//IL_00b8: Expected Obj, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected Obj, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected Obj, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected VT, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected Obj, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 112;
		_ = 0;
		_ = 0;
		Camera camera = anchorCamera;
		if (camera != null)
		{
			float depth = cameraRayDistance;
			return NGUITools.GetSides(mCam, depth, relativeTo);
		}
		Transform transform = cachedTransform;
		Vector3 position = transform.position;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
		_ = 0;
		object obj3 = 0;
		while ((nint)obj3 < 4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+60]");
			obj = 0;
			object obj4 = obj3 * 12;
			object obj5 = (object)mSides + obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			object obj6 = obj3 + 1;
			obj3 = obj6;
		}
		if (relativeTo != null)
		{
			object obj7 = 0;
			while ((nint)obj7 < 4)
			{
				object obj8 = obj7 * 12;
				object obj9 = (object)mSides + obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v26+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S1_v26+10]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+58]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+50]");
				_ = 0;
				Vector3 position2 = (Vector3)(obj + 32);
				Vector3 vector = relativeTo.InverseTransformPoint(position2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+48]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+40]");
				_ = 0;
				object obj10 = obj7 * 12;
				object obj11 = (object)mSides + obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+18]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+10]");
				_ = 0;
				object obj12 = obj7 + 1;
				obj7 = obj12;
			}
		}
		return mSides;
	}

	protected unsafe Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0099: Expected F4, but got I
		//IL_0094: Expected native int or pointer, but got VT
		//IL_00ae: Expected F4, but got I
		//IL_00a9: Expected native int or pointer, but got VT
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected VT, but got Unknown
		//IL_016b: Expected Obj, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected Obj, but got Unknown
		//IL_019d: Expected Obj, but got I
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected Obj, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected VT, but got Unknown
		//IL_02dc: Expected Obj, but got I
		//IL_02ec: Expected Obj, but got I
		//IL_02fc: Expected F4, but got I
		//IL_0337: Expected native int or pointer, but got VT
		//IL_035e: Expected native int or pointer, but got VT
		//IL_0385: Expected native int or pointer, but got VT
		//IL_0257: Expected F4, but got I
		//IL_0252: Expected native int or pointer, but got VT
		//IL_0286: Expected F4, but got I
		//IL_0281: Expected native int or pointer, but got VT
		//IL_02a7: Expected F4, but got I
		//IL_02b7: Expected Obj, but got I
		//IL_02c7: Expected Obj, but got I
		object obj = default;
		Vector3 vector = (Vector3)(obj - 128);
		_ = 0;
		_ = 0;
		Camera camera = anchorCamera;
		Vector3 vector2 = default;
		if (camera == null || ac.targetCam == null)
		{
			Transform transform = cachedTransform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			((Vector3*)(nint)vector2)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			((Vector3*)(nint)vector2)->x = 0f;
		}
		else
		{
			Rect rect = ac.targetCam.rect;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 position = ac.target.position;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			_ = 0;
			Vector3 position2 = vector + 32;
			Vector3 vector3 = ac.targetCam.WorldToViewportPoint(position2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+78]");
			object obj2 = num * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+70]");
			object obj3 = obj2 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+7C]");
			object obj4 = num2 * 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+74]");
			object obj5 = obj4 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+48]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+40]");
			_ = 0;
			Vector3 position3 = vector + 16;
			Vector3 vector4 = mCam.ViewportToWorldPoint(position3);
			float z;
			object obj6;
			object obj7;
			if (trans != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
				((Vector3*)(nint)vector)->x = 0f;
				Vector3 vector5 = trans.InverseTransformPoint(vector);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				obj7 = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+60]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+64]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+68]");
				z = 0f;
			}
			((Vector3*)(nint)vector2)->z = z;
			float x = (float)obj6 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
			((Vector3*)(nint)vector2)->x = x;
			float y = (float)obj7 + 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Floor not resolved\"");
			((Vector3*)(nint)vector2)->y = y;
		}
		return vector2;
	}

	protected virtual void OnEnable()
	{
		//IL_00e6: Expected I, but got Obj
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		mUpdateFrame = -1;
		AnchorPoint anchorPoint = rightAnchor;
		if (anchorPoint.target == null)
		{
			AnchorPoint anchorPoint2 = leftAnchor;
			if (anchorPoint2.target == null)
			{
				AnchorPoint anchorPoint3 = topAnchor;
				if (anchorPoint3.target == null)
				{
					AnchorPoint anchorPoint4 = bottomAnchor;
					if (anchorPoint4.target == null)
					{
						updateAnchors = AnchorUpdate.OnEnable;
					}
				}
			}
		}
		if (updateAnchors == AnchorUpdate.OnEnable)
		{
			mUpdateAnchors = true;
			mAnchorsCached = false;
		}
		if (~(mStarted ? 1u : 0u) == 0)
		{
			nint num = (nint)this;
			object obj = this + 120;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v64 @ S1_v9 (Il2CppClass<UIRect>)+134] (should have been resolved before IL gen)");
		}
		mUpdateFrame = -1;
	}

	protected virtual void OnInit()
	{
		mRootSet = false;
		mChanged = true;
		mParentFound = false;
		UIRect uIRect = parent;
		if (uIRect != null)
		{
			UIRect uIRect2 = mParent;
			uIRect2.mChildren.Add(this);
		}
	}

	protected virtual void OnDisable()
	{
		if ((bool)mParent)
		{
			UIRect uIRect = mParent;
			bool flag = uIRect.mChildren.Remove(this);
		}
		mParent = null;
		mRoot = null;
		mParentFound = false;
		mRootSet = false;
	}

	protected void Start()
	{
		//IL_0010: Expected I, but got Obj
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		//IL_002a: Expected I, but got Obj
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected Obj, but got Unknown
		mStarted = true;
		nint num = (nint)this;
		object obj = this + 120;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v5 @ S1_v3 (Il2CppClass<UIRect>)+134] (should have been resolved before IL gen)");
		nint num2 = (nint)this;
		object obj2 = this + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v15 @ S1_v7 (Il2CppClass<UIRect>)+15C] (should have been resolved before IL gen)");
	}

	public void Update()
	{
		//IL_00be: Expected I, but got Obj
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected Obj, but got Unknown
		if (~(mAnchorsCached ? 1u : 0u) != 0)
		{
			ResetAnchors();
		}
		int frameCount = Time.frameCount;
		if (frameCount != mUpdateFrame)
		{
			if (updateAnchors == AnchorUpdate.OnUpdate || ~(mUpdateAnchors ? 1u : 0u) == 0)
			{
				UpdateAnchorsInternal(frameCount);
			}
			nint num = (nint)this;
			object obj = this + 168;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v46 @ S1_v8 (Il2CppClass<UIRect>)+164] (should have been resolved before IL gen)");
		}
	}

	protected void UpdateAnchorsInternal(int frame)
	{
		//IL_0389: Expected Obj, but got I4
		//IL_003b: Expected Obj, but got I4
		//IL_0111: Expected Obj, but got I4
		//IL_007c: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I4
		//IL_0152: Expected Obj, but got I4
		//IL_009c: Expected Obj, but got I4
		//IL_032a: Expected I, but got Obj
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got I4
		//IL_0172: Expected Obj, but got I4
		//IL_0248: Expected Obj, but got I4
		mUpdateAnchors = false;
		mUpdateFrame = frame;
		AnchorPoint anchorPoint = leftAnchor;
		bool flag = anchorPoint.target;
		bool flag2 = !flag;
		object obj = 0;
		if (!flag2)
		{
			AnchorPoint anchorPoint2 = leftAnchor;
			bool flag3 = anchorPoint2.rect != null;
			bool flag4 = !flag3;
			obj = 1;
			if (!flag4)
			{
				AnchorPoint anchorPoint3 = leftAnchor;
				UIRect rect = anchorPoint3.rect;
				bool flag5 = rect.mUpdateFrame == frame;
				obj = 1;
				if (!flag5)
				{
					rect.Update();
					obj = 1;
				}
			}
		}
		AnchorPoint anchorPoint4 = bottomAnchor;
		if ((bool)anchorPoint4.target)
		{
			AnchorPoint anchorPoint5 = bottomAnchor;
			bool flag6 = anchorPoint5.rect != null;
			bool flag7 = !flag6;
			obj = 1;
			if (!flag7)
			{
				AnchorPoint anchorPoint6 = bottomAnchor;
				UIRect rect2 = anchorPoint6.rect;
				bool flag8 = rect2.mUpdateFrame == frame;
				obj = 1;
				if (!flag8)
				{
					rect2.Update();
					obj = 1;
				}
			}
		}
		AnchorPoint anchorPoint7 = rightAnchor;
		if ((bool)anchorPoint7.target)
		{
			AnchorPoint anchorPoint8 = rightAnchor;
			bool flag9 = anchorPoint8.rect != null;
			bool flag10 = !flag9;
			obj = 1;
			if (!flag10)
			{
				AnchorPoint anchorPoint9 = rightAnchor;
				UIRect rect3 = anchorPoint9.rect;
				bool flag11 = rect3.mUpdateFrame == frame;
				obj = 1;
				if (!flag11)
				{
					rect3.Update();
					obj = 1;
				}
			}
		}
		AnchorPoint anchorPoint10 = topAnchor;
		if ((bool)anchorPoint10.target)
		{
			AnchorPoint anchorPoint11 = topAnchor;
			if (anchorPoint11.rect != null)
			{
				AnchorPoint anchorPoint12 = topAnchor;
				UIRect rect4 = anchorPoint12.rect;
				if (frame != rect4.mUpdateFrame)
				{
					rect4.Update();
				}
			}
		}
		else if (obj == null)
		{
			return;
		}
		nint num = (nint)this;
		object obj2 = this + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v164 @ S1_v14 (Il2CppClass<UIRect>)+144] (should have been resolved before IL gen)");
	}

	public void UpdateAnchors()
	{
		if (isAnchored)
		{
			mUpdateAnchors = true;
			mUpdateFrame = -1;
			int frameCount = Time.frameCount;
			UpdateAnchorsInternal(frameCount);
		}
	}

	public void ForceUpdate()
	{
		mUpdateFrame = -1;
		Update();
	}

	protected abstract void OnAnchor();

	public void SetAnchor(Transform t)
	{
		AnchorPoint anchorPoint = leftAnchor;
		anchorPoint.target = t;
		AnchorPoint anchorPoint2 = rightAnchor;
		anchorPoint2.target = t;
		AnchorPoint anchorPoint3 = topAnchor;
		anchorPoint3.target = t;
		AnchorPoint anchorPoint4 = bottomAnchor;
		anchorPoint4.target = t;
		ResetAnchors();
		UpdateAnchors();
	}

	public void SetAnchor(GameObject go)
	{
		bool flag = go != null;
		bool flag2 = !flag;
		Transform target = null;
		if (!flag2)
		{
			Transform transform = go.transform;
			target = transform;
		}
		AnchorPoint anchorPoint = leftAnchor;
		anchorPoint.target = target;
		AnchorPoint anchorPoint2 = rightAnchor;
		anchorPoint2.target = target;
		AnchorPoint anchorPoint3 = topAnchor;
		anchorPoint3.target = target;
		AnchorPoint anchorPoint4 = bottomAnchor;
		anchorPoint4.target = target;
		ResetAnchors();
		UpdateAnchors();
	}

	public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
	{
		bool flag = go != null;
		bool flag2 = !flag;
		Transform target = null;
		if (!flag2)
		{
			Transform transform = go.transform;
			target = transform;
		}
		AnchorPoint anchorPoint = leftAnchor;
		anchorPoint.target = target;
		AnchorPoint anchorPoint2 = rightAnchor;
		anchorPoint2.target = target;
		AnchorPoint anchorPoint3 = topAnchor;
		anchorPoint3.target = target;
		AnchorPoint anchorPoint4 = bottomAnchor;
		anchorPoint4.target = target;
		AnchorPoint anchorPoint5 = leftAnchor;
		anchorPoint5.relative = 0f;
		AnchorPoint anchorPoint6 = rightAnchor;
		anchorPoint6.relative = 1f;
		AnchorPoint anchorPoint7 = bottomAnchor;
		anchorPoint7.relative = 0f;
		AnchorPoint anchorPoint8 = topAnchor;
		anchorPoint8.relative = 1f;
		anchorPoint5.absolute = left;
		anchorPoint6.absolute = right;
		anchorPoint7.absolute = bottom;
		anchorPoint8.absolute = top;
		ResetAnchors();
		UpdateAnchors();
	}

	public void ResetAnchors()
	{
		mAnchorsCached = true;
		AnchorPoint anchorPoint = leftAnchor;
		UIRect rect;
		if ((bool)anchorPoint.target)
		{
			AnchorPoint anchorPoint2 = leftAnchor;
			rect = anchorPoint2.target.GetComponent<UIRect>();
		}
		else
		{
			rect = null;
		}
		anchorPoint.rect = rect;
		AnchorPoint anchorPoint3 = bottomAnchor;
		UIRect rect2;
		if ((bool)anchorPoint3.target)
		{
			AnchorPoint anchorPoint4 = bottomAnchor;
			rect2 = anchorPoint4.target.GetComponent<UIRect>();
		}
		else
		{
			rect2 = null;
		}
		anchorPoint3.rect = rect2;
		AnchorPoint anchorPoint5 = rightAnchor;
		UIRect rect3;
		if ((bool)anchorPoint5.target)
		{
			AnchorPoint anchorPoint6 = rightAnchor;
			rect3 = anchorPoint6.target.GetComponent<UIRect>();
		}
		else
		{
			rect3 = null;
		}
		anchorPoint5.rect = rect3;
		AnchorPoint anchorPoint7 = topAnchor;
		UIRect rect4;
		if ((bool)anchorPoint7.target)
		{
			AnchorPoint anchorPoint8 = topAnchor;
			rect4 = anchorPoint8.target.GetComponent<UIRect>();
		}
		else
		{
			rect4 = null;
		}
		anchorPoint7.rect = rect4;
		GameObject gameObject = cachedGameObject;
		int layer = gameObject.layer;
		Camera camera = NGUITools.FindCameraForLayer(layer);
		mCam = camera;
		FindCameraFor(leftAnchor);
		FindCameraFor(bottomAnchor);
		FindCameraFor(rightAnchor);
		FindCameraFor(topAnchor);
		mUpdateAnchors = true;
	}

	public void ResetAndUpdateAnchors()
	{
		ResetAnchors();
		UpdateAnchors();
	}

	public abstract void SetRect(float x, float y, float width, float height);

	private void FindCameraFor(AnchorPoint ap)
	{
		if (ap.target == null || ap.rect != null)
		{
			ap.targetCam = null;
			return;
		}
		GameObject gameObject = ap.target.gameObject;
		int layer = gameObject.layer;
		Camera targetCam = NGUITools.FindCameraForLayer(layer);
		ap.targetCam = targetCam;
	}

	public virtual void ParentHasChanged()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected Obj, but got Unknown
		mParentFound = false;
		Transform transform = cachedTransform;
		Transform trans = transform.parent;
		UIRect uIRect = NGUITools.FindInParents<UIRect>(trans);
		if (mParent != uIRect)
		{
			object obj = this + 60;
			if ((bool)(UnityEngine.Object)obj)
			{
				UIRect uIRect2 = mParent;
				bool flag = uIRect2.mChildren.Remove(this);
			}
			obj = uIRect;
			if ((bool)(UnityEngine.Object)obj)
			{
				UIRect uIRect3 = mParent;
				uIRect3.mChildren.Add(this);
			}
			mRootSet = false;
		}
	}

	protected abstract void OnStart();

	protected virtual void OnUpdate()
	{
	}

	protected UIRect()
	{
		AnchorPoint anchorPoint = default;
		leftAnchor = anchorPoint;
		AnchorPoint anchorPoint2 = default;
		anchorPoint2.relative = 1f;
		rightAnchor = anchorPoint2;
		AnchorPoint anchorPoint3 = default;
		bottomAnchor = anchorPoint3;
		AnchorPoint anchorPoint4 = default;
		anchorPoint4.relative = 1f;
		topAnchor = anchorPoint4;
		updateAnchors = AnchorUpdate.OnStart;
		BetterList<UIRect> betterList = default;
		mChildren = betterList;
		finalAlpha = 1f;
		mUpdateFrame = -1;
		mUpdateAnchors = true;
		mChanged = true;
		base._002Ector();
	}

	static UIRect()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22B");
		Vector3[] array = default;
		mSides = array;
	}
}
