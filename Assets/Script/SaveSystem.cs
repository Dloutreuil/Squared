using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SaveBestTime (TimerManager timerManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/bestTime.square";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(timerManager);

        formatter.Serialize(stream, data);
        stream.Close();
    }
    
    public static PlayerData LoadBestTime()
    {
        string path = Application.persistentDataPath + "/bestTime.square";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Saved file not found in " + path);
            return null;
        }
    }

}
