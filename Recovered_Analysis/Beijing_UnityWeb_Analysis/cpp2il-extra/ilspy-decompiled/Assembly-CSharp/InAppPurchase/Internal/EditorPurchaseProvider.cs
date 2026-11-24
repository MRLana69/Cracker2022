using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using InApp;
using Ionic.Zlib;
using Kiloo.Common.Backend.PurchaseValidation;
using UnityEngine;
using UnityEngine.Rendering;

namespace InAppPurchase.Internal;

public class EditorPurchaseProvider : IPurchaseProvider
{
	private sealed class _003CProductRequestCoroutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string[] productIds;

		public EditorPurchaseProvider _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Expected Obj, but got Unknown
				//IL_00de: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e3: Expected Obj, but got Unknown
				//IL_010c: Expected I, but got Obj
				//IL_0122: Expected Obj, but got I
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0262: Expected Obj, but got Unknown
				//IL_0287: Unknown result type (might be due to invalid IL or missing references)
				//IL_028c: Expected Obj, but got Unknown
				//IL_01c5: Expected Obj, but got I4
				//IL_014d: Expected I, but got Obj
				//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e5: Expected Obj, but got Unknown
				//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fb: Expected Obj, but got Unknown
				//IL_030d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0312: Expected Obj, but got Unknown
				//IL_0324: Unknown result type (might be due to invalid IL or missing references)
				//IL_0329: Expected Obj, but got Unknown
				//IL_0196: Unknown result type (might be due to invalid IL or missing references)
				//IL_019b: Expected Obj, but got Unknown
				//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Expected Obj, but got Unknown
				EditorPurchaseProvider editorPurchaseProvider = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						float time = Time.time;
						if (time > 0f)
						{
							string[] array = productIds;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							object obj2 = default;
							object obj = obj2 + 12;
							object obj3 = default;
							object obj21 = default;
							while (true)
							{
								bool flag = System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj3) >= System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj);
								object obj4 = obj2;
								if (flag)
								{
									break;
								}
								object obj5 = productIds + 16;
								object obj6 = obj3 << 2;
								object obj7 = obj5 + obj6;
								nint num = (nint)typeof(EditorPurchaseProvider);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ S0_v44 (Il2CppClass<InAppPurchase.Internal.EditorPurchaseProvider>)+BA]");
								object obj8 = (nint)0 & (nint)0x200;
								if (obj8 != null)
								{
									nint num2 = (nint)typeof(EditorPurchaseProvider);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ S0_v70 (Il2CppClass<InAppPurchase.Internal.EditorPurchaseProvider>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj9 = obj2 + 16;
								object obj10 = obj3 << 4;
								object obj11 = obj9 + obj10;
								object obj12 = DUMMY_PRICES_LOCALIZED + 16;
								string[] dUMMY_PRICES_LOCALIZED = DUMMY_PRICES_LOCALIZED;
								object obj15;
								if (dUMMY_PRICES_LOCALIZED.Length != 0)
								{
									object obj13 = obj3 / dUMMY_PRICES_LOCALIZED.Length;
									object obj14 = obj13 * dUMMY_PRICES_LOCALIZED.Length;
									obj15 = obj3 - obj14;
								}
								else
								{
									obj15 = 0;
								}
								object obj16 = obj15 << 2;
								object obj17 = obj12 + obj16;
								obj11 = obj7;
								object obj18 = obj11 + 4;
								obj18 = obj17;
								object obj19 = obj11 + 8;
								obj19 = "Editor title";
								object obj20 = obj11 + 12;
								obj20 = "Editor description";
								obj3 = obj21 + 1;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
							object obj22 = default;
							object obj4 = obj22;
						}
						if (editorPurchaseProvider._productRequestDelegate != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8957");
						}
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0f;
				object obj23 = this + 12;
				object obj24 = default;
				obj23 = obj24;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CProductRequestCoroutine_003Ed__24(int _003C_003E1__state)
		{
			//IL_003f: Expected Obj, but got I
			//IL_010b: Expected Obj, but got I4
			int num = this._003C_003E1__state;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ S0_v2 (System.Int32)+C]");
			if ((nint)0 == 0)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+1C]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+1C]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+1C]");
				if ((nint)0 == 1)
				{
					goto IL_0102;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+1C]");
				if ((nint)0 != 2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+1C]");
					if ((nint)0 != 3)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+1C]");
						if ((nint)0 != 4)
						{
							goto IL_0102;
						}
					}
				}
			}
			goto IL_0111;
			IL_0111:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8940");
			return;
			IL_0102:
			obj = 1;
			goto IL_0111;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0015: Expected Obj, but got I
			//IL_006e: Expected Obj, but got I4
			//IL_0050: Expected Obj, but got I
			//IL_0060: Expected Obj, but got I
			//IL_00ae: Expected Obj, but got I
			//IL_00be: Expected Obj, but got I
			//IL_0113: Expected Obj, but got I
			//IL_0130: Expected Obj, but got I4
			//IL_0362: Expected Obj, but got I
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Expected Obj, but got Unknown
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Expected Obj, but got Unknown
			//IL_01bc: Expected Obj, but got I
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Expected Obj, but got Unknown
			//IL_0188: Expected Obj, but got I
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Expected Obj, but got Unknown
			//IL_024f: Expected Obj, but got I
			//IL_02a9: Expected Obj, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+34]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+34]");
			object obj2;
			object obj3;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (InAppPurchase.Internal.EditorPurchaseProvider+<ProductRequestCoroutine>d__24)+34]");
				obj2 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6+C]");
				obj3 = 0;
			}
			else
			{
				obj3 = 1;
				obj2 = this;
			}
			bool result;
			object obj4 = default;
			object obj22 = default;
			bool flag4 = default;
			object obj19 = default;
			for (result = false; obj4 != obj3; obj4 = obj22 + 1, result = flag4)
			{
				object obj5 = obj4 << 2;
				object obj6 = obj2 + obj5;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16+10]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16+14]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v21+28]");
				if ((nint)0 == -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A98");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v21+24]");
				object obj10 = (nint)0 & (nint)0x10;
				bool flag = obj10 == null;
				object obj11 = (flag ? 1 : 0) ^ 1;
				if (obj11 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v21+2A]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16+8]");
						object obj12 = (nint)0 & (nint)0x3FFF;
						object obj13 = obj12 + 6161;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v107 @ S2_v13 (should have been resolved before IL gen)");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16+8]");
						object obj14 = (nint)0 & (nint)0xFFF;
						object obj15 = obj14 + 1797;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v114 @ S1_v31 (should have been resolved before IL gen)");
					}
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v21+28]");
				if ((nint)0 != -1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16+10]");
					bool flag2;
					if ((nint)0 != 0)
					{
						object obj16 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ S0_v64+9C]");
						object obj17 = (nint)0 & (nint)0x100;
						flag2 = obj17 != null;
					}
					else
					{
						flag2 = false;
					}
					if (!flag2 && _003C_003E2__current != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ S0_v21+2B]");
						object obj18 = (nint)0 & (nint)3;
						bool flag3 = (nint)obj18 == 2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120B8");
						if (flag3)
						{
							if (obj19 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E09");
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8E0A");
							}
						}
						else if (obj19 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
						}
						continue;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ S0_v16+8]");
				object obj20 = (nint)0 & (nint)0x3FFF;
				object obj21 = obj20 + 6161;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v132 @ S2_v6 (should have been resolved before IL gen)");
			}
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

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public IPurchaseValidationResult validationResult;

		public _003C_003Ec__DisplayClass25_0()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}

		internal void _003CPurchaseCoroutine_003Eb__0(IPurchaseValidationResult purchaseValidationResult)
		{
			validationResult = purchaseValidationResult;
		}
	}

	private sealed class _003CPurchaseCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		public EditorPurchaseProvider _003C_003E4__this;

		public string productId;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Expected Obj, but got Unknown
				//IL_008b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Expected Obj, but got Unknown
				//IL_00ac: Expected Obj, but got I4
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Expected Obj, but got Unknown
				//IL_00d5: Expected Obj, but got I4
				//IL_024b: Expected I4, but got Obj
				//IL_011d: Expected Obj, but got I4
				//IL_0135: Expected I, but got Obj
				//IL_014b: Expected Obj, but got I
				//IL_0271: Expected Obj, but got I4
				//IL_0236: Expected Obj, but got I4
				//IL_03b0: Expected I4, but got Obj
				//IL_03b0: Expected I4, but got Obj
				//IL_03db: Expected I, but got Obj
				//IL_03f1: Expected Obj, but got I
				//IL_0176: Expected I, but got Obj
				//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c0: Expected Obj, but got Unknown
				//IL_01c9: Expected Obj, but got I4
				//IL_01dd: Expected Obj, but got I4
				//IL_0284: Expected I, but got Obj
				//IL_02d1: Expected I, but got Obj
				//IL_02e7: Expected Obj, but got I
				//IL_0312: Expected I, but got Obj
				EditorPurchaseProvider editorPurchaseProvider = _003C_003E4__this;
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
						object obj = _003C_003E8__1 + 8;
						obj = 0;
						if (editorPurchaseProvider._purchaseValidationServer != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
							nint num = 0;
							_ = 0;
							int num2 = default;
							object obj2 = num2 + 16;
							obj2 = _003C_003E8__1;
							nint num3 = (nint)typeof(PurchaseValidationExtensions);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S2_v25 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+BA]");
							object obj3 = (nint)0 & (nint)0x200;
							if (obj3 != null)
							{
								nint num4 = (nint)typeof(PurchaseValidationExtensions);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ S2_v31 (Il2CppClass<InAppPurchase.Internal.PurchaseValidationExtensions>)+74]");
								if ((nint)0 == 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
								}
							}
							((DeflateManager)(object)editorPurchaseProvider._purchaseValidationServer).send_all_trees((int)productId, (int)"EditorPurchaseReceipt", num2);
							_003C_003Ec__DisplayClass25_0 obj4 = _003C_003E8__1;
							if (obj4.validationResult == null)
							{
								object obj5 = this + 12;
								obj5 = 0;
								_003C_003E1__state = 2;
								return 1;
							}
						}
					}
					float time = Time.time;
					if (time < 0f)
					{
						object obj6 = 1;
					}
					else
					{
						string text = string.ConcatArray((string[])(object)"restore", (int)productId);
						((TooltipAttribute)(object)text)._002Ector(productId);
						RenderPipelineManager.CleanupRenderPipeline();
						object obj6 = 0;
					}
					nint num5 = (nint)typeof(EditorPurchaseProvider);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ S0_v26 (Il2CppClass<InAppPurchase.Internal.EditorPurchaseProvider>)+BA]");
					object obj7 = (nint)0 & (nint)0x200;
					if (obj7 != null)
					{
						nint num6 = (nint)typeof(EditorPurchaseProvider);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ S0_v57 (Il2CppClass<InAppPurchase.Internal.EditorPurchaseProvider>)+74]");
						if ((nint)0 == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
						}
					}
					if (~(USE_SINGLE_RESTORE_INSTEAD_OF_PURCHASE ? 1u : 0u) == 0)
					{
						nint num7 = (nint)typeof(InAppData);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ S0_v38 (Il2CppClass<InApp.InAppData>)+BA]");
						object obj8 = (nint)0 & (nint)0x200;
						if (obj8 != null)
						{
							nint num8 = (nint)typeof(InAppData);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ S0_v51 (Il2CppClass<InApp.InAppData>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						InAppItemModel inAppItemModel = InAppData.inAppData.get_Item(productId);
						if (~(inAppItemModel.isConsumable ? 1u : 0u) != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
							return null;
						}
					}
					_003C_003Ec__DisplayClass25_0 obj9 = _003C_003E8__1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8940");
					return null;
				}
				_003C_003E1__state = -1;
				object obj10 = this + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				object obj11 = default;
				obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0f;
				object obj12 = this + 12;
				object obj13 = default;
				obj12 = obj13;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CPurchaseCoroutine_003Ed__25(int _003C_003E1__state)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
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

	private sealed class _003CRestoreCoroutine_003Ed__26(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public string[] productIds;

		public EditorPurchaseProvider _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_004a: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Expected Obj, but got Unknown
				//IL_006b: Expected Obj, but got I4
				//IL_00bf: Expected Obj, but got I4
				//IL_01e2: Expected Obj, but got I4
				//IL_00d2: Expected I, but got Obj
				//IL_00e8: Expected Obj, but got I
				//IL_01d4: Expected Obj, but got I4
				//IL_0246: Unknown result type (might be due to invalid IL or missing references)
				//IL_024b: Expected Obj, but got Unknown
				//IL_029a: Unknown result type (might be due to invalid IL or missing references)
				//IL_029f: Expected Obj, but got Unknown
				//IL_0113: Expected I, but got Obj
				//IL_015d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0162: Expected Obj, but got Unknown
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_0195: Expected Obj, but got Unknown
				EditorPurchaseProvider editorPurchaseProvider = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						float time = Time.time;
						IAsyncResult result;
						if (time < 0f)
						{
							result = null;
						}
						else
						{
							object obj = 0;
							object obj2 = default;
							object obj10 = default;
							while (true)
							{
								string[] array = productIds;
								if ((nint)obj2 >= array.Length)
								{
									break;
								}
								nint num = (nint)typeof(EditorPurchaseProvider);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ S0_v35 (Il2CppClass<InAppPurchase.Internal.EditorPurchaseProvider>)+BA]");
								object obj3 = (nint)0 & (nint)0x200;
								if (obj3 != null)
								{
									nint num2 = (nint)typeof(EditorPurchaseProvider);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ S0_v50 (Il2CppClass<InAppPurchase.Internal.EditorPurchaseProvider>)+74]");
									if ((nint)0 == 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
									}
								}
								object obj4 = productIds + 16;
								object obj5 = obj2 << 2;
								object item = obj4 + obj5;
								if (LIST_OF_IDS_TO_RESTORE.Contains((string)item))
								{
									object obj6 = productIds + 16;
									object obj7 = obj2 << 2;
									object obj8 = obj6 + obj7;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8967");
									object obj9 = obj + 1;
									obj = obj9;
								}
								obj2 = obj10 + 1;
							}
							result = (((nint)obj >= 1) ? ((IAsyncResult)3) : ((IAsyncResult)2));
						}
						editorPurchaseProvider._restorePurchaseFinishedDelegate.EndInvoke(result);
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				_ = 0f;
				object obj11 = this + 12;
				object obj12 = default;
				obj11 = obj12;
				_003C_003E1__state = 1;
				return 1;
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

	private const float INITIALIZE_FAIL_CHANCE = 0f;

	private const float PRODUCTREQUEST_FAIL_CHANCE = 0f;

	private const float PRODUCTREQUEST_DELAY = 0f;

	private const float PRODUCTREQUEST_INVALID_CHANCE = 0f;

	private const float PURCHASE_DELAY = 0f;

	private const float PURCHASE_FAIL_CHANCE = 0f;

	private static readonly string[] DUMMY_PRICES_LOCALIZED;

	private static readonly bool USE_SINGLE_RESTORE_INSTEAD_OF_PURCHASE;

	private PurchaseDelegate _purchaseDelegate;

	private ProductInfoRequestDelegate _productRequestDelegate;

	private ItemRestoredDelegate _itemRestoredDelegate;

	private RestorePurchaseFinishedDelegate _restorePurchaseFinishedDelegate;

	private IPurchaseValidationServer _purchaseValidationServer;

	private IInAppManager _inAppManager;

	private MonoBehaviour _coroutineBehaviour;

	public static readonly List<string> LIST_OF_IDS_TO_RESTORE;

	public bool IsValidationServerSpecified => false;

	public void Init(IInAppManager inAppManager, IPurchaseValidationServer purchaseValidationServer)
	{
		((Action<string>)(object)inAppManager)?.Invoke((string)(object)purchaseValidationServer);
	}

	public bool CanMakePurchases()
	{
		return _purchaseValidationServer != null;
	}

	public void RequestProductInfo(string[] productIds)
	{
		if (productIds != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}

	public unsafe bool StartPurchase(string productId)
	{
		//IL_0009: Expected Obj, but got I4
		//IL_00d1: Expected I, but got Obj
		//IL_00eb: Expected I, but got Obj
		//IL_00f8: Expected I, but got Obj
		//IL_00de: Expected I, but got Obj
		IFormatProvider formatProvider = (IFormatProvider)0;
		if (!((int*)productId)->System_002EIConvertible_002EToBoolean(formatProvider))
		{
			goto IL_00fd;
		}
		nint num;
		if (formatProvider != null)
		{
			if ((nint)formatProvider == 1)
			{
				goto IL_00fd;
			}
			if ((nint)formatProvider != 2)
			{
				if ((nint)formatProvider != 3)
				{
					if ((nint)formatProvider != 4)
					{
						goto IL_00fd;
					}
					num = (nint)formatProvider;
				}
				else
				{
					num = (nint)formatProvider;
				}
			}
			else
			{
				num = (nint)formatProvider;
			}
		}
		else
		{
			num = (nint)formatProvider;
		}
		goto IL_010b;
		IL_00fd:
		num = 1;
		goto IL_010b;
		IL_010b:
		return (byte)num != 0;
	}

	public unsafe bool StartPurchase(string productId, string cookie)
	{
		//IL_026a: Expected Obj, but got I4
		//IL_0278: Expected I, but got Obj
		//IL_028e: Expected Obj, but got I
		//IL_02e5: Expected I4, but got Obj
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected Obj, but got Unknown
		//IL_00d8: Expected Obj, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected Obj, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected Obj, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected Obj, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected Obj, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected Obj, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected Obj, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected Obj, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected Obj, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected Obj, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected Obj, but got Unknown
		IFormatProvider formatProvider = (IFormatProvider)0;
		nint num = (nint)typeof(AndroidPurchaseProvider);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ S0_v10 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(AndroidPurchaseProvider);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ S0_v67 (Il2CppClass<InAppPurchase.Internal.AndroidPurchaseProvider>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		string text = productId.Substring((int)AndroidPurchaseProvider.SEPARATOR_FOR_STRING_SPLIT);
		object obj2 = text + 12;
		string text2;
		if ((nint)obj2 >= 1)
		{
			object obj3 = text + 16;
			if (((int*)obj3)->System_002EIConvertible_002EToBoolean(formatProvider))
			{
				object obj4 = (object)formatProvider << 2;
				object obj5 = obj4 + 1;
				if (obj2 == obj5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
					object obj6 = 0;
					object obj22 = default;
					while (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj6) < System.Runtime.CompilerServices.Unsafe.As<IFormatProvider, UIntPtr>(ref formatProvider))
					{
						object obj7 = text + 16;
						object obj8 = obj6 << 2;
						object obj9 = obj8 + 1;
						object obj10 = obj9 << 2;
						object obj11 = obj7 + obj10;
						object obj12 = obj9 << 2;
						object obj13 = text + obj12;
						object obj14 = obj13 + 20;
						object obj15 = obj9 << 2;
						object obj16 = text + obj15;
						object obj17 = obj16 + 24;
						object obj18 = obj9 << 2;
						object obj19 = text + obj18;
						object obj20 = obj19 + 28;
						object obj21 = obj22 + 16;
						object obj23 = obj6 << 4;
						object obj24 = obj21 + obj23;
						obj24 = obj11;
						object obj25 = obj24 + 4;
						obj25 = obj14;
						object obj26 = obj24 + 8;
						obj26 = obj17;
						object obj27 = obj24 + 12;
						obj27 = obj20;
						object obj28 = obj6 + 1;
						obj6 = obj28;
					}
					text2 = (string)obj22;
					return true;
				}
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		object obj29 = default;
		text2 = (string)obj29;
		return false;
	}

	public void FinishPurchase(string productId, string transactionId, string purchaseToken)
	{
		if (_purchaseValidationServer != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8960");
		}
	}

	public bool RestoreNonConsumablePurchases(string[] productIds)
	{
		return ((IOSPurchaseProvider)this).StartPurchase((string)(object)productIds, (string)null);
	}

	private IEnumerator ProductRequestCoroutine(string[] productIds)
	{
		//IL_001d: Expected Obj, but got I4
		//IL_002c: Expected Obj, but got I4
		bool flag = ((IOSPurchaseProvider)this).StartPurchase((string)(object)productIds);
		Coroutine coroutine = _coroutineBehaviour.StartCoroutine_Auto((IEnumerator)flag);
		return (IEnumerator)1;
	}

	private IEnumerator PurchaseCoroutine(string productId)
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
		obj2 = productId;
		return enumerator;
	}

	private IEnumerator RestoreCoroutine(string[] productIds)
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
		object obj2 = enumerator + 24;
		obj2 = productIds;
		return enumerator;
	}

	public EditorPurchaseProvider()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	static EditorPurchaseProvider()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected Obj, but got Unknown
		//IL_0026: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		char[] array = default;
		object obj = array + 16;
		obj = 59;
		AndroidPurchaseProvider.SEPARATOR_FOR_STRING_SPLIT = array;
	}
}
