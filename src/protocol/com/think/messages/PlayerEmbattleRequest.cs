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
  public partial class PlayerEmbattleRequest : TBase
  {
    private int _general_id;
    private byte _site;
    private byte _type;

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

    public byte Type
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


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool general_id;
      public bool site;
      public bool type;
    }

    public PlayerEmbattleRequest() {
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
              General_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              Site = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Type = iprot.ReadByte();
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
      TStruct struc = new TStruct("PlayerEmbattleRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.general_id) {
        field.Name = "general_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(General_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.site) {
        field.Name = "site";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Site);
        oprot.WriteFieldEnd();
      }
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerEmbattleRequest(");
      sb.Append("General_id: ");
      sb.Append(General_id);
      sb.Append(",Site: ");
      sb.Append(Site);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
