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
  public partial class ActiveAwardResponse : TBase
  {
    private int _id;
    private byte _award_level;
    private int _required_active;
    private bool _had_got;
    private List<ResourceResponse> _listAward;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public byte Award_level
    {
      get
      {
        return _award_level;
      }
      set
      {
        __isset.award_level = true;
        this._award_level = value;
      }
    }

    public int Required_active
    {
      get
      {
        return _required_active;
      }
      set
      {
        __isset.required_active = true;
        this._required_active = value;
      }
    }

    public bool Had_got
    {
      get
      {
        return _had_got;
      }
      set
      {
        __isset.had_got = true;
        this._had_got = value;
      }
    }

    public List<ResourceResponse> ListAward
    {
      get
      {
        return _listAward;
      }
      set
      {
        __isset.listAward = true;
        this._listAward = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool id;
      public bool award_level;
      public bool required_active;
      public bool had_got;
      public bool listAward;
    }

    public ActiveAwardResponse() {
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
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              Award_level = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Required_active = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              Had_got = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                ListAward = new List<ResourceResponse>();
                TList _list741 = iprot.ReadListBegin();
                for( int _i742 = 0; _i742 < _list741.Count; ++_i742)
                {
                  ResourceResponse _elem743 = new ResourceResponse();
                  _elem743 = new ResourceResponse();
                  _elem743.Read(iprot);
                  ListAward.Add(_elem743);
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
      TStruct struc = new TStruct("ActiveAwardResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (__isset.award_level) {
        field.Name = "award_level";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Award_level);
        oprot.WriteFieldEnd();
      }
      if (__isset.required_active) {
        field.Name = "required_active";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Required_active);
        oprot.WriteFieldEnd();
      }
      if (__isset.had_got) {
        field.Name = "had_got";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Had_got);
        oprot.WriteFieldEnd();
      }
      if (ListAward != null && __isset.listAward) {
        field.Name = "listAward";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListAward.Count));
          foreach (ResourceResponse _iter744 in ListAward)
          {
            _iter744.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ActiveAwardResponse(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Award_level: ");
      sb.Append(Award_level);
      sb.Append(",Required_active: ");
      sb.Append(Required_active);
      sb.Append(",Had_got: ");
      sb.Append(Had_got);
      sb.Append(",ListAward: ");
      sb.Append(ListAward);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
