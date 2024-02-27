﻿
namespace DiscordStatusScheduler;

internal class DefaultModes
{
    public static string ExitMode = "Exit";

    private List<Mode> _defaultModes = new List<Mode>()
    {
        new Mode()
        {
            Name = "Default",
            StatusChangeFrequency = 1,
            StatusSet = new List<string>{ "Hello c:", "I am using DiscordStatusScheduler!"}
        },
        new Mode()
        {
            Name = "Exit"
        }
    };

    public void AddDefaultModes(AppOptions appOptions)
    {
        foreach (var mode in _defaultModes)
        {
            appOptions.Modes.Add(mode);
        }
    }
}
