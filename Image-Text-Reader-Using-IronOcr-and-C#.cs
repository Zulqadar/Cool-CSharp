//Before Start, Read This...
//This code is uses reference of IronOcr nuget package, Package Manager Console Command is given below to install IronOcr
//-> Install-Package IronOcr -Version 4.4.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;  // <- Add IronOcr Reference 

namespace ImageTextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var ocrAdv = new IronOcr.AdvancedOcr()
            {
                CleanBackgroundNoise = true,
                EnhanceContrast = true,
                EnhanceResolution = true,
                Language = IronOcr.Languages.English.OcrLanguagePack,
                Strategy = IronOcr.AdvancedOcr.OcrStrategy.Advanced,
                ColorSpace = IronOcr.AdvancedOcr.OcrColorSpace.Color,
                DetectWhiteTextOnDarkBackgrounds = true,
                InputImageType = AdvancedOcr.InputTypes.AutoDetect,
                RotateAndStraighten = true,
                ReadBarCodes = false,
                ColorDepth = 4
            };

            var testDoc = @"E:\zulqadar\Ocr1.jpg"; //Path to Your Image File
            var res = ocrAdv.Read(testDoc);
            Console.WriteLine(res.Text);

            Console.ReadKey();
        }
    }
}
