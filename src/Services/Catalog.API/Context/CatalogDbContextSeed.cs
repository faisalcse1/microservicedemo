using Catalog.API.Manager;
using Catalog.API.Models;
using System.Numerics;

namespace Catalog.API.Context
{
    public class CatalogDbContextSeed
    {
        static ProductManager _productManager=new ProductManager();

        public static void Seed()
        {
            var product = _productManager.GetFirstOrDefault(c=>true);
            if (product == null)
            {
                _productManager.Add(GetPreconfiguredProducts());
            }
        }

        private static List<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone 11",
                    Summary = "Total by Verizon iPhone 11, 64GB, Black - Prepaid Smartphone (Locked).",
                    Description = "Take it to 11. Capture amazing photos and videos with the Apple iPhone 11 in Black from Total by Verizon thanks to its dual camera system. Get up to 17 hours of video playback and charge your phone even quicker with its fast-charging capability. And with 64GB of storage, you'll be able to download and store your favorite apps, games, music and more! Get a premium wireless experience without the premium price tag or costly long-term contracts with no contract plans starting at just $30/mo for a single line. Access the fastest speeds with Verizon 5G Nationwide and enjoy special perks like hotspot capability, international long-distance calling, and exclusive discounts. *5G Nationwide available in 2,700+ cities. Capable device and SIM required. Actual availability, coverage and speed may vary..",
                    ImageFile = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Samsung 10",
                    Summary = "Samsung Galaxy S10, 5G, Verizon, 256GB - Majestic Black",
                    Description = "Connect with 5G. Stream movies, play games, and wirelessly cast in 4k resolution. With 5G Ultra Wideband connectivity, you can share and download at ultra-fast speeds. Virtually frameless. Take your entertainment experience to the next level using the 6.7-inch AMOLED Cinematic Infinity Display.2 The Samsung Galaxy S10 5G provides a reduced bezel and maximum screen size on a device that’s slim and comfortable to hold.",
                    ImageFile = "product-2.png",
                    Price = 840.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f7",
                    Name = "Lenovo IdeaPad Slim",
                    Summary = "Lenovo IdeaPad Slim 3i 15ITL Intel Core i3 1005G1 4GB Ram 256GB SSD 15.6 Inch FHD Display Platinum Grey Laptop.",
                    Description = "Laptop Brand - Lenovo, Laptop Series - IdeaPad, Laptop Model - Lenovo IdeaPad Slim 3i 15IIL, Processor Brand - Intel, Processor Type - Intel Core i3, Processor Generation - 10th (Intel), Processor Model - Core i3 1005G1, Processor Base Frequency - 1.20 GHz, Processor Max Turbo Frequency - 3.40 GHz, Processor Core - 2, Processor Thread - 4, Processor Cache - 4MB, Display Size - 15.6 Inch, Display Technology - FHD LED Display, Display Resolution - 1920 x 1080, Display Features - Brightness: 220 Nits, 45% NTSC, Memory (RAM) - 4GB, Installed Memory Details - 1 x 4GB Non-Removable, Memory Type - DDR4, Memory Bus (MHz) - 3200 MHz, Total Memory Slot - 1, Empty Memory Slot - 1, Max Memory Support - 12GB, Storage - 256GB SSD, HDD Expansion Slot - No, Installed SSD Type - NVMe PCIe, SSD Expansion Slot - None, Storage Upgrade - Installed SSD can be upgradeable, Optical Drive - No-ODD, Multimedia Card Slot - 1, Supported Multimedia Card - 4-in-1 Card Reader (SD, SDHC, SDXC, MMC), Graphics Chipset - Intel UHD Graphics, Graphics Memory Accessibility - Integrated, Graphics Memory - Shared, LAN - No, WiFi - WiFi 5, Bluetooth - Bluetooth 5.0, USB 2 Port - 1 x USB 2.0 Type-A, USB 3 Port - 2 x USB 3.2 Gen 1 Type-A, HDMI Port - 1, Headphone Port - Combo, Microphone Port - Combo, Audio Properties - Dual-Array Microphones, Dolby Audio Stereo Speakers, 1.5W x2, Speaker - Yes, Microphone - Yes, Webcam - HD Webcam, Keyboard Back-lit - No, Pointing Device - Touchpad, Finger Print Sensor - No, Security Chip - Firmware TPM 2.0, Operating System - Windows 11 Home, Body Material - PC + ABS (Top & Bottom), Color - Platinum Grey.",
                    ImageFile = "product-3.png",
                    Price = 650.00M,
                    Category = "Laptop"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f8",
                    Name = "Xiaomi Mi 9",
                    Summary = "Xiaomi Mi 9 SE Cell Phone Snapdragon 712 Android Fingerprint Global Version Original Smartphone.",
                    Description = "The sources of all brand products sold in this store include: brand counter display machines, end-of-stock clearance machines, sample machines, etc. Because we need to update it to the global version, there will be some scratches or abrasions, please consider it carefully before you purchase the order.",
                    ImageFile = "product-4.png",
                    Price = 470.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f9",
                    Name = "Hp Laptop",
                    Summary = "15.6 PA156 Laptop Computer Win10 Intel N5095 16G 128G/256G/512G Notebook Netbook Backlit Keyboard WIFI HD BT4.0 USB3.0 3.0MP.",
                    Description = "CPU: Intel 8 generation celeron J4125 GPU: Intel Core graphics card 500 Memory: 12GB + 128GB / 256GB /512GB/1TB OS: Windows 10 Camera:Front 0.3MP HDMI / Backlit Keyboard / Bluetooth 4.0 / Intel 2.4G/5G dual channel WIFI , BT 4.0 All items price NOT include destination custom taxes or VAT. Windows OS key is included The product sent contains the software contained in the following picture.",
                    ImageFile = "product-5.png",
                    Price = 380.00M,
                    Category = "Laptop"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47fa",
                    Name = "DELL Inspiron 7510",
                    Summary = "Vinyl Stickers for DELL Inspiron 7510 7501 7610 7620 5510 Solid Laptop Skin for DELL Inspiron 7420 5310 5418 Decal Film.",
                    Description = "The effect picture shows only one model. Please place an order according to your specific model, not just the picture.2. If you are not sure of your laptop model, please contact customer service.",
                    ImageFile = "product-6.png",
                    Price = 240.00M,
                    Category = "Laptop"
                }
            };
        }
    }
}
