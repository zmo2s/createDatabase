using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDatabase
{
    public class Constant
    {
        public ConfigSensor[] cars = {  new ConfigSensor() {
                dureeAiTotOut = false,
                modeMag = false,
                sesibilitePir = false,
        },
            new ConfigSensor() {
                dureeAiTotOut = true,
                modeMag = false,
                sesibilitePir = false,
        },
                        new ConfigSensor() {
                dureeAiTotOut = false,
                modeMag = true,
                sesibilitePir = false,
        },
                                    new ConfigSensor() {
                dureeAiTotOut = false,
                modeMag = false,
                sesibilitePir = true,
        }
        };


        public Config400[] config400 = { new Config400()
            {
                dataToDownload = true,
                dtm =true,
                eventDTM1 = true,
                eventPeriod1 = true,
                eventPeriod2 = true,
                eventTx = true,
                eventTxSeconde  = true,
                framePlayloadNumber  = true,
                periodeEmssionSecondaire = true,
                periodeMesurCapteur = true
            }, new Config400()
            {
                dataToDownload = false,
                dtm =false,
                eventDTM1 = false,
                eventPeriod1 = false,
                eventPeriod2 = false,
                eventTx = false,
                eventTxSeconde  = false,
                framePlayloadNumber  = false,
                periodeEmssionSecondaire = false,
                periodeMesurCapteur = false
            }, };


       
    }
}
