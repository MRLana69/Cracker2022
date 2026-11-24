using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Kiloo.Common.Plugins.DeviceUtility.Internal;
using SYBO.Subway.Routes;
using SYBO.Subway.Routes.Builders;
using UnityEngine;

namespace Kiloo.Common.HTTP.Internal;

internal class Connection : IDisposable
{
	private string host__BackingField;

	private int port__BackingField;

	private bool useSsl__BackingField;

	private int sendTimeout__BackingField;

	private int receiveTimeout__BackingField;

	private bool ignoreCertificateErrors__BackingField;

	private static readonly List<Connection> _idleConnections;

	private Stream _stream;

	private bool _idle;

	private DateTime? _expires;

	public string host
	{
		get
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected Obj, but got Unknown
			//IL_0565: Expected I, but got Obj
			//IL_057b: Expected Obj, but got I
			//IL_0021: Expected I, but got Obj
			//IL_006e: Expected I, but got Obj
			//IL_0084: Expected Obj, but got I
			//IL_068d: Expected I, but got Obj
			//IL_06a3: Expected Obj, but got I
			//IL_00af: Expected I, but got Obj
			//IL_01cc: Expected I, but got Obj
			//IL_0114: Expected I, but got Obj
			//IL_012a: Expected Obj, but got I
			//IL_0147: Expected I, but got Obj
			//IL_05d7: Expected Obj, but got I
			//IL_0163: Expected I, but got Obj
			//IL_0193: Expected I, but got Obj
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Expected Obj, but got Unknown
			//IL_031d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0322: Expected Obj, but got Unknown
			//IL_034e: Expected Obj, but got I4
			//IL_01b9: Expected I, but got Obj
			//IL_0254: Invalid comparison between I4 and F4
			//IL_0418: Expected Obj, but got I
			//IL_04b4: Expected Obj, but got I
			//IL_0456: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Expected Obj, but got Unknown
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Expected Obj, but got Unknown
			//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected Obj, but got Unknown
			//IL_0301: Expected Obj, but got I4
			//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Expected Obj, but got Unknown
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Expected Obj, but got Unknown
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Expected Obj, but got Unknown
			object obj2 = default;
			object obj = obj2 + 16;
			obj2 = obj;
			_ = -1;
			nint num = (nint)typeof(WebClient);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ S0_v14 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
			object obj3 = (nint)0 & (nint)0x200;
			if (obj3 != null)
			{
				nint num2 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ S0_v159 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
				}
			}
			float timeout = ((Request)this).timeout;
			string text = default;
			if (timeout > 0f)
			{
				nint num3 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v25 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
				object obj4 = (nint)0 & (nint)0x200;
				if (obj4 != null)
				{
					nint num4 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ S0_v153 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				if (WebClient._random == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
					RankException ex = default;
					ex._002Ector();
					nint num5 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ S0_v140 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
					object obj5 = (nint)0 & (nint)0x200;
					bool flag = obj5 == null;
					nint num6 = (nint)typeof(WebClient);
					if (!flag)
					{
						nint num7 = (nint)typeof(WebClient);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ S0_v147 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
						bool flag2 = (nint)0 == 0;
						bool flag3 = !flag2;
						num6 = (nint)typeof(WebClient);
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
							num6 = (nint)typeof(WebClient);
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ L1_v14 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+5C]");
					object obj6 = (nint)0 + (nint)20;
					obj6 = ex;
				}
				nint num8 = (nint)typeof(WebClient);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ S0_v35 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+BA]");
				object obj7 = (nint)0 & (nint)0x200;
				if (obj7 != null)
				{
					nint num9 = (nint)typeof(WebClient);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ S0_v130 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9E28");
				object obj8 = default;
				float num10 = (float)obj8 * timeout;
				if (num10 < timeout)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
					object obj9 = default;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
						if (obj9 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
							if (!((float)text.m_stringLength < 0f))
							{
								float num11 = num10 - (float)text.m_stringLength;
								if (!((double)num11 > 0.0))
								{
									object obj10 = obj2 + 4;
									object obj11 = obj10 + 1;
									obj10 = obj11;
									object obj12 = obj11 << 2;
									object obj13 = obj2 + obj12;
									obj13 = 129;
									break;
								}
							}
							continue;
						}
						object obj14 = obj2 + 4;
						object obj15 = obj14 + 1;
						obj14 = obj15;
						object obj16 = obj15 << 2;
						object obj17 = obj2 + obj16;
						obj17 = 127;
						break;
					}
					object obj18 = default;
					if (obj18 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						object obj19 = (nint)0 << 2;
						object obj20 = obj2 + obj19;
						if ((nint)obj20 == 129)
						{
							object obj21 = obj2 + 4;
							if ((nint)obj21 > -1)
							{
								object obj22 = obj21 + -1;
								obj21 = obj22;
							}
							goto IL_06dd;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
					if ((nint)0 != -1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
						object obj23 = (nint)0 << 2;
						object obj24 = obj2 + obj23;
						if ((nint)obj24 == 127)
						{
							object obj25 = obj2 + 4;
							if ((nint)obj25 > -1)
							{
								object obj26 = obj25 + -1;
								obj25 = obj26;
							}
							goto IL_06dd;
						}
					}
					object obj27 = default;
					if (obj27 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
					}
				}
			}
			goto IL_06dd;
			IL_06dd:
			return text;
		}
		private set
		{
			if (value != null)
			{
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AD9C");
		}
	}

	public int port
	{
		get
		{
			//IL_0007: Expected I4, but got Obj
			return (int)host__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected Obj, but got Unknown
			//IL_0013: Expected Obj, but got I4
			object obj = this + 8;
			obj = value;
		}
	}

	public bool useSsl
	{
		get
		{
			return (byte)port__BackingField != 0;
		}
		private set
		{
			port__BackingField = (value ? 1 : 0);
		}
	}

	public int sendTimeout
	{
		get
		{
			return useSsl__BackingField ? 1 : 0;
		}
		private set
		{
			int num = value & 1;
			useSsl__BackingField = (byte)num != 0;
		}
	}

	public int receiveTimeout
	{
		get
		{
			return sendTimeout__BackingField;
		}
		private set
		{
			sendTimeout__BackingField = value;
		}
	}

	public bool ignoreCertificateErrors
	{
		get
		{
			return (byte)receiveTimeout__BackingField != 0;
		}
		private set
		{
			receiveTimeout__BackingField = (value ? 1 : 0);
		}
	}

	public bool reused => ignoreCertificateErrors__BackingField;

	public Stream GetStream()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected Obj, but got Unknown
		//IL_002f: Expected Obj, but got I4
		object obj = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ S0_v8+8]");
		bool flag = (nint)0 != 0;
		return (Stream)flag;
	}

	public unsafe static Connection Open(string host, int port, bool useSsl, int sendTimeout, int receiveTimeout, bool ignoreCertificateErrors = false)
	{
		//IL_01ec: Expected I, but got Obj
		//IL_0202: Expected Obj, but got I
		//IL_0228: Expected Obj, but got I4
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected Obj, but got Unknown
		//IL_024f: Expected Obj, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		//IL_0013: Expected I, but got Obj
		//IL_0189: Expected Obj, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected Obj, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected Obj, but got Unknown
		nint num = (nint)typeof(UnityEngine.Object);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ S0_v9 (Il2CppClass<UnityEngine.Object>)+BA]");
		object obj = (nint)0 & (nint)0x200;
		if (obj != null)
		{
			nint num2 = (nint)typeof(UnityEngine.Object);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ S0_v54 (Il2CppClass<UnityEngine.Object>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		Route route = UnityEngine.Object.Instantiate((Route)port);
		object obj2 = host - -64;
		object obj3 = obj2;
		object obj4 = ((int*)receiveTimeout)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [receiveTimeout @ L4 (System.Int32)+8]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @811C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		nint method_ptr = 0;
		EventHandler eventHandler = default;
		((Delegate)eventHandler).method_ptr = method_ptr;
		((Delegate)eventHandler).method = (nint)__ldftn(RouteManager.Route_OnDestructing);
		object obj5 = eventHandler + 16;
		obj5 = host;
		route.OnDestructing -= eventHandler;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7281");
		ComputeShader computeShader = default;
		if (computeShader.FindKernel(null) != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint num3 = 0;
			_ = 0;
			EventHandler<Route.CharacterEntrySkippedEventArgs> eventHandler2 = default;
			object obj6 = eventHandler2 + 16;
			obj6 = host;
			((Route)(object)computeShader).OnCharacterEntrySkipped -= eventHandler2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @724E");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			nint method_ptr2 = 0;
			EventHandler eventHandler3 = default;
			((Delegate)eventHandler3).method_ptr = method_ptr2;
			((Delegate)eventHandler3).method = (nint)__ldftn(RouteManager.AlternateRouteBuilder_OnCompletedLayingSections);
			object obj7 = eventHandler3 + 16;
			obj7 = host;
			RouteBuilder routeBuilder = default;
			routeBuilder.OnCompletedLayingSections -= eventHandler3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [host @ L0 (System.String)+54]");
		((RouteCollection)0).Remove(route);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [host @ L0 (System.String)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			RouteSection.RepeatConfiguration repeatConfiguration = default;
			repeatConfiguration.Validate((RouteSection)(object)route);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @7A74");
		}
		return (Connection)(object)route;
	}

	public void KeepAlive(int milliseconds)
	{
		int num = milliseconds & 1;
		ignoreCertificateErrors__BackingField = (byte)num != 0;
	}

	public void Reconnect()
	{
		//IL_005d: Expected I4, but got Obj
		//IL_006f: Expected I, but got Obj
		//IL_0085: Expected Obj, but got I
		//IL_0013: Expected I, but got Obj
		string message = string.ConcatArray((string[])(object)"[WebClient] ", (int)this);
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

	public static void CloseExpiredIdleConnections()
	{
		//IL_0139: Expected I, but got Obj
		//IL_014f: Expected Obj, but got I
		//IL_0158: Expected Obj, but got I4
		nint num = (nint)typeof(WebClient);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ S0_v6 (Il2CppClass<Kiloo.Common.HTTP.WebClient>)+5C]");
		object obj = (nint)0 + (nint)4;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117F6");
		throw new ArrayTypeMismatchException();
	}

	public static void CloseIdleConnectionsToHost(string host)
	{
		((Connection)(object)host).Dispose();
		((Connection)(object)host).CheckValidOperation();
	}

	public static void CloseIdleConnections()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected Obj, but got Unknown
		//IL_061f: Expected Obj, but got I4
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected Obj, but got Unknown
		//IL_0636: Expected Obj, but got I4
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected Obj, but got Unknown
		//IL_0666: Expected I, but got Obj
		//IL_067c: Expected Obj, but got I
		//IL_0813: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected Obj, but got Unknown
		//IL_0821: Unknown result type (might be due to invalid IL or missing references)
		//IL_0826: Expected Obj, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected Obj, but got Unknown
		//IL_083d: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_00af: Expected I, but got Obj
		//IL_055e: Expected Obj, but got I
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected Obj, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 80;
		object obj3 = obj2 - -64;
		obj3 = 0;
		object obj4 = obj2 + 16;
		obj4 = 0;
		_ = 0;
		object obj5 = obj2 + 56;
		obj5 = obj;
		_ = -1;
		nint num = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ S0_v20 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj6 = (nint)0 & (nint)0x200;
		if (obj6 != null)
		{
			nint num2 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ S0_v244 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		object obj7 = obj2 + 40;
		object obj8 = obj2 + 32;
		object obj9 = obj2 + 8;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num3 = (nint)typeof(DateTime);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ S0_v75 (Il2CppClass<System.DateTime>)+BA]");
		object obj10 = (nint)0 & (nint)0x200;
		if (obj10 != null)
		{
			nint num4 = (nint)typeof(DateTime);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ S0_v237 (Il2CppClass<System.DateTime>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D9");
		object obj12 = default;
		object obj11 = obj12 << 32;
		object obj14 = default;
		object obj13 = obj14 | obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
		object obj16 = default;
		object obj15 = obj16;
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
		object obj18 = default;
		if (obj17 == obj18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9A");
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ S0_v17+4]");
			object obj19 = (nint)0 << 2;
			object obj20 = obj5 + obj19;
			if ((nint)obj20 == 128)
			{
				object obj21 = obj5 + 4;
				if ((nint)obj21 > -1)
				{
					object obj22 = obj21 + -1;
					obj21 = obj22;
				}
				return;
			}
		}
		object obj23 = default;
		if (obj23 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void Close()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected Obj, but got Unknown
		//IL_048e: Expected Obj, but got I4
		//IL_04aa: Expected I, but got Obj
		//IL_04c0: Expected Obj, but got I
		//IL_05b8: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected Obj, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected Obj, but got Unknown
		//IL_0336: Expected Obj, but got I4
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_015c: Expected I, but got Obj
		//IL_03cd: Expected Obj, but got I
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected Obj, but got Unknown
		//IL_01d5: Expected I, but got Obj
		//IL_01eb: Expected Obj, but got I
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected Obj, but got Unknown
		//IL_0216: Expected I, but got Obj
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v177 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num3 = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v65 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v168 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj7 = default;
		object obj6 = obj7;
		object obj10 = default;
		while (true)
		{
			object obj8 = obj6 - 1;
			if ((nint)obj8 < 0)
			{
				break;
			}
			nint num5 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ S0_v92 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Connection);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ S0_v156 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			if (obj10 != null)
			{
				nint num7 = (nint)typeof(Connection);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ S0_v124 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
				object obj11 = (nint)0 & (nint)0x200;
				if (obj11 != null)
				{
					nint num8 = (nint)typeof(Connection);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ S0_v147 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
					if ((nint)0 == 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			}
			obj6 = obj8;
		}
		object obj12 = obj2 + 4;
		object obj13 = obj12 + 1;
		obj12 = obj13;
		object obj14 = obj13 << 2;
		object obj15 = obj2 + obj14;
		obj15 = 94;
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj16 = (nint)0 << 2;
			object obj17 = obj2 + obj16;
			if ((nint)obj17 == 94)
			{
				object obj18 = obj2 + 4;
				if ((nint)obj18 > -1)
				{
					object obj19 = obj18 + -1;
					obj18 = obj19;
				}
				return;
			}
		}
		object obj20 = default;
		if (obj20 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
		}
	}

	public void Dispose()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected Obj, but got Unknown
		//IL_003d: Expected Obj, but got I4
		if (_stream != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @E4D3");
			object obj = this + 32;
			obj = 0;
		}
	}

	private Connection(string host, int port, bool useSsl, int sendTimeout, int receiveTimeout, bool ignoreCertificateErrors)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected Obj, but got Unknown
		//IL_0027: Expected Obj, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected Obj, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected Obj, but got Unknown
		//IL_004d: Expected Obj, but got I4
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected Obj, but got Unknown
		//IL_0060: Expected Obj, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected Obj, but got Unknown
		//IL_0073: Expected Obj, but got I4
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected Obj, but got Unknown
		//IL_0086: Expected Obj, but got I4
		if (~(this.useSsl__BackingField ? 1u : 0u) == 0)
		{
			DeviceUtilitySimulated.LogWarning("Already showing popup");
			return;
		}
		object obj = this + 12;
		obj = ignoreCertificateErrors;
		object obj2 = this + 20;
		obj2 = host;
		object obj3 = this + 24;
		obj3 = port;
		object obj4 = this + 28;
		obj4 = useSsl;
		object obj5 = this + 32;
		obj5 = sendTimeout;
		object obj6 = this + 36;
		obj6 = receiveTimeout;
		this.useSsl__BackingField = true;
	}

	private void Connect()
	{
		Dispose();
	}

	private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		return false;
	}

	private void CheckValidOperation()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		obj2 = obj;
		_ = -1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2A");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		if (~(useSsl__BackingField ? 1u : 0u) == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9C");
			object obj4 = default;
			object obj3 = obj4;
			object obj6 = default;
			object obj5 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1AD");
			object obj7 = default;
			if (obj5 == obj7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @99");
				object obj9 = default;
				object obj8 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9B");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D");
				object obj11 = default;
				object obj10 = obj11;
			}
			else
			{
				object obj10 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @A4");
		}
		else
		{
			object obj13 = default;
			object obj12 = obj13;
			object obj14 = this + 32;
			obj14 = obj12;
		}
	}

	private static void Log(string msg)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+24]");
		if ((nint)0 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [msg @ L0 (System.String)+20]");
			if ((nint)0 != 0)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		InvalidProgramException ex = default;
		ex._002Ector("Connection not valid. Make sure you call Open before using.");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
	}

	static Connection()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected Obj, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected Obj, but got Unknown
		//IL_03a4: Expected Obj, but got I4
		//IL_03c0: Expected I, but got Obj
		//IL_03d6: Expected Obj, but got I
		//IL_04bf: Expected Obj, but got I4
		//IL_006e: Expected I, but got Obj
		//IL_0084: Expected Obj, but got I
		//IL_0021: Expected I, but got Obj
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected Obj, but got Unknown
		//IL_00af: Expected I, but got Obj
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected Obj, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected Obj, but got Unknown
		//IL_024c: Expected Obj, but got I4
		//IL_011b: Expected I, but got Obj
		//IL_0131: Expected Obj, but got I
		//IL_015c: Expected I, but got Obj
		//IL_02e3: Expected Obj, but got I
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected Obj, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected Obj, but got Unknown
		object obj2 = default;
		object obj = obj2 + 16;
		object obj3 = obj2 + 8;
		obj3 = 0;
		obj2 = obj;
		_ = -1;
		nint num = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S0_v16 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj4 = (nint)0 & (nint)0x200;
		if (obj4 != null)
		{
			nint num2 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ S0_v152 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11A99");
			}
		}
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
		nint num3 = (nint)typeof(Connection);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ S0_v65 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
		object obj5 = (nint)0 & (nint)0x200;
		if (obj5 != null)
		{
			nint num4 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ S0_v143 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
			if ((nint)0 == 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @13");
		object obj7 = default;
		object obj6 = obj7;
		while (true)
		{
			object obj8 = obj6 - 1;
			if ((nint)obj8 < 0)
			{
				break;
			}
			nint num5 = (nint)typeof(Connection);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ S0_v92 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+BA]");
			object obj9 = (nint)0 & (nint)0x200;
			if (obj9 != null)
			{
				nint num6 = (nint)typeof(Connection);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ S0_v128 (Il2CppClass<Kiloo.Common.HTTP.Internal.Connection>)+74]");
				if ((nint)0 == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1F");
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @28");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @24");
			obj6 = obj8;
		}
		object obj10 = obj2 + 4;
		object obj11 = obj10 + 1;
		obj10 = obj11;
		object obj12 = obj11 << 2;
		object obj13 = obj2 + obj12;
		obj13 = 78;
		if (obj3 != null)
		{
			throw new ArgumentNullException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
		if ((nint)0 != -1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ G7+4]");
			object obj14 = (nint)0 << 2;
			object obj15 = obj2 + obj14;
			if ((nint)obj15 == 78)
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
	}
}
