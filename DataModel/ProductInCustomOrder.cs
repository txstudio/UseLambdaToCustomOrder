using System;

namespace DataModel
{
    //繼承 Product 物件新增 Sort 屬性，依照 Brand 屬性的數值給予排序使用的索引數值
    public class ProductInCustomOrder : Product
    {
        public int Sort
        {
            get
            {

                if (String.IsNullOrWhiteSpace(this.Brand) == true)
                    return 999;

                var _compare = StringComparison.OrdinalIgnoreCase;

                if (String.Equals(this.Brand, "NOKIA", _compare) == true)
                    return 10;

                if (String.Equals(this.Brand, "HTC", _compare) == true)
                    return 700;

                if (String.Equals(this.Brand, "Apple", _compare) == true)
                    return 800;

                if (String.Equals(this.Brand, "Microsoft", _compare) == true)
                    return 1;

                return 998;
            }
        }
    }
}
