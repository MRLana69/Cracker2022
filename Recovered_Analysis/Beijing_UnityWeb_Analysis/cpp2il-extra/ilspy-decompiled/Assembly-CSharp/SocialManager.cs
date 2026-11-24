using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using AppRefresh;
using Cpp2ILInjected;
using Data.Save;
using Info;
using Kiloo;
using Kiloo.Common.OnGUIWrappers;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.GameCenter;
using Kiloo.Plugins.Facebook;
using Missions;
using SYBO.Common.Utilities;
using UI.Screens;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class SocialManager : MonoBehaviour
{
	public enum SocialPictureSize
	{
		Normal,
		Large
	}

	public enum FacebookState
	{
		None,
		Error,
		LoggingIn,
		LoggedIn,
		Opening
	}

	private enum FacebookPermissionCheckState
	{
		Waiting,
		Ok,
		Missing,
		LoggedOut,
		Error
	}

	private class FacebookPermissionCheck
	{
		public FacebookPermissionCheckState state;

		public FacebookPermissionCheck()
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009c: Expected Obj, but got VT
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected Obj, but got Unknown
			//IL_00bc: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<System.DateTime>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v18 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj2 = DateTime.MinValue;
			object obj3 = obj2 + 8;
			obj3 = obj2;
			state = (FacebookPermissionCheckState)obj3;
		}
	}

	public enum WWWRequestResult
	{
		Success,
		Error
	}

	public delegate void WWWComplete(WWWRequestResult result, string output, object cookie);

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<Friend> _003C_003E9__84_0;

		public static Comparison<Friend> _003C_003E9__85_0;

		public static Action _003C_003E9__89_0;

		public static Action<RefreshType> _003C_003E9__89_1;

		public static Predicate<Friend> _003C_003E9__97_0;

		public static Action<Friend> _003C_003E9__97_1;

		public static Predicate<Friend> _003C_003E9__113_0;

		public static Action<Friend> _003C_003E9__113_1;

		public static Comparison<FacebookProfile> _003C_003E9__128_3;

		public static FacebookSession.DialogCompleteHandler _003C_003E9__130_0;

		public static Comparison<Friend> _003C_003E9__133_0;

		public static FacebookSession.DialogCompleteHandler _003C_003E9__133_1;

		public static Action<bool> _003C_003E9__143_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Tunnel._003C_003Ec obj = default;
			Tunnel._003C_003Ec._003C_003E9 = obj;
		}

		internal int _003CFriendsSortedByScore_003Eb__84_0(Friend x, Friend y)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			int result = default;
			return result;
		}

		internal int _003CFriendsSortedByCash_003Eb__85_0(Friend x, Friend y)
		{
			return y.score - x.score;
		}

		internal void _003CInit_003Eb__89_0()
		{
		}

		internal void _003CInit_003Eb__89_1(RefreshType refreshType)
		{
			throw new InvalidOperationException();
		}

		internal bool _003CClearGameCenter_003Eb__97_0(Friend item)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManager+<>c)+8]");
			return (nint)0 == item.userid;
		}

		internal void _003CClearGameCenter_003Eb__97_1(Friend item)
		{
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected Obj, but got Unknown
			//IL_0119: Expected Obj, but got I4
			//IL_006f: Expected I, but got Obj
			//IL_0085: Expected Obj, but got I
			//IL_015a: Expected Obj, but got I4
			//IL_002e: Expected Obj, but got I4
			//IL_00b0: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 4;
			obj = item;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			obj2 = 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Enum obj3 = default;
			IFormatProvider provider = default;
			if (!obj3.System_002EIConvertible_002EToBoolean(provider))
			{
				obj = item;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				obj2 = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Enum obj4 = default;
				IFormatProvider provider2 = default;
				if (!obj4.System_002EIConvertible_002EToBoolean(provider2))
				{
					return;
				}
			}
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v20 (Il2CppClass<SocialManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v28 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool facebookDialogsSupported = SocialManager.facebookDialogsSupported;
			_ = 0;
			bool facebookDialogsSupported2 = SocialManager.facebookDialogsSupported;
			((SocialManager)facebookDialogsSupported2).Awake();
		}

		internal bool _003CFacebookLogout_003Eb__113_0(Friend item)
		{
			if (item.gcProfile != null)
			{
				return item.fbProfile == null;
			}
			return false;
		}

		internal void _003CFacebookLogout_003Eb__113_1(Friend item)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0017: Expected Obj, but got I4
			object obj = item + 28;
			obj = 0;
		}

		internal int _003CFacebookLoginCoroutine_003Eb__128_3(FacebookProfile p1, FacebookProfile p2)
		{
			//IL_0010: Expected Obj, but got I
			//IL_0092: Expected Obj, but got I
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Expected Obj, but got Unknown
			//IL_00bc: Expected Obj, but got I
			//IL_0100: Expected Obj, but got I
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Expected Obj, but got Unknown
			//IL_0127: Expected I4, but got Obj
			//IL_0054: Expected Obj, but got I
			//IL_0073: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p2 @ L2 (FacebookProfile)+28]");
			object obj = 0;
			Texture2D image = p2.image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v4 @ S1_v2+10]");
			if ((nint)image < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p2 @ L2 (FacebookProfile)+28]");
				object obj2 = 0;
				_ = p2.image;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p2 @ L2 (FacebookProfile)+28]");
			object obj3 = 0;
			Texture2D image2 = p2.image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v6+10]");
			object obj4 = image2 - 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p1 @ L1 (FacebookProfile)+28]");
			object obj5 = 0;
			Texture2D image3 = p1.image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v2+10]");
			if ((nint)image3 < 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p1 @ L1 (FacebookProfile)+28]");
				object obj6 = 0;
				_ = p1.image;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p1 @ L1 (FacebookProfile)+28]");
			object obj7 = 0;
			Texture2D image4 = p1.image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S2_v6+10]");
			object obj8 = image4 - 0;
			return obj4 - obj8;
		}

		internal void _003CRecommendAppFacebook_003Eb__130_0(IDictionary<string, object> result, FacebookError error)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected Obj, but got Unknown
			object obj = this + 16;
			obj = result;
		}

		internal int _003CBragFacebook_003Eb__133_0(Friend x, Friend y)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_00af: Expected Obj, but got I4
			//IL_00af: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(Utils);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v2 (Il2CppClass<Utils>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v7 (Il2CppClass<Utils>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return ((string)x.userid).EndsWith((string)y.userid, StringComparison.InvariantCulture) ? 1 : 0;
		}

		internal void _003CBragFacebook_003Eb__133_1(IDictionary<string, object> result, FacebookError error)
		{
			//IL_00e5: Expected I, but got Obj
			//IL_00fb: Expected Obj, but got I
			//IL_003a: Expected I, but got Obj
			//IL_0050: Expected Obj, but got I
			//IL_0173: Expected I, but got Obj
			//IL_0189: Expected Obj, but got I
			//IL_0126: Expected I, but got Obj
			//IL_0256: Expected VT, but got Obj
			//IL_007b: Expected I, but got Obj
			//IL_01b4: Expected I, but got Obj
			if (result != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				object obj = default;
				if (obj != null)
				{
					nint num = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v26 (Il2CppClass<Flurry>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num2 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v30 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return;
				}
			}
			if (error == null)
			{
				return;
			}
			nint num3 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v11 (Il2CppClass<Strings>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v18 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("FACEBOOK");
			string text2 = Strings.GetDefault("FACEBOOK_DIALOG_ERROR_MESSAGE");
			string content = Strings.GetDefault("OK");
			nint num5 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S3_v5 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S3_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((GUIArea)(object)text)._002Ector((Rect)text2, content, (string)null);
		}

		internal void _003CInvalidate_003Eb__143_0(bool success)
		{
			//IL_000e: Expected Obj, but got I4
			//IL_0017: Expected Obj, but got I4
			object obj = (success ? 1 : 0) + 32;
			obj = 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass125_0
	{
		public FacebookPermissionCheck check;

		public SocialManager _003C_003E4__this;

		internal void _003CFacebookCheckPermissionsCoroutine_003Eb__0(IDictionary<string, object> result, FacebookError error, bool isFromCache)
		{
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_00c6: Expected Obj, but got I
			//IL_011b: Expected Obj, but got I
			//IL_0138: Expected Obj, but got I4
			//IL_0402: Expected Obj, but got I
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0410: Expected I4, but got Unknown
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Expected Obj, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected I4, but got Unknown
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected Obj, but got Unknown
			//IL_026b: Expected Obj, but got I
			//IL_0331: Expected Obj, but got I
			//IL_02f5: Expected Obj, but got I
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Expected Obj, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManager+<>c__DisplayClass125_0)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManager+<>c__DisplayClass125_0)+34]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManager+<>c__DisplayClass125_0)+34]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+14]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v19+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v19+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag = obj11 == null;
				object obj12 = (flag ? 1 : 0) ^ 1;
				bool flag2;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v19+2A]");
					if ((nint)0 == 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x1FFF;
						object obj14 = obj13 + 113696;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v120 @ S4_v17 (should have been resolved before IL gen)");
						flag2 = true;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
						object obj15 = (nint)0 & (nint)0x7FF;
						flag2 = (byte)(obj15 + 121922) != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S5_v6 (System.Boolean) (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v19+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
					bool flag3;
					if ((nint)0 != 0)
					{
						object obj16 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ S0_v62+9C]");
						object obj17 = (nint)0 & (nint)0x100;
						flag3 = obj17 != null;
					}
					else
					{
						flag3 = false;
					}
					if (!flag3 && (object)_003C_003E4__this != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+10]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
							object obj18 = (nint)0 & (nint)0x1FFF;
							object obj19 = obj18 + 113696;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v173 @ S4_v12 (should have been resolved before IL gen)");
							flag2 = true;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v19+2B]");
						object obj20 = (nint)0 & (nint)3;
						bool flag4 = (nint)obj20 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag4)
						{
							if (obj21 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8961");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8962");
							}
						}
						else if (obj21 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
							flag2 = isFromCache;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v14+8]");
				object obj22 = (nint)0 & (nint)0x7FF;
				flag2 = (byte)(obj22 + 121922) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v172 @ S5_v6 (System.Boolean) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class _003CFacebookCheckPermissionsCoroutine_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookPermissionCheck check;

		public SocialManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass125_0 _003C_003E8__1;

		private float _003CtimeLeftBeforeGivingUp_003E5__2;

		private float _003ClastRealTime_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_003f: Expected Obj, but got Unknown
				//IL_005c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Expected Obj, but got Unknown
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Expected Obj, but got Unknown
				//IL_0093: Expected I, but got Obj
				//IL_00a9: Expected Obj, but got I
				//IL_0330: Expected Obj, but got I
				//IL_0340: Expected Obj, but got I
				//IL_0351: Unknown result type (might be due to invalid IL or missing references)
				//IL_0356: Expected Obj, but got Unknown
				//IL_035f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0364: Expected Obj, but got Unknown
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Expected Obj, but got Unknown
				//IL_016a: Unknown result type (might be due to invalid IL or missing references)
				//IL_016f: Expected Ref, but got Unknown
				//IL_0175: Unknown result type (might be due to invalid IL or missing references)
				//IL_017a: Expected Ref, but got Unknown
				//IL_00d4: Expected I, but got Obj
				//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01bc: Expected Obj, but got Unknown
				//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Expected Obj, but got Unknown
				//IL_029b: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Expected Obj, but got Unknown
				//IL_02a9: Expected Obj, but got I4
				//IL_02bd: Expected Obj, but got I4
				//IL_0215: Expected I, but got Obj
				//IL_022b: Expected Obj, but got I
				//IL_0256: Expected I, but got Obj
				object result;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						result = null;
						goto IL_037d;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj2 = default;
					obj = obj2;
					object obj3 = _003C_003E8__1 + 8;
					obj3 = check;
					object obj4 = _003C_003E8__1 + 12;
					obj4 = _003C_003E4__this;
					nint num = (nint)typeof(FacebookSession);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v45 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					if (obj5 != null)
					{
						nint num2 = (nint)typeof(FacebookSession);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v52 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
					_003C_003Ec__DisplayClass125_0 obj6 = _003C_003E8__1;
					FacebookPermissionCheck facebookPermissionCheck = obj6.check;
					facebookPermissionCheck.state = FacebookPermissionCheckState.Waiting;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S4_v4 (Il2CppMethodInfo)+C]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ S4_v5+60]");
					object obj8 = 0;
					object obj9 = obj8;
					object obj10 = obj9 & 0x1FFF;
					object obj11 = obj10 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v157 @ S5_v6 (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint method_ptr = 0;
					FacebookSession.RequestCompleteHandler requestCompleteHandler = default;
					((Delegate)requestCompleteHandler).method_ptr = method_ptr;
					((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass125_0._003CFacebookCheckPermissionsCoroutine_003Eb__0);
					object obj12 = requestCompleteHandler + 16;
					obj12 = _003C_003E8__1;
					FacebookSession facebookSession = default;
					string graphPath = default;
					facebookSession.UploadPhotoRequest((Texture2D)(object)"me/permissions", graphPath, null, requestCompleteHandler);
					_003C_003E4__this.UpdateTimeLeft(ref *(float*)(this + 32), ref *(float*)(this + 28));
				}
				while (true)
				{
					_003C_003Ec__DisplayClass125_0 obj13 = _003C_003E8__1;
					FacebookPermissionCheck facebookPermissionCheck2 = obj13.check;
					result = null;
					if (facebookPermissionCheck2.state != FacebookPermissionCheckState.Waiting)
					{
						break;
					}
					FacebookProfile profile = (FacebookProfile)(this + 32);
					Texture2D picture = (Texture2D)(this + 28);
					_003C_003E4__this.OnDownloadedFacebookPicture(profile, picture);
					if (!(_003CtimeLeftBeforeGivingUp_003E5__2 > 0f))
					{
						nint num4 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ S0_v21 (Il2CppClass<SocialManager>)+BA]");
						object obj14 = (nint)0 & (nint)0x200;
						if (obj14 != null)
						{
							nint num5 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v30 (Il2CppClass<SocialManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
						_003C_003Ec__DisplayClass125_0 obj15 = _003C_003E8__1;
						FacebookPermissionCheck facebookPermissionCheck3 = obj15.check;
						facebookPermissionCheck3.state = FacebookPermissionCheckState.Error;
						continue;
					}
					object obj16 = this + 12;
					obj16 = 0;
					_003C_003E1__state = 1;
					result = 1;
					break;
				}
				goto IL_037d;
				IL_037d:
				return result;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CFacebookCheckPermissionsCoroutine_003Ed__125(int _003C_003E1__state)
		{
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

	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public float timeLeftBeforeGivingUp;

		public SocialManager _003C_003E4__this;

		public FacebookSession fbSession;

		public bool asynchronousRequestsCompleted;

		public Action<bool> onComplete;

		public FacebookSession.RequestCompleteHandler _003C_003E9__2;

		public _003C_003Ec__DisplayClass128_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CFacebookLoginCoroutine_003Eb__0(IDictionary<string, object> result, FacebookError error, bool isFromCache)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0904: Unknown result type (might be due to invalid IL or missing references)
			//IL_0909: Expected Obj, but got Unknown
			//IL_0912: Expected Obj, but got I4
			//IL_091b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0920: Expected Obj, but got Unknown
			//IL_0929: Expected Obj, but got I4
			//IL_0021: Expected I, but got Obj
			//IL_0037: Expected Obj, but got I
			//IL_0062: Expected I, but got Obj
			//IL_01d1: Expected I, but got Obj
			//IL_01e7: Expected Obj, but got I
			//IL_0212: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = obj2 + 12;
			obj3 = 0;
			object obj4 = obj2 + 8;
			obj4 = 0;
			obj2 = obj;
			_ = -1;
			float num = timeLeftBeforeGivingUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (System.Single)+8]");
			if ((nint)0 != 0)
			{
				return;
			}
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v24 (Il2CppClass<SocialManager>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num3 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v367 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
				float num4 = timeLeftBeforeGivingUp;
				_ = 3;
			}
			else if (result != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj7 = default;
				if (obj7 == null)
				{
					nint num5 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ S0_v271 (Il2CppClass<SocialManager>)+BA]");
					object obj8 = (nint)0 & (nint)0x200;
					if (obj8 != null)
					{
						nint num6 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ S0_v287 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj10 = default;
					object obj9 = obj10;
					object obj12 = default;
					object obj11 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
					object obj13 = default;
					if (obj9 == obj13)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						object obj15 = default;
						object obj14 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
						object obj17 = default;
						object obj16 = obj17;
					}
					else
					{
						object obj16 = obj11;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
			}
			float num7 = timeLeftBeforeGivingUp;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ S0_v313 (System.Single)+8]");
			if ((nint)0 == 0)
			{
				float num8 = timeLeftBeforeGivingUp;
				_ = 4;
			}
		}

		internal unsafe void _003CFacebookLoginCoroutine_003Eb__2(IDictionary<string, object> friendsResult, FacebookError friendsError, bool friendsIsFromCache)
		{
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Expected Obj, but got Unknown
			//IL_0528: Expected Obj, but got I4
			//IL_0531: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			//IL_0029: Expected Obj, but got I
			//IL_0054: Expected I, but got Obj
			//IL_05c2: Expected I, but got Obj
			//IL_05d8: Expected Obj, but got I
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Expected Obj, but got Unknown
			//IL_04d2: Expected I, but got Obj
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Expected Obj, but got Unknown
			//IL_017c: Expected Obj, but got I4
			//IL_074c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0751: Expected Obj, but got Unknown
			//IL_01ca: Expected Obj, but got I4
			//IL_016e: Expected Obj, but got I4
			//IL_07a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a5: Expected Obj, but got Unknown
			//IL_0218: Expected Obj, but got I4
			//IL_01bc: Expected Obj, but got I4
			//IL_020a: Expected Obj, but got I4
			//IL_024c: Expected Obj, but got I
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Expected Obj, but got Unknown
			//IL_02a7: Expected I, but got Obj
			//IL_02bd: Expected Obj, but got I
			//IL_062c: Expected Obj, but got I4
			//IL_033d: Expected Obj, but got I
			//IL_034d: Expected Obj, but got I
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected Obj, but got Unknown
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Expected Obj, but got Unknown
			//IL_0391: Expected Obj, but got I
			//IL_03a1: Expected Obj, but got I
			//IL_03b1: Expected Obj, but got I
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bf: Expected Obj, but got Unknown
			//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Expected Obj, but got Unknown
			//IL_03e5: Expected I, but got Obj
			//IL_03fb: Expected Obj, but got I
			//IL_02e8: Expected I, but got Obj
			//IL_0664: Expected Obj, but got I
			//IL_0674: Expected Obj, but got I
			//IL_0684: Expected Obj, but got I
			//IL_068d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0692: Expected Obj, but got Unknown
			//IL_069b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a0: Expected Obj, but got Unknown
			//IL_0426: Expected I, but got Obj
			//IL_049a: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Expected Obj, but got Unknown
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 4;
			obj = 0;
			obj2 = 0;
			if (!(timeLeftBeforeGivingUp > 0f))
			{
				return;
			}
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v18 (Il2CppClass<SocialManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v80 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Coroutine coroutine = ((SocialManager)(object)friendsError).FacebookCheckPermissionsAsync((FacebookPermissionCheck)friendsResult);
			if (coroutine != null)
			{
				_003C_003E4__this.RecommendAppFacebook();
			}
			else if (friendsResult != null)
			{
				object obj4 = _003C_003E4__this + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj5 = default;
				obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
				SocialManager socialManager = _003C_003E4__this;
				object obj6 = socialManager._fbProfile + 8;
				object obj7 = obj;
				if (obj != null)
				{
					if (obj7 != typeof(string))
					{
						obj7 = 0;
					}
				}
				else
				{
					obj7 = 0;
				}
				obj6 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
				SocialManager socialManager2 = _003C_003E4__this;
				object obj8 = socialManager2._fbProfile + 12;
				object obj9 = obj;
				if (obj != null)
				{
					if (obj9 != typeof(string))
					{
						obj9 = 0;
					}
				}
				else
				{
					obj9 = 0;
				}
				obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
				SocialManager socialManager3 = _003C_003E4__this;
				object obj10 = socialManager3._fbProfile + 16;
				object obj11 = obj;
				if (obj != null)
				{
					if (obj11 != typeof(string))
					{
						obj11 = 0;
					}
				}
				else
				{
					obj11 = 0;
				}
				obj10 = obj11;
				SocialManager socialManager4 = _003C_003E4__this;
				FacebookProfile fbProfile = socialManager4._fbProfile;
				if (fbProfile.id != null)
				{
					SocialManager socialManager5 = _003C_003E4__this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num3 = 0;
					string[] array = default;
					array[1] = (string)0;
					object obj12 = array + 16;
					obj12 = _003C_003E4__this;
					IEnumerator routine = WWWRequestCoroutine((WWWComplete)(object)_003C_003E4__this, (string)(object)socialManager5._fbProfile, null, array);
					Coroutine coroutine2 = _003C_003E4__this.StartCoroutine_Auto(routine);
					nint num4 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v67 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num5 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v74 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string saveDataPath = OnlineSettings.GetSaveDataPath();
					uint value = ((OnlineSettings)(object)saveDataPath).GetValue("social_facebook_fetch_max_users", 5000u);
					obj2 = value;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S4_v15 (Il2CppMethodInfo)+C]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S4_v16+60]");
					object obj15 = 0;
					object obj16 = obj15;
					object obj17 = obj16 & 0x1FFF;
					object obj18 = obj17 + 113696;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v321 @ S5_v6 (should have been resolved before IL gen)");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S5_v8 (Il2CppMethodInfo)+C]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ S5_v9+60]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ S5_v10+48]");
					object obj21 = 0;
					object obj22 = obj21 & 0x7FF;
					object obj23 = obj22 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v339 @ S6_v7 (should have been resolved before IL gen)");
					nint num8 = (nint)typeof(CultureInfo);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ S1_v51 (Il2CppClass<System.Globalization.CultureInfo>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num9 = (nint)typeof(CultureInfo);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ S1_v61 (Il2CppClass<System.Globalization.CultureInfo>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					CultureInfo currentCulture = CultureInfo.CurrentCulture;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D55B");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S5_v13 (Il2CppMethodInfo)+C]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S5_v14+60]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S5_v15+48]");
					object obj27 = 0;
					object obj28 = obj27 & 0x7FF;
					object obj29 = obj28 + 39195;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47 @ S6_v11 (should have been resolved before IL gen)");
					bool flag = _003C_003E9__2 == null;
					bool flag2 = !flag;
					FacebookSession.RequestCompleteHandler requestCompleteHandler = _003C_003E9__2;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint method_ptr = 0;
						FacebookSession.RequestCompleteHandler requestCompleteHandler2 = default;
						((Delegate)requestCompleteHandler2).method_ptr = method_ptr;
						((Delegate)requestCompleteHandler2).method = (nint)__ldftn(_003C_003Ec__DisplayClass128_0._003CFacebookLoginCoroutine_003Eb__2);
						object obj30 = requestCompleteHandler2 + 16;
						obj30 = this;
						object obj31 = this + 28;
						obj31 = requestCompleteHandler2;
						requestCompleteHandler = requestCompleteHandler2;
					}
					string graphPath = default;
					fbSession.UploadPhotoRequest((Texture2D)(object)"me/friends", graphPath, null, requestCompleteHandler);
					return;
				}
			}
			asynchronousRequestsCompleted = true;
			string text = "FacebookLogin: Error getting user info, error: " + (string)(object)friendsError;
			nint num11 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S2_v6 (Il2CppClass<SocialManager>)+BA]");
			object obj32 = (nint)0 & (nint)0x200;
			if (obj32 != null)
			{
				nint num12 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ S2_v13 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			_003C_003E4__this.OnFacebookSessionStatusChanged(FacebookSession.State.CREATED, (FacebookError)(object)onComplete);
		}
	}

	private sealed class _003C_003Ec__DisplayClass128_1
	{
		public FacebookSession.StatusChangedHandler statusChangedHandler;

		public bool statusDidChange;

		internal void _003CFacebookLoginCoroutine_003Eb__1(FacebookSession.State status, FacebookError error)
		{
			//IL_001a: Expected Obj, but got I4
			statusChangedHandler((Friend)statusDidChange, (Texture2D)(object)error);
		}
	}

	private sealed class _003CFacebookLoginCoroutine_003Ed__128(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SocialManager _003C_003E4__this;

		public Action<bool> onComplete;

		private _003C_003Ec__DisplayClass128_0 _003C_003E8__1;

		private _003C_003Ec__DisplayClass128_1 _003C_003E8__2;

		private float _003ClastRealTime_003E5__2;

		private FacebookPermissionCheck _003CpermissionsCheck_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bb: Expected Obj, but got Unknown
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Expected Obj, but got Unknown
				//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f7: Expected Obj, but got Unknown
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0111: Expected Obj, but got Unknown
				//IL_012d: Expected Obj, but got I4
				//IL_0145: Expected I, but got Obj
				//IL_015b: Expected Obj, but got I
				//IL_0204: Expected I, but got Obj
				//IL_021a: Expected Obj, but got I
				//IL_0186: Expected I, but got Obj
				//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bb7: Expected Obj, but got Unknown
				//IL_0bcf: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bd4: Expected Obj, but got Unknown
				//IL_0245: Expected I, but got Obj
				//IL_0c0a: Expected Obj, but got I4
				//IL_0294: Expected Obj, but got I4
				//IL_0564: Unknown result type (might be due to invalid IL or missing references)
				//IL_0569: Expected Obj, but got Unknown
				//IL_0574: Unknown result type (might be due to invalid IL or missing references)
				//IL_0579: Expected Obj, but got Unknown
				//IL_0a2c: Expected I, but got Obj
				//IL_0a42: Expected Obj, but got I
				//IL_0334: Unknown result type (might be due to invalid IL or missing references)
				//IL_0339: Expected Obj, but got Unknown
				//IL_036e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0373: Expected Obj, but got Unknown
				//IL_037c: Expected Obj, but got I4
				//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02bc: Expected Ref, but got Unknown
				//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cc: Expected Ref, but got Unknown
				//IL_060e: Expected Obj, but got I4
				//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_08c8: Expected Ref, but got Unknown
				//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_08d8: Expected Ref, but got Unknown
				//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_03a7: Expected Obj, but got Unknown
				//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_03c1: Expected Obj, but got Unknown
				//IL_03e1: Expected I, but got Obj
				//IL_03f7: Expected Obj, but got I
				//IL_0644: Expected I, but got Obj
				//IL_065a: Expected Obj, but got I
				//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_05dc: Expected Obj, but got Unknown
				//IL_05e5: Expected Obj, but got I4
				//IL_05f9: Expected Obj, but got I4
				//IL_091a: Expected Obj, but got I
				//IL_092a: Expected Obj, but got I
				//IL_093b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0940: Expected Obj, but got Unknown
				//IL_0949: Unknown result type (might be due to invalid IL or missing references)
				//IL_094e: Expected Obj, but got Unknown
				//IL_096e: Expected Obj, but got I
				//IL_097e: Expected Obj, but got I
				//IL_098e: Expected Obj, but got I
				//IL_0997: Unknown result type (might be due to invalid IL or missing references)
				//IL_099c: Expected Obj, but got Unknown
				//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_09aa: Expected Obj, but got Unknown
				//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_09ee: Expected Obj, but got Unknown
				//IL_0e99: Expected Obj, but got I4
				//IL_0731: Unknown result type (might be due to invalid IL or missing references)
				//IL_0736: Expected Obj, but got Unknown
				//IL_0741: Unknown result type (might be due to invalid IL or missing references)
				//IL_0746: Expected Obj, but got Unknown
				//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ba: Expected Obj, but got Unknown
				//IL_04c3: Expected Obj, but got I4
				//IL_0b7a: Expected Obj, but got I4
				//IL_0b2b: Expected I, but got Obj
				//IL_0467: Unknown result type (might be due to invalid IL or missing references)
				//IL_046c: Expected Ref, but got Unknown
				//IL_0477: Unknown result type (might be due to invalid IL or missing references)
				//IL_047c: Expected Ref, but got Unknown
				//IL_0422: Expected I, but got Obj
				//IL_07d9: Expected I, but got Obj
				//IL_07ef: Expected Obj, but got I
				//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_06f5: Expected Obj, but got Unknown
				//IL_0726: Expected Obj, but got I4
				//IL_0685: Expected I, but got Obj
				//IL_0aba: Expected I, but got Obj
				//IL_0ecd: Expected Obj, but got I4
				//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_07a9: Expected Obj, but got Unknown
				//IL_07b2: Expected Obj, but got I4
				//IL_07c6: Expected Obj, but got I4
				//IL_081a: Expected I, but got Obj
				//IL_0c7d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c82: Expected Obj, but got Unknown
				//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0c92: Expected Obj, but got Unknown
				//IL_0d27: Expected Obj, but got I4
				//IL_0d5d: Expected I, but got Obj
				//IL_0d73: Expected Obj, but got I
				//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0cf5: Expected Obj, but got Unknown
				//IL_0cfe: Expected Obj, but got I4
				//IL_0d12: Expected Obj, but got I4
				//IL_0d9e: Expected I, but got Obj
				SocialManager socialManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state != 2)
						{
							if (_003C_003E1__state == 3)
							{
								_003C_003E1__state = -1;
								goto IL_06c4;
							}
							if (_003C_003E1__state != 4)
							{
								if (_003C_003E1__state == 5)
								{
									_003C_003E1__state = -1;
									goto IL_0c0f;
								}
								return null;
							}
							_003C_003E1__state = -1;
							object obj = this + 28;
							obj = 0;
						}
						else
						{
							_003C_003E1__state = -1;
							FacebookPermissionCheck facebookPermissionCheck = _003CpermissionsCheck_003E5__3;
							if (facebookPermissionCheck.state == FacebookPermissionCheckState.Missing)
							{
								object obj2 = this + 28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								object obj3 = default;
								obj2 = obj3;
								_003C_003Ec__DisplayClass128_1 obj4 = _003C_003E8__2;
								obj4.statusDidChange = false;
								object obj5 = _003C_003E8__2 + 8;
								obj5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
								nint num = 0;
								_ = 0;
								object obj7 = default;
								object obj6 = obj7 + 16;
								obj6 = _003C_003E8__2;
								object obj8 = _003C_003E8__2 + 8;
								obj8 = obj7;
								_003C_003Ec__DisplayClass128_1 obj9 = _003C_003E8__2;
								nint num2 = (nint)typeof(FacebookSession);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ S1_v134 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
								object obj10 = (nint)0 & (nint)0x200;
								if (obj10 != null)
								{
									nint num3 = (nint)typeof(FacebookSession);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S1_v144 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								FacebookSession.statusChangedEvent -= obj9.statusChangedHandler;
								_003C_003Ec__DisplayClass128_0 obj11 = _003C_003E8__1;
								int num4 = string.CompareOrdinalIgnoreCaseHelper(",", (string)(object)socialManager.requiredPermissions);
								obj11.fbSession.OnFacebookSessionStateChanged((string)num4);
								ref float lastRealTime = ref *(float*)(this + 32);
								ref float timeLeft = ref *(float*)(_003C_003E8__1 + 8);
								_003C_003E4__this.UpdateTimeLeft(ref lastRealTime, ref timeLeft);
								goto IL_06c4;
							}
						}
						FacebookPermissionCheck facebookPermissionCheck2 = _003CpermissionsCheck_003E5__3;
						if (facebookPermissionCheck2.state == FacebookPermissionCheckState.Ok)
						{
							ref float lastRealTime2 = ref *(float*)(this + 32);
							ref float timeLeft2 = ref *(float*)(_003C_003E8__1 + 8);
							_003C_003E4__this.UpdateTimeLeft(ref lastRealTime2, ref timeLeft2);
							_003C_003Ec__DisplayClass128_0 obj12 = _003C_003E8__1;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S4_v4 (Il2CppMethodInfo)+C]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S4_v5+60]");
							object obj14 = 0;
							object obj15 = obj14;
							object obj16 = obj15 & 0x1FFF;
							object obj17 = obj16 + 113696;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v378 @ S5_v6 (should have been resolved before IL gen)");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S5_v8 (Il2CppMethodInfo)+C]");
							object obj18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ S5_v9+60]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ S5_v10+48]");
							object obj20 = 0;
							object obj21 = obj20 & 0x7FF;
							object obj22 = obj21 + 39195;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v320 @ S6_v8 (should have been resolved before IL gen)");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint method_ptr = 0;
							FacebookSession.RequestCompleteHandler requestCompleteHandler = default;
							((Delegate)requestCompleteHandler).method_ptr = method_ptr;
							((Delegate)requestCompleteHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass128_0._003CFacebookLoginCoroutine_003Eb__0);
							object obj23 = requestCompleteHandler + 16;
							obj23 = _003C_003E8__1;
							string graphPath = default;
							obj12.fbSession.UploadPhotoRequest((Texture2D)(object)"me", graphPath, null, requestCompleteHandler);
							goto IL_0c0f;
						}
						nint num7 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v124 (Il2CppClass<SocialManager>)+BA]");
						object obj24 = (nint)0 & (nint)0x200;
						bool flag = obj24 == null;
						FacebookPermissionCheck facebookPermissionCheck3 = _003CpermissionsCheck_003E5__3;
						if (facebookPermissionCheck3.state == FacebookPermissionCheckState.Missing)
						{
							if (!flag)
							{
								nint num8 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v151 (Il2CppClass<SocialManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
							_003C_003E4__this.RecommendAppFacebook();
						}
						else
						{
							if (!flag)
							{
								nint num9 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ S0_v141 (Il2CppClass<SocialManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
						}
						_003C_003E4__this.BragFacebook((List<Friend>)1);
						_003C_003Ec__DisplayClass128_0 obj25 = _003C_003E8__1;
						_003C_003E4__this.OnFacebookSessionStatusChanged(FacebookSession.State.CREATED, (FacebookError)(object)obj25.onComplete);
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					object obj26 = this + 24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj27 = default;
					obj26 = obj27;
					object obj28 = _003C_003E8__1 + 12;
					obj28 = _003C_003E4__this;
					object obj29 = _003C_003E8__1 + 24;
					obj29 = onComplete;
					object obj30 = _003C_003E8__1 + 16;
					bool flag2 = _003C_003E4__this.HasUnconsolidatedFacebookFriends();
					obj30 = flag2;
					_003C_003Ec__DisplayClass128_0 obj31 = _003C_003E8__1;
					nint num10 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+BA]");
					object obj32 = (nint)0 & (nint)0x200;
					if (obj32 != null)
					{
						nint num11 = (nint)typeof(UnityEngine.Object);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S1_v54 (Il2CppClass<UnityEngine.Object>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag3 = obj31.fbSession != null;
					_003C_003Ec__DisplayClass128_0 obj33 = _003C_003E8__1;
					if (flag3)
					{
						_003C_003E4__this.OnFacebookSessionStatusChanged(FacebookSession.State.CREATED, (FacebookError)(object)obj33.onComplete);
						return null;
					}
					obj33.asynchronousRequestsCompleted = false;
					nint num12 = (nint)typeof(FacebookSession);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v69 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
					object obj34 = (nint)0 & (nint)0x200;
					if (obj34 != null)
					{
						nint num13 = (nint)typeof(FacebookSession);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ S0_v80 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (FacebookSession._IsSupported())
					{
						goto IL_0bac;
					}
					_003C_003E4__this.BragFacebook((List<Friend>)2);
					_003C_003Ec__DisplayClass128_0 obj35 = _003C_003E8__1;
					obj35.fbSession.Cancel();
					ref float lastRealTime3 = ref *(float*)(this + 32);
					ref float timeLeft3 = ref *(float*)(_003C_003E8__1 + 8);
					_003C_003E4__this.UpdateTimeLeft(ref lastRealTime3, ref timeLeft3);
				}
				if (socialManager._fbState != FacebookState.LoggedIn)
				{
					if (socialManager._fbState == FacebookState.Error)
					{
						_003C_003Ec__DisplayClass128_0 obj36 = _003C_003E8__1;
						_003C_003E4__this.OnFacebookSessionStatusChanged(FacebookSession.State.CREATED, (FacebookError)(object)obj36.onComplete);
						return null;
					}
					FacebookProfile profile = (FacebookProfile)(this + 32);
					Texture2D picture = (Texture2D)(_003C_003E8__1 + 8);
					_003C_003E4__this.OnDownloadedFacebookPicture(profile, picture);
					_003C_003Ec__DisplayClass128_0 obj37 = _003C_003E8__1;
					if (obj37.timeLeftBeforeGivingUp > 0f)
					{
						object obj38 = this + 12;
						obj38 = 0;
						_003C_003E1__state = 1;
						return 1;
					}
					_003C_003E4__this.BragFacebook((List<Friend>)1);
					_003C_003Ec__DisplayClass128_0 obj39 = _003C_003E8__1;
					_003C_003E4__this.OnFacebookSessionStatusChanged(FacebookSession.State.CREATED, (FacebookError)(object)obj39.onComplete);
					nint num14 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ S0_v36 (Il2CppClass<SocialManager>)+BA]");
					object obj40 = (nint)0 & (nint)0x200;
					if (obj40 != null)
					{
						nint num15 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ S0_v41 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					return null;
				}
				goto IL_0bac;
				IL_0bac:
				object obj41 = this + 36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj42 = default;
				obj41 = obj42;
				object obj43 = this + 12;
				IEnumerator enumerator = _003C_003E4__this.FacebookCheckPermissionsCoroutine(_003CpermissionsCheck_003E5__3);
				obj43 = enumerator;
				_003C_003E1__state = 2;
				return 1;
				IL_06c4:
				_003C_003Ec__DisplayClass128_1 obj44 = _003C_003E8__2;
				if (~(obj44.statusDidChange ? 1u : 0u) == 0)
				{
					object obj45 = this + 12;
					IEnumerator enumerator2 = _003C_003E4__this.FacebookCheckPermissionsCoroutine(_003CpermissionsCheck_003E5__3);
					obj45 = enumerator2;
					_003C_003E1__state = 4;
					return 1;
				}
				FacebookProfile profile2 = (FacebookProfile)(this + 32);
				Texture2D picture2 = (Texture2D)(_003C_003E8__1 + 8);
				_003C_003E4__this.OnDownloadedFacebookPicture(profile2, picture2);
				_003C_003Ec__DisplayClass128_0 obj46 = _003C_003E8__1;
				if (obj46.timeLeftBeforeGivingUp > 0f)
				{
					object obj47 = this + 12;
					obj47 = 0;
					_003C_003E1__state = 3;
					return 1;
				}
				nint num16 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ S0_v170 (Il2CppClass<SocialManager>)+BA]");
				object obj48 = (nint)0 & (nint)0x200;
				if (obj48 != null)
				{
					nint num17 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ S0_v180 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
				_003C_003E4__this.RecommendAppFacebook();
				_003C_003E4__this.BragFacebook((List<Friend>)1);
				_003C_003Ec__DisplayClass128_0 obj49 = _003C_003E8__1;
				_003C_003E4__this.OnFacebookSessionStatusChanged(FacebookSession.State.CREATED, (FacebookError)(object)obj49.onComplete);
				return null;
				IL_0c0f:
				_003C_003Ec__DisplayClass128_0 obj50 = _003C_003E8__1;
				if (~(obj50.asynchronousRequestsCompleted ? 1u : 0u) != 0)
				{
					_003C_003Ec__DisplayClass128_0 obj51 = _003C_003E8__1;
					if (obj51.timeLeftBeforeGivingUp > 0f)
					{
						FacebookProfile profile3 = (FacebookProfile)(this + 32);
						Texture2D picture3 = (Texture2D)(_003C_003E8__1 + 8);
						_003C_003E4__this.OnDownloadedFacebookPicture(profile3, picture3);
						_003C_003Ec__DisplayClass128_0 obj52 = _003C_003E8__1;
						if (obj52.timeLeftBeforeGivingUp > 0f)
						{
							object obj53 = this + 12;
							obj53 = 0;
							_003C_003E1__state = 5;
							return 1;
						}
						_003C_003E4__this.BragFacebook((List<Friend>)1);
						_003C_003Ec__DisplayClass128_0 obj54 = _003C_003E8__1;
						_003C_003E4__this.OnFacebookSessionStatusChanged(FacebookSession.State.CREATED, (FacebookError)(object)obj54.onComplete);
						nint num18 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ S0_v107 (Il2CppClass<SocialManager>)+BA]");
						object obj55 = (nint)0 & (nint)0x200;
						if (obj55 != null)
						{
							nint num19 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ S0_v110 (Il2CppClass<SocialManager>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

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

	private sealed class _003CDownloadPictureForProfile_003Ed__135(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public FacebookProfile profile;

		public SocialPictureSize pictureSize;

		public Action<FacebookProfile, Texture2D> handler;

		private WWW _003Cwww_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_00e7: Expected I, but got Obj
				//IL_00fd: Expected Obj, but got I
				//IL_0128: Expected I, but got Obj
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Expected Obj, but got Unknown
				//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Expected Obj, but got Unknown
				//IL_00d4: Expected Obj, but got I4
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						bool isDone = _003Cwww_003E5__2.isDone;
						if (handler != null)
						{
							string url = _003Cwww_003E5__2.url;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				if (profile != null)
				{
					FacebookProfile facebookProfile = profile;
					object texture = ((IConvertible)"http://graph.facebook.com/").ToType(provider: (IFormatProvider)(object)((pictureSize == SocialPictureSize.Normal) ? "/picture?width=64&height=64" : "/picture?width=300&height=300"), conversionType: (Type)(object)facebookProfile.id);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					WWW wWW = default;
					wWW.LoadImageIntoTexture((Texture2D)texture);
					object obj = this + 28;
					obj = wWW;
					object obj2 = this + 12;
					obj2 = _003Cwww_003E5__2;
					_003C_003E1__state = 1;
					return 1;
				}
				nint num = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v12 (Il2CppClass<SocialManager>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v19 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

	private sealed class _003CDownloadFacebookPictures_003Ed__137(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public SocialManager _003C_003E4__this;

		public IDictionary<string, FacebookProfile> fbProfiles;

		private int _003CdownloadFacebookPicturesContext_003E5__2;

		private List<FacebookProfile>.Enumerator _003C_003E7__wrap2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0688: Unknown result type (might be due to invalid IL or missing references)
				//IL_068d: Expected Obj, but got Unknown
				//IL_0696: Unknown result type (might be due to invalid IL or missing references)
				//IL_069b: Expected Obj, but got Unknown
				//IL_0810: Unknown result type (might be due to invalid IL or missing references)
				//IL_0815: Expected Obj, but got Unknown
				//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
				//IL_05f7: Expected Obj, but got Unknown
				//IL_04de: Unknown result type (might be due to invalid IL or missing references)
				//IL_04e3: Expected Obj, but got Unknown
				//IL_04a2: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				object obj4 = obj2 + 16;
				obj4 = obj;
				_ = -1;
				SocialManager socialManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1 || _003C_003E1__state == 2)
					{
						_003C_003E1__state = -3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj5 = default;
						if (obj5 != null && _003CdownloadFacebookPicturesContext_003E5__2 == socialManager._downloadFacebookPicturesContext)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							_003C_003E1__state = 2;
							return 1;
						}
						if (_003CdownloadFacebookPicturesContext_003E5__2 != socialManager._downloadFacebookPicturesContext)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						}
						else
						{
							object obj7 = default;
							object obj9 = default;
							while (true)
							{
								object obj6 = this + 28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								if (obj7 == null)
								{
									break;
								}
								object obj8 = this + 28;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								if (obj9 == null)
								{
									continue;
								}
								goto IL_0533;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj10 = this + 28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						}
					}
					goto IL_07e2;
				}
				_003C_003E1__state = -1;
				_003CdownloadFacebookPicturesContext_003E5__2 = ++socialManager._downloadFacebookPicturesContext;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj12 = default;
				object obj11 = obj12;
				object obj14 = default;
				object obj13 = obj14;
				goto IL_06d2;
				IL_07e2:
				object result = default;
				return result;
				IL_0533:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj15 = default;
				obj11 = obj15;
				obj13 = obj14;
				goto IL_06d2;
				IL_06d2:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj16 = default;
				if (obj13 != obj16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				_003C_003Em__Finally1();
				object obj17 = default;
				if (obj17 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_07e2;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
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

		private void _003C_003Em__Finally1()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Expected Obj, but got Unknown
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected Obj, but got Unknown
			//IL_00b5: Expected Obj, but got I4
			//IL_004b: Expected Obj, but got I4
			//IL_0104: Expected Obj, but got I
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Expected Obj, but got Unknown
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			if (_003C_003E1__state != -3)
			{
				object obj3 = _003C_003E1__state - 1;
				if ((nint)obj3 >= 2)
				{
					return;
				}
			}
			object obj4 = obj + 4;
			object obj5 = obj4 + 1;
			obj4 = obj5;
			object obj6 = obj5 << 2;
			object obj7 = obj + obj6;
			obj7 = 28;
			((IEnumerator)this).Reset();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			if ((nint)0 == -1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+4]");
			object obj8 = (nint)0 << 2;
			object obj9 = obj + obj8;
			if ((nint)obj9 == 28)
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

	private sealed class _003C_003Ec__DisplayClass162_0
	{
		public int context;

		public SocialManager _003C_003E4__this;

		public _003C_003Ec__DisplayClass162_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CInitAchievements_003Eb__0(GameCenterPlugin.Achievement[] achievements, string error)
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009e: Expected Obj, but got I4
			//IL_00a9: Expected Obj, but got I4
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v3 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v9 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FacebookSession.appId = (string)context;
			_003C_003E4__this = (SocialManager)1;
		}
	}

	private sealed class _003CWWWRequestCoroutine_003Ed__169 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string relativeUrl;

		public string[] postItems;

		public WWWComplete onWWWComplete;

		public object cookie;

		private StringBuilder _003Csb_003E5__2;

		private WWW _003Cwww_003E5__3;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0044: Expected I4, but got Obj
				//IL_0056: Expected I, but got Obj
				//IL_006c: Expected Obj, but got I
				//IL_0097: Expected I, but got Obj
				//IL_0378: Expected I, but got Obj
				//IL_038e: Expected Obj, but got I
				//IL_0114: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Expected Obj, but got Unknown
				//IL_040a: Expected I4, but got Obj
				//IL_041c: Expected I4, but got Obj
				//IL_03b9: Expected I, but got Obj
				//IL_027d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0282: Expected Obj, but got Unknown
				//IL_06e9: Expected Obj, but got I4
				//IL_02be: Expected I, but got Obj
				//IL_02d4: Expected Obj, but got I
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Expected Obj, but got Unknown
				//IL_043f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0444: Expected Obj, but got Unknown
				//IL_0a45: Expected I, but got Obj
				//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_09b8: Expected Obj, but got Unknown
				//IL_0491: Expected Obj, but got I4
				//IL_0347: Unknown result type (might be due to invalid IL or missing references)
				//IL_034c: Expected Obj, but got Unknown
				//IL_02ff: Expected I, but got Obj
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b4: Expected Obj, but got Unknown
				//IL_01f4: Expected I, but got Obj
				//IL_020a: Expected Obj, but got I
				//IL_080f: Expected I4, but got Obj
				//IL_063b: Expected I4, but got Obj
				//IL_063b: Expected I4, but got Obj
				//IL_0235: Expected I, but got Obj
				//IL_0646: Unknown result type (might be due to invalid IL or missing references)
				//IL_064b: Expected Obj, but got Unknown
				//IL_0659: Unknown result type (might be due to invalid IL or missing references)
				//IL_065e: Expected Obj, but got Unknown
				//IL_067c: Expected Obj, but got I4
				//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ba: Expected Obj, but got Unknown
				//IL_0867: Expected Obj, but got I4
				//IL_087e: Expected Obj, but got I4
				//IL_0523: Unknown result type (might be due to invalid IL or missing references)
				//IL_0528: Expected Obj, but got Unknown
				//IL_055b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0560: Expected Obj, but got Unknown
				//IL_060e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0613: Expected Obj, but got Unknown
				//IL_08ca: Expected I4, but got Obj
				//IL_08db: Expected I4, but got Obj
				//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_05a8: Expected Obj, but got Unknown
				//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
				//IL_05ee: Expected Obj, but got Unknown
				//IL_05ff: Expected I4, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						if (_003Cwww_003E5__3.isDone)
						{
							StringBuilder stringBuilder = _003Csb_003E5__2.AppendLine("Error: \"");
							bool isDone = _003Cwww_003E5__3.isDone;
							StringBuilder stringBuilder2 = stringBuilder.AppendLine((string)isDone);
							StringBuilder stringBuilder3 = stringBuilder2.AppendLine("\"\n");
						}
						else
						{
							Texture2D texture = _003Cwww_003E5__3.texture;
							if ((object)texture != null)
							{
								StringBuilder stringBuilder4 = _003Csb_003E5__2.AppendLine("Text: \"");
								Texture2D texture2 = _003Cwww_003E5__3.texture;
								StringBuilder stringBuilder5 = stringBuilder4.AppendLine((string)(object)texture2);
								StringBuilder stringBuilder6 = stringBuilder5.AppendLine("\"\n");
							}
						}
						if (onWWWComplete != null)
						{
							if (_003Cwww_003E5__3.isDone)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A32E");
								return null;
							}
							Texture2D texture3 = _003Cwww_003E5__3.texture;
							string text;
							if ((object)texture3 != null)
							{
								Texture2D texture4 = _003Cwww_003E5__3.texture;
								int num = ((string)(object)texture4).LastIndexOf((char)(int)"<result>", 5);
								if (num < 0)
								{
									text = null;
								}
								else
								{
									Texture2D texture5 = _003Cwww_003E5__3.texture;
									object obj = num + 8;
									string text2 = string.Format((string)(object)texture5, "</result>", obj, 5);
									if (System.Runtime.CompilerServices.Unsafe.As<string, UIntPtr>(ref text2) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
									{
										Texture2D texture6 = _003Cwww_003E5__3.texture;
										int length = (object)text2 - obj;
										string text3 = ((string)(object)texture6).InternalSubString((int)obj, length);
										text = text3;
									}
									else
									{
										bool flag = text2 != obj;
										bool flag2 = !flag;
										text = "";
										if (!flag2)
										{
											text = null;
										}
									}
								}
							}
							else
							{
								text = null;
							}
							bool flag3 = text == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A32E");
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				string text4 = string.ConcatArray((string[])(object)"http://hoodrunner.kiloo.com", (int)relativeUrl);
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v16 (Il2CppClass<SocialManager>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num3 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v107 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string deviceTypeString = GetDeviceTypeString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				StringBuilder stringBuilder7 = default;
				System.Text.StringBuilderCache.Release(stringBuilder7);
				object obj3 = default;
				IntPtr intPtr = default;
				string text6 = default;
				object obj19 = default;
				CertificateHandler certificateHandler = default;
				StringBuilder stringBuilder9 = default;
				string text7 = default;
				while (true)
				{
					string[] array = postItems;
					if ((nint)obj3 < array.Length)
					{
						object obj4 = postItems + 16;
						object obj5 = obj3 << 2;
						object obj6 = obj4 + obj5;
						nint num6;
						if (obj6 != null)
						{
							object obj7 = obj3 << 2;
							object obj8 = (object)postItems + obj7;
							object obj9 = obj8 + 20;
							if (obj9 == null)
							{
								object obj10 = postItems + 16;
								object obj11 = obj3 << 2;
								object type = obj10 + obj11;
								object obj12 = ((IConvertible)"WWWRequestCoroutine: Value for Post item ").ToType((Type)type, (IFormatProvider)(object)" is null, using empty string");
								nint num4 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S1_v109 (Il2CppClass<SocialManager>)+BA]");
								object obj13 = (nint)0 & (nint)0x200;
								if (obj13 != null)
								{
									nint num5 = (nint)typeof(SocialManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ S1_v121 (Il2CppClass<SocialManager>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								break;
							}
							object obj14 = obj3 << 2;
							object obj15 = (object)postItems + obj14;
							object value = obj15 + 20;
							StringBuilder stringBuilder8 = stringBuilder7.AppendLine((string)value);
							num6 = intPtr;
						}
						else
						{
							object obj16 = obj3 / 2;
							object obj17 = obj16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
							string text5 = "WWWRequestCoroutine: Post item key " + text6 + " is null, excluding item";
							nint num7 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S1_v85 (Il2CppClass<SocialManager>)+BA]");
							object obj18 = (nint)0 & (nint)0x200;
							if (obj18 != null)
							{
								nint num8 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ S1_v90 (Il2CppClass<SocialManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
							num6 = (nint)typeof(SocialManager);
						}
						obj3 = obj19 + 2;
						intPtr = num6;
						continue;
					}
					string data = deviceTypeString + (string)(object)stringBuilder7;
					nint num9 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S1_v16 (Il2CppClass<SocialManager>)+BA]");
					object obj20 = (nint)0 & (nint)0x200;
					if (obj20 != null)
					{
						nint num10 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S1_v71 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string checksum = GetChecksum((string[])(object)data);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					certificateHandler.Release();
					((WWWForm)(object)certificateHandler).AddField("identifier", (int)deviceTypeString);
					((WWWForm)(object)certificateHandler).AddField("checksum", (int)checksum);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					System.Text.StringBuilderCache.Release(stringBuilder9);
					object obj21 = this + 32;
					obj21 = stringBuilder9;
					StringBuilder stringBuilder10 = _003Csb_003E5__2.AppendLine("WWWRequest(");
					StringBuilder stringBuilder11 = stringBuilder10.AppendLine(text4);
					StringBuilder stringBuilder12 = stringBuilder11.AppendLine(")\n");
					object obj22 = 0;
					while (true)
					{
						string[] array2 = postItems;
						if ((nint)obj22 >= array2.Length)
						{
							break;
						}
						StringBuilder stringBuilder13 = _003Csb_003E5__2.AppendLine("Adding post data: \"");
						object obj23 = postItems + 16;
						object obj24 = obj22 << 2;
						object value2 = obj23 + obj24;
						StringBuilder stringBuilder14 = stringBuilder13.AppendLine((string)value2);
						StringBuilder stringBuilder15 = stringBuilder14.AppendLine("\" = \"");
						object obj25 = obj22 << 2;
						object obj26 = (object)postItems + obj25;
						object value3 = obj26 + 20;
						StringBuilder stringBuilder16 = stringBuilder15.AppendLine((string)value3);
						StringBuilder stringBuilder17 = stringBuilder16.AppendLine("\"\n");
						object obj27 = postItems + 16;
						object obj28 = obj22 << 2;
						object obj29 = obj27 + obj28;
						if (obj29 != null)
						{
							object obj30 = postItems + 16;
							object obj31 = obj22 << 2;
							object fieldName = obj30 + obj31;
							object obj32 = obj22 << 2;
							object obj33 = (object)postItems + obj32;
							object obj34 = obj33 + 20;
							((WWWForm)(object)certificateHandler).AddField((string)fieldName, (int)obj34);
						}
						object obj35 = obj22 + 2;
						obj22 = obj35;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					ScreenCapture.CaptureScreenshot(text7, (int)text4, (ScreenCapture.StereoScreenCaptureMode)certificateHandler);
					object obj36 = this + 36;
					obj36 = text7;
					object obj37 = this + 12;
					obj37 = _003Cwww_003E5__3;
					_003C_003E1__state = 1;
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
				throw new ArrayTypeMismatchException();
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CWWWRequestCoroutine_003Ed__169(int _003C_003E1__state)
		{
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Expected Obj, but got Unknown
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected Obj, but got Unknown
			//IL_0112: Expected Obj, but got I4
			//IL_00db: Expected Obj, but got VT
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			object obj3 = obj2 + 16;
			obj3 = 0;
			if (_003C_003E1__state != 0)
			{
				return;
			}
			int num = this._003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v17 (System.Int32)+78]");
			if ((nint)0 != 0)
			{
				int num2 = this._003C_003E1__state;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @744F");
				object obj4 = default;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj6 = default;
					object obj5 = obj6 + 8;
					obj5 = _003C_003E2__current;
					obj3 = obj6;
					int num3 = this._003C_003E1__state;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
				}
				object obj7 = obj3;
				_ = relativeUrl;
				object obj8 = obj3;
				DateTime utcNow = CDateTime.UtcNow;
				obj2 = utcNow;
				obj = obj2;
			}
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

	private const byte VERSION = 2;

	private const string UNREGISTER_DEVICE_URL = "/unregisterdevice.php";

	private const string REGISTER_DEVICE_URL = "/register2.php";

	private const string REPORT_SCORE_URL = "/report2.php";

	private const string CONSOLIDATE_FRIENDS_URL = "/friends2.php";

	private const string UPDATE_FRIEND_SCORES_URL = "/scores2.php";

	private const string POKE_URL = "/poke.php";

	private const string BRAG_URL = "/brag.php";

	private const string ANNOUNCE_URL = "/announce.php";

	private const float FACEBOOK_LOGIN_TIMEOUT = 10f;

	public const string NOTIFICATION_SOUND_NAME = "cpush.wav";

	private const string FACEBOOK_APPID = "254616967963463";

	public const string SECRET = "resxrctrv7tgv7gb8h9h9u0909kllfmolkjnhghgjjkhjghg";

	private const string ONLINESETTINGS_CONSOLIDATE_MIN_SECONDS_KEY = "social_consolidate_min_seconds";

	private const int CONSOLIDATE_MIN_SECONDS_DEFAULT = 3600;

	public const float USER_DATA_REFRESH_ON_AUTHENTICATE_AGE = 600f;

	public const float FRIEND_DATA_REFRESH_ON_RESUME_AGE = 3600f;

	private float _lastConsolidateFriendCompleteTime;

	private List<string> _latestPreConsolidationFacebookIds;

	private List<string> _latestSuccesfullyConsolidatedFacebookIds;

	private const string ONLINESETTINGS_REPORT_GAMES_COUNT_KEY = "social_report_games_count";

	private const int REPORT_GAMES_COUNT_DEFAULT = 5;

	private const string ONLINESETTINGS_REPORT_MIN_SECONDS_KEY = "social_report_min_seconds";

	private const int REPOST_MIN_SECONDS_DEFAULT = 1200;

	private const string LAST_REGISTER_TIMESTAMPTICKS_PLAYERPREFSKEY = "socmanlastregtime";

	private const string LAST_REGISTER_DATA_PLAYERPREFSKEY = "socmanlastregdata";

	private const string ONLINESETTINGS_REGISTER_MIN_SECONDS_KEY = "social_register_min_seconds";

	private const int REGISTER_MIN_SECONDS_DEFAULT = 3600;

	private const string ONLINESETTINGS_FACEBOOK_FETCH_MAX_USERS_KEY = "social_facebook_fetch_max_users";

	private const int FACEBOOK_FETCH_MAX_USERS_DEFAULT = 5000;

	private const string ONLINESETTINGS_FACEBOOK_KEEP_MAX_USERS_KEY = "social_facebook_keep_max_users";

	private const int FACEBOOK_KEEP_MAX_USERS_DEFAULT = 200;

	private string _tempRegisterUserData;

	private bool _appHasFocus;

	private const string ONLINESETTINGS_FRIENDSCORES_MIN_SECONDS_KEY = "social_friendscores_min_seconds";

	private const int FRIENDSCORES_MIN_SECONDS_DEFAULT = 120;

	private static SocialManager _instance;

	private int _userid;

	private string _lastFacebookLoginLocation;

	private bool isRunningFacebookLogin__BackingField;

	private static Action<FacebookProfile> m_facebookPictureDownloadedHandler;

	private Action<bool> m_onRegisterUserCompleted;

	private bool _registerUserCompleted;

	private Action<bool> m_friendsConsolidatedHandler;

	private static Action m_friendsChangedHandler;

	private FacebookProfile _fbProfile;

	private GameCenterProfile _gcProfile;

	private Action _localUserUpdatedHandler;

	private List<Friend> _friends;

	private IDictionary<string, FacebookProfile> _fbProfiles;

	private bool _fbReady;

	private DateTime _lastFriendScoreUpdateTimestamp;

	private bool _didAddAuthenticationHandlerToGameCenter;

	private Action _onFacebookStateChanged;

	private FacebookState _fbState;

	private bool _didAddChangeHandlerToFacebookSession;

	private readonly string[] requiredPermissions;

	private int _downloadFacebookPicturesContext;

	public const int FACEBOOK_CONSOLIDATED = 1;

	public const int GAMECENTER_CONSOLIDATED = 2;

	private int _consolidationState;

	private bool _consolidatedFriendsCompleted;

	private static bool _applicationIsQuiting;

	private IDictionary<string, GameCenterPlugin.Achievement> _achievements;

	private int _initAchievementsContext;

	private bool requestInvolvingDevicetokenInProgress__BackingField;

	private bool canUnregisterDevice__BackingField;

	private bool _pausePhotoDownloading;

	public int localUserId
	{
		get
		{
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Expected Obj, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected Obj, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected Obj, but got Unknown
			//IL_0096: Expected Obj, but got I4
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Expected Obj, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected Obj, but got Unknown
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ba: Expected Obj, but got Unknown
			//IL_0080: Expected Obj, but got I4
			//IL_00de: Expected Obj, but got I4
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Expected Obj, but got Unknown
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected Obj, but got Unknown
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected Obj, but got Unknown
			//IL_00c8: Expected Obj, but got I4
			object obj = this + 12;
			object obj2 = obj << 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj3 = default;
			object obj12 = default;
			object obj31 = default;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj))
			{
				object obj4 = obj3 << 1;
				object obj5 = this + 16;
				object obj6 = obj5 + obj3;
				object obj7 = obj6 & 0xFF;
				object obj9;
				object obj10;
				if ((nint)obj7 > 159)
				{
					object obj8 = obj3 << 1;
					obj9 = obj8;
					obj10 = 55;
				}
				else
				{
					obj9 = obj4;
					obj10 = 48;
				}
				object obj11 = obj12 + 16;
				object obj13 = obj9 << 1;
				object obj14 = obj11 + obj13;
				object obj15 = obj6 & 0xFF;
				object obj16 = obj15 >> 4;
				object obj17 = obj10 + obj16;
				obj14 = obj17;
				object obj18 = obj3 << 1;
				object obj19 = obj18 + 1;
				object obj20 = this + 16;
				object obj21 = obj20 + obj3;
				object obj22 = obj21 & 0xF;
				object obj25;
				object obj26;
				if ((nint)obj22 > 9)
				{
					object obj23 = obj3 << 1;
					object obj24 = obj23 + 1;
					obj25 = obj24;
					obj26 = 55;
				}
				else
				{
					obj25 = obj19;
					obj26 = 48;
				}
				object obj27 = obj12 + 16;
				object obj28 = obj25 << 1;
				object obj29 = obj27 + obj28;
				object obj30 = obj26 + obj22;
				obj29 = obj30;
				obj3 = obj31 + 1;
			}
			return ((StringComparer)null).GetHashCode(obj12);
		}
	}

	public bool isRunningFacebookLogin
	{
		get
		{
			return (byte)_userid != 0;
		}
		private set
		{
			//IL_01ff: Expected I, but got Obj
			//IL_0215: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0171: Expected I, but got Obj
			//IL_0187: Expected Obj, but got I
			//IL_00ba: Expected I, but got Obj
			//IL_00d0: Expected Obj, but got I
			//IL_01b2: Expected I, but got Obj
			//IL_00fb: Expected I, but got Obj
			nint num = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Globals);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<Globals>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (~(Globals.DEBUG_DISABLE_NOTIFICATION_REQUEST ? 1u : 0u) == 0)
			{
				return;
			}
			PreferencesSave.localNotificationsEnabled = 1;
			string dataPath = Application.dataPath;
			if ((nint)dataPath == 8)
			{
				if ((object)this == null)
				{
					return;
				}
				nint num3 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v36 (Il2CppClass<RemoteNotificationControl>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(RemoteNotificationControl);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v41 (Il2CppClass<RemoteNotificationControl>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SocialManager socialManager = instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
				return;
			}
			string dataPath2 = Application.dataPath;
			if ((nint)dataPath2 != 11)
			{
				return;
			}
			nint num5 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v23 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(DeviceUtility);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v29 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool iOSOtherAudioPlaying = DeviceUtility.GetIOSOtherAudioPlaying();
		}
	}

	public bool isRegisterUserCompleted => isRunningFacebookLogin__BackingField;

	public FacebookProfile facebookProfile
	{
		get
		{
			//IL_0019: Expected Obj, but got I4
			bool registerUserCompleted = _registerUserCompleted;
			return (FacebookProfile)registerUserCompleted;
		}
	}

	public GameCenterProfile gamecenterProfile => (GameCenterProfile)(object)_fbProfile;

	public Texture2D localUserImage => (Texture2D)(object)_gcProfile;

	public string localUserRealName
	{
		get
		{
			if (_fbProfile != null)
			{
				FacebookProfile fbProfile = _fbProfile;
				return (string)(object)fbProfile.image;
			}
			if (_gcProfile != null)
			{
				GameCenterProfile gcProfile = _gcProfile;
				return (string)(object)gcProfile.image;
			}
			return null;
		}
	}

	public string localDisplayName
	{
		get
		{
			//IL_002f: Expected I, but got Obj
			//IL_0045: Expected Obj, but got I
			//IL_0070: Expected I, but got Obj
			if (_fbProfile != null)
			{
				FacebookProfile fbProfile = _fbProfile;
				return fbProfile.name;
			}
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v16 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return Strings.GetDefault("PLAYER_GENERIC_NAME");
		}
	}

	public bool HasFacebookProfile
	{
		get
		{
			//IL_006a: Expected I, but got Obj
			//IL_0080: Expected Obj, but got I
			//IL_001c: Expected I4, but got Obj
			//IL_0124: Expected I4, but got Obj
			//IL_0057: Expected I4, but got Obj
			//IL_00ab: Expected I, but got Obj
			if (_fbProfile != null)
			{
				FacebookProfile fbProfile = _fbProfile;
				return (byte)(int)fbProfile.name != 0;
			}
			if (_gcProfile != null)
			{
				GameCenterProfile gcProfile = _gcProfile;
				return (byte)(int)gcProfile.displayName != 0;
			}
			nint num = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v11 (Il2CppClass<Strings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v18 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("PLAYER_SELF_REFERENCE");
			return (byte)(int)text != 0;
		}
	}

	public static SocialManager instance
	{
		get
		{
			//IL_0062: Expected I, but got Obj
			//IL_0078: Expected Obj, but got I
			//IL_00a3: Expected I, but got Obj
			if (PreferencesSave.localNotificationsEnabled != 0)
			{
				string dataPath = Application.dataPath;
				if ((nint)dataPath != 8)
				{
					string dataPath2 = Application.dataPath;
					if ((nint)dataPath2 == 11)
					{
						nint num = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v19 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
						object obj = (nint)0 & (nint)0x200;
						if (obj != null)
						{
							nint num2 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v29 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						if (!DeviceUtility.GetIOSOtherAudioPlaying())
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A44");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							SocialManager result = default;
							return result;
						}
					}
				}
			}
			return (SocialManager)(object)"";
		}
	}

	public bool gamecenterIsLoggedIn
	{
		get
		{
			//IL_0205: Expected I4, but got Obj
			//IL_0022: Expected I, but got Obj
			//IL_0038: Expected Obj, but got I
			//IL_0063: Expected I, but got Obj
			//IL_00b0: Expected I, but got Obj
			//IL_00c6: Expected Obj, but got I
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected Obj, but got Unknown
			//IL_01d5: Expected I, but got Obj
			//IL_01eb: Expected Obj, but got I
			//IL_00f1: Expected I, but got Obj
			Friend[] array2;
			if (_friends != null)
			{
				Friend[] array = _friends.ToArray();
				nint num = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<SocialManager+<>c>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v53 (Il2CppClass<SocialManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag = _003C_003Ec._003C_003E9__85_0 == null;
				bool flag2 = !flag;
				Comparison<Friend> comparison = _003C_003Ec._003C_003E9__85_0;
				if (!flag2)
				{
					nint num3 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27 (Il2CppClass<SocialManager+<>c>)+BA]");
					object obj2 = (nint)0 & (nint)0x200;
					if (obj2 != null)
					{
						nint num4 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v47 (Il2CppClass<SocialManager+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint num5 = 0;
					_ = 0;
					Comparison<Friend> comparison2 = default;
					object obj3 = comparison2 + 16;
					obj3 = _003C_003Ec._003C_003E9;
					nint num6 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44 (Il2CppClass<SocialManager+<>c>)+5C]");
					object obj4 = (nint)0 + (nint)8;
					obj4 = comparison2;
					comparison = comparison2;
				}
				Array.Sort(array, comparison);
				array2 = array;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				Friend[] array3 = default;
				array2 = array3;
			}
			return (byte)(int)array2 != 0;
		}
	}

	public bool gamecenterIsLoggedOut
	{
		get
		{
			//IL_0087: Expected I, but got Obj
			//IL_009d: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstanced = SocialManagerIOS.isInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+C]");
			if ((nint)0 == 1)
			{
				return false;
			}
			return _gcProfile != null;
		}
	}

	public FacebookState facebookState
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstanced = SocialManagerIOS.isInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+C]");
			return ((nint)0 == 0) ? FacebookState.Error : FacebookState.None;
		}
		private set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected Obj, but got Unknown
			//IL_001f: Expected Obj, but got I4
			object obj = this + 92;
			Delegate obj2 = ((Delegate)_onFacebookStateChanged).RemoveImpl((Delegate)value);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = default;
			obj = obj3;
		}
	}

	public bool facebookIsLoggedIn => (byte)_fbState != 0;

	public static bool facebookDialogsSupported
	{
		get
		{
			//IL_0060: Expected I, but got Obj
			//IL_0076: Expected Obj, but got I
			//IL_009e: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SocialManager._002Ecctor();
			return (byte)(int)_instance != 0;
		}
	}

	public int consolidationState
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected Obj, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected Obj, but got Unknown
			//IL_0129: Expected Obj, but got I4
			//IL_01f3: Expected Obj, but got I
			//IL_028f: Expected Obj, but got I
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected Obj, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Expected Obj, but got Unknown
			//IL_00dc: Expected Obj, but got I4
			//IL_0231: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected Obj, but got Unknown
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Expected Obj, but got Unknown
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Expected Obj, but got Unknown
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			if (_fbProfiles != null)
			{
				if (_latestSuccesfullyConsolidatedFacebookIds == null)
				{
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj3 = default;
				object obj4 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj4 == null)
						{
							object obj5 = obj2 + 4;
							object obj6 = obj5 + 1;
							obj5 = obj6;
							object obj7 = obj6 << 2;
							object obj8 = obj2 + obj7;
							obj8 = 84;
							break;
						}
						continue;
					}
					object obj9 = obj2 + 4;
					object obj10 = obj9 + 1;
					obj9 = obj10;
					object obj11 = obj10 << 2;
					object obj12 = obj2 + obj11;
					obj12 = 82;
					break;
				}
				object obj13 = default;
				if (obj13 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj14 = (nint)0 << 2;
					object obj15 = obj2 + obj14;
					if ((nint)obj15 == 84)
					{
						object obj16 = obj2 + 4;
						if ((nint)obj16 > -1)
						{
							object obj17 = obj16 + -1;
							obj16 = obj17;
						}
						return 1;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj18 = (nint)0 << 2;
					object obj19 = obj2 + obj18;
					if ((nint)obj19 == 82)
					{
						object obj20 = obj2 + 4;
						if ((nint)obj20 > -1)
						{
							object obj21 = obj20 + -1;
							obj20 = obj21;
						}
						goto IL_0401;
					}
				}
				object obj22 = default;
				if (obj22 == null)
				{
					return 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0401;
			IL_0401:
			int result = default;
			return result;
		}
	}

	public unsafe bool consolidatedFriendsCompleted
	{
		get
		{
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Expected Obj, but got Unknown
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Expected Obj, but got Unknown
			//IL_0393: Unknown result type (might be due to invalid IL or missing references)
			//IL_0398: Expected Obj, but got Unknown
			//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Expected Obj, but got Unknown
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Expected Obj, but got Unknown
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Expected Obj, but got Unknown
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Expected Obj, but got Unknown
			//IL_03d9: Expected Obj, but got I4
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Expected Obj, but got Unknown
			//IL_03f0: Expected Obj, but got I4
			//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Expected Obj, but got Unknown
			//IL_0407: Expected Obj, but got I4
			//IL_0410: Unknown result type (might be due to invalid IL or missing references)
			//IL_0415: Expected Obj, but got Unknown
			//IL_041e: Expected Obj, but got I4
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Expected Obj, but got Unknown
			//IL_0435: Expected Obj, but got I4
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Expected I4, but got Unknown
			//IL_045a: Unknown result type (might be due to invalid IL or missing references)
			//IL_045f: Expected I4, but got Unknown
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_047b: Expected I4, but got Unknown
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Expected Obj, but got Unknown
			//IL_04a0: Expected Obj, but got I4
			//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ae: Expected Obj, but got Unknown
			//IL_04b7: Expected Obj, but got I4
			//IL_0105: Expected I, but got Obj
			//IL_011b: Expected Obj, but got I
			//IL_006d: Expected I, but got Obj
			//IL_0083: Expected Obj, but got I
			//IL_018e: Expected Obj, but got I4
			//IL_01a6: Expected I, but got Obj
			//IL_01bc: Expected Obj, but got I
			//IL_0146: Expected I, but got Obj
			//IL_055f: Expected Obj, but got VT
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Expected Obj, but got Unknown
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_059b: Expected Obj, but got Unknown
			//IL_00ae: Expected I, but got Obj
			//IL_0262: Expected I, but got Obj
			//IL_01e7: Expected I, but got Obj
			//IL_02b1: Expected I, but got Obj
			//IL_0334: Expected I4, but got Obj
			//IL_0334: Expected I4, but got Obj
			//IL_034a: Expected Obj, but got I4
			object obj2 = default;
			object obj = obj2 - -64;
			object obj3 = obj2 + 56;
			object obj4 = obj2 + 24;
			object obj5 = obj2 + 32;
			object obj6 = obj2 + 16;
			object obj7 = obj2 + 8;
			IFormatProvider formatProvider = (IFormatProvider)(obj2 + 48);
			formatProvider = (IFormatProvider)0;
			object obj8 = obj2 + 40;
			obj8 = 0;
			Animation animation = (Animation)(obj2 + 100);
			animation = (Animation)0;
			string text = (string)(obj2 + 96);
			text = (string)0;
			string text2 = (string)(obj2 + 92);
			text2 = (string)0;
			int num = obj2 + 88;
			((int*)num)->m_value = 0;
			int num2 = obj2 + 84;
			((int*)num2)->m_value = 0;
			int num3 = obj2 + 80;
			((int*)num3)->m_value = 0;
			Camera camera = (Camera)(obj2 + 76);
			camera = (Camera)0;
			Action action = (Action)(obj2 + 72);
			action = (Action)0;
			bool result;
			if (((LODParameters*)"socmanlastregtime")->GetHashCode() != 0)
			{
				bool flag = PlayerPrefs.HasKey("socmanlastregtime");
				if (!(flag ? ((long*)1) : ((long*)null))->System_002EIConvertible_002EToBoolean(formatProvider))
				{
					string text3 = string.ConcatArray((string[])(object)"SocialManager.ShouldRegisterUser() Invalid ticks in playerprefs: ", flag ? 1 : 0);
					nint num4 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S1_v72 (Il2CppClass<SocialManager>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num5 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v77 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
					result = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DC47");
					nint num6 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S0_v52 (Il2CppClass<Info.OnlineSettings>)+BA]");
					object obj10 = (nint)0 & (nint)0x200;
					if (obj10 != null)
					{
						nint num7 = (nint)typeof(OnlineSettings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v114 (Il2CppClass<Info.OnlineSettings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string saveDataPath = OnlineSettings.GetSaveDataPath();
					uint value = ((OnlineSettings)(object)saveDataPath).GetValue("social_register_min_seconds", 3600u);
					DateTime utcNow = CDateTime.UtcNow;
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C3CA");
					nint num8 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v66 (Il2CppClass<System.DateTime>)+BA]");
					object obj11 = (nint)0 & (nint)0x200;
					if (obj11 != null)
					{
						nint num9 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v110 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj5 = obj8;
					obj6 = obj4;
					obj3 = obj5;
					obj = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
					obj7 = utcNow;
					object obj12 = default;
					obj2 = obj12;
					obj3 = obj7;
					obj = obj2;
					object obj13 = obj3 & 0x3FFFFFFFFFFFFFFFL;
					object obj14 = obj & 0x3FFFFFFFFFFFFFFFL;
					if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
					{
						result = true;
					}
					else
					{
						((CaptureAnimation)(object)this)._002Ector(animation, text, text2, num, num2, num3, camera, action);
						nint num10 = (nint)animation;
						bool flag2;
						if ((object)animation != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ S0_v87 (Il2CppClass<UnityEngine.Animation>)+8]");
							flag2 = (nint)0 == 0;
						}
						else
						{
							flag2 = true;
						}
						if (flag2)
						{
							nint num11 = (nint)text;
							bool flag3;
							if (text != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ S0_v98 (Il2CppClass<System.String>)+8]");
								flag3 = (nint)0 == 0;
							}
							else
							{
								flag3 = true;
							}
							if (flag3)
							{
								goto IL_0325;
							}
						}
						bool flag4 = _userid == 0;
						result = true;
						if (!flag4)
						{
							goto IL_0325;
						}
					}
				}
			}
			else
			{
				result = true;
			}
			goto IL_04fa;
			IL_04fa:
			return result;
			IL_0325:
			int num12 = UnityEngine.Random.Range((int)"socmanlastregdata", (int)"");
			char c = ((string)num12).get_Chars(((int*)num3)->m_value);
			result = (byte)c != 0;
			goto IL_04fa;
		}
	}

	public bool requestInvolvingDevicetokenInProgress
	{
		get
		{
			//IL_006b: Expected I, but got Obj
			//IL_0081: Expected Obj, but got I
			//IL_00a7: Expected Obj, but got I4
			//IL_00ab: Expected I4, but got Obj
			//IL_0013: Expected I, but got Obj
			int num = string.CompareOrdinalIgnoreCaseHelper((string)null, (string)(object)this);
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S1_v4 (Il2CppClass<SocialManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num3 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S1_v9 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (byte)(int)GetChecksum((string[])num) != 0;
		}
		private set
		{
			//IL_004a: Expected I, but got Obj
			//IL_0060: Expected Obj, but got I
			//IL_008b: Expected I, but got Obj
			//IL_00d8: Expected I, but got Obj
			//IL_00ee: Expected Obj, but got I
			//IL_0119: Expected I, but got Obj
			//IL_01a7: Expected Obj, but got I
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected Obj, but got Unknown
			//IL_01c8: Expected I, but got Obj
			//IL_01de: Expected Obj, but got I
			//IL_02e8: Expected I4, but got Obj
			//IL_0209: Expected I, but got Obj
			if (value)
			{
				return;
			}
			FacebookSession facebookSession = ((SocialManager)null).CreateFacebookSessionIfNeeded();
			if ((object)facebookSession != null)
			{
				bool flag = IsOAuthException((FacebookError)(object)this, null);
			}
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v16 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v57 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			ref GameCenterPlugin.LocalPlayer player = default;
			GameCenterPlugin.GetLocalPlayer(ref player);
			if (PreferencesSave.localNotificationsEnabled == 0)
			{
				return;
			}
			nint num3 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v26 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v53 (Il2CppClass<RemoteNotificationControl>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SocialManager socialManager = instance;
			if ((object)socialManager != null && ((UnityEngine.Object)socialManager).m_CachedPtr != (IntPtr)0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			SocialManager socialManager2 = default;
			((UnityEngine.Object)socialManager2).m_CachedPtr = cachedPtr;
			socialManager2._latestSuccesfullyConsolidatedFacebookIds = (List<string>)0;
			object obj3 = socialManager2 + 16;
			obj3 = this;
			nint num5 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v40 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v45 (Il2CppClass<RemoteNotificationControl>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			socialManager2.isRunningFacebookLogin = (byte)(int)"cpush.wav" != 0;
		}
	}

	public bool canUnregisterDevice
	{
		get
		{
			return requestInvolvingDevicetokenInProgress__BackingField;
		}
		private set
		{
			requestInvolvingDevicetokenInProgress__BackingField = value;
		}
	}

	public unsafe bool pausePhotoDownloading
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_02d3: Expected I4, but got Obj
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected Obj, but got Unknown
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected Obj, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_0164: Expected Obj, but got I4
			//IL_00bf: Expected Obj, but got I4
			//IL_0220: Expected Obj, but got I
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Expected Obj, but got Unknown
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			if (_fbProfiles != null)
			{
				if (_latestPreConsolidationFacebookIds != null)
				{
					throw new IndexOutOfRangeException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				List<string> list = default;
				list._002Ector();
				object obj3 = this + 16;
				obj3 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				StringBuilder stringBuilder = default;
				System.Text.StringBuilderCache.Release(stringBuilder);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj4 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj4 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					object obj5 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
					if ((nint)obj5 >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				}
				object obj6 = obj2 + 4;
				object obj7 = obj6 + 1;
				obj6 = obj7;
				object obj8 = obj7 << 2;
				object obj9 = obj2 + obj8;
				obj9 = 133;
				object obj10 = default;
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					object obj11 = (nint)0 << 2;
					object obj12 = obj2 + obj11;
					if ((nint)obj12 == 133)
					{
						object obj13 = obj2 + 4;
						if ((nint)obj13 > -1)
						{
							object obj14 = obj13 + -1;
							obj13 = obj14;
						}
						goto IL_035d;
					}
				}
				object obj15 = default;
				if (obj15 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_035d;
			}
			return (byte)(int)"" != 0;
			IL_035d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			bool result = default;
			return result;
		}
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0617: Unknown result type (might be due to invalid IL or missing references)
			//IL_061c: Expected Ref, but got Unknown
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_062a: Expected Obj, but got Unknown
			//IL_0633: Expected Obj, but got I4
			//IL_0642: Unknown result type (might be due to invalid IL or missing references)
			//IL_0647: Expected Obj, but got Unknown
			//IL_0650: Expected Obj, but got I4
			//IL_065f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0664: Expected Obj, but got Unknown
			//IL_003a: Expected Obj, but got I4
			//IL_0069: Expected Obj, but got I4
			//IL_0092: Expected Obj, but got VT
			//IL_069a: Unknown result type (might be due to invalid IL or missing references)
			//IL_069f: Expected Obj, but got Unknown
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Expected Obj, but got Unknown
			//IL_06d9: Expected Obj, but got I4
			//IL_0839: Expected Obj, but got I4
			//IL_0236: Expected Obj, but got I
			//IL_06eb: Expected Obj, but got I4
			//IL_071e: Expected Obj, but got I4
			//IL_030d: Expected Obj, but got I4
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0271: Expected Obj, but got Unknown
			//IL_0146: Expected Obj, but got I4
			//IL_0768: Expected I, but got Obj
			//IL_077e: Expected Obj, but got I
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Expected Obj, but got Unknown
			//IL_0877: Expected Obj, but got VT
			//IL_0891: Expected Obj, but got VT
			//IL_08ac: Expected Obj, but got I4
			//IL_08e3: Expected Obj, but got I4
			//IL_08eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f0: Expected Obj, but got Unknown
			//IL_0412: Expected Obj, but got I
			//IL_0382: Expected I, but got Obj
			object obj2 = default;
			object obj = obj2 + 80;
			ref GameCenterPlugin.LocalPlayer reference = ref *(GameCenterPlugin.LocalPlayer*)(obj2 + 16);
			object obj3 = obj2 + 56;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 40;
			obj4 = 0;
			_ = 0;
			object obj5 = obj2 + 32;
			obj5 = obj;
			_ = -1;
			if (_friends == null)
			{
				return;
			}
			List<Friend> friends = _friends;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string value2 = (string)(friends._size << 3);
			StringBuilder stringBuilder = default;
			stringBuilder._002Ector(value2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			string value3 = (string)(friends._size << 1);
			StringBuilder stringBuilder2 = default;
			stringBuilder2._002Ector(value3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (LocalPlayer&)+8]");
			_ = 0;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v184+20]");
				bool flag = (nint)0 != 0;
				bool flag2 = (byte)((flag ? 1u : 0u) | 2u) != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v184+1C]");
				if ((nint)0 == 0)
				{
					flag2 = flag;
				}
				object obj7 = flag2 & value;
				bool flag3 = obj7 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S0_v184+8]");
				bool flag4 = (nint)0 == 0;
				object obj8 = flag3 | flag4;
				if (obj8 == null)
				{
					object obj9 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
					if ((nint)obj9 >= 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				}
			}
			object obj10 = obj5 + 4;
			object obj11 = obj10 + 1;
			obj10 = obj11;
			object obj12 = obj11 << 2;
			object obj13 = obj5 + obj12;
			obj13 = 152;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S0_v20+4]");
				object obj14 = (nint)0 << 2;
				object obj15 = obj5 + obj14;
				if ((nint)obj15 == 152)
				{
					object obj16 = obj5 + 4;
					if ((nint)obj16 > -1)
					{
						object obj17 = obj16 + -1;
						obj16 = obj17;
					}
					goto IL_0822;
				}
			}
			object obj18 = default;
			if (obj18 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_0822;
			IL_0822:
			object obj19 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
			if ((nint)obj19 <= 0)
			{
				return;
			}
			bool flag5 = !value;
			bool flag6 = _fbProfile == null;
			object obj20 = flag5 | flag6;
			if (obj20 != null)
			{
				string text = "";
				string text2 = "";
			}
			else
			{
				FacebookProfile fbProfile = _fbProfile;
				FacebookProfile fbProfile2 = _fbProfile;
				string text2 = fbProfile2.fullName;
				string text = fbProfile.id;
			}
			nint num = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ S0_v63 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num2 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ S0_v136 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameCenterPlugin.GetLocalPlayer(ref reference);
			obj4 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (LocalPlayer&)+8]");
			_ = 0;
			obj2 = reference;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (LocalPlayer&)+8]");
			_ = 0;
			object obj22 = (value ? 1 : 0) & 2;
			bool flag7 = obj22 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+D]");
			bool flag8 = (nint)0 != 0;
			object obj23 = (flag8 ? 1 : 0) ^ 1;
			object obj24 = flag7 | obj23;
			if (obj24 != null)
			{
				object obj25 = "";
				object obj26 = "";
			}
			else
			{
				reference = ref *(GameCenterPlugin.LocalPlayer*)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
				_ = 0;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (LocalPlayer&)+4]");
				object obj25 = 0;
				object obj26 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	public static event Action<FacebookProfile> facebookPictureDownloadedHandler
	{
		add
		{
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SocialManager.m_facebookPictureDownloadedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SocialManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SocialManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SocialManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SocialManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SocialManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SocialManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public event Action<bool> onRegisterUserCompleted
	{
		add
		{
		}
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onRegisterUserCompleted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
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

	public event Action<bool> friendsConsolidatedHandler
	{
		add
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_onRegisterUserCompleted;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 44;
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
		remove
		{
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected Obj, but got Unknown
			Delegate obj = this.m_friendsConsolidatedHandler;
			object obj4 = default;
			while (true)
			{
				Delegate obj2 = obj.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				object obj3 = this + 52;
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

	public static event Action friendsChangedHandler
	{
		add
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SocialManager.m_facebookPictureDownloadedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.RemoveImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SocialManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SocialManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SocialManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SocialManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SocialManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SocialManager>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
		remove
		{
			//IL_00e4: Expected I, but got Obj
			//IL_00fa: Expected Obj, but got I
			//IL_017d: Expected I, but got Obj
			//IL_0193: Expected Obj, but got I
			//IL_01b0: Expected I, but got Obj
			//IL_0013: Expected I, but got Obj
			//IL_012d: Expected Obj, but got I
			//IL_0060: Expected I, but got Obj
			//IL_0090: Expected I, but got Obj
			//IL_00b6: Expected I, but got Obj
			nint num = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Delegate obj2 = SocialManager.m_friendsChangedHandler;
			object obj6 = default;
			while (true)
			{
				Delegate obj3 = obj2.CombineImpl((Delegate)value);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
				nint num3 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SocialManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				bool flag = obj4 == null;
				nint num4 = (nint)typeof(SocialManager);
				if (!flag)
				{
					nint num5 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SocialManager>)+74]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					num4 = (nint)typeof(SocialManager);
					if (!flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						num4 = (nint)typeof(SocialManager);
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SocialManager>)+5C]");
				object obj5 = (nint)0 + (nint)8;
				if (obj5 == obj2)
				{
					obj5 = obj6;
				}
				if (obj5 != obj2)
				{
					obj2 = (Delegate)obj5;
					continue;
				}
				break;
			}
		}
	}

	public void AddGameCenterSmallSizePictureDownloadedHandler(Action<GameCenterProfile> handler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(handler & 1) != 0;
		isRunningFacebookLogin__BackingField = flag;
	}

	public void RemoveGameCenterSmallSizePictureDownloadedHandler(Action<GameCenterProfile> handler)
	{
	}

	private void FriendConsolidationDidFinish(bool success)
	{
		//IL_0066: Expected Obj, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected Obj, but got Unknown
		Delegate obj = this.m_friendsConsolidatedHandler;
		object obj4 = default;
		while (true)
		{
			Delegate obj2 = obj.RemoveImpl((Delegate)success);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj3 = this + 52;
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

	private void FriendsDidChange()
	{
		//IL_00e4: Expected I, but got Obj
		//IL_00fa: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		//IL_0190: Expected Obj, but got I
		//IL_01ad: Expected I, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_012d: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_0090: Expected I, but got Obj
		//IL_00b6: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Delegate obj2 = SocialManager.m_friendsChangedHandler;
		object obj6 = default;
		while (true)
		{
			Delegate obj3 = obj2.RemoveImpl((Delegate)(object)this);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v18 (Il2CppClass<SocialManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			bool flag = obj4 == null;
			nint num4 = (nint)typeof(SocialManager);
			if (!flag)
			{
				nint num5 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v28 (Il2CppClass<SocialManager>)+74]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num4 = (nint)typeof(SocialManager);
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(SocialManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ L1_v5 (Il2CppClass<SocialManager>)+5C]");
			object obj5 = (nint)0 + (nint)8;
			if (obj5 == obj2)
			{
				obj5 = obj6;
			}
			if (obj5 != obj2)
			{
				obj2 = (Delegate)obj5;
				continue;
			}
			break;
		}
	}

	public void AddLocalUserUpdatedHandler(Action handler)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		if (this.m_friendsConsolidatedHandler != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v31 @ S3_v5 (should have been resolved before IL gen)");
		}
		((SocialManager)null).ClearGameCenter();
	}

	public void RemoveLocalUserUpdatedHandler(Action handler)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = this - -64;
		object obj2 = this - -64;
		Delegate obj3 = ((Delegate)obj2).CombineImpl((Delegate)handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj4 = default;
		obj = obj4;
	}

	public unsafe Friend FindFriend(int userid)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected Obj, but got Unknown
		//IL_0119: Expected Obj, but got I4
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected Obj, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0187: Expected Obj, but got VT
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected Obj, but got Unknown
		//IL_01a2: Expected Obj, but got I4
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected VT, but got Unknown
		//IL_01bd: Expected I8, but got Obj
		//IL_01b8: Expected native int or pointer, but got VT
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected Obj, but got Unknown
		//IL_01e0: Expected Ref, but got VT
		//IL_01ec: Expected Obj, but got I8
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_022b: Expected Obj, but got I
		//IL_0234: Expected Obj, but got VT
		//IL_0241: Expected I8, but got Obj
		//IL_023c: Expected native int or pointer, but got VT
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected Obj, but got Unknown
		//IL_00ab: Expected I, but got Obj
		//IL_00f3: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 24;
		obj = 0;
		DateTime today = CDateTime.Today;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v15 (Il2CppClass<System.DateTime>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v63 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 32;
		obj5 = today;
		object obj6 = obj2 + 16;
		obj6 = ((int*)userid)->m_value;
		DateTime dateTime = (DateTime)(obj2 + 40);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 48);
		formatProvider = (IFormatProvider)obj6;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj = num3;
		object obj7 = obj / 864000000000L;
		if ((nint)obj7 >= 1)
		{
			bool flag = isRunningFacebookLogin__BackingField;
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v41 (Il2CppClass<System.DateTime>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S0_v57 (Il2CppClass<System.DateTime>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v38 (System.Boolean)+8]");
			obj4 = 0;
			obj2 = DateTime.MinValue;
			((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj4;
			formatProvider = (IFormatProvider)obj2;
			long num6 = (long)(dateTime.dateData & 0x3FFFFFFFFFFFFFFFL);
			object obj9 = formatProvider & 0x3FFFFFFFFFFFFFFFL;
			if (num6 != (long)obj9)
			{
				return (Friend)1;
			}
		}
		return null;
	}

	public Friend[] FriendsSortedByScore()
	{
		//IL_0019: Expected Obj, but got I4
		bool flag = _fbProfile != null;
		return (Friend[])flag;
	}

	public Friend[] FriendsSortedByCash()
	{
		//IL_0022: Expected I, but got Obj
		//IL_0038: Expected Obj, but got I
		//IL_0063: Expected I, but got Obj
		//IL_00b0: Expected I, but got Obj
		//IL_00c6: Expected Obj, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected Obj, but got Unknown
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_00f1: Expected I, but got Obj
		if (_friends != null)
		{
			Friend[] array = _friends.ToArray();
			nint num = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v16 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v53 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _003C_003Ec._003C_003E9__84_0 == null;
			bool flag2 = !flag;
			Comparison<Friend> comparison = _003C_003Ec._003C_003E9__84_0;
			if (!flag2)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v27 (Il2CppClass<SocialManager+<>c>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v47 (Il2CppClass<SocialManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				Comparison<Friend> comparison2 = default;
				object obj3 = comparison2 + 16;
				obj3 = _003C_003Ec._003C_003E9;
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v44 (Il2CppClass<SocialManager+<>c>)+5C]");
				object obj4 = (nint)0 + (nint)4;
				obj4 = comparison2;
				comparison = comparison2;
			}
			Array.Sort(array, comparison);
			return array;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		Friend[] result = default;
		return result;
	}

	public void DownloadLargePictureForUser(Friend friend, Action<Friend, Texture2D> handler)
	{
		((CharacterLetterPickup)this).SSEventsManagerController_OnSSEventChangedHandler();
	}

	public static void Init()
	{
	}

	private void ClearGameCenter()
	{
		//IL_0070: Expected I, but got Obj
		//IL_0086: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v15 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (SocialManager.m_friendsChangedHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	private void OnGameCenterAuthentication(bool hasLoginView, string error)
	{
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected Obj, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_01f8: Expected Obj, but got I4
		//IL_0015: Expected Obj, but got I
		//IL_0104: Expected Obj, but got I4
		//IL_0084: Expected Obj, but got I
		//IL_00a9: Expected Obj, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00da: Expected Obj, but got I4
		//IL_00da: Expected Obj, but got I
		//IL_012f: Expected I, but got Obj
		//IL_0145: Expected Obj, but got I
		//IL_0254: Expected Obj, but got I
		//IL_027a: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I4
		//IL_02a0: Expected Obj, but got I
		//IL_02a0: Expected Obj, but got I4
		//IL_0170: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = error;
		object obj3 = obj2 + 12;
		obj3 = hasLoginView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15+20]");
		bool flag = (nint)0 != 0;
		bool flag2 = (byte)((flag ? 1u : 0u) | 2u) != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v15+1C]");
		if ((nint)0 == 0)
		{
			flag2 = flag;
		}
		if (flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			string[] array = default;
			array[1] = (string)0;
			object obj6 = array + 16;
			obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S0_v51+20]");
			IEnumerator routine = WWWRequestCoroutine(null, (string)0, 1, array);
			Coroutine coroutine = StartCoroutine_Auto(routine);
			return;
		}
		object obj7 = (flag2 ? 1 : 0) & 2;
		if (obj7 == null)
		{
			return;
		}
		nint num2 = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ S0_v26 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num3 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v46 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstanced = SocialManagerIOS.isInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+C]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num4 = 0;
		_ = 0;
		bool flag3 = default;
		object obj10 = (flag3 ? 1 : 0) + 16;
		obj10 = obj2;
		bool flag4 = isInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v33+1C]");
		IEnumerator routine2 = ((TopRunPlayerCell)flag4).AnimateMedalSprite((UISprite)0, (UISprite)1, flag3);
		Coroutine coroutine2 = StartCoroutine_Auto(routine2);
	}

	public void InitGameCenter()
	{
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected Obj, but got Unknown
		//IL_029e: Expected Obj, but got I4
		//IL_020a: Expected I, but got Obj
		//IL_0220: Expected Obj, but got I
		//IL_03bd: Expected Obj, but got I4
		//IL_03c6: Expected Obj, but got I4
		//IL_03d4: Expected Obj, but got I4
		//IL_03dd: Expected Obj, but got I4
		//IL_03eb: Expected Obj, but got I4
		//IL_03f4: Expected Obj, but got I4
		//IL_0413: Expected Obj, but got I
		//IL_042e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_024b: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_00a1: Expected I, but got Obj
		//IL_00b7: Expected Obj, but got I
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected Obj, but got Unknown
		//IL_0323: Expected I, but got Obj
		//IL_0339: Expected Obj, but got I
		//IL_00e2: Expected I, but got Obj
		object obj = this + 60;
		obj = 0;
		if (_friends != null)
		{
			nint num = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S1_v22 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v103 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_003C_003Ec._003C_003E9__97_0 == null)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v77 (Il2CppClass<SocialManager+<>c>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S1_v97 (Il2CppClass<SocialManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num5 = 0;
				_ = 0;
				object obj5 = default;
				object obj4 = obj5 + 16;
				obj4 = _003C_003Ec._003C_003E9;
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ S1_v94 (Il2CppClass<SocialManager+<>c>)+5C]");
				object obj6 = (nint)0 + (nint)20;
				obj6 = obj5;
			}
			throw new NullReferenceException();
		}
		nint num7 = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v11 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num8 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v26 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstanced = SocialManagerIOS.isInstanced;
		object obj8 = (isInstanced ? 1 : 0) + 32;
		obj8 = 0;
		object obj9 = (isInstanced ? 1 : 0) + 28;
		obj9 = 0;
		object obj10 = (isInstanced ? 1 : 0) + 16;
		obj10 = 0;
		bool isInstanced2 = SocialManagerIOS.isInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v23 (System.Boolean)+18]");
		object obj11 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v23 (System.Boolean)+24]");
		object obj12 = (nint)0 + (nint)1;
		int num9 = _consolidationState & -3;
		_consolidationState = num9;
	}

	private void OnGameCenterPhotoDownloaded(GameCenterProfile gcProfile)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected Obj, but got Unknown
		object obj = this - -64;
		object obj2 = this - -64;
		Delegate obj3 = ((Delegate)obj2).RemoveImpl((Delegate)(object)gcProfile);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj4 = default;
		obj = obj4;
	}

	private void OnFacebookPhotoDownloaded(FacebookProfile fbProfile)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02ed: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if ((object)_gcProfile == fbProfile)
		{
			object obj5 = this - -64;
			if (obj5 != null)
			{
				object obj6 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			return;
		}
		if (_friends == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Friend friend = null;
		object obj7 = default;
		Friend friend2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if ((object)friend2.gcProfile == fbProfile)
			{
				friend = friend2;
			}
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 97;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 97)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0330;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0330;
		IL_0330:
		friend?._002Ector();
	}

	public void AddFacebookStateChangedHandler(Action handler)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected Obj, but got Unknown
		//IL_0259: Expected Obj, but got I4
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected Obj, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected Obj, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected Obj, but got Unknown
		//IL_02ed: Expected Obj, but got I4
		//IL_018a: Expected Obj, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if ((object)_fbProfile == handler)
		{
			object obj5 = this - -64;
			if (obj5 != null)
			{
				object obj6 = this - -64;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
			return;
		}
		if (_friends == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Friend friend = null;
		object obj7 = default;
		Friend friend2 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj7 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if ((object)friend2.fbProfile == handler)
			{
				friend = friend2;
			}
		}
		object obj8 = obj4 + 4;
		object obj9 = obj8 + 1;
		obj8 = obj9;
		object obj10 = obj9 << 2;
		object obj11 = obj4 + obj10;
		obj11 = 97;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj12 = (nint)0 << 2;
			object obj13 = obj4 + obj12;
			if ((nint)obj13 == 97)
			{
				object obj14 = obj4 + 4;
				if ((nint)obj14 > -1)
				{
					object obj15 = obj14 + -1;
					obj14 = obj15;
				}
				goto IL_0330;
			}
		}
		object obj16 = default;
		if (obj16 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0330;
		IL_0330:
		friend?._002Ector();
	}

	public void RemoveFacebookStateChangedHandler(Action handler)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj = this + 92;
		Delegate obj2 = ((Delegate)_onFacebookStateChanged).CombineImpl((Delegate)handler);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
		object obj3 = default;
		obj = obj3;
	}

	public bool FacebookLogin(Action<bool> onComplete)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_000a: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = default;
		obj = obj3;
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private unsafe void HandleLoggingIntoFacebookComplete(bool success, Action<bool> onComplete)
	{
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected Obj, but got Unknown
		//IL_04ba: Expected Obj, but got I4
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Expected Obj, but got Unknown
		//IL_04d7: Expected Obj, but got I4
		//IL_04e5: Expected I, but got Obj
		//IL_04fb: Expected Obj, but got I
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_0645: Expected Obj, but got Unknown
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected Obj, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected Obj, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_066f: Expected Obj, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected Ref, but got Unknown
		//IL_0693: Expected Obj, but got VT
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected VT, but got Unknown
		//IL_06c0: Expected I8, but got VT
		//IL_06bb: Expected native int or pointer, but got VT
		//IL_0013: Expected I, but got Obj
		//IL_0418: Expected I, but got Obj
		//IL_042e: Expected Obj, but got I
		//IL_0358: Expected I, but got Obj
		//IL_036e: Expected Obj, but got I
		//IL_00a7: Expected I4, but got VT
		//IL_0459: Expected I, but got Obj
		//IL_01a4: Expected I8, but got Obj
		//IL_019f: Expected native int or pointer, but got VT
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected Obj, but got Unknown
		//IL_01cf: Expected Obj, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0202: Expected Obj, but got I
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected Obj, but got Unknown
		//IL_0399: Expected I, but got Obj
		//IL_0243: Expected Obj, but got VT
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected Obj, but got Unknown
		//IL_02ca: Expected I, but got Obj
		//IL_02e0: Expected Obj, but got I
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_05e2: Expected Obj, but got I4
		//IL_05e2: Expected Obj, but got VT
		//IL_054a: Expected Obj, but got VT
		//IL_0557: Expected Obj, but got VT
		//IL_0564: Expected I8, but got Obj
		//IL_055f: Expected native int or pointer, but got VT
		//IL_0579: Expected Obj, but got Ref
		//IL_0579: Expected Ref, but got VT
		//IL_0585: Expected Obj, but got I8
		//IL_030b: Expected I, but got Obj
		//IL_0135: Expected I, but got Obj
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected Obj, but got Unknown
		//IL_0188: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 96;
		obj = 0;
		_ = 0;
		object obj3 = obj2 + 24;
		obj3 = 0;
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v128 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj5 = obj2 + 16;
		object obj6 = obj2 + 8;
		object obj7 = obj2 + 80;
		object obj8 = obj2 - -64;
		ref GameCenterPlugin.LocalPlayer reference = ref *(GameCenterPlugin.LocalPlayer*)(obj2 + 48);
		GameCenterPlugin.GetLocalPlayer(ref reference);
		obj = reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (LocalPlayer&)+8]");
		_ = 0;
		DateTime dateTime = (DateTime)(obj2 + 32);
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)reference;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v27 (LocalPlayer&)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (System.DateTime)+D]");
		if ((nint)0 != 0)
		{
			if (_gcProfile != null)
			{
				GameCenterProfile gcProfile = _gcProfile;
				reference = ref *(GameCenterPlugin.LocalPlayer*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				if (gcProfile.id.get_Chars((int)reference) == '\0')
				{
					DateTime utcNow = CDateTime.UtcNow;
					GameCenterProfile gcProfile2 = _gcProfile;
					nint num3 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ S0_v109 (Il2CppClass<System.DateTime>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num4 = (nint)typeof(DateTime);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v124 (Il2CppClass<System.DateTime>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					obj5 = utcNow;
					obj6 = gcProfile2.refreshedTime;
					((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj5;
					long num5 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64((IFormatProvider)System.Runtime.CompilerServices.Unsafe.AsPointer(ref *(byte*)obj6));
					obj3 = num5;
					double num6 = (double)obj3 * 1E-07;
					if (num6 > 600.0)
					{
						object obj10 = this + 60;
						obj10 = 0;
					}
				}
			}
			if (_gcProfile == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj12 = default;
				object obj11 = obj12 + 12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v31 (System.DateTime)+4]");
				obj11 = 0;
				obj7 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj13 = obj12 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v23+8]");
				obj13 = 0;
				obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				object obj14 = obj12 + 8;
				obj14 = obj8;
				DateTime utcNow2 = CDateTime.UtcNow;
				obj2 = utcNow2;
				_ = *(GameCenterPlugin.LocalPlayer*)obj2;
				object obj15 = this + 60;
				obj15 = obj12;
				reference = ref *(GameCenterPlugin.LocalPlayer*)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9+8]");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint method_ptr = 0;
				FacebookSession.RequestCompleteHandler requestCompleteHandler = default;
				((Delegate)requestCompleteHandler).method_ptr = method_ptr;
				((Delegate)requestCompleteHandler).method = (nint)__ldftn(SocialManager._003COnGameCenterAuthentication_003Eb__98_0);
				object obj16 = requestCompleteHandler + 16;
				obj16 = this;
				nint num7 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ S1_v74 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
				object obj17 = (nint)0 & (nint)0x200;
				if (obj17 != null)
				{
					nint num8 = (nint)typeof(GameCenterPlugin);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ S1_v80 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((FacebookSession)reference).GraphRequest(null, (IDictionary<string, object>)50, (HttpMethod)50, requestCompleteHandler);
				this._002Ector();
			}
			nint num9 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ S0_v64 (Il2CppClass<Flurry>)+BA]");
			object obj18 = (nint)0 & (nint)0x200;
			if (obj18 != null)
			{
				nint num10 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v69 (Il2CppClass<Flurry>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Flurry.SetUserId();
		}
		else
		{
			if (((SocialManager)null).facebookState != FacebookState.None)
			{
				return;
			}
			nint num11 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v41 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj19 = (nint)0 & (nint)0x200;
			if (obj19 != null)
			{
				nint num12 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v52 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstanced = SocialManagerIOS.isInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ S0_v46 (System.Boolean)+C]");
			if ((nint)0 != 0)
			{
				_ = 0;
			}
			Awake();
			((SocialManager)null).ClearGameCenter();
		}
	}

	public unsafe void FacebookLogout()
	{
		//IL_0252: Expected I, but got Obj
		//IL_0268: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0388: Expected I, but got Obj
		//IL_039e: Expected Obj, but got I
		//IL_02d9: Expected I, but got Obj
		//IL_02ef: Expected Obj, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected Obj, but got Unknown
		//IL_00aa: Expected I, but got Obj
		//IL_00c0: Expected Obj, but got I
		//IL_0138: Expected I, but got Obj
		//IL_00eb: Expected I, but got Obj
		//IL_0204: Expected I, but got Obj
		//IL_019e: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v65 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstanced = SocialManagerIOS.isInstanced;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (System.Boolean)+C]");
		if ((nint)0 != 1)
		{
			_ = 1;
		}
		if (~(_didAddAuthenticationHandlerToGameCenter ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			GameCenterPlugin.AuthenticateHandler authenticateHandler = default;
			((Delegate)authenticateHandler).method_ptr = method_ptr;
			((Delegate)authenticateHandler).method = (nint)__ldftn(SocialManager.OnGameCenterAuthentication);
			object obj2 = authenticateHandler + 16;
			obj2 = this;
			nint num3 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v54 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num4 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v60 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			GameCenterPlugin.authenticationEvent -= authenticateHandler;
			_didAddAuthenticationHandlerToGameCenter = true;
		}
		nint num5 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v20 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num6 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S0_v43 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = GameCenterPlugin.ArePhotosSupported();
		nint num7 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v8 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		bool flag2 = obj5 != null;
		if (flag)
		{
			if (flag2)
			{
				nint num8 = (nint)typeof(GameCenterPlugin);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v39 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool initialAuthenticationComplete = GameCenterPlugin.initialAuthenticationComplete;
			HandleLoggingIntoFacebookComplete(success: false, null);
			return;
		}
		if (flag2)
		{
			nint num9 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ S0_v30 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameCenterPlugin.ShowLoginView();
	}

	public static bool IsOAuthException(FacebookError error, object obj)
	{
		//IL_02db: Expected I, but got Obj
		//IL_02f1: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0125: Expected Obj, but got I4
		//IL_0133: Expected I, but got Obj
		//IL_0149: Expected Obj, but got I
		//IL_032a: Expected I, but got Obj
		//IL_0340: Expected Obj, but got I
		//IL_0090: Expected I, but got Obj
		//IL_00a6: Expected Obj, but got I
		//IL_0367: Expected Obj, but got I4
		//IL_0174: Expected I, but got Obj
		//IL_01c1: Expected I, but got Obj
		//IL_00da: Expected I, but got Obj
		//IL_020e: Expected I, but got Obj
		//IL_0224: Expected Obj, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected Obj, but got Unknown
		//IL_03d8: Expected Obj, but got I4
		//IL_024f: Expected I, but got Obj
		//IL_03fe: Expected Obj, but got I4
		//IL_040f: Expected I4, but got Obj
		//IL_0297: Expected Obj, but got I4
		//IL_02a9: Expected I4, but got Obj
		//IL_02a9: Expected Obj, but got I4
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v49 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool result;
		if (AgeRestriction.waitForAgeRestriction)
		{
			result = false;
		}
		else if (error.exceptionType != null)
		{
			nint num3 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S1_v33 (Il2CppClass<SocialManager>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			bool flag = obj3 == null;
			result = false;
			if (!flag)
			{
				nint num4 = (nint)typeof(SocialManager);
				result = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v37 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					result = false;
				}
			}
		}
		else
		{
			_ = 0;
			error.exceptionType = (string)1;
			nint num5 = (nint)typeof(UIScreenController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v18 (Il2CppClass<UIScreenController>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v40 (Il2CppClass<UIScreenController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = UIScreenController.ShouldShowOnlineScreen();
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S1_v8 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ S1_v28 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)flag2).FindKernel(null) != 0)
			{
				nint num9 = (nint)typeof(UIScreenController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v30 (Il2CppClass<UIScreenController>)+BA]");
				object obj6 = (nint)0 & (nint)0x200;
				if (obj6 != null)
				{
					nint num10 = (nint)typeof(UIScreenController);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ S0_v36 (Il2CppClass<UIScreenController>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj7 = error + 36;
				bool flag3 = UIScreenController.ShouldShowOnlineScreen();
				string[] values;
				if (((UIScreenController)flag3).IsPopupQueueEmpty())
				{
					bool isShowingPopup = ((UIScreenController)flag3).isShowingPopup;
					string text = string.ConcatArray((string[])isShowingPopup, (int)" on ");
					values = (string[])(object)text;
				}
				else
				{
					values = (string[])(object)"";
				}
				IEnumerator enumerator = ((UIScreenController)flag3).DelayHideMainCamera();
				string text2 = string.ConcatArray(values, (int)enumerator);
				obj7 = text2;
			}
			IEnumerator routine = ((SocialManager)(object)error).DownloadFacebookPictures((IDictionary<string, FacebookProfile>)obj);
			Coroutine coroutine = ((MonoBehaviour)(object)error).StartCoroutine_Auto(routine);
			result = true;
		}
		return result;
	}

	private void OnFacebookSessionStatusChanged(FacebookSession.State status, FacebookError error)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		Awake();
		isRunningFacebookLogin__BackingField = false;
		if (error != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v2 (Il2CppMethodInfo)+18]");
			object obj = 0;
			object obj2 = obj;
			object obj3 = obj2 & 0x3FFF;
			object obj4 = obj3 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v34 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	public bool HasFacebookAccessToken()
	{
		//IL_0101: Expected I, but got Obj
		//IL_0117: Expected Obj, but got I
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v26 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(Globals.DEBUG_USE_DEBUG_LOGIN_STATE ? 1u : 0u) == 0)
		{
			return true;
		}
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v15 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v21 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return FacebookSession._IsSupported();
	}

	private FacebookSession CreateFacebookSessionIfNeeded()
	{
		//IL_0220: Expected I, but got Obj
		//IL_0236: Expected Obj, but got I
		//IL_006a: Expected I, but got Obj
		//IL_0080: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0270: Expected I, but got Obj
		//IL_0286: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_0140: Expected I4, but got Obj
		//IL_0188: Expected I, but got Obj
		//IL_019e: Expected Obj, but got I
		//IL_02e1: Expected Obj, but got I4
		//IL_02f8: Expected Obj, but got I4
		//IL_0175: Expected Obj, but got I4
		//IL_01c9: Expected I, but got Obj
		nint num = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v54 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AgeRestriction.waitForAgeRestriction)
		{
			return null;
		}
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v14 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ S0_v49 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v21 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v45 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			bool flag = FacebookSession.IsOpened((FacebookSession.State)computeShader);
			if (flag)
			{
				return (FacebookSession)1;
			}
			nint num7 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v33 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num8 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ S0_v40 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj5 = (flag ? 1 : 0) + -3;
			bool flag2 = (nint)obj5 < 2;
			return (FacebookSession)flag2;
		}
		return null;
	}

	private Coroutine FacebookCheckPermissionsAsync(FacebookPermissionCheck check)
	{
		//IL_00b9: Expected Obj, but got I4
		if ((object)this == null || (((UnityEngine.Object)this).m_CachedPtr != (IntPtr)2 && ((UnityEngine.Object)this).m_CachedPtr != (IntPtr)3 && !(_tempRegisterUserData != "OAuthException")))
		{
			return null;
		}
		return (Coroutine)1;
	}

	private IEnumerator FacebookCheckPermissionsCoroutine(FacebookPermissionCheck check)
	{
		IEnumerator routine = FacebookLoginCoroutine((Action<bool>)(object)check);
		return (IEnumerator)(object)StartCoroutine_Auto(routine);
	}

	private unsafe void ResetTimeLeft(out float lastRealTime, out float timeLeft)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_03b4: Expected Obj, but got Ref
		//IL_0054: Expected I, but got Obj
		//IL_01f4: Expected Obj, but got I4
		//IL_03f8: Expected Obj, but got I4
		//IL_0156: Expected Obj, but got I4
		//IL_00cb: Expected I, but got Obj
		//IL_00e1: Expected Obj, but got I
		//IL_01ae: Expected Obj, but got I4
		//IL_0251: Expected Obj, but got I
		//IL_010c: Expected I, but got Obj
		//IL_02ae: Expected I, but got Obj
		//IL_02c4: Expected Obj, but got I
		//IL_044b: Expected I, but got Obj
		//IL_0461: Expected Obj, but got I
		//IL_0498: Expected VT, but got I
		//IL_02ef: Expected I, but got Obj
		//IL_033c: Expected I, but got Obj
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref lastRealTime) == (void*)2)
		{
			return;
		}
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v57 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref lastRealTime, -3));
		if ((nint)obj2 < 2)
		{
			if (_fbState == FacebookState.LoggingIn)
			{
				nint num3 = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S1_v24 (Il2CppClass<Flurry>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num4 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v29 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Flurry.LogOkPressedOnPopup(_lastFacebookLoginLocation);
			}
			BragFacebook((List<Friend>)3);
			return;
		}
		if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref lastRealTime) != (void*)5)
		{
			if (System.Runtime.CompilerServices.Unsafe.AsPointer(ref timeLeft) != null)
			{
				BragFacebook((List<Friend>)1);
			}
			else
			{
				BragFacebook(null);
			}
			return;
		}
		bool flag = System.Runtime.CompilerServices.Unsafe.AsPointer(ref timeLeft) == null;
		bool flag2 = _fbState != FacebookState.LoggingIn;
		object obj4 = flag | flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [timeLeft @ L2 (System.Single&)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [timeLeft @ L2 (System.Single&)+24]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [timeLeft @ L2 (System.Single&)+24]");
				bool flag3;
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ S0_v27+8]");
					flag3 = (nint)0 == 0;
				}
				else
				{
					flag3 = true;
				}
				if (!flag3)
				{
					nint num5 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v31 (Il2CppClass<Strings>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ S0_v38 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = Strings.GetDefault("FACEBOOK");
					string content = Strings.GetDefault("OK");
					nint num7 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S3_v5 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num8 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S3_v10 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [timeLeft @ L2 (System.Single&)+24]");
					((GUIArea)(object)text)._002Ector((Rect)0, content, (string)null);
				}
			}
		}
		BragFacebook((List<Friend>)1);
	}

	private unsafe void UpdateTimeLeft(ref float lastRealTime, ref float timeLeft)
	{
		//IL_0009: Expected Ref, but got F4
		//IL_001a: Expected Ref, but got F4
		ref float reference = ref *(float*)10f;
		float maxDelay = NetworkServer.maxDelay;
		ref float reference2 = ref *(float*)maxDelay;
	}

	private IEnumerator FacebookLoginCoroutine(Action<bool> onComplete)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 20;
		obj = this;
		object obj2 = enumerator + 16;
		obj2 = onComplete;
		return enumerator;
	}

	private unsafe bool HasUnconsolidatedFacebookFriends()
	{
		//IL_02f7: Expected I, but got Obj
		//IL_030d: Expected Obj, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected Obj, but got Unknown
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_01bb: Expected I, but got Obj
		//IL_01d1: Expected Obj, but got I
		//IL_00e0: Expected I, but got Obj
		//IL_012d: Expected I, but got Obj
		//IL_0143: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_01fc: Expected I, but got Obj
		//IL_02d1: Expected Obj, but got I4
		//IL_02d1: Expected Obj, but got I4
		//IL_016e: Expected I, but got Obj
		if (~(_didAddChangeHandlerToFacebookSession ? 1u : 0u) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			FacebookSession.StatusChangedHandler statusChangedHandler = default;
			((Delegate)statusChangedHandler).method_ptr = method_ptr;
			((Delegate)statusChangedHandler).method = (nint)__ldftn(SocialManager.OnFacebookSessionStatusChanged);
			object obj = statusChangedHandler + 16;
			obj = this;
			nint num = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v55 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v61 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			FacebookSession.statusChangedEvent -= statusChangedHandler;
			_didAddChangeHandlerToFacebookSession = true;
		}
		nint num3 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v10 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num4 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v44 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!FacebookSession._IsSupported())
		{
			nint num5 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v30 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v40 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7434");
			int num7 = string.CompareOrdinalIgnoreCaseHelper(",", (string)(object)requiredPermissions);
			bool flag = ((FacebookSession)num7)._RequestNewReadPermissions((string)2);
		}
		nint num8 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S0_v19 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num9 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v25 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
		bool result = default;
		return result;
	}

	public void RecommendAppFacebook()
	{
		//IL_038e: Expected I, but got Obj
		//IL_03a4: Expected Obj, but got I
		//IL_0502: Expected I, but got Obj
		//IL_0518: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected Obj, but got Unknown
		//IL_02aa: Expected Obj, but got I4
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected Obj, but got Unknown
		//IL_02be: Expected Obj, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected Obj, but got Unknown
		//IL_02d2: Expected Obj, but got I4
		//IL_0300: Expected I, but got Obj
		//IL_0316: Expected Obj, but got I
		//IL_0060: Expected I, but got Obj
		//IL_04e9: Expected Obj, but got I4
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_0341: Expected I, but got Obj
		//IL_00ee: Expected I, but got Obj
		//IL_013b: Expected I, but got Obj
		//IL_0151: Expected Obj, but got I
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected Obj, but got Unknown
		//IL_0454: Expected I, but got Obj
		//IL_046a: Expected Obj, but got I
		//IL_017c: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v40 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v110 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ComputeShader computeShader = default;
		int num5 = computeShader.FindKernel(null);
		if (_friends != null)
		{
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S1_v23 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num7 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S1_v104 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (_003C_003Ec._003C_003E9__113_0 == null)
			{
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S1_v78 (Il2CppClass<SocialManager+<>c>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num9 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S1_v98 (Il2CppClass<SocialManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num10 = 0;
				_ = 0;
				object obj6 = default;
				object obj5 = obj6 + 16;
				obj5 = _003C_003Ec._003C_003E9;
				nint num11 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S1_v95 (Il2CppClass<SocialManager+<>c>)+5C]");
				object obj7 = (nint)0 + (nint)28;
				obj7 = obj6;
			}
			throw new NullReferenceException();
		}
		object obj8 = this + 20;
		obj8 = 0;
		object obj9 = this + 72;
		obj9 = 0;
		object obj10 = this + 56;
		obj10 = 0;
		((SocialManager)null).ClearGameCenter();
		int num12 = _consolidationState & -2;
		_consolidationState = num12;
		nint num13 = (nint)typeof(CharacterScreenManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ S0_v25 (Il2CppClass<UI.Screens.CharacterScreenManager>)+BA]");
		object obj11 = (nint)0 & (nint)0x200;
		if (obj11 != null)
		{
			nint num14 = (nint)typeof(CharacterScreenManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S0_v31 (Il2CppClass<UI.Screens.CharacterScreenManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool running = FirstPurchaseBonusManager.running;
		((CharacterScreenManager)running).OnCharacterScreenHide();
	}

	public void BragFacebook(List<Friend> friends)
	{
		//IL_0036: Expected I4, but got Obj
		if ((nint)_fbState != (nint)friends)
		{
			_fbState = (FacebookState)friends;
			if (_onFacebookStateChanged != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
			}
		}
	}

	private IEnumerator DownloadPictureForProfile(FacebookProfile profile, SocialPictureSize pictureSize, Action<FacebookProfile, Texture2D> handler)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0049: Expected Obj, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = profile & 1;
		object obj3 = pictureSize & SocialPictureSize.Large;
		object obj4 = handler & 1;
		return enumerator;
	}

	private void OnDownloadedFacebookPicture(FacebookProfile profile, Texture2D picture)
	{
		//IL_004d: Expected Obj, but got F4
		//IL_00a5: Expected Obj, but got F4
		if (_fbState != FacebookState.Opening)
		{
			float maxDelay = NetworkServer.maxDelay;
			float num = maxDelay - (float)profile;
			FacebookProfile facebookProfile = (FacebookProfile)maxDelay;
			if (num < 0.5f && ~(_appHasFocus ? 1u : 0u) == 0)
			{
				float num2 = (float)picture - num;
				Texture2D texture2D = (Texture2D)num2;
			}
		}
	}

	private IEnumerator DownloadFacebookPictures(IDictionary<string, FacebookProfile> fbProfiles)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = fbProfiles;
		return enumerator;
	}

	public void Invalidate()
	{
		//IL_0417: Expected I, but got Obj
		//IL_042d: Expected Obj, but got I
		//IL_0388: Expected I, but got Obj
		//IL_039e: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0072: Expected Obj, but got I
		//IL_0082: Expected Obj, but got I
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00e6: Expected Obj, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected Obj, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected Obj, but got Unknown
		//IL_0122: Expected Obj, but got I
		//IL_0132: Expected Obj, but got I
		//IL_0142: Expected Obj, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected Obj, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected Obj, but got Unknown
		//IL_017e: Expected Obj, but got I
		//IL_018e: Expected Obj, but got I
		//IL_019e: Expected Obj, but got I
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected Obj, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected Obj, but got Unknown
		//IL_01d2: Expected I, but got Obj
		//IL_01e8: Expected Obj, but got I
		//IL_03c9: Expected I, but got Obj
		//IL_046e: Expected Obj, but got I
		//IL_047e: Expected Obj, but got I
		//IL_048e: Expected Obj, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected Obj, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected Obj, but got Unknown
		//IL_04c2: Expected I, but got Obj
		//IL_04d8: Expected Obj, but got I
		//IL_050d: Expected I, but got Obj
		//IL_0523: Expected Obj, but got I
		//IL_0213: Expected I, but got Obj
		//IL_0564: Expected I4, but got Obj
		//IL_0260: Expected I, but got Obj
		//IL_02ad: Expected I, but got Obj
		//IL_02fa: Expected I, but got Obj
		//IL_0310: Expected Obj, but got I
		//IL_0598: Expected Obj, but got I4
		//IL_05af: Expected I, but got Obj
		//IL_05c5: Expected Obj, but got I
		//IL_05cd: Expected Obj, but got I4
		//IL_033b: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v58 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (FacebookSession._IsSupported())
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S3_v3 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ S3_v4+60]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v52 @ S4_v5 (should have been resolved before IL gen)");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S4_v7 (Il2CppMethodInfo)+C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S4_v8+60]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S4_v9+48]");
			object obj9 = 0;
			object obj10 = obj9 & 0x7FF;
			object obj11 = obj10 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v71 @ S5_v7 (should have been resolved before IL gen)");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S4_v12 (Il2CppMethodInfo)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ S4_v13+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S4_v14+48]");
			object obj14 = 0;
			object obj15 = obj14 & 0x7FF;
			object obj16 = obj15 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v90 @ S5_v11 (should have been resolved before IL gen)");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S4_v17 (Il2CppMethodInfo)+C]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S4_v18+60]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S4_v19+48]");
			object obj19 = 0;
			object obj20 = obj19 & 0x7FF;
			object obj21 = obj20 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v109 @ S5_v15 (should have been resolved before IL gen)");
			nint num7 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v34 (Il2CppClass<Strings>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num8 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v54 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string text = Strings.GetDefault("FACEBOOK_RECOMMEND_CAPTION");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S4_v22 (Il2CppMethodInfo)+C]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S4_v23+60]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S4_v24+48]");
			object obj25 = 0;
			object obj26 = obj25 & 0x7FF;
			object obj27 = obj26 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v156 @ S5_v19 (should have been resolved before IL gen)");
			nint num10 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v44 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj28 = (nint)0 & (nint)0x200;
			if (obj28 != null)
			{
				nint num11 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v50 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
			nint num12 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S1_v19 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj29 = (nint)0 & (nint)0x200;
			if (obj29 != null)
			{
				nint num13 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ S1_v25 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _003C_003Ec._003C_003E9__130_0 == null;
			bool flag2 = !flag;
			int cookie = (int)_003C_003Ec._003C_003E9__130_0;
			if (!flag2)
			{
				nint num14 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S2_v19 (Il2CppClass<SocialManager+<>c>)+BA]");
				object obj30 = (nint)0 & (nint)0x200;
				if (obj30 != null)
				{
					nint num15 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ S2_v36 (Il2CppClass<SocialManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num16 = 0;
				_ = 0;
				int num17 = default;
				object obj31 = num17 + 16;
				obj31 = _003C_003Ec._003C_003E9;
				nint num18 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S2_v33 (Il2CppClass<SocialManager+<>c>)+5C]");
				object obj32 = (nint)0 + (nint)40;
				obj32 = num17;
				cookie = num17;
			}
			FacebookSession facebookSession = default;
			IDictionary<string, object> error = default;
			facebookSession.OnFacebookSessionRequestCompleteWithObject((IDictionary<string, object>)(object)"feed", error, cookie);
			return;
		}
		nint num19 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v14 (Il2CppClass<SocialManager>)+BA]");
		object obj33 = (nint)0 & (nint)0x200;
		if (obj33 != null)
		{
			nint num20 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ S0_v20 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
	}

	private bool ShouldRegisterUser()
	{
		return (byte)_consolidationState != 0;
	}

	private bool ShouldConsolidateFriends()
	{
		return _consolidatedFriendsCompleted;
	}

	public unsafe void CollectFriendReward(Friend friend)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cca: Expected Obj, but got Unknown
		//IL_0cd3: Expected Obj, but got I4
		//IL_0ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce7: Expected Obj, but got Unknown
		//IL_0d03: Expected I, but got Obj
		//IL_0d19: Expected Obj, but got I
		//IL_1226: Unknown result type (might be due to invalid IL or missing references)
		//IL_122b: Expected Obj, but got Unknown
		//IL_0c3b: Expected I, but got Obj
		//IL_0c51: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0c7c: Expected I, but got Obj
		//IL_0381: Expected I, but got Obj
		//IL_0397: Expected Obj, but got I
		//IL_0a44: Expected I, but got Obj
		//IL_0a5a: Expected Obj, but got I
		//IL_03c2: Expected I, but got Obj
		//IL_0f37: Expected Obj, but got I4
		//IL_0ad2: Expected I, but got Obj
		//IL_0ae8: Expected Obj, but got I
		//IL_0a85: Expected I, but got Obj
		//IL_0f85: Expected Obj, but got I
		//IL_0f95: Expected Obj, but got I
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Expected Obj, but got Unknown
		//IL_0fb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb9: Expected Obj, but got Unknown
		//IL_0fd9: Expected Obj, but got I
		//IL_0fe9: Expected Obj, but got I
		//IL_0ff9: Expected Obj, but got I
		//IL_1002: Unknown result type (might be due to invalid IL or missing references)
		//IL_1007: Expected Obj, but got Unknown
		//IL_1010: Unknown result type (might be due to invalid IL or missing references)
		//IL_1015: Expected Obj, but got Unknown
		//IL_1035: Expected Obj, but got I
		//IL_1045: Expected Obj, but got I
		//IL_1055: Expected Obj, but got I
		//IL_105e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1063: Expected Obj, but got Unknown
		//IL_106c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1071: Expected Obj, but got Unknown
		//IL_1091: Expected Obj, but got I
		//IL_10a1: Expected Obj, but got I
		//IL_10b1: Expected Obj, but got I
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bf: Expected Obj, but got Unknown
		//IL_10c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cd: Expected Obj, but got Unknown
		//IL_10ed: Expected Obj, but got I
		//IL_10fd: Expected Obj, but got I
		//IL_110d: Expected Obj, but got I
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Expected Obj, but got Unknown
		//IL_1124: Unknown result type (might be due to invalid IL or missing references)
		//IL_1129: Expected Obj, but got Unknown
		//IL_1141: Expected I, but got Obj
		//IL_1157: Expected Obj, but got I
		//IL_0d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Expected Obj, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected Obj, but got Unknown
		//IL_0d7e: Expected Obj, but got I4
		//IL_1198: Expected I4, but got Obj
		//IL_0b13: Expected I, but got Obj
		//IL_0b60: Expected I, but got Obj
		//IL_06b4: Expected I, but got Obj
		//IL_06ca: Expected Obj, but got I
		//IL_045e: Expected I, but got Obj
		//IL_0474: Expected Obj, but got I
		//IL_0bad: Expected I, but got Obj
		//IL_0bc3: Expected Obj, but got I
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_0e73: Expected Obj, but got I4
		//IL_128f: Expected I, but got Obj
		//IL_12a5: Expected Obj, but got I
		//IL_01e5: Expected Obj, but got I
		//IL_11cc: Expected Obj, but got I4
		//IL_11e3: Expected I, but got Obj
		//IL_11f9: Expected Obj, but got I
		//IL_1201: Expected Obj, but got I4
		//IL_0f12: Expected Obj, but got I4
		//IL_0eb4: Expected Obj, but got I4
		//IL_049f: Expected I, but got Obj
		//IL_0bee: Expected I, but got Obj
		//IL_08bc: Expected I, but got Obj
		//IL_0ee3: Expected Obj, but got I4
		//IL_058a: Expected I, but got Obj
		//IL_12ca: Expected native int or pointer, but got Obj
		//IL_029d: Expected I, but got Obj
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0738: Expected I, but got Obj
		//IL_02ea: Expected I, but got Obj
		//IL_0300: Expected Obj, but got I
		//IL_0ddc: Expected Obj, but got I
		//IL_0df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df5: Expected Obj, but got Unknown
		//IL_0e0c: Expected I, but got Obj
		//IL_0e22: Expected Obj, but got I
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected Obj, but got Unknown
		//IL_032b: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 32;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v313 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj6 = obj2 + 8;
		List<Friend> list = default;
		if (FacebookSession._IsSupported())
		{
			if (friend == null)
			{
				goto IL_036a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			list._002Ector(friend.score);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S0_v23+8]");
			_ = 0;
			object obj7 = default;
			object obj8 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj7 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v298+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ S0_v298+C]");
					if (0 < (nint)obj8)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
					}
				}
			}
			object obj9 = obj4 + 4;
			object obj10 = obj9 + 1;
			obj9 = obj10;
			object obj11 = obj10 << 2;
			object obj12 = obj4 + obj11;
			obj12 = 102;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj13 = (nint)0 << 2;
				object obj14 = obj4 + obj13;
				if ((nint)obj14 == 102)
				{
					object obj15 = obj4 + 4;
					if ((nint)obj15 > -1)
					{
						object obj16 = obj15 + -1;
						obj15 = obj16;
					}
					goto IL_1281;
				}
			}
			object obj17 = default;
			if (obj17 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
			goto IL_1281;
		}
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v29 (Il2CppClass<SocialManager>)+BA]");
		object obj18 = (nint)0 & (nint)0x200;
		if (obj18 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v35 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
		return;
		IL_1281:
		nint num5 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ S0_v219 (Il2CppClass<SocialManager+<>c>)+BA]");
		object obj19 = (nint)0 & (nint)0x200;
		if (obj19 != null)
		{
			nint num6 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v569 @ S0_v256 (Il2CppClass<SocialManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__133_0 == null;
		bool flag2 = !flag;
		Queue<_00210> q = (Queue<_00210>)(object)_003C_003Ec._003C_003E9__133_0;
		if (!flag2)
		{
			nint num7 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ S0_v230 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num8 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ S0_v250 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num9 = 0;
			Queue<_00210> queue = default;
			queue._array = (_00210[])num9;
			queue._size = 0;
			object obj21 = queue + 16;
			obj21 = _003C_003Ec._003C_003E9;
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ S0_v247 (Il2CppClass<SocialManager+<>c>)+5C]");
			object obj22 = (nint)0 + (nint)44;
			obj22 = queue;
			q = queue;
		}
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)list, new Queue<T>.Enumerator((Queue<T>)(object)q));
		goto IL_036a;
		IL_036a:
		int bragScoreThreshold = PlayerSave.bragScoreThreshold;
		nint num11 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v44 (Il2CppClass<SocialManager>)+BA]");
		object obj23 = (nint)0 & (nint)0x200;
		if (obj23 != null)
		{
			nint num12 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v191 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SocialManagerIOS arg = SocialManagerIOS.instance;
		if (list != null && list._size != 0)
		{
			if (list._size != 1)
			{
				if (list._size == 2)
				{
					nint num13 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ S0_v166 (Il2CppClass<Strings>)+BA]");
					object obj24 = (nint)0 & (nint)0x200;
					if (obj24 != null)
					{
						nint num14 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ S0_v174 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text = Strings.GetDefault("FACEBOOK_BRAG_MESSAGE_BEAT_TWO");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					obj6 = bragScoreThreshold;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					throw new ArrayTypeMismatchException();
				}
				nint num15 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ S0_v94 (Il2CppClass<Strings>)+BA]");
				object obj25 = (nint)0 & (nint)0x200;
				bool flag3 = obj25 == null;
				if (list._size == 3)
				{
					if (!flag3)
					{
						nint num16 = (nint)typeof(Strings);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ S0_v161 (Il2CppClass<Strings>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					string text2 = Strings.GetDefault("FACEBOOK_BRAG_MESSAGE_BEAT_THREE");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					obj6 = bragScoreThreshold;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
					throw new ArrayTypeMismatchException();
				}
				if (!flag3)
				{
					nint num17 = (nint)typeof(Strings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ S0_v134 (Il2CppClass<Strings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text3 = Strings.GetDefault("FACEBOOK_BRAG_MESSAGE_BEAT_MANY");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				obj6 = bragScoreThreshold;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				throw new ArrayTypeMismatchException();
			}
			nint num18 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ S0_v179 (Il2CppClass<Strings>)+BA]");
			object obj26 = (nint)0 & (nint)0x200;
			if (obj26 != null)
			{
				nint num19 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ S0_v187 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string provider = Strings.GetDefault("FACEBOOK_BRAG_MESSAGE_BEAT_ONE");
			obj6 = bragScoreThreshold;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			Friend friend2 = list.get_Item(0);
			FacebookProfile fbProfile = friend2.fbProfile;
			string format = default;
			string text4 = string.Format((IFormatProvider)(object)provider, format, arg, fbProfile.fullName);
		}
		else
		{
			nint num20 = (nint)typeof(Strings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v66 (Il2CppClass<Strings>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			if (obj27 != null)
			{
				nint num21 = (nint)typeof(Strings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ S0_v74 (Il2CppClass<Strings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string provider2 = Strings.GetDefault("FACEBOOK_BRAG_MESSAGE_BEAT_NONE");
			obj6 = bragScoreThreshold;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string format2 = default;
			string text4 = string.Format((IFormatProvider)(object)provider2, format2, arg);
		}
		nint num22 = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v446 @ S0_v54 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num23 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ S0_v60 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7423");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ S4_v4 (Il2CppMethodInfo)+C]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ S4_v5+60]");
		object obj30 = 0;
		object obj31 = obj30;
		object obj32 = obj31 & 0x1FFF;
		object obj33 = obj32 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v614 @ S5_v6 (should have been resolved before IL gen)");
		nint num25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ S5_v8 (Il2CppMethodInfo)+C]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ S5_v9+60]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ S5_v10+48]");
		object obj36 = 0;
		object obj37 = obj36 & 0x7FF;
		object obj38 = obj37 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v632 @ S6_v7 (should have been resolved before IL gen)");
		nint num26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ S5_v13 (Il2CppMethodInfo)+C]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ S5_v14+60]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ S5_v15+48]");
		object obj41 = 0;
		object obj42 = obj41 & 0x7FF;
		object obj43 = obj42 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v651 @ S6_v11 (should have been resolved before IL gen)");
		nint num27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ S5_v18 (Il2CppMethodInfo)+C]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ S5_v19+60]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v662 @ S5_v20+48]");
		object obj46 = 0;
		object obj47 = obj46 & 0x7FF;
		object obj48 = obj47 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v670 @ S6_v15 (should have been resolved before IL gen)");
		nint num28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ S5_v23 (Il2CppMethodInfo)+C]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ S5_v24+60]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ S5_v25+48]");
		object obj51 = 0;
		object obj52 = obj51 & 0x7FF;
		object obj53 = obj52 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v141 @ S6_v19 (should have been resolved before IL gen)");
		nint num29 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ S1_v31 (Il2CppClass<SocialManager+<>c>)+BA]");
		object obj54 = (nint)0 & (nint)0x200;
		if (obj54 != null)
		{
			nint num30 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ S1_v37 (Il2CppClass<SocialManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag4 = _003C_003Ec._003C_003E9__133_1 == null;
		bool flag5 = !flag4;
		int cookie = (int)_003C_003Ec._003C_003E9__133_1;
		if (!flag5)
		{
			nint num31 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v781 @ S2_v22 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj55 = (nint)0 & (nint)0x200;
			if (obj55 != null)
			{
				nint num32 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ S2_v39 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num33 = 0;
			_ = 0;
			int num34 = default;
			object obj56 = num34 + 16;
			obj56 = _003C_003Ec._003C_003E9;
			nint num35 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v879 @ S2_v36 (Il2CppClass<SocialManager+<>c>)+5C]");
			object obj57 = (nint)0 + (nint)48;
			obj57 = num34;
			cookie = num34;
		}
		FacebookSession facebookSession = default;
		IDictionary<string, object> error = default;
		facebookSession.OnFacebookSessionRequestCompleteWithObject((IDictionary<string, object>)(object)"feed", error, cookie);
	}

	public int CashIn(Friend friend, int max)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04b9: Expected Obj, but got I4
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected Obj, but got Unknown
		//IL_04e9: Expected I, but got Obj
		//IL_04ff: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected Obj, but got Unknown
		//IL_01ff: Expected Obj, but got I4
		//IL_009a: Expected I, but got Obj
		//IL_00b0: Expected Obj, but got I
		//IL_0287: Expected Obj, but got I
		//IL_0676: Expected I, but got Obj
		//IL_068c: Expected Obj, but got I
		//IL_0340: Expected Obj, but got I
		//IL_00db: Expected I, but got Obj
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected Obj, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected Obj, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected Obj, but got Unknown
		//IL_0613: Expected Obj, but got I
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected Obj, but got Unknown
		//IL_0441: Expected I4, but got Obj
		//IL_044e: Expected Obj, but got I4
		//IL_03f8: Expected I, but got Obj
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected Obj, but got Unknown
		//IL_0464: Expected Obj, but got I4
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected Obj, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected Obj, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected Obj, but got Unknown
		//IL_0578: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18 (Il2CppClass<Globals>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v155 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F7C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		object obj6 = default;
		object obj8 = default;
		object obj9 = default;
		object obj10 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				nint num3 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ S0_v117 (Il2CppClass<UnityEngine.Object>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num4 = (nint)typeof(UnityEngine.Object);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ S0_v148 (Il2CppClass<UnityEngine.Object>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj8 == null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj9 == null)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v111+10]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [max @ L2 (System.Int32)+8]");
				if (num5 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
					if (obj10 != null)
					{
						object obj11 = obj4 + 4;
						object obj12 = obj11 + 1;
						obj11 = obj12;
						object obj13 = obj12 << 2;
						object obj14 = obj4 + obj13;
						obj14 = 177;
						break;
					}
				}
				continue;
			}
			object obj15 = obj4 + 4;
			object obj16 = obj15 + 1;
			obj15 = obj16;
			object obj17 = obj16 << 2;
			object obj18 = obj4 + obj17;
			obj18 = 111;
			break;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj4 + obj19;
			if ((nint)obj20 == 177)
			{
				object obj21 = obj4 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				return 0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			object obj23 = (nint)0 << 2;
			object obj24 = obj4 + obj23;
			if ((nint)obj24 == 111)
			{
				object obj25 = obj4 + 4;
				if ((nint)obj25 > -1)
				{
					object obj26 = obj25 + -1;
					obj25 = obj26;
				}
				goto IL_0668;
			}
		}
		object obj27 = default;
		if (obj27 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0668;
		IL_0668:
		nint num6 = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ S0_v44 (Il2CppClass<Globals>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num7 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ S0_v57 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj30 = default;
		object obj29 = obj30 + 8;
		obj29 = this;
		object obj31 = obj30 + 12;
		obj31 = friend;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [max @ L2 (System.Int32)+8]");
		_ = 0;
		object obj32 = obj30 + 20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [max @ L2 (System.Int32)+C]");
		obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @10F73");
		AnimationState animationState = ((Animation)(object)this).get_Item((string)(object)friend);
		bool flag = ((Animation)(object)this).Play((PlayMode)friend);
		string text = ((AnimationState)flag).name;
		((AnimationClip)(object)text).AddEventInternal((object)max);
		if ((object)animationState != null)
		{
			AnimationState animationState2 = ((Animation)(object)this).CrossFadeQueued((string)(object)friend);
		}
		return 1;
	}

	public int CashInAll(int maxPerFriend)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		int num = default;
		object obj = num + 16;
		obj = this;
		object obj2 = num + 20;
		obj2 = maxPerFriend;
		return num;
	}

	private static string GetSaveDataPath()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(FacebookSession);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return null;
	}

	private void OnRemoteNotificationsEnabled(string deviceToken, string oldDeviceToken)
	{
		//IL_01eb: Expected I, but got Obj
		//IL_0201: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected Obj, but got Unknown
		//IL_00cf: Expected I, but got Obj
		//IL_00e5: Expected Obj, but got I
		//IL_0110: Expected I, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_019e: Expected I, but got Obj
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v51 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if ((UnityEngine.Object)(object)oldDeviceToken != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		object obj2 = default;
		if ((nint)obj2 == 8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj3 = default;
			if ((nint)obj3 == 8)
			{
				return;
			}
		}
		object obj4 = deviceToken + 20;
		obj4 = oldDeviceToken;
		nint num3 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v21 (Il2CppClass<SocialManager>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v42 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (SocialManager.m_facebookPictureDownloadedHandler == null)
		{
			return;
		}
		nint num5 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v29 (Il2CppClass<SocialManager>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ S0_v36 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7C62");
	}

	private void Awake()
	{
		//IL_00d0: Expected I, but got Obj
		//IL_00e6: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0111: Expected I, but got Obj
		//IL_0054: Expected I, but got Obj
		//IL_01c1: Expected I, but got Obj
		//IL_01d7: Expected Obj, but got I
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected Obj, but got Unknown
		//IL_036a: Expected Obj, but got I
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected Obj, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected Obj, but got Unknown
		//IL_0202: Expected I, but got Obj
		//IL_024f: Expected I, but got Obj
		//IL_0265: Expected Obj, but got I
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected Obj, but got Unknown
		//IL_04a3: Expected I, but got Obj
		//IL_04b9: Expected Obj, but got I
		//IL_0290: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath == 8)
		{
			nint num = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v92 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v105 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstanced = SocialManagerIOS.isInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v97 (System.Boolean)+C]");
			bool flag;
			if ((nint)0 == 3)
			{
				flag = true;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v97 (System.Boolean)+C]");
				flag = (nint)0 == 0;
			}
			if (!flag)
			{
				return;
			}
		}
		nint num3 = (nint)typeof(RemoteNotificationControl);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v11 (Il2CppClass<RemoteNotificationControl>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v87 (Il2CppClass<RemoteNotificationControl>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		SocialManager socialManager = instance;
		if ((object)socialManager == null)
		{
			return;
		}
		FacebookSession facebookSession = ((SocialManager)null).CreateFacebookSessionIfNeeded();
		if ((object)facebookSession != null && ~(_fbReady ? 1u : 0u) != 0)
		{
			return;
		}
		if (consolidatedFriendsCompleted)
		{
			nint num5 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ S0_v41 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v78 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag2 = _003C_003Ec._003C_003E9__143_0 == null;
			bool flag3 = !flag2;
			Action<bool> consolidateFriendsCompleted = _003C_003Ec._003C_003E9__143_0;
			if (!flag3)
			{
				nint num7 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v52 (Il2CppClass<SocialManager+<>c>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num8 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v72 (Il2CppClass<SocialManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num9 = 0;
				_ = 0;
				Action<bool> action = default;
				object obj5 = action + 16;
				obj5 = _003C_003Ec._003C_003E9;
				nint num10 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v69 (Il2CppClass<SocialManager+<>c>)+5C]");
				object obj6 = (nint)0 + (nint)52;
				obj6 = action;
				consolidateFriendsCompleted = action;
			}
			ConsolidateFriends(consolidateFriendsCompleted);
		}
		string checksum = GetChecksum((string)(object)this);
		if (checksum != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num11 = 0;
			_ = 0;
			Action<bool> action2 = default;
			object obj7 = action2 + 16;
			obj7 = this;
			UpdateFriendScores(action2);
		}
		else if (this.m_friendsConsolidatedHandler != null)
		{
			nint num12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v3 (Il2CppMethodInfo)+18]");
			object obj8 = 0;
			object obj9 = obj8;
			object obj10 = obj9 & 0x3FFF;
			object obj11 = obj10 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v74 @ S3_v5 (should have been resolved before IL gen)");
		}
	}

	private void AttemptRelogin()
	{
		//IL_0349: Expected I, but got Obj
		//IL_035f: Expected Obj, but got I
		//IL_0443: Expected I, but got Obj
		//IL_0459: Expected Obj, but got I
		//IL_0493: Expected I, but got Obj
		//IL_04a9: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected Obj, but got Unknown
		//IL_02ba: Expected I, but got Obj
		//IL_02d0: Expected Obj, but got I
		//IL_0179: Expected I, but got Obj
		//IL_0394: Expected I, but got Obj
		//IL_03aa: Expected Obj, but got I
		//IL_01e0: Expected Obj, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected Obj, but got Unknown
		//IL_0201: Expected I, but got Obj
		//IL_0217: Expected Obj, but got I
		//IL_00c6: Expected I, but got Obj
		//IL_02fb: Expected I, but got Obj
		//IL_0416: Expected I4, but got Obj
		//IL_0113: Expected I, but got Obj
		//IL_0242: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v85 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v40 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int num5 = ((ComputeShader)(object)_instance).FindKernel((string)null);
		nint num6 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v10 (Il2CppClass<SocialManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		bool flag = obj3 != null;
		if (num5 != 0)
		{
			if (flag)
			{
				nint num7 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v81 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S0_v72 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num9 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ S0_v77 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			UnityEngine.Object.DestroyImmediate(this);
			return;
		}
		if (flag)
		{
			nint num10 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v61 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_instance = this;
		bool flag2 = HasUnconsolidatedFacebookFriends();
		if (PreferencesSave.localNotificationsEnabled != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			SocialManager socialManager = default;
			((UnityEngine.Object)socialManager).m_CachedPtr = cachedPtr;
			socialManager._latestSuccesfullyConsolidatedFacebookIds = (List<string>)0;
			object obj5 = socialManager + 16;
			obj5 = this;
			nint num11 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S0_v52 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v57 (Il2CppClass<RemoteNotificationControl>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			socialManager.isRunningFacebookLogin = (byte)(int)"cpush.wav" != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num13 = 0;
		_ = 0;
		Action<FacebookProfile> action = default;
		object obj7 = action + 16;
		obj7 = this;
		nint num14 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v34 (Il2CppClass<SocialManager>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num15 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S0_v41 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		facebookPictureDownloadedHandler -= action;
		OnApplicationQuit();
		Awake();
	}

	private void OnApplicationFocus(bool focus)
	{
		//IL_0010: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [focus @ L1 (System.Boolean)+28]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [focus @ L1 (System.Boolean)+14]");
		_ = 0;
	}

	private void OnApplicationPause(bool pause)
	{
		_appHasFocus = pause;
	}

	private void OnApplicationQuit()
	{
		FacebookSession facebookSession = ((SocialManager)null).CreateFacebookSessionIfNeeded();
		if ((object)facebookSession != null)
		{
			bool flag = IsOAuthException((FacebookError)(object)this, null);
		}
	}

	private void InitAchievements()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		_applicationIsQuiting = true;
	}

	public void ReportAchievement(string achievementId, float percentCompleted)
	{
		string debugText = ((CurveParent)(object)achievementId).GetDebugText();
		Vector3 vector = ((Curve)(object)debugText).EvaluateDerivative(percentCompleted);
	}

	private static string GetRandomIdentifier()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00aa: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string cachePath = DeviceUtility.GetCachePath();
		return string.ConcatArray((string[])(object)cachePath, (int)"/socialdata");
	}

	public static string GetChecksum(string data)
	{
		//IL_0146: Expected Obj, but got I4
		//IL_0051: Expected I, but got Obj
		//IL_0067: Expected Obj, but got I
		//IL_0132: Invalid comparison between F4 and I4
		//IL_0140: Expected Obj, but got I4
		//IL_0092: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [data @ L0 (System.String)+74]");
		if ((nint)0 != 0 && ((SocialManager)(object)data).consolidationState == 0)
		{
			float maxDelay = NetworkServer.maxDelay;
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S2_v2 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S2_v8 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float num3 = maxDelay - (float)(int)data.m_firstChar;
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath).GetValue("social_consolidate_min_seconds", 3600u);
			bool flag = !(num3 < (float)(int)value);
			return (string)flag;
		}
		return (string)1;
	}

	private unsafe static string GetChecksum(string[] data)
	{
		//IL_0018: Expected I4, but got Obj
		//IL_003c: Expected Obj, but got I4
		string data2 = string.ConcatArray(data, (int)"resxrctrv7tgv7gb8h9h9u0909kllfmolkjnhghgjjkhjghg");
		byte[] str = Checksum.ComputeMD5(data2);
		return (string)TimeUtility.TryParseSortableNumber((string)(object)str, out *(DateTime*)1);
	}

	public static IEnumerator WWWRequestCoroutine(WWWComplete onWWWComplete, string relativeUrl, object cookie, string[] postItems)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = relativeUrl;
		object obj2 = enumerator + 24;
		obj2 = postItems;
		return enumerator;
	}

	private void FireAndForgetUnregisterDevice(string token)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(token & 1) != 0;
		canUnregisterDevice__BackingField = flag;
	}

	private void UnregisterDevice(Action<bool> completionHandler)
	{
		bool flag;
		if (completionHandler != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [completionHandler @ L1 (System.Action`1<System.Boolean>)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			throw new ArrayTypeMismatchException();
		}
	}

	private void WWWUnregisterDeviceCompleted(WWWRequestResult result, string output, object cookie)
	{
		//IL_0012: Expected I4, but got Obj
		//IL_0012: Expected Obj, but got I4
		IEnumerator routine = DownloadPictureForProfile((FacebookProfile)result, (SocialPictureSize)output, (Action<FacebookProfile, Texture2D>)cookie);
		Coroutine coroutine = StartCoroutine_Auto(routine);
	}

	private void RegisterUser(Action<bool> registerUserCompleted)
	{
		//IL_02b3: Expected I, but got Obj
		//IL_02c9: Expected Obj, but got I
		//IL_02f4: Expected I, but got Obj
		//IL_00d2: Expected I, but got Obj
		//IL_00e8: Expected Obj, but got I
		//IL_0044: Expected I, but got Obj
		//IL_005a: Expected Obj, but got I
		//IL_0113: Expected I, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected Obj, but got Unknown
		if (~(canUnregisterDevice__BackingField ? 1u : 0u) == 0)
		{
			if (PreferencesSave.localNotificationsEnabled == 0)
			{
				nint num = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S0_v69 (Il2CppClass<SocialManager>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v75 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
			}
			else
			{
				nint num3 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v26 (Il2CppClass<RemoteNotificationControl>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(RemoteNotificationControl);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v64 (Il2CppClass<RemoteNotificationControl>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SocialManager socialManager = instance;
				if ((object)socialManager != null && ((UnityEngine.Object)socialManager).m_CachedPtr != (IntPtr)0)
				{
					canUnregisterDevice__BackingField = false;
					requestInvolvingDevicetokenInProgress__BackingField = true;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					nint cachedPtr = 0;
					SocialManagerIOS socialManagerIOS = default;
					((UnityEngine.Object)socialManagerIOS).m_CachedPtr = cachedPtr;
					socialManagerIOS._pausePhotoDownloading = false;
					object obj3 = socialManagerIOS + 16;
					obj3 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					throw new ArrayTypeMismatchException();
				}
			}
		}
		else
		{
			nint num5 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v12 (Il2CppClass<SocialManager>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num6 = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v18 (Il2CppClass<SocialManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
		}
		registerUserCompleted?.Invoke(obj: false);
	}

	private int GetCurrentRank()
	{
		return canUnregisterDevice__BackingField ? 1 : 0;
	}

	private unsafe void FetchRegisterUserParams(out string fbid, out string gcid, out string deviceToken, out string bundleVersion, out string highestScore, out string registerUserData, out string timezone, out string locale)
	{
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_0240: Expected Obj, but got Ref
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected Obj, but got Unknown
		//IL_0253: Expected Obj, but got Ref
		//IL_0261: Expected I, but got Obj
		//IL_0277: Expected Obj, but got I
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Expected Obj, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected Obj, but got Unknown
		//IL_035e: Expected Obj, but got Ref
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected Obj, but got Unknown
		//IL_0371: Expected Obj, but got Ref
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected Obj, but got Unknown
		//IL_0384: Expected Obj, but got Ref
		//IL_03a8: Expected F4, but got Obj
		//IL_03a8: Expected F4, but got Obj
		//IL_0083: Expected I, but got Obj
		//IL_0099: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0182: Expected I, but got Obj
		//IL_0198: Expected Obj, but got I
		//IL_00c4: Expected I, but got Obj
		//IL_02ec: Expected Obj, but got Ref
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected Obj, but got Unknown
		//IL_02ca: Expected Obj, but got Ref
		//IL_02e1: Expected VT, but got I4
		//IL_02e1: Expected Obj, but got I4
		//IL_01c3: Expected I, but got Obj
		//IL_0143: Expected VT, but got Obj
		//IL_016a: Expected I4, but got Obj
		//IL_016a: Expected Obj, but got I4
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected Obj, but got Unknown
		//IL_0215: Expected Obj, but got Ref
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0228: Expected Obj, but got Ref
		object obj = this + 124;
		obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref timezone);
		object obj2 = this + 136;
		obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref deviceToken);
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v8 (Il2CppClass<UnityEngine.Vector3>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Vector3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S1_v61 (Il2CppClass<UnityEngine.Vector3>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Vector3 one = Vector3.one;
		Transform transform2 = default;
		Transform transform = (Transform)(transform2 + 12);
		transform = transform2;
		((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
		Vector3 eulerAngles = transform.eulerAngles;
		object obj4 = this + 128;
		obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref bundleVersion);
		object obj5 = this + 132;
		obj5 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref highestScore);
		object obj6 = this + 140;
		obj6 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref registerUserData);
		_ = _tempRegisterUserData;
		_ = _appHasFocus;
		float num3 = ScrollRect.RubberDelta((float)_latestSuccesfullyConsolidatedFacebookIds, (float)_latestPreConsolidationFacebookIds);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (SocialManager)+94]");
		float num4 = 0f + _lastConsolidateFriendCompleteTime;
		nint num5 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S1_v35 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num6 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v57 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (((ComputeShader)(object)this.m_onRegisterUserCompleted).FindKernel((string)null) != 0)
		{
			object obj8 = this + 56;
			obj8 = this.m_onRegisterUserCompleted;
			int layer = ((GameObject)(object)_fbProfile).layer;
			GameObject gameObject = base.gameObject;
			transform2.position = (Vector3)gameObject;
			transform = transform2;
			((UnityEngine.Object)transform).m_CachedPtr = ((UnityEngine.Object)transform2).m_CachedPtr;
			((Transform)layer).SetSiblingIndex((int)transform);
		}
		else
		{
			nint num7 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ S0_v33 (Il2CppClass<UnityEngine.Object>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num8 = (nint)typeof(UnityEngine.Object);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ S0_v43 (Il2CppClass<UnityEngine.Object>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (((ComputeShader)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fbid)).FindKernel(null) != 0)
			{
				object obj10 = this + 56;
				obj10 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fbid);
				object obj11 = this + 40;
				obj11 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref gcid);
			}
		}
		int layer2 = ((GameObject)System.Runtime.CompilerServices.Unsafe.AsPointer(ref fbid)).layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer2, HierarchyPathType.Dynamic, (Vector3)0);
	}

	private void WWWRegisterUserCompleted(WWWRequestResult result, string output, object cookie)
	{
		//IL_0021: Expected I, but got Obj
		//IL_0037: Expected Obj, but got I
		//IL_0062: Expected I, but got Obj
		bool obj;
		if (result != WWWRequestResult.Success)
		{
			obj = false;
		}
		else
		{
			nint num = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v12 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num2 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v20 (Il2CppClass<RemoteNotificationControl>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			RemoteNotificationControl._002Ecctor();
			((TooltipAttribute)(object)"socmanlastregdata")._002Ector("");
			obj = true;
		}
		if (cookie != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			Action<bool> action = default;
			action(obj);
		}
	}

	private string GetFBListAsStringAndSaveAsPreConsolidated()
	{
		//IL_006c: Expected Obj, but got I4
		//IL_00a8: Expected Obj, but got I4
		int currentSkipForVideoMissionIndex = PlayerSave.currentSkipForVideoMissionIndex;
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		int missionSetCount = ((MissionsManager)(object)stayInOneLaneMission).missionSetCount;
		if (missionSetCount != 0)
		{
			bool flag = currentSkipForVideoMissionIndex == int.MinValue;
			bool flag2 = missionSetCount == -1;
			object obj = flag & flag2;
			if (obj != null)
			{
				return null;
			}
			int num = currentSkipForVideoMissionIndex / missionSetCount;
			return (string)num;
		}
		return null;
	}

	private unsafe void ConsolidateFriends(Action<bool> consolidateFriendsCompleted)
	{
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected Obj, but got Unknown
		//IL_048b: Expected Obj, but got I4
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected Obj, but got Unknown
		//IL_04a2: Expected Obj, but got I4
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Expected Obj, but got Unknown
		//IL_04b9: Expected Obj, but got I4
		//IL_04c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Expected I4, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected I4, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected Obj, but got Unknown
		//IL_0508: Expected Obj, but got I4
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Expected Obj, but got Unknown
		//IL_051f: Expected Obj, but got I4
		//IL_0528: Expected Obj, but got I4
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected I4, but got Unknown
		//IL_0561: Expected I, but got Obj
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected Obj, but got Unknown
		//IL_0037: Expected I, but got Obj
		//IL_0086: Expected I, but got Obj
		object obj = default;
		Animation animation = (Animation)(obj + 28);
		animation = (Animation)0;
		string text = (string)(obj + 24);
		text = (string)0;
		string text2 = (string)(obj + 20);
		text2 = (string)0;
		int num = obj + 16;
		((int*)num)->m_value = 0;
		int num2 = obj + 12;
		((int*)num2)->m_value = 0;
		Camera camera = (Camera)(obj + 8);
		camera = (Camera)0;
		Action action = (Action)(obj + 4);
		action = (Action)0;
		obj = 0;
		int fps = this + 24;
		((CaptureAnimation)(object)this)._002Ector(animation, text, text2, num, num2, fps, camera, action);
		nint num3 = (nint)animation;
		bool flag;
		if ((object)animation != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ S0_v25 (Il2CppClass<UnityEngine.Animation>)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			nint num4 = (nint)text;
			bool flag2;
			if (text != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v112 (Il2CppClass<System.String>)+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				nint num5 = (nint)text2;
				bool flag3;
				if (text2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ S0_v116 (Il2CppClass<System.String>)+8]");
					flag3 = (nint)0 == 0;
				}
				else
				{
					flag3 = true;
				}
				if (flag3)
				{
					consolidateFriendsCompleted?.Invoke(obj: false);
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		SocialManagerIOS socialManagerIOS = default;
		((UnityEngine.Object)socialManagerIOS).m_CachedPtr = cachedPtr;
		socialManagerIOS._pausePhotoDownloading = false;
		object obj2 = socialManagerIOS + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void WWWConsolidateFriendsCompleted(WWWRequestResult result, string output, object cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Expected Obj, but got Unknown
		//IL_0576: Expected Obj, but got I4
		//IL_057f: Expected Obj, but got I4
		//IL_0588: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected Obj, but got Unknown
		//IL_04aa: Expected Obj, but got VT
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected Obj, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected Obj, but got Unknown
		//IL_050a: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		bool obj5;
		if (result != WWWRequestResult.Success)
		{
			obj5 = false;
		}
		else
		{
			canUnregisterDevice__BackingField = true;
			requestInvolvingDevicetokenInProgress__BackingField = false;
			string text = StringUtility.FormatProperties((Dictionary<string, string>)(object)output);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			string tempRegisterUserData = _tempRegisterUserData;
			if (_tempRegisterUserData != null && tempRegisterUserData.m_stringLength != 0)
			{
				DateTime utcNow = CDateTime.UtcNow;
				obj3 = utcNow;
				object obj7 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				obj2 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D66F");
				string tooltip = default;
				((TooltipAttribute)(object)"socmanlastregtime")._002Ector(tooltip);
				((TooltipAttribute)(object)"socmanlastregdata")._002Ector(_tempRegisterUserData);
				object obj8 = this + 24;
				obj8 = 0;
			}
			obj5 = true;
		}
		_registerUserCompleted = true;
		if (cookie != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			Action<bool> action = default;
			action(obj5);
		}
		if (this.m_onRegisterUserCompleted != null)
		{
			this.m_onRegisterUserCompleted(obj5);
		}
	}

	public void ReportScore(int newScore, bool isNewHighscore)
	{
		//IL_0056: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_013f: Expected Obj, but got I4
		//IL_0097: Expected I, but got Obj
		string dataPath = Application.dataPath;
		if ((nint)dataPath != 8)
		{
			bool flag;
			if (isNewHighscore)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [isNewHighscore @ L2 (System.Boolean)+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				nint num = (nint)typeof(Flurry);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v14 (Il2CppClass<Flurry>)+BA]");
				object obj = (nint)0 & (nint)0x200;
				if (obj != null)
				{
					nint num2 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v19 (Il2CppClass<Flurry>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				UnregisterDevice((Action<bool>)isNewHighscore);
			}
		}
		Awake();
	}

	private void WWWReportScoreCompleted(WWWRequestResult result, string output, object cookie)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected Obj, but got Unknown
		//IL_10a5: Expected Obj, but got I4
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b3: Expected Obj, but got Unknown
		//IL_10bc: Expected Obj, but got I4
		//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d0: Expected Obj, but got Unknown
		//IL_108d: Expected Obj, but got I4
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_1121: Expected I, but got Obj
		//IL_1137: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		//IL_0101: Expected I, but got Obj
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_0237: Expected I4, but got Obj
		//IL_018f: Expected I, but got Obj
		//IL_0258: Expected Obj, but got I4
		//IL_0265: Expected I4, but got Obj
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected Obj, but got Unknown
		//IL_027d: Expected I, but got Obj
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_0229: Expected Obj, but got I4
		//IL_0c1c: Expected I, but got Obj
		//IL_0c32: Expected Obj, but got I
		//IL_0290: Expected Obj, but got I4
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected Obj, but got Unknown
		//IL_0c5d: Expected I, but got Obj
		//IL_0af2: Expected Obj, but got I4
		//IL_0b09: Expected I, but got Obj
		//IL_0b1f: Expected Obj, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_103d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1042: Expected Obj, but got Unknown
		//IL_1465: Expected I, but got Obj
		//IL_147b: Expected Obj, but got I
		//IL_130e: Expected I, but got Obj
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b97: Expected Obj, but got Unknown
		//IL_0b4a: Expected I, but got Obj
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected Obj, but got Unknown
		//IL_0ee9: Expected I, but got Obj
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected Obj, but got Unknown
		//IL_136b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Expected Obj, but got Unknown
		//IL_1379: Unknown result type (might be due to invalid IL or missing references)
		//IL_137e: Expected Obj, but got Unknown
		//IL_13aa: Expected Obj, but got I4
		//IL_13b3: Expected Obj, but got I4
		//IL_1214: Unknown result type (might be due to invalid IL or missing references)
		//IL_1219: Expected Obj, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected Obj, but got Unknown
		//IL_0429: Expected Obj, but got I4
		//IL_0ed6: Expected Obj, but got I4
		//IL_0e24: Expected Obj, but got I
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected Obj, but got Unknown
		//IL_1231: Unknown result type (might be due to invalid IL or missing references)
		//IL_1236: Expected Obj, but got Unknown
		//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d52: Expected Obj, but got Unknown
		//IL_0461: Expected Obj, but got I4
		//IL_0461: Expected Obj, but got I4
		//IL_046b: Expected I, but got Obj
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e67: Expected Obj, but got Unknown
		//IL_0d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6d: Expected Obj, but got Unknown
		//IL_05b4: Expected Obj, but got I4
		//IL_1417: Expected Obj, but got I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected Obj, but got Unknown
		//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9d: Expected Obj, but got Unknown
		//IL_066b: Expected Obj, but got I
		//IL_07a5: Expected Obj, but got I
		//IL_09fd: Expected I, but got Obj
		//IL_0706: Expected Obj, but got I
		//IL_0840: Expected Obj, but got I
		//IL_0977: Unknown result type (might be due to invalid IL or missing references)
		//IL_097c: Expected Obj, but got Unknown
		//IL_0984: Expected Obj, but got I
		//IL_0a67: Expected I, but got Obj
		//IL_0a7d: Expected Obj, but got I
		//IL_0aa8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 40;
		obj3 = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 16;
		obj5 = obj;
		_ = -1;
		string eventName = default;
		string eventName2 = default;
		string eventName3 = default;
		bool flag4 = default;
		if (result == WWWRequestResult.Success)
		{
			string text = StringUtility.FormatProperties((Dictionary<string, string>)(object)output);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj6 = default;
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				nint num = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ S1_v26 (Il2CppClass<SocialManager>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S1_v280 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string[] array = default;
				string checksum = GetChecksum(array);
				nint num3 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ S2_v12 (Il2CppClass<Utils>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num4 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S2_v92 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = default;
				string[] array2 = text2.Split((char[])(object)checksum, (StringSplitOptions)3);
				if (array2 == null)
				{
					nint num5 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v557 (Il2CppClass<SocialManager>)+BA]");
					object obj9 = (nint)0 & (nint)0x200;
					if (obj9 != null)
					{
						nint num6 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ S0_v563 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
				}
				else
				{
					bool flag;
					if (array != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ S0_v33 (System.String[])+8]");
						flag = (nint)0 == 0;
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						object obj10 = this + 68;
						obj10 = 0;
					}
					else
					{
						int num7 = StringUtility.ParseHexDigit((char)(int)array);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						object obj11 = num7 + 12;
						List<Friend> list = default;
						list._002Ector((int)obj11);
						object obj12 = this + 68;
						obj12 = list;
						object obj13 = default;
						object obj55 = default;
						nint num12;
						object obj24 = default;
						object obj26 = default;
						object obj32 = default;
						object obj33 = default;
						object obj35 = default;
						object obj37 = default;
						object obj39 = default;
						IntPtr intPtr2 = default;
						object obj42 = default;
						IntPtr intPtr3 = default;
						object obj44 = default;
						object obj45 = default;
						object obj47 = default;
						object obj48 = default;
						int totalLength = default;
						object obj51 = default;
						for (nint num8 = unchecked((nint)null); System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj11); obj13 = obj55 + 1, num8 = num12)
						{
							object obj14 = num7 + 16;
							object obj15 = obj13 << 2;
							object obj16 = obj14 + obj15;
							object obj17 = obj16 + 12;
							if ((nint)obj17 < 6)
							{
								goto IL_0acd;
							}
							object obj18 = obj16 + 20;
							object obj19 = obj18;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v211+8]");
							if ((nint)0 <= (nint)0)
							{
								object obj20 = obj16 + 24;
								object obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ S0_v547+8]");
								if ((nint)0 < (nint)1)
								{
									goto IL_0acd;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj22 = obj16 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj23 = obj16 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if ((nint)obj24 >= 1)
							{
								obj3 = 0;
								if (_fbProfiles != null)
								{
									((Dictionary<string, Friend.Status>)1228).set_Item((string)7, (Friend.Status)(object)typeof(IDictionary<string, FacebookProfile>));
									num8 = (nint)_fbProfiles;
								}
								object obj25 = obj26 + 32;
								obj25 = obj3;
							}
							object obj27 = obj16 + 28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj28 = obj16 + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj29 = obj16 + 36;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if ((nint)obj17 > 6)
							{
								object obj30 = obj16 + 40;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								object obj31 = obj32;
							}
							else
							{
								object obj31 = 0;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
							object obj34;
							object obj36;
							IntPtr intPtr;
							if (obj33 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj34 = obj35;
								obj36 = obj37;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v219+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v219+20]");
									object obj38 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									bool flag2 = obj39 == null;
									num8 = 0;
									if (!flag2)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v219+20]");
										object obj40 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
										intPtr = intPtr2;
										goto IL_096e;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v219+1C]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v219+1C]");
									object obj41 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									bool flag3 = obj42 == null;
									num8 = 0;
									if (!flag3)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ S0_v219+1C]");
										object obj43 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
										intPtr = intPtr3;
										goto IL_096e;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj34 = obj44;
								obj36 = obj37;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							if (obj36 != obj45)
							{
								object obj46 = obj34;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								nint num9 = (nint)obj47;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								if (obj48 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
									string text3 = string.ConcatArray((string[])(object)"Friend parse error ", totalLength);
									nint num10 = (nint)typeof(SocialManager);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ S1_v153 (Il2CppClass<SocialManager>)+BA]");
									object obj49 = (nint)0 & (nint)0x200;
									if (obj49 != null)
									{
										nint num11 = (nint)typeof(SocialManager);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1088 @ S1_v158 (Il2CppClass<SocialManager>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
									num12 = num8;
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
								object obj50 = obj47;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
								object obj46 = obj51;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
							goto IL_11a1;
							IL_0acd:
							int num13 = string.CompareOrdinalIgnoreCaseHelper(";", (string)obj16);
							object obj52 = ((IConvertible)"Malformed friend: (").ToType((Type)num13, (IFormatProvider)(object)")");
							nint num14 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ S1_v124 (Il2CppClass<SocialManager>)+BA]");
							object obj53 = (nint)0 & (nint)0x200;
							if (obj53 != null)
							{
								nint num15 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ S1_v129 (Il2CppClass<SocialManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
							num12 = unchecked((nint)null);
							continue;
							IL_096e:
							object obj54 = obj26 + 40;
							obj54 = (nint)intPtr;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							num12 = 0;
						}
					}
					nint num16 = (nint)typeof(Flurry);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ S0_v44 (Il2CppClass<Flurry>)+BA]");
					object obj56 = (nint)0 & (nint)0x200;
					if (obj56 != null)
					{
						nint num17 = (nint)typeof(Flurry);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ S0_v178 (Il2CppClass<Flurry>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					IEnumerator enumerator = ((FollowingGuard)(object)"Social Friends Consolidated").HitByTrainSequenceCoroutine();
					if (enumerator != null)
					{
						if (_friends != null)
						{
							List<Friend> friends = _friends;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
							obj4 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							string text4 = null;
							string text5 = null;
							object obj57 = default;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								if (obj57 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v165+20]");
								if ((nint)0 != 0)
								{
									string text6 = text5 + 1;
									text5 = text6;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ S0_v165+1C]");
								if ((nint)0 != 0)
								{
									string text7 = text4 + 1;
									text4 = text7;
								}
							}
							object obj58 = obj5 + 4;
							object obj59 = obj58 + 1;
							obj58 = obj59;
							object obj60 = obj59 << 2;
							object obj61 = obj5 + obj60;
							obj61 = 758;
							object obj62 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
							if ((nint)0 != -1)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
								object obj63 = (nint)0 << 2;
								object obj64 = obj5 + obj63;
								if ((nint)obj64 == 758)
								{
									object obj65 = obj5 + 4;
									if ((nint)obj65 > -1)
									{
										object obj66 = obj65 + -1;
										obj65 = obj66;
									}
									eventName = text5;
									eventName2 = text4;
									eventName3 = (string)friends._size;
									goto IL_1457;
								}
							}
							if (obj62 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
							}
							else
							{
								eventName = text5;
								eventName2 = text4;
								eventName3 = (string)friends._size;
							}
						}
						goto IL_1457;
					}
					if (_latestPreConsolidationFacebookIds == null)
					{
						flag4 = true;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						List<string> list2 = default;
						list2._002Ector((IEnumerable<string>)_latestPreConsolidationFacebookIds);
						object obj67 = this + 20;
						obj67 = list2;
						flag4 = true;
					}
				}
			}
		}
		goto IL_11a1;
		IL_11a1:
		if (cookie != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			Action<bool> action = default;
			action(flag4);
		}
		AddLocalUserUpdatedHandler((Action)flag4);
		return;
		IL_1457:
		nint num18 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ S0_v68 (Il2CppClass<Flurry>)+BA]");
		object obj68 = (nint)0 & (nint)0x200;
		if (obj68 != null)
		{
			nint num19 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ S0_v97 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag5 = Flurry.ShouldLogDailyEvent(eventName3);
		bool flag6 = Flurry.ShouldLogDailyEvent(eventName);
		bool flag7 = Flurry.ShouldLogDailyEvent(eventName2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private TimeSpan GetForceReportScoreTimeSpan()
	{
		//IL_0007: Expected VT, but got Obj
		return (TimeSpan)_latestPreConsolidationFacebookIds;
	}

	public void UpdateFriendScores(Action<bool> updateFriendsScoresCompleted)
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected Obj, but got Unknown
		//IL_00bb: Expected Obj, but got I4
		bool flag;
		if (pausePhotoDownloading)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ S0_v6 (System.Boolean)+8]");
			flag = (nint)0 == 0;
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			bool flag2;
			if ("" != null)
			{
				object obj = "";
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v53+8]");
				flag2 = (nint)0 == 0;
			}
			else
			{
				flag2 = true;
			}
			if (flag2)
			{
				updateFriendsScoresCompleted?.Invoke(obj: true);
				AddLocalUserUpdatedHandler((Action)1);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		SocialManagerIOS socialManagerIOS = default;
		((UnityEngine.Object)socialManagerIOS).m_CachedPtr = cachedPtr;
		socialManagerIOS._pausePhotoDownloading = false;
		object obj2 = socialManagerIOS + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	private void WWWUpdateFriendScoresCompleted(WWWRequestResult result, string output, object cookie)
	{
		if (result == WWWRequestResult.Success)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @92AE");
		}
	}

	public string GetNameForRelation(Friend friend)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected Obj, but got Unknown
		//IL_01cd: Expected Obj, but got I4
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Expected Obj, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected Obj, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected Obj, but got Unknown
		//IL_0256: Expected Obj, but got I4
		//IL_0114: Expected Obj, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected Obj, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 48;
		object obj3 = obj2 + 24;
		obj3 = 0;
		_ = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		if (_friends != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			string text = null;
			object obj5 = default;
			object obj6 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				string text2 = obj6 + text;
				text = text2;
			}
			object obj7 = obj4 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj4 + obj9;
			obj10 = 70;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj4 + obj11;
				if ((nint)obj12 == 70)
				{
					object obj13 = obj4 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					return text;
				}
			}
			object obj15 = default;
			if (obj15 == null)
			{
				return text;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		string result = default;
		return result;
	}

	public unsafe void Poke(Friend friend)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_045b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected Obj, but got Unknown
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Expected VT, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Obj, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected Obj, but got Unknown
		//IL_04a1: Expected Obj, but got I4
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected Obj, but got Unknown
		//IL_04b8: Expected Obj, but got I4
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Expected Obj, but got Unknown
		//IL_0056: Expected I, but got Obj
		//IL_006c: Expected Obj, but got I
		//IL_0501: Expected Obj, but got VT
		//IL_050b: Expected Obj, but got VT
		//IL_0518: Expected I8, but got Obj
		//IL_0513: Expected native int or pointer, but got VT
		//IL_052d: Expected Ref, but got VT
		//IL_0539: Expected Obj, but got I8
		//IL_055b: Expected I, but got Obj
		//IL_0571: Expected Obj, but got I
		//IL_05b6: Invalid comparison between F8 and I4
		//IL_0097: Expected I, but got Obj
		//IL_00e4: Expected I, but got Obj
		//IL_012b: Expected Obj, but got VT
		//IL_013d: Expected VT, but got Obj
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected Obj, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected Obj, but got Unknown
		//IL_0254: Expected Obj, but got I4
		//IL_01bd: Expected Obj, but got I4
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_0687: Expected Obj, but got Unknown
		//IL_02dc: Expected Obj, but got I
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected Obj, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		IFormatProvider formatProvider = (IFormatProvider)(obj2 + 40);
		DateTime dateTime = (DateTime)(obj2 + 32);
		object obj3 = obj2 + 16;
		object obj4 = obj2 + 8;
		object obj5 = obj2 + 24;
		obj5 = 0;
		object obj6 = obj2 - -64;
		obj6 = 0;
		_ = 0;
		object obj7 = obj2 + 56;
		obj7 = obj;
		_ = -1;
		if (_friends == null)
		{
			return;
		}
		List<Friend> friends = _friends;
		if (friends._size == 0)
		{
			return;
		}
		DateTime utcNow = CDateTime.UtcNow;
		nint num = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ S0_v41 (Il2CppClass<System.DateTime>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num2 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ S0_v148 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = utcNow;
		obj4 = _lastFriendScoreUpdateTimestamp;
		((DateTime*)(nint)dateTime)->dateData = (ulong)(long)obj3;
		formatProvider = (IFormatProvider)obj4;
		long num3 = ((DateTime*)dateTime)->System_002EIConvertible_002EToInt64(formatProvider);
		obj5 = num3;
		double num4 = (double)obj5 * 1E-07;
		nint num5 = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ S1_v28 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num6 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ S1_v109 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		uint value = ((OnlineSettings)(object)saveDataPath).GetValue("social_friendscores_min_seconds", 120u);
		if (num4 < (double)(int)value)
		{
			return;
		}
		obj2 = utcNow;
		formatProvider = (IFormatProvider)obj2;
		_lastFriendScoreUpdateTimestamp = (DateTime)formatProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder stringBuilder = default;
		System.Text.StringBuilderCache.Release(stringBuilder);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
		obj6 = formatProvider;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S0_v9 (System.IFormatProvider)+8]");
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
			object obj11 = stringBuilder.m_ChunkLength + stringBuilder.m_ChunkOffset;
			if ((nint)obj11 >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		}
		object obj12 = obj7 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj7 + obj14;
		obj15 = 163;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S0_v25+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj7 + obj16;
			if ((nint)obj17 == 163)
			{
				object obj18 = obj7 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				goto IL_0647;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0647;
		IL_0647:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		SocialManagerIOS socialManagerIOS = default;
		((UnityEngine.Object)socialManagerIOS).m_CachedPtr = cachedPtr;
		socialManagerIOS._pausePhotoDownloading = false;
		object obj21 = socialManagerIOS + 16;
		obj21 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public void SetPokeFirstTime(Friend friend)
	{
		//IL_01e5: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_01e5: Expected Obj, but got I4
		//IL_0295: Expected Obj, but got VT
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected Obj, but got Unknown
		//IL_02b8: Expected VT, but got Obj
		//IL_02c6: Expected I, but got Obj
		//IL_02dc: Expected Obj, but got I
		//IL_009d: Expected I, but got Obj
		StayInOneLaneMission stayInOneLaneMission = StayInOneLaneMission.instance;
		((OwnBoardsAward)(object)stayInOneLaneMission)._002Ector((AwardStaticData)48, (PersistentAwardProgress)1, (Action<Award>)(-1));
		if (friend.fbProfile != null)
		{
			if (_fbProfile != null)
			{
				FacebookProfile fbProfile = _fbProfile;
				string fullName = fbProfile.fullName;
			}
			else
			{
				string fullName = null;
			}
		}
		else if (_gcProfile != null)
		{
			GameCenterProfile gcProfile = _gcProfile;
			string fullName = gcProfile.alias;
		}
		else
		{
			string fullName = null;
		}
		Friend.Status status = friend.status;
		DateTime today = CDateTime.Today;
		object obj = today;
		object obj2 = obj + 8;
		obj2 = obj;
		status.lastPokeTime = (DateTime)obj2;
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v16 (Il2CppClass<Flurry>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S0_v46 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public void BragNotify(int oldScore, List<Friend> friends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0016: Expected Obj, but got I4
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected Obj, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected Obj, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected Obj, but got Unknown
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Expected Obj, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected Obj, but got Unknown
		//IL_03f5: Expected Obj, but got I4
		//IL_0032: Expected Obj, but got I4
		//IL_0049: Expected Obj, but got I4
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected Obj, but got Unknown
		//IL_0082: Expected Obj, but got VT
		//IL_00ce: Expected I, but got Obj
		//IL_00e4: Expected Obj, but got I
		//IL_010f: Expected I, but got Obj
		//IL_019a: Expected I, but got Obj
		//IL_01b0: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got VT
		//IL_04c7: Expected Obj, but got I8
		//IL_04e9: Expected Obj, but got VT
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected Obj, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected Obj, but got Unknown
		//IL_01db: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 60;
		obj = oldScore;
		Action action = (Action)(obj2 + 48);
		object obj3 = obj2 + 40;
		object obj4 = obj2 + 32;
		object obj5 = obj2 + 24;
		object obj6 = obj2 + 16;
		object obj7 = obj2 + 8;
		object obj8 = obj2 + 56;
		obj8 = 0;
		if (_userid <= 0)
		{
			return;
		}
		int highScore = PlayerSave.highScore;
		object obj9 = highScore + 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @92AE");
		obj8 = highScore;
		if (highScore == 1)
		{
			DateTime today = CDateTime.Today;
			obj4 = today;
			action = (Action)obj4;
			PlayerSave.highScoreChanged += action;
		}
		if (friends == null)
		{
			nint num = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S1_v60 (Il2CppClass<Info.OnlineSettings>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num2 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ S1_v87 (Il2CppClass<Info.OnlineSettings>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			string saveDataPath = OnlineSettings.GetSaveDataPath();
			uint value = ((OnlineSettings)(object)saveDataPath).GetValue("social_report_games_count", 5u);
			if ((nint)obj8 < (int)value)
			{
				if ((nint)obj8 < 2)
				{
					return;
				}
				DateTime today2 = CDateTime.Today;
				DateTime weeklyGiftUnlockTime = PlayerSave.weeklyGiftUnlockTime;
				long eventEndTime = ((EventTesterManager)null).GetEventEndTime();
				nint num3 = (nint)typeof(DateTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ S0_v89 (Il2CppClass<System.DateTime>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num4 = (nint)typeof(DateTime);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ S0_v107 (Il2CppClass<System.DateTime>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				obj5 = weeklyGiftUnlockTime;
				obj6 = eventEndTime;
				obj3 = obj5;
				action = (Action)obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @DCFF");
				obj7 = today2;
				object obj12 = default;
				obj2 = obj12;
				obj3 = obj7;
				action = (Action)obj2;
				object obj13 = obj3 & 0x3FFFFFFFFFFFFFFFL;
				object obj14 = action & 0x3FFFFFFFFFFFFFFFL;
				if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj13) <= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj14))
				{
					return;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint cachedPtr = 0;
		SocialManagerIOS socialManagerIOS = default;
		((UnityEngine.Object)socialManagerIOS).m_CachedPtr = cachedPtr;
		socialManagerIOS._pausePhotoDownloading = false;
		object obj15 = socialManagerIOS + 16;
		obj15 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public void AnnounceToFriends(int relationsMask)
	{
		//IL_0010: Expected Obj, but got I
		//IL_0021: Expected Obj, but got VT
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [relationsMask @ L1 (System.Int32)+28]");
		object obj = 0;
		DateTime today = CDateTime.Today;
		object obj2 = today;
		object obj3 = obj2 + 8;
		obj3 = obj2;
	}

	private static string GetDeviceTypeString()
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0069: Expected Obj, but got I4
		//IL_007d: Expected I, but got Obj
		//IL_0093: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		IndexOutOfRangeException ex = default;
		object obj = ex + 16;
		obj = 0;
		_ = 0;
		nint num = (nint)typeof(Guid);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v12 (Il2CppClass<System.Guid>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(Guid);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v21 (Il2CppClass<System.Guid>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ex._002Ector();
		obj = ex;
		_ = ((Exception)ex)._className;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @EF7B");
		string result = default;
		return result;
	}

	public void UpdateRemoteNotificationControl(bool newValue)
	{
		//IL_00ee: Expected I, but got Obj
		//IL_0104: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(SocialManagerIOS);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManagerIOS>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v25 (Il2CppClass<SocialManagerIOS>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (TopRunRewardHelper.ShouldShowResults())
		{
			nint num3 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v15 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v21 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstanced = SocialManagerIOS.isInstanced;
		}
		_pausePhotoDownloading = newValue;
	}

	public bool AreFacebookFriendsConsolidated()
	{
		return _pausePhotoDownloading;
	}

	public static void LogError(string msg, UnityEngine.Object context = null)
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected I4, but got Unknown
		//IL_0033: Expected Obj, but got I
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected Obj, but got Unknown
		//IL_0057: Expected I, but got Obj
		//IL_006d: Expected Obj, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected Obj, but got Unknown
		//IL_018b: Expected I4, but got Obj
		//IL_0098: Expected I, but got Obj
		int localNotificationsEnabled = PreferencesSave.localNotificationsEnabled;
		int num = localNotificationsEnabled ^ 1;
		if ((num | context) != 0)
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint cachedPtr = 0;
			SocialManager socialManager = default;
			((UnityEngine.Object)socialManager).m_CachedPtr = cachedPtr;
			socialManager._latestSuccesfullyConsolidatedFacebookIds = (List<string>)0;
			object obj = socialManager + 16;
			obj = msg;
			nint num2 = (nint)typeof(RemoteNotificationControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v30 (Il2CppClass<RemoteNotificationControl>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(RemoteNotificationControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ S0_v35 (Il2CppClass<RemoteNotificationControl>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			socialManager.isRunningFacebookLogin = (byte)(int)"cpush.wav" != 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+81]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num4 = 0;
				_ = 0;
				Action<bool> action = default;
				object obj3 = action + 16;
				obj3 = msg;
				((SocialManager)(object)msg).RegisterUser(action);
			}
		}
	}

	public static void LogWarning(string msg, UnityEngine.Object context = null)
	{
		SDebug.LogFormat(msg, (object[])(object)context);
	}

	public static void Log(string msg, UnityEngine.Object context = null)
	{
	}

	public unsafe SocialManager()
	{
		//IL_0172: Expected I, but got Obj
		//IL_0188: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected Obj, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected Obj, but got Unknown
		//IL_00e3: Expected I, but got Obj
		//IL_00f9: Expected Obj, but got I
		//IL_0124: Expected I, but got Obj
		nint num = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v40 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		ref GameCenterPlugin.LocalPlayer player = default;
		GameCenterPlugin.GetLocalPlayer(ref player);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (LocalPlayer&)+D]");
		if ((nint)0 == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj3 = default;
		object obj2 = obj3 + 12;
		obj2 = this;
		int initAchievementsContext = _initAchievementsContext + 1;
		_initAchievementsContext = initAchievementsContext;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		GameCenterPlugin.LoadAchievementDescriptionsCompletionHandler loadAchievementDescriptionsCompletionHandler = default;
		((Delegate)loadAchievementDescriptionsCompletionHandler).method_ptr = method_ptr;
		((Delegate)loadAchievementDescriptionsCompletionHandler).method = (nint)__ldftn(_003C_003Ec__DisplayClass162_0._003CInitAchievements_003Eb__0);
		object obj4 = loadAchievementDescriptionsCompletionHandler + 16;
		obj4 = obj3;
		nint num3 = (nint)typeof(GameCenterPlugin);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S0_v31 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(GameCenterPlugin);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S0_v36 (Il2CppClass<Kiloo.GameCenter.GameCenterPlugin>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		GameCenterPlugin.LoadAchievementDescriptions(loadAchievementDescriptionsCompletionHandler);
	}

	unsafe static SocialManager()
	{
		//IL_0458: Expected I, but got Obj
		//IL_046e: Expected Obj, but got I
		//IL_0677: Expected I, but got Obj
		//IL_068d: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_00ee: Expected I, but got Obj
		//IL_0145: Expected I4, but got Obj
		//IL_0158: Expected I, but got Obj
		//IL_016e: Expected Obj, but got I
		//IL_01eb: Expected VT, but got I4
		//IL_01eb: Expected Obj, but got I4
		//IL_0199: Expected I, but got Obj
		//IL_0206: Expected Obj, but got I4
		//IL_0214: Expected I, but got Obj
		//IL_022a: Expected Obj, but got I
		//IL_06b8: Expected I, but got Obj
		//IL_06ce: Expected Obj, but got I
		//IL_0255: Expected I, but got Obj
		//IL_059c: Expected I, but got Obj
		//IL_05b2: Expected Obj, but got I
		//IL_02a2: Expected I, but got Obj
		//IL_02b8: Expected Obj, but got I
		//IL_0330: Expected I, but got Obj
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected Obj, but got Unknown
		//IL_055a: Expected I, but got Obj
		//IL_0570: Expected Obj, but got I
		//IL_037d: Expected I, but got Obj
		//IL_02e3: Expected I, but got Obj
		//IL_03ca: Expected I, but got Obj
		//IL_03e0: Expected Obj, but got I
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected Obj, but got Unknown
		//IL_063e: Expected I, but got Obj
		//IL_0654: Expected Obj, but got I
		//IL_040b: Expected I, but got Obj
		nint num = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SocialManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v143 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S1_v4 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ S1_v46 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (!(_instance != null))
		{
			return;
		}
		nint num5 = (nint)typeof(SocialManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v16 (Il2CppClass<SocialManager>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(SocialManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v137 (Il2CppClass<SocialManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(_applicationIsQuiting ? 1u : 0u) == 0)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		GameObject gameObject = default;
		gameObject.layer = (int)"SocialManager";
		nint num7 = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ S0_v28 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num8 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ S0_v133 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((UnityEngine.UnitySynchronizationContext)(object)gameObject).Exec();
		SocialManager socialManager = gameObject.AddComponent<SocialManager>();
		int layer = gameObject.layer;
		HierarchyUtility.ReparentByHierarchyPathType((Transform)layer, HierarchyPathType.Dynamic, (Vector3)0);
		int layer2 = gameObject.layer;
		((HierarchyUtility)layer2)._002Ector();
		nint num9 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ S0_v40 (Il2CppClass<SocialManager+<>c>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v127 (Il2CppClass<SocialManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _003C_003Ec._003C_003E9__89_0 == null;
		bool flag2 = !flag;
		Action value = _003C_003Ec._003C_003E9__89_0;
		if (!flag2)
		{
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ S0_v104 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj6 = (nint)0 & (nint)0x200;
			if (obj6 != null)
			{
				nint num12 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ S0_v121 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr;
			((Delegate)action).method = (nint)__ldftn(_003C_003Ec._003CInit_003Eb__89_0);
			object obj7 = action + 16;
			obj7 = _003C_003Ec._003C_003E9;
			nint num13 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v118 (Il2CppClass<SocialManager+<>c>)+5C]");
			object obj8 = (nint)0 + (nint)12;
			obj8 = action;
			value = action;
		}
		nint num14 = (nint)typeof(AgeRestriction);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ S0_v50 (Il2CppClass<Info.AgeRestriction>)+BA]");
		object obj9 = (nint)0 & (nint)0x200;
		if (obj9 != null)
		{
			nint num15 = (nint)typeof(AgeRestriction);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ S0_v99 (Il2CppClass<Info.AgeRestriction>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AgeRestriction.restrictionChanged -= value;
		nint num16 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ S0_v56 (Il2CppClass<SocialManager+<>c>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num17 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ S0_v93 (Il2CppClass<SocialManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag3 = _003C_003Ec._003C_003E9__89_1 == null;
		bool flag4 = !flag3;
		Action<RefreshType> value2 = _003C_003Ec._003C_003E9__89_1;
		if (!flag4)
		{
			nint num18 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v67 (Il2CppClass<SocialManager+<>c>)+BA]");
			object obj11 = (nint)0 & (nint)0x200;
			if (obj11 != null)
			{
				nint num19 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v87 (Il2CppClass<SocialManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num20 = 0;
			_ = 0;
			Action<RefreshType> action2 = default;
			object obj12 = action2 + 16;
			obj12 = _003C_003Ec._003C_003E9;
			nint num21 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ S0_v84 (Il2CppClass<SocialManager+<>c>)+5C]");
			object obj13 = (nint)0 + (nint)16;
			obj13 = action2;
			value2 = action2;
		}
		AppRefreshHandler.hasRefreshed -= value2;
	}

	private void _003COnGameCenterAuthentication_003Eb__98_0(string playerID, Texture2D photo, string photoError)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0073: Expected I, but got Obj
		//IL_0089: Expected Obj, but got I
		//IL_0aec: Expected I, but got Obj
		//IL_0b02: Expected Obj, but got I
		//IL_00b4: Expected I, but got Obj
		//IL_0101: Expected I, but got Obj
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected Obj, but got Unknown
		//IL_0213: Expected Obj, but got I4
		//IL_014e: Expected I, but got Obj
		//IL_0164: Expected Obj, but got I
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected Obj, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected Obj, but got Unknown
		//IL_018f: Expected I, but got Obj
		//IL_0285: Expected Obj, but got I4
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected Obj, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected Obj, but got Unknown
		//IL_0323: Expected Obj, but got I4
		//IL_047c: Expected I, but got Obj
		//IL_0492: Expected Obj, but got I
		//IL_0b9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba1: Expected Obj, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected Obj, but got Unknown
		//IL_04bd: Expected I, but got Obj
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected Obj, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected Obj, but got Unknown
		//IL_0469: Expected Obj, but got I4
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		if (playerID == null)
		{
			string text = StringUtility.FormatProperties((Dictionary<string, string>)(object)photo);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			object obj3 = default;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
				nint num = (nint)typeof(SocialManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S1_v19 (Il2CppClass<SocialManager>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num2 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S1_v124 (Il2CppClass<SocialManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string[] data = default;
				string checksum = GetChecksum(data);
				nint num3 = (nint)typeof(Utils);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ S2_v11 (Il2CppClass<Utils>)+BA]");
				object obj5 = (nint)0 & (nint)0x200;
				if (obj5 != null)
				{
					nint num4 = (nint)typeof(Utils);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ S2_v44 (Il2CppClass<Utils>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string text2 = default;
				string[] array = text2.Split((char[])(object)checksum, (StringSplitOptions)3);
				if (array == null)
				{
					nint num5 = (nint)typeof(SocialManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v312 (Il2CppClass<SocialManager>)+BA]");
					object obj6 = (nint)0 & (nint)0x200;
					if (obj6 != null)
					{
						nint num6 = (nint)typeof(SocialManager);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ S0_v318 (Il2CppClass<SocialManager>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7422");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj8 = default;
					object obj7 = obj8 + 12;
					object obj9 = 0;
					object obj16 = default;
					object obj17 = default;
					object obj18 = default;
					object obj19 = default;
					object obj20 = default;
					object obj21 = default;
					object obj22 = default;
					object obj23 = default;
					object obj24 = default;
					object obj25 = default;
					object obj26 = default;
					object obj27 = default;
					object obj28 = default;
					object obj29 = default;
					object obj31 = default;
					object obj33 = default;
					object obj35 = default;
					IntPtr method = default;
					object obj36 = default;
					object obj42 = default;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj9) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
					{
						object obj10 = obj8 + 16;
						object obj11 = obj9 << 2;
						object obj12 = obj10 + obj11;
						object obj13 = obj12 + 12;
						if ((nint)obj13 < 4)
						{
							object obj14 = 41;
							object obj15 = obj14 - 23;
							if ((nint)obj14 != 23)
							{
								if ((nint)obj15 != 1)
								{
									if ((nint)obj15 != 2)
									{
										if ((nint)obj15 != 3)
										{
											if ((nint)obj15 != 4 && (nint)obj15 != 5 && (nint)obj15 != 6 && (nint)obj15 != 7)
											{
												if ((nint)obj15 != 8)
												{
													if ((nint)obj15 != 9)
													{
														if ((nint)obj15 != 10)
														{
															if ((nint)obj15 != 11 && (nint)obj15 != 12)
															{
																if ((nint)obj15 != 13)
																{
																	if ((nint)obj15 != 14)
																	{
																		if ((nint)obj15 != 15 && (nint)obj15 != 16 && (nint)obj15 != 17 && (nint)obj15 == 18)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																			obj16 = obj17;
																			obj18 = obj19;
																		}
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																		obj16 = obj17;
																		obj18 = obj20;
																	}
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
																	obj16 = obj17;
																	obj18 = obj21;
																}
															}
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															obj16 = obj17;
															obj18 = obj22;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														obj16 = obj17;
														obj18 = obj23;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													obj16 = obj17;
													obj18 = obj24;
												}
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											obj16 = obj17;
											obj18 = obj25;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										obj16 = obj17;
										obj18 = obj26;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									obj16 = obj17;
									obj18 = obj27;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								obj16 = obj17;
								obj18 = obj28;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							if (obj16 == obj29)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								object obj30 = obj31;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
								object obj32 = obj33;
							}
							else
							{
								object obj32 = obj18;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj34 = obj12 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
						((Predicate<Friend>)5448)._002Ector(obj35, method);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj36 != null)
						{
							object obj37 = obj12 + 20;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj38 = obj12 + 24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							object obj39 = obj12 + 28;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							if ((nint)obj13 > 4)
							{
								object obj40 = obj12 + 32;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								object obj41 = obj42;
							}
							else
							{
								object obj41 = 0;
							}
						}
						else
						{
							nint num7 = (nint)typeof(SocialManager);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ S0_v244 (Il2CppClass<SocialManager>)+BA]");
							object obj43 = (nint)0 & (nint)0x200;
							if (obj43 != null)
							{
								nint num8 = (nint)typeof(SocialManager);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ S0_v248 (Il2CppClass<SocialManager>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
								}
							}
						}
						object obj44 = obj9 + 1;
						obj9 = obj44;
					}
				}
			}
		}
		if (photoError != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			Action<bool> action = default;
			action(obj: true);
		}
	}

	private void _003CInvalidate_003Eb__143_1(bool success)
	{
	}

	private void _003CUpdateRemoteNotificationControl_003Eb__203_0(bool success)
	{
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0167: Expected I, but got Obj
		//IL_017d: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		//IL_00c0: Expected I, but got Obj
		if (success)
		{
			nint num = (nint)typeof(FacebookSession);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v10 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(FacebookSession);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v32 (Il2CppClass<Kiloo.Plugins.Facebook.FacebookSession>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (FacebookSession._IsSupported())
			{
				int num3 = _consolidationState | 1;
				_consolidationState = num3;
			}
			nint num4 = (nint)typeof(SocialManagerIOS);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v18 (Il2CppClass<SocialManagerIOS>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num5 = (nint)typeof(SocialManagerIOS);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v27 (Il2CppClass<SocialManagerIOS>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstanced = SocialManagerIOS.isInstanced;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v23 (System.Boolean)+C]");
			if ((nint)0 == 3)
			{
				int num6 = _consolidationState | 2;
				_consolidationState = num6;
			}
		}
		_consolidatedFriendsCompleted = true;
		float maxDelay = NetworkServer.maxDelay;
		_lastConsolidateFriendCompleteTime = maxDelay;
	}
}
