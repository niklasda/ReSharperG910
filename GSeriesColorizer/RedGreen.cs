using GSeriesColorizer.Lib;

namespace GSeriesColorizer
{
    public class RedGreen
    {   
        public string GetVersion()
        {
            if (LogitechGSDK.LogiLedInit())
            {
                int maj = 0, min = 0, build = 0;

                if (LogitechGSDK.LogiLedGetSdkVersion(ref maj, ref min, ref build))
                {
                    return string.Format("{0}.{1}.{2}", maj, min, build);
                }

                LogitechGSDK.LogiLedShutdown();
            }

            return "Failure";
        }

        public bool SetRed()
        {
            if (LogitechGSDK.LogiLedInit())
            {
                var m_targetDevice = LogitechGSDK.LOGI_DEVICETYPE_ALL;

                if (LogitechGSDK.LogiLedSetTargetDevice(m_targetDevice))
                {
                    LogitechGSDK.LogiLedSetLighting(100, 0, 0);
                }

                LogitechGSDK.LogiLedShutdown();
                return true;
            }

            return false;
        }

        public bool SetGreen()
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



                 
                }


                LogitechGSDK.LogiLedShutdown();
                return true;
            }

            return false;
        }
    }
}
