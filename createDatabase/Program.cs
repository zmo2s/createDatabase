using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using createDatabase;
using createDatabase.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace ConsoleApplication1
{
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
            int cpt = 0;
            foreach (Config element in Constant.config)
            {
                collectionConfig400.InsertOne(element.config400);
                element.config400.Id = ObjectId.GenerateNewId();
                collectionConfigSensor.InsertOne(element.configSensor);
                element.configSensor.Id = ObjectId.GenerateNewId();
                element.configBaseExec();
                collectionConfigBase.InsertOne(element.configBase);
                element.configBase.Id = ObjectId.GenerateNewId();
                element.tagInputExec(cpt);
                collectionTagInput.InsertOne(element.tagInput);
                element.tagInput.Id = ObjectId.GenerateNewId();
                cpt++;
                Thread.Sleep(500);
            }
        }
    }
}