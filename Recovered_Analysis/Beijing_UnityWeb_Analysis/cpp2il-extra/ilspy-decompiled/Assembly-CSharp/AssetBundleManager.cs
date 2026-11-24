using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Cloud;
using Cpp2ILInjected;
using Data.Managers;
using Data.Save;
using InApp;
using Info;
using Kiloo;
using Kiloo.Common.Extensions;
using Kiloo.Common.HTTP;
using Kiloo.Common.Plugins.DeviceUtility;
using Kiloo.Common.Utility;
using Kiloo.Serialization;
using SYBO.Subway;
using SYBO.Subway.Info;
using SYBO.Subway.UI;
using UI.Screens.BoardScreenInternal;
using UI.Screens.CharacterScreenInternal;
using UnityEngine;
using UnityEngine.UI;

public class AssetBundleManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__51_1;

		public static Predicate<string> _003C_003E9__51_0;

		public static Comparison<CharacterModelRequest.CharacterBundleRequest> _003C_003E9__56_0;

		static _003C_003Ec()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AdSystemManager._003C_003Ec obj = default;
			AdSystemManager._003C_003Ec._003C_003E9 = obj;
		}

		public _003C_003Ec()
		{
			TransformExtensions.Reset((Transform)(object)AdSystemManager.onAdSystemInitialized);
		}

		internal bool _003CGetAbsolutePath_003Eb__51_1(string s)
		{
			//IL_0015: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (AssetBundleManager+<>c)+8]");
			return s != (string)0;
		}

		internal bool _003CGetAbsolutePath_003Eb__51_0(string s)
		{
			return s != "..";
		}

		internal int _003CProcessCharacterBundleRequests_003Eb__56_0(CharacterModelRequest.CharacterBundleRequest r1, CharacterModelRequest.CharacterBundleRequest r2)
		{
			//IL_0009: Expected Obj, but got I4
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120A3");
			int result = default;
			return result;
		}
	}

	private sealed class _003CLoadAssetBundleAsync_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string bundleName;

		public int cachedVersion;

		public AssetBundleManager _003C_003E4__this;

		public Action<AssetBundle> requestResultHandler;

		private AssetBundleCreateRequest _003Crequest_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0061: Expected I, but got Obj
				//IL_0077: Expected Obj, but got I
				//IL_0189: Expected I, but got Obj
				//IL_019f: Expected Obj, but got I
				//IL_00a2: Expected I, but got Obj
				//IL_024b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Expected Obj, but got Unknown
				//IL_026d: Expected Obj, but got I4
				//IL_0273: Unknown result type (might be due to invalid IL or missing references)
				//IL_0278: Expected Obj, but got Unknown
				//IL_0296: Expected Obj, but got I4
				//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fc: Expected Obj, but got Unknown
				//IL_0118: Expected Obj, but got I4
				//IL_01ca: Expected I, but got Obj
				//IL_0162: Expected I4, but got Obj
				//IL_0162: Expected I4, but got Obj
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						if (_003C_003E1__state == 2)
						{
							_003C_003E1__state = -1;
							UnityEngine.Object asset = ((AssetBundleRequest)(object)_003Crequest_003E5__2).asset;
							CharacterCustomizationAssetsFactory.GetAssetPrefab((string)(object)_003C_003E4__this, (int)bundleName, (byte)(int)asset != 0, (Action<CharacterCustomizationBundle>)requestResultHandler);
							return null;
						}
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(Globals);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v32 (Il2CppClass<Globals>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(Globals);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v31 @ S0_v47 (Il2CppClass<Globals>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(Globals.DEBUG_ENABLE_LOADING_DELAY ? 1u : 0u) == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						_ = 0.5f;
						object obj2 = this + 12;
						object obj3 = default;
						obj2 = obj3;
						_003C_003E1__state = 1;
						return 1;
					}
				}
				nint num3 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16 (Il2CppClass<AssetBundleCache>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(AssetBundleCache);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v26 (Il2CppClass<AssetBundleCache>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj5 = this + 32;
				bool flag = AssetBundleCache.IsAssetBundleCached(bundleName, cachedVersion);
				obj5 = flag;
				object obj6 = this + 12;
				obj6 = _003Crequest_003E5__2;
				_003C_003E1__state = 2;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CLoadAssetBundleAsync_003Ed__54(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected Obj, but got Unknown
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected Obj, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected I4, but got Unknown
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected Obj, but got Unknown
			bool flag;
			if (this != null)
			{
				flag = true;
				char[] array = default;
				char[] array3 = default;
				while ((nint)array < _003C_003E1__state)
				{
					string[] array2 = ((string)this).Split(array3);
					object obj = array2 & 0xFFFF;
					object obj2 = flag ^ obj;
					bool flag2 = (byte)(obj2 * 16777619) != 0;
					array = (char[])(array3 + 1);
					flag = flag2;
				}
			}
			else
			{
				flag = false;
			}
			return flag;
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

	private sealed class _003CProcessCharacterBundleRequests_003Ed__56(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0365: Unknown result type (might be due to invalid IL or missing references)
				//IL_036a: Expected Obj, but got Unknown
				//IL_0373: Expected Obj, but got I4
				//IL_0387: Expected Obj, but got I4
				//IL_0093: Expected I, but got Obj
				//IL_00a9: Expected Obj, but got I
				//IL_03b8: Expected native int or pointer, but got Obj
				//IL_00d4: Expected I, but got Obj
				//IL_0121: Expected I, but got Obj
				//IL_0137: Expected Obj, but got I
				//IL_01b3: Expected Obj, but got VT
				//IL_01c5: Expected Obj, but got VT
				//IL_0304: Expected Obj, but got I
				//IL_0318: Unknown result type (might be due to invalid IL or missing references)
				//IL_031d: Expected Obj, but got Unknown
				//IL_0334: Expected I, but got Obj
				//IL_034a: Expected Obj, but got I
				//IL_01e4: Expected Obj, but got I
				//IL_01ed: Expected Obj, but got I4
				//IL_0162: Expected I, but got Obj
				//IL_0208: Expected Obj, but got I
				//IL_0244: Unknown result type (might be due to invalid IL or missing references)
				//IL_0249: Expected Obj, but got Unknown
				//IL_0251: Expected Obj, but got VT
				//IL_0275: Unknown result type (might be due to invalid IL or missing references)
				//IL_027a: Expected Obj, but got Unknown
				AssetBundleManager assetBundleManager = _003C_003E4__this;
				if (_003C_003E1__state != 0 && _003C_003E1__state != 1)
				{
					return null;
				}
				_003C_003E1__state = -1;
				List<CharacterModelRequest.CharacterBundleRequest> pendingCharacterBundleRequests = assetBundleManager._pendingCharacterBundleRequests;
				if (pendingCharacterBundleRequests._size >= 1)
				{
					nint num = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v10 (Il2CppClass<AssetBundleManager+<>c>)+BA]");
					object obj = (nint)0 & (nint)0x200;
					if (obj != null)
					{
						nint num2 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ S1_v68 (Il2CppClass<AssetBundleManager+<>c>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					bool flag = _003C_003Ec._003C_003E9__56_0 == null;
					bool flag2 = !flag;
					Queue<_00210> q = (Queue<_00210>)(object)_003C_003Ec._003C_003E9__56_0;
					if (!flag2)
					{
						nint num3 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S1_v42 (Il2CppClass<AssetBundleManager+<>c>)+BA]");
						object obj2 = (nint)0 & (nint)0x200;
						if (obj2 != null)
						{
							nint num4 = (nint)typeof(_003C_003Ec);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ S1_v62 (Il2CppClass<AssetBundleManager+<>c>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
						nint num5 = 0;
						Queue<_00210> queue = default;
						queue._array = (_00210[])num5;
						queue._size = 0;
						object obj3 = queue + 16;
						obj3 = _003C_003Ec._003C_003E9;
						nint num6 = (nint)typeof(_003C_003Ec);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S1_v59 (Il2CppClass<AssetBundleManager+<>c>)+5C]");
						object obj4 = (nint)0 + (nint)12;
						obj4 = queue;
						q = queue;
					}
					System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)assetBundleManager._pendingCharacterBundleRequests, new Queue<T>.Enumerator((Queue<T>)(object)q));
					_0021_00210 val = (_0021_00210)Enumerable.Last<TSource>((IEnumerable<TSource>)assetBundleManager._pendingCharacterBundleRequests);
					List<CharacterModelRequest.CharacterBundleRequest> activeCharacterBundleRequests = assetBundleManager._activeCharacterBundleRequests;
					if (activeCharacterBundleRequests._size < assetBundleManager._simultaneousCharacterBundleRequests)
					{
						assetBundleManager._activeCharacterBundleRequests.Add((CharacterModelRequest.CharacterBundleRequest)val);
						bool flag3 = assetBundleManager._pendingCharacterBundleRequests.Remove((CharacterModelRequest.CharacterBundleRequest)val);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v26 (TSource)+10]");
						object obj5 = (nint)0 + (nint)12;
						object obj6 = 0;
						Action<AssetBundle> action = default;
						while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj5))
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v26 (TSource)+10]");
							object obj7 = (nint)0 + (nint)16;
							object obj8 = obj6 << 2;
							object bundleName = obj7 + obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num7 = 0;
							_ = 0;
							object obj9 = action + 16;
							obj9 = val;
							assetBundleManager.RequestAssetBundle((string)bundleName, action, asynchronous: true);
							object obj10 = obj6 + 1;
							obj6 = obj10;
						}
					}
				}
				object obj11 = this + 12;
				obj11 = 0;
				_003C_003E1__state = 1;
				return 1;
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

	private sealed class _003CCacheNeededAssetBundles_003Ed__61(int _003C_003E1__state) : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private float _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		private Dictionary<string, int> _003CneededBundles_003E5__2;

		private int _003CnShippedBundles_003E5__3;

		private int _003CnBundlesProcessed_003E5__4;

		private Dictionary<string, int>.KeyCollection.Enumerator _003C_003E7__wrap4;

		float IEnumerator<float>.Current
		{
			get
			{
				//IL_0007: Expected F4, but got I4
				return _003C_003E1__state;
			}
		}

		object IEnumerator.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_066a: Unknown result type (might be due to invalid IL or missing references)
				//IL_066f: Expected Obj, but got Unknown
				//IL_0678: Unknown result type (might be due to invalid IL or missing references)
				//IL_067d: Expected Obj, but got Unknown
				//IL_0057: Unknown result type (might be due to invalid IL or missing references)
				//IL_005c: Expected Obj, but got Unknown
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Expected Obj, but got Unknown
				//IL_00ad: Expected Obj, but got I4
				//IL_00bb: Expected I, but got Obj
				//IL_00d1: Expected Obj, but got I
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ad: Expected Obj, but got Unknown
				//IL_00fc: Expected I, but got Obj
				//IL_029b: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a0: Expected Obj, but got Unknown
				//IL_06bf: Expected Obj, but got I4
				//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fe: Expected Obj, but got Unknown
				//IL_0216: Expected I, but got Obj
				//IL_022c: Expected Obj, but got I
				//IL_02f4: Expected I, but got Obj
				//IL_030a: Expected Obj, but got I
				//IL_0257: Expected I, but got Obj
				//IL_0335: Expected I, but got Obj
				object obj2 = default;
				object obj = obj2 + 48;
				object obj3 = obj2 + 24;
				object obj4 = obj2 + 16;
				obj4 = obj;
				_ = -1;
				AssetBundleManager assetBundleManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -3;
						object obj5 = this + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
						object obj6 = default;
						if (obj6 != null)
						{
							object obj7 = this + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							object obj8 = default;
							if ((nint)obj8 < 0)
							{
								nint num = (nint)typeof(AssetBundleVersionControl);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ S0_v108 (Il2CppClass<AssetBundleVersionControl>)+BA]");
								object obj9 = (nint)0 & (nint)0x200;
								if (obj9 != null)
								{
									nint num2 = (nint)typeof(AssetBundleVersionControl);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ S0_v155 (Il2CppClass<AssetBundleVersionControl>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							}
							goto IL_05c4;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
						object obj10 = this + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
						nint num3 = (nint)typeof(AssetBundleCache);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ S0_v169 (Il2CppClass<AssetBundleCache>)+BA]");
						object obj11 = (nint)0 & (nint)0x200;
						if (obj11 != null)
						{
							nint num4 = (nint)typeof(AssetBundleCache);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ S0_v180 (Il2CppClass<AssetBundleCache>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
					goto IL_06b9;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				object obj12 = this + 20;
				object obj13 = default;
				obj12 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				int num5 = default;
				_003CnShippedBundles_003E5__3 = num5;
				_003CnBundlesProcessed_003E5__4 = 0;
				assetBundleManager.succesfullyPrecached = 0;
				object obj14 = assetBundleManager - -64;
				obj14 = 0;
				nint num6 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S0_v212 (Il2CppClass<AssetBundleCache>)+BA]");
				object obj15 = (nint)0 & (nint)0x200;
				if (obj15 != null)
				{
					nint num7 = (nint)typeof(AssetBundleCache);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ S0_v243 (Il2CppClass<AssetBundleCache>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				goto IL_05c4;
				IL_06b9:
				return 1;
				IL_05c4:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
				object obj16 = default;
				object obj17 = default;
				if (obj16 != obj17)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
				_003C_003Em__Finally1();
				object obj18 = default;
				if (obj18 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_06b9;
			}
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0007: Expected I4, but got F4
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
		}
	}

	private sealed class _003CUnloadBundlesCoroutine_003Ed__69(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b73: Expected Obj, but got Unknown
				//IL_0b7c: Expected Obj, but got I4
				//IL_0b91: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b96: Expected Obj, but got Unknown
				//IL_0b9f: Expected Obj, but got I4
				//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bad: Expected Obj, but got Unknown
				//IL_0bb6: Expected Obj, but got I4
				//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
				//IL_0bca: Expected Obj, but got Unknown
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Expected Obj, but got Unknown
				//IL_0c07: Expected Obj, but got I4
				//IL_00a4: Expected Obj, but got I
				//IL_0154: Expected Obj, but got I4
				//IL_0389: Unknown result type (might be due to invalid IL or missing references)
				//IL_038e: Expected Obj, but got Unknown
				//IL_0262: Expected I, but got Obj
				//IL_0278: Expected Obj, but got I
				//IL_08d0: Expected Obj, but got I
				//IL_02a3: Expected I, but got Obj
				//IL_0906: Unknown result type (might be due to invalid IL or missing references)
				//IL_090b: Expected Obj, but got Unknown
				//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
				//IL_09c8: Expected Obj, but got Unknown
				//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_09d6: Expected Obj, but got Unknown
				//IL_0a02: Expected Obj, but got I4
				//IL_093c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0941: Expected Obj, but got Unknown
				//IL_0ac1: Expected Obj, but got I
				//IL_0aff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b04: Expected Obj, but got Unknown
				//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
				//IL_0b3a: Expected Obj, but got Unknown
				//IL_07f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_07f6: Expected Obj, but got Unknown
				//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0804: Expected Obj, but got Unknown
				//IL_0830: Expected Obj, but got I4
				//IL_0839: Expected Obj, but got I4
				object obj2 = default;
				object obj = obj2 + 80;
				object obj3 = obj2 + 56;
				obj3 = 0;
				_ = 0;
				_ = 0;
				object obj4 = obj2 + 24;
				obj4 = 0;
				object obj5 = obj2 + 40;
				obj5 = 0;
				_ = 0;
				object obj6 = obj2 + 32;
				obj6 = obj;
				_ = -1;
				AssetBundleManager assetBundleManager = _003C_003E4__this;
				object obj19;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Dictionary<string, bool> pendingUnloads = assetBundleManager._pendingUnloads;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v39 (System.Collections.Generic.Dictionary`2<System.String, System.Boolean>)+10]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v39 (System.Collections.Generic.Dictionary`2<System.String, System.Boolean>)+1C]");
						object obj7 = num - 0;
						if ((nint)obj7 > 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							List<string> list = default;
							list._002Ector();
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
							obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
							_ = 0;
							object obj8 = default;
							object obj9 = default;
							object obj10 = default;
							object obj12 = default;
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
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								if (obj9 != null)
								{
									continue;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
								if (obj10 != null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									nint num2 = (nint)typeof(UnityEngine.Object);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ S0_v245 (Il2CppClass<UnityEngine.Object>)+BA]");
									object obj11 = (nint)0 & (nint)0x200;
									if (obj11 != null)
									{
										nint num3 = (nint)typeof(UnityEngine.Object);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ S0_v277 (Il2CppClass<UnityEngine.Object>)+74]");
										if ((nint)0 == 0)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									if (obj12 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
							}
							object obj13 = 40;
							object obj14 = obj13 - 12;
							object obj20;
							object obj22;
							object obj23 = default;
							if ((nint)obj13 != 12 && (nint)obj14 != 1 && (nint)obj14 != 2 && (nint)obj14 != 3)
							{
								if ((nint)obj14 == 4 || (nint)obj14 == 5 || (nint)obj14 == 6)
								{
									goto IL_0b56;
								}
								if ((nint)obj14 != 7)
								{
									if ((nint)obj14 == 8 || (nint)obj14 == 9 || (nint)obj14 == 10 || (nint)obj14 == 11)
									{
										goto IL_0b56;
									}
									if ((nint)obj14 != 12)
									{
										if ((nint)obj14 == 13 || (nint)obj14 == 14)
										{
											goto IL_0b56;
										}
										if ((nint)obj14 != 15)
										{
											if ((nint)obj14 == 16 || (nint)obj14 == 17 || (nint)obj14 == 18 || (nint)obj14 == 19 || (nint)obj14 == 20 || (nint)obj14 == 21 || (nint)obj14 == 22)
											{
												goto IL_0b56;
											}
											if ((nint)obj14 != 23)
											{
												if ((nint)obj14 != 24)
												{
													if ((nint)obj14 != 25)
													{
														if ((nint)obj14 != 26)
														{
															if ((nint)obj14 != 27)
															{
																if ((nint)obj14 != 28)
																{
																	goto IL_0b56;
																}
																object obj15 = obj6 + 4;
																object obj16 = obj15 + 1;
																obj15 = obj16;
																object obj17 = obj16 << 2;
																object obj18 = obj6 + obj17;
																obj18 = 241;
																obj19 = 0;
																goto IL_0895;
															}
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj21 = default;
															obj20 = obj21;
															obj22 = obj23;
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
															object obj24 = default;
															obj20 = obj24;
															obj22 = obj23;
														}
													}
													else
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
														object obj25 = default;
														obj20 = obj25;
														obj22 = obj23;
													}
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
													object obj26 = default;
													obj20 = obj26;
													obj22 = obj23;
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
												object obj27 = default;
												obj20 = obj27;
												obj22 = obj23;
											}
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
											object obj28 = default;
											obj20 = obj28;
											obj22 = obj23;
										}
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj29 = default;
										obj20 = obj29;
										obj22 = obj23;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj30 = default;
									obj20 = obj30;
									obj22 = obj23;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj31 = default;
								obj20 = obj31;
								obj22 = obj23;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
							object obj32 = default;
							if (obj22 == obj32)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
								object obj33 = default;
								obj19 = obj33;
								goto IL_0895;
							}
							object obj34 = obj20;
							goto IL_0b56;
						}
					}
				}
				else
				{
					_003C_003E1__state = -1;
					object obj35 = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					object obj36 = default;
					obj35 = obj36;
					_003C_003E1__state = 1;
				}
				goto IL_0c01;
				IL_0b56:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
				goto IL_0c01;
				IL_0895:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
					object obj37 = (nint)0 << 2;
					object obj38 = obj6 + obj37;
					if ((nint)obj38 == 241)
					{
						object obj39 = obj6 + 4;
						if ((nint)obj39 > -1)
						{
							object obj40 = obj39 + -1;
							obj39 = obj40;
						}
						goto IL_0ca0;
					}
				}
				if (obj19 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
				}
				goto IL_0ca0;
				IL_0c01:
				return 1;
				IL_0ca0:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @727C");
				obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				_ = 0;
				object obj41 = default;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					if (obj41 == null)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				}
				object obj42 = obj6 + 4;
				object obj43 = obj42 + 1;
				obj42 = obj43;
				object obj44 = obj43 << 2;
				object obj45 = obj6 + obj44;
				obj45 = 299;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v21+4]");
					object obj46 = (nint)0 << 2;
					object obj47 = obj6 + obj46;
					if ((nint)obj47 == 299)
					{
						object obj48 = obj6 + 4;
						if ((nint)obj48 > -1)
						{
							object obj49 = obj48 + -1;
							obj48 = obj49;
						}
						goto IL_0c01;
					}
				}
				if (obj19 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					goto IL_0b56;
				}
				goto IL_0c01;
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
			object obj = _003C_003E2__current;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			bool result = default;
			return result;
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

	private sealed class _003CDownloadAllAssetBundles_003Ed__76(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public AssetBundleManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0105: Expected Obj, but got I4
				//IL_006a: Expected Obj, but got I
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Expected Obj, but got Unknown
				//IL_00c7: Expected Obj, but got I4
				//IL_00e7: Expected Obj, but got I4
				object bundleName = 0;
				AssetBundleManager assetBundleManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state != 1)
					{
						return null;
					}
					_003C_003E1__state = -1;
				}
				else
				{
					_003C_003E1__state = -1;
					_ = 1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (AssetBundleManager)+28]");
				if (Enumerable.Any((IEnumerable<KeyValuePair<string, int>>)0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BD85");
					object obj = this + 12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					bool flag = ((AssetBundleVersionControl)(object)assetBundleManager).IsBundleVersionShipped((string)bundleName, 0);
					Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])flag);
					obj = coroutine;
					_003C_003E1__state = 1;
					return 1;
				}
				_ = 0;
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

	private sealed class _003CDownloadAssetBundle_003Ed__77(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string bundleName;

		public AssetBundleManager _003C_003E4__this;

		public int version;

		private bool _003CdownloadSuccessful_003E5__2;

		private IRequest _003Crequest_003E5__3;

		unsafe object IEnumerator<object>.Current
		{
			get
			{
				//IL_0740: Unknown result type (might be due to invalid IL or missing references)
				//IL_0745: Expected VT, but got Unknown
				//IL_074e: Expected Obj, but got I4
				//IL_0044: Expected I4, but got Obj
				//IL_0056: Expected I, but got Obj
				//IL_006c: Expected Obj, but got I
				//IL_0794: Expected I, but got Obj
				//IL_07aa: Expected Obj, but got I
				//IL_07fe: Expected I4, but got Obj
				//IL_0097: Expected I, but got Obj
				//IL_013a: Expected I, but got Obj
				//IL_0150: Expected Obj, but got I
				//IL_00e4: Expected I, but got Obj
				//IL_081a: Expected I4, but got Obj
				//IL_0831: Expected I4, but got Obj
				//IL_01d5: Expected I, but got Obj
				//IL_01eb: Expected Obj, but got I
				//IL_017b: Expected I, but got Obj
				//IL_045f: Expected I, but got Obj
				//IL_0475: Expected Obj, but got I
				//IL_084a: Unknown result type (might be due to invalid IL or missing references)
				//IL_084f: Expected Obj, but got Unknown
				//IL_0914: Expected I, but got Obj
				//IL_092a: Expected Obj, but got I
				//IL_025d: Expected Obj, but got VT
				//IL_0274: Expected I4, but got Obj
				//IL_026f: Expected native int or pointer, but got VT
				//IL_0289: Expected Obj, but got I
				//IL_0284: Expected native int or pointer, but got VT
				//IL_028f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0294: Expected Obj, but got Unknown
				//IL_0216: Expected I, but got Obj
				//IL_04a0: Expected I, but got Obj
				//IL_034e: Expected I, but got Obj
				//IL_0364: Expected Obj, but got I
				//IL_02c9: Expected Obj, but got I4
				//IL_04ed: Expected I, but got Obj
				//IL_0897: Expected I4, but got Obj
				//IL_08b1: Expected I4, but got Obj
				//IL_08b1: Expected I4, but got Obj
				//IL_038f: Expected I, but got Obj
				//IL_0410: Expected Obj, but got I4
				object obj = default;
				WebClient.SendOptions sendOptions = (WebClient.SendOptions)(obj + 16);
				obj = 0;
				_ = 0;
				AssetBundleManager assetBundleManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj2 = default;
						if (obj2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
							object obj3 = default;
							if (obj3 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
								nint num = (nint)typeof(CompressionExtensions);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ S1_v127 (Il2CppClass<Kiloo.CompressionExtensions>)+BA]");
								object obj4 = (nint)0 & (nint)0x200;
								if (obj4 != null)
								{
									nint num2 = (nint)typeof(CompressionExtensions);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S1_v144 (Il2CppClass<Kiloo.CompressionExtensions>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								BinaryReader reader = default;
								IDictionary dictionary = BsonBinaryReaderExtensions.ReadBsonObject(reader, (byte)(int)"subway_bundles" != 0);
								string[] referencedAssetBundleNames = ((Factories)null).GetReferencedAssetBundleNames((Characters.CharacterId)bundleName, version, (byte)(int)dictionary != 0);
								if (referencedAssetBundleNames != null)
								{
									_003CdownloadSuccessful_003E5__2 = true;
									int succesfullyDownloaded = assetBundleManager.succesfullyDownloaded + 1;
									assetBundleManager.succesfullyDownloaded = succesfullyDownloaded;
									((AssetBundleVersionControl)(object)_003C_003E4__this).CreateAvailableBundlesVersionInfo((Dictionary<string, int>)(object)bundleName, (Dictionary<string, int>)version);
								}
								else
								{
									((AssetBundleManager)null).DebugRequestStatus("Attempt to cache downloaded bundle from the server failed.");
								}
								goto IL_06e3;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						object obj5 = default;
						if (obj5 != null)
						{
							nint num3 = (nint)typeof(DeviceUtility);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S0_v95 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
							object obj6 = (nint)0 & (nint)0x200;
							if (obj6 != null)
							{
								nint num4 = (nint)typeof(DeviceUtility);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ S0_v137 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							string unfilteredLocale = DeviceUtility.GetUnfilteredLocale();
							nint num5 = (nint)typeof(Utils);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ S1_v66 (Il2CppClass<Utils>)+BA]");
							object obj7 = (nint)0 & (nint)0x200;
							if (obj7 != null)
							{
								nint num6 = (nint)typeof(Utils);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ S1_v116 (Il2CppClass<Utils>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							bool flag = Utils.IsEnum((Type)(object)unfilteredLocale);
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							throw new ArrayTypeMismatchException();
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						string text2 = default;
						string text = "Attempt to download from the server failed. Error message: " + text2;
						((AssetBundleManager)null).DebugRequestStatus(text);
						goto IL_06e3;
					}
					return null;
				}
				_003C_003E1__state = -1;
				string message = string.ConcatArray((string[])(object)"pending: ", (int)bundleName);
				nint num7 = (nint)typeof(Debug);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S1_v12 (Il2CppClass<UnityEngine.Debug>)+BA]");
				object obj8 = (nint)0 & (nint)0x200;
				if (obj8 != null)
				{
					nint num8 = (nint)typeof(Debug);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S1_v44 (Il2CppClass<UnityEngine.Debug>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Debug.LogError(message);
				nint num9 = (nint)typeof(OnlineSettings);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ S0_v22 (Il2CppClass<Info.OnlineSettings>)+BA]");
				object obj9 = (nint)0 & (nint)0x200;
				if (obj9 != null)
				{
					nint num10 = (nint)typeof(OnlineSettings);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ S0_v72 (Il2CppClass<Info.OnlineSettings>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string saveDataPath = OnlineSettings.GetSaveDataPath();
				_003CdownloadSuccessful_003E5__2 = false;
				string editorBundlesPath = _003C_003E4__this.GetEditorBundlesPath(bundleName);
				string message2 = string.ConcatArray((string[])(object)"url: ", (int)editorBundlesPath);
				Debug.LogError(message2);
				nint num11 = (nint)typeof(AssetBundleManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ S0_v35 (Il2CppClass<AssetBundleManager>)+BA]");
				object obj10 = (nint)0 & (nint)0x200;
				if (obj10 != null)
				{
					nint num12 = (nint)typeof(AssetBundleManager);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S0_v66 (Il2CppClass<AssetBundleManager>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				float startOffset = ((LayoutGroup)(object)saveDataPath).GetStartOffset((int)"asset_bundle_request_timeout", _requestDownloadTimeout);
				float startOffset2 = ((LayoutGroup)(object)saveDataPath).GetStartOffset((int)"asset_bundle_request_max_backoff_time", _requestMaxBackoffTime);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Uri uri = default;
				uri.CreateThisFromUri((Uri)(object)editorBundlesPath);
				nint num13 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ S0_v47 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num14 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ S0_v62 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				object obj12 = this + 32;
				IRequest request = WebClient.CreatePut(uri);
				IRequest request2 = RequestExtensions.WithKeepAlive(request, startOffset);
				Wait.Config.TimeConfig timeConfig = ((Wait.Config)request2).For(startOffset2);
				obj12 = timeConfig;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39CF");
				((WebClient.SendOptions*)(nint)sendOptions)->disableCache = (byte)(int)obj != 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
				System.Runtime.CompilerServices.Unsafe.Write(&((WebClient.SendOptions*)(nint)sendOptions)->simulatedRequestResults, (IList<SimulatedRequestResult>)0);
				object obj13 = this + 12;
				Coroutine coroutine = WebClient.RequestAsync(_003Crequest_003E5__3, null, sendOptions);
				obj13 = coroutine;
				_003C_003E1__state = 1;
				return 1;
				IL_06e3:
				if (~(_003CdownloadSuccessful_003E5__2 ? 1u : 0u) != 0)
				{
					_003C_003E4__this.ResolveDownloadRequest(bundleName, version);
				}
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

	public const string COMPRESSION_SIGNATURE = "subway_bundles";

	private const string ASSET_BUNDLE_RESOURCES_PATH = "AssetBundles";

	private const string ASSET_BUNDLES_ROOT_PATH = "..\\..\\AssetBundles";

	private const string EDITOR_ASSET_BUNDLE_CACHE_PATH = "..\\EditorCache";

	private const string UNCOMPRESSED_ASSET_BUNDLE_ANDROID_FOLDER = "android";

	private const string UNCOMPRESSED_ASSET_BUNDLE_IOS_FOLDER = "ios";

	private const string UNCOMPRESSED_ASSET_BUNDLE_STANDALONE_FOLDER = "standalone";

	private const string TEMPORARY_EDITOR_ASSET_BUNDLE_FOLDER = "Temp";

	private const string DEBUG_TAG = "[AssetBundleManager]: ";

	private const char VALUE_SEPARATOR = '-';

	private const char ITEM_SEPARATOR = ',';

	private const string ASSET_BUNDLE_SERVER_URL_OS_KEY = "asset_bundle_server";

	private const string ASSET_BUNDLE_SERVER_IOS_FOLDER_OS_KEY = "asset_bundle_server_ios_folder";

	private const string ASSET_BUNDLE_SERVER_ANDROID_FOLDER_OS_KEY = "asset_bundle_server_android_folder";

	private const string ASSET_BUNDLE_REQUEST_TIMEOUT_OS_KEY = "asset_bundle_request_timeout";

	private const string ASSET_BUNDLE_REQUEST_MAX_BACKOFF_TIME_OS_KEY = "asset_bundle_request_max_backoff_time";

	private const string ASSET_BUNDLE_DOWNLOAD_REST_TIME_OS_KEY = "asset_bundle_download_rest_time";

	private const string ASSET_BUNDLE_IS_USING_EXTENSION_OS_KEY = "asset_bundle_using_extension";

	private const string ASSET_BUNDLE_EXTENSION_OS_KEY = "asset_bundle_extension";

	private const int SIMULTANEOUS_CHARACTER_BUNDLE_REQUESTS_LOW = 3;

	private const int SIMULTANEOUS_CHARACTER_BUNDLE_REQUESTS_HIGH = 6;

	private static string _assetBundleBaseServerUrl;

	private static string _serverDirIos;

	private static string _serverDirAndroid;

	private static string _serverDirGenerated;

	private static float _requestDownloadTimeout;

	private static float _requestMaxBackoffTime;

	private static float _downloadAttemptRestTime;

	private static bool _usingBundleExtension;

	private static string _assetBundleExtension;

	private AssetBundleVersionControl _versionControl;

	private List<string> _assetBundlesLoading;

	private Dictionary<string, AssetBundle> _loadedAssetBundles;

	private Dictionary<string, bool> _pendingUnloads;

	private List<KeyValuePair<string, Action<AssetBundle>>> _pendingRequests;

	private List<CharacterModelRequest.CharacterBundleRequest> _pendingCharacterBundleRequests;

	private List<CharacterModelRequest.CharacterBundleRequest> _activeCharacterBundleRequests;

	private int _simultaneousCharacterBundleRequests;

	private Dictionary<string, int> _pendingDownloads;

	private bool _isDownloading;

	private float _lastInitializedDownloads;

	private bool _downloadableBundlesUpdated;

	private IEnumerator _currentDownloaderCoroutine;

	private static AssetBundleManager _instance;

	private bool _delayedAvailabilityCheck;

	private int attemptingToPrecacheAmount;

	private int succesfullyPrecached;

	private int attemptingToDownloadAmount;

	private int succesfullyDownloaded;

	public unsafe static AssetBundleManager Instance
	{
		get
		{
			bool flag = OfferWallManager._instance == null;
			bool flag2 = !flag;
			string result = (string)(object)OfferWallManager._instance;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				string text = default;
				AssetBundleCache.Log(text);
				OfferWallManager._instance = (OfferWallManager)(object)text;
				result = text;
			}
			return (AssetBundleManager)(object)result;
		}
		private set
		{
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			//IL_0526: Expected Obj, but got Unknown
			//IL_001b: Expected Obj, but got I
			//IL_002b: Expected Obj, but got I
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected Obj, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected Obj, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected Obj, but got Unknown
			//IL_008f: Expected Obj, but got I
			//IL_009f: Expected Obj, but got I
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected Obj, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected Obj, but got Unknown
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected Obj, but got Unknown
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected Obj, but got Unknown
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Expected Obj, but got Unknown
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected Obj, but got Unknown
			//IL_018a: Expected I, but got Obj
			//IL_01a0: Expected Obj, but got I
			//IL_0562: Expected I, but got Obj
			//IL_0578: Expected Obj, but got I
			//IL_074a: Expected I, but got Obj
			//IL_0760: Expected Obj, but got I
			//IL_01cb: Expected I, but got Obj
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a3: Expected Obj, but got Unknown
			//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Expected Obj, but got Unknown
			//IL_0611: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Expected Obj, but got Unknown
			//IL_0218: Expected I, but got Obj
			//IL_0265: Expected I, but got Obj
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Expected Obj, but got Unknown
			//IL_030b: Expected I, but got Obj
			//IL_0321: Expected Obj, but got I
			//IL_066f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0674: Expected Obj, but got Unknown
			//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c5: Expected Obj, but got Unknown
			//IL_03db: Expected I, but got Obj
			//IL_03f1: Expected Obj, but got I
			//IL_034c: Expected I, but got Obj
			//IL_06c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cd: Expected Obj, but got Unknown
			//IL_0472: Expected I, but got Obj
			//IL_0488: Expected Obj, but got I
			//IL_041c: Expected I, but got Obj
			//IL_04b3: Expected I, but got Obj
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<string> list = default;
			list._002Ector();
			object obj = value + 12;
			obj = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S3_v2 (Il2CppMethodInfo)+C]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S3_v3+60]");
			object obj3 = 0;
			object obj4 = obj3;
			object obj5 = obj4 & 0x1FFF;
			object obj6 = obj5 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v39 @ S4_v4 (should have been resolved before IL gen)");
			object obj7 = value + 16;
			object obj8 = default;
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S3_v7 (Il2CppMethodInfo)+C]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ S3_v8+60]");
			object obj10 = 0;
			object obj11 = obj10;
			object obj12 = obj11 & 0x1FFF;
			object obj13 = obj12 + 113696;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v62 @ S4_v8 (should have been resolved before IL gen)");
			object obj14 = value + 20;
			object obj15 = default;
			obj14 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BB79");
			object obj16 = value + 24;
			object obj17 = default;
			obj16 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<CharacterModelRequest.CharacterBundleRequest> list2 = default;
			list2._002Ector();
			object obj18 = value + 28;
			obj18 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			List<CharacterModelRequest.CharacterBundleRequest> list3 = default;
			list3._002Ector();
			object obj19 = value + 32;
			obj19 = list3;
			value._simultaneousCharacterBundleRequests = 3;
			nint num3 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ S0_v37 (Il2CppClass<AssetBundleManager>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num4 = (nint)typeof(AssetBundleManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ S0_v139 (Il2CppClass<AssetBundleManager>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float lastInitializedDownloads = 0f - _downloadAttemptRestTime;
			value._lastInitializedDownloads = lastInitializedDownloads;
			nint num5 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S0_v43 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj21 = (nint)0 & (nint)0x200;
			if (obj21 != null)
			{
				nint num6 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ S0_v135 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			AssetBundleCache.StartBulkCaching();
			nint num7 = (nint)typeof(AssetBundleVersionControl);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v49 (Il2CppClass<AssetBundleVersionControl>)+BA]");
			object obj22 = (nint)0 & (nint)0x200;
			if (obj22 != null)
			{
				nint num8 = (nint)typeof(AssetBundleVersionControl);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v131 (Il2CppClass<AssetBundleVersionControl>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			object obj23 = value + 8;
			string versionInfoFilePath = AssetBundleVersionControl.GetVersionInfoFilePath();
			obj23 = versionInfoFilePath;
			AssetBundleVersionControl versionControl = value._versionControl;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr = 0;
			Delegate obj24 = default;
			obj24.method_ptr = method_ptr;
			obj24.method = (nint)__ldftn(AssetBundleManager.OnDownloadableAssetBundlesUpdated);
			object obj25 = obj24 + 16;
			obj25 = value;
			object obj26 = value._versionControl + 32;
			Delegate obj27 = ((Delegate)versionControl.OnDownloadableAssetBundlesUpdated).CombineImpl(obj24);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7289");
			object obj28 = default;
			obj26 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			Action action = default;
			((Delegate)action).method_ptr = method_ptr2;
			((Delegate)action).method = (nint)__ldftn(AssetBundleManager.StopAssetbundlesDownload);
			object obj29 = action + 16;
			obj29 = value;
			nint num9 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ S0_v73 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj30 = (nint)0 & (nint)0x200;
			if (obj30 != null)
			{
				nint num10 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S0_v127 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Game.OnGameStarted -= action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr3 = 0;
			Action action2 = default;
			((Delegate)action2).method_ptr = method_ptr3;
			((Delegate)action2).method = (nint)__ldftn(AssetBundleManager.ResumeAssetBundlesDownload);
			object obj31 = action2 + 16;
			obj31 = value;
			Game.OnMenuScreenShown -= action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr4 = 0;
			Action action3 = default;
			((Delegate)action3).method_ptr = method_ptr4;
			((Delegate)action3).method = (nint)__ldftn(AssetBundleManager.OnEventChanged);
			object obj32 = action3 + 16;
			obj32 = value;
			nint num11 = (nint)typeof(SSEventsManagerController);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ S0_v92 (Il2CppClass<SSEventsManagerController>)+BA]");
			object obj33 = (nint)0 & (nint)0x200;
			if (obj33 != null)
			{
				nint num12 = (nint)typeof(SSEventsManagerController);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ S0_v123 (Il2CppClass<SSEventsManagerController>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			SSEventsManagerController.OnSSEventChangedHandler -= action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr5 = 0;
			Action action4 = default;
			((Delegate)action4).method_ptr = method_ptr5;
			((Delegate)action4).method = (nint)__ldftn(AssetBundleManager.DelayedAvailabilityCheck);
			object obj34 = action4 + 16;
			obj34 = value;
			Game.OnMenuScreenShown -= action4;
			value.OnDownloadableAssetBundlesUpdated();
			nint num13 = (nint)typeof(DeviceInfo);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ S0_v106 (Il2CppClass<DeviceInfo>)+BA]");
			object obj35 = (nint)0 & (nint)0x200;
			if (obj35 != null)
			{
				nint num14 = (nint)typeof(DeviceInfo);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ S0_v119 (Il2CppClass<DeviceInfo>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int runAverageFPS = InRunAverageFPSCounter.runAverageFPS;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ S0_v111 (System.Int32)+8]");
			if ((nint)0 > (nint)0)
			{
				value._simultaneousCharacterBundleRequests = 6;
			}
			IEnumerator<float> list4 = value.CacheNeededAssetBundles();
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)list4);
		}
	}

	private AssetBundleManager()
	{
		//IL_0010: Expected I4, but got Obj
		string msg = string.ConcatArray((string[])(object)"[AssetBundleCache]: ", (int)this);
		SDebug.LogFormat(msg, null);
	}

	private string GetAssetBundlesServerURL(string bundleName)
	{
		//IL_01eb: Expected I, but got Obj
		//IL_0201: Expected Obj, but got I
		//IL_0281: Expected I4, but got Obj
		//IL_015d: Expected I, but got Obj
		//IL_0173: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_019e: Expected I, but got Obj
		//IL_022c: Expected I, but got Obj
		//IL_0242: Expected Obj, but got I
		//IL_02b6: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		//IL_0136: Expected Obj, but got I4
		//IL_00ee: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (AssetBundleCache.RemoveFromCache((string)(object)this, (int)bundleName))
		{
			nint num3 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v18 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v28 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S1_v18 (Il2CppClass<System.IO.Path>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num6 = (nint)typeof(Path);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S1_v25 (Il2CppClass<System.IO.Path>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = Path.SameRoot(AssetBundleCache.ASSET_BUNDLE_CACHE_PATH, (string)(object)this);
			((FileStream)flag).ExposeHandle();
			UnloadAssetBundle(bundleName, unloadAllLoadedObjects: true);
			return (string)1;
		}
		object obj4 = ((IConvertible)"Attempting to remove bundle ").ToType((Type)(object)this, (IFormatProvider)(object)" but it's not cached.");
		nint num7 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ S1_v7 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num8 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ S1_v12 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		((AssetBundleManager)obj4)._002Ector();
		return null;
	}

	private string GetEditorBundlesPath(string bundleName)
	{
		//IL_0694: Expected I, but got Obj
		//IL_06aa: Expected Obj, but got I
		//IL_0934: Expected I, but got Obj
		//IL_094a: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v129 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		nint num3 = (nint)typeof(DeviceUtility);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S0_v19 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(DeviceUtility);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S0_v125 (Il2CppClass<Kiloo.Common.Plugins.DeviceUtility.DeviceUtility>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string bundleIdentifier = DeviceUtility.GetBundleIdentifier();
		throw new ArrayTypeMismatchException();
	}

	public static string GetAssetBundlesCachePath()
	{
		//IL_0130: Expected I, but got Obj
		//IL_0146: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0078: Expected I, but got Obj
		//IL_008e: Expected Obj, but got I
		//IL_00ab: Expected I, but got Obj
		//IL_0179: Expected Obj, but got I
		//IL_00c7: Expected I, but got Obj
		//IL_00f7: Expected I, but got Obj
		//IL_011d: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v34 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = _instance == null;
		bool flag2 = !flag;
		string result = (string)(object)_instance;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			AssetBundleManager assetBundleManager = default;
			Instance = assetBundleManager;
			nint num3 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v20 (Il2CppClass<AssetBundleManager>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			bool flag3 = obj2 == null;
			nint num4 = (nint)typeof(AssetBundleManager);
			if (!flag3)
			{
				nint num5 = (nint)typeof(AssetBundleManager);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v28 (Il2CppClass<AssetBundleManager>)+74]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				num4 = (nint)typeof(AssetBundleManager);
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					num4 = (nint)typeof(AssetBundleManager);
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ L0_v6 (Il2CppClass<AssetBundleManager>)+5C]");
			object obj3 = (nint)0 + (nint)36;
			obj3 = assetBundleManager;
			result = (string)(object)assetBundleManager;
		}
		return result;
	}

	private static string GetAbsolutePath(string path)
	{
		//IL_00fc: Expected I, but got Obj
		//IL_0112: Expected Obj, but got I
		//IL_0169: Expected Obj, but got I
		//IL_0179: Expected Obj, but got I
		//IL_0189: Expected Obj, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected Obj, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected Obj, but got Unknown
		//IL_00e9: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0149: Expected Obj, but got I4
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v32 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S2_v3+60]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ S2_v4+44]");
		object obj4 = 0;
		object obj5 = obj4 & 0x1FFF;
		object obj6 = obj5 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v43 @ S3_v4 (should have been resolved before IL gen)");
		object obj7 = default;
		if ((nint)obj7 > -1)
		{
			nint num4 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v18 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj8 = (nint)0 & (nint)0x200;
			if (obj8 != null)
			{
				nint num5 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v26 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			int num6 = AssetBundleCache._cachedBundlesVersionInfo.get_Item(path);
			return (string)num6;
		}
		return (string)(-1);
	}

	public void GetAssetBundle(string bundleName, Action<AssetBundle> requestResultHandler, bool asynchronous = false)
	{
	}

	private void RequestAssetBundle(string bundleName, Action<AssetBundle> requestResultHandler, bool asynchronous = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected VT, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected Obj, but got Unknown
		//IL_026d: Expected Obj, but got I4
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected Obj, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected Obj, but got Unknown
		//IL_02a0: Expected Obj, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_007f: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 + 48;
		KeyValuePair<string, Action<AssetBundle>> keyValuePair = (KeyValuePair<string, Action<AssetBundle>>)(obj2 + 32);
		object obj3 = obj2 + 8;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = obj;
		_ = -1;
		object obj5 = obj2 + 24;
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @108D8");
		object obj6 = default;
		if (obj6 != null)
		{
			requestResultHandler((AssetBundle)obj5);
		}
		else if (_assetBundlesLoading.Contains(bundleName))
		{
			obj3 = bundleName;
			object obj7 = obj3 + 4;
			obj7 = requestResultHandler;
			obj2 = obj3;
			keyValuePair = (KeyValuePair<string, Action<AssetBundle>>)obj2;
			_pendingRequests.Add(keyValuePair);
		}
		else
		{
			_assetBundlesLoading.Add(bundleName);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C");
		}
	}

	private IEnumerator LoadAssetBundleAsync(string bundleName, int cachedVersion, Action<AssetBundle> requestResultHandler)
	{
		//IL_00b7: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0029: Expected Obj, but got I
		//IL_00e7: Expected I4, but got Obj
		//IL_00eb: Expected Obj, but got I4
		//IL_0054: Expected I, but got Obj
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object arg = default;
		string text = string.Format((IFormatProvider)(object)"provider_{0}_{1}_minimum_device_version", (string)cachedVersion, arg);
		string productIds = text.ToLowerInvariant();
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ S0_v17 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ S0_v24 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		return (IEnumerator)((InAppManager)(object)saveDataPath).RestoreNonConsumablePurchases((string[])(object)productIds, (byte)(int)requestResultHandler != 0);
	}

	private void OnRequestFinished(string bundleName, AssetBundle assetBundle, Action<AssetBundle> requestResultHandler)
	{
		//IL_0327: Expected I, but got Obj
		//IL_033d: Expected Obj, but got I
		//IL_00d9: Expected I4, but got Obj
		//IL_0013: Expected I, but got Obj
		//IL_0285: Expected I, but got Obj
		//IL_029b: Expected Obj, but got I
		//IL_0120: Expected I4, but got Obj
		//IL_03d6: Expected I4, but got Obj
		//IL_03ec: Expected I4, but got Obj
		//IL_03ec: Expected I4, but got Obj
		//IL_025c: Expected I4, but got Obj
		//IL_0269: Expected Obj, but got I4
		//IL_0202: Expected I4, but got Obj
		//IL_02c6: Expected I, but got Obj
		//IL_0228: Expected I4, but got Obj
		//IL_0162: Expected I4, but got Obj
		//IL_0162: Expected I4, but got Obj
		//IL_0174: Expected I, but got Obj
		//IL_018a: Expected Obj, but got I
		//IL_01b5: Expected I, but got Obj
		int availableShippedVersionForBundle = _versionControl.GetAvailableShippedVersionForBundle(bundleName);
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v66 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string absolutePath = GetAbsolutePath(bundleName);
		if (availableShippedVersionForBundle > -1)
		{
			if (availableShippedVersionForBundle > (nint)absolutePath)
			{
				Sound sound = ((So)(object)_versionControl).playSound((AudioClipInfo)(object)bundleName, (byte)availableShippedVersionForBundle != 0);
				if (sound == null)
				{
					DownloadFailedFor(bundleName, availableShippedVersionForBundle);
				}
			}
		}
		else
		{
			string bundleName2 = string.ConcatArray((string[])(object)"No version information exists for bundle :", (int)bundleName);
			((AssetBundleManager)null).DebugRequestStatus(bundleName2);
		}
		bool flag = (nint)absolutePath > -1;
		string text = absolutePath;
		if (!flag)
		{
			Dictionary<string, int> dictionary = _versionControl.ReadAssetBundleManifest((byte)(int)bundleName != 0);
			if ((nint)dictionary >= 0)
			{
				string[] referencedAssetBundleNames = ((Factories)null).GetReferencedAssetBundleNames((Characters.CharacterId)bundleName, (int)dictionary, false);
				nint num3 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ S0_v46 (Il2CppClass<AssetBundleCache>)+BA]");
				object obj2 = (nint)0 & (nint)0x200;
				if (obj2 != null)
				{
					nint num4 = (nint)typeof(AssetBundleCache);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ S0_v53 (Il2CppClass<AssetBundleCache>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				string absolutePath2 = GetAbsolutePath(bundleName);
				bool flag2 = (nint)absolutePath2 >= 0;
				text = absolutePath2;
				if (flag2)
				{
					goto IL_022d;
				}
			}
			string bundleName3 = string.ConcatArray((string[])(object)"No cached version available for bundle: ", (int)bundleName);
			((AssetBundleManager)null).DebugRequestStatus(bundleName3);
			CharacterCustomizationAssetsFactory.GetAssetPrefab((string)(object)this, (int)bundleName, asynchronous: false, (Action<CharacterCustomizationBundle>)(object)assetBundle);
			return;
		}
		goto IL_022d;
		IL_022d:
		if (requestResultHandler != null)
		{
			bool flag3 = CacheAssetBundle(bundleName, (int)text, (byte[])(object)assetBundle);
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])flag3);
			return;
		}
		nint num5 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ S0_v24 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj3 = (nint)0 & (nint)0x200;
		if (obj3 != null)
		{
			nint num6 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v29 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleCreateRequest assetBundleCreateRequest = AssetBundleCache.LoadAssetBundleAsync(bundleName, (int)text);
		CharacterCustomizationAssetsFactory.GetAssetPrefab((string)(object)this, (int)bundleName, (byte)(int)assetBundleCreateRequest != 0, (Action<CharacterCustomizationBundle>)(object)assetBundle);
	}

	private IEnumerator ProcessCharacterBundleRequests()
	{
		//IL_0312: Expected Obj, but got I4
		//IL_031b: Expected Obj, but got I4
		//IL_03d7: Expected I, but got Obj
		//IL_03ed: Expected Obj, but got I
		//IL_002d: Expected I, but got Obj
		//IL_013f: Expected I, but got Obj
		//IL_0155: Expected Obj, but got I
		//IL_007a: Expected I, but got Obj
		//IL_0090: Expected Obj, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected Obj, but got Unknown
		//IL_039d: Expected I, but got Obj
		//IL_03b3: Expected Obj, but got I
		//IL_0180: Expected I, but got Obj
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_00bb: Expected I, but got Obj
		//IL_01cd: Expected I, but got Obj
		//IL_01e3: Expected Obj, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected Obj, but got Unknown
		//IL_0470: Expected I, but got Obj
		//IL_0486: Expected Obj, but got I
		//IL_020e: Expected I, but got Obj
		string persistentDataPath = Application.persistentDataPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num = default;
		object obj = num + 16;
		obj = 92;
		string source = ((string)this).Substring(num);
		List<string> source2 = Enumerable.ToList((IEnumerable<string>)(object)source);
		string text = persistentDataPath;
		Func<string, bool> func = default;
		object obj6 = default;
		object obj7 = default;
		string text2 = default;
		while (true)
		{
			nint num2 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v16 (Il2CppClass<AssetBundleManager+<>c>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num3 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v126 (Il2CppClass<AssetBundleManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool flag = _003C_003Ec._003C_003E9__51_1 == null;
			bool flag2 = !flag;
			Func<string, bool> predicate = _003C_003Ec._003C_003E9__51_1;
			if (!flag2)
			{
				nint num4 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ S0_v100 (Il2CppClass<AssetBundleManager+<>c>)+BA]");
				object obj3 = (nint)0 & (nint)0x200;
				if (obj3 != null)
				{
					nint num5 = (nint)typeof(_003C_003Ec);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v120 (Il2CppClass<AssetBundleManager+<>c>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num6 = 0;
				_ = 0;
				object obj4 = func + 16;
				obj4 = _003C_003Ec._003C_003E9;
				nint num7 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ S0_v117 (Il2CppClass<AssetBundleManager+<>c>)+5C]");
				object obj5 = (nint)0 + (nint)4;
				obj5 = func;
				predicate = func;
			}
			int num8 = Enumerable.Count(source2, predicate);
			if ((nint)obj6 >= num8)
			{
				break;
			}
			string name = ((FileInfo)(object)text).Name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			obj6 = obj7 + 1;
			text = text2;
		}
		nint num9 = (nint)typeof(_003C_003Ec);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ S0_v28 (Il2CppClass<AssetBundleManager+<>c>)+BA]");
		object obj8 = (nint)0 & (nint)0x200;
		if (obj8 != null)
		{
			nint num10 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v89 (Il2CppClass<AssetBundleManager+<>c>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (_003C_003Ec._003C_003E9__51_0 == null)
		{
			nint num11 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ S0_v63 (Il2CppClass<AssetBundleManager+<>c>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num12 = (nint)typeof(_003C_003Ec);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ S0_v83 (Il2CppClass<AssetBundleManager+<>c>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num13 = 0;
			_ = 0;
			object obj11 = default;
			object obj10 = obj11 + 16;
			obj10 = _003C_003Ec._003C_003E9;
			nint num14 = (nint)typeof(_003C_003Ec);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ S0_v80 (Il2CppClass<AssetBundleManager+<>c>)+5C]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = obj11;
		}
		throw new NullReferenceException();
	}

	public void EnqueueAsyncCharacterBundleRequest(Characters.CharacterId characterId, int theme, Action onBundlesLoaded, CharacterModelRequest modelRequest)
	{
		//IL_0064: Expected Obj, but got I4
		//IL_0064: Expected Obj, but got I4
		//IL_0076: Expected I, but got Obj
		//IL_008c: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string text = string.Format((IFormatProvider)(object)"{0}_{1} Result", (string)theme, characterId);
		nint num = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v9 (Il2CppClass<Flurry>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v13 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
	}

	public void RemoveAsyncCharacterBundleRequest(CharacterModelRequest modelRequest)
	{
	}

	public void CharacterBundleRequestCompleted(CharacterModelRequest.CharacterBundleRequest request)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I
		//IL_00da: Expected Obj, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		object obj2 = default;
		object obj = obj2 + 8;
		obj = request;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		_ = 0;
		object obj4 = default;
		object obj3 = obj4 + 16;
		obj3 = obj2;
		NullReferenceException ex = new NullReferenceException();
		if (ex != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			if (((HoverboardOverlayHelper._003C_003Ec__DisplayClass29_0)(object)ex)._003CBoardHasFreeThemes_003Eb__0((HoverboardThemes.HoverboardTheme)0))
			{
				bool flag = _pendingCharacterBundleRequests.Remove((CharacterModelRequest.CharacterBundleRequest)(object)ex);
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num2 = 0;
		_ = 0;
		object obj6 = default;
		object obj5 = obj6 + 16;
		obj5 = obj2;
		NullReferenceException ex2 = new NullReferenceException();
		if (ex2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7+8]");
			bool flag2 = ((HoverboardOverlayHelper._003C_003Ec__DisplayClass29_0)(object)ex2)._003CBoardHasFreeThemes_003Eb__0((HoverboardThemes.HoverboardTheme)0);
		}
	}

	public void CancelCharacterBundleRequest(CharacterModelRequest.CharacterBundleRequest request)
	{
		bool flag = _activeCharacterBundleRequests.Remove(request);
	}

	public IEnumerator<float> CacheNeededAssetBundles()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator<float> enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void OnEventChanged()
	{
	}

	private void DelayedAvailabilityCheck()
	{
		//IL_0109: Expected I, but got Obj
		//IL_011f: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0155: Expected Obj, but got I
		//IL_00a1: Expected I, but got Obj
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (MergeLevelStartHelp.IsValidLoadedLevelNameForGameplay())
		{
			nint num3 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ S0_v17 (Il2CppClass<SYBO.Subway.Game>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(Game);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S0_v26 (Il2CppClass<SYBO.Subway.Game>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			bool isInstantiated = Game.IsInstantiated;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v22 (System.Boolean)+60]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S0_v23+8]");
			if ((nint)0 == 0)
			{
				InitializeDownloadRequests();
				return;
			}
		}
		_delayedAvailabilityCheck = true;
	}

	public void PerformAvailabilityCheck()
	{
		if (~(_delayedAvailabilityCheck ? 1u : 0u) == 0)
		{
			_delayedAvailabilityCheck = false;
			InitializeDownloadRequests();
		}
	}

	private bool CacheAssetBundle(string bundleName, int version, byte[] bundleBytes = null)
	{
		//IL_0023: Expected Obj, but got I4
		//IL_0036: Expected Obj, but got I4
		//IL_0051: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 24;
		obj = this;
		object obj2 = (flag ? 1 : 0) + 16;
		obj2 = bundleName;
		object obj3 = (flag ? 1 : 0) + 28;
		obj3 = bundleBytes;
		return flag;
	}

	public void UnloadAssetBundle(string bundleName, bool unloadAllLoadedObjects)
	{
		//IL_0052: Expected I, but got Obj
		//IL_0068: Expected Obj, but got I
		//IL_04e6: Expected Obj, but got I
		//IL_04f6: Expected Obj, but got I
		//IL_0506: Expected Obj, but got I
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected Obj, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected Obj, but got Unknown
		//IL_0549: Expected I, but got Obj
		//IL_055f: Expected Obj, but got I
		//IL_0093: Expected I, but got Obj
		//IL_01ac: Expected I, but got Obj
		//IL_01c2: Expected Obj, but got I
		//IL_0610: Expected Obj, but got I
		//IL_0620: Expected Obj, but got I
		//IL_0630: Expected Obj, but got I
		//IL_0639: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected Obj, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected Obj, but got Unknown
		//IL_0671: Expected Obj, but got I
		//IL_0681: Expected Obj, but got I
		//IL_0691: Expected Obj, but got I
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected Obj, but got Unknown
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected Obj, but got Unknown
		//IL_06d4: Expected I, but got Obj
		//IL_06ea: Expected Obj, but got I
		//IL_015f: Expected I, but got Obj
		//IL_05aa: Expected Obj, but got I
		//IL_05ba: Expected Obj, but got I
		//IL_05ca: Expected Obj, but got I
		//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected Obj, but got Unknown
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e6: Expected Obj, but got Unknown
		//IL_01ed: Expected I, but got Obj
		//IL_030b: Expected I, but got Obj
		//IL_0321: Expected Obj, but got I
		//IL_049d: Expected I, but got Obj
		//IL_04b3: Expected Obj, but got I
		//IL_00f9: Expected I, but got Obj
		//IL_02b9: Expected I, but got Obj
		//IL_034c: Expected I, but got Obj
		//IL_03a8: Expected I, but got Obj
		//IL_0253: Expected I, but got Obj
		//IL_03f5: Expected I, but got Obj
		//IL_040b: Expected Obj, but got I
		//IL_0436: Expected I, but got Obj
		switch (unloadAllLoadedObjects)
		{
		case false:
		{
			nint num3 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v34 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj2 = (nint)0 & (nint)0x200;
			if (obj2 != null)
			{
				nint num4 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ S0_v69 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ S2_v3 (Il2CppMethodInfo)+C]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S2_v4+60]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S2_v5+44]");
			object obj5 = 0;
			object obj6 = obj5 & 0x1FFF;
			object obj7 = obj6 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v55 @ S3_v5 (should have been resolved before IL gen)");
			object obj8 = default;
			bool flag = (nint)obj8 > -1;
			nint num6 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S1_v10 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			bool flag2 = obj9 != null;
			if (flag)
			{
				if (flag2)
				{
					nint num7 = (nint)typeof(AssetBundleCache);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ S0_v65 (Il2CppClass<AssetBundleCache>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				((AssetBundleManager)(object)"Recording caching info for a bundle that is already cached. Overwriting info. This might cause verison mismatch.")._002Ector();
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ S4_v11 (Il2CppMethodInfo)+C]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ S4_v12+60]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ S4_v13+48]");
				object obj12 = 0;
				object obj13 = obj12 & 0x7FF;
				object obj14 = obj13 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v288 @ S5_v10 (should have been resolved before IL gen)");
				break;
			}
			if (flag2)
			{
				nint num9 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ S0_v50 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ S4_v6 (Il2CppMethodInfo)+C]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ S4_v7+60]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ S4_v8+48]");
			object obj17 = 0;
			object obj18 = obj17 & 0x7FF;
			object obj19 = obj18 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v219 @ S5_v6 (should have been resolved before IL gen)");
			break;
		}
		case true:
		{
			nint num11 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v76 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj20 = (nint)0 & (nint)0x200;
			if (obj20 != null)
			{
				nint num12 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ S0_v106 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ S2_v13 (Il2CppMethodInfo)+C]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ S2_v14+60]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ S2_v15+44]");
			object obj23 = 0;
			object obj24 = obj23 & 0x1FFF;
			object obj25 = obj24 + 22691;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v100 @ S3_v12 (should have been resolved before IL gen)");
			object obj26 = default;
			bool flag3 = (nint)obj26 > -1;
			nint num14 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ S1_v22 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj27 = (nint)0 & (nint)0x200;
			bool flag4 = obj27 != null;
			if (flag3)
			{
				if (flag4)
				{
					nint num15 = (nint)typeof(AssetBundleCache);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ S0_v100 (Il2CppClass<AssetBundleCache>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				bool flag5 = AssetBundleCache._cachedBundlesVersionInfo.Remove((string)(object)this);
				break;
			}
			if (flag4)
			{
				nint num16 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ S0_v90 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			((AssetBundleManager)(object)"Attempting to record caching info for removing a bundle that is not cached. Aborting.")._002Ector();
			break;
		}
		case true:
		{
			nint num = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v113 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj = (nint)0 & (nint)0x200;
			if (obj != null)
			{
				nint num2 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v134 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			if (AssetBundleCache._cachedBundlesVersionInfo != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				throw new IndexOutOfRangeException();
			}
			break;
		}
		}
		nint num17 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v8 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj28 = (nint)0 & (nint)0x200;
		if (obj28 != null)
		{
			nint num18 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ S0_v27 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		if (~(AssetBundleCache._isPerformingBulkCaching ? 1u : 0u) == 0)
		{
			return;
		}
		nint num19 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ S0_v18 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj29 = (nint)0 & (nint)0x200;
		if (obj29 != null)
		{
			nint num20 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ S0_v23 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleCache._002Ecctor();
	}

	public static void ClearCache()
	{
		//IL_00ad: Expected I, but got Obj
		//IL_00c3: Expected Obj, but got I
		//IL_011d: Expected I, but got Obj
		//IL_0133: Expected Obj, but got I
		//IL_00fb: Expected Obj, but got I4
		//IL_0013: Expected I, but got Obj
		//IL_0060: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v19 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleVersionControl instance = AssetBundleVersionControl.Instance;
		nint num3 = (nint)typeof(Path);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S1_v4 (Il2CppClass<System.IO.Path>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(Path);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S1_v12 (Il2CppClass<System.IO.Path>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool flag = Path.SameRoot((string)(object)instance, "AssetBundles");
		AssetBundleCache.ASSET_BUNDLE_CACHE_PATH = (string)flag;
		AssetBundleCache._isPerformingBulkCaching = false;
	}

	private IEnumerator UnloadBundlesCoroutine()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		return enumerator;
	}

	private void InitializeDownloadRequests()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0882: Unknown result type (might be due to invalid IL or missing references)
		//IL_0887: Expected Obj, but got Unknown
		//IL_0890: Expected Obj, but got I4
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08aa: Expected Obj, but got Unknown
		//IL_08b3: Expected Obj, but got I4
		//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c1: Expected Obj, but got Unknown
		//IL_08ec: Expected I, but got Obj
		//IL_0902: Expected Obj, but got I
		//IL_0959: Expected Obj, but got I4
		//IL_0021: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected Obj, but got Unknown
		//IL_012a: Expected I, but got Obj
		//IL_0140: Expected Obj, but got I
		//IL_00fa: Expected Obj, but got I4
		//IL_016b: Expected I, but got Obj
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected Obj, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected Obj, but got Unknown
		//IL_05ab: Expected Obj, but got I4
		//IL_0213: Expected Obj, but got I4
		//IL_09f4: Expected I, but got Obj
		//IL_0a0a: Expected Obj, but got I
		//IL_06e9: Expected Obj, but got I
		//IL_07a1: Expected I, but got Obj
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0724: Expected Obj, but got Unknown
		//IL_07f9: Expected I, but got Obj
		//IL_080f: Expected Obj, but got I
		//IL_0755: Unknown result type (might be due to invalid IL or missing references)
		//IL_075a: Expected Obj, but got Unknown
		//IL_083a: Expected I, but got Obj
		//IL_05b9: Expected Obj, but got I4
		//IL_05c7: Expected Obj, but got I4
		//IL_05d5: Expected Obj, but got I4
		//IL_05e3: Expected Obj, but got I4
		//IL_05f1: Expected Obj, but got I4
		//IL_05ff: Expected Obj, but got I4
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected Obj, but got Unknown
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected Obj, but got Unknown
		//IL_0651: Expected Obj, but got I4
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
		int currentlyAvailableBundleVersion = _versionControl.GetCurrentlyAvailableBundleVersion();
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ S0_v24 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S0_v184 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleCache.EndBulkCaching();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @759C");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj7 = 1;
		object obj8 = default;
		object obj9;
		object obj11 = default;
		object obj12 = default;
		object obj13 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj8 == null)
			{
				obj9 = 33;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			if (obj7 == null)
			{
				obj9 = 10;
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			nint num3 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ S0_v139 (Il2CppClass<AssetBundleCache>)+BA]");
			object obj10 = (nint)0 & (nint)0x200;
			if (obj10 != null)
			{
				nint num4 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ S0_v172 (Il2CppClass<AssetBundleCache>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj11 == obj12)
			{
				obj13 = 1;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17");
			}
			obj7 = obj13;
		}
		object obj14 = obj9 - 9;
		object obj19 = default;
		if ((nint)obj9 != 9)
		{
			if ((nint)obj14 != 1)
			{
				if ((nint)obj14 != 2 && (nint)obj14 != 3 && (nint)obj14 != 4 && (nint)obj14 != 5)
				{
					if ((nint)obj14 != 6)
					{
						if ((nint)obj14 == 7 || (nint)obj14 == 8 || (nint)obj14 == 9)
						{
							goto IL_097f;
						}
						if ((nint)obj14 != 10)
						{
							if ((nint)obj14 != 11)
							{
								if ((nint)obj14 == 12 || (nint)obj14 == 13 || (nint)obj14 == 14 || (nint)obj14 == 15 || (nint)obj14 == 16 || (nint)obj14 == 17)
								{
									goto IL_097f;
								}
								if ((nint)obj14 != 18)
								{
									if ((nint)obj14 != 19)
									{
										if ((nint)obj14 != 20)
										{
											if ((nint)obj14 != 21)
											{
												if ((nint)obj14 != 22 && (nint)obj14 != 23 && (nint)obj14 == 24)
												{
													object obj15 = obj5 + 4;
													object obj16 = obj15 + 1;
													obj15 = obj16;
													object obj17 = obj16 << 2;
													object obj18 = obj5 + obj17;
													obj18 = 107;
													obj19 = obj7;
												}
												goto IL_097f;
											}
										}
										else
										{
											obj7 = 1;
										}
									}
									else
									{
										obj7 = 1;
									}
								}
								else
								{
									obj7 = 1;
								}
							}
							else
							{
								obj7 = 1;
							}
						}
						else
						{
							obj7 = 1;
						}
					}
					else
					{
						obj7 = 1;
					}
					goto IL_065e;
				}
			}
			else
			{
				object obj20 = obj5 + 4;
				object obj21 = obj20 + 1;
				obj20 = obj21;
				object obj22 = obj21 << 2;
				object obj23 = obj5 + obj22;
				obj23 = 107;
			}
			goto IL_097f;
		}
		goto IL_065e;
		IL_065e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj24 = default;
		object obj25 = default;
		if (obj24 == obj25)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
			obj19 = obj7;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_097f;
		IL_09e6:
		nint num5 = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ S0_v51 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj26 = (nint)0 & (nint)0x200;
		if (obj26 != null)
		{
			nint num6 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ S0_v69 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleCache.ClearCache();
		if (obj19 != null)
		{
			return;
		}
		((AssetBundleManager)null).DebugRequestStatus("We do not have all the necessary bundles cached. Please free some disk space and restart the App.");
		nint num7 = (nint)typeof(Flurry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ S0_v62 (Il2CppClass<Flurry>)+BA]");
		object obj27 = (nint)0 & (nint)0x200;
		if (obj27 != null)
		{
			nint num8 = (nint)typeof(Flurry);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ S0_v65 (Il2CppClass<Flurry>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		return;
		IL_097f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj28 = (nint)0 << 2;
			object obj29 = obj5 + obj28;
			if ((nint)obj29 == 107)
			{
				object obj30 = obj5 + 4;
				if ((nint)obj30 > -1)
				{
					object obj31 = obj30 + -1;
					obj30 = obj31;
				}
				goto IL_09e6;
			}
		}
		object obj32 = default;
		if (obj32 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_09e6;
	}

	private void OnDownloadableAssetBundlesUpdated()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected Obj, but got Unknown
		//IL_0898: Expected Obj, but got I4
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected Obj, but got Unknown
		//IL_08bb: Expected Obj, but got I4
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected Obj, but got Unknown
		//IL_090a: Expected Obj, but got I
		//IL_091a: Expected Obj, but got I
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected Obj, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_093e: Expected Obj, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected Obj, but got Unknown
		//IL_0969: Expected I, but got Obj
		//IL_097f: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_009f: Expected Obj, but got I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected Obj, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected Obj, but got Unknown
		//IL_0137: Expected Obj, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected Obj, but got Unknown
		//IL_0190: Expected I, but got Obj
		//IL_01a6: Expected Obj, but got I
		//IL_0b30: Expected I, but got Obj
		//IL_0b46: Expected Obj, but got I
		//IL_0750: Expected Obj, but got I
		//IL_01d1: Expected I, but got Obj
		//IL_0a89: Expected Obj, but got I
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected Obj, but got Unknown
		//IL_0808: Expected I, but got Obj
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected Obj, but got Unknown
		//IL_0295: Expected Obj, but got I4
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected Obj, but got Unknown
		//IL_02b6: Expected Obj, but got I4
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected Obj, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected Obj, but got Unknown
		//IL_06e9: Expected Obj, but got I4
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
		float deltaTime = Time.deltaTime;
		_lastInitializedDownloads = deltaTime;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ S3_v3+60]");
		object obj7 = 0;
		object obj8 = obj7;
		object obj9 = obj8 & 0x1FFF;
		object obj10 = obj9 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v419 @ S4_v8 (should have been resolved before IL gen)");
		object obj11 = this + 40;
		object obj12 = default;
		obj11 = obj12;
		nint num2 = (nint)typeof(CharacterManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ S0_v27 (Il2CppClass<Data.Managers.CharacterManager>)+BA]");
		object obj13 = (nint)0 & (nint)0x200;
		if (obj13 != null)
		{
			nint num3 = (nint)typeof(CharacterManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ S0_v189 (Il2CppClass<Data.Managers.CharacterManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		IEnumerator enumerator = CloudSave.LoginAsync();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @77DB");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+10]");
		_ = 0;
		object obj14 = default;
		object obj16 = default;
		object obj22 = default;
		object obj23 = default;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			if (obj14 == null)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			object obj15 = obj16 + 12;
			object obj17 = 0;
			while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj17) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj15))
			{
				object obj18 = obj16 + 16;
				object obj19 = obj17 << 2;
				object obj20 = obj18 + obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				nint num4 = (nint)typeof(AssetBundleCache);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ S0_v153 (Il2CppClass<AssetBundleCache>)+BA]");
				object obj21 = (nint)0 & (nint)0x200;
				if (obj21 != null)
				{
					nint num5 = (nint)typeof(AssetBundleCache);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ S0_v175 (Il2CppClass<AssetBundleCache>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @16");
					bool flag = obj23 == null;
					bool flag2 = !flag;
					obj10 = 0;
					if (!flag2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
						obj10 = 0;
					}
				}
				object obj24 = obj17 + 1;
				obj17 = obj24;
			}
		}
		object obj25 = 37;
		object obj26 = obj25 - 12;
		object obj29;
		object obj30 = default;
		if ((nint)obj25 != 12 && (nint)obj26 != 1 && (nint)obj26 != 2 && (nint)obj26 != 3)
		{
			if ((nint)obj26 == 4 || (nint)obj26 == 5 || (nint)obj26 == 6 || (nint)obj26 == 7 || (nint)obj26 == 8)
			{
				goto IL_0aee;
			}
			if ((nint)obj26 != 9)
			{
				object obj27;
				if ((nint)obj26 != 10)
				{
					if ((nint)obj26 != 11 && (nint)obj26 != 12)
					{
						if ((nint)obj26 == 13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
							object obj28 = default;
							obj27 = obj28;
							obj29 = obj30;
							goto IL_0a15;
						}
						if ((nint)obj26 != 14 && (nint)obj26 != 15)
						{
							if ((nint)obj26 == 16)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
								object obj31 = default;
								obj27 = obj31;
								obj29 = obj30;
								goto IL_0a15;
							}
							if ((nint)obj26 != 17 && (nint)obj26 != 18 && (nint)obj26 != 19)
							{
								if ((nint)obj26 == 20)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
									object obj32 = default;
									obj27 = obj32;
									obj29 = obj30;
									goto IL_0a15;
								}
								if ((nint)obj26 != 21 && (nint)obj26 != 22 && (nint)obj26 != 23)
								{
									if ((nint)obj26 == 24)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
										object obj33 = default;
										obj27 = obj33;
										obj29 = obj30;
										goto IL_0a15;
									}
									if ((nint)obj26 == 25)
									{
										object obj34 = obj5 + 4;
										object obj35 = obj34 + 1;
										obj34 = obj35;
										object obj36 = obj35 << 2;
										object obj37 = obj5 + obj36;
										obj37 = 159;
									}
								}
							}
						}
					}
					goto IL_0aee;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj38 = default;
				obj27 = obj38;
				obj29 = obj30;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
				object obj39 = default;
				object obj27 = obj39;
				obj29 = obj30;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj40 = default;
			object obj27 = obj40;
			obj29 = obj30;
		}
		goto IL_0a15;
		IL_0b13:
		bool flag3 = Enumerable.Any(_pendingDownloads);
		nint num6 = (nint)typeof(UserSave);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ S1_v39 (Il2CppClass<Data.Save.UserSave>)+BA]");
		object obj41 = (nint)0 & (nint)0x200;
		if (obj41 != null)
		{
			nint num7 = (nint)typeof(UserSave);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ S1_v61 (Il2CppClass<Data.Save.UserSave>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		int latestAvailableAssetBundlesVersion = (flag3 ? 1 : 0) ^ 1;
		UserSave.latestAvailableAssetBundlesVersion = latestAvailableAssetBundlesVersion;
		Dictionary<string, int> pendingDownloads = _pendingDownloads;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S1_v48 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+10]");
		nint num8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ S1_v48 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+1C]");
		object obj42 = num8 - 0;
		int num10;
		if ((nint)obj42 > 0)
		{
			Dictionary<string, int> pendingDownloads2 = _pendingDownloads;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S1_v58 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+10]");
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ S1_v58 (System.Collections.Generic.Dictionary`2<System.String, System.Int32>)+1C]");
			num10 = (int)(num9 - 0);
		}
		else
		{
			num10 = 0;
		}
		attemptingToDownloadAmount = num10;
		succesfullyDownloaded = 0;
		return;
		IL_0a15:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj43 = default;
		if (obj29 == obj43)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		goto IL_0aee;
		IL_0aee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			object obj44 = (nint)0 << 2;
			object obj45 = obj5 + obj44;
			if ((nint)obj45 == 159)
			{
				object obj46 = obj5 + 4;
				if ((nint)obj46 > -1)
				{
					object obj47 = obj46 + -1;
					obj46 = obj47;
				}
				goto IL_0b13;
			}
		}
		object obj48 = default;
		if (obj48 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
		goto IL_0b13;
	}

	private void AddAssetBundleDownloadRequest(string bundleName, int version)
	{
		//IL_001b: Expected Obj, but got I
		//IL_002b: Expected Obj, but got I
		//IL_003b: Expected Obj, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected Obj, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected Obj, but got Unknown
		//IL_0074: Expected Obj, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S4_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S4_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S4_v4+48]");
		object obj3 = 0;
		object obj4 = obj3 & 0x7FF;
		object obj5 = obj4 + 39195;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v30 @ S5_v4 (should have been resolved before IL gen)");
		bool flag = AllowedToInitializeDownloads();
		Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])flag);
	}

	public void ResumeAssetBundlesDownload()
	{
		_downloadableBundlesUpdated = true;
	}

	private bool AllowedToInitializeDownloads()
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 16;
		obj = this;
		return flag;
	}

	private void StopAssetbundlesDownload()
	{
		//IL_00a0: Expected I, but got Obj
		//IL_00b6: Expected Obj, but got I
		//IL_018f: Expected Obj, but got I
		//IL_00e1: Expected I, but got Obj
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected Obj, but got Unknown
		while (!Enumerable.Any(_pendingDownloads) || ~(_downloadableBundlesUpdated ? 1u : 0u) == 0)
		{
			do
			{
				IEnumerator enumerator = DownloadAllAssetBundles();
				if (enumerator != null)
				{
					OnDownloadableAssetBundlesUpdated();
					if (!Enumerable.Any(_pendingDownloads))
					{
						return;
					}
					continue;
				}
				return;
			}
			while (_pendingDownloads == null);
		}
		if (~(_isDownloading ? 1u : 0u) == 0)
		{
			return;
		}
		nint num = (nint)typeof(Game);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ S0_v30 (Il2CppClass<SYBO.Subway.Game>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(Game);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ S0_v44 (Il2CppClass<SYBO.Subway.Game>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		bool isInstantiated = Game.IsInstantiated;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ S0_v35 (System.Boolean)+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ S0_v36+8]");
		if ((nint)0 == 0)
		{
			object obj3 = this + 56;
			string text = SerializeAssetBundleVersionData((Dictionary<string, int>)(object)this);
			obj3 = text;
			Coroutine coroutine = CoroutineUtil.WaitForAll((YieldInstruction[])(object)_currentDownloaderCoroutine);
		}
	}

	private IEnumerator DownloadAllAssetBundles()
	{
		//IL_002c: Expected I, but got Obj
		//IL_0042: Expected Obj, but got I
		//IL_012e: Expected I, but got Obj
		//IL_0144: Expected Obj, but got I
		//IL_0019: Expected Obj, but got I4
		//IL_0174: Expected I4, but got Obj
		//IL_01a8: Expected Obj, but got I4
		//IL_006d: Expected I, but got Obj
		//IL_00ba: Expected I, but got Obj
		if (~(_downloadableBundlesUpdated ? 1u : 0u) == 0)
		{
			_downloadableBundlesUpdated = false;
			return (IEnumerator)1;
		}
		nint num = (nint)typeof(OnlineSettings);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S1_v4 (Il2CppClass<Info.OnlineSettings>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(OnlineSettings);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S1_v13 (Il2CppClass<Info.OnlineSettings>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string saveDataPath = OnlineSettings.GetSaveDataPath();
		nint num3 = (nint)typeof(AssetBundleManager);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ S2_v4 (Il2CppClass<AssetBundleManager>)+BA]");
		object obj2 = (nint)0 & (nint)0x200;
		if (obj2 != null)
		{
			nint num4 = (nint)typeof(AssetBundleManager);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S2_v10 (Il2CppClass<AssetBundleManager>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		float startOffset = ((LayoutGroup)(object)saveDataPath).GetStartOffset((int)"asset_bundle_download_rest_time", _downloadAttemptRestTime);
		float num5 = _lastInitializedDownloads + startOffset;
		float deltaTime = Time.deltaTime;
		bool flag = num5 < deltaTime;
		return (IEnumerator)flag;
	}

	private IEnumerator DownloadAssetBundle(string bundleName, int version)
	{
		//IL_0006: Expected Obj, but got I4
		return (IEnumerator)1;
	}

	private void DownloadFailedFor(string bundleName, int version)
	{
		//IL_0117: Expected Obj, but got I
		//IL_0127: Expected Obj, but got I
		//IL_0137: Expected Obj, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected Obj, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected Obj, but got Unknown
		//IL_00b6: Expected Obj, but got I
		//IL_00c6: Expected Obj, but got I
		//IL_00d6: Expected Obj, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected Obj, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected Obj, but got Unknown
		//IL_0055: Expected Obj, but got I
		//IL_0065: Expected Obj, but got I
		//IL_0075: Expected Obj, but got I
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected Obj, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v27 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			int num2 = _pendingDownloads.get_Item(bundleName);
			if (num2 > version)
			{
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ S4_v11 (Il2CppMethodInfo)+C]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ S4_v12+60]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ S4_v13+48]");
				object obj9 = 0;
				object obj10 = obj9 & 0x7FF;
				object obj11 = obj10 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v94 @ S5_v10 (should have been resolved before IL gen)");
			}
		}
		else
		{
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ S4_v5 (Il2CppMethodInfo)+C]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ S4_v6+60]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ S4_v7+48]");
			object obj14 = 0;
			object obj15 = obj14 & 0x7FF;
			object obj16 = obj15 + 39195;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v56 @ S5_v5 (should have been resolved before IL gen)");
		}
	}

	private void ResolveDownloadRequest(string bundleName, int version)
	{
		//IL_00ed: Expected Obj, but got I
		//IL_00fd: Expected Obj, but got I
		//IL_010d: Expected Obj, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected Obj, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected Obj, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ S2_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S2_v3+60]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ S2_v4+44]");
		object obj3 = 0;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 22691;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v33 @ S3_v4 (should have been resolved before IL gen)");
		object obj6 = default;
		if ((nint)obj6 > -1)
		{
			bool flag = _pendingDownloads.Remove(bundleName);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static string SerializeAssetBundleVersionData(Dictionary<string, int> versionData)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected Obj, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		string text = default;
		text.m_stringLength = 0;
		object obj = text + 16;
		obj = versionData;
		return text;
	}

	public static Dictionary<string, int> ParseAssetBundleVersionData(string serializedData)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected Obj, but got Unknown
		//IL_0251: Expected Obj, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected Obj, but got Unknown
		//IL_0274: Expected Obj, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected Obj, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected Obj, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected Obj, but got Unknown
		//IL_013e: Expected Obj, but got I4
		//IL_01a5: Expected Obj, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
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
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		StringBuilder sb = default;
		System.Text.StringBuilderCache.Release(sb);
		if (serializedData != null)
		{
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
				if (obj6 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			}
			object obj7 = obj5 + 4;
			object obj8 = obj7 + 1;
			obj7 = obj8;
			object obj9 = obj8 << 2;
			object obj10 = obj5 + obj9;
			obj10 = 97;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
			if ((nint)0 != -1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v18+4]");
				object obj11 = (nint)0 << 2;
				object obj12 = obj5 + obj11;
				if ((nint)obj12 == 97)
				{
					object obj13 = obj5 + 4;
					if ((nint)obj13 > -1)
					{
						object obj14 = obj13 + -1;
						obj13 = obj14;
					}
					goto IL_0355;
				}
			}
			object obj15 = default;
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			}
		}
		goto IL_0355;
		IL_0355:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
		Dictionary<string, int> result = default;
		return result;
	}

	public unsafe string GetPreCachedBundles()
	{
		//IL_0170: Expected Obj, but got I
		//IL_0180: Expected Obj, but got I
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected Obj, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected Obj, but got Unknown
		//IL_01c6: Expected Obj, but got I4
		//IL_01cf: Expected Obj, but got I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected Obj, but got Unknown
		//IL_001c: Expected Obj, but got I4
		//IL_0025: Expected Obj, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected Obj, but got Unknown
		//IL_006b: Expected Obj, but got I4
		//IL_0074: Expected Obj, but got I4
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected Obj, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected Obj, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected Obj, but got Unknown
		//IL_00f6: Expected Obj, but got I
		//IL_0106: Expected Obj, but got I
		//IL_0116: Expected Obj, but got I
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected Obj, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected Obj, but got Unknown
		//IL_0146: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S3_v2 (Il2CppMethodInfo)+C]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ S3_v3+60]");
		object obj2 = 0;
		object obj3 = obj2;
		object obj4 = obj3 & 0x1FFF;
		object obj5 = obj4 + 113696;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v60 @ S4_v6 (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		int num2 = default;
		object obj6 = num2 + 16;
		obj6 = 44;
		string text = ((string)this).Substring(num2);
		object obj7 = text + 12;
		object obj8 = 0;
		object obj9 = 113696;
		int num3 = default;
		while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj8) < System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj7))
		{
			object obj10 = text + 16;
			object obj11 = obj8 << 2;
			object obj12 = obj10 + obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			object obj13 = num3 + 16;
			obj13 = 45;
			string text2 = ((string)obj12).Substring(num3);
			if (text2.m_firstChar == '\u0002')
			{
				object obj14 = text2 + 16;
				object obj15 = text2 + 20;
				TypeCode typeCode = ((int*)obj15)->GetTypeCode();
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ S4_v8 (Il2CppMethodInfo)+C]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ S4_v9+60]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ S4_v10+48]");
				obj5 = 0;
				object obj18 = obj5 & 0x7FF;
				obj9 = obj18 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v58 @ S5_v4 (should have been resolved before IL gen)");
				obj3 = 2;
			}
			object obj19 = obj8 + 1;
			obj8 = obj19;
		}
		string result = default;
		return result;
	}

	public string GetDownloadedBundles()
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected Obj, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected Obj, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 4;
		object obj3 = this - -64;
		if ((nint)obj3 == succesfullyPrecached)
		{
			object obj4 = this - -64;
			obj = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
			string text = default;
			return "Complete(" + text + ")";
		}
		obj = succesfullyPrecached;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		object obj5 = this - -64;
		obj2 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
		string text2 = default;
		string text3 = default;
		return text2 + "/" + text3;
	}

	private void Log(string msg)
	{
		if (_pendingCharacterBundleRequests.Contains((CharacterModelRequest.CharacterBundleRequest)(object)msg))
		{
			bool flag = _pendingCharacterBundleRequests.Remove((CharacterModelRequest.CharacterBundleRequest)(object)msg);
		}
	}

	private void LogWarning(string msg)
	{
	}

	private void LogError(string msg)
	{
	}

	private void DebugRequestStatus(string bundleName)
	{
		//IL_0013: Expected I4, but got Obj
		string msg = string.ConcatArray((string[])(object)"[AssetBundleManager]: ", (int)bundleName);
		SDebug.LogFormat(msg, null);
	}

	static AssetBundleManager()
	{
		//IL_0060: Expected I, but got Obj
		//IL_0076: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		nint num = (nint)typeof(AssetBundleCache);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<AssetBundleCache>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AssetBundleCache);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v11 (Il2CppClass<AssetBundleCache>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		AssetBundleCache.LoadCachedBundlesVersionInfo();
	}
}
