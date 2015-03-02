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
  public partial class TopPlayerResponse : TBase
  {
    private int _top_id;
    private string _top_name;
    private int _user_id;
    private string _user_name;
    private int _contrast;

    public int Top_id
    {
      get
      {
        return _top_id;
      }
      set
      {
        __isset.top_id = true;
        this._top_id = value;
      }
    }

    public string Top_name
    {
      get
      {
        return _top_name;
      }
      set
      {
        __isset.top_name = true;
        this._top_name = value;
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

    public int Contrast
    {
      get
      {
        return _contrast;
      }
      set
      {
        __isset.contrast = true;
        this._contrast = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool top_id;
      public bool top_name;
      public bool user_id;
      public bool user_name;
      public bool contrast;
    }

    public TopPlayerResponse() {
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
              Top_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Top_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              User_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              User_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              Contrast = iprot.ReadI32();
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
      TStruct struc = new TStruct("TopPlayerResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.top_id) {
        field.Name = "top_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Top_id);
        oprot.WriteFieldEnd();
      }
      if (Top_name != null && __isset.top_name) {
        field.Name = "top_name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Top_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.user_id) {
        field.Name = "user_id";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(User_id);
        oprot.WriteFieldEnd();
      }
      if (User_name != null && __isset.user_name) {
        field.Name = "user_name";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(User_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.contrast) {
        field.Name = "contrast";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Contrast);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TopPlayerResponse(");
      sb.Append("Top_id: ");
      sb.Append(Top_id);
      sb.Append(",Top_name: ");
      sb.Append(Top_name);
      sb.Append(",User_id: ");
      sb.Append(User_id);
      sb.Append(",User_name: ");
      sb.Append(User_name);
      sb.Append(",Contrast: ");
      sb.Append(Contrast);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
