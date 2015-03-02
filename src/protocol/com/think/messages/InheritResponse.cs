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
  public partial class InheritResponse : TBase
  {
    private byte _type;
    private GeneralInheritResponse _inheritGeneral;
    private GeneralInheritResponse _beInheritGeneral;
    private int _ratio;

    public byte Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public GeneralInheritResponse InheritGeneral
    {
      get
      {
        return _inheritGeneral;
      }
      set
      {
        __isset.inheritGeneral = true;
        this._inheritGeneral = value;
      }
    }

    public GeneralInheritResponse BeInheritGeneral
    {
      get
      {
        return _beInheritGeneral;
      }
      set
      {
        __isset.beInheritGeneral = true;
        this._beInheritGeneral = value;
      }
    }

    public int Ratio
    {
      get
      {
        return _ratio;
      }
      set
      {
        __isset.ratio = true;
        this._ratio = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool inheritGeneral;
      public bool beInheritGeneral;
      public bool ratio;
    }

    public InheritResponse() {
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
              Type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              InheritGeneral = new GeneralInheritResponse();
              InheritGeneral.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              BeInheritGeneral = new GeneralInheritResponse();
              BeInheritGeneral.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Ratio = iprot.ReadI32();
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
      TStruct struc = new TStruct("InheritResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
        oprot.WriteFieldEnd();
      }
      if (InheritGeneral != null && __isset.inheritGeneral) {
        field.Name = "inheritGeneral";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        InheritGeneral.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (BeInheritGeneral != null && __isset.beInheritGeneral) {
        field.Name = "beInheritGeneral";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        BeInheritGeneral.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.ratio) {
        field.Name = "ratio";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Ratio);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("InheritResponse(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",InheritGeneral: ");
      sb.Append(InheritGeneral== null ? "<null>" : InheritGeneral.ToString());
      sb.Append(",BeInheritGeneral: ");
      sb.Append(BeInheritGeneral== null ? "<null>" : BeInheritGeneral.ToString());
      sb.Append(",Ratio: ");
      sb.Append(Ratio);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
