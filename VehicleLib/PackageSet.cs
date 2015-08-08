using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLib
{

    public abstract class FeatureSetBase<T>
    {
        protected List<T> list = null;

        public FeatureSetBase()
        {
            list = new List<T>(); 
        }
        public abstract void Add(T item);
    }

    public abstract class ItemChooserSet<T> : FeatureSetBase<T>
    {
        public ItemChooserSet()
            : base()
        {
            
        }
        public abstract Boolean SelectOne(string code);
        public abstract Boolean SelectMulti(params string[] codes);
        public abstract Boolean DeselectMulti(params string[] codes);
    }

    public class FeatureSet : FeatureSetBase<Package>
    {
        public FeatureSet() : base()
        {

        }

        public override void Add(Package item)
        {
            list.Add(item);
        }
    }

    public class PackageSet : ItemChooserSet<Package>
    {

        public PackageSet() : base()
        {
            
        }

        public override void Add(Package item)
        {
            list.Add(item);
        }

        public Package GetPackage(string code)
        {
            foreach (Package itm in list)
            {
                if (itm.Code.Equals(code))
                {
                    return itm;
                }
            }
            return null;
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

    public class ColorSet : ItemChooserSet<Color>
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
