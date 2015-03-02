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
  public partial class ActivityStartResponse : TBase
  {
    private byte _activityId;
    private string _activityName;

    public byte ActivityId
    {
      get
      {
        return _activityId;
      }
      set
      {
        __isset.activityId = true;
        this._activityId = value;
      }
    }

    public string ActivityName
    {
      get
      {
        return _activityName;
      }
      set
      {
        __isset.activityName = true;
        this._activityName = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool activityId;
      public bool activityName;
    }

    public ActivityStartResponse() {
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
              ActivityId = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              ActivityName = iprot.ReadString();
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
      TStruct struc = new TStruct("ActivityStartResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.activityId) {
        field.Name = "activityId";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(ActivityId);
        oprot.WriteFieldEnd();
      }
      if (ActivityName != null && __isset.activityName) {
        field.Name = "activityName";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ActivityName);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ActivityStartResponse(");
      sb.Append("ActivityId: ");
      sb.Append(ActivityId);
      sb.Append(",ActivityName: ");
      sb.Append(ActivityName);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
