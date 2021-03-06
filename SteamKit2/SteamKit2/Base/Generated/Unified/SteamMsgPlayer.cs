//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Option: light framework (CF/Silverlight) enabled
    
// Generated from: steammessages_player.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetGameBadgeLevels_Request")]
  public partial class CPlayer_GetGameBadgeLevels_Request : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetGameBadgeLevels_Request() {}
    

    private uint? _appid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint appid
    {
      get { return _appid?? default(uint); }
      set { _appid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool appidSpecified
    {
      get { return _appid != null; }
      set { if (value == (_appid== null)) _appid = value ? this.appid : (uint?)null; }
    }
    private bool ShouldSerializeappid() { return appidSpecified; }
    private void Resetappid() { appidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetGameBadgeLevels_Response")]
  public partial class CPlayer_GetGameBadgeLevels_Response : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetGameBadgeLevels_Response() {}
    

    private uint? _player_level;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"player_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint player_level
    {
      get { return _player_level?? default(uint); }
      set { _player_level = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool player_levelSpecified
    {
      get { return _player_level != null; }
      set { if (value == (_player_level== null)) _player_level = value ? this.player_level : (uint?)null; }
    }
    private bool ShouldSerializeplayer_level() { return player_levelSpecified; }
    private void Resetplayer_level() { player_levelSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<CPlayer_GetGameBadgeLevels_Response.Badge> _badges = new global::System.Collections.Generic.List<CPlayer_GetGameBadgeLevels_Response.Badge>();
    [global::ProtoBuf.ProtoMember(2, Name=@"badges", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPlayer_GetGameBadgeLevels_Response.Badge> badges
    {
      get { return _badges; }
    }
  
  [global::ProtoBuf.ProtoContract(Name=@"Badge")]
  public partial class Badge : global::ProtoBuf.IExtensible
  {
    public Badge() {}
    

    private int? _level;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level?? default(int); }
      set { _level = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool levelSpecified
    {
      get { return _level != null; }
      set { if (value == (_level== null)) _level = value ? this.level : (int?)null; }
    }
    private bool ShouldSerializelevel() { return levelSpecified; }
    private void Resetlevel() { levelSpecified = false; }
    

    private int? _series;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"series", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int series
    {
      get { return _series?? default(int); }
      set { _series = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool seriesSpecified
    {
      get { return _series != null; }
      set { if (value == (_series== null)) _series = value ? this.series : (int?)null; }
    }
    private bool ShouldSerializeseries() { return seriesSpecified; }
    private void Resetseries() { seriesSpecified = false; }
    

    private uint? _border_color;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"border_color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint border_color
    {
      get { return _border_color?? default(uint); }
      set { _border_color = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool border_colorSpecified
    {
      get { return _border_color != null; }
      set { if (value == (_border_color== null)) _border_color = value ? this.border_color : (uint?)null; }
    }
    private bool ShouldSerializeborder_color() { return border_colorSpecified; }
    private void Resetborder_color() { border_colorSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetLastPlayedTimes_Request")]
  public partial class CPlayer_GetLastPlayedTimes_Request : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetLastPlayedTimes_Request() {}
    

    private uint? _min_last_played;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"min_last_played", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint min_last_played
    {
      get { return _min_last_played?? default(uint); }
      set { _min_last_played = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool min_last_playedSpecified
    {
      get { return _min_last_played != null; }
      set { if (value == (_min_last_played== null)) _min_last_played = value ? this.min_last_played : (uint?)null; }
    }
    private bool ShouldSerializemin_last_played() { return min_last_playedSpecified; }
    private void Resetmin_last_played() { min_last_playedSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPlayer_GetLastPlayedTimes_Response")]
  public partial class CPlayer_GetLastPlayedTimes_Response : global::ProtoBuf.IExtensible
  {
    public CPlayer_GetLastPlayedTimes_Response() {}
    
    private readonly global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> _games = new global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game>();
    [global::ProtoBuf.ProtoMember(1, Name=@"games", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> games
    {
      get { return _games; }
    }
  
  [global::ProtoBuf.ProtoContract(Name=@"Game")]
  public partial class Game : global::ProtoBuf.IExtensible
  {
    public Game() {}
    

    private int? _appid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int appid
    {
      get { return _appid?? default(int); }
      set { _appid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool appidSpecified
    {
      get { return _appid != null; }
      set { if (value == (_appid== null)) _appid = value ? this.appid : (int?)null; }
    }
    private bool ShouldSerializeappid() { return appidSpecified; }
    private void Resetappid() { appidSpecified = false; }
    

    private uint? _last_playtime;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"last_playtime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint last_playtime
    {
      get { return _last_playtime?? default(uint); }
      set { _last_playtime = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool last_playtimeSpecified
    {
      get { return _last_playtime != null; }
      set { if (value == (_last_playtime== null)) _last_playtime = value ? this.last_playtime : (uint?)null; }
    }
    private bool ShouldSerializelast_playtime() { return last_playtimeSpecified; }
    private void Resetlast_playtime() { last_playtimeSpecified = false; }
    

    private int? _playtime_2weeks;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"playtime_2weeks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playtime_2weeks
    {
      get { return _playtime_2weeks?? default(int); }
      set { _playtime_2weeks = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool playtime_2weeksSpecified
    {
      get { return _playtime_2weeks != null; }
      set { if (value == (_playtime_2weeks== null)) _playtime_2weeks = value ? this.playtime_2weeks : (int?)null; }
    }
    private bool ShouldSerializeplaytime_2weeks() { return playtime_2weeksSpecified; }
    private void Resetplaytime_2weeks() { playtime_2weeksSpecified = false; }
    

    private int? _playtime_forever;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"playtime_forever", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int playtime_forever
    {
      get { return _playtime_forever?? default(int); }
      set { _playtime_forever = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    
    public bool playtime_foreverSpecified
    {
      get { return _playtime_forever != null; }
      set { if (value == (_playtime_forever== null)) _playtime_forever = value ? this.playtime_forever : (int?)null; }
    }
    private bool ShouldSerializeplaytime_forever() { return playtime_foreverSpecified; }
    private void Resetplaytime_forever() { playtime_foreverSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPlayer_AcceptSSA_Request")]
  public partial class CPlayer_AcceptSSA_Request : global::ProtoBuf.IExtensible
  {
    public CPlayer_AcceptSSA_Request() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPlayer_AcceptSSA_Response")]
  public partial class CPlayer_AcceptSSA_Response : global::ProtoBuf.IExtensible
  {
    public CPlayer_AcceptSSA_Response() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::ProtoBuf.ProtoContract(Name=@"CPlayer_LastPlayedTimes_Notification")]
  public partial class CPlayer_LastPlayedTimes_Notification : global::ProtoBuf.IExtensible
  {
    public CPlayer_LastPlayedTimes_Notification() {}
    
    private readonly global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> _games = new global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game>();
    [global::ProtoBuf.ProtoMember(1, Name=@"games", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CPlayer_GetLastPlayedTimes_Response.Game> games
    {
      get { return _games; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IPlayer
    {
      CPlayer_GetGameBadgeLevels_Response GetGameBadgeLevels(CPlayer_GetGameBadgeLevels_Request request);
    CPlayer_GetLastPlayedTimes_Response ClientGetLastPlayedTimes(CPlayer_GetLastPlayedTimes_Request request);
    CPlayer_AcceptSSA_Response AcceptSSA(CPlayer_AcceptSSA_Request request);
    
    }
    
    
    public interface IPlayerClient
    {
      NoResponse NotifyLastPlayedTimes(CPlayer_LastPlayedTimes_Notification request);
    
    }
    
    
}
#pragma warning restore 1591
