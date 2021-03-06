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
  public partial class TurnplateRankingResponse : TBase
  {
    private int _ranking_id;
    private string _name;
    private int _num;
    private string _award_type;

    public int Ranking_id
    {
      get
      {
        return _ranking_id;
      }
      set
      {
        __isset.ranking_id = true;
        this._ranking_id = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public int Num
    {
      get
      {
        return _num;
      }
      set
      {
        __isset.num = true;
        this._num = value;
      }
    }

    public string Award_type
    {
      get
      {
        return _award_type;
      }
      set
      {
        __isset.award_type = true;
        this._award_type = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool ranking_id;
      public bool name;
      public bool num;
      public bool award_type;
    }

    public TurnplateRankingResponse() {
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
              Ranking_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              Num = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Award_type = iprot.ReadString();
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
      TStruct struc = new TStruct("TurnplateRankingResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.ranking_id) {
        field.Name = "ranking_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Ranking_id);
        oprot.WriteFieldEnd();
      }
      if (Name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Name);
        oprot.WriteFieldEnd();
      }
      if (__isset.num) {
        field.Name = "num";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Num);
        oprot.WriteFieldEnd();
      }
      if (Award_type != null && __isset.award_type) {
        field.Name = "award_type";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Award_type);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("TurnplateRankingResponse(");
      sb.Append("Ranking_id: ");
      sb.Append(Ranking_id);
      sb.Append(",Name: ");
      sb.Append(Name);
      sb.Append(",Num: ");
      sb.Append(Num);
      sb.Append(",Award_type: ");
      sb.Append(Award_type);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
