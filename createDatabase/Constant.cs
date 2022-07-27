using ConsoleApplication1;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDatabase
{
    public static class Constant
    {

        public static int[] inputTagConstant =  { 1,2 };
        public static ConfigSensor[] configSensor = {  
  
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
        },
                      new ConfigSensor() {
                dureeAiTotOut = false,
                modeMag = false,
                sesibilitePir = false,
        }
        };


        public static Config400[] config400 = { new Config400()
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
            },
        new Config400()
            {
                dataToDownload = true,
                dtm =false,
                eventDTM1 = false,
                eventPeriod1 = false,
                eventPeriod2 = false,
                eventTx = false,
                eventTxSeconde  = false,
                framePlayloadNumber  = false,
                periodeEmssionSecondaire = false,
                periodeMesurCapteur = false
            }

        };

        public static ConfigBase[] configBases = { new ConfigBase
            {
                dureeEvent = true,
                isActivateTag = true,
                isLoggerActivate = true,
                puissanceDbm = true,
                recurrenceAdvertising = true,
                recurrenceEvent = true,
                recurrenceLog = true,
                useBUzzer = true,
                useLED = true,
                useModConnected = true,
            //  config400 = new MongoDBRef("Config400", config400.Id),
            //  configSensor = new MongoDBRef("ConfigSensor", configSensor.Id),
                                            } 
            };
        public static TagInput[] tagInputs =
        {
            new TagInput
            {
                format = "ID",
                model = "PUCK",
                version = "2.0.0",
            }, new TagInput
            {
                format = "ID",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "ID",
                model = "EDDYSTONE",
                version = "4.0.0",
            }
        };



        public static ConfigBase configBase(ObjectId config400, ObjectId configSensor)
        
          {
            return new ConfigBase
            {
                dureeEvent = true,
                isActivateTag = true,
                isLoggerActivate = true,
                puissanceDbm = true,
                recurrenceAdvertising = true,
                recurrenceEvent = true,
                recurrenceLog = true,
                useBUzzer = true,
                useLED = true,
                useModConnected = true,
                config400 = new MongoDBRef("Config400", config400),
                configSensor = new MongoDBRef("ConfigSensor", configSensor),
            };
            }

        public static TagInput tagInput(int id, ObjectId configBase)
        {
            TagInput tagInput = tagInputs[id];
            tagInput.configBase = new MongoDBRef("ConfigBase", configBase);
            return tagInput;
        }


    }
       
    }

