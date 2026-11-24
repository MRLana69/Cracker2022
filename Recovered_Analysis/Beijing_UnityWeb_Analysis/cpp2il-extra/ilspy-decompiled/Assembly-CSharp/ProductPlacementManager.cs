using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;
using SYBO.Components.Utilities;
using UnityEngine;

public class ProductPlacementManager : SingletonMonoBehaviour<ProductPlacementManager>
{
	private sealed class _003CDownloadProductPlacement_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SpriteContainer container;

		public ProductPlacementManager _003C_003E4__this;

		public int intent;

		private WWW _003Cproduct_003E5__2;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0054: Expected Obj, but got I
				//IL_0064: Expected Obj, but got I
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Expected Obj, but got Unknown
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Expected Obj, but got Unknown
				//IL_00a8: Expected Obj, but got I
				//IL_00b8: Expected Obj, but got I
				//IL_00c8: Expected Obj, but got I
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Expected Obj, but got Unknown
				//IL_00df: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Expected Obj, but got Unknown
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				//IL_011c: Expected Obj, but got Unknown
				//IL_013a: Expected Obj, but got I
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Expected Obj, but got Unknown
				//IL_0168: Expected Obj, but got I4
				//IL_018e: Expected Obj, but got I
				//IL_0298: Expected I, but got Obj
				//IL_02ae: Expected Obj, but got I
				//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f5: Expected Obj, but got Unknown
				//IL_0253: Expected Obj, but got I4
				//IL_02d9: Expected I, but got Obj
				ProductPlacementManager productPlacementManager = _003C_003E4__this;
				if (_003C_003E1__state != 0)
				{
					if (_003C_003E1__state == 1)
					{
						_003C_003E1__state = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (ProductPlacementManager)+20]");
						object obj = -1;
						bool flag;
						if (_003Cproduct_003E5__2.isDone)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v33 (System.Boolean)+8]");
							flag = (nint)0 == 0;
						}
						else
						{
							flag = true;
						}
						if (flag)
						{
							object obj2 = container + 8;
							string url = _003Cproduct_003E5__2.url;
							obj2 = url;
							return null;
						}
						if (intent <= 4)
						{
							Action<Texture2D, Texture2D> onFinishedDownloading = (Action<Texture2D, Texture2D>)(intent + 1);
							IEnumerator routine = FacebookImageDownloader.StartImageDownload((string)(object)productPlacementManager, (string)(object)container, onFinishedDownloading);
							Coroutine coroutine = productPlacementManager.StartCoroutine_Auto(routine);
							return null;
						}
						nint num = (nint)typeof(Debug);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ S0_v39 (Il2CppClass<UnityEngine.Debug>)+BA]");
						object obj3 = (nint)0 & (nint)0x200;
						if (obj3 != null)
						{
							nint num2 = (nint)typeof(Debug);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v46 (Il2CppClass<UnityEngine.Debug>)+74]");
							if ((nint)0 == 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							}
						}
						Debug.LogException((Exception)(object)"Image could not be downloaded");
						return null;
					}
					return null;
				}
				_003C_003E1__state = -1;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S3_v3 (Il2CppMethodInfo)+C]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ S3_v4+60]");
				object obj5 = 0;
				object obj6 = obj5;
				object obj7 = obj6 & 0x1FFF;
				object obj8 = obj7 + 113696;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v49 @ S4_v5 (should have been resolved before IL gen)");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ S4_v7 (Il2CppMethodInfo)+C]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ S4_v8+60]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ S4_v9+48]");
				object obj11 = 0;
				object obj12 = obj11 & 0x7FF;
				object obj13 = obj12 + 39195;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v68 @ S5_v7 (should have been resolved before IL gen)");
				SpriteContainer spriteContainer = container;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117A8");
				object obj14 = this + 28;
				object obj15 = default;
				obj14 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v6 (ProductPlacementManager)+20]");
				object obj16 = (nint)0 + (nint)1;
				object obj17 = this + 12;
				obj17 = _003Cproduct_003E5__2;
				_003C_003E1__state = 1;
				return 1;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CDownloadProductPlacement_003Ed__20(int _003C_003E1__state)
		{
			throw new InvalidOperationException();
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

	public SpriteContainer tunnelContainer;

	public SpriteContainer billboardContainer;

	public SpriteContainer trainContainer;

	public Action OnProductPlacementDownloaded;

	private int _onGoingRequests;

	private float tunnelTimeInbetween__BackingField = 0f;

	private float trainTimeInbetween__BackingField = 0f;

	private float billboardTimeInbetween__BackingField = 0f;

	public float tunnelTimeInbetween
	{
		get
		{
			//IL_0007: Expected F4, but got Obj
			return (float)billboardContainer;
		}
		set
		{
			//IL_000a: Expected Obj, but got F4
			billboardContainer = (SpriteContainer)value;
		}
	}

	public float trainTimeInbetween
	{
		get
		{
			return tunnelTimeInbetween__BackingField;
		}
		set
		{
			tunnelTimeInbetween__BackingField = value;
		}
	}

	public float billboardTimeInbetween
	{
		get
		{
			return trainTimeInbetween__BackingField;
		}
		set
		{
			trainTimeInbetween__BackingField = value;
		}
	}

	private void Start()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected Obj, but got Unknown
		//IL_0037: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		List<UITexture> list = default;
		list._002Ector();
		object obj = this + 16;
		obj = list;
		billboardContainer = (SpriteContainer)3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F4C1");
	}

	private void Update()
	{
		this._002Ector();
	}

	private void Init()
	{
		float unscaledTime = Time.unscaledTime;
		float num = tunnelTimeInbetween__BackingField + unscaledTime;
		tunnelTimeInbetween__BackingField = num;
		float unscaledTime2 = Time.unscaledTime;
		float num2 = trainTimeInbetween__BackingField + unscaledTime2;
		trainTimeInbetween__BackingField = num2;
		float unscaledTime3 = Time.unscaledTime;
		float num3 = billboardTimeInbetween__BackingField + unscaledTime3;
		billboardTimeInbetween__BackingField = num3;
	}

	private IEnumerator DownloadProductPlacement(SpriteContainer container, int intent)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected Obj, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		//IL_0054: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		IEnumerator enumerator = default;
		object obj = enumerator + 16;
		obj = this;
		object obj2 = enumerator + 20;
		obj2 = container;
		object obj3 = enumerator + 24;
		obj3 = intent;
		return enumerator;
	}

	public ProductPlacementManager()
	{
		IEnumerator routine = FacebookImageDownloader.StartImageDownload((string)(object)this, (string)(object)tunnelContainer, (Action<Texture2D, Texture2D>)null);
		Coroutine coroutine = StartCoroutine_Auto(routine);
		IEnumerator routine2 = FacebookImageDownloader.StartImageDownload((string)(object)this, (string)(object)billboardContainer, (Action<Texture2D, Texture2D>)null);
		Coroutine coroutine2 = StartCoroutine_Auto(routine2);
		IEnumerator routine3 = FacebookImageDownloader.StartImageDownload((string)(object)this, (string)(object)trainContainer, (Action<Texture2D, Texture2D>)null);
		Coroutine coroutine3 = StartCoroutine_Auto(routine3);
		if (_onGoingRequests == 0 && OnProductPlacementDownloaded != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @78B7");
		}
	}
}
