using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

public class SerializationManager
{
    public static bool Save(string saveName, object SaveData){
        XmlSerializer serializer = new XmlSerializer(typeof(object));

        if (!Directory.Exists(Application.persistentDataPath + "/saves")){
            Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        }

        string path = Application.persistentDataPath + "/saves/" + saveName + ".save";

        FileStream file = File.Create(path);

        //formatter.Serialize(file, SaveData);

        file.Close();
        
        return true;
    }

    public static object Load(string path){
        if (!File.Exists(path)){
            return null;
        }


        FileStream file = File.Open(path, FileMode.Open);

        try {
            //object save = formatter.Deserialize(file);
            file.Close();
            return null;//save;
        } catch {
            Debug.LogErrorFormat("Failed to load file at {0}", path);
            file.Close();
            return null;
        }
    }
}
