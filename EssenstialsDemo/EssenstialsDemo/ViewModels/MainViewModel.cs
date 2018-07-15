using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EssenstialsDemo.ViewModels
{
    public class MainViewModel
    {
        #region Fields

        private string _deviceBrand;
        private string _deviceModel;
        private string _deviceName;
        private string _devicePlatform;
        private string _connectivityText;
        private string _textToSpeak;

        private int _connectivity;

        private Command _speakCommand;
        #endregion

        #region Properties

        public string DeviceBrandText
        {
            get
            {
                return $"Brand: {_deviceBrand}";
            }
        }

        public string DeviceNameText
        {
            get
            {
                return $"Name: {_deviceName}";
            }
        }

        public string DeviceModelText
        {
            get
            {
                return $"Model: {_deviceModel}";
            }
        }

        public string DevicePlatformText
        {
            get
            {
                return $"Platform: {_devicePlatform}";
            }
        }

        public string ConnectivityText
        {
            get { return _connectivityText; }
            set { _connectivityText = value; }
        }

        public string TextToSpeak
        {
            get { return _textToSpeak; }
            set { _textToSpeak = value; }
        }

        public int Connectivity
        {
            get { return _connectivity; }
            set { _connectivity = value; }
        }

        #endregion

        #region Commands

        public Command SpeakCommand
        {
            get { return _speakCommand; }
            set { _speakCommand = value; }
        }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            _deviceBrand = string.Empty;
            _deviceModel = string.Empty;
            _deviceName = string.Empty;
            _devicePlatform = string.Empty;
            _textToSpeak = string.Empty;

            _connectivity = 0;
            _connectivityText = "Unknown";
            _speakCommand = new Command(speak);
        }
        #endregion

        #region Methods

        private void speak()
        {
            if(!string.IsNullOrEmpty(_textToSpeak))
            {

            }
        }
        #endregion

    }
}
