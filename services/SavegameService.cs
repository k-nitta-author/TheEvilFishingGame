using Godot;

namespace Service
{
    public partial class SavegameService: Resource
    {

        // the file path of the save file
        [Export(PropertyHint.FilePath)]
        string SaveFilePath {get; set;}


        // method to check if given file exists
        public void CheckIfSaveFileExists()
        {
            FileAccess.FileExists(SaveFilePath);
        }

        // method to save data to the save file
        public void SaveDataToFile(string Data)
        {
            using var file = FileAccess.Open(SaveFilePath, FileAccess.ModeFlags.Write);

            file.StoreString(Data);

            file.Close();
        }

        // method to load data from save file
        public string LoadDataFromFile()
        {

            using var file = FileAccess.Open(SaveFilePath, FileAccess.ModeFlags.Read);

            string fileContent = file.GetAsText();

            return fileContent;
        }
    }    
}