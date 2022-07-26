using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using createDatabase;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace ConsoleApplication1
{
    public class TagInput
    {
        public ObjectId Id { get; set; }
        public string format { get; set; }
        public string model { get; set; }
        public string version { get; set; }
        public MongoDBRef configBase { get; set; }
    }
    public class ConfigBase
    {
        public ObjectId Id { get; set; }
        public bool dureeEvent { get; set; }
        public bool isActivateTag { get; set; }
        public bool isLoggerActivate { get; set; }
        public bool puissanceDbm { get; set; }
        public bool recurrenceAdvertising { get; set; }
        public bool recurrenceEvent { get; set; }
        public bool recurrenceLog { get; set; }
        public bool useBUzzer { get; set; }
        public bool useLED { get; set; }
        public bool useModConnected { get; set; }
        public MongoDBRef config400 { get; set; }
        public MongoDBRef configSensor { get; set; }
    }
    public class ConfigSensor
    {
        public ObjectId Id { get; set; }
        public bool dureeAiTotOut { get; set; }
        public bool modeMag { get; set; }
        public bool sesibilitePir { get; set; }
    }
    public class Config400
    {
     
        public ObjectId Id { get; set; }
        public bool dataToDownload { get; set; }
        public bool dtm { get; set; }
        public bool eventDTM1 { get; set; }
        public bool eventPeriod1 { get; set; }
        public bool eventPeriod2 { get; set; }
        public bool eventTx { get; set; }
        public bool eventTxSeconde { get; set; }
        public bool framePlayloadNumber { get; set; }
        public bool periodeEmssionSecondaire { get; set; }
        public bool periodeMesurCapteur { get; set; }
    }

    public class Config
    {
        public TagInput tagInput;
        public ConfigBase configBase;
        public Config400 config400;
        public ConfigSensor configSensor;

        public void configBaseExec()
        {
            configBase = Constant.configBase(this.config400.Id, this.configSensor.Id);
            
        }
        public void tagInputExec(int id)
        { tagInput = Constant.tagInput(id, configBase.Id); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("tagsConfiguration");
            var collectionTagInput = database.GetCollection<TagInput>("TagInput");
            var collectionConfigBase = database.GetCollection<ConfigBase>("ConfigBase");
            var collectionConfigSensor = database.GetCollection<ConfigSensor>("ConfigSensor");
            var collectionConfig400 = database.GetCollection<Config400>("Config400");
            
            /*

            Config400 config400 = new Config400()
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
            };
            
            ConfigSensor configSensor = new ConfigSensor()
            {
                dureeAiTotOut = true,
                modeMag = true,
                sesibilitePir = true
            };
            

            ConfigBase configBase = new ConfigBase
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
                config400 = new MongoDBRef("Config400", config400.Id),
                configSensor = new MongoDBRef("ConfigSensor", configSensor.Id),
            };
            
            TagInput tagInput = new TagInput
            {
                format = "ID",
                model = "PUCK",
                version = "4.0.0",
                configBase = new MongoDBRef("ConfigBase", configBase.Id)
            };

            /*collectionConfig400.InsertOne(config400);
            collectionConfigSensor.InsertOne(configSensor);
            collectionConfigBase.InsertOne(configBase);
            collectionTagInput.InsertOne(tagInput);
            */

            List<Config> config = new List<Config>()
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
            };
            int cpt = 0;
            List<Config400> config4001 = new List<Config400>();
            foreach( Config element in config)
            {
               
                Config test = element;
             //   test.config400.Id = ObjectId.Parse(cpt.ToString());// ObjectId.GenerateNewId();
                config4001.Add(test.config400);
                  Console.WriteLine("ok");
                  collectionConfigSensor.InsertOne(element.configSensor);
                 element.configBaseExec();
                  collectionConfigBase.InsertOne(element.configBase);
                  element.tagInputExec(cpt);
                  collectionTagInput.InsertOne(element.tagInput);
                  cpt++;
                
                Thread.Sleep(500);
               
            }
          //  collectionConfig400.InsertMany(config4001.ToArray());
        }
    }
}