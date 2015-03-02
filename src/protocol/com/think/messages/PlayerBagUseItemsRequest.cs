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
  public partial class PlayerBagUseItemsRequest : TBase
  {
    private int _role_instance_id;
    private int _id;
    private short _index;

    public int Role_instance_id
    {
      get
      {
        return _role_instance_id;
      }
      set
      {
        __isset.role_instance_id = true;
        this._role_instance_id = value;
      }
    }

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

    public short Index
    {
      get
      {
        return _index;
      }
      set
      {
        __isset.index = true;
        this._index = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool role_instance_id;
      public bool id;
      public bool index;
    }

    public PlayerBagUseItemsRequest() {
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
              Role_instance_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I16) {
              Index = iprot.ReadI16();
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
      TStruct struc = new TStruct("PlayerBagUseItemsRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.role_instance_id) {
        field.Name = "role_instance_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Role_instance_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (__isset.index) {
        field.Name = "index";
        field.Type = TType.I16;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(Index);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerBagUseItemsRequest(");
      sb.Append("Role_instance_id: ");
      sb.Append(Role_instance_id);
      sb.Append(",Id: ");
      sb.Append(Id);
      sb.Append(",Index: ");
      sb.Append(Index);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
