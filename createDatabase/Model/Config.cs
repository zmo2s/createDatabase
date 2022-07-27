using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createDatabase.Model
{
    public class Config
    {
     
        public TagInput tagInput;
        public ConfigBase configBase;
        public Config400 config400;
        public ConfigSensor configSensor;

        public void configBaseExec()
        {
            configBase = Constant.configBase(this.config400._id, this.configSensor._id);

        }
        public void tagInputExec(int id)
        { tagInput = Constant.tagInput(id, configBase._id); }
    }
}
