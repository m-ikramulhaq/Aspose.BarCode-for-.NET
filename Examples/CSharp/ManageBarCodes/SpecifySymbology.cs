﻿using System.Drawing.Imaging;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SpecifySymbology
    {
        public static void Run()
        {
            // ExStart:SpecifySymbology   
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate barcode object and set differnt barcode properties
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128);

            // Save the image to your system and set its image format to Jpeg
            barCodeBuilder.Save(dataDir + "barcode-symbiology_out.jpg", ImageFormat.Jpeg);
            // ExEnd:SpecifySymbology   
        }
    }
}