using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Recycler.mCode
{
    class MyAdapter : RecyclerView.Adapter
    {
        private readonly string[] spacecrafts;

        public MyAdapter(string[] spacecrafts)
        {
            this.spacecrafts = spacecrafts;
        }

        //BIND DATA
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            MyViewHolder h = holder as MyViewHolder;
            if (h != null && h.nameTxt != null) h.nameTxt.Text = spacecrafts[position];
        }

        //INITIALIZE VH
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.Model, parent, false);
            return new MyViewHolder(v);

        }

        //TOTAL SPACECRAFTS
        public override int ItemCount => spacecrafts.Length;
    }

    class MyViewHolder : RecyclerView.ViewHolder
    {
        public TextView nameTxt;
        public MyViewHolder(View itemView) : base(itemView)
        {
            nameTxt = itemView.FindViewById<TextView>(Resource.Id.nameTxt);
        }
    }
}