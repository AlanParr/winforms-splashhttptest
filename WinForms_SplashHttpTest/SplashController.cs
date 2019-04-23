using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_SplashHttpTest
{
    public class SplashController
    {
        private static Splash _splash;
        private static SplashController _instance;
        private readonly Form1 formReference;

        delegate void HideSplash();
        delegate void ShowSplash();

        private SplashController(Form1 reference)
        {
            formReference = reference;
        }

        public static SplashController CreateInstance(Form1 formReference)
        {
            _instance = new SplashController(formReference);
            return _instance;
        }

        public static SplashController GetInstance()
        {
            return _instance;
        }
        public void Show()
        {
            if (_splash == null)
            {
                _splash = new Splash();
            }

            _splash.ShowSplash();
        }

        public void Hide()
        {
            if (_splash == null) return;
            _splash.HideSplash();
        }
    }
}
