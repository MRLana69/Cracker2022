using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Kiloo.Common.Backend.Authentication;
using Kiloo.Common.Backend.Cloud;
using Kiloo.Common.HTTP;
using Kiloo.Common.Plugins.DeviceUtility;
using UnityEngine;

namespace Kiloo.Common.Ads;

public abstract class AbstractAdProvider : AdEventListenerAdapter
{
	private enum InitState
	{
		Uninitialized,
		Initializing,
		Initialized,
		Unsupported
	}

	[StructLayout((LayoutKind)0, Size = 12)]
	public struct AdAttempt
	{
		public string adLocationID;

		public string cacheID;

		public AdType adType;

		public unsafe AdAttempt(string adLocationID, string cacheID, AdType adType)
		{
			//IL_0005: Expected Obj, but got Ref
			//IL_0015: Expected Obj, but got I
			//IL_007e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00b6: Expected Obj, but got I
			//IL_0132: Expected Obj, but got I
			//IL_014f: Expected Obj, but got I4
			//IL_062a: Expected Obj, but got I
			//IL_0633: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Expected I4, but got Unknown
			//IL_01d7: Expected Obj, but got I
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected I4, but got Unknown
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0682: Expected Obj, but got Unknown
			//IL_05c5: Expected Obj, but got I
			//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Expected I4, but got Unknown
			//IL_019b: Expected Obj, but got I
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Expected I4, but got Unknown
			//IL_0408: Expected Obj, but got I
			//IL_0297: Expected Obj, but got I
			//IL_04d4: Expected Obj, but got I
			//IL_02f7: Expected Obj, but got I
			//IL_0498: Expected Obj, but got I
			//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6: Expected I4, but got Unknown
			//IL_058d: Expected I4, but got Obj
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref this);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AbstractAdProvider+AdAttempt)+34]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AbstractAdProvider+AdAttempt)+34]");
			object obj4;
			object obj5;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AbstractAdProvider+AdAttempt)+34]");
				object obj3 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj4 = 0;
				obj5 = obj3;
			}
			else
			{
				obj5 = obj;
				obj4 = 1;
			}
			object obj6 = default;
			object obj26 = default;
			object obj18 = default;
			object obj24 = default;
			for (; obj6 != obj4; obj6 = obj26 + 1)
			{
				object obj7 = obj6 << 2;
				object obj8 = obj5 + obj7;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+14]");
				AdType adType2 = AdType.Interstitial;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (Kiloo.Common.Ads.AdType)+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (Kiloo.Common.Ads.AdType)+2A]");
				bool flag = (nint)0 == 3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (Kiloo.Common.Ads.AdType)+24]");
				object obj11 = (nint)0 & (nint)0x10;
				bool flag2 = obj11 == null;
				object obj12 = (flag2 ? 1 : 0) ^ 1;
				AdType adType4;
				AdType adType3;
				if (obj12 != null)
				{
					if (flag)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
						object obj13 = (nint)0 & (nint)0x1FFF;
						adType3 = (AdType)(obj13 + 113696);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (Kiloo.Common.Ads.AdType) (should have been resolved before IL gen)");
						adType4 = (AdType)113696;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
						object obj14 = (nint)0 & (nint)0x7FF;
						adType4 = (AdType)(obj14 + 121922);
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (Kiloo.Common.Ads.AdType) (should have been resolved before IL gen)");
						adType3 = adType2;
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (Kiloo.Common.Ads.AdType)+28]");
				bool flag3 = (nint)0 != -1;
				if (!flag)
				{
					if (flag3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
						bool flag4;
						if ((nint)0 != 0)
						{
							object obj15 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v94+9C]");
							object obj16 = (nint)0 & (nint)0x100;
							flag4 = obj16 != null;
						}
						else
						{
							flag4 = false;
						}
						if (!flag4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AbstractAdProvider+AdAttempt)+C]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (Kiloo.Common.Ads.AdType)+2B]");
								object obj17 = (nint)0 & (nint)3;
								bool flag5 = (nint)obj17 == 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
								if (flag5)
								{
									if (obj18 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A77");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A78");
									}
								}
								else if (obj18 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7574");
									adType3 = adType;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
								}
								continue;
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
					object obj19 = (nint)0 & (nint)0x1FFF;
					adType3 = (AdType)(obj19 + 113696);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (Kiloo.Common.Ads.AdType) (should have been resolved before IL gen)");
					adType4 = (AdType)113696;
					continue;
				}
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
					bool flag6;
					if ((nint)0 != 0)
					{
						object obj20 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ S0_v66+9C]");
						object obj21 = (nint)0 & (nint)0x100;
						flag6 = obj21 != null;
					}
					else
					{
						flag6 = false;
					}
					if (!flag6)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AbstractAdProvider+AdAttempt)+C]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+10]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
								object obj22 = (nint)0 & (nint)0x1FFF;
								adType3 = (AdType)(obj22 + 113696);
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v197 @ S4_v16 (Kiloo.Common.Ads.AdType) (should have been resolved before IL gen)");
								adType4 = (AdType)113696;
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S0_v19 (Kiloo.Common.Ads.AdType)+2B]");
							object obj23 = (nint)0 & (nint)3;
							bool flag7 = (nint)obj23 == 2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
							if (flag7)
							{
								if (obj24 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8961");
									adType3 = adType;
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8962");
									adType3 = adType;
								}
							}
							else if (obj24 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77FE");
								adType4 = adType;
								adType3 = (AdType)cacheID;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7D0D");
								adType3 = adType;
							}
							continue;
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v14+8]");
				object obj25 = (nint)0 & (nint)0x7FF;
				adType4 = (AdType)(obj25 + 121922);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v195 @ S5_v6 (Kiloo.Common.Ads.AdType) (should have been resolved before IL gen)");
				adType3 = adType2;
			}
		}
	}

	protected class EventListenerInvoker : IAdEventListener
	{
		private readonly List<IAdEventListener> _listeners;

		public void AddToStartOfList(IAdEventListener listener)
		{
			_listeners = (List<IAdEventListener>)listener;
		}

		public void AddListener(IAdEventListener listener)
		{
			_listeners.Insert(0, listener);
		}

		public void RemoveListener(IAdEventListener listener)
		{
			_listeners.Add(listener);
		}

		public void Clear()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		public void WillShowAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected Obj, but got Unknown
			object obj = this + 8;
			obj = adType;
			object obj2 = obj + 4;
			obj2 = providerID;
		}

		public void ShowedAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached)
		{
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected Obj, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected Obj, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Expected Obj, but got Unknown
			//IL_0092: Expected Obj, but got I4
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S2_v2 (Il2CppMethodInfo)+C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v3+60]");
			object obj2 = 0;
			object obj3 = obj2;
			object obj4 = obj3 & 0x3FFF;
			object obj5 = obj4 + 97173;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v26 @ S3_v4 (should have been resolved before IL gen)");
			object obj6 = this + 20;
			obj6 = providerID;
			object obj7 = this + 24;
			obj7 = adLocationID;
			object obj8 = this + 16;
			obj8 = wasAlreadyCached;
		}

		public void DismissedAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void StartedCachingAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void FinishedWatchingVideo(string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			object obj = adLocationID & 1;
		}

		public void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void FailedToShowAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void FailedToInitAdProvider(string providerID)
		{
			bool flag = _listeners.Remove((IAdEventListener)(object)providerID);
		}

		public void CachingTimedOut(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void ClickedAd(AdType adType, string providerID, string adLocationID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		private List<IAdEventListener> CloneListeners()
		{
			//IL_000d: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Ads.AbstractAdProvider+EventListenerInvoker)+C]");
			return (List<IAdEventListener>)0;
		}

		public void ReachedDailyInterstitialLimit(int limit)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 52;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 52)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void ReachedHourlyInterstitialLimit(int limit)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("This event should not be invoked by the ad provider!");
			((EventListenerInvoker)(object)ex).ReachedDailyInterstitialLimit(0);
		}

		public void ReachedNewUserInterstitialLimit(int limit)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("This event should not be invoked by the ad provider!");
			((EventListenerInvoker)(object)ex).ReachedHourlyInterstitialLimit(0);
		}

		public void ReachedTimeBetweenAdsInterstitialLimit(int limit)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("This event should not be invoked by the ad provider!");
			((EventListenerInvoker)(object)ex).ReachedNewUserInterstitialLimit(0);
		}

		public void ChangedProvider(AdType adType, string newProvider, string changedWaterfallID)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Expected Obj, but got Unknown
			//IL_01e4: Expected Obj, but got I4
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Expected Obj, but got Unknown
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected Obj, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Expected Obj, but got Unknown
			//IL_009b: Expected Obj, but got I4
			//IL_0123: Expected Obj, but got I
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Expected Obj, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 48;
			object obj3 = obj2 + 24;
			obj3 = 0;
			_ = 0;
			object obj4 = obj2 + 16;
			obj4 = obj;
			_ = -1;
			bool flag = ((_003CGetAbstractAdProviderSubTypes_003Ed__44)this).MoveNext();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = default;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj5 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D");
			}
			object obj6 = obj4 + 4;
			object obj7 = obj6 + 1;
			obj6 = obj7;
			object obj8 = obj7 << 2;
			object obj9 = obj4 + obj8;
			obj9 = 54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ S0_v15+4]");
				object obj10 = (nint)0 << 2;
				object obj11 = obj4 + obj10;
				if ((nint)obj11 == 54)
				{
					object obj12 = obj4 + 4;
					if ((nint)obj12 > -1)
					{
						object obj13 = obj12 + -1;
						obj12 = obj13;
					}
					return;
				}
			}
			object obj14 = default;
			if (obj14 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}

		public void PriorityListWrapped(string waterfallID)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("This event should not be invoked by the ad provider!");
			((EventListenerInvoker)(object)ex).ReachedTimeBetweenAdsInterstitialLimit(0);
		}

		public EventListenerInvoker()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB86");
		}
	}

	private sealed class _003CGetAbstractAdProviderSubTypes_003Ed__44 : IEnumerable<Type>, IEnumerable, IEnumerator<Type>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private Type _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private Assembly[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private IEnumerator<Type> _003C_003E7__wrap3;

		Type IEnumerator<Type>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_06a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ac: Expected Obj, but got Unknown
				//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_06ba: Expected I, but got Unknown
				//IL_06c2: Expected I, but got Obj
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00be: Expected Obj, but got Unknown
				//IL_00c6: Expected Obj, but got I
				//IL_00dc: Expected Obj, but got I4
				//IL_06fb: Expected Obj, but got I4
				//IL_00ea: Expected Obj, but got I4
				//IL_076d: Expected Obj, but got I4
				//IL_039a: Unknown result type (might be due to invalid IL or missing references)
				//IL_039f: Expected Obj, but got Unknown
				//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_03bc: Expected Obj, but got Unknown
				//IL_07c7: Expected Obj, but got I4
				//IL_036e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0373: Expected Obj, but got Unknown
				//IL_037c: Expected Obj, but got I4
				//IL_038a: Expected Obj, but got I4
				//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d5: Expected Obj, but got Unknown
				//IL_02de: Expected Obj, but got I4
				//IL_0301: Expected Obj, but got I4
				//IL_0138: Expected I, but got Obj
				//IL_014e: Expected Obj, but got I
				//IL_0179: Expected I, but got Obj
				//IL_065b: Expected Obj, but got I4
				//IL_025e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0263: Expected Obj, but got Unknown
				//IL_026b: Expected Obj, but got I
				//IL_027f: Expected Obj, but got I4
				//IL_0288: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 32;
				object obj3 = obj2 + 16;
				nint num = (nint)(obj2 + 8);
				num = (nint)obj;
				_ = -1;
				object obj4;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						obj4 = 52;
					}
					else
					{
						_003C_003E1__state = -3;
						obj4 = 41;
					}
				}
				else
				{
					_003C_003E1__state = -1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					object obj5 = this + 20;
					IntPtr intPtr = default;
					obj5 = (nint)intPtr;
					_003C_003E7__wrap2 = 0;
					obj4 = 47;
				}
				object obj6 = obj4;
				object obj7 = default;
				IntPtr intPtr2 = default;
				IntPtr intPtr3 = default;
				Type result = default;
				object obj14 = default;
				object obj15 = default;
				object obj17 = default;
				object obj18 = default;
				object obj19 = default;
				object obj20 = default;
				while (true)
				{
					if ((nint)obj6 == 41)
					{
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							if (obj7 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								nint num2 = (nint)typeof(Type);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ S0_v200 (Il2CppClass<System.Type>)+BA]");
								object obj8 = (nint)0 & (nint)0x200;
								if (obj8 != null)
								{
									nint num3 = (nint)typeof(Type);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ S0_v222 (Il2CppClass<System.Type>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									}
								}
								obj2 = typeof(DebugAdProvider);
								obj3 = obj2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								if (intPtr2 != intPtr3)
								{
									object obj9 = this + 12;
									obj9 = (nint)intPtr2;
									_003C_003E1__state = 1;
									result = (Type)1;
									obj6 = 52;
									break;
								}
								continue;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
							object obj10 = this + 28;
							obj10 = 0;
							int num4 = _003C_003E7__wrap2 + 1;
							_003C_003E7__wrap2 = num4;
							obj6 = 47;
							break;
						}
					}
					else if ((nint)obj6 == 47)
					{
						Assembly[] array = _003C_003E7__wrap1;
						if (_003C_003E7__wrap2 >= array.Length)
						{
							object obj11 = this + 20;
							obj11 = 0;
							result = null;
							obj6 = 52;
							continue;
						}
						object obj12 = _003C_003E7__wrap1 + 16;
						int num5 = _003C_003E7__wrap2 << 2;
						object obj13 = obj12 + num5;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj6 = 49;
						obj14 = obj15;
						object obj16 = obj17;
					}
					else if ((nint)obj6 == 49)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
						if (obj14 != obj18)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
						_003C_003Em__Finally1();
						if (obj19 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
							break;
						}
						result = null;
						obj6 = 52;
					}
					else
					{
						if ((nint)obj6 == 52)
						{
							return result;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						obj6 = 49;
						obj14 = obj15;
						object obj16 = obj20;
					}
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CGetAbstractAdProviderSubTypes_003Ed__44(int _003C_003E1__state)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("This event should not be invoked by the ad provider!");
			((EventListenerInvoker)(object)ex).PriorityListWrapped((string)null);
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001e: Expected VT, but got I4
			//IL_0023: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<> list = default;
			((List<T>)(object)list).Add((T)_003C_003E1__state);
			return (byte)(int)list != 0;
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
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected Obj, but got Unknown
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected Obj, but got Unknown
			//IL_010c: Expected Obj, but got I4
			//IL_015b: Expected Obj, but got I
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Expected Obj, but got Unknown
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 8;
			obj = obj2;
			_ = -1;
			object obj3 = _003C_003E1__state - -3;
			if (_003C_003E1__state != -3 && ((nint)obj3 == 1 || (nint)obj3 == 2 || (nint)obj3 == 3 || (nint)obj3 != 4))
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
			if (_003C_003E7__wrap3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
			}
		}

		IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
		{
			return (IEnumerator<Type>)_003C_003E2__current;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			if (_003C_003E1__state == -2)
			{
				bool hasShutdownStarted = Environment.HasShutdownStarted;
				if (_003C_003El__initialThreadId == (hasShutdownStarted ? 1 : 0))
				{
					_003C_003E1__state = 0;
					goto IL_0058;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8589");
			goto IL_0058;
			IL_0058:
			_003CGetAbstractAdProviderSubTypes_003Ed__44 result = default;
			return result;
		}
	}

	protected static readonly EventListenerInvoker eventInvoker;

	protected const string DEFAULT_CACHE_LOCATION = "undetermined";

	protected const string DEFAULT_SHOW_LOCATION = "undetermined";

	protected string _showInterstitialLocation;

	protected string _cacheInterstitialLocation;

	protected string _showVideoLocation;

	protected string _cacheVideoLocation;

	private static readonly Dictionary<string, AbstractAdProvider> _idToAbstractAdProvider;

	private static readonly Dictionary<string, AbstractAdProvider> _idToDebugAdProvider;

	private InitState _initState;

	private bool? _isLoadedAdConstantsRestricted;

	private static IAdSettingsProvider _settingsProvider;

	private bool _hasCheckedPlatformSupport;

	protected readonly Dictionary<AdType, bool> _supportedAdTypes;

	private AdType[] _allAdTypes;

	private bool isCaching__BackingField;

	private static Dictionary<string, AbstractAdProvider> idToAdProvider
	{
		get
		{
			//IL_0153: Expected I, but got Obj
			//IL_0169: Expected Obj, but got I
			//IL_01d1: Expected I, but got Obj
			//IL_01e7: Expected Obj, but got I
			//IL_0013: Expected I, but got Obj
			//IL_0106: Expected I, but got Obj
			//IL_0078: Expected I, but got Obj
			//IL_008e: Expected Obj, but got I
			//IL_00b9: Expected I, but got Obj
			nint num = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(SimulatedCloudServer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v45 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (SimulatedCloudServer._instance == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				SimulatedCloudServer simulatedCloudServer = default;
				simulatedCloudServer.CreateLocalDirsIfNecessary();
				nint num3 = (nint)typeof(SimulatedCloudServer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v33 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(SimulatedCloudServer);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v39 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				SimulatedCloudServer._instance = simulatedCloudServer;
			}
			nint num5 = (nint)typeof(SimulatedCloudServer);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v16 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(SimulatedCloudServer);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S0_v23 (Il2CppClass<Kiloo.Common.Backend.Cloud.SimulatedCloudServer>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (Dictionary<string, AbstractAdProvider>)(object)SimulatedCloudServer._instance;
		}
	}

	public abstract string id { get; }

	public abstract bool supportsMulticaching { get; }

	public virtual List<AdType> adTypesWithClickCallbackSupport
	{
		get
		{
			//IL_0035: Expected Obj, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj = default;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
				object obj2 = default;
				bool flag = (nint)obj2 == 401;
				return (List<AdType>)flag;
			}
			return null;
		}
	}

	public bool isCaching
	{
		get
		{
			//IL_001d: Expected I4, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<AdType> list = default;
			list._002Ector();
			return (byte)(int)list != 0;
		}
		private set
		{
			//IL_0014: Expected Obj, but got I4
			//IL_0014: Expected Obj, but got VT
			bool flag = ((Dictionary<string, IKilooAuthPlatform>)_isLoadedAdConstantsRestricted).Remove((string)value);
		}
	}

	public bool isInitializing => isCaching__BackingField;

	public bool isInitialized => _initState == InitState.Initializing;

	protected abstract void CheckPlatformSupport(AdProviderConfiguration configuration);

	private void Initialize(AdProviderConfiguration configuration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected I4, but got Unknown
		bool flag = (byte)(configuration & 1) != 0;
		isCaching__BackingField = flag;
	}

	public bool IsSupportedOnPlatform(AdType adType)
	{
		//IL_0093: Expected I4, but got Obj
		//IL_0093: Expected Obj, but got I4
		//IL_0125: Expected I4, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj = default;
		if ((nint)obj != 2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj3 = default;
			object obj2 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			string message = "KilooAuth state must Authorized (current state: " + text + ")";
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector(message);
			KilooAuthRequestExtensions.WithKilooAuth((IRequest)(object)ex, null);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Uri uri = default;
		bool originalStringSwitched = uri.OriginalStringSwitched;
		if (((string)originalStringSwitched).get_Chars((int)"https") != '\0')
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex2 = default;
			ex2._002Ector("KilooAuth only allowed when using https.");
			KilooAuthRequestExtensions.WithKilooAuth((IRequest)(object)ex2, null);
			return false;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object[] args = default;
		string innerException = $"KilooAuth AccessToken=\"{args}\"";
		HTTPBackOffException ex3 = default;
		ex3._002Ector("Authorization", (Exception)(object)innerException);
		return (byte)(int)this != 0;
	}

	private void CheckHasCacheIDs(Dictionary<AdLocationInfo, string> cacheIDs)
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected Obj, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected Obj, but got Unknown
		//IL_00a7: Expected I, but got Obj
		//IL_00bd: Expected Obj, but got I
		//IL_0057: Expected Obj, but got I4
		//IL_0065: Expected Obj, but got I4
		//IL_007f: Expected VT, but got Obj
		//IL_00e8: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = obj2 + 2;
		if (_initState != InitState.Uninitialized)
		{
			return;
		}
		AbstractAdProvider adProvider = GetAdProvider((string)(object)this);
		if (adProvider != null)
		{
			_initState = InitState.Initializing;
			bool flag = cacheIDs.buckets != null;
			obj3 = 0;
			_ = 1;
			obj3 = flag;
			obj2 = obj3;
			obj = obj2;
			_isLoadedAdConstantsRestricted = (bool?)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			return;
		}
		_initState = InitState.Unsupported;
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ S0_v21 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S0_v28 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int limit = default;
		eventInvoker.ReachedDailyInterstitialLimit(limit);
	}

	private void CheckOnlineSettingRestriction()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[KilooAuthRequestExtensions] ", (int)this);
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
		Debug.LogError(message);
	}

	private bool IsAnyTypeSupportedOnPlatform()
	{
		return _initState == InitState.Initialized;
	}

	protected unsafe virtual void OnInitialize(AdProviderConfiguration configuration)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected Obj, but got Unknown
		//IL_03f1: Expected Obj, but got I4
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected Obj, but got Unknown
		//IL_0414: Expected Obj, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected Ref, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected Obj, but got Unknown
		//IL_0467: Expected Obj, but got I
		//IL_0477: Expected Obj, but got I
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected Obj, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected I, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected Obj, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected Obj, but got Unknown
		//IL_01da: Expected Obj, but got I4
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected Obj, but got Unknown
		//IL_05e3: Expected Obj, but got I4
		//IL_05ec: Expected Obj, but got I4
		//IL_0241: Expected Obj, but got I
		//IL_0066: Expected Obj, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected Obj, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected Obj, but got Unknown
		//IL_0327: Expected I4, but got Obj
		//IL_0339: Expected Obj, but got I4
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected Obj, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected Obj, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected Obj, but got Unknown
		//IL_038d: Expected Obj, but got I
		//IL_039d: Expected Obj, but got I
		//IL_03bb: Expected Obj, but got I
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		ref bool reference = ref *(bool*)(obj2 - -64);
		reference = ref *(bool*)null;
		object obj5 = obj2 + 32;
		obj5 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		nint num2 = (nint)(obj9 + 113696);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v299 @ S4_v8 (Il2CppMethodInfo) (should have been resolved before IL gen)");
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)configuration)->Current;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj10 = default;
		object obj12 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj10 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v110+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ S0_v110+8]");
			bool flag;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ S0_v111+8]");
				flag = (nint)0 == 0;
			}
			else
			{
				flag = true;
			}
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				bool flag2;
				if (obj12 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ S0_v119+8]");
					flag2 = (nint)0 == 0;
				}
				else
				{
					flag2 = true;
				}
				if (!flag2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
					num2 = 0;
				}
			}
		}
		object obj13 = obj5 + 4;
		object obj14 = obj13 + 1;
		obj13 = obj14;
		object obj15 = obj14 << 2;
		object obj16 = obj5 + obj15;
		obj16 = 100;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj17 = (nint)0 << 2;
			object obj18 = obj5 + obj17;
			if ((nint)obj18 == 100)
			{
				object obj19 = obj5 + 4;
				if ((nint)obj19 > -1)
				{
					object obj20 = obj19 + -1;
					obj19 = obj20;
				}
				goto IL_05ca;
			}
		}
		object obj21 = default;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_05ca;
		IL_05ca:
		object obj22 = _allAdTypes + 12;
		object obj23 = 0;
		object obj24 = 113696;
		Dictionary<AdType, bool> dictionary = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj23) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj22))
		{
			object obj25 = _allAdTypes + 16;
			object obj26 = obj23 << 2;
			object obj27 = obj25 + obj26;
			bool flag3 = dictionary.TryGetValue((AdType)obj27, out reference);
			object obj28 = (flag3 ? 1 : 0) ^ 1;
			bool flag4 = !reference;
			object obj29 = flag4 | obj28;
			if (obj29 != null)
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ S4_v10 (Il2CppMethodInfo)+C]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S4_v11+60]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S4_v12+48]");
				num2 = 0;
				object obj32 = num2 & 0x7FF;
				obj24 = obj32 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v297 @ S5_v4 (should have been resolved before IL gen)");
			}
			object obj33 = obj23 + 1;
			obj23 = obj33;
		}
	}

	protected void FinishInitialization(bool success)
	{
	}

	public static void ClearStaticCollections()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected Obj, but got Unknown
		//IL_0022: Expected Obj, but got I4
		SimulatedCloudServer._instance = null;
		object obj2 = default;
		object obj = obj2 + 8;
		obj = 0;
		throw new ArrayTypeMismatchException();
	}

	public unsafe static void MapAdProviders(IAdSettingsProvider settingsProvider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected Ref, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected Obj, but got Unknown
		//IL_04aa: Expected Obj, but got I4
		//IL_04ce: Expected Obj, but got I
		//IL_0029: Expected Obj, but got I
		//IL_005d: Expected I4, but got Obj
		//IL_005d: Expected Obj, but got I
		//IL_006f: Expected Obj, but got I4
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected Obj, but got Unknown
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Expected Obj, but got Unknown
		//IL_00c6: Expected I, but got Obj
		//IL_00dc: Expected Obj, but got I
		//IL_0107: Expected I, but got Obj
		//IL_0154: Expected I, but got Obj
		//IL_016a: Expected Obj, but got I
		//IL_0195: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		ref bool reference = ref *(bool*)(obj2 + 12);
		reference = ref *(bool*)null;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [settingsProvider @ L0 (Kiloo.Common.Ads.IAdSettingsProvider)+24]");
		object obj4 = (nint)0 + (nint)12;
		object obj5 = default;
		object obj12 = default;
		object obj14 = default;
		while (true)
		{
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj4))
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [settingsProvider @ L0 (Kiloo.Common.Ads.IAdSettingsProvider)+24]");
			object obj6 = (nint)0 + (nint)16;
			object obj7 = obj5 << 2;
			object obj8 = obj6 + obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [settingsProvider @ L0 (Kiloo.Common.Ads.IAdSettingsProvider)+20]");
			bool flag = ((Dictionary<AdType, bool>)0).TryGetValue((AdType)obj8, out reference);
			object obj9 = (flag ? 1 : 0) ^ 1;
			bool flag2 = !reference;
			object obj10 = flag2 | obj9;
			if (obj10 == null)
			{
				nint num = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S0_v37 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num2 = (nint)typeof(AbstractAdProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ S0_v135 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9BDB");
				if (obj12 != null)
				{
					nint num3 = (nint)typeof(DeviceUtility);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S0_v49 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
					object obj13 = (nint)0 & (nint)0x200;
					if (obj13 != null)
					{
						nint num4 = (nint)typeof(DeviceUtility);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v131 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					break;
				}
			}
			obj5 = obj14 + 1;
		}
		string oSIdentifier = DeviceUtility.GetOSIdentifier();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj15 = default;
		object obj16 = default;
		if (obj15 == obj16)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			object obj18 = default;
			object obj17 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj19 = default;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
				throw new ArrayTypeMismatchException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @98");
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
			object obj22 = default;
			object obj21 = obj22;
		}
		else
		{
			object obj23 = default;
			object obj21 = obj23;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
	}

	private static void MapDebugAdProvider()
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v16 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<Type> abstractAdProviderSubTypes = GetAbstractAdProviderSubTypes();
		((Dictionary<TKey, TValue>)abstractAdProviderSubTypes).Resize();
		eventInvoker._002Ector();
	}

	private static void MapAbstractAdProviders(IAdSettingsProvider settingsProvider)
	{
		//IL_0227: Expected I, but got Obj
		//IL_023d: Expected Obj, but got I
		//IL_025a: Expected I, but got Obj
		//IL_02de: Expected Obj, but got I
		//IL_0306: Expected Obj, but got I4
		//IL_010a: Expected I, but got Obj
		//IL_0120: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0043: Expected I, but got Obj
		//IL_0292: Expected Obj, but got I4
		//IL_007c: Expected I, but got Obj
		//IL_0092: Expected Obj, but got I
		//IL_014b: Expected I, but got Obj
		//IL_0069: Expected I, but got Obj
		//IL_0198: Expected I, but got Obj
		//IL_01ae: Expected Obj, but got I
		//IL_00bd: Expected I, but got Obj
		//IL_01d9: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		bool flag = obj == null;
		nint num2 = (nint)typeof(AbstractAdProvider);
		if (!flag)
		{
			nint num3 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v63 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num2 = (nint)typeof(AbstractAdProvider);
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				num2 = (nint)typeof(AbstractAdProvider);
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ L1_v2 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+5C]");
		object obj2 = (nint)0 + (nint)12;
		obj2 = settingsProvider;
		Dictionary<string, AbstractAdProvider> idToDebugAdProvider = _idToDebugAdProvider;
		object obj3 = idToDebugAdProvider.count - idToDebugAdProvider.freeCount;
		if ((nint)obj3 < 1)
		{
			nint num4 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ S0_v54 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num5 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v59 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			HandleAdConstantsChanged();
		}
		nint num6 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ S0_v24 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num7 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ S0_v47 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Dictionary<string, AbstractAdProvider> idToAbstractAdProvider = _idToAbstractAdProvider;
		object obj6 = idToAbstractAdProvider.count - idToAbstractAdProvider.freeCount;
		if ((nint)obj6 >= 1)
		{
			return;
		}
		nint num8 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ S0_v38 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num9 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v43 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AddEventListener((IAdEventListener)settingsProvider);
	}

	private static IEnumerable<Type> GetAbstractAdProviderSubTypes()
	{
		//IL_012c: Expected I, but got Obj
		//IL_0142: Expected Obj, but got I
		//IL_019c: Expected I, but got Obj
		//IL_01b2: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_00df: Expected I, but got Obj
		//IL_0079: Expected I, but got Obj
		nint num = (nint)typeof(Globals);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Globals>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Globals);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v37 (Il2CppClass<Globals>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool dEBUG_USE_DEBUG_AD_PROVIDER = Globals.DEBUG_USE_DEBUG_AD_PROVIDER;
		nint num3 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v5 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		bool flag = obj2 != null;
		if (dEBUG_USE_DEBUG_AD_PROVIDER)
		{
			if (flag)
			{
				nint num4 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S0_v31 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			return (IEnumerable<Type>)_idToDebugAdProvider;
		}
		if (flag)
		{
			nint num5 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S0_v20 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return (IEnumerable<Type>)_idToAbstractAdProvider;
	}

	public static void HandleAdConstantsChanged()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0352: Expected I, but got Obj
		//IL_0368: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01d0: Expected Obj, but got I4
		//IL_028c: Expected Obj, but got I
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected Obj, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected Obj, but got Unknown
		//IL_00f4: Expected I, but got Obj
		//IL_010a: Expected Obj, but got I
		//IL_0135: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v138 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool simulateErrors = DebugAdProvider.simulateErrors;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
			nint num3 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ S0_v110 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj5 = (nint)0 & (nint)0x200;
			if (obj5 != null)
			{
				nint num4 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ S0_v129 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj6 = obj2 + 4;
		object obj7 = obj6 + 1;
		obj6 = obj7;
		object obj8 = obj7 << 2;
		object obj9 = obj2 + obj8;
		obj9 = 85;
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
			if ((nint)obj12 == 85)
			{
				object obj13 = obj2 + 4;
				if ((nint)obj13 > -1)
				{
					object obj14 = obj13 + -1;
					obj13 = obj14;
				}
				return;
			}
		}
		object obj15 = default;
		if (obj15 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public unsafe static bool IsProviderSupportedOnPlatform(string id, AdType adType)
	{
		//IL_0147: Expected Obj, but got I
		//IL_015d: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_0054: Expected I, but got Obj
		ref bool reference = ref *(bool*)null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+1E]");
		if ((nint)0 == 0)
		{
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v21 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ S0_v40 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @72FD");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @745A");
			AdProviderConfiguration configuration = default;
			((AbstractAdProvider)(object)id).OnInitialize(configuration);
			MapAdProviders((IAdSettingsProvider)(object)id);
			_ = 1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+20]");
		bool flag = ((Dictionary<AdType, bool>)0).TryGetValue(adType, out reference);
		object obj2 = reference & flag;
		return obj2 != null;
	}

	public static AbstractAdProvider GetAdProvider(string id)
	{
		//IL_0016: Expected Obj, but got I
		//IL_001f: Expected Obj, but got I4
		//IL_003a: Expected Obj, but got I
		//IL_0062: Expected I4, but got Obj
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected Obj, but got Unknown
		//IL_0088: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+24]");
		object obj = (nint)0 + (nint)12;
		object obj2 = 0;
		AbstractAdProvider result;
		while (true)
		{
			bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
			result = null;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [id @ L0 (System.String)+24]");
			object obj3 = (nint)0 + (nint)16;
			object obj4 = obj2 << 2;
			object obj5 = obj3 + obj4;
			if (IsProviderSupportedOnPlatform(id, (AdType)obj5))
			{
				result = (AbstractAdProvider)1;
				break;
			}
			object obj6 = obj2 + 1;
			obj2 = obj6;
		}
		return result;
	}

	public static void AddEventListener(IAdEventListener listener)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_06e4: Expected I, but got Obj
		//IL_06fa: Expected Obj, but got I
		//IL_0785: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_0078: Expected Obj, but got I4
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected Obj, but got Unknown
		//IL_0099: Expected Obj, but got I4
		//IL_00b1: Expected Obj, but got I4
		//IL_00c9: Expected Obj, but got I4
		//IL_00e1: Expected Obj, but got I4
		//IL_0176: Expected I, but got Obj
		//IL_018c: Expected Obj, but got I
		//IL_0614: Expected Obj, but got I
		//IL_076d: Expected Obj, but got I4
		//IL_0133: Expected Obj, but got I4
		//IL_01b7: Expected I, but got Obj
		//IL_014b: Expected Obj, but got I4
		//IL_064a: Unknown result type (might be due to invalid IL or missing references)
		//IL_064f: Expected Obj, but got Unknown
		//IL_0163: Expected Obj, but got I4
		//IL_01fa: Expected Obj, but got I4
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected Obj, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected Obj, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected Obj, but got Unknown
		//IL_0558: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S0_v16 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v162 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool simulateErrors = DebugAdProvider.simulateErrors;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
		object obj5 = default;
		object obj6 = default;
		object obj4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj4 = 34;
			bool flag = obj5 == null;
			obj4 = 37;
			if (flag)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			obj4 = 13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj4 = 14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj4 = 14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj4 = 15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj6 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				obj4 = 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
				obj4 = 25;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = 26;
			}
			nint num3 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ S0_v111 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj7 = (nint)0 & (nint)0x200;
			if (obj7 != null)
			{
				nint num4 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v132 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					obj4 = 27;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			obj4 = 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		}
		object obj8 = obj4 - 13;
		if ((nint)obj4 != 13 && (nint)obj8 != 1 && (nint)obj8 != 2 && (nint)obj8 != 3)
		{
			if ((nint)obj8 != 4 && (nint)obj8 != 5 && (nint)obj8 != 6 && (nint)obj8 != 7 && (nint)obj8 != 8 && (nint)obj8 != 9 && (nint)obj8 != 10)
			{
				if ((nint)obj8 == 11 || (nint)obj8 == 12 || (nint)obj8 == 13 || (nint)obj8 == 14)
				{
					goto IL_055d;
				}
				if ((nint)obj8 != 15 && (nint)obj8 != 16 && (nint)obj8 != 17 && (nint)obj8 != 18)
				{
					if ((nint)obj8 == 19 || (nint)obj8 == 20 || (nint)obj8 == 21)
					{
						goto IL_055d;
					}
					if ((nint)obj8 != 22 && (nint)obj8 != 23 && (nint)obj8 == 24)
					{
						object obj9 = obj2 + 4;
						object obj10 = obj9 + 1;
						obj9 = obj10;
						object obj11 = obj10 << 2;
						object obj12 = obj2 + obj11;
						obj12 = 108;
					}
				}
			}
			goto IL_0794;
		}
		goto IL_055d;
		IL_0794:
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
			if ((nint)obj15 == 108)
			{
				object obj16 = obj2 + 4;
				if ((nint)obj16 > -1)
				{
					object obj17 = obj16 + -1;
					obj16 = obj17;
				}
				return;
			}
		}
		object obj18 = default;
		if (obj18 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		return;
		IL_055d:
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
		goto IL_0794;
	}

	public static void RemoveEventListener(IAdEventListener listener)
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		eventInvoker.RemoveListener(listener);
	}

	public bool HasCachedAd(AdType adType, string cacheID)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = adType;
		object obj3 = (flag ? 1 : 0) + 24;
		obj3 = cacheID;
		return flag;
	}

	public bool IsCachingLocation(AdLocationInfo info)
	{
		//IL_010e: Expected Obj, but got I4
		//IL_011c: Expected I, but got Obj
		//IL_0132: Expected Obj, but got I
		//IL_0073: Expected I4, but got Obj
		//IL_0085: Expected I, but got Obj
		//IL_009b: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_005f: Expected I4, but got Obj
		//IL_00c6: Expected I, but got Obj
		object obj = 0;
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v25 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<Type> abstractAdProviderSubTypes = GetAbstractAdProviderSubTypes();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj3 = default;
		if (obj3 != null)
		{
			return IsProviderSupportedOnPlatform((string)obj, (AdType)info);
		}
		string text = string.ConcatArray((string[])(object)"Unknown provider ID ", (int)this);
		nint num3 = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S1_v10 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num4 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S1_v15 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DebugAdGUI)(object)text).Awake();
		return false;
	}

	public unsafe void CacheAd(AdType adType, string adLocationID, string cacheID)
	{
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected Obj, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected Ref, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected Obj, but got Unknown
		//IL_01b0: Expected Obj, but got I4
		//IL_01c0: Expected Obj, but got I4
		//IL_01e7: Expected Obj, but got I
		//IL_0083: Expected Obj, but got I
		//IL_0093: Expected Obj, but got I
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected Obj, but got Unknown
		//IL_00d7: Expected Obj, but got I
		//IL_00e7: Expected Obj, but got I
		//IL_00f7: Expected Obj, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected Obj, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected Obj, but got Unknown
		//IL_0162: Expected Obj, but got I4
		//IL_0029: Expected Obj, but got I4
		//IL_0224: Expected Obj, but got I
		//IL_0234: Expected Obj, but got I
		//IL_0244: Expected Obj, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected Obj, but got Unknown
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected Obj, but got Unknown
		object obj = default;
		string text = (string)(obj + 32);
		ref CloudWorkingCopy.ItemMetadata reference = ref *(CloudWorkingCopy.ItemMetadata*)(obj + 48);
		reference = ref *(CloudWorkingCopy.ItemMetadata*)null;
		object obj2 = obj + 16;
		obj2 = 0;
		_ = 0;
		string filePathFromItemName = ((CloudWorkingCopy)(object)this).GetFilePathFromItemName((string)adType);
		bool flag = isCaching__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ S0_v18 (System.Boolean)+C]");
		if (((Dictionary<string, CloudWorkingCopy.ItemMetadata>)0).TryGetValue(filePathFromItemName, out reference))
		{
			int num = ((SimulatedCloudServer._003C_003Ec)(object)reference)._003CInternalUpdateItems_003Eb__33_0((ICloudItem)(object)adLocationID, (ICloudItem)(object)cacheID);
			CloudWorkingCopy.ItemMetadata itemMetadata = ((CloudWorkingCopy.ItemMetadata)num).WithServerDataVersion(1);
			reference = ref *(CloudWorkingCopy.ItemMetadata*)itemMetadata;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
			obj = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v13+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S3_v6 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S3_v7+60]");
			object obj4 = 0;
			object obj5 = obj4;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v86 @ S4_v10 (should have been resolved before IL gen)");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S4_v12 (Il2CppMethodInfo)+C]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ S4_v13+60]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ S4_v14+48]");
			object obj10 = 0;
			object obj11 = obj10 & 0x7FF;
			object obj12 = obj11 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v103 @ S5_v11 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			text = (string)obj;
			string text2 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			text2.m_stringLength = 0;
			System.IO.FileSystemEnumerableIterator<> fileSystemEnumerableIterator = default;
			bool checkHost = default;
			((System.IO.FileSystemEnumerableIterator<TSource>)(object)fileSystemEnumerableIterator)._002Ector((string)null, text, (string)null, (string)1, SearchOption.TopDirectoryOnly, (System.IO.SearchResultHandler<TSource>)null, checkHost);
			reference = ref *(CloudWorkingCopy.ItemMetadata*)fileSystemEnumerableIterator;
		}
		bool flag2 = isCaching__BackingField;
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S4_v3 (Il2CppMethodInfo)+C]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ S4_v4+60]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ S4_v5+48]");
		object obj15 = 0;
		object obj16 = obj15 & 0x7FF;
		object obj17 = obj16 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v155 @ S5_v5 (should have been resolved before IL gen)");
		CloudWorkingCopy.LogError((string)(object)this);
	}

	public bool ShowAd(AdType adType, string adLocationID, string cacheID)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_003e: Expected Obj, but got I4
		//IL_004c: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 20;
		obj2 = adType;
		object obj3 = (flag ? 1 : 0) + 44;
		obj3 = adLocationID;
		_ = cacheID.m_stringLength;
		object obj4 = (flag ? 1 : 0) + 28;
		obj4 = cacheID;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		return flag;
	}

	public void TimeoutCaching(AdType adType, string adLocationID)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 32;
		object obj3 = obj2 + 8;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		obj3 = adLocationID;
		_ = adLocationID.m_stringLength;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
		object obj4 = default;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj5 = default;
			if (obj5 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			}
		}
	}

	protected virtual void OnCacheTimeout(AdType adType, string adLocationID)
	{
		//IL_0061: Expected I, but got Obj
		//IL_0077: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v14 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID = default;
		eventInvoker.ClickedAd(adType, providerID, adLocationID);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
	}

	protected virtual void ShowInterstitial(string adLocationID, string cacheID)
	{
	}

	protected virtual void CacheInterstitial(string adLocationID, string cacheID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type type = default;
		object message = ((IConvertible)"Ad provider ").ToType(type, (IFormatProvider)(object)", does not support interstitials");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector((string)message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	protected virtual void ShowVideo(string adLocationID, string cacheID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type type = default;
		object message = ((IConvertible)"Ad provider ").ToType(type, (IFormatProvider)(object)", does not support interstitials");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector((string)message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	protected virtual void CacheVideo(string adLocationID, string cacheID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type type = default;
		object message = ((IConvertible)"Ad provider ").ToType(type, (IFormatProvider)(object)", does not support videos");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector((string)message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	protected virtual bool HasCachedVideo(string cacheID)
	{
		//IL_0079: Expected Obj, but got I4
		if (~(isCaching__BackingField ? 1u : 0u) != 0)
		{
			return false;
		}
		string text = ((cacheID.m_firstChar == '\0') ? _cacheInterstitialLocation : _cacheVideoLocation);
		return text != (string)cacheID.m_stringLength;
	}

	protected virtual bool HasCachedInterstitial(string cacheID)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Type type = default;
		object message = ((IConvertible)"Ad provider ").ToType(type, (IFormatProvider)(object)", does not support videos");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		NullReferenceException ex = default;
		ex._002Ector((string)message);
		((AbstractAdProvider)(object)ex).HasCachedVideo((string)null);
		return false;
	}

	public unsafe override void CachedAd(AdType adType, string providerID, string adLocationID, bool wasAlreadyCached)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected Obj, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected Obj, but got Unknown
		//IL_004f: Expected Obj, but got I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_00ad: Expected F4, but got Obj
		//IL_00a8: Expected native int or pointer, but got VT
		//IL_00c2: Expected F4, but got I
		//IL_00bd: Expected native int or pointer, but got VT
		//IL_00cf: Expected Obj, but got I4
		//IL_00e0: Expected F4, but got Obj
		//IL_00db: Expected native int or pointer, but got VT
		//IL_00f5: Expected F4, but got I
		//IL_00f0: Expected native int or pointer, but got VT
		//IL_0102: Expected Obj, but got I4
		//IL_017d: Expected Obj, but got I4
		//IL_01b4: Expected F4, but got Obj
		//IL_01af: Expected native int or pointer, but got VT
		//IL_01c9: Expected F4, but got I
		//IL_01c4: Expected native int or pointer, but got VT
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected Obj, but got Unknown
		//IL_0150: Expected F4, but got Obj
		//IL_014b: Expected native int or pointer, but got VT
		//IL_0165: Expected F4, but got I
		//IL_0160: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + 60);
		object obj2 = obj + 48;
		object obj3 = obj + 12;
		object obj4 = obj + 36;
		object obj5 = obj + 24;
		obj5 = 0;
		_ = 0;
		object obj6 = this + 12;
		object obj7 = default;
		object obj11 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6))
		{
			object obj8 = this + 16;
			object obj9 = obj7 * 12;
			object obj10 = obj8 + obj9;
			obj2 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S1_v15+8]");
			_ = 0;
			((Vector3*)(nint)vector)->x = (float)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector2 = ((Transform)adType).InverseTransformPoint(vector);
			((Vector3*)(nint)vector)->x = (float)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S0_v9+8]");
			((Vector3*)(nint)vector)->z = 0f;
			Vector3 vector3 = ((Camera)wasAlreadyCached).WorldToViewportPoint(vector);
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			_ = 0f;
			if (adLocationID != null)
			{
				((Vector3*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4B6");
			}
			else
			{
				string text = (string)1;
				obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				_ = 0;
				obj2 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v11+8]");
				_ = 0;
				((Vector3*)(nint)vector)->x = (float)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S0_v13+8]");
				((Vector3*)(nint)vector)->z = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4AE");
			}
			obj7 = obj11 + 1;
		}
	}

	public override void FailedToCacheAd(AdType adType, string providerID, string adLocationID)
	{
		//IL_01c7: Expected I, but got Obj
		//IL_01dd: Expected Obj, but got I
		//IL_0307: Expected I, but got Obj
		//IL_031d: Expected Obj, but got I
		//IL_0208: Expected I, but got Obj
		//IL_0255: Expected I, but got Obj
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected Obj, but got Unknown
		//IL_00b8: Expected Obj, but got I4
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_017a: Expected I, but got Obj
		if (_initState == InitState.Initialized && adLocationID != null && adLocationID.m_stringLength != 0)
		{
			bool flag = adType == AdType.Video;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			object obj2 = default;
			object obj = obj2 ^ 1;
			object obj3 = flag | obj;
			if (obj3 != null && isCaching__BackingField)
			{
				return;
			}
			IEnumerator enumerator = ((DebugAdProvider)this).CacheInterstitialCoroutine((string)adType, adLocationID);
			if (enumerator == null)
			{
				isCaching__BackingField = true;
				if (flag)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7767");
				}
				return;
			}
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v45 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj4 = (nint)0 & (nint)0x200;
			if (obj4 != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ S0_v52 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			string providerID2 = default;
			((AdController.EventHandler)(object)eventInvoker).CachedAd(adType, providerID2, providerID, true);
			return;
		}
		nint num3 = (nint)typeof(AdSystemLog);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v11 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(AdSystemLog);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v31 (Il2CppClass<Kiloo.Common.Ads.AdSystemLog>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((DebugAdGUI)(object)"Unable to cache ad, provider is not initialized or cacheID is null").Awake();
		nint num5 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v18 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num6 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ S0_v25 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		string providerID3 = default;
		eventInvoker.FailedToShowAd(adType, providerID3, providerID);
	}

	public override void CachingTimedOut(AdType adType, string providerID, string adLocationID)
	{
		//IL_000a: Expected I4, but got Obj
		((AdController)(object)this).allowReCacheOnFail = (byte)(int)providerID != 0;
	}

	private void OnFinishedCaching(string providerID)
	{
		//IL_00b7: Expected I, but got Obj
		//IL_00cd: Expected Obj, but got I
		//IL_001e: Expected I, but got Obj
		//IL_0034: Expected Obj, but got I
		//IL_00f8: Expected I, but got Obj
		//IL_005f: Expected I, but got Obj
		if (providerID != null)
		{
			_initState = InitState.Initialized;
			nint num = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v24 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v31 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			eventInvoker.AddListener(this);
			return;
		}
		_initState = InitState.Uninitialized;
		nint num3 = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ S0_v9 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S0_v16 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		int limit = default;
		eventInvoker.ReachedDailyInterstitialLimit(limit);
	}

	protected AbstractAdProvider()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v13 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		eventInvoker.FailedToInitAdProvider((string)(object)this);
	}

	unsafe static AbstractAdProvider()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09de: Expected Obj, but got Unknown
		//IL_09e7: Expected Obj, but got I4
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a01: Expected Obj, but got Unknown
		//IL_0a0a: Expected Obj, but got I4
		//IL_0a13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Expected Obj, but got Unknown
		//IL_0a21: Expected Obj, but got I4
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected Obj, but got Unknown
		//IL_0a4b: Expected I, but got Obj
		//IL_0a61: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected Obj, but got Unknown
		//IL_0160: Expected I, but got Obj
		//IL_0176: Expected Obj, but got I
		//IL_01a1: Expected I, but got Obj
		//IL_0246: Expected Obj, but got I
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected Obj, but got Unknown
		//IL_0926: Expected Obj, but got I
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected Obj, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected Obj, but got Unknown
		//IL_0861: Unknown result type (might be due to invalid IL or missing references)
		//IL_0866: Expected Obj, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0874: Expected Obj, but got Unknown
		//IL_08a0: Expected Obj, but got I4
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 + 40;
		obj3 = 0;
		_ = 0;
		_ = 0;
		object obj4 = obj2 + 24;
		obj4 = 0;
		object obj5 = obj2 - -64;
		obj5 = 0;
		object obj6 = obj2 + 32;
		obj6 = obj;
		_ = -1;
		nint num = (nint)typeof(AbstractAdProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ S0_v23 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
		object obj7 = (nint)0 & (nint)0x200;
		if (obj7 != null)
		{
			nint num2 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S0_v203 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerable<Type> abstractAdProviderSubTypes = GetAbstractAdProviderSubTypes();
		KeyValuePair<_00210, _00211> current = (KeyValuePair<_00210, _00211>)((Dictionary<TKey, TValue>.Enumerator*)abstractAdProviderSubTypes)->Current;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj8 = default;
		object obj11 = default;
		object obj13 = default;
		object obj14 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ S0_v119+18]");
			if ((nint)0 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ S0_v197+18]");
				if ((nint)0 != 1)
				{
					continue;
				}
			}
			nint num3 = (nint)typeof(AbstractAdProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ S0_v128 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num4 = (nint)typeof(AbstractAdProvider);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ S0_v183 (Il2CppClass<Kiloo.Common.Ads.AbstractAdProvider>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ S0_v153+1C]");
			obj2 = 0;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			object obj10 = obj11 ^ 1;
			object obj12 = obj13 & obj10;
			if (obj12 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				if (obj14 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					_ = 3;
				}
			}
		}
		object obj15 = 45;
		object obj16 = obj15 - 10;
		object obj23;
		object obj24 = default;
		if ((nint)obj15 != 10 && (nint)obj16 != 1)
		{
			if ((nint)obj16 == 2 || (nint)obj16 == 3 || (nint)obj16 == 4)
			{
				goto IL_0b19;
			}
			if ((nint)obj16 != 5)
			{
				if ((nint)obj16 == 6 || (nint)obj16 == 7 || (nint)obj16 == 8 || (nint)obj16 == 9)
				{
					goto IL_0b19;
				}
				if ((nint)obj16 != 10)
				{
					if ((nint)obj16 == 11 || (nint)obj16 == 12 || (nint)obj16 == 13 || (nint)obj16 == 14 || (nint)obj16 == 15 || (nint)obj16 == 16)
					{
						goto IL_0b19;
					}
					if ((nint)obj16 != 17)
					{
						if ((nint)obj16 != 18)
						{
							if ((nint)obj16 != 19)
							{
								if ((nint)obj16 != 20 && (nint)obj16 != 21)
								{
									if ((nint)obj16 == 22 || (nint)obj16 == 23 || (nint)obj16 == 24)
									{
										goto IL_0b19;
									}
									if ((nint)obj16 != 25)
									{
										if ((nint)obj16 == 26 || (nint)obj16 == 27 || (nint)obj16 == 28 || (nint)obj16 == 29 || (nint)obj16 == 30)
										{
											goto IL_0b19;
										}
										if ((nint)obj16 != 31)
										{
											if ((nint)obj16 != 32)
											{
												if ((nint)obj16 != 33 && (nint)obj16 != 34 && (nint)obj16 == 35)
												{
													object obj17 = obj6 + 4;
													object obj18 = obj17 + 1;
													obj17 = obj18;
													object obj19 = obj18 << 2;
													object obj20 = obj6 + obj19;
													obj20 = 150;
												}
												goto IL_0b19;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj22 = default;
											object obj21 = obj22;
											obj23 = obj24;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj25 = default;
											object obj21 = obj25;
											obj23 = obj24;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj26 = default;
										object obj21 = obj26;
										obj23 = obj24;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj27 = default;
									object obj21 = obj27;
									obj23 = obj24;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj28 = default;
								object obj21 = obj28;
								obj23 = obj24;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj29 = default;
							object obj21 = obj29;
							obj23 = obj24;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
						object obj30 = default;
						object obj21 = obj30;
						obj23 = obj24;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
					object obj31 = default;
					object obj21 = obj31;
					obj23 = obj24;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj32 = default;
				object obj21 = obj32;
				obj23 = obj24;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj33 = default;
			object obj21 = obj33;
			obj23 = obj24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj34 = default;
		if (obj23 == obj34)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0b19;
		IL_0b19:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20+4]");
			object obj35 = (nint)0 << 2;
			object obj36 = obj6 + obj35;
			if ((nint)obj36 == 150)
			{
				object obj37 = obj6 + 4;
				if ((nint)obj37 > -1)
				{
					object obj38 = obj37 + -1;
					obj37 = obj38;
				}
				return;
			}
		}
		object obj39 = default;
		if (obj39 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}
}
