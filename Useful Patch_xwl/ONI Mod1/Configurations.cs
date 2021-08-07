// Decompiled with JetBrains decompiler
// Type: Useful_Patch.Configurations
// Assembly: Useful Patch, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6222DEC0-B53E-4E8A-9B19-F74DA2F20D5B
// Assembly location: C:\Users\xu198\Documents\0Useful Patch\archived_versions\vanilla_455509\Useful Patch.dll

using System;

namespace Useful_Patch
{
  [Serializable]
  public class Configurations
  {
    private static Configurations _instance = (Configurations) null;
    public Definitions solidtransferarmpickupRange = new Definitions(50);
    public Definitions IsPhysicallyAccessible = new Definitions(1);
    public Definitions DropMoreSeeds = new Definitions(1);
    public Definitions LandingPodRefreshTime = new Definitions(1);

    public static Configurations GetConfig()
    {
      if (Configurations._instance == null)
        Configurations._instance = ConfigUtils.LoadConfig<Configurations>(nameof (Configurations), new Configurations());
      return Configurations._instance;
    }
  }
}
