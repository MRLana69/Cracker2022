using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace SYBO.Subway.Visuals;

public class HuntTokenCollectVFXColorCycle : HuntTokenCollectVFX
{
	[Serializable]
	public class ColorEntry
	{
		private Color _minColor;

		private Color _maxColor;

		public unsafe ParticleSystem.MinMaxGradient Gradient
		{
			get
			{
				//IL_0005: Expected native int or pointer, but got VT
				ParticleSystem.MinMaxGradient minMaxGradient = default;
				System.Runtime.CompilerServices.Unsafe.Write(&((ParticleSystem.MinMaxGradient*)(nint)minMaxGradient)->m_GradientMax, this);
				return minMaxGradient;
			}
		}

		public ColorEntry()
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			NullReferenceException ex = default;
			ex._002Ector();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	private sealed class _003CPlayEffect_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HuntTokenCollectVFXColorCycle _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			get
			{
				//IL_0009: Unknown result type (might be due to invalid IL or missing references)
				//IL_000e: Expected Obj, but got Unknown
				//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ac: Expected Obj, but got Unknown
				//IL_00cc: Expected Obj, but got I
				RoofedCulling roofedCulling = default;
				object obj = roofedCulling + 44;
				HuntTokenCollectVFXColorCycle huntTokenCollectVFXColorCycle = _003C_003E4__this;
				if (_003C_003E1__state == 0)
				{
					_003C_003E1__state = -1;
					roofedCulling.CurrentCullingBlock = (RoofedCulling.CullingBlock)(object)_003C_003E4__this;
					obj = roofedCulling;
					_ = roofedCulling._cullingBlockList;
					_ = roofedCulling._nextCullingBlock;
					_ = roofedCulling._menuCullingblock;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (SYBO.Subway.Visuals.RoofedCulling)+20]");
					_ = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7 (SYBO.Subway.Visuals.RoofedCulling)+28]");
					_ = 0;
					object obj2 = _003C_003E4__this + 20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1175D");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ S0_v7 (SYBO.Subway.Visuals.HuntTokenCollectVFXColorCycle)+C]");
					((ParticleSystem)0).Stop();
				}
				return null;
			}
		}

		object IEnumerator.Current => _003C_003E2__current;

		public _003CPlayEffect_003Ed__6(int _003C_003E1__state)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_001c: Expected Obj, but got I4
			//IL_003f: Expected Obj, but got I4
			//IL_005d: Expected Obj, but got I4
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected Obj, but got Unknown
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			object obj3 = _003C_003E1__state + 8;
			obj = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S1_v4+8]");
			_ = 0;
			object obj4 = _003C_003E1__state + 24;
			obj2 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S1_v9+8]");
			_ = 0;
			_003CPlayEffect_003Ed__6 obj5 = (_003CPlayEffect_003Ed__6)0;
			this._003C_003E1__state = 0;
			_003C_003E4__this = null;
			_ = 0;
			_ = 0;
			_ = 0;
			object obj6 = obj2 + 32;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			object obj7 = obj2 + 48;
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1176B");
		}

		void IDisposable.Dispose()
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected Obj, but got Unknown
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected Obj, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			Color black = Color.black;
			object obj3 = obj2 + 32;
			obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ S0_v5+8]");
			_ = 0;
			object obj4 = this + 8;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+8]");
			_ = 0;
			Color black2 = Color.black;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+8]");
			_ = 0;
			object obj5 = this + 24;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ S0_v7+8]");
			_ = 0;
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

	private System.Random _randomGen;

	private ParticleSystem.MainModule _mainParticleModule;

	private List<ColorEntry> _colorEntries;

	private int _randomSeed;

	public override void Setup()
	{
		CancelInvoke();
	}

	public override IEnumerator PlayEffect()
	{
		//IL_0007: Expected Obj, but got VT
		return (IEnumerator)_mainParticleModule;
	}

	private ParticleSystem.MinMaxGradient PickRandomColorGradient()
	{
		//IL_0042: Expected Obj, but got I4
		//IL_0042: Expected Obj, but got VT
		//IL_0054: Expected Obj, but got I
		//IL_006d: Expected Obj, but got VT
		//IL_0083: Expected Obj, but got I4
		//IL_0083: Expected Obj, but got I
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected VT, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.ParticleSystem+MinMaxGradient)+14]");
		ParticleSystem.MinMaxGradient minMaxGradient2 = default;
		ParticleSystem.MinMaxGradient minMaxGradient = default;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.ParticleSystem+MinMaxGradient)+14]");
			if ((nint)0 != 1)
			{
				minMaxGradient = (ParticleSystem.MinMaxGradient)(minMaxGradient2 + 20);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AF");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
				throw new NullReferenceException();
			}
			((GameObject)minMaxGradient2.m_ColorMin).tag = null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.ParticleSystem+MinMaxGradient)+10]");
			((GameObject)0).tag = (string)1;
		}
		else
		{
			((GameObject)minMaxGradient2.m_ColorMin).tag = (string)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ L0_v1 (UnityEngine.ParticleSystem+MinMaxGradient)+10]");
			((GameObject)0).tag = null;
		}
		return minMaxGradient;
	}

	public HuntTokenCollectVFXColorCycle()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0051: Expected Obj, but got I4
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected Obj, but got Unknown
		//IL_007a: Expected Obj, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected Obj, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		RankException ex2;
		if (_randomSeed == -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RankException ex = default;
			ex._002Ector();
			ex2 = ex;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RankException ex3 = default;
			ex3._002Ector((string)_randomSeed);
			ex2 = ex3;
		}
		object obj3 = this + 16;
		obj3 = ex2;
		obj = 0;
		obj = _particleSystem;
		obj2 = obj;
		object obj4 = obj2 + 4;
		obj4 = obj2;
		object obj5 = this + 20;
		obj5 = obj4;
	}
}
