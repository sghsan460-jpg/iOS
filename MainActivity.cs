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

            // إنشاء الواجهة
            LinearLayout layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;
            
            // التعديل الصحيح لتجنب الخطأ: استدعاء دالة التوسط مباشرة
            layout.SetGravity(Android.Views.GravityFlags.Center);

            TextView textView = new TextView(this)
            {
                Text = "مرحباً بك في تطبيق كيت سعود!",
                TextSize = 24
            };
            textView.SetGravity(Android.Views.GravityFlags.Center);

            layout.AddView(textView);
            SetContentView(layout);
        }
    }
}
