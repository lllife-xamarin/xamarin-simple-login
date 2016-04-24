using Foundation;
using UIKit;

namespace CodeOnlyDemo
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var controller = new CustomViewController();
			// create a new window instance based on the screen size
			var window = new UIWindow (UIScreen.MainScreen.Bounds) {
				RootViewController = controller
			};

            // make the window visible
            window.MakeKeyAndVisible();
			
            return true;
        }
    }
}

