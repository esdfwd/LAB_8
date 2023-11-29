using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_8
{
    internal class ConfigurationManager
    {
    }
}
class ConfigurationManager
{
    constructor()
    {
        if (ConfigurationManager.instance)
        {
            return ConfigurationManager.instance;
        }
        this.config = { }; // Тут зберігаються конфігураційні дані
        ConfigurationManager.instance = this;
    }

    static getInstance()
    {
        return new ConfigurationManager();
    }

    setConfig(key, value)
    {
        this.config[key] = value;
    }

    getConfig(key)
    {
        return this.config[key];
    }
}