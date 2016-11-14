﻿Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Text
Imports Aspose.BarCode.BarCodeRecognition
Imports Aspose.BarCode
Imports Aspose.BarCode.Generation

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.BarCode.Examples.VisualBasic.CreateAndManageTwoDBarcodes
    Class EncodeQRCodEInECIMode
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_CreateAndManage2DBarCodes()

            ' initialize a BarCodeBuilder class object and Set its CodeText & Symbology Type 
            Dim builder As New BarCodeBuilder("12345TEXT", EncodeTypes.QR)

            ' Set encoding mode
            builder.QREncodeMode = QREncodeMode.ECIEncoding

            ' Set ForceQR (default) for standard QR
            builder.QREncodeType = QREncodeType.ForceQR

            ' Set ECI encoding type
            builder.ECIEncoding = ECIEncodings.UTF8

            ' Set error correction level
            builder.QRErrorLevel = QRErrorLevel.LevelL

            ' Get barcode image Bitmap
            Dim lBmp As Bitmap = builder.GenerateBarCodeImage()

            ' Save QR code
            lBmp.Save(dataDir & Convert.ToString("EncodeQRCodEInECIMode_out.bmp"), ImageFormat.Bmp)
        End Sub
    End Class
End Namespace