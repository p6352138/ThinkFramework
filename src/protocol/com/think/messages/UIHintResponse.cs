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
  public partial class UIHintResponse : TBase
  {
    private byte _showType;
    private int _uiID;
    private byte _index;
    private string _warningContent;
    private string _icon;

    public byte ShowType
    {
      get
      {
        return _showType;
      }
      set
      {
        __isset.showType = true;
        this._showType = value;
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

    public byte Index
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

    public string WarningContent
    {
      get
      {
        return _warningContent;
      }
      set
      {
        __isset.warningContent = true;
        this._warningContent = value;
      }
    }

    public string Icon
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


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool showType;
      public bool uiID;
      public bool index;
      public bool warningContent;
      public bool icon;
    }

    public UIHintResponse() {
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
              ShowType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              UiID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Index = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              WarningContent = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Icon = iprot.ReadString();
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
      TStruct struc = new TStruct("UIHintResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.showType) {
        field.Name = "showType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(ShowType);
        oprot.WriteFieldEnd();
      }
      if (__isset.uiID) {
        field.Name = "uiID";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(UiID);
        oprot.WriteFieldEnd();
      }
      if (__isset.index) {
        field.Name = "index";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Index);
        oprot.WriteFieldEnd();
      }
      if (WarningContent != null && __isset.warningContent) {
        field.Name = "warningContent";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(WarningContent);
        oprot.WriteFieldEnd();
      }
      if (Icon != null && __isset.icon) {
        field.Name = "icon";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Icon);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UIHintResponse(");
      sb.Append("ShowType: ");
      sb.Append(ShowType);
      sb.Append(",UiID: ");
      sb.Append(UiID);
      sb.Append(",Index: ");
      sb.Append(Index);
      sb.Append(",WarningContent: ");
      sb.Append(WarningContent);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
