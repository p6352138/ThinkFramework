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
  public partial class LoginResponse : TBase
  {
    private int _serverId;
    private int _sessionId;

    public int ServerId
    {
      get
      {
        return _serverId;
      }
      set
      {
        __isset.serverId = true;
        this._serverId = value;
      }
    }

    public int SessionId
    {
      get
      {
        return _sessionId;
      }
      set
      {
        __isset.sessionId = true;
        this._sessionId = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool serverId;
      public bool sessionId;
    }

    public LoginResponse() {
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
              ServerId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              SessionId = iprot.ReadI32();
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
      TStruct struc = new TStruct("LoginResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.serverId) {
        field.Name = "serverId";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ServerId);
        oprot.WriteFieldEnd();
      }
      if (__isset.sessionId) {
        field.Name = "sessionId";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SessionId);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LoginResponse(");
      sb.Append("ServerId: ");
      sb.Append(ServerId);
      sb.Append(",SessionId: ");
      sb.Append(SessionId);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
