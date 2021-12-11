using System.Collections.Generic;

public class SystemData
{
    public float MusicVolume { get; set; }
    public float GameplayVolume { get; set; }
    public float MasterVolume { get; set; }
    public int GameResolutionIndex { get; set; }
    public bool IsFullscreen { get; set; }
    public List<string> ResolutionOptions = new List<string>();
    public int QualityIndex { get; set; }
    public float AutoSaveFrequency { get; set; }

    public SystemData()
    {
        MusicVolume = 0.0f;
        GameplayVolume = 0.0f;
        MasterVolume = 0.0f;
        GameResolutionIndex = 1;
        IsFullscreen = false;
        AutoSaveFrequency = 30f;
        if(ResolutionOptions.Count <= 0)
        {
            ResolutionOptions.Add("320x200");
        }
        QualityIndex = 0;
    }
}
