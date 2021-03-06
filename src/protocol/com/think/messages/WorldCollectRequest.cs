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
  public partial class WorldCollectRequest : TBase
  {
    private byte _collectType;
    private int _mapID;

    public byte CollectType
    {
      get
      {
        return _collectType;
      }
      set
      {
        __isset.collectType = true;
        this._collectType = value;
      }
    }

    public int MapID
    {
      get
      {
        return _mapID;
      }
      set
      {
        __isset.mapID = true;
        this._mapID = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool collectType;
      public bool mapID;
    }

    public WorldCollectRequest() {
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
              CollectType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              MapID = iprot.ReadI32();
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
      TStruct struc = new TStruct("WorldCollectRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.collectType) {
        field.Name = "collectType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(CollectType);
        oprot.WriteFieldEnd();
      }
      if (__isset.mapID) {
        field.Name = "mapID";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(MapID);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("WorldCollectRequest(");
      sb.Append("CollectType: ");
      sb.Append(CollectType);
      sb.Append(",MapID: ");
      sb.Append(MapID);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
