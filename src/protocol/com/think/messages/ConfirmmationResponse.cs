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
  public partial class ConfirmmationResponse : TBase
  {
    private byte _requestType;
    private byte _type;
    private string _content;
    private bool _ischecked;
    private int _uiID;

    public byte RequestType
    {
      get
      {
        return _requestType;
      }
      set
      {
        __isset.requestType = true;
        this._requestType = value;
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

    public bool Ischecked
    {
      get
      {
        return _ischecked;
      }
      set
      {
        __isset.ischecked = true;
        this._ischecked = value;
      }
    }

    public int UiID
    {
      get
      {
        return _uiID;
      }
      set
      {
        __isset.uiID = true;
        this._uiID = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool requestType;
      public bool type;
      public bool content;
      public bool ischecked;
      public bool uiID;
    }

    public ConfirmmationResponse() {
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
              RequestType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              Type = iprot.ReadByte();
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
            if (field.Type == TType.Bool) {
              Ischecked = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              UiID = iprot.ReadI32();
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
      TStruct struc = new TStruct("ConfirmmationResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.requestType) {
        field.Name = "requestType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(RequestType);
        oprot.WriteFieldEnd();
      }
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
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
      if (__isset.ischecked) {
        field.Name = "ischecked";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Ischecked);
        oprot.WriteFieldEnd();
      }
      if (__isset.uiID) {
        field.Name = "uiID";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(UiID);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ConfirmmationResponse(");
      sb.Append("RequestType: ");
      sb.Append(RequestType);
      sb.Append(",Type: ");
      sb.Append(Type);
      sb.Append(",Content: ");
      sb.Append(Content);
      sb.Append(",Ischecked: ");
      sb.Append(Ischecked);
      sb.Append(",UiID: ");
      sb.Append(UiID);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
