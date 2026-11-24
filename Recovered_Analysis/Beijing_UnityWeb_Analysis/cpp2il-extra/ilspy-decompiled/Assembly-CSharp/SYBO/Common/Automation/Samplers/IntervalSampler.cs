using Cpp2ILInjected;
using SYBO.Common.Automation.Steps;
using SYBO.Common.Benchmarking;

namespace SYBO.Common.Automation.Samplers;

public class IntervalSampler : IMetricSampler
{
	private float _sampleInterval;

	protected float _timeSinceLastSample;

	public unsafe IntervalSampler(float sampleInterval)
	{
		//IL_0027: Expected Obj, but got F4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected Obj, but got Unknown
		//IL_00a6: Expected Obj, but got F4
		//IL_00b9: Expected native int or pointer, but got F4
		//IL_00c2: Expected Obj, but got F4
		if (!((AutomationStep)this).IsDone)
		{
			float num = _sampleInterval + 16f;
			object obj = _timeSinceLastSample << 2;
			float num2 = num + (float)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @736B");
			object obj2 = default;
			if (obj2 != null)
			{
				float timeSinceLastSample = _timeSinceLastSample + 1f;
				_timeSinceLastSample = timeSinceLastSample;
				object obj3 = this + 16;
				float num3 = _sampleInterval + 16f;
				object obj4 = _timeSinceLastSample << 2;
				float num4 = num3 + (float)obj4;
				obj3 = ((float*)(nint)num4)->m_value;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @9466");
		}
	}

	public void Initialize()
	{
		//IL_0063: Expected Obj, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected Obj, but got Unknown
		object obj = 0;
		while (true)
		{
			float sampleInterval = _sampleInterval;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ S1_v4 (System.Single)+C]");
			if ((nint)obj2 < 0)
			{
				float num = _sampleInterval + 16f;
				object obj3 = obj << 2;
				float num2 = num + (float)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @741D");
				object obj4 = obj + 1;
				obj = obj4;
				continue;
			}
			break;
		}
	}

	public void Cleanup()
	{
	}

	public virtual bool Update(float unscaledDeltaTime)
	{
		//IL_0023: Expected Obj, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B6C");
		_ = 0;
		bool flag = default;
		object obj = (flag ? 1 : 0) + 20;
		obj = this;
		return flag;
	}
}
