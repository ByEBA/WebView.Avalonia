﻿namespace Avalonia.WebView;

partial class WebView
{
    protected override Size MeasureOverride(Size availableSize)
    {
        return LayoutHelper.MeasureChild(Child, availableSize, Padding, BorderThickness);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
        return LayoutHelper.ArrangeChild(Child, finalSize, Padding, BorderThickness);
    }

    public override void Render(DrawingContext context)
    {
        var borderThickness = BorderThickness.Top;
        IPen? pen = null;
        if (BorderBrush != null && borderThickness > 0)
            pen = new ImmutablePen(BorderBrush.ToImmutable(), borderThickness, default, default, default);

        var rect = new Rect(Bounds.Size);
        if (!MathUtilities.IsZero(borderThickness))
            rect = rect.Deflate(borderThickness * 0.5);

        context.PlatformImpl.DrawRectangle(Background, pen, rect, default);
    }

    protected override void OnAttachedToVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnAttachedToVisualTree(e);
        var platformView = _platformWebViewProvider.CreatePlatformView();
        Child = platformView.AttachableControl;
        _platformWebView = platformView;
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        base.OnDetachedFromVisualTree(e);
        Child = null;
        _platformWebView?.Dispose();
    }

}
