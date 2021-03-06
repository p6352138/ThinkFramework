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
  public partial class PlayerTrainResponse : TBase
  {
    private byte _site;
    private int _general_id;
    private byte _lvl;
    private int _cd_time;
    private string _multiple;
    private int _upgrade_gold;
    private List<PlayerTrainCaoDianResponse> _caoDianList;

    public byte Site
    {
      get
      {
        return _site;
      }
      set
      {
        __isset.site = true;
        this._site = value;
      }
    }

    public int General_id
    {
      get
      {
        return _general_id;
      }
      set
      {
        __isset.general_id = true;
        this._general_id = value;
      }
    }

    public byte Lvl
    {
      get
      {
        return _lvl;
      }
      set
      {
        __isset.lvl = true;
        this._lvl = value;
      }
    }

    public int Cd_time
    {
      get
      {
        return _cd_time;
      }
      set
      {
        __isset.cd_time = true;
        this._cd_time = value;
      }
    }

    public string Multiple
    {
      get
      {
        return _multiple;
      }
      set
      {
        __isset.multiple = true;
        this._multiple = value;
      }
    }

    public int Upgrade_gold
    {
      get
      {
        return _upgrade_gold;
      }
      set
      {
        __isset.upgrade_gold = true;
        this._upgrade_gold = value;
      }
    }

    public List<PlayerTrainCaoDianResponse> CaoDianList
    {
      get
      {
        return _caoDianList;
      }
      set
      {
        __isset.caoDianList = true;
        this._caoDianList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool site;
      public bool general_id;
      public bool lvl;
      public bool cd_time;
      public bool multiple;
      public bool upgrade_gold;
      public bool caoDianList;
    }

    public PlayerTrainResponse() {
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
              Site = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              General_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Lvl = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Cd_time = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Multiple = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Upgrade_gold = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.List) {
              {
                CaoDianList = new List<PlayerTrainCaoDianResponse>();
                TList _list311 = iprot.ReadListBegin();
                for( int _i312 = 0; _i312 < _list311.Count; ++_i312)
                {
                  PlayerTrainCaoDianResponse _elem313 = new PlayerTrainCaoDianResponse();
                  _elem313 = new PlayerTrainCaoDianResponse();
                  _elem313.Read(iprot);
                  CaoDianList.Add(_elem313);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("PlayerTrainResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.site) {
        field.Name = "site";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Site);
        oprot.WriteFieldEnd();
      }
      if (__isset.general_id) {
        field.Name = "general_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(General_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.lvl) {
        field.Name = "lvl";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Lvl);
        oprot.WriteFieldEnd();
      }
      if (__isset.cd_time) {
        field.Name = "cd_time";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Cd_time);
        oprot.WriteFieldEnd();
      }
      if (Multiple != null && __isset.multiple) {
        field.Name = "multiple";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Multiple);
        oprot.WriteFieldEnd();
      }
      if (__isset.upgrade_gold) {
        field.Name = "upgrade_gold";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Upgrade_gold);
        oprot.WriteFieldEnd();
      }
      if (CaoDianList != null && __isset.caoDianList) {
        field.Name = "caoDianList";
        field.Type = TType.List;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, CaoDianList.Count));
          foreach (PlayerTrainCaoDianResponse _iter314 in CaoDianList)
          {
            _iter314.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerTrainResponse(");
      sb.Append("Site: ");
      sb.Append(Site);
      sb.Append(",General_id: ");
      sb.Append(General_id);
      sb.Append(",Lvl: ");
      sb.Append(Lvl);
      sb.Append(",Cd_time: ");
      sb.Append(Cd_time);
      sb.Append(",Multiple: ");
      sb.Append(Multiple);
      sb.Append(",Upgrade_gold: ");
      sb.Append(Upgrade_gold);
      sb.Append(",CaoDianList: ");
      sb.Append(CaoDianList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
