using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using AndroidX.AppCompat.App;
using Android;
using Android.Content.PM;
using Android.Runtime;
using System;
using AndroidX.AppCompat.View.Menu;

namespace AppBagrut
{
    [Activity(Label = "SettingsActivity")]
    public class SettingsActivity : AppCompatActivity
    {
        TextView optionsTextView1, optionsTextView2;
        ImageView sortDownImageView1, sortDownImageView2;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.settings);

            optionsTextView1 = FindViewById<TextView>(Resource.Id.optiontextview1);
            sortDownImageView1 = FindViewById<ImageView>(Resource.Id.sortdownimageview1);
            optionsTextView1.Click += OptionsTextView_Click1;
            sortDownImageView1.Click += OptionsTextView_Click1;
            optionsTextView2 = FindViewById<TextView>(Resource.Id.optiontextview2);
            sortDownImageView2 = FindViewById<ImageView>(Resource.Id.sortdownimageView2);
            optionsTextView2.Click += OptionsTextView_Click2;
            sortDownImageView2.Click += OptionsTextView_Click2;

        }

        private void OptionsTextView_Click1(object sender, System.EventArgs e)
        {
            PopupMenu popupMenu = new PopupMenu(this, optionsTextView1);
            popupMenu.MenuItemClick += PopupMenu_MenuItemClick1;
            popupMenu.Menu.Add(Menu.None, 1, 1, "Distance");
            popupMenu.Menu.Add(Menu.None, 2, 2, "Duration");
            popupMenu.Menu.Add(Menu.None, 3, 3, "Calories");
            popupMenu.Show();

        }
        private void OptionsTextView_Click2(object sender, System.EventArgs e)
        {
            PopupMenu popupMenu2 = new PopupMenu(this, optionsTextView2);
            popupMenu2.MenuItemClick += PopupMenu_MenuItemClick2;
            popupMenu2.Menu.Add(Menu.None, 1, 1, "Running");
            popupMenu2.Menu.Add(Menu.None, 2, 2, "Walking");
            popupMenu2.Menu.Add(Menu.None, 3, 3, "Cycling");
            popupMenu2.Show();

        }

        private void PopupMenu_MenuItemClick1(object sender, PopupMenu.MenuItemClickEventArgs e)
        {
            optionsTextView1.Text = e.Item.TitleFormatted.ToString();

            if (e.Item.TitleFormatted.ToString().Contains("Java"))
            {
                Toast.MakeText(this, e.Item.TitleFormatted.ToString(), ToastLength.Short).Show();
            }

        }
        private void PopupMenu_MenuItemClick2(object sender, PopupMenu.MenuItemClickEventArgs e)
        {
            optionsTextView2.Text = e.Item.TitleFormatted.ToString();

            if (e.Item.TitleFormatted.ToString().Contains("Java"))
            {
                Toast.MakeText(this, e.Item.TitleFormatted.ToString(), ToastLength.Short).Show();
            }
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            // Handle item selection
            switch (item.ItemId)
            {
                case Resource.Id.menu_main_page:
                    StartActivity(typeof(MainPageActivity));
                    return true;
                case Resource.Id.menu_settings:
                    // Already in SettingsActivity, no need to start it again
                    return true;
                case Resource.Id.menu_progress:
                    StartActivity(typeof(ProgressActivity));
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}