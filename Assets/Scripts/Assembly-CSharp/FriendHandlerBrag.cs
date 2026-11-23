using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

public class FriendHandlerBrag : MonoBehaviour
{
	private sealed class _003CUpdatePanelAfterFrames_003Ed__44(int _003C_003E1__state) : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state = _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public FriendHandlerBrag _003C_003E4__this;

		private int _003CpassedFrames_003E5__2;

		object IEnumerator<object>.Current => _003C_003E2__current;

		object IEnumerator.Current => _003C_003E2__current;

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			FriendHandlerBrag friendHandlerBrag = _003C_003E4__this;
			int num;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state != 1)
				{
					goto IL_00b8;
				}
				_003C_003E1__state = -1;
				num = _003CpassedFrames_003E5__2;
			}
			else
			{
				_003CpassedFrames_003E5__2 = 0;
				_003C_003E1__state = -1;
				num = 0;
			}
			if (num >= frames)
			{
				Transform transform = friendHandlerBrag._currentGrid.transform;
				Transform parent = transform.parent;
				UIPanel component = parent.GetComponent<UIPanel>();
				component.Refresh();
				friendHandlerBrag._ScrollGridToUser(component);
				goto IL_00b8;
			}
			_003C_003E2__current = null;
			int num2 = num + 1;
			_003CpassedFrames_003E5__2 = num2;
			_003C_003E1__state = 1;
			return true;
			IL_00b8:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			NotSupportedException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @21F");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @222");
		}
	}

	private GameObject friendNoBragPrefab;

	private GameObject facebookLoginPrefab;

	private GameObject gameCenterLoginPrefab;

	private GameObject facebookBonus;

	private GameObject gameCenterBonus;

	private GameObject OfflineParent;

	private GameObject OnlineFacebookParent;

	private GameObject OnlineGameCenterParent;

	private GameObject OnlineBothNoBragParent;

	private UIGrid OnlineFacebookGrid;

	private UIGrid OnlineGameCenterGrid;

	private UIGrid OnlineBothNoBragGrid;

	private GameObject FacebookLoginButtonParent;

	private GameObject GameCenterLoginButtonParent;

	private UILabel gettingLabel;

	private const float THREE_QUARTERS_LOGIN_BAR_HEIGHT = 18f;

	private const float DISTANCE_BETWEEN_GC_FB = 40f;

	private ScrollViewHeightResizer heightResizerBothNoBrag;

	private Vector3 initialPositionBothGrid;

	private float initialHeightBothGrid;

	private bool initializedPosition;

	private UIGrid _currentGrid;

	private List<Friend> _bragList;

	private int _friendIndexOnTopOfPlayer;

	private int _friendsCount;

	[NonSerialized]
	public string preBragPopupString;

	private bool canWeBrag;

	private static FriendHandlerBrag _instance;

	public List<Friend> bragList => _bragList;

	public static FriendHandlerBrag instance
	{
		get
		{
			if (_instance == null)
			{
			}
			return _instance;
		}
	}

	private void ClearAllGrids()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0b67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected Obj, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7f: Expected Obj, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Expected Obj, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected Obj, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected Obj, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected Obj, but got Unknown
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Expected Obj, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b5: Expected Obj, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected Obj, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected Obj, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected Obj, but got Unknown
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		Transform transform = OnlineBothNoBragGrid.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 32;
		object obj4 = obj + 44;
		obj = obj4;
		_ = 0;
		object obj5 = default;
		object obj9 = default;
		object obj13 = default;
		object obj14 = default;
		object obj16 = default;
		object obj17 = default;
		object obj20 = default;
		object obj21 = default;
		object obj22 = default;
		object obj23 = default;
		object obj24 = default;
		object obj25 = default;
		object obj26 = default;
		object obj27 = default;
		object obj28 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_02ea;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												continue;
											}
										}
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
									goto IL_025b;
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			goto IL_025b;
			IL_02ea:
			object obj6 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			Transform transform2 = OnlineFacebookGrid.transform;
			IEnumerator enumerator2 = transform2.GetEnumerator();
			object obj7 = obj + 28;
			object obj8 = obj + 40;
			obj = obj8;
			_ = 0;
			object obj15;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj9 == null)
					{
						goto IL_06a7;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													continue;
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_0618;
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				goto IL_0618;
				IL_06a7:
				object obj10 = obj + 8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
				Transform transform3 = OnlineGameCenterGrid.transform;
				IEnumerator enumerator3 = transform3.GetEnumerator();
				object obj11 = obj + 24;
				object obj12 = obj + 36;
				obj = obj12;
				_ = 0;
				goto IL_0c26;
				IL_0618:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag = obj13 != obj14;
				obj15 = obj16;
				if (flag)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_06a7;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj15 = obj17;
				break;
			}
			_ = 0;
			object obj18 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0aea;
			}
			goto IL_0b13;
			IL_0a9e:
			_ = 0;
			object obj19 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0aea;
			}
			goto IL_0b13;
			IL_0b13:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			return;
			IL_0c26:
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					if (obj20 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
										if ((nint)0 != 1)
										{
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
											if ((nint)0 != 1)
											{
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
												if ((nint)0 != 1)
												{
													continue;
												}
											}
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
										goto IL_09e3;
									}
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				goto IL_09e3;
				IL_09e3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj21 == obj22;
				bool flag3 = !flag2;
				obj15 = obj23;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj15 = obj24;
				}
				goto IL_0a9e;
			}
			break;
			IL_025b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag4 = obj25 != obj26;
			obj15 = obj27;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_02ea;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj15 = obj28;
			}
			_ = 0;
			object obj29 = obj + 8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 == 1)
			{
				goto IL_0aea;
			}
			goto IL_0b13;
			IL_0aea:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			break;
		}
		object obj30 = obj + 8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public void ShowGettingReadyLabel()
	{
		ClearEverything();
		GameObject go = gettingLabel.gameObject;
		NGUITools.SetActive(go, state: true);
	}

	public void ClearEverything()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected Obj, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected Obj, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected Obj, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Expected Obj, but got Unknown
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected Obj, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected Obj, but got Unknown
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected Obj, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 - 48;
		_ = 0;
		_ = 0;
		_ = 0;
		ClearAllGrids();
		NGUITools.SetActive(OnlineBothNoBragParent, state: false);
		NGUITools.SetActive(OnlineFacebookParent, state: false);
		NGUITools.SetActive(OnlineGameCenterParent, state: false);
		NGUITools.SetActive(OfflineParent, state: false);
		GameObject go = gettingLabel.gameObject;
		NGUITools.SetActive(go, state: false);
		Transform transform = FacebookLoginButtonParent.transform;
		IEnumerator enumerator = transform.GetEnumerator();
		object obj3 = obj + 36;
		object obj4 = obj + 44;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
		_ = 0;
		object obj5 = default;
		object obj6 = default;
		object obj7 = default;
		object obj9 = default;
		object obj10 = default;
		object obj16 = default;
		object obj17 = default;
		object obj18 = default;
		object obj19 = default;
		object obj20 = default;
		while (true)
		{
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				if (obj5 == null)
				{
					goto IL_02d6;
				}
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									continue;
								}
							}
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
			bool flag = obj6 != obj7;
			object obj8 = obj9;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					goto IL_02d6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				obj8 = obj10;
			}
			_ = 0;
			object obj11 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0641;
			}
			goto IL_0651;
			IL_05f8:
			_ = 0;
			object obj12 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
			if ((nint)0 != 1)
			{
				goto IL_0641;
			}
			goto IL_0651;
			IL_0641:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A");
			break;
			IL_0651:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22C");
			return;
			IL_02d6:
			object obj13 = obj + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
			Transform transform2 = GameCenterLoginButtonParent.transform;
			IEnumerator enumerator2 = transform2.GetEnumerator();
			object obj14 = obj + 32;
			object obj15 = obj + 40;
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			while (true)
			{
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
				if ((nint)0 != 1)
				{
					if (obj16 == null)
					{
						break;
					}
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
						if ((nint)0 != 1)
						{
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
							if ((nint)0 != 1)
							{
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
								if ((nint)0 != 1)
								{
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @C");
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
									if ((nint)0 != 1)
									{
										continue;
									}
								}
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @0");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @8");
				bool flag2 = obj17 == obj18;
				bool flag3 = !flag2;
				obj8 = obj19;
				if (!flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [4B2584]");
					if ((nint)0 != 1)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @5");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1");
					obj8 = obj20;
				}
				goto IL_05f8;
			}
			break;
		}
		object obj21 = obj + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @38A");
	}

	public void GoOffline(bool enableButtons)
	{
		ClearEverything();
		NGUITools.SetActive(OfflineParent, state: true);
		GameOverOfflineHelper component = OfflineParent.GetComponent<GameOverOfflineHelper>();
		PlayerInfo playerInfo = PlayerInfo.Instance;
		if (~(playerInfo._hasPayedOutFacebook ? 1u : 0u) == 0)
		{
			NGUITools.SetActive(facebookBonus, state: false);
		}
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		if (~(playerInfo2._hasPayedOutGameCenter ? 1u : 0u) == 0)
		{
			NGUITools.SetActive(gameCenterBonus, state: false);
		}
	}

	private void SetCurrentGridWhenLoginStateBoth(Friend[] friends)
	{
		_currentGrid = OnlineBothNoBragGrid;
		NGUITools.SetActive(OnlineBothNoBragParent, state: true);
		GameObject go = _currentGrid.gameObject;
		UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
		uIScrollView.ResetPosition();
	}

	private unsafe void SetCurrentGridWhenLoginStateGameCenter(Friend[] friends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0034: Expected Obj, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected Obj, but got Unknown
		//IL_0071: Expected Obj, but got I4
		//IL_0097: Expected Obj, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected Obj, but got Unknown
		//IL_02a0: Expected native int or pointer, but got VT
		//IL_02b2: Expected F4, but got Obj
		//IL_02ad: Expected native int or pointer, but got VT
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_currentGrid = OnlineGameCenterGrid;
		NGUITools.SetActive(OnlineGameCenterParent, state: true);
		SocialManager socialManager = SocialManager.instance;
		bool facebookIsLoggedIn = socialManager.facebookIsLoggedIn;
		bool flag = !facebookIsLoggedIn;
		object obj2 = 1;
		if (!flag)
		{
			SocialManager socialManager2 = SocialManager.instance;
			bool facebookIsLoggedIn2 = socialManager2.facebookIsLoggedIn;
			bool flag2 = !facebookIsLoggedIn2;
			obj2 = 0;
			if (!flag2)
			{
				bool flag3 = AreFacebookFriendsConsolidated();
				obj2 = (flag3 ? 1 : 0) ^ 1;
			}
		}
		bool flag4 = facebookLoginPrefab;
		object obj3 = flag4 & obj2;
		if (obj3 != null)
		{
			GameObject gameObject = NGUITools.AddChild(FacebookLoginButtonParent, facebookLoginPrefab);
			gameObject.name = "facebookLoginButton";
			FacebookLoginButtonOnline component = gameObject.GetComponent<FacebookLoginButtonOnline>();
			if (component != null)
			{
				SocialManager socialManager3 = SocialManager.instance;
				bool facebookIsLoggedIn3 = socialManager3.facebookIsLoggedIn;
				PlayerInfo playerInfo = PlayerInfo.Instance;
				component.Init(facebookIsLoggedIn3, playerInfo._hasPayedOutFacebook);
			}
			Transform transform = GameCenterLoginButtonParent.transform;
			int childCount = transform.childCount;
			Transform transform2 = gameObject.transform;
			object obj4;
			if (childCount == 0)
			{
				_ = 0;
				obj4 = vector + 32;
				float num = -18f;
			}
			else
			{
				_ = 0;
				obj4 = vector + 16;
				float num = -58f;
			}
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj4;
			transform2.localPosition = vector;
		}
		GameObject go = _currentGrid.gameObject;
		UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
		uIScrollView.ResetPosition();
	}

	private unsafe void SetCurrentGridWhenLoginStateFacebook(Friend[] friends)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected Obj, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected Obj, but got Unknown
		//IL_02ac: Expected native int or pointer, but got VT
		//IL_02be: Expected F4, but got Obj
		//IL_02b9: Expected native int or pointer, but got VT
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected Obj, but got Unknown
		object obj = default;
		Vector3 vector = (Vector3)(obj - 48);
		_currentGrid = OnlineFacebookGrid;
		NGUITools.SetActive(OnlineFacebookParent, state: true);
		RuntimePlatform platform = Application.platform;
		if (platform != RuntimePlatform.IPhonePlayer)
		{
			return;
		}
		if (!Globals.DEBUG_USE_DEBUG_LOGIN_STATE)
		{
			SocialManager socialManager = SocialManager.instance;
			if (socialManager.gamecenterIsLoggedIn)
			{
				SocialManager socialManager2 = SocialManager.instance;
				if (!socialManager2.gamecenterIsLoggedIn || AreGamecenterFriendsConsolidated())
				{
					goto IL_0246;
				}
			}
		}
		if (gameCenterLoginPrefab != null)
		{
			GameObject gameObject = NGUITools.AddChild(GameCenterLoginButtonParent, gameCenterLoginPrefab);
			gameObject.name = "gameCenterLoginButton";
			GameCenterButton component = gameObject.GetComponent<GameCenterButton>();
			if (component != null)
			{
				SocialManager socialManager3 = SocialManager.instance;
				bool gamecenterIsLoggedIn = socialManager3.gamecenterIsLoggedIn;
				PlayerInfo playerInfo = PlayerInfo.Instance;
				component.Init(gamecenterIsLoggedIn, playerInfo._hasPayedOutGameCenter);
			}
			Transform transform = FacebookLoginButtonParent.transform;
			int childCount = transform.childCount;
			Transform transform2 = gameObject.transform;
			object obj2;
			if (childCount == 0)
			{
				_ = 0;
				obj2 = vector + 32;
				float num = -18f;
			}
			else
			{
				_ = 0;
				obj2 = vector + 16;
				float num = -58f;
			}
			_ = 0;
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)obj2;
			transform2.localPosition = vector;
		}
		goto IL_0246;
		IL_0246:
		UIGrid currentGrid = _currentGrid;
		object obj3 = currentGrid - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ S1_v12+BC] (should have been resolved before IL gen)");
	}

	private void SetCurrentGridWhenUsingCachedLeaderboard(Friend[] friends)
	{
		SetCurrentGridWhenLoginStateGameCenter((Friend[])(object)this);
		SetCurrentGridWhenLoginStateBoth((Friend[])(object)this);
	}

	private void AddFriendsIntoGrid(Friend[] friends, Transform cursorTransform)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected Obj, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got I4
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected Obj, but got Unknown
		//IL_0620: Expected Obj, but got I
		//IL_05a0: Expected Obj, but got I4
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected Obj, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected Obj, but got Unknown
		//IL_067d: Expected Obj, but got I
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected Obj, but got Unknown
		//IL_0391: Expected Obj, but got I4
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected Obj, but got Unknown
		//IL_03ca: Expected Obj, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected Obj, but got Unknown
		//IL_0291: Expected Obj, but got I
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected Obj, but got Unknown
		//IL_0306: Expected Obj, but got I
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected Obj, but got Unknown
		//IL_044f: Expected Obj, but got I
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I
		object obj2 = default;
		object obj = obj2 - 16;
		int num = 0;
		int num2 = 1;
		object arg = default;
		object obj4 = default;
		while (friends.Length > num)
		{
			GameObject parent = _currentGrid.gameObject;
			GameObject gameObject = NGUITools.AddChild(parent, friendNoBragPrefab);
			object obj3 = obj + 12;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			string text = $"{arg:000}";
			gameObject.name = text;
			FriendHelperBrag component = gameObject.GetComponent<FriendHelperBrag>();
			FriendHelperBrag friendHelperBrag = component;
			GameObject gameObject2 = gameObject;
			obj4 = 1;
			int num3 = num << 2;
			object obj5 = friends + num3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ S0_v55+10]");
			object obj6 = 0;
			PlayerInfo playerInfo = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ S0_v56+C]");
			if ((nint)0 <= (nint)playerInfo._highScore)
			{
				int num4 = num << 2;
				object obj7 = friends + num4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ S0_v103+10]");
				object obj8 = 0;
				PlayerInfo playerInfo2 = PlayerInfo.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ S0_v104+C]");
				if ((nint)0 > (nint)playerInfo2._formerHighScore)
				{
					canWeBrag = true;
				}
			}
			int num5 = num << 2;
			object obj9 = friends + num5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ S0_v64+10]");
			object obj10 = 0;
			PlayerInfo playerInfo3 = PlayerInfo.Instance;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ S0_v65+C]");
			bool flag = (nint)0 >= (nint)playerInfo3._highScore;
			bool flag2 = false;
			if (!flag)
			{
				int num6 = num << 2;
				object obj11 = friends + num6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ S0_v90+10]");
				object obj12 = 0;
				PlayerInfo playerInfo4 = PlayerInfo.Instance;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ S0_v91+C]");
				bool flag3 = (nint)0 < (nint)playerInfo4._formerHighScore;
				flag2 = false;
				if (!flag3)
				{
					flag2 = _currentGrid;
				}
			}
			int num7 = num << 2;
			object obj13 = friends + num7;
			int num8 = num2 / 2;
			object obj14 = num8 * 2;
			object obj15 = num2 - obj14;
			bool backgroundActive = (nint)obj15 == 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ S1_v45+10]");
			friendHelperBrag.InitFriend((Friend)0, num2, backgroundActive);
			if (obj4 == null)
			{
				Transform transform = gameObject2.transform;
			}
			if (flag2)
			{
				int num9 = num << 2;
				object obj16 = friends + num9;
				List<Friend> list = _bragList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ S1_v54+10]");
				if (!list.Contains((Friend)0))
				{
					int num10 = num << 2;
					object obj17 = friends + num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S1_v57+10]");
					AddBragFriend((Friend)0);
				}
			}
			int num11 = num2 + 1;
			_friendsCount = friends.Length;
			int num12 = num + 1;
			num = num12;
			num2 = num11;
		}
		if (obj4 == null)
		{
			GameObject parent2 = _currentGrid.gameObject;
			GameObject gameObject3 = NGUITools.AddChild(parent2, friendNoBragPrefab);
			object obj18 = obj + 4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @227");
			object arg2 = default;
			string text2 = $"{arg2:000}";
			gameObject3.name = text2;
			FriendHelperBrag component2 = gameObject3.GetComponent<FriendHelperBrag>();
			Transform transform2 = gameObject3.transform;
			int num13 = num2 / 2;
			object obj19 = num13 * 2;
			object obj20 = num2 - obj19;
			bool backgroundActive2 = (nint)obj20 == 1;
			component2.InitLocalUser(num2, backgroundActive2);
			_friendIndexOnTopOfPlayer = friends.Length;
		}
	}

	private unsafe void SetPropertiesWhenCurrentGridIsOnlineBothNoBragGrid()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected Obj, but got Unknown
		//IL_00b5: Expected F4, but got I
		//IL_00b0: Expected native int or pointer, but got VT
		//IL_00d4: Expected F4, but got I
		//IL_00cf: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 32);
		UIGrid currentGrid = _currentGrid;
		currentGrid.sorting = UIGrid.Sorting.None;
		object obj2 = currentGrid - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v24 @ S1_v6+BC] (should have been resolved before IL gen)");
		GameObject go = _currentGrid.gameObject;
		UIScrollView uIScrollView = NGUITools.FindInParents<UIScrollView>(go);
		uIScrollView.ResetPosition();
		ScrollViewHeightResizer scrollViewHeightResizer = heightResizerBothNoBrag;
		float staticObjectsHeight = initialHeightBothGrid - 40f;
		scrollViewHeightResizer._staticObjectsHeight = staticObjectsHeight;
		Transform transform = OnlineBothNoBragParent.transform;
		float num = (float)initialPositionBothGrid + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHandlerBrag)+50]");
		float num2 = 0f + 37f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHandlerBrag)+54]");
		float num3 = 0f + 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+18]");
		((Vector3*)(nint)vector)->z = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+10]");
		((Vector3*)(nint)vector)->x = 0f;
		transform.localPosition = vector;
		heightResizerBothNoBrag.RearrangeWidgets();
	}

	private unsafe void SetPropertiesWhenCurrentGridIsCachedPlayers(bool hasGameCenter)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected VT, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected Obj, but got Unknown
		//IL_00c6: Expected F4, but got I
		//IL_00c1: Expected native int or pointer, but got VT
		//IL_00e5: Expected F4, but got I
		//IL_00e0: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj + -64);
		canWeBrag = false;
		ScrollViewHeightResizer scrollViewHeightResizer = heightResizerBothNoBrag;
		if (hasGameCenter)
		{
			float staticObjectsHeight = initialHeightBothGrid + 40f;
			scrollViewHeightResizer._staticObjectsHeight = staticObjectsHeight;
			Transform transform = OnlineBothNoBragParent.transform;
			float num = (float)initialPositionBothGrid - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHandlerBrag)+50]");
			float num2 = 0f - 46f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHandlerBrag)+54]");
			float num3 = 0f - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+38]");
			((Vector3*)(nint)vector)->z = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+30]");
			((Vector3*)(nint)vector)->x = 0f;
			transform.localPosition = vector;
		}
		else
		{
			scrollViewHeightResizer._staticObjectsHeight = initialHeightBothGrid;
			Transform transform2 = OnlineBothNoBragParent.transform;
			float num4 = (float)initialPositionBothGrid - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHandlerBrag)+50]");
			float num5 = 0f - 6f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHandlerBrag)+54]");
			float num6 = 0f - 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+28]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector3)+20]");
			_ = 0;
			Vector3 localPosition = vector + 16;
			transform2.localPosition = localPosition;
		}
		UIGrid currentGrid = _currentGrid;
		object obj2 = currentGrid - -64;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v104 @ S1_v6+BC] (should have been resolved before IL gen)");
		heightResizerBothNoBrag.RearrangeWidgets();
	}

	private void BragNotifyFriends()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		PlayerInfo playerInfo2 = PlayerInfo.Instance;
		if (playerInfo._highScore > playerInfo2._formerHighScore)
		{
			GameStats gameStats = GameStats.Instance;
			if (!gameStats.BragNotifyDone)
			{
				SocialManager socialManager = SocialManager.instance;
				PlayerInfo playerInfo3 = PlayerInfo.Instance;
				socialManager.BragNotify(playerInfo3._formerHighScore, _bragList);
				GameStats gameStats2 = GameStats.Instance;
				gameStats2.BragNotifyDone = true;
			}
		}
	}

	private IEnumerator UpdatePanelAfterFrames(int frames)
	{
		_ = 0;
		IEnumerator result = default;
		return result;
	}

	private bool AreFacebookFriendsConsolidated()
	{
		SocialManager socialManager = SocialManager.instance;
		return (byte)(socialManager._consolidationState & 1) != 0;
	}

	private bool AreGamecenterFriendsConsolidated()
	{
		SocialManager socialManager = SocialManager.instance;
		int num = socialManager._consolidationState & 2;
		return (byte)(num >> 1) != 0;
	}

	public unsafe void ShowFriendList()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_007f: Expected Obj, but got I4
		//IL_009b: Expected Obj, but got I4
		//IL_00d0: Expected Obj, but got I4
		//IL_016f: Expected Obj, but got I4
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected Obj, but got Unknown
		//IL_01a3: Expected Obj, but got I4
		//IL_02b2: Expected F4, but got I
		//IL_02ad: Expected native int or pointer, but got VT
		//IL_02c1: Expected F4, but got VT
		//IL_02bc: Expected native int or pointer, but got VT
		object obj = default;
		Vector3 vector = (Vector3)(obj - 16);
		Transform transform = base.transform;
		Transform parent = transform.parent;
		SocialManager socialManager = SocialManager.instance;
		Friend[] array = socialManager.FriendsSortedByScore();
		Globals.LogInState loginState = Globals.GetLoginState();
		SocialManager socialManager2 = SocialManager.instance;
		bool flag = ~(Globals.DEBUG_USE_DEBUG_LOGIN_STATE ? 1u : 0u) == 0 || AreFacebookFriendsConsolidated();
		object obj2 = loginState & (Globals.LogInState)(-3);
		bool flag2 = (nint)obj2 == 1;
		object obj3 = flag & flag2;
		Friend[] friends;
		object obj4;
		if (obj3 != null)
		{
			SetCurrentGridWhenLoginStateBoth((Friend[])(object)this);
			friends = array;
			obj4 = 0;
		}
		else
		{
			if ((socialManager2._fbState == SocialManager.FacebookState.LoggingIn || !AreFacebookFriendsConsolidated()) && !CachedLeaderboard.IsAvailable())
			{
				SetCurrentGridWhenLoginStateGameCenter((Friend[])(object)this);
				return;
			}
			bool flag3 = CachedLeaderboard.IsAvailable();
			bool flag4 = !flag3;
			friends = array;
			obj4 = 0;
			if (!flag4)
			{
				Friend[] array2 = CachedLeaderboard.Load();
				SetCurrentGridWhenUsingCachedLeaderboard((Friend[])(object)this);
				friends = array2;
				obj4 = 1;
			}
		}
		AddFriendsIntoGrid(friends, (Transform)(object)this);
		bool flag5 = _currentGrid == OnlineBothNoBragGrid;
		if (obj4 == null && flag5)
		{
			SetPropertiesWhenCurrentGridIsOnlineBothNoBragGrid();
		}
		else if (obj4 != null)
		{
			SetPropertiesWhenCurrentGridIsCachedPlayers(hasGameCenter: false);
		}
		else
		{
			UIGrid currentGrid = _currentGrid;
			currentGrid.sorting = UIGrid.Sorting.None;
			object obj5 = currentGrid - -64;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ S1_v21+BC] (should have been resolved before IL gen)");
			Transform transform2 = _currentGrid.transform;
			Transform parent2 = transform2.parent;
			UIPanel component = parent2.GetComponent<UIPanel>();
			UIScrollView component2 = component.GetComponent<UIScrollView>();
			bool flag6 = component2.RestrictWithinBounds(instant: true);
			Transform transform3 = _currentGrid.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (FriendHandlerBrag)+54]");
			((Vector3*)(nint)vector)->z = 0f;
			((Vector3*)(nint)vector)->x = (float)initialPositionBothGrid;
			transform3.localPosition = vector;
			ScrollViewHeightResizer scrollViewHeightResizer = heightResizerBothNoBrag;
			scrollViewHeightResizer._staticObjectsHeight = initialHeightBothGrid;
			scrollViewHeightResizer.RearrangeWidgets();
		}
		if (~(canWeBrag ? 1u : 0u) == 0)
		{
			BragNotifyFriends();
		}
		IEnumerator routine = UpdatePanelAfterFrames(1);
		Coroutine coroutine = StartCoroutine(routine);
	}

	public void AddBragFriend(Friend friend)
	{
		if (!_bragList.Contains(friend))
		{
			_bragList.Add(friend);
		}
	}

	public void RemoveBragFriend(Friend friend)
	{
		if (_bragList.Contains(friend))
		{
			bool flag = _bragList.Remove(friend);
		}
	}

	public void CompletedBrag()
	{
		GameObject gameObject = _currentGrid.gameObject;
		gameObject.BroadcastMessage("CompletedBragging", SendMessageOptions.DontRequireReceiver);
		((List<T>)(object)_bragList).Clear();
		PlayerInfo playerInfo = PlayerInfo.Instance;
		playerInfo.BragCompleted();
		ClearEverything();
		ShowFriendList();
	}

	private void MovedAwayFromGameOverScreenClicked()
	{
		PlayerInfo playerInfo = PlayerInfo.Instance;
		playerInfo.BragCompleted();
		((List<T>)(object)_bragList).Clear();
	}

	private void OnDisable()
	{
		MovedAwayFromGameOverScreenClicked();
	}

	private unsafe void _ScrollGridToUser(UIPanel dragPanel)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected VT, but got Unknown
		//IL_0026: Expected F4, but got I
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected VT, but got Unknown
		//IL_0101: Expected F4, but got I
		//IL_00fc: Expected native int or pointer, but got VT
		object obj = default;
		Vector2 vector = (Vector2)(obj + -64);
		int friendIndexOnTopOfPlayer = _friendIndexOnTopOfPlayer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dragPanel @ L1 (UIPanel)+D4]");
		float num = _GetPositionOnGrid(friendIndexOnTopOfPlayer, 0f);
		Transform transform = dragPanel.transform;
		Vector3 localPosition = transform.localPosition;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+34]");
		float num2 = 0f + num;
		Transform transform2 = dragPanel.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+20]");
		_ = 0;
		Vector3 localPosition2 = (Vector3)(vector + 8);
		transform2.localPosition = localPosition2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [dragPanel @ L1 (UIPanel)+F0]");
		float num3 = 0f - num;
		_ = dragPanel.mClipOffset;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2 (UnityEngine.Vector2)+18]");
		((Vector2*)(nint)vector)->x = 0f;
		dragPanel.clipOffset = vector;
	}

	private float _GetPositionOnGrid(int index, float clipHeight)
	{
		//IL_001b: Expected F8, but got I4
		//IL_002a: Invalid comparison between I4 and F8
		//IL_0051: Expected Obj, but got I4
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected Obj, but got Unknown
		//IL_0066: Invalid comparison between F8 and Obj
		//IL_00d5: Expected Obj, but got I4
		float num = clipHeight / 33f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"System.Math.Ceiling not resolved\"");
		double num2 = Math.Abs((double)num);
		double num3 = ((!(num2 < 2147483648.0)) ? (-2147483648.0) : ((double)num));
		float num4 = num - (float)num3;
		float num5 = num4 * 33f;
		if (index >= 2 && (double)_friendsCount > num3)
		{
			object obj = _friendsCount + 1;
			object obj2 = obj - index;
			if (System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref (object)num3) > System.Runtime.CompilerServices.Unsafe.As<object, UIntPtr>(ref obj2))
			{
				double num6 = num3 - (double)obj2;
				double num7 = (double)index - num6;
				double num8 = num7 * 33.0;
				return (float)num8 - num5;
			}
			object obj3 = index - 1;
			return (float)obj3 * 33f;
		}
		float result = default;
		return result;
	}

	private void Awake()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_005d: Expected VT, but got Obj
		object obj2 = default;
		object obj = obj2 - 32;
		_instance = this;
		nint num = 0;
		nint num2 = 0;
		IntPtr intPtr = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v34 @ S4_v3 (Il2CppClass<Il2CppMethodRgctx<UnityEngine.GameObject::GetComponentInChildren>>)+4] (should have been resolved before IL gen)");
		ScrollViewHeightResizer scrollViewHeightResizer = default;
		heightResizerBothNoBrag = scrollViewHeightResizer;
		if (~(initializedPosition ? 1u : 0u) != 0)
		{
			Transform transform = OnlineBothNoBragParent.transform;
			Vector3 localPosition = transform.localPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ S0_v2+8]");
			_ = 0;
			initialPositionBothGrid = (Vector3)obj;
			ScrollViewHeightResizer scrollViewHeightResizer2 = heightResizerBothNoBrag;
			initialHeightBothGrid = scrollViewHeightResizer2._staticObjectsHeight;
			initializedPosition = true;
		}
	}

	public FriendHandlerBrag()
	{
		//IL_0019: Expected I, but got Obj
		nint num = (nint)typeof(Vector3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ S0_v10 (Il2CppClass<UnityEngine.Vector3>)+5C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ S0_v11 (Il2CppStaticFields<UnityEngine.Vector3>)+8]");
		_ = 0;
		initialPositionBothGrid = Vector3.zeroVector;
		List<Friend> list = default;
		list._002Ector();
		_bragList = list;
		preBragPopupString = string.Empty;
		base._002Ector();
	}
}
