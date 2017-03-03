using System;
using ObjCRuntime;

[Native]
public enum MGTransformCurve : nuint
{
	Linear = 0,
	EaseIn,
	EaseOut,
	EaseInOut
}

[Native]
public enum MGAttribute : nuint
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
