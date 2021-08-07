// Decompiled with JetBrains decompiler
// Type: Useful_Patch.ConfigUtils
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using Newtonsoft.Json;
using System;
using System.IO;

namespace Useful_Patch
{
  public static class ConfigUtils
  {
    public static string GetConfigDirectoryPath()
    {
      string str = System.IO.Path.DirectorySeparatorChar.ToString();
      return System.IO.Path.Combine(Util.RootFolder(), "mods" + str + "settings");
    }

    public static string GetConfigFilePath(string modName)
    {
      System.IO.Path.DirectorySeparatorChar.ToString();
      return System.IO.Path.Combine(ConfigUtils.GetConfigDirectoryPath(), modName + ".json");
    }

    public static T LoadConfig<T>(string modName, T defaultObject)
    {
      try
      {
        string configFilePath = ConfigUtils.GetConfigFilePath(modName);
        if (!File.Exists(configFilePath))
        {
          Debug.Log((object) ("Creating initial config for " + modName));
          ConfigUtils.SaveConfig(modName, (object) defaultObject);
          return defaultObject;
        }
        T obj = JsonConvert.DeserializeObject<T>(File.ReadAllText(configFilePath));
        ConfigUtils.SaveConfig(modName, (object) obj);
        return obj;
      }
      catch (Exception ex)
      {
        Debug.Log((object) ("Error loading " + modName + " config:"));
        Debug.Log((object) ex);
      }
      return defaultObject;
    }

    public static void SaveConfig(string modName, object serializeableObject)
    {
      try
      {
        Directory.CreateDirectory(ConfigUtils.GetConfigDirectoryPath());
        string contents = JsonConvert.SerializeObject(serializeableObject, Formatting.Indented);
        File.WriteAllText(ConfigUtils.GetConfigFilePath(modName), contents);
      }
      catch (Exception ex)
      {
        Debug.Log((object) ("Error saving " + modName + " config:"));
        Debug.Log((object) ex);
      }
    }
  }
}
