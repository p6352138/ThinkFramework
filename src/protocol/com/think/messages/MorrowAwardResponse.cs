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
  public partial class MorrowAwardResponse : TBase
  {
    private int _award_id;
    private ResourceResponse _resource;
    private bool _isChecked;

    public int Award_id
    {
      get
      {
        return _award_id;
      }
      set
      {
        __isset.award_id = true;
        this._award_id = value;
      }
    }

    public ResourceResponse Resource
    {
      get
      {
        return _resource;
      }
      set
      {
        __isset.resource = true;
        this._resource = value;
      }
    }

    public bool IsChecked
    {
      get
      {
        return _isChecked;
      }
      set
      {
        __isset.isChecked = true;
        this._isChecked = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool award_id;
      public bool resource;
      public bool isChecked;
    }

    public MorrowAwardResponse() {
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
              Award_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              Resource = new ResourceResponse();
              Resource.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              IsChecked = iprot.ReadBool();
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
      TStruct struc = new TStruct("MorrowAwardResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.award_id) {
        field.Name = "award_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Award_id);
        oprot.WriteFieldEnd();
      }
      if (Resource != null && __isset.resource) {
        field.Name = "resource";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Resource.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.isChecked) {
        field.Name = "isChecked";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsChecked);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("MorrowAwardResponse(");
      sb.Append("Award_id: ");
      sb.Append(Award_id);
      sb.Append(",Resource: ");
      sb.Append(Resource== null ? "<null>" : Resource.ToString());
      sb.Append(",IsChecked: ");
      sb.Append(IsChecked);
      sb.Append(")");
      return sb.ToString();
    }

  }

}