﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{

    public abstract class ItemSet<T>
    {
        protected List<T> list = null;
        public ItemSet() 
        {
            list = new List<T>(); 
        }
        public abstract void Add(T item);
        public abstract Boolean SelectOne(string code);
        public abstract Boolean SelectMulti(params string[] codes);
        public abstract Boolean DeselectMulti(params string[] codes);
    }

    public class PackageSet : ItemSet<Package>
    {

        public PackageSet() : base()
        {
            
        }

        public override void Add(Package item)
        {
            list.Add(item);
        }

        public override Boolean SelectOne(string code)
        {
            foreach (Package itm in list)
            {
                itm.IsSelected = false;
            }

            foreach (Package itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    itm.IsSelected = true;
                    return true;
                }
            }
            return false;
        }

        public override Boolean SelectMulti(params string[] codes)
        {
            foreach (Package itm in list)
            {
                foreach (string code in codes)
                {
                    if (itm.Code.Equals(code))
                    {
                        itm.IsSelected = true;
                    }
                }
            }
            return false;
        }

        public override Boolean DeselectMulti(params string[] codes)
        {
            foreach (Package itm in list)
            {
                foreach (string code in codes)
                {
                    if (itm.Code.Equals(code))
                    {
                        itm.IsSelected = false;
                    }
                }
            }
            return false;
        }

    }

    public class ColorSet : ItemSet<Color>
    {
        public ColorSet() : base()
        {
            
        }

        public override void Add(Color item)
        {
            list.Add(item);
        }

        public override Boolean SelectOne(string code)
        {
            foreach (Color itm in list)
            {
                itm.IsSelected = false;
            }

            foreach (Color itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    itm.IsSelected = true;
                    return true;
                }
            }
            return false;
        }

        public override Boolean SelectMulti(params string[] codes)
        {
            foreach (Color itm in list)
            {
                foreach (string code in codes)
                {
                    if (itm.Code.Equals(code))
                    {
                        itm.IsSelected = true;
                    }
                }
            }
            return false;
        }

        public override Boolean DeselectMulti(params string[] codes)
        {
            foreach (Color itm in list)
            {
                foreach (string code in codes)
                {
                    if (itm.Code.Equals(code))
                    {
                        itm.IsSelected = false;
                    }
                }
            }
            return false;
        }

    }
}