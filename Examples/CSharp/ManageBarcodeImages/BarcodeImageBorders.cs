﻿using System.Drawing.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class BarcodeImageBorders
    {
        public static void Run()
        {
            // ExStart:BarcodeImageBorders   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object and set different properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder
            {
                BorderDashStyle = BorderDashStyle.Solid,
                Margins = new MarginsF(2f, 2f, 2f, 2f),
                BorderWidth = 0.5f,
                BorderVisible = true
            };
            barCodeBuilder.Save(dataDir + "barcodeImageborders_out.jpeg", ImageFormat.Jpeg);
            // ExEnd:BarcodeImageBorders   
        }
    }
}
