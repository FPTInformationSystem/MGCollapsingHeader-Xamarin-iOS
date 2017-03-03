using System;
using Foundation;
using ObjCRuntime;
using UIKit;

// @protocol MGCollapsingHeaderDelegate <NSObject>
[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MGCollapsingHeaderDelegate
{
	// @required -(void)headerDidCollapseToOffset:(double)offset;
	[Abstract]
	[Export ("headerDidCollapseToOffset:")]
	void HeaderDidCollapseToOffset (double offset);

	// @required -(void)headerDidFinishCollapsing;
	[Abstract]
	[Export ("headerDidFinishCollapsing")]
	void HeaderDidFinishCollapsing ();

	// @required -(void)headerDidExpandToOffset:(double)offset;
	[Abstract]
	[Export ("headerDidExpandToOffset:")]
	void HeaderDidExpandToOffset (double offset);

	// @required -(void)headerDidFinishExpanding;
	[Abstract]
	[Export ("headerDidFinishExpanding")]
	void HeaderDidFinishExpanding ();
}

// @interface MGTransform : NSObject
[BaseType (typeof(NSObject))]
interface MGTransform
{
	// @property (nonatomic) MGAttribute attribute;
	[Export ("attribute", ArgumentSemantic.Assign)]
	MGAttribute Attribute { get; set; }

	// @property (nonatomic) MGTransformCurve curve;
	[Export ("curve", ArgumentSemantic.Assign)]
	MGTransformCurve Curve { get; set; }

	// @property (nonatomic) CGFloat value;
	[Export ("value")]
	nfloat Value { get; set; }

	// @property (nonatomic) CGFloat origValue;
	[Export ("origValue")]
	nfloat OrigValue { get; set; }

	// +(instancetype)transformAttribute:(MGAttribute)attr byValue:(CGFloat)val;
	[Static]
	[Export ("transformAttribute:byValue:")]
	MGTransform TransformAttribute (MGAttribute attr, nfloat val);
}

// @interface MGCollapsingHeaderView : UIView
[BaseType (typeof(UIView))]
interface MGCollapsingHeaderView
{
	[Wrap ("WeakDelegate")]
	MGCollapsingHeaderDelegate Delegate { get; set; }

	// @property (nonatomic, strong) id<MGCollapsingHeaderDelegate> delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Strong)]
	NSObject WeakDelegate { get; set; }

	// @property (nonatomic) CGFloat minimumHeaderHeight;
	[Export ("minimumHeaderHeight")]
	nfloat MinimumHeaderHeight { get; set; }

	// @property (nonatomic) BOOL alwaysCollapse;
	[Export ("alwaysCollapse")]
	bool AlwaysCollapse { get; set; }

	// -(void)setCollapsingConstraint:(NSLayoutConstraint *)c;
	[Export ("setCollapsingConstraint:")]
	void SetCollapsingConstraint (NSLayoutConstraint c);

	// -(void)setCollapsingConstraints:(NSArray *)constrs;
	[Export ("setCollapsingConstraints:")]
	[Verify (StronglyTypedNSArray)]
	void SetCollapsingConstraints (NSObject[] constrs);

	// -(BOOL)addTransformingSubview:(UIView *)view attributes:(NSArray *)attrs;
	[Export ("addTransformingSubview:attributes:")]
	[Verify (StronglyTypedNSArray)]
	bool AddTransformingSubview (UIView view, NSObject[] attrs);

	// -(BOOL)addFadingSubview:(UIView *)view fadeBy:(CGFloat)ratio;
	[Export ("addFadingSubview:fadeBy:")]
	bool AddFadingSubview (UIView view, nfloat ratio);

	// -(void)collapseWithScroll:(UIScrollView *)scrollView;
	[Export ("collapseWithScroll:")]
	void CollapseWithScroll (UIScrollView scrollView);
}
