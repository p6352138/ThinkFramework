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
  public partial class CityResponse : TBase
  {
    private int _ctiyId;
    private string _name;
    private byte _clan;
    private int _index_key;
    private int _type;
    private string _signal;

    public int CtiyId
    {
      get
      {
        return _ctiyId;
      }
      set
      {
        __isset.ctiyId = true;
        this._ctiyId = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public byte Clan
    {
      get
      {
        return _clan;
      }
      set
      {
        __isset.clan = true;
        this._clan = value;
      }
    }

    public int Index_key
    {
      get
      {
        return _index_key;
      }
      set
      {
        __isset.index_key = true;
        this._index_key = value;
      }
    }

    public int Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public string Signal
    {
      get
      {
        return _signal;
      }
      set
      {
        __isset.signal = true;
        this._signal = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool ctiyId;
      public bool name;
      public bool clan;
      public bool index_key;
      public bool type;
      public bool signal;
    }

    public CityResponse() {
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
            if (field.Type == TType.I32) {
              CtiyId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Clan = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Index_key = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Type = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              Signal = iprot.ReadString();
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
      TStruct struc = new TStruct("CityResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.ctiyId) {
        field.Name = "ctiyId";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(CtiyId);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.clan) {
        field.Name = "clan";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Clan);
        oprot.WriteFieldEnd();
      }
      if (__isset.index_key) {
        field.Name = "index_key";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Index_key);
        oprot.WriteFieldEnd();
      }
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Type);
        oprot.WriteFieldEnd();
      }
      if (Signal != null && __isset.signal) {
        field.Name = "signal";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Signal);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CityResponse(");
      sb.Append("CtiyId: ");
      sb.Append(CtiyId);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Clan: ");
      sb.Append(Clan);
      sb.Append(",Index_key: ");
      sb.Append(Index_key);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(",Signal: ");
      sb.Append(Signal);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
