using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using QRCoder;
using QRGenerator.QR;

namespace QRGenerator
{
    public partial class QRPromptPayGenerator : UserControl
    {
        public static readonly DependencyProperty PropmtPayIDProperty =
            DependencyProperty.Register("PropmtPayID",
                typeof(string),
                typeof(QRPromptPayGenerator),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedPromptPayEvtChanged));

        public static readonly DependencyProperty AmountProperty =
            DependencyProperty.Register("Amount",
                typeof(string),
                typeof(QRPromptPayGenerator),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnSelectedAmountEvtChanged));

        #region PropmtPayID
        public string PropmtPayID
        {
            get { return (string)GetValue(PropmtPayIDProperty); }
            set { SetValue(PropmtPayIDProperty, value); }
        }

        private static void OnSelectedPromptPayEvtChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            QRPromptPayGenerator ctrl = obj as QRPromptPayGenerator;
        }
        #endregion        

        #region Amount
        public string Amount
        {
            get { return (string)GetValue(AmountProperty); }
            set { SetValue(AmountProperty, value); }
        }

        private static void OnSelectedAmountEvtChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            QRPromptPayGenerator ctrl = obj as QRPromptPayGenerator;
        }
        #endregion

        public QRPromptPayGenerator()
        {
            InitializeComponent();
        }

        public void GenerateQR()
        {
            string payload = PromptPayUtils.QRCodePayload(PropmtPayID, Amount);

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);            
            PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeAsPngByteArr = qrCode.GetGraphic(200);

            var ms = new MemoryStream(qrCodeAsPngByteArr);
            var imageSource = new BitmapImage();

            imageSource.BeginInit();
            imageSource.StreamSource = ms;
            imageSource.EndInit();

            imgQR.Source = imageSource;
        }        
    }
}
