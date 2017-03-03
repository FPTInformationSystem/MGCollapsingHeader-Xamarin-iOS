using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace FPT.Framework.iOS.UI.MGCollapsingHeader
{
	[Native]
	public enum MGTransformCurve : ulong
	{
		Linear = 0,
		EaseIn,
		EaseOut,
		EaseInOut
	}

	[Native]
	public enum MGAttribute : ulong
	{
		X = 1,
		Y,
		Width,
		Height,
		Alpha,
		CornerRadius,
		ShadowRadius,
		ShadowOpacity,
		FontSize
	}

}
