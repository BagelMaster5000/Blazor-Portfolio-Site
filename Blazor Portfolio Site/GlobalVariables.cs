using Blazorise.Animate;

public static class GlobalVariables {
    public static int PageAnimationSlideDirection = 0; // 1 if right, -1 if left
    public static IAnimation PageAnimation {
        get {
            switch (PageAnimationSlideDirection) {
                case > 0: return Animations.FadeLeft;
                case < 0: return Animations.FadeRight;
                default: return Animations.FadeIn;
            }
        }
    }

    public static Action? OnPageJump;
}
