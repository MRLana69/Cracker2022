using System;
using Cpp2ILInjected;
using Kiloo.Common.Utility;
using SYBO.Components.Json;

namespace Kiloo.Common.Backend;

public class InstallationInfo : IInstallationInfo
{
	private class InstallationInfoModel
	{
		public string id;
	}

	private const string INSTALLATION_INFO_FILE = ".installationInfo";

	private readonly IFileSaver _fileSaver;

	private InstallationInfoModel _info;

	public string id
	{
		get
		{
			//IL_0038: Expected Obj, but got I
			//IL_003c: Expected Obj, but got VT
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.InstallationInfo)+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
				JsonCustomSerializer jsonCustomSerializer = default;
				jsonCustomSerializer._002Ector();
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ L0 (Kiloo.Common.Backend.InstallationInfo)+18]");
				return (string)JsonApi.ReflectionDeserializeDom<T>((object)0, (JsonContext)(object)jsonCustomSerializer);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
			InvalidProgramException ex = default;
			ex._002Ector("EventLogger.GetSessionJSON: Session not started.");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @120AB");
			return null;
		}
	}

	public InstallationInfo(IFileSaver fileSaver)
	{
	}

	private InstallationInfoModel GetInfo()
	{
		return (InstallationInfoModel)(object)((KilooBackendException)this).backendError?.category;
	}

	public static void DeleteInfoDebug()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		EventRemoteLogger eventRemoteLogger = default;
		eventRemoteLogger.CheckSessionRemoval();
		EventRemoteLogger.instance = eventRemoteLogger;
	}

	private void LogError(string msg)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected Obj, but got Unknown
		object obj = this + 8;
		obj = msg;
	}
}
