using Android.App;
using Android.OS;
using Android.Widget;

namespace KitSaud
{
    [Activity(Label = "Kit Saud", MainLauncher = true, Theme = "@android:style/Theme.Material.Light")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // إنشاء واجهة ترحيبية بسيطة داخل التطبيق
            LinearLayout layout = new LinearLayout(this)
            {
                Orientation = Orientation.Vertical,
                Gravity = Android.Views.GravityFlags.Center
            };

            TextView textView = new TextView(this)
            {
                Text = "مرحباً بك في تطبيق كيت سعود!",
                TextSize = 24,
                Gravity = Android.Views.GravityFlags.Center
            };

            layout.AddView(textView);
            SetContentView(layout);
        }
    }
}
