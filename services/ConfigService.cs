using System.Diagnostics.CodeAnalysis;
using Godot;

namespace Service
{
    public partial class ConfigService: Resource
    {

        [Export]
        public Vector2 ScreenResolution {get; set;}

        public bool CheckConfigFileExist()
        {
            using var configFile = new ConfigFile();

            return true;
            
        }


        // TODO: Implement
        public void SaveConfigFile()
        {
        }

        // TODO: Implement
        public void LoadConfigFile()
        {   
        }

    }
}