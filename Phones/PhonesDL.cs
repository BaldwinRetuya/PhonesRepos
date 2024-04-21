using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhonesModel;
namespace Phones
{
    public class PhonesDL
    {
        public List<CPBrands> brands = new List<CPBrands>();
        public PhonesDL()
        {
            CPData();
        }

        public void CPData()
        {

            CPBrands brandone = new CPBrands();
            brandone.Model = " Redmi Note 12 Pro 5G";
            brandone.OperatingSystem = " Android 12 + MIUI 13";
            brandone.Brand = " Xiaomi";
            brandone.Price = " 14,999.00";
            brandone.Processor = " Mediatek Dimensity 1080";

            CPBrands brandtwo = new CPBrands();
            brandtwo.Model = " iPhone XR";
            brandtwo.OperatingSystem = " iOS 12";
            brandtwo.Brand = " Apple";
            brandtwo.Price = " 14,990.00";
            brandtwo.Processor = " Apple A12 Bionic";

            CPBrands brandthree = new CPBrands();
            brandthree.Model = " infinix Zero 5G 2023";
            brandthree.OperatingSystem = " Android 12, XOS 12";
            brandthree.Brand = "Infinix";
            brandthree.Price = " 11,599.00.";
            brandthree.Processor = " Mediatek Dimensity 1080 Mediatek Dimensity 920";

            CPBrands brandfour = new CPBrands();
            brandfour.Model = " TECNO LI9";
            brandfour.OperatingSystem = " Android 14, HIOS 14";
            brandfour.Brand = "TECNO";
            brandfour.Price = " 11,999.00.";
            brandfour.Processor = " MediaTek Dimensity 6080 5G Gaming Processor";

            CPBrands brandfive = new CPBrands();
            brandfive.Model = " ROG Phone 5s";
            brandfive.OperatingSystem = " Android 11, upgradable to Android 12, ROG UI";
            brandfive.Brand = " Asus";
            brandfive.Price = " 22,000.00.";
            brandfive.Processor = " Snapdragon 888 5G";

            CPBrands brandsix = new CPBrands();
            brandsix.Model = "  Xiaomi Poco X6 Neo";
            brandsix.OperatingSystem = " Android 13";
            brandsix.Brand = " Xiaomi";
            brandsix.Price = " 15,999.00";
            brandsix.Processor = " Mediatek Dimensity 6080 Octa-core";

            CPBrands brandseven = new CPBrands();
            brandseven.Model = " iPhone 14";
            brandseven.OperatingSystem = " iOS 16, upgradable to iOS 17.4";
            brandseven.Brand = " Apple";
            brandseven.Price = " 56,990.00";
            brandseven.Processor = " A15 Bionic";

            CPBrands brandeight = new CPBrands();
            brandeight.Model = " Infinix Note 40 Pro";
            brandeight.OperatingSystem = " Android 14, XOS 14";
            brandeight.Brand = " Infinix";
            brandeight.Price = " 16,999.00";
            brandeight.Processor = " MediaTek Helio G99 Ultimate";

            CPBrands brandnine = new CPBrands();
            brandnine.Model = " CAMON 20 Pro 5G";
            brandnine.OperatingSystem = " Android 13 OS";
            brandnine.Brand = " TECNO";
            brandnine.Price = " 13,999.00";
            brandnine.Processor = " octa-core MediaTek Dimensity 8050";

            CPBrands brandten = new CPBrands();
            brandten.Model = " Zenfone 8";
            brandten.OperatingSystem = " Android 11";
            brandten.Brand = " Asus";
            brandten.Price = "  39,995.00";
            brandten.Processor = " Qualcomm Snapdragon 888 5G with Octa-core (1x2.84 GHz";


            brands.Add(brandone);
            brands.Add(brandtwo);
            brands.Add(brandthree);
            brands.Add(brandfour);
            brands.Add(brandfive);
            brands.Add(brandsix);
            brands.Add(brandseven);
            brands.Add(brandeight);
            brands.Add(brandnine);
            brands.Add(brandten);
        }
    }
}

