using SYBO.Subway.Routes.Builders;

namespace SYBO.Subway.Rendering;

public static class RenderQueues
{
	public static int TransparentOverlay;

	static RenderQueues()
	{
		DefaultRouteBuilder.ChunkLengthForcingEnvironmentSwitch = 540;
	}
}
