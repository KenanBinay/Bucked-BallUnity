using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.PlayerLoop;

public class LoadManager : MonoBehaviour
{
    public static LoadManager instance;
    public Data data;
    string dataFile = "626f6c756d6c6572.dat";

    void Awake()
    {
    
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }   
        else if (instance != this)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {     
        Load();
        if (data.bölüm2 == 1)
        {
            Bucked1.x = LoadManager.instance.data.bölüm2;    
        }
        if (data.bölüm3 == 1)
        {
            Bucked2and3.x1 = LoadManager.instance.data.bölüm3;
        }
        if (data.bölüm4 == 1)
        {
            Bucked3to4.x4 = LoadManager.instance.data.bölüm4;
        }
        if (data.bölüm5 == 1)
        {
            Bucket4To5.x5 = LoadManager.instance.data.bölüm5;
        }
        if (data.bölüm6 == 1)
        {
            Bucked5To6.x6 = LoadManager.instance.data.bölüm6;
        }
        if (data.bölüm7 == 1)
        {
            Bucked6To7.x7 = LoadManager.instance.data.bölüm7;
        }
        if (data.bölüm8 == 1)
        {
            Bucked7To8.x8 = LoadManager.instance.data.bölüm8;
        }
        if (data.bölüm9 == 1)
        {
            Bucket8To9.x9 = LoadManager.instance.data.bölüm9;
        }
        if (data.bölüm10 == 1)
        {
            Bucket9To10.x10 = LoadManager.instance.data.bölüm10;
        }
        if (data.bölüm11 == 1)
        {
            Bucked10To11.x11 = LoadManager.instance.data.bölüm11;
        }
        if (data.bölüm12 == 1)
        {
            Bucked11To12.x12 = LoadManager.instance.data.bölüm12;
        }
        if (data.bölüm13 == 1)
        {
            Bucked12To13.x13 = LoadManager.instance.data.bölüm13;
        }
        if (data.bölüm14 == 1)
        {
            Bucked13To14.x14 = LoadManager.instance.data.bölüm14;
        }
        if (data.bölüm15 == 1)
        {
            Bucked14To15.x15 = LoadManager.instance.data.bölüm15;
        }
        if (data.bölüm16 == 1)
        {
            Bucked15To16.x16 = LoadManager.instance.data.bölüm16;
        }
        if (data.bölüm17 == 1)
        {
            Bucked16To17.x17 = LoadManager.instance.data.bölüm17;
        }
    }
    private void Update()
    {
        if (Bucked1.x == 1)
        {
            data.bölüm2 = 1;
            Save();
            Debug.Log("Bölüm2 Kaydedildi");
        }
        if (Bucked2and3.x1 == 1)
        {
            data.bölüm3 = 1;
            Save();
            Debug.Log("Bölüm3 Kaydedildi");
        }
        if (Bucked3to4.x4 == 1)
        {
            data.bölüm4 = 1;
            Save();
            Debug.Log("Bölüm4 Kaydedildi");
        }
        if (Bucket4To5.x5 == 1)
        {
            data.bölüm5 = 1;
            Save();
            Debug.Log("Bölüm5 Kaydedildi");
        }
        if (Bucked5To6.x6 == 1)
        {
            data.bölüm6 = 1;
            Save();
            Debug.Log("Bölüm6 Kaydedildi");
        }
        if (Bucked6To7.x7 == 1)
        {
            data.bölüm7 = 1;
            Save();
            Debug.Log("Bölüm7 Kaydedildi");
        }
        if (Bucked7To8.x8 == 1)
        {
            data.bölüm8 = 1;
            Save();
            Debug.Log("Bölüm8 Kaydedildi");
        }
        if (Bucket8To9.x9 == 1)
        {
            data.bölüm9 = 1;
            Save();
            Debug.Log("Bölüm9 Kaydedildi");
        }
        if (Bucket9To10.x10 == 1)
        {
            data.bölüm10 = 1;
            Save();
            Debug.Log("Bölüm10 Kaydedildi");
        }
        if (Bucked10To11.x11 == 1)
        {
            data.bölüm11 = 1;
            Save();
            Debug.Log("Bölüm11 Kaydedildi");
        }
        if (Bucked11To12.x12 == 1)
        {
            data.bölüm12 = 1;
            Save();
            Debug.Log("Bölüm12 Kaydedildi");
        }
        if (Bucked12To13.x13 == 1)
        {
            data.bölüm13 = 1;
            Save();
            Debug.Log("Bölüm13 Kaydedildi");
        }
        if (Bucked13To14.x14 == 1)
        {
            data.bölüm14 = 1;
            Save();
            Debug.Log("Bölüm14 Kaydedildi");
        }
        if (Bucked14To15.x15 == 1)
        {
            data.bölüm15 = 1;
            Save();
            Debug.Log("Bölüm15 Kaydedildi");
        }
        if (Bucked15To16.x16 == 1)
        {
            data.bölüm16 = 1;
            Save();
            Debug.Log("Bölüm16 Kaydedildi");
        }
        if (Bucked16To17.x17 == 1)
        {
            data.bölüm17 = 1;
            Save();
            Debug.Log("Bölüm17 Kaydedildi");
        }
    }

    public void Save()
    {
        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter yrk = new BinaryFormatter();
        FileStream file = File.Create(filePath);
        yrk.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        string filePath = Application.persistentDataPath + "/" + dataFile;
        BinaryFormatter yrk = new BinaryFormatter();
        if (File.Exists(filePath))
        {
            FileStream file = File.Open(filePath, FileMode.Open);
            Data loaded = (Data)yrk.Deserialize(file);
            data = loaded;
            file.Close();
        }
    }
}

[System.Serializable]
public class Data
{
    public float bölüm2, bölüm3, bölüm4, bölüm5, bölüm6, bölüm7, bölüm8, bölüm9, bölüm10, bölüm11, bölüm12, bölüm13, bölüm14, bölüm15, bölüm16, bölüm17;
   
    public Data()
    {
        bölüm2 = 0; 
        bölüm3 = 0; //time2=
        bölüm4 = 0; //time3=
        bölüm5 = 0; //time4=
        bölüm6 = 0; //time5=
        bölüm7 = 0; //time6=
        bölüm8 = 0; //time7= 
        bölüm9 = 0; //time8= 
        bölüm10 = 0; //time9= 
        bölüm11 = 0; //time10= 
        bölüm12 = 0;
        bölüm13 = 0;
        bölüm14 = 0;
        bölüm15 = 0;
        bölüm16 = 0;
        bölüm17 = 0;
    }

}