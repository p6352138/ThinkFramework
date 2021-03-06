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
  public partial class KingsMoBaiResponse : TBase
  {
    private int _user_id;
    private int _icon;
    private string _user_name;
    private int _mobai_times;
    private int _secend_user_id;
    private int _secend_icon;
    private string _secend_user_name;
    private string _award_str;
    private bool _isCan;

    public int User_id
    {
      get
      {
        return _user_id;
      }
      set
      {
        __isset.user_id = true;
        this._user_id = value;
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

    public string User_name
    {
      get
      {
        return _user_name;
      }
      set
      {
        __isset.user_name = true;
        this._user_name = value;
      }
    }

    public int Mobai_times
    {
      get
      {
        return _mobai_times;
      }
      set
      {
        __isset.mobai_times = true;
        this._mobai_times = value;
      }
    }

    public int Secend_user_id
    {
      get
      {
        return _secend_user_id;
      }
      set
      {
        __isset.secend_user_id = true;
        this._secend_user_id = value;
      }
    }

    public int Secend_icon
    {
      get
      {
        return _secend_icon;
      }
      set
      {
        __isset.secend_icon = true;
        this._secend_icon = value;
      }
    }

    public string Secend_user_name
    {
      get
      {
        return _secend_user_name;
      }
      set
      {
        __isset.secend_user_name = true;
        this._secend_user_name = value;
      }
    }

    public string Award_str
    {
      get
      {
        return _award_str;
      }
      set
      {
        __isset.award_str = true;
        this._award_str = value;
      }
    }

    public bool IsCan
    {
      get
      {
        return _isCan;
      }
      set
      {
        __isset.isCan = true;
        this._isCan = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool user_id;
      public bool icon;
      public bool user_name;
      public bool mobai_times;
      public bool secend_user_id;
      public bool secend_icon;
      public bool secend_user_name;
      public bool award_str;
      public bool isCan;
    }

    public KingsMoBaiResponse() {
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
              User_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              User_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Mobai_times = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Secend_user_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Secend_icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              Secend_user_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.String) {
              Award_str = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Bool) {
              IsCan = iprot.ReadBool();
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
      TStruct struc = new TStruct("KingsMoBaiResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (User_name != null && __isset.user_name) {
        field.Name = "user_name";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(User_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.mobai_times) {
        field.Name = "mobai_times";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Mobai_times);
        oprot.WriteFieldEnd();
      }
      if (__isset.secend_user_id) {
        field.Name = "secend_user_id";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Secend_user_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.secend_icon) {
        field.Name = "secend_icon";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Secend_icon);
        oprot.WriteFieldEnd();
      }
      if (Secend_user_name != null && __isset.secend_user_name) {
        field.Name = "secend_user_name";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Secend_user_name);
        oprot.WriteFieldEnd();
      }
      if (Award_str != null && __isset.award_str) {
        field.Name = "award_str";
        field.Type = TType.String;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Award_str);
        oprot.WriteFieldEnd();
      }
      if (__isset.isCan) {
        field.Name = "isCan";
        field.Type = TType.Bool;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsCan);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("KingsMoBaiResponse(");
      sb.Append("User_id: ");
      sb.Append(User_id);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",User_name: ");
      sb.Append(User_name);
      sb.Append(",Mobai_times: ");
      sb.Append(Mobai_times);
      sb.Append(",Secend_user_id: ");
      sb.Append(Secend_user_id);
      sb.Append(",Secend_icon: ");
      sb.Append(Secend_icon);
      sb.Append(",Secend_user_name: ");
      sb.Append(Secend_user_name);
      sb.Append(",Award_str: ");
      sb.Append(Award_str);
      sb.Append(",IsCan: ");
      sb.Append(IsCan);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
