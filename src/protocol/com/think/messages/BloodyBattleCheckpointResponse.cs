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
  public partial class BloodyBattleCheckpointResponse : TBase
  {
    private int _dungeonId;
    private string _checkpointName;
    private bool _canfight;
    private bool _hasAward;
    private byte _starLevel;
    private int _progress_num;
    private int _max_num;
    private int _image;
    private string _unlock_desc;

    public int DungeonId
    {
      get
      {
        return _dungeonId;
      }
      set
      {
        __isset.dungeonId = true;
        this._dungeonId = value;
      }
    }

    public string CheckpointName
    {
      get
      {
        return _checkpointName;
      }
      set
      {
        __isset.checkpointName = true;
        this._checkpointName = value;
      }
    }

    public bool Canfight
    {
      get
      {
        return _canfight;
      }
      set
      {
        __isset.canfight = true;
        this._canfight = value;
      }
    }

    public bool HasAward
    {
      get
      {
        return _hasAward;
      }
      set
      {
        __isset.hasAward = true;
        this._hasAward = value;
      }
    }

    public byte StarLevel
    {
      get
      {
        return _starLevel;
      }
      set
      {
        __isset.starLevel = true;
        this._starLevel = value;
      }
    }

    public int Progress_num
    {
      get
      {
        return _progress_num;
      }
      set
      {
        __isset.progress_num = true;
        this._progress_num = value;
      }
    }

    public int Max_num
    {
      get
      {
        return _max_num;
      }
      set
      {
        __isset.max_num = true;
        this._max_num = value;
      }
    }

    public int Image
    {
      get
      {
        return _image;
      }
      set
      {
        __isset.image = true;
        this._image = value;
      }
    }

    public string Unlock_desc
    {
      get
      {
        return _unlock_desc;
      }
      set
      {
        __isset.unlock_desc = true;
        this._unlock_desc = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool dungeonId;
      public bool checkpointName;
      public bool canfight;
      public bool hasAward;
      public bool starLevel;
      public bool progress_num;
      public bool max_num;
      public bool image;
      public bool unlock_desc;
    }

    public BloodyBattleCheckpointResponse() {
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
              DungeonId = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              CheckpointName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              Canfight = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              HasAward = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Byte) {
              StarLevel = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              Progress_num = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Max_num = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              Image = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              Unlock_desc = iprot.ReadString();
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
      TStruct struc = new TStruct("BloodyBattleCheckpointResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.dungeonId) {
        field.Name = "dungeonId";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(DungeonId);
        oprot.WriteFieldEnd();
      }
      if (CheckpointName != null && __isset.checkpointName) {
        field.Name = "checkpointName";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CheckpointName);
        oprot.WriteFieldEnd();
      }
      if (__isset.canfight) {
        field.Name = "canfight";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(Canfight);
        oprot.WriteFieldEnd();
      }
      if (__isset.hasAward) {
        field.Name = "hasAward";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(HasAward);
        oprot.WriteFieldEnd();
      }
      if (__isset.starLevel) {
        field.Name = "starLevel";
        field.Type = TType.Byte;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(StarLevel);
        oprot.WriteFieldEnd();
      }
      if (__isset.progress_num) {
        field.Name = "progress_num";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Progress_num);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_num) {
        field.Name = "max_num";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Max_num);
        oprot.WriteFieldEnd();
      }
      if (__isset.image) {
        field.Name = "image";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Image);
        oprot.WriteFieldEnd();
      }
      if (Unlock_desc != null && __isset.unlock_desc) {
        field.Name = "unlock_desc";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Unlock_desc);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("BloodyBattleCheckpointResponse(");
      sb.Append("DungeonId: ");
      sb.Append(DungeonId);
      sb.Append(",CheckpointName: ");
      sb.Append(CheckpointName);
      sb.Append(",Canfight: ");
      sb.Append(Canfight);
      sb.Append(",HasAward: ");
      sb.Append(HasAward);
      sb.Append(",StarLevel: ");
      sb.Append(StarLevel);
      sb.Append(",Progress_num: ");
      sb.Append(Progress_num);
      sb.Append(",Max_num: ");
      sb.Append(Max_num);
      sb.Append(",Image: ");
      sb.Append(Image);
      sb.Append(",Unlock_desc: ");
      sb.Append(Unlock_desc);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
