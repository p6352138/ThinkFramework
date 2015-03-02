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
  public partial class ClanKnowledgeUpgradeResponse : TBase
  {
    private ClanKnowledgeResponse _clanKnowledge;
    private long _treasuryMoney;

    public ClanKnowledgeResponse ClanKnowledge
    {
      get
      {
        return _clanKnowledge;
      }
      set
      {
        __isset.clanKnowledge = true;
        this._clanKnowledge = value;
      }
    }

    public long TreasuryMoney
    {
      get
      {
        return _treasuryMoney;
      }
      set
      {
        __isset.treasuryMoney = true;
        this._treasuryMoney = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool clanKnowledge;
      public bool treasuryMoney;
    }

    public ClanKnowledgeUpgradeResponse() {
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
            if (field.Type == TType.Struct) {
              ClanKnowledge = new ClanKnowledgeResponse();
              ClanKnowledge.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              TreasuryMoney = iprot.ReadI64();
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
      TStruct struc = new TStruct("ClanKnowledgeUpgradeResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (ClanKnowledge != null && __isset.clanKnowledge) {
        field.Name = "clanKnowledge";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        ClanKnowledge.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.treasuryMoney) {
        field.Name = "treasuryMoney";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(TreasuryMoney);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanKnowledgeUpgradeResponse(");
      sb.Append("ClanKnowledge: ");
      sb.Append(ClanKnowledge== null ? "<null>" : ClanKnowledge.ToString());
      sb.Append(",TreasuryMoney: ");
      sb.Append(TreasuryMoney);
      sb.Append(")");
      return sb.ToString();
    }

  }

}