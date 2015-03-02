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
  public partial class AwardDeleteResponse : TBase
  {
    private byte _award_type;

    public byte Award_type
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
      public bool award_type;
    }

    public AwardDeleteResponse() {
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
              Award_type = iprot.ReadByte();
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
      TStruct struc = new TStruct("AwardDeleteResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.award_type) {
        field.Name = "award_type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Award_type);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AwardDeleteResponse(");
      sb.Append("Award_type: ");
      sb.Append(Award_type);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
