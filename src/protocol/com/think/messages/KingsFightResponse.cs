/**
 * Autogenerated by Thrift Compiler (0.8.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace com.think.messages
{

  [Serializable]
  public partial class KingsFightResponse : TBase
  {
    private byte _resType;
    private string _title;
    private string _content;
    private byte _state;
    private List<string> _betList;
    private List<string> _bodyValueList;
    private List<KingsFightLogResponse> _kingsFightLogList;
    private List<KingsResponse> _kingsList;
    private List<KingsFightTableResponse> _kingsFightList;
    private int _fight_times;
    private byte _fight_propress;
    private KingsMoBaiResponse _kingsMoBaiResponse;
    private byte _kings_fight_type;

    public byte ResType
    {
      get
      {
        return _resType;
      }
      set
      {
        __isset.resType = true;
        this._resType = value;
      }
    }

    public string Title
    {
      get
      {
        return _title;
      }
      set
      {
        __isset.title = true;
        this._title = value;
      }
    }

    public string Content
    {
      get
      {
        return _content;
      }
      set
      {
        __isset.content = true;
        this._content = value;
      }
    }

    public byte State
    {
      get
      {
        return _state;
      }
      set
      {
        __isset.state = true;
        this._state = value;
      }
    }

    public List<string> BetList
    {
      get
      {
        return _betList;
      }
      set
      {
        __isset.betList = true;
        this._betList = value;
      }
    }

    public List<string> BodyValueList
    {
      get
      {
        return _bodyValueList;
      }
      set
      {
        __isset.bodyValueList = true;
        this._bodyValueList = value;
      }
    }

    public List<KingsFightLogResponse> KingsFightLogList
    {
      get
      {
        return _kingsFightLogList;
      }
      set
      {
        __isset.kingsFightLogList = true;
        this._kingsFightLogList = value;
      }
    }

    public List<KingsResponse> KingsList
    {
      get
      {
        return _kingsList;
      }
      set
      {
        __isset.kingsList = true;
        this._kingsList = value;
      }
    }

    public List<KingsFightTableResponse> KingsFightList
    {
      get
      {
        return _kingsFightList;
      }
      set
      {
        __isset.kingsFightList = true;
        this._kingsFightList = value;
      }
    }

    public int Fight_times
    {
      get
      {
        return _fight_times;
      }
      set
      {
        __isset.fight_times = true;
        this._fight_times = value;
      }
    }

    public byte Fight_propress
    {
      get
      {
        return _fight_propress;
      }
      set
      {
        __isset.fight_propress = true;
        this._fight_propress = value;
      }
    }

    public KingsMoBaiResponse KingsMoBaiResponse
    {
      get
      {
        return _kingsMoBaiResponse;
      }
      set
      {
        __isset.kingsMoBaiResponse = true;
        this._kingsMoBaiResponse = value;
      }
    }

    public byte Kings_fight_type
    {
      get
      {
        return _kings_fight_type;
      }
      set
      {
        __isset.kings_fight_type = true;
        this._kings_fight_type = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool resType;
      public bool title;
      public bool content;
      public bool state;
      public bool betList;
      public bool bodyValueList;
      public bool kingsFightLogList;
      public bool kingsList;
      public bool kingsFightList;
      public bool fight_times;
      public bool fight_propress;
      public bool kingsMoBaiResponse;
      public bool kings_fight_type;
    }

    public KingsFightResponse() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Byte) {
              ResType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Title = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Content = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Byte) {
              State = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                BetList = new List<string>();
                TList _list604 = iprot.ReadListBegin();
                for( int _i605 = 0; _i605 < _list604.Count; ++_i605)
                {
                  string _elem606 = null;
                  _elem606 = iprot.ReadString();
                  BetList.Add(_elem606);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                BodyValueList = new List<string>();
                TList _list607 = iprot.ReadListBegin();
                for( int _i608 = 0; _i608 < _list607.Count; ++_i608)
                {
                  string _elem609 = null;
                  _elem609 = iprot.ReadString();
                  BodyValueList.Add(_elem609);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.List) {
              {
                KingsFightLogList = new List<KingsFightLogResponse>();
                TList _list610 = iprot.ReadListBegin();
                for( int _i611 = 0; _i611 < _list610.Count; ++_i611)
                {
                  KingsFightLogResponse _elem612 = new KingsFightLogResponse();
                  _elem612 = new KingsFightLogResponse();
                  _elem612.Read(iprot);
                  KingsFightLogList.Add(_elem612);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.List) {
              {
                KingsList = new List<KingsResponse>();
                TList _list613 = iprot.ReadListBegin();
                for( int _i614 = 0; _i614 < _list613.Count; ++_i614)
                {
                  KingsResponse _elem615 = new KingsResponse();
                  _elem615 = new KingsResponse();
                  _elem615.Read(iprot);
                  KingsList.Add(_elem615);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.List) {
              {
                KingsFightList = new List<KingsFightTableResponse>();
                TList _list616 = iprot.ReadListBegin();
                for( int _i617 = 0; _i617 < _list616.Count; ++_i617)
                {
                  KingsFightTableResponse _elem618 = new KingsFightTableResponse();
                  _elem618 = new KingsFightTableResponse();
                  _elem618.Read(iprot);
                  KingsFightList.Add(_elem618);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              Fight_times = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Byte) {
              Fight_propress = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Struct) {
              KingsMoBaiResponse = new KingsMoBaiResponse();
              KingsMoBaiResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.Byte) {
              Kings_fight_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("KingsFightResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.resType) {
        field.Name = "resType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(ResType);
        oprot.WriteFieldEnd();
      }
      if (Title != null && __isset.title) {
        field.Name = "title";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Title);
        oprot.WriteFieldEnd();
      }
      if (Content != null && __isset.content) {
        field.Name = "content";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Content);
        oprot.WriteFieldEnd();
      }
      if (__isset.state) {
        field.Name = "state";
        field.Type = TType.Byte;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(State);
        oprot.WriteFieldEnd();
      }
      if (BetList != null && __isset.betList) {
        field.Name = "betList";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, BetList.Count));
          foreach (string _iter619 in BetList)
          {
            oprot.WriteString(_iter619);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (BodyValueList != null && __isset.bodyValueList) {
        field.Name = "bodyValueList";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, BodyValueList.Count));
          foreach (string _iter620 in BodyValueList)
          {
            oprot.WriteString(_iter620);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (KingsFightLogList != null && __isset.kingsFightLogList) {
        field.Name = "kingsFightLogList";
        field.Type = TType.List;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, KingsFightLogList.Count));
          foreach (KingsFightLogResponse _iter621 in KingsFightLogList)
          {
            _iter621.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (KingsList != null && __isset.kingsList) {
        field.Name = "kingsList";
        field.Type = TType.List;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, KingsList.Count));
          foreach (KingsResponse _iter622 in KingsList)
          {
            _iter622.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (KingsFightList != null && __isset.kingsFightList) {
        field.Name = "kingsFightList";
        field.Type = TType.List;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, KingsFightList.Count));
          foreach (KingsFightTableResponse _iter623 in KingsFightList)
          {
            _iter623.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.fight_times) {
        field.Name = "fight_times";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fight_times);
        oprot.WriteFieldEnd();
      }
      if (__isset.fight_propress) {
        field.Name = "fight_propress";
        field.Type = TType.Byte;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Fight_propress);
        oprot.WriteFieldEnd();
      }
      if (KingsMoBaiResponse != null && __isset.kingsMoBaiResponse) {
        field.Name = "kingsMoBaiResponse";
        field.Type = TType.Struct;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        KingsMoBaiResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.kings_fight_type) {
        field.Name = "kings_fight_type";
        field.Type = TType.Byte;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Kings_fight_type);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("KingsFightResponse(");
      sb.Append("ResType: ");
      sb.Append(ResType);
      sb.Append(",Title: ");
      sb.Append(Title);
      sb.Append(",Content: ");
      sb.Append(Content);
      sb.Append(",State: ");
      sb.Append(State);
      sb.Append(",BetList: ");
      sb.Append(BetList);
      sb.Append(",BodyValueList: ");
      sb.Append(BodyValueList);
      sb.Append(",KingsFightLogList: ");
      sb.Append(KingsFightLogList);
      sb.Append(",KingsList: ");
      sb.Append(KingsList);
      sb.Append(",KingsFightList: ");
      sb.Append(KingsFightList);
      sb.Append(",Fight_times: ");
      sb.Append(Fight_times);
      sb.Append(",Fight_propress: ");
      sb.Append(Fight_propress);
      sb.Append(",KingsMoBaiResponse: ");
      sb.Append(KingsMoBaiResponse== null ? "<null>" : KingsMoBaiResponse.ToString());
      sb.Append(",Kings_fight_type: ");
      sb.Append(Kings_fight_type);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
