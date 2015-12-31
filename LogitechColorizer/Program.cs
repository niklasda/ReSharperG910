using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogitechColorizer.Lib;

namespace LogitechColorizer
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (LogitechGSDK.LogiLedInit())
            {
                var m_targetDevice = LogitechGSDK.LOGI_DEVICETYPE_ALL;

                if (LogitechGSDK.LogiLedSetTargetDevice(m_targetDevice))
                {

                    LogitechGSDK.LogiLedSetLighting(0, 100, 0);

                    //LogitechGSDK.LogiLedSaveCurrentLighting();
                    //LogitechGSDK.LogiLedSetLighting(10, 10, 100);
                    //LogitechGSDK.LogiLedRestoreLighting();
            //        LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(KeyboardNames.NUM_ZERO, 10, 100, 10);

            //        LogitechGSDK.LogiLedSaveLightingForKey(KeyboardNames.NUM_ZERO);

//                LogitechGSDK.LogiLedFlashSingleKey(KeyboardNames.NUM_ZERO, 0, 100, 0, 5000, 500);
            //        LogitechGSDK.LogiLedPulseSingleKey(KeyboardNames.NUM_ZERO, 0, 10, 0, 0, 100, 0, 2000, false);



                    int maj = 0, min = 0, build = 0;
                    if (LogitechGSDK.LogiLedGetSdkVersion(ref maj, ref min, ref build))
                    {
                        Console.WriteLine("GSDK Version v{0}.{1}.{2}", maj, min, build);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                    }
                }


                LogitechGSDK.LogiLedShutdown();
            }
        }

        void OnBnClickedCheck1()
        {
            var m_targetDevice = 0;
           m_targetDevice |= LogitechGSDK.LOGI_DEVICETYPE_RGB;
           m_targetDevice |= LogitechGSDK.LOGI_DEVICETYPE_MONOCHROME;
           m_targetDevice |= LogitechGSDK.LOGI_DEVICETYPE_PERKEY_RGB;
            
            LogitechGSDK.LogiLedSetTargetDevice(m_targetDevice);
        }
    }
}
