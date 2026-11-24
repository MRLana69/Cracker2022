using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using SYBO.Common;
using SYBO.Common.Utilities.Flags;
using UnityEngine;
using UnityEngine.Rendering;

namespace Kiloo.Common.Backend.Cloud;

public sealed class CloudWorkingCopy
{
	private class CommitContext
	{
		public string method;

		public ICloudItem[] modifiedLocalItems;

		public CloudServerCommitResult result;

		public CommitContext()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private class Conflict : ICloudConflict
	{
		private ICloudItem mine__BackingField;

		private ICloudItem theirs__BackingField;

		private ICloudItem resolution__BackingField;

		private CloudConflictResolution resolveMethod__BackingField;

		public string name => (string)(object)theirs__BackingField;

		public ICloudItem mine
		{
			get
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				ICloudItem result = default;
				return result;
			}
			private set
			{
				mine__BackingField = value;
			}
		}

		public ICloudItem theirs
		{
			get
			{
				return mine__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
				obj = value;
			}
		}

		public ICloudItem resolution
		{
			get
			{
				return theirs__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 12;
				obj = value;
			}
		}

		public CloudConflictResolution resolveMethod
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (CloudConflictResolution)resolution__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got I4
				object obj = this + 16;
				obj = value;
			}
		}

		public void ResolveUsingMine()
		{
		}

		public unsafe void ResolveUsingTheirs()
		{
			//IL_0054: Expected F4, but got I
			//IL_004f: Expected native int or pointer, but got VT
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected I4, but got Unknown
			//IL_0094: Expected I4, but got Obj
			//IL_00d9: Expected VT, but got I4
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7571");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Color color = default;
			((Color*)(nint)color)->b = num;
			_ = 0;
			object obj = color + 16;
			obj = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			bool flag = (byte)(obj2 + 16) != 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			GUIStyle gUIStyle = default;
			Rect screenRect = default;
			GUIContent content = default;
			bool hasKeyboardFocus = default;
			bool drawSelectionAsComposition = default;
			int cursorFirst = default;
			int cursorLast = default;
			gUIStyle.Internal_DrawWithTextSelection(screenRect, content, flag, true, false, hasKeyboardFocus, drawSelectionAsComposition, cursorFirst, cursorLast, (Color)1, color);
			object obj3 = this + 16;
			obj3 = gUIStyle;
			resolveMethod__BackingField = CloudConflictResolution.UsingMine;
		}

		public void ResolveWith(byte[] data, ICloudUserData userData)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected Obj, but got Unknown
			ICloudItem cloudItem = (ICloudItem)(data & 1);
			mine__BackingField = cloudItem;
			object obj = this + 12;
			obj = userData;
		}

		public unsafe Conflict(ICloudItem mine, ICloudItem theirs)
		{
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Expected Obj, but got Unknown
			//IL_0075: Expected F4, but got I
			//IL_0070: Expected native int or pointer, but got VT
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Expected Obj, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected I4, but got Unknown
			//IL_00b8: Expected I4, but got Obj
			//IL_00fd: Expected VT, but got I4
			//IL_00fd: Expected I4, but got Obj
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_0108: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 8;
			OverflowException ex = new OverflowException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			object obj3 = default;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7571");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Color color = default;
			((Color*)(nint)color)->b = num;
			_ = 0;
			object obj4 = color + 16;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj5 = default;
			bool flag = (byte)(obj5 + 16) != 0;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj5 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			GUIStyle gUIStyle = default;
			Rect screenRect = default;
			GUIContent content = default;
			bool hasKeyboardFocus = default;
			bool drawSelectionAsComposition = default;
			int cursorFirst = default;
			gUIStyle.Internal_DrawWithTextSelection(screenRect, content, flag, true, false, hasKeyboardFocus, drawSelectionAsComposition, cursorFirst, (int)theirs, (Color)0, color);
			object obj6 = this + 16;
			obj6 = gUIStyle;
			resolveMethod__BackingField = CloudConflictResolution.UsingCustom;
		}

		private Stream _003CResolveUsingMine_003Eb__18_0(LocalItem s)
		{
			//IL_001c: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudServer2._003CCheckAuthenticationCoroutine_003Ed__50 obj = default;
			obj._002Ector((int)s);
			return (Stream)(object)obj;
		}
	}

	public delegate void CompleteHandler(bool success);

	public delegate void SynchronizeCompleteHandler(bool updateSuccess, bool commitSuccess);

	private class ItemMetadata
	{
		private string revision__BackingField;

		private bool isOutOfDate__BackingField;

		private bool isModified__BackingField;

		private int serverDataVersion__BackingField;

		private int pristineCrc32__BackingField;

		private Dictionary<string, string> userData__BackingField;

		public string revision
		{
			get
			{
				//IL_000d: Expected Obj, but got I
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata)+14]");
				return (string)0;
			}
			private set
			{
				throw new InvalidOperationException();
			}
		}

		public DateTime? lastModified
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				DateTime? dateTime = default;
				object obj = (Nullable)dateTime + 8;
				obj = this;
				return dateTime;
			}
			private set
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0028: Expected Obj, but got I
				object obj = (Nullable)value + 16;
				ItemMetadata itemMetadata = (ItemMetadata)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
				revision__BackingField = (string)0;
			}
		}

		public unsafe bool isOutOfDate
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)revision__BackingField != 0;
			}
			private set
			{
				//IL_000d: Expected Obj, but got I4
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected Obj, but got Unknown
				object obj = ((bool*)(value ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
				_ = 0;
				object obj2 = this + 16;
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
			}
		}

		public bool isModified
		{
			get
			{
				return isOutOfDate__BackingField;
			}
			private set
			{
				isOutOfDate__BackingField = value;
			}
		}

		public int serverDataVersion
		{
			get
			{
				return isModified__BackingField ? 1 : 0;
			}
			private set
			{
				int num = value & 1;
				isModified__BackingField = (byte)num != 0;
			}
		}

		public int pristineCrc32
		{
			get
			{
				return serverDataVersion__BackingField;
			}
			private set
			{
				serverDataVersion__BackingField = value;
			}
		}

		public Dictionary<string, string> userData
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (Dictionary<string, string>)pristineCrc32__BackingField;
			}
			private set
			{
				//IL_000a: Expected I4, but got Obj
				pristineCrc32__BackingField = (int)value;
			}
		}

		public unsafe ItemMetadata(string revision = null, DateTime? lastModified = null, bool isOutOfDate = false, bool isModified = false, int serverDataVersion = 0, int pristineCrc32 = 0, Dictionary<string, string> userData = null)
		{
			//IL_0278: Expected I, but got Obj
			//IL_028e: Expected Obj, but got I
			//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b6: Expected Obj, but got Unknown
			//IL_03d9: Expected Obj, but got I
			//IL_03e7: Expected I, but got Obj
			//IL_03fd: Expected Obj, but got I
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Expected Obj, but got Unknown
			//IL_02ed: Expected I, but got Obj
			//IL_0303: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Expected Obj, but got Unknown
			//IL_033b: Expected Obj, but got I4
			//IL_036a: Expected Obj, but got I4
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_039a: Expected Obj, but got Unknown
			//IL_0060: Expected I, but got Obj
			//IL_0124: Expected Obj, but got I4
			//IL_00ad: Expected I, but got Obj
			//IL_0165: Expected I, but got Obj
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Expected Obj, but got Unknown
			//IL_01c1: Expected Obj, but got VT
			//IL_01f5: Expected Obj, but got I4
			//IL_0225: Expected VT, but got Obj
			//IL_0241: Expected Obj, but got I
			//IL_024f: Expected VT, but got Obj
			nint num = (nint)typeof(Quaternion);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Quaternion>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Quaternion);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v79 (Il2CppClass<UnityEngine.Quaternion>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform = default;
			object obj2 = transform + 48;
			Vector2 zero = Vector2.zero;
			ItemMetadata itemMetadata = (ItemMetadata)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v14+8]");
			this.revision__BackingField = (string)0;
			nint num3 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v18 (Il2CppClass<UnityEngine.Vector3>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Vector3);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v75 (Il2CppClass<UnityEngine.Vector3>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj4 = transform + 36;
			Vector3 one = Vector3.one;
			string text = (string)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v23+8]");
			revision.m_stringLength = 0;
			nint num5 = (nint)typeof(Math3D);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27 (Il2CppClass<SYBO.Common.Math3D>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num6 = (nint)typeof(Math3D);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v69 (Il2CppClass<SYBO.Common.Math3D>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Transform transform2 = (Transform)(transform - -64);
			transform2 = (Transform)((bool*)(isModified ? 1 : 0))->m_value;
			Transform transform3 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isModified @ L4 (System.Boolean)+8]");
			((UnityEngine.Object)transform3).m_CachedPtr = (IntPtr)0;
			Quaternion localRotation = transform2.localRotation;
			transform2 = (Transform)((int*)serverDataVersion)->m_value;
			Transform transform4 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [serverDataVersion @ L5 (System.Int32)+8]");
			((UnityEngine.Object)transform4).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition = transform2.localPosition;
			object obj6 = transform + 24;
			Vector3 forward = Vector3.forward;
			transform2 = (Transform)obj6;
			Transform transform5 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S1_v26+8]");
			((UnityEngine.Object)transform5).m_CachedPtr = (IntPtr)0;
			Math3D.tempParent.parent = transform2;
			transform2 = (Transform)((int*)pristineCrc32)->m_value;
			Transform transform6 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [pristineCrc32 @ L6 (System.Int32)+8]");
			((UnityEngine.Object)transform6).m_CachedPtr = (IntPtr)0;
			Quaternion localRotation2 = transform2.localRotation;
			transform2 = (Transform)(object)userData;
			((UnityEngine.Object)transform2).m_CachedPtr = (IntPtr)userData.buckets;
			Vector3 localPosition2 = transform2.localPosition;
			object obj7 = transform + 12;
			Vector3 forward2 = Vector3.forward;
			transform2 = (Transform)obj7;
			Transform transform7 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ S1_v37+8]");
			((UnityEngine.Object)transform7).m_CachedPtr = (IntPtr)0;
			Math3D.tempChild.parent = transform2;
			transform2 = (Transform)lastModified;
			Transform transform8 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [lastModified @ L2 (System.Nullable`1<System.DateTime>)+8]");
			((UnityEngine.Object)transform8).m_CachedPtr = (IntPtr)0;
			Quaternion localRotation3 = transform2.localRotation;
			transform2 = (Transform)((bool*)(isOutOfDate ? 1 : 0))->m_value;
			Transform transform9 = transform2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isOutOfDate @ L3 (System.Boolean)+8]");
			((UnityEngine.Object)transform9).m_CachedPtr = (IntPtr)0;
			Vector3 localPosition3 = transform2.localPosition;
			transform2.rotation = (Quaternion)Math3D.tempChild;
			itemMetadata = (ItemMetadata)(object)transform2;
			this.revision__BackingField = (string)(nint)((UnityEngine.Object)transform2).m_CachedPtr;
			transform.position = (Vector3)Math3D.tempChild;
			text = (string)(object)transform;
			revision.m_stringLength = (int)(nint)((UnityEngine.Object)transform).m_CachedPtr;
		}

		public ItemMetadata(ICloudItem cloudItem, int pristineCrc32 = 0)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_0408: Expected Obj, but got I
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Expected I4, but got Unknown
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected I4, but got Unknown
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_026b: Expected Obj, but got I
			//IL_0337: Expected Obj, but got I
			//IL_02fb: Expected Obj, but got I
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata)+34]");
				object obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
				obj4 = obj2;
			}
			else
			{
				obj4 = this;
				obj3 = 1;
			}
			object obj5 = default;
			object obj23 = default;
			object obj21 = default;
			for (; obj5 != obj3; obj5 = obj23 + 1)
			{
				object obj6 = obj5 << 2;
				object obj7 = obj4 + obj6;
				object obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				int num;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+2A]");
					if ((nint)0 == 2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x3FFF;
						object obj14 = obj13 + 97173;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v115 @ S3_v17 (should have been resolved before IL gen)");
						num = 97173;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x1FFF;
						num = obj15 + 113696;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v164 @ S4_v6 (System.Int32) (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj16 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ S0_v62+9C]");
						object obj17 = (nint)0 & (nint)0x100;
						flag2 = obj17 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+10]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
								object obj18 = (nint)0 & (nint)0x3FFF;
								object obj19 = obj18 + 97173;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v165 @ S3_v12 (should have been resolved before IL gen)");
								num = 97173;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v19+2B]");
							object obj20 = (nint)0 & (nint)3;
							bool flag3 = (nint)obj20 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag3)
							{
								if (obj21 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
								}
							}
							else if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
								num = pristineCrc32;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v14+8]");
				object obj22 = (nint)0 & (nint)0x1FFF;
				num = obj22 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v164 @ S4_v6 (System.Int32) (should have been resolved before IL gen)");
			}
		}

		public ItemMetadata WithRevision(string newRevision)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			ItemMetadata result = default;
			return result;
		}

		public ItemMetadata WithIsOutOfDate(bool newIsOutOfDate)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_00ad: Expected I4, but got Obj
			//IL_00ad: Expected Obj, but got I4
			//IL_00ad: Expected Obj, but got I4
			//IL_00ad: Expected Obj, but got I4
			//IL_00ad: Expected Obj, but got I4
			object obj = this + 16;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4+8]");
			_ = 0;
			bool flag = isOutOfDate__BackingField;
			bool flag2 = isModified__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = (string)(obj2 + 16);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)newIsOutOfDate, text, (string)flag, (string)flag2, (SearchOption)serverDataVersion__BackingField, (System.IO.SearchResultHandler<TSource>)pristineCrc32__BackingField, (byte)(int)userData__BackingField != 0);
			return (ItemMetadata)(object)fileSystemEnumerableIterator;
		}

		public ItemMetadata WithIsModified(bool newIsModified)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected Obj, but got Unknown
			//IL_009b: Expected I4, but got Obj
			//IL_009b: Expected Obj, but got I4
			//IL_009b: Expected Obj, but got I4
			//IL_009b: Expected Obj, but got I4
			object obj = this + 16;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4+8]");
			_ = 0;
			bool flag = isModified__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = (string)(obj2 + 16);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector(revision__BackingField, text, (string)newIsModified, (string)flag, (SearchOption)serverDataVersion__BackingField, (System.IO.SearchResultHandler<TSource>)pristineCrc32__BackingField, (byte)(int)userData__BackingField != 0);
			return (ItemMetadata)(object)fileSystemEnumerableIterator;
		}

		public ItemMetadata WithServerDataVersion(int newServerDataVersion)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected Obj, but got Unknown
			//IL_009b: Expected I4, but got Obj
			//IL_009b: Expected Obj, but got I4
			//IL_009b: Expected Obj, but got I4
			//IL_009b: Expected Obj, but got I4
			object obj = this + 16;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4+8]");
			_ = 0;
			bool flag = isOutOfDate__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = (string)(obj2 + 16);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector(revision__BackingField, text, (string)flag, (string)newServerDataVersion, (SearchOption)serverDataVersion__BackingField, (System.IO.SearchResultHandler<TSource>)pristineCrc32__BackingField, (byte)(int)userData__BackingField != 0);
			return (ItemMetadata)(object)fileSystemEnumerableIterator;
		}

		public ItemMetadata WithUserData(string key, string value)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_00c2: Expected Obj, but got I4
			//IL_00a1: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD51");
			object obj3 = default;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD51");
			object obj4 = default;
			obj2 = obj4;
			object obj5 = obj2 + 16;
			obj5 = obj2;
			object obj6 = obj & 0x3FFFFFFFFFFFFFFFL;
			object obj7 = obj5 & 0x3FFFFFFFFFFFFFFFL;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
			{
				return (ItemMetadata)1;
			}
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7);
			object obj8 = (flag ? 1u : 0u) << 31;
			return (ItemMetadata)(obj8 >> 31);
		}

		public ItemMetadata WithUserData(Dictionary<string, string> newUserData)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Expected Obj, but got Unknown
			//IL_00ad: Expected I4, but got Obj
			//IL_00ad: Expected Obj, but got I4
			//IL_00ad: Expected I4, but got Obj
			//IL_00ad: Expected Obj, but got I4
			//IL_00ad: Expected Obj, but got I4
			object obj = this + 16;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4+8]");
			_ = 0;
			bool flag = isOutOfDate__BackingField;
			bool flag2 = isModified__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = (string)(obj2 + 16);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector(revision__BackingField, text, (string)flag, (string)flag2, (SearchOption)newUserData, (System.IO.SearchResultHandler<TSource>)pristineCrc32__BackingField, (byte)(int)userData__BackingField != 0);
			return (ItemMetadata)(object)fileSystemEnumerableIterator;
		}
	}

	private class LocalItem : ICloudItem
	{
		public delegate Stream GetDataStreamFunction(LocalItem localItem);

		private string name__BackingField;

		private string revision__BackingField;

		private DateTime? lastModified__BackingField;

		private bool isModified__BackingField;

		private bool isOutOfDate__BackingField;

		private string sourceDescription__BackingField;

		private string sourceInstallationId__BackingField;

		private int dataVersion__BackingField;

		private ICloudUserData userData__BackingField;

		private readonly GetDataStreamFunction _getDataStreamFunction;

		public string name
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (string)dataVersion__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 44;
				obj = value;
			}
		}

		public string revision
		{
			get
			{
				return name__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 8;
				obj = value;
			}
		}

		public DateTime? lastModified
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				DateTime? dateTime = default;
				object obj = (Nullable)dateTime + 12;
				obj = this;
				return dateTime;
			}
			private set
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0028: Expected Obj, but got I
				object obj = (Nullable)value + 16;
				LocalItem localItem = (LocalItem)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ S1_v2+8]");
				name__BackingField = (string)0;
			}
		}

		public unsafe bool isModified
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (byte)(int)revision__BackingField != 0;
			}
			private set
			{
				//IL_000d: Expected Obj, but got I4
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Expected Obj, but got Unknown
				object obj = ((bool*)(value ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [value @ L1 (System.Boolean)+8]");
				_ = 0;
				object obj2 = this + 16;
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
			}
		}

		public bool isOutOfDate
		{
			get
			{
				return isModified__BackingField;
			}
			private set
			{
				isModified__BackingField = value;
			}
		}

		public string sourceDescription
		{
			get
			{
				//IL_0019: Expected Obj, but got I4
				bool flag = isOutOfDate__BackingField;
				return (string)flag;
			}
			private set
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected I4, but got Unknown
				bool flag = (byte)(value & 1) != 0;
				isOutOfDate__BackingField = flag;
			}
		}

		public string sourceInstallationId
		{
			get
			{
				return sourceDescription__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				object obj = this + 36;
				obj = value;
			}
		}

		public int dataVersion
		{
			get
			{
				//IL_0007: Expected I4, but got Obj
				return (int)sourceInstallationId__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got I4
				object obj = this + 40;
				obj = value;
			}
		}

		public ICloudUserData userData
		{
			get
			{
				//IL_0007: Expected Obj, but got I4
				return (ICloudUserData)dataVersion__BackingField;
			}
			private set
			{
				//IL_000a: Expected I4, but got Obj
				dataVersion__BackingField = (int)value;
			}
		}

		public bool bytesAreSaved
		{
			get
			{
				//IL_002f: Expected I4, but got Obj
				if (_getDataStreamFunction != null)
				{
					return (byte)(int)_getDataStreamFunction.EndInvoke((IAsyncResult)this) != 0;
				}
				return false;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected Obj, but got Unknown
				//IL_0013: Expected Obj, but got I4
				object obj = this + 48;
				obj = value;
			}
		}

		public Stream GetDataStream()
		{
			return (Stream)userData__BackingField;
		}

		public LocalItem(string name, string revision, DateTime? lastModified, bool isModified, bool isOutOfDate, string sourceDescription, string sourceInstallationId, int dataVersion, ICloudUserData userData, bool bytesAreSaved, GetDataStreamFunction getDataStreamFunction)
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected Obj, but got Unknown
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Expected Obj, but got Unknown
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected Obj, but got Unknown
			//IL_00e1: Expected Obj, but got VT
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected Obj, but got Unknown
			//IL_00f7: Expected Obj, but got I4
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Expected Obj, but got Unknown
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Expected Obj, but got Unknown
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected Obj, but got Unknown
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected Obj, but got Unknown
			//IL_0023: Expected Obj, but got I4
			//IL_0033: Expected Obj, but got VT
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj2 = default;
			object obj = obj2 + 8;
			obj = this;
			object obj3 = userData & 1;
			object obj4 = obj2 + 16;
			obj4 = lastModified;
			object obj5 = obj2 + 20;
			obj5 = isOutOfDate;
			object obj6 = obj2 + 24;
			obj6 = sourceDescription;
			object obj7 = sourceInstallationId & 1;
			int num = dataVersion & 1;
			object obj8 = obj2 + 32;
			obj8 = getDataStreamFunction;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+1D]");
			if ((nint)0 != 0)
			{
				((CharacterCustomization)this).DestroyMaterials();
			}
			object obj9 = this + 16;
			obj9 = isModified;
			((Renderer)this.lastModified__BackingField).shadowCastingMode = ShadowCastingMode.Off;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+D]");
			bool asynchronous = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			_ = 0;
			Action<Material> action = default;
			object obj10 = action + 16;
			obj10 = obj2;
			CharacterMaterial.RequestMaterial(name, revision, asynchronous, action);
		}
	}

	private class Metadata
	{
		public string kilooTag;

		public Dictionary<string, ItemMetadata> items;

		public Metadata()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = items;
			_ = 2;
		}
	}

	private class UpdateContext
	{
		public string method;

		public CloudConflictResolver conflictResolver;

		public ICloudItem[] localItemsWithRevisionIds;

		public CloudServerResult result;

		public List<ICloudConflict> conflicts;

		public List<ICloudItem> saveItems;

		public List<CloudItemUpdatedArgs> itemUpdatedEventArgs;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, ItemMetadata>, _003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>> _003C_003E9__29_0;

		public static Func<KeyValuePair<string, ItemMetadata>, _003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>> _003C_003E9__67_0;

		public static Func<_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>, bool> _003C_003E9__67_1;

		public static Func<ICloudConflict, bool> _003C_003E9__69_0;

		public static Func<KeyValuePair<string, ItemMetadata>, bool> _003C_003E9__72_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			CloudServer2._003C_003Ec obj = default;
			CloudServer2._003C_003Ec._003C_003E9 = obj;
		}

		internal _003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata> _003CGetItems_003Eb__29_0(KeyValuePair<string, ItemMetadata> entry)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected Obj, but got Unknown
			//IL_00cb: Expected I4, but got VT
			//IL_00cb: Expected Obj, but got I
			//IL_00cb: Expected Obj, but got I4
			//IL_00cb: Expected Obj, but got I4
			//IL_00cb: Expected Obj, but got I
			object obj = this + 16;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v4+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c)+20]");
			bool flag = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c)+21]");
			bool flag2 = (nint)0 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string text = (string)(obj2 + 16);
			text = (string)obj2;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c)+8]");
			nint num = 0;
			string normalizedSearchPath = text;
			bool flag3 = flag;
			bool flag4 = flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c)+24]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c)+28]");
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)num, normalizedSearchPath, (string)flag3, (string)flag4, (SearchOption)num2, (System.IO.SearchResultHandler<TSource>)0, (byte)(int)entry != 0);
			return (_003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>)(object)fileSystemEnumerableIterator;
		}

		internal _003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata> _003CPrepareUpdateContext_003Eb__67_0(KeyValuePair<string, ItemMetadata> element)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_001b: Expected Obj, but got VT
			//IL_002d: Expected Obj, but got VT
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected VT, but got Unknown
			//IL_0043: Expected VT, but got Obj
			//IL_005c: Expected Obj, but got I
			object obj2 = default;
			object obj = obj2 + 8;
			obj = element;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			obj2 = element;
			KeyValuePair<string, ItemMetadata> keyValuePair = (KeyValuePair<string, ItemMetadata>)(obj2 + 16);
			keyValuePair = (KeyValuePair<string, ItemMetadata>)obj2;
			KeyValuePair<string, ItemMetadata> entry = keyValuePair;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata> obj3 = default;
			((_003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>)(object)obj3)._002Ector(entry, (ItemMetadata)0);
			return obj3;
		}

		internal bool _003CPrepareUpdateContext_003Eb__67_1(_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata> _003C_003Eh__TransparentIdentifier0)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected Obj, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected VT, but got Unknown
			//IL_0043: Expected VT, but got Obj
			//IL_005c: Expected Obj, but got I
			//IL_005c: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 + 8;
			obj = _003C_003Eh__TransparentIdentifier0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			obj2 = _003C_003Eh__TransparentIdentifier0;
			KeyValuePair<string, ItemMetadata> keyValuePair = (KeyValuePair<string, ItemMetadata>)(obj2 + 16);
			keyValuePair = (KeyValuePair<string, ItemMetadata>)obj2;
			bool flag2 = default;
			bool flag = flag2;
			KeyValuePair<string, ItemMetadata> element = keyValuePair;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+4]");
			((_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>)flag)._002Ector(element, (ItemMetadata)0);
			return flag2;
		}

		internal bool _003CApplyUpdate_003Eb__69_0(ICloudConflict conflict)
		{
			//IL_003f: Expected Obj, but got I
			//IL_004f: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [conflict @ L1 (Kiloo.Common.Backend.Cloud.ICloudConflict)+10]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v8+8]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v9+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}

		internal bool _003CPrepareCommitContext_003Eb__72_0(KeyValuePair<string, ItemMetadata> entry)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			return obj != null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public UpdateContext context;

		internal void _003CUpdateCoroutine_003Eb__0(CloudServerResult result)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = result & 1;
		}
	}

	private sealed class _003CUpdateCoroutine_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudWorkingCopy _003C_003E4__this;

		public CloudConflictResolver conflictResolver;

		public bool calledFromSynchronize;

		private _003C_003Ec__DisplayClass70_0 _003C_003E8__1;

		public CompleteHandler completeHandler;

		private bool _003Csuccess_003E5__2;

		private List<ICloudConflict>.Enumerator _003C_003E7__wrap2;

		private ICloudConflict _003Cconflict_003E5__4;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0835: Unknown result type (might be due to invalid IL or missing references)
				//IL_083a: Expected Obj, but got Unknown
				//IL_0843: Unknown result type (might be due to invalid IL or missing references)
				//IL_0848: Expected I, but got Unknown
				//IL_0850: Expected I, but got Obj
				//IL_08a2: Expected Obj, but got I4
				//IL_0232: Expected Obj, but got I4
				//IL_034c: Expected Obj, but got I4
				//IL_08ed: Expected Obj, but got I4
				//IL_044f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0454: Expected Obj, but got Unknown
				//IL_035a: Expected Obj, but got I4
				//IL_0920: Unknown result type (might be due to invalid IL or missing references)
				//IL_0925: Expected Obj, but got Unknown
				//IL_092e: Expected Obj, but got I4
				//IL_093a: Expected Obj, but got I4
				//IL_0303: Unknown result type (might be due to invalid IL or missing references)
				//IL_0308: Expected I, but got Unknown
				//IL_0310: Expected I, but got Obj
				//IL_0333: Expected Obj, but got I4
				//IL_0691: Expected Obj, but got I4
				//IL_054e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0553: Expected Obj, but got Unknown
				//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b6: Expected Obj, but got Unknown
				//IL_0758: Expected Obj, but got I4
				//IL_06f6: Expected Obj, but got I4
				//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f8: Expected Obj, but got Unknown
				//IL_0509: Expected Obj, but got I4
				//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_03f3: Expected Obj, but got Unknown
				//IL_03fc: Expected Obj, but got I4
				//IL_0410: Expected Obj, but got I4
				//IL_041c: Expected Obj, but got I4
				//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
				//IL_05d9: Expected I4, but got Unknown
				//IL_05ed: Expected Obj, but got I4
				//IL_0585: Expected Obj, but got I4
				//IL_07e9: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				nint num = (nint)(obj2 + 16);
				num = (nint)obj;
				_ = -1;
				CloudWorkingCopy cloudWorkingCopy = _003C_003E4__this;
				object obj4;
				object obj8 = default;
				object obj9 = default;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -3;
							obj4 = 29;
						}
						else
						{
							obj4 = 50;
						}
					}
					else
					{
						_003C_003E1__state = -1;
						if (~(cloudWorkingCopy._abortUpdate ? 1u : 0u) == 0)
						{
							obj4 = 41;
						}
						else
						{
							_003C_003Ec__DisplayClass70_0 obj5 = _003C_003E8__1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							object obj6 = default;
							if (obj6 != null)
							{
								_003C_003Ec__DisplayClass70_0 obj7 = _003C_003E8__1;
								UpdateContext context = obj7.context;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								obj3 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
								_ = 0;
								nint num2 = (nint)(this + 40);
								num2 = (nint)obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
								_ = 0;
								_003C_003E1__state = -3;
								obj4 = 34;
							}
							else
							{
								obj4 = 41;
							}
						}
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					obj8 = obj9;
					object obj11 = default;
					object obj10 = obj11;
					obj4 = 47;
				}
				object obj12 = obj4;
				object obj13 = default;
				object result = default;
				object obj17 = default;
				object obj20 = default;
				object obj24 = default;
				object obj27 = default;
				object obj28 = default;
				object obj29 = default;
				object obj30 = default;
				while (true)
				{
					if ((nint)obj12 == 29)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj13 == null && ~(cloudWorkingCopy._abortUpdate ? 1u : 0u) != 0)
						{
							object obj14 = this + 12;
							obj14 = 0;
							_003C_003E1__state = 2;
							result = 1;
							obj12 = 50;
						}
						else
						{
							object obj15 = this + 56;
							obj15 = 0;
							obj12 = 34;
						}
					}
					else if ((nint)obj12 == 34)
					{
						object obj16 = this + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						if (obj17 != null)
						{
							object obj18 = this + 40;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj19 = this + 56;
							obj19 = obj20;
							object obj21 = 29;
							obj12 = obj21;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj22 = this + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						if (~(cloudWorkingCopy._abortUpdate ? 1u : 0u) == 0)
						{
							obj12 = 41;
							continue;
						}
						_003C_003Ec__DisplayClass70_0 obj23 = _003C_003E8__1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						bool flag = (byte)(obj24 & 1) != 0;
						_003Csuccess_003E5__2 = flag;
						object obj25 = 41;
						obj12 = obj25;
					}
					else if ((nint)obj12 == 41)
					{
						cloudWorkingCopy._abortUpdate = false;
						cloudWorkingCopy._isUpdating = false;
						_003C_003Ec__DisplayClass70_0 obj26 = _003C_003E8__1;
						UpdateContext context2 = obj26.context;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj8 = obj9;
						object obj10 = obj27;
						obj12 = 47;
					}
					else if ((nint)obj12 == 42)
					{
						if (completeHandler == null)
						{
							result = null;
							obj12 = 50;
							continue;
						}
						bool flag2 = _003Csuccess_003E5__2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj8 = obj9;
						object obj10 = obj28;
						obj12 = 47;
					}
					else if ((nint)obj12 == 47)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
						if (obj8 != obj29)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						_003C_003Em__Finally1();
						if (obj30 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
							break;
						}
						result = null;
						obj12 = 50;
					}
					else if ((nint)obj12 == 50)
					{
						return result;
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CUpdateCoroutine_003Ed__70(int _003C_003E1__state)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0018: Expected Obj, but got I4
			object obj = this._003C_003E1__state + 20;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<UpdateCoroutine>d__70)+34]");
			return (nint)0 != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_002c: Expected Obj, but got I4
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected Obj, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Obj, but got Unknown
			//IL_0129: Expected Obj, but got I4
			//IL_0178: Expected Obj, but got I
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Expected Obj, but got Unknown
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 == 4 || (nint)obj3 != 5))
			{
				return;
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 26;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 26)
			{
				object obj10 = obj + 4;
				if ((nint)obj10 > -1)
				{
					object obj11 = obj10 + -1;
					obj10 = obj11;
				}
			}
		}

		void IEnumerator.Reset()
		{
			_003C_003E1__state = -1;
		}
	}

	private sealed class _003C_003Ec__DisplayClass74_0
	{
		public CommitContext context;

		internal void _003CCommitCoroutine_003Eb__0(CloudServerCommitResult result)
		{
			context = (CommitContext)(object)result;
		}
	}

	private sealed class _003CCommitCoroutine_003Ed__74 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudWorkingCopy _003C_003E4__this;

		public bool calledFromSynchronize;

		private _003C_003Ec__DisplayClass74_0 _003C_003E8__1;

		public CompleteHandler completeHandler;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_019f: Expected I4, but got Obj
				//IL_0119: Unknown result type (might be due to invalid IL or missing references)
				//IL_011e: Expected Obj, but got Unknown
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0133: Expected Obj, but got Unknown
				//IL_01f6: Expected Obj, but got I4
				//IL_0171: Expected Obj, but got I4
				CloudWorkingCopy cloudWorkingCopy = _003C_003E4__this;
				bool flag2;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass74_0 obj = _003C_003E8__1;
					bool flag = _003C_003E4__this.Commit((byte)(int)obj.context != 0);
					cloudWorkingCopy._isCommitting = false;
					flag2 = flag;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj2 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj3 = default;
					obj2 = obj3;
					object obj4 = _003C_003E8__1 + 8;
					bool flag3 = calledFromSynchronize;
					IEnumerator enumerator = _003C_003E4__this.CommitCoroutine((CompleteHandler)(object)"CommitAsync", flag3);
					obj4 = enumerator;
					_003C_003Ec__DisplayClass74_0 obj5 = _003C_003E8__1;
					if (obj5.context != null)
					{
						cloudWorkingCopy._isCommitting = true;
						Metadata meta = cloudWorkingCopy._meta;
						_003C_003Ec__DisplayClass74_0 obj6 = _003C_003E8__1;
						CommitContext context = obj6.context;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num = 0;
						_ = 0;
						object obj8 = default;
						object obj7 = obj8 + 16;
						obj7 = _003C_003E8__1;
						object obj9 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BDB");
						object obj10 = default;
						obj9 = obj10;
						_003C_003E1__state = 1;
						return 1;
					}
					flag2 = false;
				}
				if (completeHandler != null)
				{
					completeHandler.EndInvoke((IAsyncResult)flag2);
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CCommitCoroutine_003Ed__74(int _003C_003E1__state)
		{
			//IL_0010: Expected Obj, but got I4
			//IL_0018: Expected Obj, but got I4
			object obj = this._003C_003E1__state + 16;
			obj = _003C_003E1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public CommitContext context;

		public _003C_003Ec__DisplayClass77_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CUpdateMetadataCoroutine_003Eb__0(CloudServerResult result)
		{
			context = (CommitContext)(object)result;
		}
	}

	private sealed class _003CUpdateMetadataCoroutine_003Ed__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudWorkingCopy _003C_003E4__this;

		private _003C_003Ec__DisplayClass77_0 _003C_003E8__1;

		public CompleteHandler completeHandler;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_0170: Expected I4, but got Obj
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ef: Expected Obj, but got Unknown
				//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0104: Expected Obj, but got Unknown
				//IL_01c7: Expected Obj, but got I4
				//IL_0142: Expected Obj, but got I4
				CloudWorkingCopy cloudWorkingCopy = _003C_003E4__this;
				bool flag2;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
					_003C_003Ec__DisplayClass77_0 obj = _003C_003E8__1;
					bool flag = _003C_003E4__this.Commit((byte)(int)obj.context != 0);
					cloudWorkingCopy._isMetadataUpdating = false;
					flag2 = flag;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj2 = this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj3 = default;
					obj2 = obj3;
					object obj4 = _003C_003E8__1 + 8;
					IEnumerator enumerator = _003C_003E4__this.UpdateMetadataCoroutine((CompleteHandler)(object)"UpdateMetadataAsync");
					obj4 = enumerator;
					_003C_003Ec__DisplayClass77_0 obj5 = _003C_003E8__1;
					if (obj5.context != null)
					{
						cloudWorkingCopy._isMetadataUpdating = true;
						Metadata meta = cloudWorkingCopy._meta;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num = 0;
						_ = 0;
						object obj7 = default;
						object obj6 = obj7 + 16;
						obj6 = _003C_003E8__1;
						object obj8 = this + 12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
						object obj9 = default;
						obj8 = obj9;
						_003C_003E1__state = 1;
						return 1;
					}
					flag2 = false;
				}
				if (completeHandler != null)
				{
					completeHandler.EndInvoke((IAsyncResult)flag2);
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CUpdateMetadataCoroutine_003Ed__77(int _003C_003E1__state)
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected Obj, but got Unknown
			//IL_003a: Expected Obj, but got I
			//IL_005a: Expected Obj, but got I
			//IL_006a: Expected Obj, but got I
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected Obj, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected Obj, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected Obj, but got Unknown
			//IL_00be: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>1__state @ L1 (System.Int32)+8]");
			_ = 0;
			object obj2 = default;
			object obj = obj2 + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [<>1__state @ L1 (System.Int32)+C]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S4_v2 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S4_v3+60]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S5_v4 (should have been resolved before IL gen)");
			object obj8 = obj2 + 16;
			object obj9 = default;
			obj8 = obj9;
			object obj10 = this._003C_003E1__state + 16;
			obj10 = obj2;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass78_0
	{
		public bool updateSuccess;

		public bool commitSuccess;

		public _003C_003Ec__DisplayClass78_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CSynchronizeCoroutine_003Eb__0(bool success)
		{
			updateSuccess = success;
		}

		internal void _003CSynchronizeCoroutine_003Eb__1(bool success)
		{
			updateSuccess = success;
		}
	}

	private sealed class _003CSynchronizeCoroutine_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CloudWorkingCopy _003C_003E4__this;

		public CloudConflictResolver conflictResolver;

		private _003C_003Ec__DisplayClass78_0 _003C_003E8__1;

		public SynchronizeCompleteHandler completeHandler;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_0182: Unknown result type (might be due to invalid IL or missing references)
				//IL_0187: Expected Obj, but got Unknown
				//IL_0197: Unknown result type (might be due to invalid IL or missing references)
				//IL_019c: Expected Obj, but got Unknown
				//IL_01b4: Expected Obj, but got I4
				//IL_01e6: Expected Obj, but got I4
				//IL_026d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0272: Expected Obj, but got Unknown
				//IL_0282: Unknown result type (might be due to invalid IL or missing references)
				//IL_0287: Expected Obj, but got Unknown
				//IL_0299: Expected Obj, but got I4
				//IL_02cb: Expected Obj, but got I4
				CloudWorkingCopy cloudWorkingCopy = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							return null;
						}
						_003C_003E1__state = -1;
					}
					else
					{
						_003C_003E1__state = -1;
						_003C_003Ec__DisplayClass78_0 obj = _003C_003E8__1;
						if (~(obj.updateSuccess ? 1u : 0u) == 0 && ~(cloudWorkingCopy._abortSynchronize ? 1u : 0u) != 0 && cloudWorkingCopy.isOutOfDate)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint method_ptr = 0;
							CloudConflictResolver cloudConflictResolver = default;
							((Delegate)cloudConflictResolver).method_ptr = method_ptr;
							((Delegate)cloudConflictResolver).method = (nint)__ldftn(_003C_003Ec__DisplayClass78_0._003CSynchronizeCoroutine_003Eb__1);
							object obj2 = cloudConflictResolver + 16;
							obj2 = _003C_003E8__1;
							object obj3 = this + 12;
							IEnumerator list = cloudWorkingCopy.SynchronizeCoroutine(cloudConflictResolver, (SynchronizeCompleteHandler)1);
							Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
							obj3 = coroutine;
							_003C_003E1__state = 2;
							return 1;
						}
						_003C_003Ec__DisplayClass78_0 obj4 = _003C_003E8__1;
						obj4.commitSuccess = true;
					}
					cloudWorkingCopy._isSynchronizing = false;
					cloudWorkingCopy._abortSynchronize = false;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj5 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj6 = default;
					obj5 = obj6;
					_003C_003Ec__DisplayClass78_0 obj7 = _003C_003E8__1;
					obj7.updateSuccess = false;
					_003C_003Ec__DisplayClass78_0 obj8 = _003C_003E8__1;
					obj8.commitSuccess = false;
					if (~(cloudWorkingCopy._isUpdating ? 1u : 0u) != 0 && ~(cloudWorkingCopy._isCommitting ? 1u : 0u) != 0 && ~(cloudWorkingCopy._isMetadataUpdating ? 1u : 0u) != 0 && !cloudWorkingCopy._isSynchronizing)
					{
						cloudWorkingCopy._isSynchronizing = true;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint method_ptr2 = 0;
						AsyncCallback asyncCallback = default;
						((Delegate)asyncCallback).method_ptr = method_ptr2;
						((Delegate)asyncCallback).method = (nint)__ldftn(_003C_003Ec__DisplayClass78_0._003CSynchronizeCoroutine_003Eb__0);
						object obj9 = asyncCallback + 16;
						obj9 = _003C_003E8__1;
						object obj10 = this + 12;
						IAsyncResult list2 = ((CloudConflictResolver)(object)cloudWorkingCopy).BeginInvoke((ICloudConflict[])(object)conflictResolver, asyncCallback, (object)1);
						Coroutine coroutine2 = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list2);
						obj10 = coroutine2;
						_003C_003E1__state = 1;
						return 1;
					}
					Log("SynchronizeAsync: Cannot synchronize while another update or commit operation is running.");
				}
				if (completeHandler != null)
				{
					_003C_003Ec__DisplayClass78_0 obj11 = _003C_003E8__1;
					bool updateSuccess = obj11.updateSuccess;
					_003C_003Ec__DisplayClass78_0 obj12 = _003C_003E8__1;
					bool commitSuccess = obj12.commitSuccess;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CSynchronizeCoroutine_003Ed__78(int _003C_003E1__state)
		{
			int num = _003C_003E1__state & 1;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got Obj
			return (byte)(int)_003C_003E2__current != 0;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private EventHandler<CloudItemUpdatedArgs> m_itemUpdated;

	private string sourceDescription__BackingField;

	private const string METADATA_FILE = ".cloudsave";

	private readonly ICloudServer _cloudServer;

	private readonly IFileSaver _fileSaver;

	private readonly string _installationId;

	private readonly int _dataVersion;

	private readonly string _rootDir;

	private readonly string _metadataFile;

	private Metadata _meta;

	private bool _abortUpdate;

	private bool _abortSynchronize;

	private bool _isMetadataUpdating;

	private bool _isUpdating;

	private bool _isCommitting;

	private bool _isSynchronizing;

	public bool isSynchronizing
	{
		get
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			bool result = default;
			return result;
		}
	}

	public bool isModified
	{
		get
		{
			if (~(_isUpdating ? 1u : 0u) == 0)
			{
				return true;
			}
			if (~(_isCommitting ? 1u : 0u) == 0)
			{
				return true;
			}
			if (~(_isMetadataUpdating ? 1u : 0u) == 0)
			{
				return true;
			}
			return _isSynchronizing;
		}
	}

	public bool isOutOfDate
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Expected Obj, but got Unknown
			//IL_0309: Expected Obj, but got I4
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Expected Obj, but got Unknown
			//IL_032c: Expected Obj, but got I4
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Expected Obj, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected Obj, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected Obj, but got Unknown
			//IL_012f: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got I
			//IL_025d: Expected Obj, but got I
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I4
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected Obj, but got Unknown
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected Obj, but got Unknown
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			Metadata meta = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v102+21]");
					if ((nint)0 != 0)
					{
						object obj7 = obj5 + 4;
						object obj8 = obj7 + 1;
						obj7 = obj8;
						object obj9 = obj8 << 2;
						object obj10 = obj5 + obj9;
						obj10 = 72;
						break;
					}
					continue;
				}
				object obj11 = obj5 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj5 + obj13;
				obj14 = 70;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj5 + obj15;
				if ((nint)obj16 == 72)
				{
					object obj17 = obj5 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					goto IL_040f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj19 = (nint)0 << 2;
				object obj20 = obj5 + obj19;
				if ((nint)obj20 == 70)
				{
					object obj21 = obj5 + 4;
					if ((nint)obj21 > -1)
					{
						object obj22 = obj21 + -1;
						obj21 = obj22;
					}
					goto IL_040f;
				}
			}
			object obj23 = default;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_040f;
			IL_040f:
			return true;
		}
	}

	public bool isIncompatible
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Expected Obj, but got Unknown
			//IL_0309: Expected Obj, but got I4
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Expected Obj, but got Unknown
			//IL_032c: Expected Obj, but got I4
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033a: Expected Obj, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected Obj, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected Obj, but got Unknown
			//IL_012f: Expected Obj, but got I4
			//IL_0196: Expected Obj, but got I
			//IL_025d: Expected Obj, but got I
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected Obj, but got Unknown
			//IL_00c3: Expected Obj, but got I4
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected Obj, but got Unknown
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected Obj, but got Unknown
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d6: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			Metadata meta = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v102+20]");
					if ((nint)0 != 0)
					{
						object obj7 = obj5 + 4;
						object obj8 = obj7 + 1;
						obj7 = obj8;
						object obj9 = obj8 << 2;
						object obj10 = obj5 + obj9;
						obj10 = 72;
						break;
					}
					continue;
				}
				object obj11 = obj5 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj5 + obj13;
				obj14 = 70;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj5 + obj15;
				if ((nint)obj16 == 72)
				{
					object obj17 = obj5 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					goto IL_040f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj19 = (nint)0 << 2;
				object obj20 = obj5 + obj19;
				if ((nint)obj20 == 70)
				{
					object obj21 = obj5 + 4;
					if ((nint)obj21 > -1)
					{
						object obj22 = obj21 + -1;
						obj21 = obj22;
					}
					goto IL_040f;
				}
			}
			object obj23 = default;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_040f;
			IL_040f:
			return true;
		}
	}

	public bool isAccountMismatch
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Expected Obj, but got Unknown
			//IL_030d: Expected Obj, but got I4
			//IL_0322: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Expected Obj, but got Unknown
			//IL_0330: Expected Obj, but got I4
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Expected Obj, but got Unknown
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Expected Obj, but got Unknown
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Expected Obj, but got Unknown
			//IL_0133: Expected Obj, but got I4
			//IL_019a: Expected Obj, but got I
			//IL_0261: Expected Obj, but got I
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected Obj, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Expected Obj, but got Unknown
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected Obj, but got Unknown
			//IL_00c7: Expected Obj, but got I4
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected Obj, but got Unknown
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Expected Obj, but got Unknown
			//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 40;
			obj3 = 0;
			_ = 0;
			_ = 0;
			object obj4 = obj2 + 24;
			obj4 = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			Metadata meta = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ S0_v102+24]");
					if ((nint)0 > (nint)_dataVersion)
					{
						object obj7 = obj5 + 4;
						object obj8 = obj7 + 1;
						obj7 = obj8;
						object obj9 = obj8 << 2;
						object obj10 = obj5 + obj9;
						obj10 = 78;
						break;
					}
					continue;
				}
				object obj11 = obj5 + 4;
				object obj12 = obj11 + 1;
				obj11 = obj12;
				object obj13 = obj12 << 2;
				object obj14 = obj5 + obj13;
				obj14 = 76;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj15 = (nint)0 << 2;
				object obj16 = obj5 + obj15;
				if ((nint)obj16 == 78)
				{
					object obj17 = obj5 + 4;
					if ((nint)obj17 > -1)
					{
						object obj18 = obj17 + -1;
						obj17 = obj18;
					}
					goto IL_0413;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj19 = (nint)0 << 2;
				object obj20 = obj5 + obj19;
				if ((nint)obj20 == 76)
				{
					object obj21 = obj5 + 4;
					if ((nint)obj21 > -1)
					{
						object obj22 = obj21 + -1;
						obj21 = obj22;
					}
					goto IL_0413;
				}
			}
			object obj23 = default;
			if (obj23 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0413;
			IL_0413:
			return true;
		}
	}

	public string kilooTag
	{
		get
		{
			//IL_0063: Expected Obj, but got I4
			Metadata meta = _meta;
			if (meta.kilooTag != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj = default;
				if (obj != null)
				{
					Metadata meta2 = _meta;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					int index = default;
					char c = meta2.kilooTag.get_Chars(index);
					return (string)c;
				}
				return null;
			}
			return null;
		}
	}

	public string sourceDescription
	{
		get
		{
			Metadata meta = _meta;
			return meta.kilooTag;
		}
		set
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_itemUpdated;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)(object)value);
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

	public event EventHandler<CloudItemUpdatedArgs> itemUpdated
	{
		add
		{
			//IL_0074: Expected I, but got Obj
			//IL_008a: Expected Obj, but got I
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected Obj, but got Unknown
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.StringComparer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(StringComparer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<System.StringComparer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E25");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Dictionary<string, string> dictionary = default;
			IEqualityComparer<string> comparer = default;
			dictionary._002Ector((IDictionary<string, string>)(object)value, comparer);
			object obj2 = this + 8;
			obj2 = dictionary;
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_itemUpdated;
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

	public CloudWorkingCopy(int dataVersion, string rootDir, ICloudServer cloudServer, IFileSaver fileSaver, string installationId)
	{
		//IL_00ef: Expected I, but got Obj
		//IL_0105: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!DeviceUtility.IsSupportedOnPlatform())
		{
			return;
		}
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v14 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v19 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8947");
	}

	public void Add(string file)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 12;
		obj = file;
	}

	public void SetUserData(string file, string key, string value)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_0044: Expected Obj, but got F4
		//IL_004f: Expected Obj, but got I4
		object obj = this + 8;
		obj = file;
		object obj2 = this + 12;
		obj2 = key;
		object obj3 = this + 16;
		obj3 = value;
		_fileSaver = (IFileSaver)0f;
		_installationId = (string)256;
		_dataVersion = 6;
	}

	public void SetUserData(string file, Dictionary<string, string> userData)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
	}

	public unsafe void SetUserData(string file, ICloudUserData userData)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Ref, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00ed: Expected Obj, but got I4
		//IL_00a4: Expected I4, but got Obj
		//IL_00a4: Expected Obj, but got I4
		//IL_0013: Expected VT, but got Obj
		//IL_015e: Expected Obj, but got I
		//IL_016e: Expected Obj, but got I
		//IL_017e: Expected Obj, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected Obj, but got Unknown
		object obj = default;
		string text = (string)(obj + 32);
		ref ItemMetadata reference = ref *(ItemMetadata*)(obj + 48);
		reference = ref *(ItemMetadata*)null;
		object obj2 = obj + 16;
		obj2 = 0;
		_ = 0;
		string filePathFromItemName = GetFilePathFromItemName(file);
		Metadata meta = _meta;
		if (meta.items.TryGetValue(filePathFromItemName, out reference))
		{
			_003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata> obj3 = ((_003C_003Ec)(object)reference)._003CGetItems_003Eb__29_0((KeyValuePair<string, ItemMetadata>)userData);
			ItemMetadata itemMetadata = ((ItemMetadata)(object)obj3).WithServerDataVersion(1);
			reference = ref *(ItemMetadata*)itemMetadata;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			text = (string)obj;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)null, text, (string)null, (string)1, SearchOption.TopDirectoryOnly, (System.IO.SearchResultHandler<TSource>)null, (byte)(int)userData != 0);
			reference = ref *(ItemMetadata*)fileSystemEnumerableIterator;
		}
		Metadata meta2 = _meta;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S4_v4+60]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S4_v5+48]");
		object obj6 = 0;
		object obj7 = obj6 & 0x7FF;
		object obj8 = obj7 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v121 @ S5_v5 (should have been resolved before IL gen)");
		LogError((string)(object)this);
	}

	public bool IsFileAdded(string path)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
		bool result = default;
		return result;
	}

	public ICloudItem[] GetItems()
	{
		return (ICloudItem[])(object)sourceDescription__BackingField;
	}

	public ICloudItem GetItem(string file)
	{
		//IL_0033: Expected Obj, but got I
		//IL_0043: Expected Obj, but got I
		//IL_0053: Expected Obj, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected Obj, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected Obj, but got Unknown
		//IL_008d: Expected Obj, but got I4
		string filePathFromItemName = GetFilePathFromItemName(file);
		Metadata meta = _meta;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v3 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v4+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v5+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		bool flag = (nint)obj6 > -1;
		return (ICloudItem)flag;
	}

	public string GetFile(ICloudItem item)
	{
		string filePathFromItemName = GetFilePathFromItemName((string)(object)item);
		return (string)(object)GetItemMetadata(filePathFromItemName);
	}

	public string[] GetFiles()
	{
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected Obj, but got Unknown
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		Metadata meta = _meta;
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S1_v3 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v52 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__29_0 == null;
		bool flag2 = !flag;
		Func<KeyValuePair<string, ItemMetadata>, _003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>> selector = _003C_003Ec._003C_003E9__29_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S1_v26 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v46 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<KeyValuePair<string, ItemMetadata>, _003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>> func = default;
			object obj3 = func + 16;
			obj3 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ S1_v43 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+5C]");
			object obj4 = (nint)0 + (nint)4;
			obj4 = func;
			selector = func;
		}
		IEnumerable<_003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>> source = Enumerable.Select(meta.items, selector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num7 = 0;
		_ = 0;
		Func<_003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>, ICloudItem> func2 = default;
		object obj5 = func2 + 16;
		obj5 = this;
		IEnumerable<ICloudItem> source2 = Enumerable.Select(source, func2);
		return (string[])(object)Enumerable.ToArray(source2);
	}

	public void Clear()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00bd: Expected Obj, but got I
		//IL_00cd: Expected Obj, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected Obj, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected Obj, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(StringComparer);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.StringComparer>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(StringComparer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v17 (Il2CppClass<System.StringComparer>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E25");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S3_v3+60]");
		object obj3 = 0;
		object obj4 = obj3;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v45 @ S4_v4 (should have been resolved before IL gen)");
		object obj7 = this + 8;
		object obj8 = default;
		obj7 = obj8;
	}

	public void RefreshIsModified()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected Obj, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected Obj, but got Unknown
		//IL_0330: Expected Obj, but got I4
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected Obj, but got Unknown
		//IL_034d: Expected Obj, but got I4
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected Obj, but got Unknown
		//IL_0387: Expected Obj, but got I4
		//IL_0390: Expected Obj, but got I4
		//IL_0021: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected Obj, but got Unknown
		//IL_01d9: Expected Obj, but got I4
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected Obj, but got Unknown
		//IL_040e: Expected Obj, but got I4
		//IL_0261: Expected Obj, but got I
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected Obj, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 32;
		object obj4 = obj2 + 56;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = 0;
		_ = 0;
		object obj6 = obj2 + 48;
		obj6 = obj;
		_ = -1;
		bool flag = Commit();
		object obj7 = (flag ? 1 : 0) + 12;
		object obj8 = 0;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
		{
			object obj9 = (flag ? 1 : 0) + 16;
			object obj10 = obj8 << 2;
			object obj11 = obj9 + obj10;
			if (File.GetAttributes((string)obj11) != 0)
			{
				((FileStream)obj11).ExposeHandle();
			}
			object obj12 = obj8 + 1;
			obj8 = obj12;
		}
		Metadata meta = _meta;
		Dictionary<string, ItemMetadata>.KeyCollection keys = meta.items.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector((IEnumerable<string>)keys);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
		_ = 0;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj13 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Metadata meta2 = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			obj2 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj14 = obj6 + 4;
		object obj15 = obj14 + 1;
		obj14 = obj15;
		object obj16 = obj15 << 2;
		object obj17 = obj6 + obj16;
		obj17 = 141;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			object obj18 = (nint)0 << 2;
			object obj19 = obj6 + obj18;
			if ((nint)obj19 == 141)
			{
				object obj20 = obj6 + 4;
				if ((nint)obj20 > -1)
				{
					object obj21 = obj20 + -1;
					obj20 = obj21;
				}
				goto IL_03f5;
			}
		}
		object obj22 = default;
		if (obj22 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_03f5;
		IL_03f5:
		object obj23 = _meta + 8;
		obj23 = 0;
		LogError((string)(object)this);
	}

	public void ScanForLocalModifications()
	{
		if (!isOutOfDate)
		{
			Abort();
		}
	}

	public Coroutine UpdateAsync(CloudConflictResolver conflictResolver, CompleteHandler completeHandler = null)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Coroutine coroutine = default;
		coroutine.m_Ptr = (IntPtr)0;
		object obj = coroutine + 16;
		obj = this;
		object obj2 = coroutine + 20;
		obj2 = conflictResolver;
		object obj3 = coroutine + 28;
		obj3 = completeHandler;
		return coroutine;
	}

	public bool Update(CloudConflictResolver conflictResolver)
	{
		//IL_001d: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		LocalItem item = default;
		return (byte)(int)GetLocalItemFileStream(item) != 0;
	}

	public Coroutine CommitAsync(CompleteHandler completeHandler = null)
	{
		return (Coroutine)(object)PrepareCommitContext((string)(object)completeHandler, calledFromSynchronize: false);
	}

	public bool Commit()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected Obj, but got Unknown
		//IL_0062: Expected I4, but got Obj
		Metadata meta = _meta;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		Func<KeyValuePair<string, ItemMetadata>, string> func = default;
		object obj = func + 16;
		obj = this;
		IEnumerable<string> source = Enumerable.Select(meta.items, func);
		return (byte)(int)Enumerable.ToArray(source) != 0;
	}

	public Coroutine UpdateMetadataAsync(CompleteHandler completeHandler = null)
	{
		IEnumerator list = SynchronizeCoroutine((CloudConflictResolver)(object)completeHandler, null);
		return CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public bool UpdateMetadata()
	{
		//IL_000b: Expected I4, but got Obj
		return (byte)(int)PrepareUpdateMetadataContext(null) != 0;
	}

	public Coroutine SynchronizeAsync(CloudConflictResolver conflictResolver, SynchronizeCompleteHandler completeHandler = null)
	{
		IAsyncResult list = ((CloudConflictResolver)this).BeginInvoke((ICloudConflict[])(object)conflictResolver, (AsyncCallback)(object)completeHandler, (object)null);
		return CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	public unsafe bool Synchronize(CloudConflictResolver conflictResolver, out bool updateSuccess, out bool commitSuccess)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0054: Expected Obj, but got Ref
		//IL_0062: Expected Obj, but got I4
		//IL_006a: Expected Obj, but got Ref
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 20;
		obj2 = conflictResolver;
		object obj3 = (flag ? 1 : 0) + 28;
		obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref updateSuccess);
		object obj4 = (flag ? 1 : 0) + 32;
		obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref commitSuccess);
		return flag;
	}

	public unsafe void Abort()
	{
		//IL_000e: Expected Obj, but got Ref
		//IL_0e5e: Expected Obj, but got Ref
		//IL_0e67: Expected Obj, but got I4
		//IL_0e7b: Expected Obj, but got Ref
		//IL_0e84: Expected Obj, but got I4
		//IL_0e9e: Expected Obj, but got Ref
		//IL_0ea7: Expected Obj, but got I4
		//IL_0eb5: Expected Obj, but got Ref
		//IL_0ee3: Expected Obj, but got I
		//IL_0ef3: Expected Obj, but got I
		//IL_0f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f09: Expected Obj, but got Unknown
		//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f17: Expected Obj, but got Unknown
		//IL_0f4a: Expected VT, but got Obj
		//IL_0033: Expected Obj, but got I4
		//IL_0077: Expected Obj, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected Obj, but got Unknown
		//IL_08ba: Expected Obj, but got I4
		//IL_08e2: Expected Obj, but got I4
		//IL_10da: Expected Obj, but got I
		//IL_0b64: Expected Obj, but got I
		//IL_0b17: Expected Obj, but got I4
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9f: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected Obj, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected Obj, but got Unknown
		//IL_02b9: Expected Obj, but got I4
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd5: Expected Obj, but got Unknown
		//IL_0cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cde: Expected Obj, but got Unknown
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected Obj, but got Unknown
		//IL_0d18: Expected Obj, but got I4
		//IL_0932: Expected Obj, but got I4
		//IL_03ce: Expected Obj, but got I4
		//IL_0309: Expected Obj, but got I
		//IL_03b7: Expected Obj, but got I4
		//IL_0da5: Expected Obj, but got I
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected Obj, but got Unknown
		//IL_0ddb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de0: Expected Obj, but got Unknown
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected Obj, but got Unknown
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Expected Obj, but got Unknown
		//IL_095a: Expected Obj, but got I4
		//IL_0982: Expected Obj, but got I4
		//IL_09aa: Expected Obj, but got I4
		//IL_09d2: Expected Obj, but got I4
		//IL_0a09: Expected Obj, but got I4
		//IL_0a31: Expected Obj, but got I4
		//IL_0a59: Expected Obj, but got I4
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6c: Expected Obj, but got Unknown
		//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7a: Expected Obj, but got Unknown
		//IL_0aa6: Expected Obj, but got I4
		//IL_0ab7: Expected Obj, but got I4
		ref _0021_00210 reference = default;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 80));
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref reference, -64));
		obj2 = 0;
		_ = 0;
		object obj3 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 40));
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 24));
		obj4 = 0;
		object obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref reference, 32));
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v69 @ S4_v4 (should have been resolved before IL gen)");
		Metadata meta = _meta;
		Dictionary<string, ItemMetadata>.KeyCollection keys = meta.items.Keys;
		FlagsHelper.Set<T>(ref System.Runtime.CompilerServices.Unsafe.As<_0021_00210, T>(ref reference), (T)keys);
		obj2 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		object obj11 = 0;
		object obj12 = default;
		object obj13;
		object obj15 = default;
		object obj16 = default;
		object obj17 = default;
		object obj22 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj12 == null)
			{
				obj13 = 45;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Metadata meta2 = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v240+21]");
			if ((nint)0 != 0)
			{
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v240+28]");
			object obj14;
			bool flag3;
			bool flag;
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj14 = obj11;
				if (obj15 == null)
				{
					flag = false;
					continue;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj16 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S0_v240+28]");
					bool flag2 = obj17 != null;
					object obj18 = obj5 + 4;
					object obj19 = obj18 + 1;
					obj18 = obj19;
					object obj20 = obj19 << 2;
					object obj21 = obj5 + obj20;
					obj21 = 152;
					flag = flag2;
					obj14 = obj11;
					if (obj22 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
					object obj27;
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
						object obj23 = (nint)0 << 2;
						object obj24 = obj5 + obj23;
						if ((nint)obj24 == 152)
						{
							object obj25 = obj5 + 4;
							if ((nint)obj25 > -1)
							{
								object obj26 = obj25 + -1;
								obj25 = obj26;
							}
							obj27 = obj14;
							if (flag)
							{
								goto IL_0f6d;
							}
							obj27 = obj14;
							flag3 = false;
							goto IL_0fcd;
						}
					}
					if (obj14 != null)
					{
						obj27 = obj14;
						obj13 = 32;
						break;
					}
					obj27 = obj14;
					obj14 = 0;
				}
				else
				{
					obj14 = obj11;
				}
			}
			goto IL_0f6d;
			IL_0fcd:
			flag = flag3;
			obj11 = obj14;
			continue;
			IL_0f6d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			flag3 = true;
			goto IL_0fcd;
		}
		object obj28 = obj13 - 7;
		object obj33 = default;
		object obj34 = default;
		object obj35 = default;
		object obj36 = default;
		if ((nint)obj13 != 7)
		{
			if ((nint)obj28 != 1)
			{
				if ((nint)obj28 != 2 && (nint)obj28 != 3)
				{
					if ((nint)obj28 != 4)
					{
						if ((nint)obj28 != 5)
						{
							if ((nint)obj28 != 6)
							{
								if ((nint)obj28 != 7 && (nint)obj28 != 8)
								{
									if ((nint)obj28 != 9)
									{
										if ((nint)obj28 != 10 && (nint)obj28 != 11 && (nint)obj28 != 12 && (nint)obj28 != 13)
										{
											if ((nint)obj28 != 14)
											{
												if ((nint)obj28 != 15 && (nint)obj28 != 16)
												{
													if ((nint)obj28 != 17)
													{
														if ((nint)obj28 != 18 && (nint)obj28 != 19)
														{
															if ((nint)obj28 != 20)
															{
																if ((nint)obj28 != 21 && (nint)obj28 != 22 && (nint)obj28 != 23 && (nint)obj28 != 24)
																{
																	if ((nint)obj28 != 25)
																	{
																		if ((nint)obj28 != 26 && (nint)obj28 != 27 && (nint)obj28 != 28 && (nint)obj28 != 29 && (nint)obj28 != 30 && (nint)obj28 != 31 && (nint)obj28 != 32 && (nint)obj28 != 33)
																		{
																			if ((nint)obj28 != 34)
																			{
																				if ((nint)obj28 != 35)
																				{
																					if ((nint)obj28 != 36 && (nint)obj28 != 37 && (nint)obj28 == 38)
																					{
																						object obj29 = obj5 + 4;
																						object obj30 = obj29 + 1;
																						obj29 = obj30;
																						object obj31 = obj30 << 2;
																						object obj32 = obj5 + obj31;
																						obj32 = 198;
																						obj33 = obj11;
																						obj13 = 46;
																					}
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																					obj34 = obj35;
																					object obj37 = default;
																					obj36 = obj37;
																					obj13 = 43;
																				}
																			}
																			else
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																				obj34 = obj35;
																				object obj38 = default;
																				obj36 = obj38;
																				obj13 = 43;
																			}
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		obj34 = obj35;
																		object obj39 = default;
																		obj36 = obj39;
																		obj13 = 43;
																	}
																}
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																obj34 = obj35;
																object obj40 = default;
																obj36 = obj40;
																obj13 = 43;
															}
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														obj34 = obj35;
														object obj41 = default;
														obj36 = obj41;
														obj13 = 43;
													}
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												obj34 = obj35;
												object obj42 = default;
												obj36 = obj42;
												obj13 = 43;
											}
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj34 = obj35;
										object obj43 = default;
										obj36 = obj43;
										obj13 = 43;
									}
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj34 = obj35;
								object obj44 = default;
								obj36 = obj44;
								obj13 = 43;
							}
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj34 = obj35;
						object obj45 = default;
						obj36 = obj45;
						obj13 = 43;
					}
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				obj34 = obj35;
				object obj46 = default;
				obj36 = obj46;
				obj13 = 43;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			obj34 = obj35;
			object obj47 = default;
			obj36 = obj47;
			obj13 = 43;
		}
		if ((nint)obj13 == 43)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj48 = default;
			if (obj34 == obj48)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				object obj49 = default;
				obj33 = obj49;
				obj13 = 46;
			}
			else
			{
				object obj50 = obj36;
			}
		}
		if ((nint)obj13 == 46)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
				object obj51 = (nint)0 << 2;
				object obj52 = obj5 + obj51;
				if ((nint)obj52 == 198)
				{
					object obj53 = obj5 + 4;
					if ((nint)obj53 > -1)
					{
						object obj54 = obj53 + -1;
						obj53 = obj54;
					}
					goto IL_10bd;
				}
			}
			if (obj33 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_10bd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		return;
		IL_1102:
		LogError((string)(object)this);
		return;
		IL_10bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v25+1C]");
		object obj55 = num2 - 0;
		if ((nint)obj55 <= 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (T&)+10]");
		_ = 0;
		object obj56 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj56 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = System.Runtime.CompilerServices.Unsafe.As<_0021_00210, object>(ref reference);
			Metadata meta3 = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj57 = obj5 + 4;
		object obj58 = obj57 + 1;
		obj57 = obj58;
		object obj59 = obj58 << 2;
		object obj60 = obj5 + obj59;
		obj60 = 281;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
			object obj61 = (nint)0 << 2;
			object obj62 = obj5 + obj61;
			if ((nint)obj62 == 281)
			{
				object obj63 = obj5 + 4;
				if ((nint)obj63 > -1)
				{
					object obj64 = obj63 + -1;
					obj63 = obj64;
				}
				goto IL_1102;
			}
		}
		if (obj33 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_1102;
	}

	private void LoadWorkingCopy()
	{
		if (~(_isUpdating ? 1u : 0u) == 0)
		{
			_abortUpdate = true;
		}
		if (~(_isSynchronizing ? 1u : 0u) == 0)
		{
			_abortSynchronize = true;
		}
	}

	private void SaveWorkingCopy()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0191: Expected Obj, but got I
		//IL_01a1: Expected Obj, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected Obj, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj3 = default;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj4 = this + 40;
			object obj5 = default;
			obj4 = obj5;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S3_v4 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S3_v5+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v133 @ S4_v5 (should have been resolved before IL gen)");
		object obj12 = default;
		object obj11 = obj12 + 12;
		object obj13 = default;
		obj11 = obj13;
		object obj14 = this + 40;
		obj14 = obj12;
	}

	private string GetItemNameFromFilePath(string filePath)
	{
		ICloudItem list = _003CGetItems_003Eb__29_1((_003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata>)(object)filePath);
		return (string)(object)CoroutineUtil.WaitForAll((YieldInstruction[])(object)list);
	}

	private string GetFilePathFromItemName(string name)
	{
		//IL_01ce: Expected I, but got Obj
		//IL_01e4: Expected Obj, but got I
		//IL_021e: Expected VT, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_006e: Expected Obj, but got I4
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		//IL_013e: Expected I, but got Obj
		//IL_0154: Expected Obj, but got I
		//IL_0275: Expected Obj, but got I4
		//IL_0275: Expected Obj, but got I4
		//IL_017f: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v54 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string fullPathInternal = Path.GetFullPathInternal(name);
		string text = fullPathInternal.ToLower((CultureInfo)(object)_rootDir);
		if (text != null)
		{
			string rootDir = _rootDir;
			string text2 = fullPathInternal.Trim((char[])rootDir.m_stringLength);
			if (text2.m_stringLength >= 1)
			{
				nint num3 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v24 (Il2CppClass<System.IO.Path>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v47 (Il2CppClass<System.IO.Path>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = Path.DirectorySeparatorChar != '/';
				bool flag2 = !flag;
				string result = text2;
				if (!flag2)
				{
					nint num5 = (nint)typeof(Path);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v35 (Il2CppClass<System.IO.Path>)+BA]");
					object obj3 = (nint)0 & (nint)0x200;
					if (obj3 != null)
					{
						nint num6 = (nint)typeof(Path);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v41 (Il2CppClass<System.IO.Path>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text3 = text2.Replace((string)Path.DirectorySeparatorChar, (string)47);
					result = text3;
				}
				return result;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		ArgumentException ex = default;
		ex._002Ector((SerializationInfo)(object)"Invalid file.", (StreamingContext)"filePath");
		((CloudWorkingCopy)(object)ex).GetItemNameFromFilePath((string)null);
		return null;
	}

	private Stream GetLocalItemFileStream(LocalItem item)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a6: Expected Obj, but got I4
		//IL_00a6: Expected Obj, but got I4
		//IL_00b9: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<System.IO.Path>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = ((string)(object)item).Replace((string)47, (string)Path.DirectorySeparatorChar);
		return (Stream)(object)string.ConcatArray((string[])(object)_rootDir, (int)text);
	}

	private LocalItem GetLocalItem(string name)
	{
		//IL_0051: Expected Obj, but got I4
		Stream localItemFileStream = GetLocalItemFileStream((LocalItem)name.m_stringLength);
		if (File.GetAttributes((string)(object)localItemFileStream) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			FileStream fileStream = default;
			fileStream.Write((byte[])(object)localItemFileStream, 3, 1);
			return (LocalItem)(object)fileStream;
		}
		return null;
	}

	private unsafe ItemMetadata GetItemMetadata(string name)
	{
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected I4, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected Ref, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Expected Obj, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected Obj, but got Unknown
		//IL_01a8: Expected Obj, but got I4
		//IL_01b7: Expected Obj, but got I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected Obj, but got Unknown
		//IL_0021: Expected I4, but got Obj
		//IL_0084: Expected Obj, but got I4
		//IL_0225: Expected F4, but got I
		//IL_0220: Expected native int or pointer, but got VT
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected Obj, but got Unknown
		//IL_0252: Expected I4, but got Obj
		//IL_02a0: Expected VT, but got I4
		//IL_02a0: Expected I4, but got Obj
		//IL_02a0: Expected I4, but got Obj
		//IL_02a0: Expected I4, but got Obj
		//IL_02a0: Expected VT, but got Obj
		//IL_00c0: Expected Obj, but got I4
		object obj = default;
		bool flag = (byte)(obj + 48) != 0;
		ref ItemMetadata reference = ref *(ItemMetadata*)(obj - -64);
		reference = ref *(ItemMetadata*)null;
		object obj2 = obj + 32;
		obj2 = 0;
		_ = 0;
		object obj3 = obj + 16;
		obj3 = 0;
		_ = 0;
		obj = 0;
		_ = 0;
		Metadata meta = _meta;
		bool flag2 = meta.items.TryGetValue(name, out reference);
		ItemMetadata itemMetadata = reference;
		if (reference != null)
		{
			object obj4 = reference + 16;
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj4 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S1_v18+8]");
			_ = 0;
			ItemMetadata itemMetadata2 = reference;
			bool isActive = itemMetadata2.isModified__BackingField;
			ItemMetadata itemMetadata3 = reference;
			bool flag3 = itemMetadata3.isOutOfDate__BackingField;
			ItemMetadata itemMetadata4 = reference;
			obj3 = ((bool*)(flag ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Boolean)+8]");
			_ = 0;
			CloudWorkingCopy cloudWorkingCopy2;
			if (itemMetadata4.userData__BackingField != null)
			{
				obj2 = ((bool*)(flag ? 1 : 0))->m_value;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.Boolean)+8]");
				_ = 0;
				ItemMetadata itemMetadata5 = reference;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				CloudWorkingCopy cloudWorkingCopy = default;
				cloudWorkingCopy.itemUpdated += (EventHandler<CloudItemUpdatedArgs>)(object)itemMetadata5.userData__BackingField;
				obj = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
				_ = 0;
				cloudWorkingCopy2 = cloudWorkingCopy;
			}
			else
			{
				obj = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16+8]");
				_ = 0;
				cloudWorkingCopy2 = null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Color color = default;
			((Color*)(nint)color)->b = num;
			_ = 0;
			object obj5 = color + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			GUIStyle gUIStyle = default;
			gUIStyle.Internal_DrawWithTextSelection((Rect)name, (GUIContent)(object)itemMetadata.revision__BackingField, flag, isActive, flag3, (byte)(int)sourceDescription__BackingField != 0, (byte)(int)_installationId != 0, _dataVersion, (int)cloudWorkingCopy2, (Color)1, color);
			return (ItemMetadata)(object)gUIStyle;
		}
		return null;
	}

	private void RaiseItemUpdatedWithArgs(List<CloudItemUpdatedArgs> args)
	{
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected Obj, but got Unknown
		//IL_0102: Expected Obj, but got I4
		//IL_0136: Expected Obj, but got I
		//IL_0146: Expected Obj, but got I
		//IL_0156: Expected Obj, but got I
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected Obj, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected Obj, but got Unknown
		//IL_008b: Expected Obj, but got I
		//IL_009b: Expected Obj, but got I
		//IL_00ab: Expected Obj, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected Obj, but got Unknown
		object obj = default;
		string text = (string)(obj + 32);
		object obj2 = obj + 16;
		obj2 = 0;
		_ = 0;
		string filePathFromItemName = GetFilePathFromItemName((string)(object)args);
		Metadata meta = _meta;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S2_v3 (Il2CppMethodInfo)+C]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S2_v4+60]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S2_v5+44]");
		object obj5 = 0;
		object obj6 = obj5 & 0x1FFF;
		object obj7 = obj6 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50 @ S3_v4 (should have been resolved before IL gen)");
		object obj8 = default;
		if ((nint)obj8 <= -1)
		{
			Metadata meta2 = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			text = (string)obj;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)null, text, (string)null, (string)null, SearchOption.TopDirectoryOnly, (System.IO.SearchResultHandler<TSource>)null, false);
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S4_v7+60]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S4_v8+48]");
			object obj11 = 0;
			object obj12 = obj11 & 0x7FF;
			object obj13 = obj12 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v73 @ S5_v6 (should have been resolved before IL gen)");
			LogError((string)(object)this);
		}
	}

	private unsafe UpdateContext PrepareUpdateContext(string method, CloudConflictResolver conflictResolver, bool calledFromSynchronize)
	{
		//IL_0161: Expected Obj, but got I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected Obj, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected Obj, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected Obj, but got Unknown
		//IL_01d8: Expected Obj, but got I4
		//IL_0125: Expected Obj, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected I4, but got Unknown
		CloudConflictResolver cloudConflictResolver = (CloudConflictResolver)0;
		((bool*)(calledFromSynchronize ? 1 : 0))->m_value = false;
		if (~(_isUpdating ? 1u : 0u) == 0 || ~(_isCommitting ? 1u : 0u) == 0 || ~(_isMetadataUpdating ? 1u : 0u) == 0 || _isSynchronizing)
		{
			Log("Synchronize: Cannot synchronize while another update or commit operation is running.");
		}
		else
		{
			_isSynchronizing = true;
			CommitContext commitContext = PrepareCommitContext(method, calledFromSynchronize: true);
			object obj = commitContext & 1;
			cloudConflictResolver = (CloudConflictResolver)obj;
			bool value;
			if (commitContext != null)
			{
				if (~(_abortSynchronize ? 1u : 0u) == 0)
				{
					value = true;
				}
				else if (isOutOfDate)
				{
					CommitContext commitContext2 = PrepareUpdateMetadataContext((string)1);
					value = (byte)(commitContext2 & 1) != 0;
				}
				else
				{
					value = true;
				}
			}
			else
			{
				value = true;
			}
			((bool*)(calledFromSynchronize ? 1 : 0))->m_value = value;
			_isSynchronizing = false;
			_abortSynchronize = false;
		}
		object obj2 = ((bool*)(calledFromSynchronize ? 1 : 0))->m_value & conflictResolver;
		object obj3 = obj2 & 0xFF;
		bool flag = obj3 != null;
		return (UpdateContext)flag;
	}

	private unsafe bool ProcessUpdateResult(UpdateContext context)
	{
		//IL_0038: Expected I4, but got Obj
		ref ItemMetadata reference = ref *(ItemMetadata*)null;
		Metadata meta = _meta;
		bool flag = meta.items.TryGetValue((string)(object)context, out reference);
		return (byte)(int)reference != 0;
	}

	private bool ApplyUpdate(UpdateContext context)
	{
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected Obj, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected Obj, but got Unknown
		//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e8: Expected Obj, but got Unknown
		//IL_06f1: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_0584: Expected Obj, but got I4
		//IL_0576: Expected Obj, but got I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected Obj, but got Unknown
		//IL_0136: Expected Obj, but got I4
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected Obj, but got Unknown
		//IL_0548: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected Obj, but got Unknown
		//IL_0568: Expected Obj, but got I4
		//IL_0613: Expected I4, but got Obj
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected Obj, but got Unknown
		//IL_0268: Expected Obj, but got I4
		//IL_032e: Expected Obj, but got I4
		//IL_029d: Expected Obj, but got I4
		//IL_0748: Expected Obj, but got I
		//IL_0758: Expected Obj, but got I
		//IL_0768: Expected Obj, but got I
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected Obj, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0784: Expected Obj, but got Unknown
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected Obj, but got Unknown
		//IL_024b: Expected Obj, but got I4
		//IL_03b3: Expected Obj, but got I4
		//IL_07c8: Expected Obj, but got I4
		//IL_042b: Expected Obj, but got I4
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected Obj, but got Unknown
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Expected Obj, but got Unknown
		//IL_04c4: Expected Obj, but got I4
		object obj = default;
		string text = (string)(obj + 48);
		object obj2 = obj + 16;
		object obj3 = obj + 32;
		obj3 = 0;
		_ = 0;
		bool flag7 = default;
		if (context.result != null)
		{
			CloudServerResult result = context.result;
			if (result.status != CloudSaveStatus.OK)
			{
				return false;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			object obj4 = context + 24;
			object obj5 = default;
			obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<ICloudItem> list = default;
			list._002Ector();
			object obj6 = context + 28;
			obj6 = list;
			CloudServerResult result2 = context.result;
			object obj25;
			if (result2.items != null)
			{
				CloudServerResult result3 = context.result;
				ICloudItem[] items = result3.items;
				if (items.Length != 0)
				{
					Abort();
					CloudServerResult result4 = context.result;
					object obj7 = result4.items + 12;
					object obj8 = 0;
					object obj9 = default;
					Metadata meta;
					nint num;
					object obj18;
					object obj19;
					object obj20;
					object obj21;
					object obj22;
					object obj23 = default;
					UpdateContext context2 = default;
					object obj13 = default;
					bool flag5 = default;
					Dictionary<string, string> newUserData = default;
					System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator2 = default;
					SearchOption searchOption = default;
					object obj14 = default;
					string text4 = default;
					bool newIsOutOfDate = default;
					string name = default;
					object obj16 = default;
					for (; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7); meta = _meta, Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B"), num = 0, Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ S4_v11 (Il2CppMethodInfo)+C]"), obj18 = 0, Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ S4_v12+60]"), obj19 = 0, Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ S4_v13+48]"), obj20 = 0, obj21 = obj20 & 0x7FF, obj22 = obj21 + 39195, Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v233 @ S5_v11 (should have been resolved before IL gen)"), obj9 = obj23 + 1)
					{
						object obj10 = result4.items + 16;
						object obj11 = obj9 << 2;
						object obj12 = obj10 + obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						bool flag = ProcessUpdateResult(context2);
						bool flag2 = !flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator;
						if ((nint)obj13 > _dataVersion)
						{
							bool flag3 = !flag2;
							bool flag4 = flag;
							if (!flag3)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
								obj2 = obj3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								text = (string)obj2;
								string text2 = text;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S0_v11+8]");
								text2.m_stringLength = 0;
								((System.IO.FileSystemEnumerableIterator<TSource>)flag5)._002Ector((string)null, text, (string)null, (string)null, SearchOption.TopDirectoryOnly, (System.IO.SearchResultHandler<TSource>)null, false);
								flag4 = flag5;
							}
							ItemMetadata itemMetadata = ((ItemMetadata)flag4).WithIsModified(newIsModified: true);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							ItemMetadata itemMetadata2 = itemMetadata.WithUserData(newUserData);
							fileSystemEnumerableIterator = (System.IO.FileSystemEnumerableIterator<>)(object)itemMetadata2;
							obj8 = 1;
							continue;
						}
						if (flag2)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
							obj = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v13+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							text = (string)obj;
							string text3 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							text3.m_stringLength = 0;
							((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator2)._002Ector((string)null, text, (string)1, (string)null, searchOption, (System.IO.SearchResultHandler<TSource>)null, false);
							context.saveItems.Add((ICloudItem)obj12);
							fileSystemEnumerableIterator = fileSystemEnumerableIterator2;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						bool flag6;
						if (obj14 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v103+8]");
							flag6 = (nint)0 == 0;
						}
						else
						{
							flag6 = true;
						}
						if (flag6)
						{
							ItemMetadata itemMetadata3 = ((ItemMetadata)flag).WithServerDataVersion(1);
							ItemMetadata itemMetadata4 = itemMetadata3.WithIsModified(newIsModified: false);
							ItemMetadata itemMetadata5 = itemMetadata4.WithIsOutOfDate(newIsOutOfDate: false);
							fileSystemEnumerableIterator = (System.IO.FileSystemEnumerableIterator<>)(object)itemMetadata5;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v89 (System.Boolean)+21]");
						if ((nint)0 == 0)
						{
							ItemMetadata itemMetadata6 = ((ItemMetadata)flag).WithIsModified(newIsModified: true);
							context.saveItems.Add((ICloudItem)obj12);
							fileSystemEnumerableIterator = (System.IO.FileSystemEnumerableIterator<>)(object)itemMetadata6;
							continue;
						}
						if (_installationId != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							if (text4 != _installationId)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								ItemMetadata itemMetadata7 = ((ItemMetadata)flag).WithIsOutOfDate(newIsOutOfDate);
								ItemMetadata itemMetadata8 = itemMetadata7.WithIsModified(newIsModified: false);
								fileSystemEnumerableIterator = (System.IO.FileSystemEnumerableIterator<>)(object)itemMetadata8;
								continue;
							}
						}
						ItemMetadata itemMetadata9 = ((ItemMetadata)flag).WithIsModified(newIsModified: true);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						ItemMetadata itemMetadata10 = GetItemMetadata(name);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj15 = obj16 + 8;
						obj15 = itemMetadata10;
						object obj17 = obj16 + 12;
						obj17 = obj12;
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
						fileSystemEnumerableIterator = (System.IO.FileSystemEnumerableIterator<>)(object)itemMetadata9;
					}
					object obj24 = obj8 & 1;
					flag7 = obj24 != null;
					obj25 = 1;
				}
				else
				{
					obj25 = 0;
				}
			}
			else
			{
				obj25 = 0;
			}
			Metadata meta2 = _meta;
			if (meta2.kilooTag == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj26 = default;
				if (obj26 != null)
				{
					object obj27 = _meta + 8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj28 = default;
					obj27 = obj28;
					goto IL_05dc;
				}
			}
			if (obj25 != null)
			{
				goto IL_05dc;
			}
			goto IL_05e7;
		}
		return false;
		IL_05dc:
		LogError((string)(object)this);
		goto IL_05e7;
		IL_05e7:
		if (flag7)
		{
			string msg = string.ConcatArray((string[])(object)context.method, (int)": Aborting update because working copy is not compatible with updated data.");
			Log(msg);
			return false;
		}
		List<ICloudConflict> conflicts = context.conflicts;
		if (conflicts._size > 0 && context.conflictResolver != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BBA9");
			IAsyncResult result5 = default;
			context.conflictResolver.EndInvoke(result5);
		}
		return true;
	}

	private IEnumerator UpdateCoroutine(CloudConflictResolver conflictResolver, CompleteHandler completeHandler, bool calledFromSynchronize)
	{
		//IL_03c2: Expected Obj, but got I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected Obj, but got Unknown
		//IL_037f: Expected I4, but got Obj
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected Obj, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected Obj, but got Unknown
		//IL_0166: Expected I, but got Obj
		//IL_017c: Expected Obj, but got I
		//IL_00af: Expected I4, but got Obj
		//IL_00fc: Expected I4, but got Obj
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_01a7: Expected I, but got Obj
		//IL_01f4: Expected I, but got Obj
		//IL_020a: Expected Obj, but got I
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected Obj, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected Obj, but got Unknown
		//IL_0282: Expected I, but got Obj
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected Obj, but got Unknown
		//IL_0460: Expected I, but got Obj
		//IL_0476: Expected Obj, but got I
		//IL_02cf: Expected I, but got Obj
		//IL_02e5: Expected Obj, but got I
		//IL_0235: Expected I, but got Obj
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected Obj, but got Unknown
		//IL_04fa: Expected I, but got Obj
		//IL_0510: Expected Obj, but got I
		//IL_0310: Expected I, but got Obj
		bool flag = ~(_isUpdating ? 1u : 0u) == 0 || ~(_isCommitting ? 1u : 0u) == 0 || ~(_isMetadataUpdating ? 1u : 0u) == 0 || _isSynchronizing;
		object obj = (flag ? 1 : 0) ^ 1;
		object obj2 = obj | calledFromSynchronize;
		if (obj2 != null)
		{
			string text = kilooTag;
			if (text != null)
			{
				string msg = string.ConcatArray((string[])(object)conflictResolver, (int)": Working copy belongs to another account.");
				Log(msg);
				return null;
			}
			if (isAccountMismatch)
			{
				string msg2 = string.ConcatArray((string[])(object)conflictResolver, (int)": Cannot update because working copy is incompatible with server data version.");
				Log(msg2);
				return null;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			IEnumerator enumerator = default;
			object obj3 = enumerator + 8;
			obj3 = conflictResolver;
			object obj4 = enumerator + 12;
			obj4 = completeHandler;
			Metadata meta = _meta;
			nint num = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S1_v16 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S1_v107 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = _003C_003Ec._003C_003E9__67_0 == null;
			bool flag3 = !flag2;
			Func<KeyValuePair<string, ItemMetadata>, _003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>> selector = _003C_003Ec._003C_003E9__67_0;
			if (!flag3)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ S1_v81 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num4 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S1_v101 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				Func<KeyValuePair<string, ItemMetadata>, _003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>> func = default;
				object obj7 = func + 16;
				obj7 = _003C_003Ec._003C_003E9;
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ S1_v98 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+5C]");
				object obj8 = (nint)0 + (nint)8;
				obj8 = func;
				selector = func;
			}
			IEnumerable<_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>> source = Enumerable.Select(meta.items, selector);
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S1_v27 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ S1_v74 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag4 = _003C_003Ec._003C_003E9__67_1 == null;
			bool flag5 = !flag4;
			Func<_0021_00210, _0021_00211> selector2 = (Func<_0021_00210, _0021_00211>)(object)_003C_003Ec._003C_003E9__67_1;
			if (!flag5)
			{
				nint num9 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S1_v48 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num10 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S1_v68 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num11 = 0;
				_ = 0;
				Func<_0021_00210, _0021_00211> func2 = default;
				object obj11 = func2 + 16;
				obj11 = _003C_003Ec._003C_003E9;
				nint num12 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S1_v65 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+5C]");
				object obj12 = (nint)0 + (nint)12;
				obj12 = func2;
				selector2 = func2;
			}
			IEnumerable<_0021_00211> source2 = (IEnumerable<_0021_00211>)Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)source, (Func<TSource, TResult>)(object)selector2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num13 = 0;
			_ = 0;
			Func<_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>, ICloudItem> func3 = default;
			object obj13 = func3 + 16;
			obj13 = this;
			object obj14 = enumerator + 16;
			IEnumerable<ICloudItem> source3 = Enumerable.Select((IEnumerable<_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata>>)source2, func3);
			ICloudItem[] array = Enumerable.ToArray(source3);
			obj14 = array;
			return enumerator;
		}
		string msg3 = string.ConcatArray((string[])(object)conflictResolver, (int)": Cannot update while another update or commit operation is running.");
		Log(msg3);
		return null;
	}

	private bool Update(CloudConflictResolver conflictResolver, bool calledFromSynchronize)
	{
		//IL_001b: Expected Obj, but got I4
		//IL_001f: Expected I4, but got Obj
		int num = CloudItemExtensions.SaveToFileAndOptionallyComputeCrc32((ICloudItem)(object)this, (string)(object)conflictResolver, calledFromSynchronize);
		return (byte)(int)CoroutineUtil.WaitForAll((YieldInstruction[])num) != 0;
	}

	private CommitContext PrepareCommitContext(string method, bool calledFromSynchronize)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I
		//IL_014e: Expected Obj, but got I4
		IEnumerator enumerator = UpdateCoroutine((CloudConflictResolver)(object)"Update", (CompleteHandler)(object)method, calledFromSynchronize);
		if (enumerator != null)
		{
			_abortUpdate = false;
			_isUpdating = true;
			object obj = enumerator + 20;
			Metadata meta = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			object obj2 = default;
			obj = obj2;
			bool flag = ~(_abortUpdate ? 1u : 0u) != 0 && ApplyUpdate((UpdateContext)enumerator) && ~(_abortUpdate ? 1u : 0u) != 0 && ProcessCommitResult((CommitContext)enumerator);
			_abortUpdate = false;
			_isUpdating = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v6 (System.Collections.IEnumerator)+20]");
			base((ICloudConflict[])0);
			return (CommitContext)flag;
		}
		return null;
	}

	private bool ProcessCommitResult(CommitContext context)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a00: Expected Obj, but got Unknown
		//IL_0a09: Expected Obj, but got I4
		//IL_0a18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1d: Expected Obj, but got Unknown
		//IL_0a26: Expected Obj, but got I4
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected Obj, but got Unknown
		//IL_0a56: Expected I, but got Obj
		//IL_0a6c: Expected Obj, but got I
		//IL_0c11: Expected Obj, but got I
		//IL_0c2c: Expected VT, but got Obj
		//IL_0021: Expected I, but got Obj
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaf: Expected Obj, but got Unknown
		//IL_0ac6: Expected I, but got Obj
		//IL_0adc: Expected Obj, but got I
		//IL_00af: Expected I, but got Obj
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected Obj, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected Obj, but got Unknown
		//IL_01b8: Expected Obj, but got I4
		//IL_01c1: Expected Obj, but got I4
		//IL_0bad: Expected Obj, but got I
		//IL_0274: Expected Obj, but got I
		//IL_0b48: Expected Obj, but got I4
		//IL_0331: Expected I4, but got Obj
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Expected Obj, but got Unknown
		//IL_038d: Expected Obj, but got I4
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected Obj, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected Obj, but got Unknown
		//IL_03ae: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_042e: Expected Obj, but got I4
		//IL_0446: Expected Obj, but got I4
		//IL_045e: Expected Obj, but got I4
		//IL_0be1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be6: Expected Obj, but got Unknown
		//IL_0938: Expected Obj, but got I
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected Obj, but got Unknown
		//IL_0484: Expected Obj, but got I4
		//IL_0416: Expected Obj, but got I4
		//IL_049c: Expected Obj, but got I4
		//IL_04f6: Expected Obj, but got I4
		//IL_096e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected Obj, but got Unknown
		//IL_04b4: Expected Obj, but got I4
		//IL_050e: Expected Obj, but got I4
		//IL_04d4: Expected Obj, but got I4
		//IL_0526: Expected Obj, but got I4
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected Obj, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected Obj, but got Unknown
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected Obj, but got Unknown
		//IL_087f: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 - -64;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S1_v14 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S1_v185 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__69_0 == null;
		bool flag2 = !flag;
		Func<_0021_00210, _0021_00211> selector = (Func<_0021_00210, _0021_00211>)(object)_003C_003Ec._003C_003E9__69_0;
		if (!flag2)
		{
			nint num3 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S1_v159 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v179 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num5 = 0;
			_ = 0;
			Func<_0021_00210, _0021_00211> func = default;
			object obj8 = func + 16;
			obj8 = _003C_003Ec._003C_003E9;
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S1_v176 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+5C]");
			object obj9 = (nint)0 + (nint)16;
			obj9 = func;
			selector = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ L1 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+CommitContext)+18]");
		IEnumerable<_0021_00211> enumerable = (IEnumerable<_0021_00211>)Enumerable.Select<TSource, TResult>((IEnumerable<TSource>)0, (Func<TSource, TResult>)(object)selector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<> list = default;
		((List<T>)(object)list).Add((T)enumerable);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		object obj11 = obj5 + 4;
		object obj12 = obj11 + 1;
		obj11 = obj12;
		object obj13 = obj12 << 2;
		object obj14 = obj5 + obj13;
		obj14 = 118;
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj5 + obj16;
			if ((nint)obj17 == 118)
			{
				object obj18 = obj5 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_0b89;
			}
		}
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0b89;
		IL_08fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj20 = (nint)0 << 2;
			object obj21 = obj5 + obj20;
			if ((nint)obj21 == 303)
			{
				object obj22 = obj5 + 4;
				if ((nint)obj22 > -1)
				{
					object obj23 = obj22 + -1;
					obj22 = obj23;
				}
				goto IL_0bd2;
			}
		}
		object obj24 = default;
		if (obj24 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0bd2;
		IL_0bd2:
		LogError((string)(object)this);
		object obj25 = context + 32;
		object obj26 = default;
		obj25 = obj26;
		return true;
		IL_0b89:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [context @ L1 (Kiloo.Common.Backend.Cloud.CloudWorkingCopy+CommitContext)+18]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ S0_v51+C]");
		if ((nint)0 != 0)
		{
			string msg = string.ConcatArray((string[])(object)context.method, (int)": Aborting update because all conflicts were NOT resolved.");
			Log(msg);
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj29 = default;
		object obj30 = default;
		object obj33 = default;
		object obj34 = default;
		object obj28;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj28 = 58;
			bool flag3 = obj29 == null;
			obj28 = 59;
			if (flag3)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj28 = 35;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj28 = 36;
			object obj31;
			if (obj30 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ S0_v124+34]");
				if ((nint)0 != 0)
				{
					obj31 = 0;
					goto IL_04d9;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj28 = 51;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj28 = 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj28 = 53;
			object obj32 = obj33 ^ 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			obj28 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj28 = 55;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj28 = 55;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj31 = obj34;
			obj28 = 55;
			goto IL_04d9;
			IL_04d9:
			Metadata meta = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj28 = 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			obj28 = 57;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			obj28 = 57;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj35 = obj28 - 35;
		if ((nint)obj28 != 35 && (nint)obj35 != 1)
		{
			if ((nint)obj35 != 2 && (nint)obj35 != 3 && (nint)obj35 != 4 && (nint)obj35 != 5 && (nint)obj35 != 6 && (nint)obj35 != 7 && (nint)obj35 != 8 && (nint)obj35 != 9 && (nint)obj35 != 10 && (nint)obj35 != 11 && (nint)obj35 != 12 && (nint)obj35 != 13 && (nint)obj35 != 14 && (nint)obj35 != 15)
			{
				if ((nint)obj35 == 16 || (nint)obj35 == 17 || (nint)obj35 == 18 || (nint)obj35 == 19 || (nint)obj35 == 20 || (nint)obj35 == 21 || (nint)obj35 == 22 || (nint)obj35 == 23)
				{
					goto IL_088c;
				}
				if ((nint)obj35 == 24)
				{
					object obj36 = obj5 + 4;
					object obj37 = obj36 + 1;
					obj36 = obj37;
					object obj38 = obj37 << 2;
					object obj39 = obj5 + obj38;
					obj39 = 303;
					obj24 = obj15;
				}
			}
			goto IL_08fd;
		}
		goto IL_088c;
		IL_088c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj40 = default;
		object obj41 = default;
		if (obj40 != obj41)
		{
			object obj43 = default;
			object obj42 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		object obj44 = default;
		obj24 = obj44;
		goto IL_08fd;
	}

	private IEnumerator CommitCoroutine(CompleteHandler completeHandler, bool calledFromSynchronize)
	{
		//IL_02dc: Expected Obj, but got I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected Obj, but got Unknown
		//IL_0299: Expected I4, but got Obj
		//IL_00af: Expected I4, but got Obj
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected Obj, but got Unknown
		//IL_015b: Expected I, but got Obj
		//IL_0171: Expected Obj, but got I
		//IL_00fc: Expected I4, but got Obj
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected Obj, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected Obj, but got Unknown
		//IL_019c: Expected I, but got Obj
		//IL_01e9: Expected I, but got Obj
		//IL_01ff: Expected Obj, but got I
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected Obj, but got Unknown
		//IL_037a: Expected I, but got Obj
		//IL_0390: Expected Obj, but got I
		//IL_022a: Expected I, but got Obj
		bool flag = ~(_isUpdating ? 1u : 0u) == 0 || ~(_isCommitting ? 1u : 0u) == 0 || ~(_isMetadataUpdating ? 1u : 0u) == 0 || _isSynchronizing;
		object obj = (flag ? 1 : 0) ^ 1;
		object obj2 = obj | calledFromSynchronize;
		if (obj2 != null)
		{
			string text = kilooTag;
			if (text != null)
			{
				string msg = string.ConcatArray((string[])(object)completeHandler, (int)": Working copy belongs to another account.");
				Log(msg);
				return null;
			}
			if (isIncompatible)
			{
				string msg2 = string.ConcatArray((string[])(object)completeHandler, (int)": Cannot commit when working copy is out of date. Update first.");
				Log(msg2);
				return null;
			}
			Abort();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			IEnumerator enumerator = default;
			object obj3 = enumerator + 8;
			obj3 = completeHandler;
			Metadata meta = _meta;
			nint num = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S1_v15 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S1_v62 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = _003C_003Ec._003C_003E9__72_0 == null;
			bool flag3 = !flag2;
			Func<KeyValuePair<string, ItemMetadata>, bool> predicate = _003C_003Ec._003C_003E9__72_0;
			if (!flag3)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S1_v36 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v56 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				Func<KeyValuePair<string, ItemMetadata>, bool> func = default;
				object obj6 = func + 16;
				obj6 = _003C_003Ec._003C_003E9;
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v53 (Il2CppClass<Kiloo.Common.Backend.Cloud.CloudWorkingCopy+<>c>)+5C]");
				object obj7 = (nint)0 + (nint)20;
				obj7 = func;
				predicate = func;
			}
			IEnumerable<KeyValuePair<string, ItemMetadata>> source = Enumerable.Where(meta.items, predicate);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num7 = 0;
			_ = 0;
			Func<KeyValuePair<string, ItemMetadata>, ICloudItem> func2 = default;
			object obj8 = func2 + 16;
			obj8 = this;
			object obj9 = enumerator + 12;
			IEnumerable<ICloudItem> source2 = Enumerable.Select(source, func2);
			ICloudItem[] array = Enumerable.ToArray(source2);
			obj9 = array;
			return enumerator;
		}
		string msg3 = string.ConcatArray((string[])(object)completeHandler, (int)": Cannot commit while another update or commit operation is running.");
		Log(msg3);
		return null;
	}

	private bool Commit(bool calledFromSynchronize)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdc: Expected Obj, but got Unknown
		//IL_0be5: Expected Obj, but got I4
		//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf9: Expected Obj, but got Unknown
		//IL_0c02: Expected Obj, but got I4
		//IL_0c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c16: Expected Obj, but got Unknown
		//IL_0c34: Expected Obj, but got I
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I
		//IL_0023: Expected Obj, but got I
		//IL_0bb7: Expected I4, but got Obj
		//IL_0bb7: Expected Obj, but got I
		//IL_0117: Expected Obj, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected Obj, but got Unknown
		//IL_0181: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I4
		//IL_0ccd: Expected Obj, but got I
		//IL_0cd6: Expected Obj, but got I4
		//IL_06a1: Expected Obj, but got I
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected Obj, but got Unknown
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected Obj, but got Unknown
		//IL_0779: Expected Obj, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected Obj, but got Unknown
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected Obj, but got Unknown
		//IL_0a8f: Expected Obj, but got I4
		//IL_0996: Expected Obj, but got I4
		//IL_0aaa: Expected Obj, but got I
		//IL_0aba: Expected Obj, but got I
		//IL_0ad8: Expected Obj, but got I
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected Obj, but got Unknown
		//IL_09d0: Expected Obj, but got I
		//IL_09e0: Expected Obj, but got I
		//IL_09fe: Expected Obj, but got I
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected Obj, but got Unknown
		//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Expected Obj, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_084f: Expected Obj, but got Unknown
		//IL_08af: Expected Obj, but got I
		//IL_08f8: Expected Obj, but got I
		//IL_090e: Expected Obj, but got I
		//IL_091e: Expected Obj, but got I
		//IL_093c: Expected Obj, but got I
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected Obj, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected Obj, but got Unknown
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected Obj, but got Unknown
		//IL_0619: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		Predicate<ICloudItem> predicate = (Predicate<ICloudItem>)(obj2 + 56);
		predicate = (Predicate<ICloudItem>)0;
		_ = 0;
		object obj3 = obj2 + 16;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 48;
		obj4 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [calledFromSynchronize @ L1 (System.Boolean)+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21+8]");
		bool flag = (nint)0 == 0;
		ICloudItem[] array = default;
		if (flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [calledFromSynchronize @ L1 (System.Boolean)+C]");
			array = (ICloudItem[])0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		}
		string text = (string)(obj2 + 32);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [calledFromSynchronize @ L1 (System.Boolean)+10]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28+C]");
		if ((nint)0 == 0)
		{
			goto IL_0b7d;
		}
		Metadata meta = _meta;
		Dictionary<string, ItemMetadata>.KeyCollection keys = meta.items.Keys;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<string> list = default;
		list._002Ector((IEnumerable<string>)keys);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		predicate = (Predicate<ICloudItem>)(object)text;
		_ = text.m_stringLength;
		object obj7 = default;
		nint num = default;
		object obj9 = default;
		object obj10 = default;
		object obj11 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj8 = num + 8;
			obj8 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			((Predicate<ICloudItem>)5519)._002Ector(obj10, (IntPtr)num);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			nint num2;
			if (obj11 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj12 != null)
				{
					num2 = 0;
					continue;
				}
			}
			Metadata meta2 = _meta;
			Metadata meta3 = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			num2 = 0;
		}
		object obj13 = 35;
		object obj14 = obj13 - 15;
		if ((nint)obj13 != 15 && (nint)obj14 != 1 && (nint)obj14 != 2 && (nint)obj14 != 3)
		{
			if ((nint)obj14 != 4 && (nint)obj14 != 5)
			{
				if ((nint)obj14 == 6)
				{
					goto IL_061e;
				}
				if ((nint)obj14 != 7 && (nint)obj14 != 8 && (nint)obj14 != 9 && (nint)obj14 != 10 && (nint)obj14 != 11 && (nint)obj14 != 12 && (nint)obj14 != 13 && (nint)obj14 != 14)
				{
					if ((nint)obj14 == 15 || (nint)obj14 == 16 || (nint)obj14 == 17 || (nint)obj14 == 18 || (nint)obj14 == 19)
					{
						goto IL_061e;
					}
					if ((nint)obj14 == 20)
					{
						object obj15 = obj4 + 4;
						object obj16 = obj15 + 1;
						obj15 = obj16;
						object obj17 = obj16 << 2;
						object obj18 = obj4 + obj17;
						obj18 = 224;
					}
				}
			}
			goto IL_0c92;
		}
		goto IL_061e;
		IL_061e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj19 = default;
		object obj20 = default;
		if (obj19 == obj20)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0c92;
		IL_0c92:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Object)+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Object)+4]");
			object obj21 = (nint)0 << 2;
			object obj22 = obj4 + obj21;
			if ((nint)obj22 == 224)
			{
				object obj23 = obj4 + 4;
				if ((nint)obj23 > -1)
				{
					object obj24 = obj23 + -1;
					obj23 = obj24;
				}
				goto IL_0cb7;
			}
		}
		object obj25 = default;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0cb7;
		IL_0b7d:
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [calledFromSynchronize @ L1 (System.Boolean)+8]");
			string msg = string.ConcatArray((string[])0, (int)": Failed");
			Log(msg);
		}
		return flag;
		IL_0cb7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28+C]");
		object obj26 = (nint)0 + (nint)12;
		object obj45;
		object obj29 = default;
		UpdateContext context = default;
		string text2 = default;
		Predicate<ICloudItem> predicate2 = default;
		KilooAuth.DetachPlatformsCompleteHandler detachPlatformsCompleteHandler = default;
		Dictionary<string, string> newUserData = default;
		System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
		SearchOption searchOption = default;
		for (object obj27 = 0; System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj27) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj26); obj45 = obj27 + 1, obj27 = obj45)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			object obj28 = obj29 + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v28+C]");
			object obj30 = (nint)0 + (nint)16;
			object obj31 = obj27 << 2;
			object obj32 = obj30 + obj31;
			obj28 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			bool flag2 = ProcessUpdateResult(context);
			bool flag3 = flag2;
			if (flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ S0_v87 (System.Boolean)+8]");
				if (text2.get_Chars(0) == '\0')
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				_ = 0;
				object obj33 = predicate2 + 16;
				obj33 = obj29;
				ICloudItem cloudItem = Array.Find(array, predicate2);
				if (cloudItem != null)
				{
					Metadata meta4 = _meta;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [calledFromSynchronize @ L1 (System.Boolean)+10]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ S0_v84+8]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ S2_v54+8]");
					detachPlatformsCompleteHandler._002Ector(num4, (IntPtr)0);
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v848 @ S4_v27 (Il2CppMethodInfo)+C]");
					object obj35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ S4_v28+60]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ S4_v29+48]");
					nint num2 = 0;
					object obj37 = num2 & 0x7FF;
					object obj38 = obj37 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v473 @ S5_v3 (should have been resolved before IL gen)");
					continue;
				}
			}
			Metadata meta5 = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			if (flag3)
			{
				ItemMetadata itemMetadata = ((ItemMetadata)flag2).WithIsModified(newIsModified: true);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				ItemMetadata itemMetadata2 = itemMetadata.WithUserData(newUserData);
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ S4_v17 (Il2CppMethodInfo)+C]");
				object obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ S4_v18+60]");
				object obj40 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ S4_v19+48]");
				nint num2 = 0;
				object obj41 = num2 & 0x7FF;
				object obj38 = obj41 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v473 @ S5_v3 (should have been resolved before IL gen)");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				obj2 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v12+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				text = (string)obj2;
				string text3 = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				text3.m_stringLength = 0;
				((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)null, text, (string)1, (string)null, searchOption, (System.IO.SearchResultHandler<TSource>)null, false);
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ S4_v8 (Il2CppMethodInfo)+C]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ S4_v9+60]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ S4_v10+48]");
				nint num2 = 0;
				object obj44 = num2 & 0x7FF;
				object obj38 = obj44 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v473 @ S5_v3 (should have been resolved before IL gen)");
			}
		}
		Metadata meta6 = _meta;
		if (meta6.kilooTag == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj46 = default;
			if (obj46 != null)
			{
				object obj47 = _meta + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj48 = default;
				obj47 = obj48;
			}
		}
		LogError((string)(object)this);
		goto IL_0b7d;
	}

	private CommitContext PrepareUpdateMetadataContext(string method)
	{
		//IL_0082: Expected I4, but got Obj
		//IL_00a8: Expected Obj, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0044: Expected I4, but got Obj
		IEnumerator enumerator = CommitCoroutine((CompleteHandler)(object)"Commit", (byte)(int)method != 0);
		bool flag2;
		if (enumerator != null)
		{
			_isCommitting = true;
			object obj = enumerator + 16;
			Metadata meta = _meta;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
			object obj2 = default;
			obj = obj2;
			bool flag = Commit((byte)(int)enumerator != 0);
			_isCommitting = false;
			flag2 = flag;
		}
		else
		{
			flag2 = false;
		}
		return (CommitContext)flag2;
	}

	private IEnumerator UpdateMetadataCoroutine(CompleteHandler completeHandler)
	{
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected Obj, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected Obj, but got Unknown
		//IL_007e: Expected I4, but got Obj
		//IL_00cf: Expected I4, but got Obj
		if (~(_isUpdating ? 1u : 0u) == 0 || ~(_isCommitting ? 1u : 0u) == 0 || ~(_isMetadataUpdating ? 1u : 0u) == 0 || _isSynchronizing)
		{
			string msg = string.ConcatArray((string[])(object)completeHandler, (int)": Cannot update metadata while another update or commit operation is running.");
			Log(msg);
			return null;
		}
		string text = kilooTag;
		if (text != null)
		{
			string msg2 = string.ConcatArray((string[])(object)completeHandler, (int)": Working copy belongs to another account.");
			Log(msg2);
			return null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		IEnumerator enumerator = default;
		object obj = enumerator + 8;
		obj = completeHandler;
		object obj2 = enumerator + 12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj3 = default;
		obj2 = obj3;
		return enumerator;
	}

	private IEnumerator SynchronizeCoroutine(CloudConflictResolver conflictResolver, SynchronizeCompleteHandler completeHandler)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 28;
		obj2 = conflictResolver;
		object obj3 = completeHandler & 1;
		return enumerator;
	}

	private static void LogError(string msg)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
	}

	private static void LogEach<T>(IEnumerable<T> items, Action<T> logMethod)
	{
		//IL_0030: Expected Obj, but got I
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [items @ L0 (System.Collections.Generic.IEnumerable`1<T>)+8]");
		Delegate obj = (Delegate)0;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)logMethod);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @81FC");
			object obj3 = items + 8;
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

	private static void Log(string msg)
	{
		//IL_0060: Expected I4, but got Obj
		//IL_0072: Expected I, but got Obj
		//IL_0088: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string exception = string.ConcatArray((string[])(object)"[CloudWorkingCopy] ", (int)msg);
		nint num = (nint)typeof(Debug);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S1_v4 (Il2CppClass<UnityEngine.Debug>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Debug);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9 (Il2CppClass<UnityEngine.Debug>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Debug.LogException((Exception)(object)exception);
	}

	private ICloudItem _003CGetItems_003Eb__29_1(_003C_003Ef__AnonymousType1<KeyValuePair<string, ItemMetadata>, ItemMetadata> _003C_003Eh__TransparentIdentifier0)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		ICloudItem cloudItem = default;
		object obj = cloudItem + 16;
		obj = this;
		object obj2 = cloudItem + 24;
		obj2 = _003C_003Eh__TransparentIdentifier0;
		return cloudItem;
	}

	private unsafe string _003CGetFiles_003Eb__32_0(KeyValuePair<string, ItemMetadata> item)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00b0: Expected Obj, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected Obj, but got Unknown
		//IL_00c7: Expected Obj, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected Obj, but got Unknown
		//IL_00e4: Expected Obj, but got I4
		//IL_00f3: Expected Obj, but got I4
		//IL_0116: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected I4, but got Unknown
		//IL_013a: Expected Obj, but got I
		//IL_0147: Expected I4, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_01b8: Expected Obj, but got I
		//IL_01c5: Expected Obj, but got I4
		//IL_0214: Expected F4, but got I
		//IL_020f: Expected native int or pointer, but got VT
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0241: Expected I4, but got Obj
		//IL_0292: Expected VT, but got I4
		//IL_0292: Expected I4, but got Obj
		//IL_0292: Expected I4, but got Obj
		//IL_0292: Expected I4, but got Obj
		//IL_0292: Expected Obj, but got I
		//IL_0292: Expected VT, but got Obj
		//IL_0012: Expected Obj, but got I4
		//IL_002f: Expected Obj, but got I
		//IL_004e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 + 48;
		obj = 0;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		_ = 0;
		obj2 = 0;
		_ = 0;
		obj = item.key;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata>)+10]");
		object obj5 = 0;
		bool flag = (byte)(obj2 + 56) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata>)+10]");
		object obj6 = (nint)0 + (nint)16;
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj6 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ S1_v18+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata>)+10]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v38+21]");
		bool isActive = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata>)+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v44+20]");
		bool flag2 = (nint)0 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata>)+10]");
		object obj9 = 0;
		obj4 = ((bool*)(flag ? 1 : 0))->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v33 (System.Boolean)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ S0_v56+2C]");
		CloudWorkingCopy cloudWorkingCopy2;
		if ((nint)0 != 0)
		{
			obj3 = ((bool*)(flag ? 1 : 0))->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v33 (System.Boolean)+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [item @ L1 (System.Collections.Generic.KeyValuePair`2<System.String, Kiloo.Common.Backend.Cloud.CloudWorkingCopy+ItemMetadata>)+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v81+2C]");
			CloudWorkingCopy cloudWorkingCopy = default;
			cloudWorkingCopy.itemUpdated += (EventHandler<CloudItemUpdatedArgs>)0;
			obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v11+8]");
			_ = 0;
			cloudWorkingCopy2 = cloudWorkingCopy;
		}
		else
		{
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v14+8]");
			_ = 0;
			cloudWorkingCopy2 = null;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Color color = default;
		((Color*)(nint)color)->b = num;
		_ = 0;
		object obj11 = color + 16;
		obj11 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		((bool*)(flag ? 1 : 0))->m_value = (byte)(int)obj2 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v28+8]");
		GUIStyle gUIStyle = default;
		gUIStyle.Internal_DrawWithTextSelection((Rect)obj12, (GUIContent)0, flag, isActive, flag2, (byte)(int)sourceDescription__BackingField != 0, (byte)(int)_installationId != 0, _dataVersion, (int)cloudWorkingCopy2, (Color)1, color);
		return (string)(object)gUIStyle;
	}

	private ICloudItem _003CPrepareUpdateContext_003Eb__67_2(_003C_003Ef__AnonymousType2<KeyValuePair<string, ItemMetadata>, ItemMetadata> _003C_003Eh__TransparentIdentifier0)
	{
		return (ICloudItem)GetLocalItemFileStream((LocalItem)(object)_003C_003Eh__TransparentIdentifier0);
	}

	private ICloudItem _003CPrepareCommitContext_003Eb__72_1(KeyValuePair<string, ItemMetadata> entry)
	{
		//IL_000e: Expected Obj, but got I4
		object obj = 0;
		obj = entry.key;
		return (ICloudItem)GetItemMetadata((string)obj);
	}
}
