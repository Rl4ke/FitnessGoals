using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace AppBagrut
{
    class Record : IEquatable<Record>
    {
        public bool Equals(Record other)
        {
            throw new NotImplementedException();
        }
        private int distance;
        private String title;
        private String subTitle;
        private Android.Graphics.Bitmap bitmap;

        public Record(int dis, String title, String subTitle, Android.Graphics.Bitmap bitmap)
        {
            this.distance = dis;
            this.title = title;
            this.subTitle = subTitle;
            this.bitmap = bitmap;
        }
        public static bool operator ==(Record r1,
                                       Record r2)

        {
            if (((object)r1) == null || ((object)r2) == null)
                return Object.Equals(r1, r2);

            return r1.Equals(r2);
        }
        //-------------------------------------------
        public static bool operator !=(Record r1, Record r2)
        //-------------------------------------------
        {
            if (((object)r1) == null || ((object)r2) == null)
                return !Object.Equals(r1, r2);

            return !r1.Equals(r2);
        }

        public override bool Equals(Object obj)
        //-------------------------------------------
        {
            if (obj == null)
                return false;

            Record toyObj = obj as Record;
            if (toyObj == null)
                return false;
            else
                return Equals(toyObj);
        }
        //-------------------------------------------
        public override int GetHashCode()
        //-------------------------------------------
        {
            return base.GetHashCode();
        }

        public int getPrice()
        {
            return distance;
        }

        public void setPrice(int distance)
        {
            this.distance = distance;
        }

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public String getSubTitle()
        {
            return subTitle;
        }

        public void setSubTitle(String subTitle)
        {
            this.subTitle = subTitle;
        }

        public Android.Graphics.Bitmap getBitmap()
        {
            return bitmap;
        }
        public void setBitmap(Android.Graphics.Bitmap bitmap) => this.bitmap = bitmap;

    }
}