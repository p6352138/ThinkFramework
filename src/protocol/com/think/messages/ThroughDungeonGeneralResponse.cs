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
  public partial class ThroughDungeonGeneralResponse : TBase
  {
    private int _general_id;
    private int _checkPointsNum;
    private string _generalName;
    private bool _isCanFight;
    private int _imageID;
    private int _strategy_icon;

    public int General_id
    {
      get
      {
        return _general_id;
      }
      set
      {
        __isset.general_id = true;
        this._general_id = value;
      }
    }

    public int CheckPointsNum
    {
      get
      {
        return _checkPointsNum;
      }
      set
      {
        __isset.checkPointsNum = true;
        this._checkPointsNum = value;
      }
    }

    public string GeneralName
    {
      get
      {
        return _generalName;
      }
      set
      {
        __isset.generalName = true;
        this._generalName = value;
      }
    }

    public bool IsCanFight
    {
      get
      {
        return _isCanFight;
      }
      set
      {
        __isset.isCanFight = true;
        this._isCanFight = value;
      }
    }

    public int ImageID
    {
      get
      {
        return _imageID;
      }
      set
      {
        __isset.imageID = true;
        this._imageID = value;
      }
    }

    public int Strategy_icon
    {
      get
      {
        return _strategy_icon;
      }
      set
      {
        __isset.strategy_icon = true;
        this._strategy_icon = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool general_id;
      public bool checkPointsNum;
      public bool generalName;
      public bool isCanFight;
      public bool imageID;
      public bool strategy_icon;
    }

    public ThroughDungeonGeneralResponse() {
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
              General_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              CheckPointsNum = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              GeneralName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              IsCanFight = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              ImageID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Strategy_icon = iprot.ReadI32();
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
      TStruct struc = new TStruct("ThroughDungeonGeneralResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.general_id) {
        field.Name = "general_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(General_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.checkPointsNum) {
        field.Name = "checkPointsNum";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(CheckPointsNum);
        oprot.WriteFieldEnd();
      }
      if (GeneralName != null && __isset.generalName) {
        field.Name = "generalName";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(GeneralName);
        oprot.WriteFieldEnd();
      }
      if (__isset.isCanFight) {
        field.Name = "isCanFight";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsCanFight);
        oprot.WriteFieldEnd();
      }
      if (__isset.imageID) {
        field.Name = "imageID";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ImageID);
        oprot.WriteFieldEnd();
      }
      if (__isset.strategy_icon) {
        field.Name = "strategy_icon";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Strategy_icon);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ThroughDungeonGeneralResponse(");
      sb.Append("General_id: ");
      sb.Append(General_id);
      sb.Append(",CheckPointsNum: ");
      sb.Append(CheckPointsNum);
      sb.Append(",GeneralName: ");
      sb.Append(GeneralName);
      sb.Append(",IsCanFight: ");
      sb.Append(IsCanFight);
      sb.Append(",ImageID: ");
      sb.Append(ImageID);
      sb.Append(",Strategy_icon: ");
      sb.Append(Strategy_icon);
      sb.Append(")");
      return sb.ToString();
    }

  }

}