using ConsoleApplication1;
using createDatabase.Model;
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
        public static int[] inputTagConstant = { 0, 1, 2 ,3,4,5,6,7,8,9,10,11,12,13 };
        public static ConfigSensor[] configSensor =
            {
            new ConfigSensor() {
                dureeAiTorOut = true,
                modeMag = false,
                sensibilitePir = false,
        },
            new ConfigSensor() {
                dureeAiTorOut = false,
                modeMag = true,
                sensibilitePir = false,
        },
            new ConfigSensor() {
                dureeAiTorOut = false,
                modeMag = false,
                sensibilitePir = true,
        },
                      new ConfigSensor() {
                dureeAiTorOut = false,
                modeMag = false,
                sensibilitePir = false,
                                        }
        };
        public static Config400[] config400 = {
                         new Config400()
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
                dtm =true,
                eventDTM1 = true,
                eventPeriod1 = true,
                eventPeriod2 = true,
                eventTx = true,
                eventTxSeconde  = true,
                framePlayloadNumber  = true,
                periodeEmssionSecondaire = true,
                periodeMesurCapteur = true
            },



     
        };
        public static ConfigBase[] configBases =
            { new ConfigBase
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
                format = "EDDYSTONE",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "EDDYSTONE",
                model = "PUCK",
                version = "4.0.0",
            },

            new TagInput
            {
                format = "IBEACON",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "IBEACON",
                model = "PUCK",
                version = "4.0.0",
            },

            new TagInput
            {
                format = "T",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "T",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "RHT",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "RHT",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "MAG",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "MAG",
                model = "PUCK",
                version = "4.0.0",
            },
             new TagInput
            {
                format = "MOV",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "MOV",
                model = "PUCK",
                version = "4.0.0",
            },
             new TagInput
            {
                format = "ANG",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "ANG",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "TOROUT",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "TOROUT",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "AI",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "AI",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "TORIN",
                model = "PUCK",
                version = "2.0.0",
            },
            new TagInput
            {
                format = "TORIN",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "TPROBE",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "PIR",
                model = "PUCK",
                version = "4.0.0",
            },
            new TagInput
            {
                format = "PROXIR",
                model = "PUCK",
                version = "4.0.0",
               // configBase =
            },
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

        public static List<Config> config = new List<Config>()
            {
                // ID
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // EDDYSTONE
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                 // IBEACON
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // T
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // RHT
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // MAG
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[1],
                    config400 = Constant.config400[1],
                            },
                // MOV
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // ANG
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // TOROUT
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[0],
                    config400 = Constant.config400[1],
                            },
                // AI
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // TORIN
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[0],
                            },
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // TPROBE
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
                // PIR
                new Config(){
                    configSensor = Constant.configSensor[2],
                    config400 = Constant.config400[1],
                            },
                // PROXIR
                new Config(){
                    configSensor = Constant.configSensor[3],
                    config400 = Constant.config400[1],
                            },
            };
    }
}

