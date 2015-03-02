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
  public partial class KingsFightTableResponse : TBase
  {
    private int _against_id;
    private int _user_id;
    private string _user_name;
    private int _target_user_id;
    private string _target_name;
    private byte _state;
    private int _fight_id;
    private bool _isFinish;
    private byte _isBet;
    private int _user_icon;
    private int _target_user_icon;

    public int Against_id
    {
      get
      {
        return _against_id;
      }
      set
      {
        __isset.against_id = true;
        this._against_id = value;
      }
    }

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

    public int Target_user_id
    {
      get
      {
        return _target_user_id;
      }
      set
      {
        __isset.target_user_id = true;
        this._target_user_id = value;
      }
    }

    public string Target_name
    {
      get
      {
        return _target_name;
      }
      set
      {
        __isset.target_name = true;
        this._target_name = value;
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

    public int Fight_id
    {
      get
      {
        return _fight_id;
      }
      set
      {
        __isset.fight_id = true;
        this._fight_id = value;
      }
    }

    public bool IsFinish
    {
      get
      {
        return _isFinish;
      }
      set
      {
        __isset.isFinish = true;
        this._isFinish = value;
      }
    }

    public byte IsBet
    {
      get
      {
        return _isBet;
      }
      set
      {
        __isset.isBet = true;
        this._isBet = value;
      }
    }

    public int User_icon
    {
      get
      {
        return _user_icon;
      }
      set
      {
        __isset.user_icon = true;
        this._user_icon = value;
      }
    }

    public int Target_user_icon
    {
      get
      {
        return _target_user_icon;
      }
      set
      {
        __isset.target_user_icon = true;
        this._target_user_icon = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool against_id;
      public bool user_id;
      public bool user_name;
      public bool target_user_id;
      public bool target_name;
      public bool state;
      public bool fight_id;
      public bool isFinish;
      public bool isBet;
      public bool user_icon;
      public bool target_user_icon;
    }

    public KingsFightTableResponse() {
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
              Against_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              User_id = iprot.ReadI32();
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
              Target_user_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Target_name = iprot.ReadString();
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
          case 7:
            if (field.Type == TType.I32) {
              Fight_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Bool) {
              IsFinish = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Byte) {
              IsBet = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              User_icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              Target_user_icon = iprot.ReadI32();
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
      TStruct struc = new TStruct("KingsFightTableResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.against_id) {
        field.Name = "against_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Against_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
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
      if (__isset.target_user_id) {
        field.Name = "target_user_id";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Target_user_id);
        oprot.WriteFieldEnd();
      }
      if (Target_name != null && __isset.target_name) {
        field.Name = "target_name";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Target_name);
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
      if (__isset.fight_id) {
        field.Name = "fight_id";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fight_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.isFinish) {
        field.Name = "isFinish";
        field.Type = TType.Bool;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsFinish);
        oprot.WriteFieldEnd();
      }
      if (__isset.isBet) {
        field.Name = "isBet";
        field.Type = TType.Byte;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(IsBet);
        oprot.WriteFieldEnd();
      }
      if (__isset.user_icon) {
        field.Name = "user_icon";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.target_user_icon) {
        field.Name = "target_user_icon";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Target_user_icon);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("KingsFightTableResponse(");
      sb.Append("Against_id: ");
      sb.Append(Against_id);
      sb.Append(",User_id: ");
      sb.Append(User_id);
      sb.Append(",User_name: ");
      sb.Append(User_name);
      sb.Append(",Target_user_id: ");
      sb.Append(Target_user_id);
      sb.Append(",Target_name: ");
      sb.Append(Target_name);
      sb.Append(",State: ");
      sb.Append(State);
      sb.Append(",Fight_id: ");
      sb.Append(Fight_id);
      sb.Append(",IsFinish: ");
      sb.Append(IsFinish);
      sb.Append(",IsBet: ");
      sb.Append(IsBet);
      sb.Append(",User_icon: ");
      sb.Append(User_icon);
      sb.Append(",Target_user_icon: ");
      sb.Append(Target_user_icon);
      sb.Append(")");
      return sb.ToString();
    }

  }

}