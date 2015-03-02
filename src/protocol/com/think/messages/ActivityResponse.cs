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
  public partial class ActivityResponse : TBase
  {
    private byte _activityId;
    private string _activityName;
    private string _dateTime;
    private int _icon;
    private string _details;
    private byte _state;

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

    public string DateTime
    {
      get
      {
        return _dateTime;
      }
      set
      {
        __isset.dateTime = true;
        this._dateTime = value;
      }
    }

    public int Icon
    {
      get
      {
        return _icon;
      }
      set
      {
        __isset.icon = true;
        this._icon = value;
      }
    }

    public string Details
    {
      get
      {
        return _details;
      }
      set
      {
        __isset.details = true;
        this._details = value;
      }
    }

    public byte State
    {
      get
      {
        return _state;
      }
      set
      {
        __isset.state = true;
        this._state = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool activityId;
      public bool activityName;
      public bool dateTime;
      public bool icon;
      public bool details;
      public bool state;
    }

    public ActivityResponse() {
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
          case 3:
            if (field.Type == TType.String) {
              DateTime = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Details = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Byte) {
              State = iprot.ReadByte();
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
      TStruct struc = new TStruct("ActivityResponse");
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
      if (DateTime != null && __isset.dateTime) {
        field.Name = "dateTime";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(DateTime);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (Details != null && __isset.details) {
        field.Name = "details";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Details);
        oprot.WriteFieldEnd();
      }
      if (__isset.state) {
        field.Name = "state";
        field.Type = TType.Byte;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(State);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ActivityResponse(");
      sb.Append("ActivityId: ");
      sb.Append(ActivityId);
      sb.Append(",ActivityName: ");
      sb.Append(ActivityName);
      sb.Append(",DateTime: ");
      sb.Append(DateTime);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",Details: ");
      sb.Append(Details);
      sb.Append(",State: ");
      sb.Append(State);
      sb.Append(")");
      return sb.ToString();
    }

  }

}