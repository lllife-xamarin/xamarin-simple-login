using System;
using UIKit;
using CoreGraphics;

namespace CodeOnlyDemo
{
    public class CustomViewController : UIViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.BackgroundColor = UIColor.Gray;

            nfloat h = 31.0f;
            nfloat w = View.Bounds.Width;

            var usernameField = new UITextField
            {
                Placeholder = "Enter your username",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CGRect(10, 32, w - 20, h),
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth
            };

            var passwordField = new UITextField
            {
                Placeholder = "Enter your password",
                BorderStyle = UITextBorderStyle.RoundedRect,
                Frame = new CGRect(10, 64, w - 20, h),
                SecureTextEntry = true,
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth
            };

			var submitButton = UIButton.FromType (UIButtonType.RoundedRect);
            submitButton.Frame = new CGRect(10, 120, w - 20, 44);
            submitButton.BackgroundColor = UIColor.White;
            submitButton.Layer.CornerRadius = 5f;
            submitButton.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
            submitButton.SetTitle("Submit", UIControlState.Normal);

            submitButton.TouchUpInside += delegate
            {
                Console.WriteLine("Submit button pressed");
                var circleController = new CircleController();
                PresentViewController(circleController, true, null);
            };

            View.AddSubviews(new UIView[]{ usernameField, passwordField, submitButton });
        }
    }
}